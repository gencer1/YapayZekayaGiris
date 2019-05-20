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
    public partial class FormGiris : Form
    {
        public string FormYonlendirme = "";
        public FormGiris()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            VeriYonetim vy = new VeriYonetim();

            if (vy.KullaniciGiris(tbKullaniciAdi.Text, tbSifre.Text)) {
                if (FormYonlendirme == "YonetimFormu")
                {
                    FormYonetim frmYonetim = new FormYonetim();
                    frmYonetim.ShowDialog();
                    FormYonlendirme = "";
                    this.Hide();
                }else if(FormYonlendirme == "ExtreamModFormu")
                {
                    ExtreamModFormu exForm = new ExtreamModFormu();
                    exForm.ShowDialog();
                    FormYonlendirme = "";
                    this.Hide();
                }
                else
                {
                    lblDurum.Text = "Geçerli Sayfaya İlerlenemiyor.";
                }
            }
            else
            {
                lblDurum.Text = "Kullanıcı adınız veya şifreniz yanlış !";
            }
        }

        private void FormGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormYonetim yonetimFormu = new FormYonetim();
            yonetimFormu.Close();
            this.Close();
        }

        private void tbKullaniciAdi_Enter(object sender, EventArgs e)
        {
            lblDurum.Text = "";
        }
    }
}
