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

namespace borsa
{
    public partial class frmLoginSatici : Form
    {
        public frmLoginSatici()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

            secimEkrani sc = new secimEkrani();
            sc.Show();
            this.Hide();
        }

        SaticiYonteim sy = new SaticiYonteim();

        private void button1_Click(object sender, EventArgs e)
        {
            girisKontrol validasyon = new girisKontrol();
            lblOnay.Text = validasyon.onayliMi(txtKullaniciAdi.Text, "tblSatici");
            validasyon.kontrol("tblSatici", "kad", "sifre", txtKullaniciAdi.Text, txtSifre.Text);
            if (validasyon.bilgiKontrol == true && lblOnay.Text == true.ToString())
            {
                this.Hide();
                string kid;
                SqlConnection con = new SqlConnection("Data Source=KAANZZDEMIR;Initial Catalog=Borsa;Integrated Security=True");
                con.Open();
                SqlCommand cmd2 = new SqlCommand("Select id from tblSatici where kad = '" + txtKullaniciAdi.Text + "'", con);
                SqlDataReader dr = cmd2.ExecuteReader();
                while (dr.Read())
                {
                    kid = dr["id"].ToString();
                    sy.id = kid.ToString();
                }
                MessageBox.Show("Başarılı bir şekilde giriş yaptınız.");
                sy.ShowDialog();
            }
            else
            {
                MessageBox.Show("Giriş işlemi başarısız.");
            }
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
