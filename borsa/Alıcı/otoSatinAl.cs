using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace borsa.Alıcı
{
    public partial class otoSatinAl : Form
    {
        public otoSatinAl()
        {
            InitializeComponent();
        }
        public int bakiye = 0;
        public string id;

        public void listeTazele()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select id,urunAd AS 'Ürün Adı',urunFiyat AS 'Birim Fiyatı', urunMiktar AS 'Miktar (kg)' from tblUrun where urunAd='" + comboBox1.Text + "' ORDER BY urunFiyat ASC", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;
            da.Fill(dt);
            con.Close();
        }
        public void fiyatBelirtme()
        {
            urunId = dataGridView1.Rows[0].Cells[0].Value.ToString();
            urunAd = dataGridView1.Rows[0].Cells[1].Value.ToString();
            birimFiyat = Convert.ToInt32(dataGridView1.Rows[0].Cells[2].Value.ToString());
            miktar = Convert.ToInt32(dataGridView1.Rows[0].Cells[3].Value.ToString());
            toplamFiyat = birimFiyat * miktar;
        }
        SqlConnection con = new SqlConnection("Data Source=KAANZZDEMIR;Initial Catalog=Borsa;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select tblSatici.ad AS 'Satıcı Adı',tblUrun.urunAd AS 'Ürün Adı',tblUrun.urunMiktar AS 'Ürün Miktarı',tblUrun.urunFiyat AS 'Ürün Fiyatı' from tblUrun INNER JOIN tblSatici ON tblUrun.urunSatici = tblSatici.id", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;
            da.Fill(dt);
            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AliciYonetim ay = new AliciYonetim();
        }

        private void otoSatinAl_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT distinct urunAd FROM tblUrun";
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;

            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["urunAd"]);
            }
            con.Close();
            comboBox1.SelectedIndex = 0;
        }

        string urunId;

        private void button1_Click(object sender, EventArgs e)
        {

            listeTazele();

        }

        public int birimFiyat, miktar, toplamFiyat;
        public string urunAd;

        private void button3_Click(object sender, EventArgs e)
        {
            fiyatBelirtme();

            if (bakiye > toplamFiyat)
            {
                while (bakiye > toplamFiyat)
                {
                    fiyatBelirtme();
                    if (bakiye < toplamFiyat)
                    {
                        MessageBox.Show("Bakiyeniz yetersizdir");
                        break;
                    }
                    con.Open();
                    SqlCommand varlikEkle = new SqlCommand("insert into tblVarlik (varlikAd,varlikMiktar,varlikFiyat,aliciId) values ('" + urunAd + "', " + miktar + "," + birimFiyat + "," + id + ")", con);
                    varlikEkle.ExecuteNonQuery();
                    con.Close();


                    con.Open();
                    SqlCommand satilanUrunSil = new SqlCommand("delete from tblUrun where id=" + urunId + "", con);
                    satilanUrunSil.ExecuteNonQuery();
                    con.Close();

                    bakiye = bakiye - toplamFiyat;

                    con.Open();
                    SqlCommand bakiyeGuncelle = new SqlCommand("update tblAlici set bakiye=" + bakiye + " where id=" + id + "", con);
                    bakiyeGuncelle.ExecuteNonQuery();
                    con.Close();


                    listeTazele();
                }
            }
            else
            {
                MessageBox.Show("Bakiyeniz yetersizdir");
            }

            MessageBox.Show("Satın alma işlemi sona ermiştir.");

        }
    }
}
