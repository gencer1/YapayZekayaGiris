using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

namespace yapayZeka
{
    internal class MSSQL
    {
        public string vtConStr = "Data Source=DESKTOP-5COFHMM\\SQLEXPRESS; Initial Catalog=YZekaDb; Integrated Security=true;";

        public SqlConnection Baglan() {
            SqlConnection baglanti = new SqlConnection(vtConStr);
            baglanti.Open();
            return baglanti;
        }

        public int cmd(string sqlCumle) {
            SqlConnection baglan = this.Baglan();
            SqlCommand sorgu = new SqlCommand(sqlCumle);

            int sonuc = 0;

            try
            {
                sonuc = sorgu.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                //throw new Exception(ex.Message + " (" + sqlcumle + ")");
                sorgu.Connection.Close();
                return -5;
            }
            finally
            {
                sorgu.Connection.Close();
            }

            return (sonuc);
        }

        //Kayıt Sayısı Bulma
        public string GetDataCell(string sql)
        {
            DataTable table = GetDataTable(sql);
            if (table.Rows.Count == 0)
                return null;
            return table.Rows[0][0].ToString();
        }

        //Kayıt Çekme
        public DataRow GetDataRow(string sql)
        {
            DataTable table = GetDataTable(sql);
            if (table.Rows.Count == 0) return null;
            return table.Rows[0];

        }

        //DataTable ye veri çekme
        public DataTable GetDataTable(string sql)
        {
            SqlConnection baglan = this.Baglan();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, baglan);
            DataTable dt = new DataTable();
            try
            {
                adapter.Fill(dt);

            }
            catch (SqlException)
            {
                //throw new Exception(ex.Message + " (" + sql + ")");
            }
            finally
            {
                adapter.Dispose();
                baglan.Close();
            }
            return dt;
        }

        //Datasete veri çekme
        public DataSet GetDataSet(string sql)
        {
            SqlConnection baglan = this.Baglan();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, baglan);
            DataSet ds = new DataSet();
            try
            {
                adapter.Fill(ds);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message + " (" + sql + ")");
            }
            finally
            {
                ds.Dispose();
                adapter.Dispose();
                baglan.Close();
            }
            return ds;
        }

        //Parametreyle veri çekme
        public DataTable GetDataTableWP(string sql, Dictionary<string, object> veri)
        {
            SqlConnection baglan = this.Baglan();
            SqlCommand sorgu = new SqlCommand(sql, baglan);
            foreach (var item in veri)
            {
                sorgu.Parameters.Add("@" + item.Key, item.Value);
            }
            DataTable dt = new DataTable();
            try
            {
                SqlDataReader rd = sorgu.ExecuteReader();
                dt.Load(rd);
            }
            catch (SqlException ex)
            {
                //throw new Exception(ex.Message + " (" + sql + ")");
            }
            finally
            {
                baglan.Close();
            }
            return dt;
        }
        //Parametreyle hücre çekme
        public string GetDataCellWP(string sql, Dictionary<string, object> veri)
        {
            DataTable table = GetDataTableWP(sql, veri);
            if (table.Rows.Count == 0)
                return null;
            return table.Rows[0][0].ToString();
        }

        //Parametreyle Kayıt Çekme
        public DataRow GetDataRowWP(string sql, Dictionary<string, object> veri)
        {
            DataTable table = GetDataTableWP(sql, veri);
            if (table.Rows.Count == 0) return null;
            return table.Rows[0];
        }

        //Parametreyle sorgu çalıştırma
        public int cmdWP(string sqlcumle, Dictionary<string, object> veri)
        {
            SqlConnection baglan = this.Baglan();
            SqlCommand sorgu = new SqlCommand(sqlcumle, baglan);
            foreach (var item in veri)
            {
                sorgu.Parameters.Add("@" + item.Key, item.Value);
            }
            int sonuc = 0;
            try
            {
                sonuc = sorgu.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                //cmd("update Isyeri set DspTc='" + ex.Message + "' where IsletmeID=2");
                //throw new Exception(ex.Message + " (" + sqlcumle + ")");
                sorgu.Connection.Close();
                return -5;
            }
            finally
            {
                sorgu.Connection.Close();
            }
            return (sonuc);
        }


    }
}
