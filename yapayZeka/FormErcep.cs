using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using SpeechLib;
using System.Speech.Synthesis;
using System.Diagnostics;
using System.IO;

namespace yapayZeka
{
    public partial class FormErcep : Form
    {
        MSSQL vt = new MSSQL();
        private SpeechSynthesizer ses = new SpeechSynthesizer();
        private string tb_yaziDefaultText = "Bir şeyler yazın...";

        bool likelanaBilirlik = false;
        string cevapIdText = ""; //Bunu like butonu için tututyorum

        public string konusmaMetni = "";

        public FormErcep()
        {
            InitializeComponent();
            tb_Yazi.Text = tb_yaziDefaultText;
        }
        
        void Ercep() {
            string mesaj = tb_Yazi.Text;
            likelanaBilirlik = false;
            lb_KonusmaGecmisi.Items.Add("Sen : " + mesaj);
            
            //Eski haline döndürüyorum
            tb_Yazi.Text = tb_yaziDefaultText;

            if (mesaj.Length >= 1)
            {
                //String işlemleri
                string metin = mesaj.ToLower().Replace("?", "").Replace("!", "").Trim();

                int baslangicD = metin.LastIndexOf(" ") + 1;
                int bitisD = metin.Length - baslangicD;

                string edat = metin.ToString().Substring(baslangicD,bitisD);

                //Veritabanı iliskisi
                Dictionary<string, object> dic = new Dictionary<string, object>();
                string query = "";

                //Edat kontrol
                string tabloIsmi = "";
                string tabloIndexText = "";
                string kalipVeriIdText = "";

                Dictionary<string, object> edatDic = new Dictionary<string, object>();
                edatDic.Add("edat",edat);
                //DataRow edatDr = vt.GetDataRowWP("Select * From TblKaliplar Where kalipText = @edat",edatDic);
                DataTable edatlar = vt.GetDataTable("Select * From TblKaliplar");
                bool edatIslenmedi = true; //edat işlenmediyse normal konuşma olayları gerçekleşecek

                foreach (DataRow edatDr in edatlar.Rows)
                {
                    if(edat == edatDr["kalipText"].ToString())
                    {
                        if (Convert.ToBoolean(edatDr["kalipOnay"]))
                        {
                            tabloIsmi = edatDr["kalipTablosu"].ToString();
                            tabloIndexText = edatDr["kalipVeriSatiri"].ToString();
                            kalipVeriIdText = edatDr["kalipVeriIdText"].ToString();
                            metin = metin.Replace(edat, "").Trim();
                            //static query olusturma
                            dic.Add("soru", metin);
                            query = "Select * From " + tabloIsmi + " Where " + tabloIndexText + " = @soru";
                            //veri çekme
                            DataRow dr = vt.GetDataRowWP(query, dic);
                            if (dr != null)
                            {
                                konusmaMetni = dr["hakkinda"].ToString();
                                lb_KonusmaGecmisi.Items.Add("Ercep : " + konusmaMetni);
                                TextOkuTimer.Enabled = true;
                                //cevapIdText = dr[kalipVeriIdText].ToString(); Bu like butonu için
                            }
                            else
                            {
                                //Mesajı bilmiyordur
                                dic.Add("kategori", tabloIsmi);
                                dic.Add("text", metin);

                                DataRow returnMesaj = vt.GetDataRowWP("Select islemId From TblYapilamayanIslemler Where islemMetni=@text AND islemKategorisi=@kategori", dic);
                                if (returnMesaj == null)
                                {
                                    vt.cmdWP("Insert Into TblYapilamayanIslemler(islemMetni,islemKategorisi) Values(@text,@kategori)", dic);
                                }

                                konusmaMetni = metin + " ile ilgili bir bilgim yok.";
                                lb_KonusmaGecmisi.Items.Add("Ercep : " + konusmaMetni);
                                TextOkuTimer.Enabled = true;
                            }
                        }
                        else
                        {
                            //edat eklenmiş ama onay verilmemişse buraya giriyor. Sadece yazı yazdırıyorum.
                            konusmaMetni = "Üzgünüm, bu edatı bilmediğim için işlem yapamıyorum.";
                            lb_KonusmaGecmisi.Items.Add("Ercep : " + konusmaMetni);
                            TextOkuTimer.Enabled = true;
                        }

                        edatIslenmedi = false; //Burada edat işlenmiştir ve soru cevaplanmış veya cevaplanmamıştır.b
                        break;
                    }
                }

                //Edat işlenmediyse ya edatı bilmiyordur ya da norma bir şey yazmıştır.
                if (edatIslenmedi)
                {
                    //Öncelikle diyalog mu diye bakıyorum.
                    dic.Add("diyalog", metin);
                    DataRow reDiyalog = vt.GetDataRowWP("Select * From TblDiyalog WHERE diyalogId=(Select toDiyalogId From TblToDiyalog WHERE diyalogId=(select diyalogId From TblDiyalog Where diyalogText=@diyalog) AND toDiyalogPuan=(select max(toDiyalogPuan) From TblToDiyalog Where diyalogId=(select diyalogId From TblDiyalog Where diyalogText=@diyalog)))", dic);

                    if (reDiyalog != null)//Buraya girerse bu bir diyalogtur
                    {
                        konusmaMetni = reDiyalog["diyalogText"].ToString();
                        cevapIdText = reDiyalog["diyalogId"].ToString(); //Like için
                        likelanaBilirlik = true;
                        lb_KonusmaGecmisi.Items.Add("Ercep : " + konusmaMetni);
                    }
                    else
                    {
                        //Buraya girdiyse edatı bilmiyordur veya diyaloğu
                        dic.Add("edat", edat);
                        vt.cmdWP("Insert Into TblKaliplar(kalipText) Values(@edat)", dic);//edat sorulacaklara ekleniyor

                        vt.cmdWP("Insert Into TblKaliplar(kalipText) Values(@diyalog)", dic);//metin de ekleniyor

                        konusmaMetni = "Üzgünüm, ne demek istediğini anlamadım.";
                        lb_KonusmaGecmisi.Items.Add("Ercep : " + konusmaMetni);
                    }
                    TextOkuTimer.Enabled = true;
                }

                //if (edatIslenmedi)
                //{
                //    Dictionary<string, object> diyalogDic = new Dictionary<string, object>();
                //    diyalogDic.Add("diyalogText",mesaj);

                //    DataRow mesajResult = vt.GetDataRowWP("Select diyalogId From TblDiyalog Where diyalogText=@diyalogText",diyalogDic);


                //}

            }
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
        private void btn_gonder_Click(object sender, EventArgs e)
        {
            Ercep();
        }
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_KonusmaGecmisi.Items.Clear();
        }
        private void yönetimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGiris _formGiris = new FormGiris();
            _formGiris.FormYonlendirme = "YonetimFormu";
            _formGiris.ShowDialog();
        }
        //End form eventları
        public void Komutlar(string islem) {
            switch (islem)
            {
                case "programı kapat":
                    Application.Exit();
                    break;
            }
        }
        void TextOku() {
            //SpVoice oku = new SpVoice();

            //oku.Speak("my name is Ercep");

            //speech.Volume = 80;
            //speech.Rate = -2;


            //-----ses.SelectVoice("eSpeak-tr");
            ses.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Senior);
            ses.Volume = 100;
            ses.Rate = -1;


