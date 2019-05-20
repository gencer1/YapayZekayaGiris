namespace yapayZeka
{
    partial class FormErcep
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
            this.components = new System.ComponentModel.Container();
            this.tb_Yazi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_KonusmaGecmisi = new System.Windows.Forms.ListBox();
            this.btn_gonder = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temizleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ercepsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ercepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yönetimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextOkuTimer = new System.Windows.Forms.Timer(this.components);
            this.BtnLikeAt = new System.Windows.Forms.Button();
            this.extreamModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Yazi
            // 
            this.tb_Yazi.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_Yazi.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_Yazi.Location = new System.Drawing.Point(17, 192);
            this.tb_Yazi.Name = "tb_Yazi";
            this.tb_Yazi.Size = new System.Drawing.Size(389, 30);
            this.tb_Yazi.TabIndex = 0;
            this.tb_Yazi.Text = "Bir şeyler yazın...";
            this.tb_Yazi.Enter += new System.EventHandler(this.tb_Yazi_Enter);
            this.tb_Yazi.Leave += new System.EventHandler(this.tb_Yazi_Leave);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(441, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ercep";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_KonusmaGecmisi
            // 
            this.lb_KonusmaGecmisi.FormattingEnabled = true;
            this.lb_KonusmaGecmisi.HorizontalScrollbar = true;
            this.lb_KonusmaGecmisi.ItemHeight = 15;
            this.lb_KonusmaGecmisi.Location = new System.Drawing.Point(17, 58);
            this.lb_KonusmaGecmisi.Name = "lb_KonusmaGecmisi";
            this.lb_KonusmaGecmisi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_KonusmaGecmisi.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lb_KonusmaGecmisi.Size = new System.Drawing.Size(436, 124);
            this.lb_KonusmaGecmisi.TabIndex = 4;
            // 
            // btn_gonder
            // 
            this.btn_gonder.Location = new System.Drawing.Point(412, 193);
            this.btn_gonder.Name = "btn_gonder";
            this.btn_gonder.Size = new System.Drawing.Size(41, 30);
            this.btn_gonder.TabIndex = 1;
            this.btn_gonder.Text = ">>";
            this.btn_gonder.UseVisualStyleBackColor = true;
            this.btn_gonder.Click += new System.EventHandler(this.btn_gonder_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.ercepsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(465, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temizleToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "&Dosya";
            // 
            // temizleToolStripMenuItem
            // 
            this.temizleToolStripMenuItem.Name = "temizleToolStripMenuItem";
            this.temizleToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.temizleToolStripMenuItem.Text = "&Temizle";
            this.temizleToolStripMenuItem.Click += new System.EventHandler(this.temizleToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.çıkışToolStripMenuItem.Text = "&Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // ercepsToolStripMenuItem
            // 
            this.ercepsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ercepToolStripMenuItem,
            this.yönetimToolStripMenuItem,
            this.extreamModToolStripMenuItem});
            this.ercepsToolStripMenuItem.Name = "ercepsToolStripMenuItem";
            this.ercepsToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.ercepsToolStripMenuItem.Text = "&Pencereler";
            // 
            // ercepToolStripMenuItem
            // 
            this.ercepToolStripMenuItem.Name = "ercepToolStripMenuItem";
            this.ercepToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ercepToolStripMenuItem.Text = "&Ercep";
            // 
            // yönetimToolStripMenuItem
            // 
            this.yönetimToolStripMenuItem.Name = "yönetimToolStripMenuItem";
            this.yönetimToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yönetimToolStripMenuItem.Text = "&Yönetim";
            this.yönetimToolStripMenuItem.Click += new System.EventHandler(this.yönetimToolStripMenuItem_Click);
            // 
            // TextOkuTimer
            // 
            this.TextOkuTimer.Interval = 500;
            this.TextOkuTimer.Tick += new System.EventHandler(this.konusma_Tick);
            // 
            // BtnLikeAt
            // 
            this.BtnLikeAt.AutoEllipsis = true;
            this.BtnLikeAt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnLikeAt.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnLikeAt.Image = global::yapayZeka.Properties.Resources.like;
            this.BtnLikeAt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLikeAt.Location = new System.Drawing.Point(304, 12);
            this.BtnLikeAt.Name = "BtnLikeAt";
            this.BtnLikeAt.Size = new System.Drawing.Size(149, 38);
            this.BtnLikeAt.TabIndex = 2;
            this.BtnLikeAt.Text = "Verilen Yanıtı Beğen";
            this.BtnLikeAt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLikeAt.UseCompatibleTextRendering = true;
            this.BtnLikeAt.UseVisualStyleBackColor = true;
            this.BtnLikeAt.Click += new System.EventHandler(this.BtnLikeAt_Click);
            // 
            // extreamModToolStripMenuItem
            // 
            this.extreamModToolStripMenuItem.Name = "extreamModToolStripMenuItem";
            this.extreamModToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.extreamModToolStripMenuItem.Text = "Extream Mod";
            this.extreamModToolStripMenuItem.Click += new System.EventHandler(this.extreamModToolStripMenuItem_Click);
            // 
            // FormErcep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 233);
            this.Controls.Add(this.BtnLikeAt);
            this.Controls.Add(this.btn_gonder);
            this.Controls.Add(this.lb_KonusmaGecmisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Yazi);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormErcep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ercep";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Yazi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lb_KonusmaGecmisi;
        private System.Windows.Forms.Button btn_gonder;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temizleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ercepsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ercepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yönetimToolStripMenuItem;
        private System.Windows.Forms.Button BtnLikeAt;
        public System.Windows.Forms.Timer TextOkuTimer;
        private System.Windows.Forms.ToolStripMenuItem extreamModToolStripMenuItem;
    }
}

