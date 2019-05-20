using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yapayZeka
{
    public partial class FormYonetim : Form
    {
        VeriYonetim vy = new VeriYonetim();
        MSSQL vt = new MSSQL();
        private string tb_yaziDefaultText = "Cevabınızı Yazın.";
        private bool onay = false;
        private bool cevap = false;
        private bool diyalogOgren = false;

        #region Sorulan Soru Değişkenleri
        string tabloIsmi = "";
        string soruSorugu = "";
        int sorulanSoruId;
        
        #endregion

        public FormYonetim()
        {
            InitializeComponent();
        }
        private void cbKategori_Ekle_SelectedIndexChanged(object sender, EventArgs e)
        {
            int _index = cbKategori_Ekle.SelectedIndex;

            if (_index == 0) { //Kişi
                lblAnahtar.Text = "Eklenecek Kişinin Adı Soyadı : ";
                lblAciklama.Text = "Eklenecek Kişi Hakkında : ";
            }
            else if(_index == 1) //Cisim
            {
                lblAnahtar.Text = "Eklenecek Cismin İsmi : ";
                lblAciklama.Text = "Eklenecek Cisim Hakkında : ";
            }
            else if(_index ==2) //Komut
            {
                lblAnahtar.Text = "Eklenecek Komutun Index Numarası : ";
                lblAciklama.Text = "Eklenecek Komut Açıklaması : ";
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (vy.YeniVeriEkle(cbKategori_Ekle.SelectedIndex, tbKey_Ekle.Text, tbAciklama_Ekle.Text)) {
                MessageBox.Show("Ekleme işlemi başarıyla gerçekleşti","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ekleme sırasında hata oluştu", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_gonder_Click(object sender, EventArgs e)
        {
            if (!cevap) //Cevaplanmıyorsa soru soracak
            {
                
                if (!onay)
                {
                    onay = OnayKontrol();
                    if (onay)
                    {
                        cevap = true;
                        SoruSor();
                    }
                    else
                    {
                        Erceps("Bu şekilde ilerleyemeyiz ;)");
                    }
                }
                else
                {
                    cevap = true;
                    SoruSor();
                }
                
            }
            else //Cevap trueysa cevap bekliyordur.
            {
                Ogren();
            }


            tb_Yazi.Text = tb_yaziDefaultText;
        }
        private void Ogren(){
            try
            {
                string cevapT = tb_Yazi.Text.Trim();
                Siz(cevapT);

                Dictionary<string, object> cevapDic = new Dictionary<string, object>();
                cevapDic.Add("soruId", sorulanSoruId);

                if (diyalogOgren)
                {//Diyalog öğrenecek
                    #region Aşamalar
                    //cevap diyalogta varmı
                    //varsa todiyaloga onun idsiyle kaydet
                    //yoksa to diyaloga onu kaydet sonra id döndür
                    #endregion
                    cevapDic.Add("cevapText", cevapT);
                    DataRow cevapDR = vt.GetDataRowWP("Select * From TblDiyalog Where diyalogText=@cevapText", cevapDic);
                    if(cevapDR == null)
                    {//cevap diyaloglarda yoktur
                        vt.cmdWP("Insert Into TblDiyalog(diyalogText) Values(@cevapText)",cevapDic);
                        string newCevapId = vt.GetDataRowWP("Select diyalogId From TblDiyalog Where diyalogText=@cevapText",cevapDic)["diyalogId"].ToString();
                        cevapDic.Add("newCevapId",newCevapId);
                        vt.cmdWP("Insert Into TblToDiyalog(diyalogId,toDiyalogId) Values(@soruId,@newCevapId)",cevapDic);
                    }
                    else
                    {//cevap diyaloglarda vardır
                        cevapDic.Add("toDiyalogId", cevapDR["diyalogId"].ToString());
                        vt.cmdWP("Insert Into TblToDiyalog(diyalogId,toDiyalogId) Values(@soruId,@toDiyalogId)", cevapDic);
                    }

                    //Son olarak öğrenilen diyaloğun kontrol değişkeni True olacak
                    vt.cmdWP("Update TblDiyalog Set diyalogOnay='True' WHERE diyalogId=@soruId", cevapDic);


                    diyalogOgren = false;//Öğrendiyse bunu false yapmak gerek
                }
                else
                {//Kimdir nedir gibi şeyleri öğrenecek
                    string queryStr = "";
                    

                    if (cevapT.ToLower() != "öğrenmek için uygun değildir")
                    {
                        switch (tabloIsmi)
                        {
                            case "TblKimdir":
                                cevapDic.Add("hakkinda", cevapT);
                                cevapDic.Add("adiSoyadi", soruSorugu);
                                queryStr = "TblKimdir(adiSoyadi,hakkinda) Values(@adiSoyadi,@hakkinda)";
                                break;
                            case "TblNedir":
                                cevapDic.Add("hakkinda", cevapT);
                                cevapDic.Add("isim", soruSorugu);
                                queryStr = "TblNedir(isim,hakkinda) Values(@isim,@hakkinda)";
                                break;
                        }

                        vt.cmdWP("Insert Into " + queryStr, cevapDic);
                    }
                    //Kaydettikten sonra onu siliyorum.
                    vt.cmdWP("Delete From TblYapilamayanIslemler Where islemId=@soruId", cevapDic);
                }
                SoruSor();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void Erceps(string yazi) {
            FormErcep ercep = new FormErcep();
            ercep.konusmaMetni = yazi;
            ercep.TextOkuTimer.Enabled = true;

            lbKonusmaGemisi.Items.Add("Erceps : " + yazi);
        }
        private void Siz(string yazi)
        {
            lbKonusmaGemisi.Items.Add("Sen : " + yazi);
        }
        private void SoruSor() {
            
            string soruText = "";
            bool hatami = true;

            try
            {
                DataRow soru = vt.GetDataRow("Select * From TblYapilamayanIslemler Where islemId = (Select min(islemId) From TblYapilamayanIslemler)");
                if (soru == null) {
                    hatami = false;
                }
                tabloIsmi = soru["islemKategorisi"].ToString();
                soruText = soru["islemMetni"].ToString();
                sorulanSoruId = Convert.ToInt16(soru["islemId"].ToString());

                //Kayıt için bellekte tutulan
                soruSorugu = soruText;
                switch (tabloIsmi)
                {
                    case "TblKimdir":
                        soruText = soruText + " kimdir?";
                        break;
                    case "TblNedir":
                        soruText = soruText + " nedir?";
                        break;
                }

                Erceps(soruText);

            }
            catch (Exception ex)
            {
                if (!hatami)
                { //hata değilse yapılamayan işlemlerde bişey kalmamıştır.
                    DataRow edatSoru = vt.GetDataRow("Select * From TblKaliplar Where kalipId = (Select min(kalipId) From TblKaliplar Where kalipOnay = 'False')");
                    if (edatSoru != null)
                    {
                        string edat = edatSoru["kalipText"].ToString();
                        Erceps(edat + " edatı hangi tablo ile ilişkili?");
                        EdatOgrenForm ogrenFormu = new EdatOgrenForm();
                        ogrenFormu.lbl_Edat.Text = edat;
                        ogrenFormu.ShowDialog();

                       
                        Dictionary<string, object> dic = new Dictionary<string, object>();
                        dic.Add("kalipId", edatSoru["kalipId"]);

                        if (VeriModel.edatOgrenTblText == "IslemSil")//Yanlış kaydediilmiş edattır ve siler
                        {
                            vt.cmdWP("DELETE FROM TblKaliplar Where kalipId=@kalipId", dic);
                            SoruSor();
                        }
                        else if (VeriModel.edatOgrenTblText == "IslemIptal") //İşlem iptalse hiçbir şey yapamaz
                        {
                            Erceps("Teşekkürler. Şimdilik bu kadar yeter.");
                        }else if (VeriModel.edatOgrenTblText == "DiyalogOgren")
                        {//Buraya girerse diyalogtur
                            vt.cmdWP("DELETE FROM TblKaliplar Where kalipId=@kalipId", dic);//Edatlardan siliyorum
                            dic.Add("diyalogText", edat);//edat sandığı şeyi dic ekliyorum
                            vt.cmdWP("Insert Into TblDiyalog(diyalogText) Values(@diyalogText)",dic);//diyaloğa kaydediyorum
                            SoruSor();
                        }
                        else//İşlem iptal değilse olaya devam eder
                        {
                            switch (VeriModel.edatOgrenTblText)
                            {
                                case "TblKimdir":
                                    dic.Add("kVS", "adiSoyadi");
                                    dic.Add("kVIT", "kimdirId");
                                    break;
                                case "TblNedir":
                                    dic.Add("kVS", "isim");
                                    dic.Add("kVIT", "nedirId");
                                    break;
                            }


                            dic.Add("kalipTablosu", VeriModel.edatOgrenTblText);

                            vt.cmdWP("Update TblKaliplar SET kalipTablosu=@kalipTablosu,kalipVeriSatiri=@kVS,kalipVeriIdText=@kVIT,kalipOnay='True' WHERE kalipId=@kalipId", dic);
                            SoruSor();
                        }

                        
                    }
                    else //Buraya geldiyse diyalog kontrol edicem
                    {
                        DataRow diyalogSoru = vt.GetDataRow("Select * From TblDiyalog Where diyalogId = (Select min(diyalogId) From TblDiyalog Where diyalogOnay='False')");
                        if (diyalogSoru != null)
                        {//Buraya girerse diyalog la ilgili işlemler yapıcam
                            soruText = diyalogSoru["diyalogText"].ToString() + " dersem bana ne cevap verirsin?";
                            sorulanSoruId = Convert.ToInt16(diyalogSoru["diyalogId"].ToString());
                            diyalogOgren = true;
                            Erceps(soruText);
                        }
                        else
                        {//Buraya girerse soracağı bir şey yoktur
                            Erceps("Teşekkür ederim soracağım soru kalmadı :)"); //Buraya teşekkür cümlelerinden biri gelecek vt den
                        }
                    }
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        private bool OnayKontrol() {
            string cevapT = tb_Yazi.Text.Trim();
            Siz(cevapT);
            cevapT = cevapT.ToLower();

            DataTable onayCDt = vt.GetDataTable("select * From TblYardimciOgeler Where ogeKategoriId = 1");

            foreach(DataRow onayCml in onayCDt.Rows)
            {
                if (cevapT == onayCml["ogeText"].ToString())
                {
                    return Convert.ToBoolean(onayCml["degeri"]);
                }
            }

            return false;
            
        }
        
        //Form Kontrolleri
        private void FormYonetim_Load(object sender, EventArgs e)
        {
            Erceps("Size bir kaç soru sorabilir miyim?");
        }
        private void tb_Yazi_Leave(object sender, EventArgs e)
        {
            tb_Yazi.ForeColor = Color.Silver;

            if (tb_Yazi.Text == "")
            {
                tb_Yazi.Text = tb_yaziDefaultText;
            }
        }
        private void tb_Yazi_Enter(object sender, EventArgs e)
        {
            tb_Yazi.ForeColor = Color.Black;

            if (tb_Yazi.Text == tb_yaziDefaultText)
            {
                tb_Yazi.Text = "";
            }
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorduğu soruyu unutması için : öğrenmek için uygun değildir yazılmalıdır.", "Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
