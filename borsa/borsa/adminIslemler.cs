using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace borsa
{
    class adminIslemler
    {
        SqlConnection con = new SqlConnection("Data Source=KAANZZDEMIR;Initial Catalog=Borsa;Integrated Security=True");
        public void veriListele(DataGridView dgw, DataTable dt, string tabloAd)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select id,ad,soyad,kad,onay from  " + tabloAd + "  where uyelikDurum='True'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
        }
        public void veriListele2(DataGridView dgw, DataTable dt)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select tblUrun.id, tblUrun.urunAd, tblUrun.urunMiktar, tblUrun.urunFiyat,  tblSatici.ad, tblUrun.onay from tblUrun INNER JOIN tblSatici on tblUrun.urunSatici = tblSatici.id", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
        }

        public void veriSilme(string tabloAdi, string id)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE " + tabloAdi + " SET uyelikDurum='False' where id=" + id + "", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void onay(string tabloAdi, string id)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE " + tabloAdi + " SET onay='True' where id=" + id + "", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void red(string tabloAdi, string id)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE " + tabloAdi + " SET onay='False' where id=" + id + "", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
