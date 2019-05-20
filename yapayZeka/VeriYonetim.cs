using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yapayZeka
{
    internal class VeriYonetim
    {
        MSSQL vt = new MSSQL();
        public int cevapIndex = -1;
        public string Nedir(string _currentStr)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>();
            dict.Add("text", _currentStr);

            string queryStr = "SELECT * FROM TblNedir WHERE isim = @text";

            DataRow getDt = Contakt(queryStr, dict);

            if (getDt == null)
            {
                return _currentStr + " ile ilgili sonuç bulunamadı!";
            }
            else
            {
                return _currentStr + " --> " + getDt["hakkinda"];
                cevapIndex = Convert.ToInt16(getDt["nedirId"]);
            }
        }
        
        public bool KullaniciGiris(string kulAdi,string sifre) {
            Dictionary<string, object> wpD = new Dictionary<string, object>();

            wpD.Add("kulAdi",kulAdi);
            wpD.Add("sifre",sifre);
            
            if(Contakt("SELECT id FROM TblKullanici Where kullaniciAdi=@kulAdi AND sifre=@sifre", wpD) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        public bool YeniVeriEkle(int tbl,string key,string value) {
            Dictionary<string, object> wpD = new Dictionary<string, object>();

            string queryStr = "";

            if (tbl == 0){
                wpD.Add("adiSoyadi", key);
                wpD.Add("hakkinda", value);
                queryStr = "TblKimdir(adiSoyadi,hakkinda) VALUES(@adiSoyadi,@hakkinda)";
            } else if (tbl == 1) {
                wpD.Add("isim", key);
                wpD.Add("hakkinda", value);
                queryStr = "TblNedir(isim,hakkinda) VALUES(@isim,@hakkinda)";
            } else if (tbl == 2){
                wpD.Add("text", key);
                wpD.Add("index", value);
                queryStr = "TblCmd(cmdKomutText,yapilacakIslemIndex) VALUES(@text,@index)";
            }
            



            //Dönen veririnin null olup olmadığını kontrol ediyorum.
            if(ContaktCmd("INSERT INTO " + queryStr,wpD) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
            
            //Komut

        }

        //Vt ile veri alışverişinin yapıldığı yer
        public DataRow Contakt (string queryStr, Dictionary<string, object> wpD)
        {
            try
            {
                DataRow dr = vt.GetDataRowWP(queryStr, wpD);

                return dr;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public int ContaktCmd(string queryStr, Dictionary<string, object> wpD)
        {
            try
            {
                vt.cmdWP(queryStr, wpD);

                return 1; //işlem tamamlanmış
            }
            catch (Exception)
            {
                return 0; //işlem tamamlanmış
            }

        }

    }
}
