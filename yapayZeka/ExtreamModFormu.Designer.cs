namespace yapayZeka
{
    partial class ExtreamModFormu
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
            this.btn_Isle = new System.Windows.Forms.Button();
            this.lb_KonusmaGecmisi = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Yazi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ercepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rTBOnIzleme = new System.Windows.Forms.RichTextBox();
            this.pnlOnIzleme = new System.Windows.Forms.Panel();
            this.btnKodCalistir = new System.Windows.Forms.Button();
            this.btnKodAc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlOnIzleme.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Isle
            // 
            this.btn_Isle.Location = new System.Drawing.Point(355, 285);
            this.btn_Isle.Name = "btn_Isle";
            this.btn_Isle.Size = new System.Drawing.Size(41, 30);
            this.btn_Isle.TabIndex = 6;
            this.btn_Isle.Text = ">>";
            this.btn_Isle.UseVisualStyleBackColor = true;
            this.btn_Isle.Click += new System.EventHandler(this.btn_Isle_Click);
            // 
            // lb_KonusmaGecmisi
            // 
            this.lb_KonusmaGecmisi.FormattingEnabled = true;
            this.lb_KonusmaGecmisi.HorizontalScrollbar = true;
            this.lb_KonusmaGecmisi.Location = new System.Drawing.Point(13, 64);
            this.lb_KonusmaGecmisi.Name = "lb_KonusmaGecmisi";
            this.lb_KonusmaGecmisi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_KonusmaGecmisi.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lb_KonusmaGecmisi.Size = new System.Drawing.Size(383, 212);
            this.lb_KonusmaGecmisi.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(13, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ercep";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_Yazi
            // 
            this.tb_Yazi.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_Yazi.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_Yazi.Location = new System.Drawing.Point(13, 284);
            this.tb_Yazi.Name = "tb_Yazi";
            this.tb_Yazi.Size = new System.Drawing.Size(325, 30);
            this.tb_Yazi.TabIndex = 5;
            this.tb_Yazi.Text = "Yapmak istediğiniz işlemi yazın...";
            this.tb_Yazi.Enter += new System.EventHandler(this.tb_Yazi_Enter);
            this.tb_Yazi.Leave += new System.EventHandler(this.tb_Yazi_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(98, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "ex mod";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ercepToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(797, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ercepToolStripMenuItem
            // 
            this.ercepToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışToolStripMenuItem});
            this.ercepToolStripMenuItem.Name = "ercepToolStripMenuItem";
            this.ercepToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.ercepToolStripMenuItem.Text = "Ercep";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.çıkışToolStripMenuItem.Text = "Kapat";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // rTBOnIzleme
            // 
            this.rTBOnIzleme.Location = new System.Drawing.Point(15, 31);
            this.rTBOnIzleme.Name = "rTBOnIzleme";
            this.rTBOnIzleme.Size = new System.Drawing.Size(341, 250);
            this.rTBOnIzleme.TabIndex = 11;
            this.rTBOnIzleme.Text = "";
            // 
            // pnlOnIzleme
            // 
            this.pnlOnIzleme.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlOnIzleme.Controls.Add(this.btnKodCalistir);
            this.pnlOnIzleme.Controls.Add(this.btnKodAc);
            this.pnlOnIzleme.Controls.Add(this.label3);
            this.pnlOnIzleme.Controls.Add(this.rTBOnIzleme);
            this.pnlOnIzleme.Location = new System.Drawing.Point(414, 33);
            this.pnlOnIzleme.Name = "pnlOnIzleme";
            this.pnlOnIzleme.Size = new System.Drawing.Size(371, 290);
            this.pnlOnIzleme.TabIndex = 12;
            // 
            // btnKodCalistir
            // 
            this.btnKodCalistir.Location = new System.Drawing.Point(283, 5);
            this.btnKodCalistir.Name = "btnKodCalistir";
            this.btnKodCalistir.Size = new System.Drawing.Size(75, 23);
            this.btnKodCalistir.TabIndex = 13;
            this.btnKodCalistir.Text = "Çalıştır";
            this.btnKodCalistir.UseVisualStyleBackColor = true;
            this.btnKodCalistir.Click += new System.EventHandler(this.btnKodCalistir_Click);
            // 
            // btnKodAc
            // 
            this.btnKodAc.Location = new System.Drawing.Point(242, 5);
            this.btnKodAc.Name = "btnKodAc";
            this.btnKodAc.Size = new System.Drawing.Size(35, 23);
            this.btnKodAc.TabIndex = 13;
            this.btnKodAc.Text = "Aç";
            this.btnKodAc.UseVisualStyleBackColor = true;
            this.btnKodAc.Click += new System.EventHandler(this.btnKodAc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Kod Ön İzleme";
            // 
            // ExtreamModFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 335);
            this.Controls.Add(this.pnlOnIzleme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Isle);
            this.Controls.Add(this.lb_KonusmaGecmisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Yazi);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ExtreamModFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extream Mod";
            this.Load += new System.EventHandler(this.ExtreamModFormu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlOnIzleme.ResumeLayout(false);
            this.pnlOnIzleme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Isle;
        private System.Windows.Forms.ListBox lb_KonusmaGecmisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Yazi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ercepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rTBOnIzleme;
        private System.Windows.Forms.Panel pnlOnIzleme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKodCalistir;
        private System.Windows.Forms.Button btnKodAc;
    }
}