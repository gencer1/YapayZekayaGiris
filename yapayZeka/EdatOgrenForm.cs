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
    public partial class EdatOgrenForm : Form
    {
        MSSQL vt = new MSSQL();
        public EdatOgrenForm()
        {
            InitializeComponent();
        }

        private void EdatOgrenForm_Load(object sender, EventArgs e)
        {
            DataTable dt = vt.GetDataTable("Select name From sys.tables");

            foreach (DataRow tablo in dt.Rows)
            {
                cb_Tablolar.Items.Add(tablo["name"]);
            }
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            VeriModel.edatOgrenTblText = cb_Tablolar.Text;
            this.Close();
        }

        private void btn_EdatDegil_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Peki diyalog mu?","Dikkat",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {//Buraya girerse bu bir diyalogtur
                VeriModel.edatOgrenTblText = "DiyalogOgren";
                this.Close();
            }
            else
            {
                VeriModel.edatOgrenTblText = "IslemSil";
                this.Close();
            }
            
        }

        private void btn_Vazgec_Click(object sender, EventArgs e)
        {
            VeriModel.edatOgrenTblText = "IslemIptal";
            this.Close();
        }
    }
}
