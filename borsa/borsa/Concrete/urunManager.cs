using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace borsa.Concrete
{
    public class urunManager
    {
        public void urunSatis(string _urunAdi, string _urunFiyati, string _urunMiktar, string _saticiId)
        {
            if (_urunAdi != "" & _urunFiyati != "" & _urunMiktar != "")
            {
                SqlConnection con = new SqlConnection("Data Source=KAANZZDEMIR;Initial Catalog=Borsa;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO tblUrun (urunAd, urunMiktar, urunFiyat, urunSatici) VALUES('" + _urunAdi + "' , '" + _urunMiktar + "' , '" + _urunFiyati + "' , " + _saticiId + ")", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                MessageBox.Show("Hata boş yer bıraktınız !");
            }
        }
    }
}
