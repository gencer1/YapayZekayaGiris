namespace yapayZeka
{
    partial class FormYonetim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageSoruCevap = new System.Windows.Forms.TabPage();
            this.btn_gonder = new System.Windows.Forms.Button();
            this.tb_Yazi = new System.Windows.Forms.TextBox();
            this.lbKonusmaGemisi = new System.Windows.Forms.ListBox();
            this.tabPageCevapEkle = new System.Windows.Forms.TabPage();
            this.tbAciklama_Ekle = new System.Windows.Forms.TextBox();
            this.tbKey_Ekle = new System.Windows.Forms.TextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblAnahtar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbKategori_Ekle = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl.SuspendLayout();
            this.tabPageSoruCevap.SuspendLayout();
            this.tabPageCevapEkle.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageSoruCevap);
            this.tabControl.Controls.Add(this.tabPageCevapEkle);
            this.tabControl.Location = new System.Drawing.Point(3, 29);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(542, 277);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageSoruCevap
            // 
            this.tabPageSoruCevap.Controls.Add(this.btn_gonder);
            this.tabPageSoruCevap.Controls.Add(this.tb_Yazi);
            this.tabPageSoruCevap.Controls.Add(this.lbKonusmaGemisi);
            this.tabPageSoruCevap.Location = new System.Drawing.Point(4, 24);
            this.tabPageSoruCevap.Name = "tabPageSoruCevap";
            this.tabPageSoruCevap.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSoruCevap.Size = new System.Drawing.Size(534, 249);
            this.tabPageSoruCevap.TabIndex = 1;
            this.tabPageSoruCevap.Text = "Soru Cevap";
            this.tabPageSoruCevap.UseVisualStyleBackColor = true;
            // 
            // btn_gonder
            // 
            this.btn_gonder.Location = new System.Drawing.Point(484, 212);
            this.btn_gonder.Name = "btn_gonder";
            this.btn_gonder.Size = new System.Drawing.Size(44, 30);
            this.btn_gonder.TabIndex = 5;
            this.btn_gonder.Text = ">>";
            this.btn_gonder.UseVisualStyleBackColor = true;
            this.btn_gonder.Click += new System.EventHandler(this.btn_gonder_Click);
            // 
            // tb_Yazi
            // 
            this.tb_Yazi.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_Yazi.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_Yazi.Location = new System.Drawing.Point(8, 211);
            this.tb_Yazi.Name = "tb_Yazi";
            this.tb_Yazi.Size = new System.Drawing.Size(470, 30);
            this.tb_Yazi.TabIndex = 1;
            this.tb_Yazi.Text = "Cevabınızı Yazın.";
            this.tb_Yazi.Enter += new System.EventHandler(this.tb_Yazi_Enter);
            this.tb_Yazi.Leave += new System.EventHandler(this.tb_Yazi_Leave);
            // 
            // lbKonusmaGemisi
            // 
            this.lbKonusmaGemisi.FormattingEnabled = true;
            this.lbKonusmaGemisi.ItemHeight = 15;
            this.lbKonusmaGemisi.Location = new System.Drawing.Point(8, 6);
            this.lbKonusmaGemisi.Name = "lbKonusmaGemisi";
            this.lbKonusmaGemisi.Size = new System.Drawing.Size(520, 199);
            this.lbKonusmaGemisi.TabIndex = 0;
            // 
            // tabPageCevapEkle
            // 
            this.tabPageCevapEkle.Controls.Add(this.tbAciklama_Ekle);
            this.tabPageCevapEkle.Controls.Add(this.tbKey_Ekle);
            this.tabPageCevapEkle.Controls.Add(this.btnTemizle);
            this.tabPageCevapEkle.Controls.Add(this.lblAciklama);
            this.tabPageCevapEkle.Controls.Add(this.btnEkle);
            this.tabPageCevapEkle.Controls.Add(this.lblAnahtar);
            this.tabPageCevapEkle.Controls.Add(this.label1);
            this.tabPageCevapEkle.Controls.Add(this.cbKategori_Ekle);
            this.tabPageCevapEkle.Location = new System.Drawing.Point(4, 24);
            this.tabPageCevapEkle.Name = "tabPageCevapEkle";
            this.tabPageCevapEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCevapEkle.Size = new System.Drawing.Size(534, 249);
            this.tabPageCevapEkle.TabIndex = 0;
            this.tabPageCevapEkle.Text = "Ekle";
            this.tabPageCevapEkle.UseVisualStyleBackColor = true;
            // 
            // tbAciklama_Ekle
            // 
            this.tbAciklama_Ekle.Location = new System.Drawing.Point(196, 103);
            this.tbAciklama_Ekle.Multiline = true;
            this.tbAciklama_Ekle.Name = "tbAciklama_Ekle";
            this.tbAciklama_Ekle.Size = new System.Drawing.Size(287, 73);
            this.tbAciklama_Ekle.TabIndex = 3;
            // 
            // tbKey_Ekle
            // 
            this.tbKey_Ekle.Location = new System.Drawing.Point(196, 61);
            this.tbKey_Ekle.Name = "tbKey_Ekle";
            this.tbKey_Ekle.Size = new System.Drawing.Size(287, 23);
            this.tbKey_Ekle.TabIndex = 3;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(66, 194);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(108, 38);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            // 
            // lblAciklama
            // 
            this.lblAciklama.Location = new System.Drawing.Point(32, 102);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(142, 23);
            this.lblAciklama.TabIndex = 1;
            this.lblAciklama.Text = "Eklenecek Değer :";
            this.lblAciklama.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(373, 194);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(110, 38);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblAnahtar
            // 
            this.lblAnahtar.Location = new System.Drawing.Point(32, 60);
            this.lblAnahtar.Name = "lblAnahtar";
            this.lblAnahtar.Size = new System.Drawing.Size(142, 23);
            this.lblAnahtar.TabIndex = 1;
            this.lblAnahtar.Text = "Eklenecek Ad Soyad :";
            this.lblAnahtar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(32, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eklenecek Kategori : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbKategori_Ekle
            // 
            this.cbKategori_Ekle.FormattingEnabled = true;
            this.cbKategori_Ekle.Items.AddRange(new object[] {
            "Kişi",
            "Cisim",
            "Komut"});
            this.cbKategori_Ekle.Location = new System.Drawing.Point(196, 15);
            this.cbKategori_Ekle.Name = "cbKategori_Ekle";
            this.cbKategori_Ekle.Size = new System.Drawing.Size(287, 23);
            this.cbKategori_Ekle.TabIndex = 0;
            this.cbKategori_Ekle.SelectedIndexChanged += new System.EventHandler(this.cbKategori_Ekle_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(542, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kapatToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            this.yardımToolStripMenuItem.Click += new System.EventHandler(this.yardımToolStripMenuItem_Click);
            // 
            // FormYonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 318);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormYonetim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetim Paneli";
            this.Load += new System.EventHandler(this.FormYonetim_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageSoruCevap.ResumeLayout(false);
            this.tabPageSoruCevap.PerformLayout();
            this.tabPageCevapEkle.ResumeLayout(false);
            this.tabPageCevapEkle.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageCevapEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbKategori_Ekle;
        private System.Windows.Forms.TabPage tabPageSoruCevap;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblAnahtar;
        private System.Windows.Forms.TextBox tbKey_Ekle;
        private System.Windows.Forms.TextBox tbAciklama_Ekle;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.ListBox lbKonusmaGemisi;
        private System.Windows.Forms.TextBox tb_Yazi;
        private System.Windows.Forms.Button btn_gonder;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
    }
}