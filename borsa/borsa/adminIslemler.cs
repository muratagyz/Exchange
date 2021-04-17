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
            SqlCommand cmd = new SqlCommand("select id,ad,soyad,kad from " + tabloAd, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
        }

        public void veriSilme(string tabloAdi, string id)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM " + tabloAdi + " WHERE id=" + id + "", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
