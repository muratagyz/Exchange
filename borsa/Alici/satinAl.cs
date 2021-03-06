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
using borsa.Admin;

namespace borsa.Alıcı
{
    public partial class satinAl : Form
    {
        public satinAl()
        {
            InitializeComponent();
        }

        public string id;
        public int toplamFiyat = 0;
        public int enSonBakiye;
        AliciYonetim ay = new AliciYonetim();

        public void listele()
        {
            islemId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            urunAd = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            urunMiktar = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            urunFiyat = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            saticiAd = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            saticiId = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }
        public string islemId, urunAd, urunMiktar, urunFiyat, saticiAd, saticiId;

        private void satinAl_FormClosed(object sender, FormClosedEventArgs e)
        {
            ay.Hide();
            ay.Show();

        }


        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=KAANZZDEMIR;Initial Catalog=Borsa;Integrated Security=True");
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select * from tblOnayBekleyen ", con);
            listele();
            if (urunMiktar == "" && urunFiyat == "")
            {
                MessageBox.Show("Bir ürün seçilemedi.");
            }
            else
            {
                listele();
                MessageBox.Show("Ürünü başarıyla seçtiniz!");
                toplamFiyat = int.Parse(urunMiktar) * int.Parse(urunFiyat);
                string mesaj = "Seçmiş olduğunuz " + urunAd + " adlı ürünü " + toplamFiyat + "TL'ye satın almak istiyor musunuz?";
                string baslik = "Ürün Al";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(mesaj, baslik, buttons);
                con.Close();
                if (result == DialogResult.Yes)
                {

                    aliciIslemler ali = new aliciIslemler();
                    ali.varlikEkle(urunAd, int.Parse(urunMiktar), int.Parse(urunFiyat), id, enSonBakiye,saticiId,islemId,enSonBakiye,toplamFiyat);

                    ///SON OLARAK ÜRÜN SATIN ALDIRMA İŞLEMİ MANUEL YAPTIRILDI LBLBAKİYE'Yİ GÜNCELLEMEK VE OTO YAPMAK KALDI
                }
            }

        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void satinAl_Load(object sender, EventArgs e)
        {

            adminIslemler ai = new adminIslemler();
            DataTable dt = new DataTable();
            ai.veriListele3(dataGridView1, dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
