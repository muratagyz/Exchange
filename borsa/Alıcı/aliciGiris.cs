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
    public partial class frmLoginAlici : Form
    {
        public frmLoginAlici()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            secimEkrani sc = new secimEkrani();
            sc.Show();
            this.Hide();
        }
        AliciYonetim ay = new AliciYonetim();
        SqlConnection con = new SqlConnection("Data Source=KAANZZDEMIR;Initial Catalog=Borsa;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            girisKontrol validasyon = new girisKontrol();
            lblOnay.Text = validasyon.onayliMi(txtKullaniciAdi.Text, "tblAlici");
            validasyon.kontrol("tblAlici", "kad", "sifre", txtKullaniciAdi.Text, txtSifre.Text);
            if (validasyon.bilgiKontrol == true && lblOnay.Text == true.ToString())
            {
                this.Hide();
                string kid;
                con.Open();
                SqlCommand cmd2 = new SqlCommand("Select id from tblAlici where kad = '" + txtKullaniciAdi.Text + "'", con);
                SqlDataReader dr = cmd2.ExecuteReader();
                while (dr.Read())
                {
                    kid = dr["id"].ToString();
                    ay.id = kid;
                    MessageBox.Show("Başarılı bir şekilde giriş yaptınız.");
                    ay.ShowDialog();
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Giriş işlemi başarısız.");
            }
        }

        private void frmLoginAlici_Load(object sender, EventArgs e)
        {

        }
    }
}
