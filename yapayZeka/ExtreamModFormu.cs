using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yapayZeka
{
    public partial class ExtreamModFormu : Form
    {
        private string tbYaziDefaultText = "Yapmak istediğiniz işlemi yazın...";
        MSSQL vt = new MSSQL();

        #region Komut İşleme Değişkenleri
        DataTable komutDiyaloglari;
        int islenmesiGereken = 0; //Bu ve altındaki değişken veri almayı kolaylaştırmak için.
        int islenen = 0;
        string kodBlogu = "";
        bool cevaplaniyor = false;
        bool veriAlinacak = false;
        #endregion

        #region Kod Çalıştırma Ve Kaydetme Değişkenleri
        private string dosyaIsmi = "deneme";
        #endregion

        //Form Load da Çağırılıyor
        private void AcilisAyarlari() {
            tb_Yazi.Text = tbYaziDefaultText;
            tb_Yazi.ForeColor = Color.Silver;
        }

        //İşle Butonundan Çağırılıyor.
        private void KodIsle() {
            string girilenKomut = tb_Yazi.Text.ToLower().Trim();
            Sen(girilenKomut);//konuşma geçmişi için

            try
            {
                Dictionary<string, object> komutDic = new Dictionary<string, object>();
                komutDic.Add("komutText", girilenKomut);

                DataRow komut = vt.GetDataRowWP("Select * From TblKomutlar Where komutText=@komutText",komutDic);

                if (komut != null) { //Girilen komut bulunmuştur
                    kodBlogu = komut["komutKod"].ToString();

                    Dictionary<string, object> komutDiyalogDic = new Dictionary<string, object>();
                    komutDiyalogDic.Add("komutId",komut["komutId"].ToString());

                    komutDiyaloglari = vt.GetDataTableWP("Select * From TblKomutDiyaloglari Where komutDiyalogId In(Select komutDiyalogId From TblKomutToDiyalog Where komutId=@komutId)", komutDiyalogDic);
                    
                    if(komutDiyaloglari.Rows.Count > 0)
                    {
                        //foreach (DataRow diyalog in komutDiyaloglari.Rows)
                        //{
                        //    MessageBox.Show(diyalog["diyalogText"].ToString());   
                        //}
                        islenmesiGereken = komutDiyaloglari.Rows.Count;
                        veriAlinacak = true;
                        KodIstekleri();
                    }

                }
                else
                {//Buraya girdiyse veritababnında girilen komut bulunamamıştır.
                    MessageBox.Show("Komut Bulunamadı. Lütfen Yazdığınız Komutu Kontrol Edin.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu. \n Hata:"+ex.Message,"Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        //Bu fonksiyon kod işlenmesi ve kaydedilmesi için gerekli
        private void KodIstekleri() {

            if (cevaplaniyor) //Cevaplanıyorsa cevap alınacaktır
            {
                string girilenKomut = tb_Yazi.Text;
                Sen(girilenKomut);
                kodBlogu = kodBlogu.Replace(komutDiyaloglari.Rows[islenen]["diyalogReplaceText"].ToString(), girilenKomut);
                cevaplaniyor = false;
                islenen++;
            }

            VeriAl();
        }

        private void VeriAl() {

            if (!(islenmesiGereken <= 0))//İşlenmesi gereken veri varsa işleme devam edecek.(soru soracak)
            {
                Ercep(komutDiyaloglari.Rows[islenen]["diyalogText"].ToString());
                cevaplaniyor = true;
                islenmesiGereken--;
            }
            else //
            {
                veriAlinacak = false;
                //MessageBox.Show(kodBlogu);//Bruada kodu oluştuup çalıştırmaya başlayacak
                rTBOnIzleme.Text = kodBlogu;
            }
        }

        //Bu fonksiyon konuşma geçmişine bizim yazdıklarımızı kaydetmeye yarıyor.
        private void Sen(string yazi) {
            lb_KonusmaGecmisi.Items.Add("Sen : " + yazi);
        }

        private void Ercep(string yazi)
        {
            lb_KonusmaGecmisi.Items.Add("Ercep : " + yazi);
        }

        //private void KodYazdir() { //Düzenlenecek

        //    //Önce var olan kodu alıp üzerine REPLACE uygulayıp tekrar kaydetmem gerekiyor.
        //    //string veriYol = Environment.CurrentDirectory + "deneme.py";
        //    //dosyaYaz = File.AppendText(veriYol);
        //    //bilgi = tbAd.Text + "," + tbSoyad.Text + "," + cmbDogYer.Text;
        //    //dosyaYaz.WriteLine(bilgi);

        //    KodCalistir(); //Yazdırma işlemi bitince çalıştırmak için çağırıyorum
        //}

        private void btnKodCalistir_Click(object sender, EventArgs e)
        {            
            //Ses komutlarını da çalıştırmayı unutma

            KoduKaydet(); //Öncelikle kodu kaydediyorum (kaydettiğim yoluda ramde tutuyorum)
            KodCalistir(); //Sonra yolunu bildiğim kodu  python shelle gönderiyorum
        }

        private void KoduKaydet()
        {
            //SaveFileDialog dosyaKaydet = new SaveFileDialog();

            //dosyaKaydet.Title = "Dosya Adını Giriniz";
            //dosyaKaydet.Filter = "Python |*.py|Tümü|*.*";
            //dosyaKaydet.FilterIndex = 0;
            //if (dosyaKaydet.ShowDialog() == DialogResult.OK)
            //{
            //    rTBOnIzleme.SaveFile(dosyaKaydet.FileName, RichTextBoxStreamType.PlainText);
            //    dosyaKonum = dosyaKaydet.FileName;
            //    MessageBox.Show("Dosya Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

            rTBOnIzleme.SaveFile(dosyaIsmi+".py", RichTextBoxStreamType.PlainText);
            MessageBox.Show("Dosya Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void KodCalistir() {
            //cevapIdText değişkenini burada kullanıcam
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "C:\\Python27\\python.exe";
            //start.Arguments = string.Format("{0} {1}", cmd, args);
            start.Arguments = dosyaIsmi+".py";  //string.Concat("deneme.py", " ",1.ToString(),2.ToString());
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    MessageBox.Show(result);
                }
            }
        }

        #region Form Eventları
        public ExtreamModFormu()
        {
            InitializeComponent();
        }
        private void ExtreamModFormu_Load(object sender, EventArgs e)
        {
            AcilisAyarlari();
        }
        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tb_Yazi_Enter(object sender, EventArgs e)
        {
            tb_Yazi.Text = "";
            tb_Yazi.ForeColor = Color.Black;

        }

        private void tb_Yazi_Leave(object sender, EventArgs e)
        {
            tb_Yazi.ForeColor = Color.Silver;
        }

        private void btn_Isle_Click(object sender, EventArgs e)
        {
            if (veriAlinacak)
            {
                KodIstekleri();
            }
            else
            {
                KodIsle();
            }
            tb_Yazi.Text = tbYaziDefaultText;
        }

        private void btnKodAc_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosyaAc = new OpenFileDialog();

            dosyaAc.Title = "Python Kodu Seçin";
            dosyaAc.Filter = "Python |*.py| Tümü|*.*";
            dosyaAc.FilterIndex = 0;

            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                rTBOnIzleme.LoadFile(dosyaAc.FileName, RichTextBoxStreamType.PlainText);
            }
        }
        #endregion
        
    }
}
