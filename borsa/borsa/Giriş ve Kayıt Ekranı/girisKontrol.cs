using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using borsa.abstracts;

namespace borsa
{
    public class girisKontrol : ILoginDal
    {
        public bool bilgiKontrol = false;

        public void kontrol(string tabloAdi, string id, string sifre, string textBoxKullaniciAd, string textBoxSifre)
        {
            SqlConnection con = new SqlConnection("Data Source=KAANZZDEMIR;Initial Catalog=Borsa;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM " + tabloAdi.ToString() + " where " + id.ToString() + "=@user AND " + sifre.ToString() + "=@pass ", con);
            cmd.Parameters.AddWithValue("@user", textBoxKullaniciAd);
            cmd.Parameters.AddWithValue("@pass", textBoxSifre);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                bilgiKontrol = true;
            }
            else
            {
                bilgiKontrol = false;
            }

            con.Close();
        }

        public string onayliMi(string txtkAd, string tblAd)
        {
            string onay = "";
            SqlConnection con = new SqlConnection("Data Source=KAANZZDEMIR;Initial Catalog=Borsa;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select onay from " + tblAd + " where kad=@kullaniciAd", con);
            cmd.Parameters.AddWithValue("@kullaniciAd", txtkAd);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                onay = dr["onay"].ToString();
            }
            dr.Close();
            con.Close();
            return onay;
        }
    }
}
