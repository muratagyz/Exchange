using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace borsa.Alıcı
{
    public class aliciIslemler
    {
        SqlConnection con = new SqlConnection("Data Source=KAANZZDEMIR;Initial Catalog=Borsa;Integrated Security=True");


        private void urunSil(string saticiId, string islemId)
        {
            con.Open();
            SqlCommand cmd3 = new SqlCommand("delete from tblUrun where urunSatici=' " + saticiId + " ' AND id=' " + islemId + " '", con);
            cmd3.ExecuteNonQuery();
            con.Close();
        }

        private void bakiyeAta(string id, int enSonBakiye)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select bakiye from tblAlici where id=' " + id + " '", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                enSonBakiye = Convert.ToInt32(dr["bakiye"]);
            }
            con.Close();
        }
        private void sonFiyatHesapla(int enSonBakiye, int toplamFiyat, string id)
        {
            int sonFiyat = (enSonBakiye - toplamFiyat);

            con.Open();
            SqlCommand cmd4 = new SqlCommand("update tblAlici set bakiye=" + sonFiyat + " where id=" + id + "", con);
            cmd4.ExecuteNonQuery();
            con.Close();
        }
        public void varlikEkle(string urunAd, int urunMiktar, int urunFiyat, string id, int bakiye, string saticiId, string islemId, int enSonBakiye, int toplamFiyat)
        {
            if (bakiye < urunFiyat * urunMiktar)
            {
                MessageBox.Show("Bakiyeniz ürünü satın almak için yetersizdir.");
            }
            else
            {
                con.Open();
                SqlCommand cmd2 = new SqlCommand("insert into tblVarlik (varlikAd,varlikMiktar,varlikFiyat,aliciId) values ('" + urunAd + "', " + urunMiktar + "," + urunFiyat + "," + id + ")", con);
                cmd2.ExecuteNonQuery();
                con.Close();
                urunSil(saticiId, islemId);
                bakiyeAta(id, enSonBakiye);
                sonFiyatHesapla(enSonBakiye, toplamFiyat, id);
                MessageBox.Show("Ürün başarıyla satın alındı!");
            }
        }
        public void onayBeklet(string id, int tutar)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO tblOnayBekleyen (bekleyenId,bekleyenTutar) values (" + id + "," + tutar + ")", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void isimCek(string isim, string id, string karsilama, int bakiye)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("select ad from tblAlici where id=' " + id + " '", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                isim = dr["ad"].ToString();
                karsilama = isim + ", hoşgeldin. Mevcut bakiyen : " + bakiye;
            }
            con.Close();
        }
    }
}
