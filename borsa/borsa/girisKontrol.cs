using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace borsa
{
    public class girisKontrol
    {

        public bool bilgiKontrol = false;

        public void kontrol(string tabloAdi, string id, string sifre, string textBoxKullaniciAd, string textBoxSifre)
        {
            SqlConnection con = new SqlConnection("Data Source=KAANZZDEMIR;Initial Catalog=Borsa;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM " + tabloAdi.ToString() + " where " + id.ToString() + "=@user AND " + sifre.ToString() + "=@pass", con);
            cmd.Parameters.AddWithValue("@user", textBoxKullaniciAd);
            cmd.Parameters.AddWithValue("@pass", textBoxSifre);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                bilgiKontrol = true;
                MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");
               
            }
            else
            {
                bilgiKontrol = false;
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            con.Close();
        }
    }
}
