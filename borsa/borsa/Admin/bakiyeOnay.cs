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

namespace borsa.Admin
{
    public partial class bakiyeOnay : Form
    {
        public bakiyeOnay()
        {
            InitializeComponent();
        }
        public string bakiye;
        public string id;
        public int toplam;
        SqlConnection con = new SqlConnection("Data Source=KAANZZDEMIR;Initial Catalog=Borsa;Integrated Security=True");


        void listele()
        {
            con.Open();
            SqlCommand cmd4 = new SqlCommand("select tblOnayBekleyen.id, tblAlici.id, tblAlici.ad, tblAlici.bakiye, tblOnayBekleyen.bekleyenTutar from tblAlici inner join tblOnayBekleyen on tblAlici.id = tblOnayBekleyen.bekleyenId", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd4);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            AdminYonetim ay = new AdminYonetim();
            ay.Show();
            this.Hide();
        }

        private void bakiyeOnay_Load(object sender, EventArgs e)
        {
            listele();
        }
        

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select * from tblOnayBekleyen ", con);
            string islemId = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string onayId = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string bekleyenId = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string mevcutBakiye = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string bekleyenTutar = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string mesaj = "Bakiye yükleme başvurusu " + onayId + " numaralı id'ye sahip, " + bekleyenId + " isimli kişi mevcut bakiyesinin üzerine " + bekleyenTutar + " kadar ekleme yapmak istiyor. Onaylıyor musunuz?";
            string baslik = "Bakiye Onayı";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mesaj, baslik, buttons);
            con.Close();
            if (result == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd3 = new SqlCommand("select bakiye from tblAlici where id=" + onayId + "", con);
                SqlDataReader dr = cmd3.ExecuteReader();
                while (dr.Read())
                {
                    bakiye = dr["bakiye"].ToString();
                }
                con.Close();


                con.Open();
                toplam = int.Parse(bekleyenTutar) + int.Parse(bakiye);
                SqlCommand cmd = new SqlCommand("update tblAlici set bakiye=" + toplam + "  where id=" + onayId + " ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bakiye yükleme işlemi gerçekleştirildi.");
                con.Close();

                con.Open();
                SqlCommand cmdDelete = new SqlCommand("delete from tblOnayBekleyen where id=" + islemId + "", con);
                cmdDelete.ExecuteNonQuery();
                con.Close();
                listele();

            }
            else
            {

            }
        }
    }
}