            //BURAYI SES DUYMAK İSTEDİĞİNDE AÇ-******************************************************
            ses.SpeakAsync(konusmaMetni);

            TextOkuTimer.Enabled = false;
        }
        private void konusma_Tick(object sender, EventArgs e)
        {
            TextOku();
        }
        private void BtnLikeAt_Click(object sender, EventArgs e)
        {
            #region hocam burası karanlık işler için o yüzden şimdilik iptal
            ////cevapIdText değişkenini burada kullanıcam
            //ProcessStartInfo start = new ProcessStartInfo();
            //start.FileName = "C:\\Python27\\python.exe";
            ////start.Arguments = string.Format("{0} {1}", cmd, args);
            //start.Arguments = string.Concat("deneme.py", " ", 1.ToString(), " ", 2.ToString());
            //start.UseShellExecute = false;
            //start.RedirectStandardOutput = true;
            //using (Process process = Process.Start(start))
            //{
            //    using (StreamReader reader = process.StandardOutput)
            //    {
            //        string result = reader.ReadToEnd();
            //        Console.Write(result);
            //    }
            //}
            #endregion

            try
            {
                if (likelanaBilirlik)
                {
                    Dictionary<string, object> likeDic = new Dictionary<string, object>();
                    likeDic.Add("diyalogId", cevapIdText);

                    DataRow toDiyalogRow = vt.GetDataRowWP("Select * From TblToDiyalog Where toDiyalogId=@diyalogId AND toDiyalogPuan=(Select max(toDiyalogPuan) From TblToDiyalog Where toDiyalogId=@diyalogId)", likeDic);
                    double puan = 0;
                    if (toDiyalogRow != null)
                    {
                        puan = Convert.ToDouble(toDiyalogRow["toDiyalogPuan"].ToString()) + 0.2;
                        likeDic.Add("puan", puan);
                        likeDic.Add("diyalogToId", toDiyalogRow["diyalogToId"].ToString());
                        vt.cmdWP("UPDATE TblToDiyalog SET toDiyalogPuan=@puan WHERE toDiyalogId=@diyalogId", likeDic);
                        MessageBox.Show(";)");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yanıt beğenme sırasında hata ile karşılaşıldı! \n\r"+ex.Message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void extreamModToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGiris _formGiris = new FormGiris();
            _formGiris.FormYonlendirme = "ExtreamModFormu";
            _formGiris.ShowDialog();
        }
    }
}
