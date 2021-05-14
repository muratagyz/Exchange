using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace borsa
{
    public class uyeEkle
    {
        public void vtUyeEkle(string tabloAdi, string ad, string soyad, string id,
            string sifre, string mail, string tel, string adres, string tc)
        {
            SqlConnection con = new SqlConnection("Data Source=KAANZZDEMIR;Initial Catalog=Borsa;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO " + tabloAdi.ToString() + " (ad, soyad, kad, sifre,mail,telefon,adres,tc) VALUES('"+ ad + "' , '" + soyad + "' , '"
                + id + "' , '" + sifre + "' , '" + mail+ "' , '" + tel + "' , '" + adres +
                "' , '" + tc + " ')", con);
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}
