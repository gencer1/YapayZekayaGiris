namespace yapayZeka
{
    partial class EdatOgrenForm
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
            this.pnl_BirinciAsama = new System.Windows.Forms.Panel();
            this.cb_Tablolar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Vazgec = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Edat = new System.Windows.Forms.Label();
            this.btn_EdatDegil = new System.Windows.Forms.Button();
            this.pnl_BirinciAsama.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_BirinciAsama
            // 
            this.pnl_BirinciAsama.Controls.Add(this.label1);
            this.pnl_BirinciAsama.Controls.Add(this.cb_Tablolar);
            this.pnl_BirinciAsama.Location = new System.Drawing.Point(12, 36);
            this.pnl_BirinciAsama.Name = "pnl_BirinciAsama";
            this.pnl_BirinciAsama.Size = new System.Drawing.Size(309, 42);
            this.pnl_BirinciAsama.TabIndex = 0;
            // 
            // cb_Tablolar
            // 
            this.cb_Tablolar.FormattingEnabled = true;
            this.cb_Tablolar.Location = new System.Drawing.Point(168, 9);
            this.cb_Tablolar.Name = "cb_Tablolar";
            this.cb_Tablolar.Size = new System.Drawing.Size(129, 21);
            this.cb_Tablolar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Edatın İlişkili Olduğu Tabo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(255, 93);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(66, 30);
            this.btn_Ekle.TabIndex = 2;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_Vazgec
            // 
            this.btn_Vazgec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Vazgec.Location = new System.Drawing.Point(12, 93);
            this.btn_Vazgec.Name = "btn_Vazgec";
            this.btn_Vazgec.Size = new System.Drawing.Size(67, 30);
            this.btn_Vazgec.TabIndex = 3;
            this.btn_Vazgec.Text = "Vazgeç";
            this.btn_Vazgec.UseVisualStyleBackColor = true;
            this.btn_Vazgec.Click += new System.EventHandler(this.btn_Vazgec_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(15, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Edat ->";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Edat
            // 
            this.lbl_Edat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Edat.Location = new System.Drawing.Point(86, 10);
            this.lbl_Edat.Name = "lbl_Edat";
            this.lbl_Edat.Size = new System.Drawing.Size(235, 23);
            this.lbl_Edat.TabIndex = 4;
            this.lbl_Edat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_EdatDegil
            // 
            this.btn_EdatDegil.ForeColor = System.Drawing.Color.Red;
            this.btn_EdatDegil.Location = new System.Drawing.Point(111, 93);
            this.btn_EdatDegil.Name = "btn_EdatDegil";
            this.btn_EdatDegil.Size = new System.Drawing.Size(138, 30);
            this.btn_EdatDegil.TabIndex = 2;
            this.btn_EdatDegil.Text = "Bu Bir Edat Değil";
            this.btn_EdatDegil.UseVisualStyleBackColor = true;
            this.btn_EdatDegil.Click += new System.EventHandler(this.btn_EdatDegil_Click);
            // 
            // EdatOgrenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 135);
            this.Controls.Add(this.lbl_Edat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Vazgec);
            this.Controls.Add(this.btn_EdatDegil);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.pnl_BirinciAsama);
            this.Name = "EdatOgrenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edat Öğret";
            this.Load += new System.EventHandler(this.EdatOgrenForm_Load);
            this.pnl_BirinciAsama.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_BirinciAsama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_Vazgec;
        public System.Windows.Forms.ComboBox cb_Tablolar;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbl_Edat;
        private System.Windows.Forms.Button btn_EdatDegil;
    }
}