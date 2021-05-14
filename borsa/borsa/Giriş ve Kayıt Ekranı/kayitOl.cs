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
    public partial class kayitOl : Form
    {
        public kayitOl()
        {
            InitializeComponent();
        }
        public void geriGel()
        {
            secimEkrani sc = new secimEkrani();
            sc.Show();
            this.Hide();
        }
        private void kayitOl_Load(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
            secimEkrani sc = new secimEkrani();
            sc.Show();
            this.Hide();
        }


        private void btnKayitOl_Click_1(object sender, EventArgs e)
        {
            if (rdbAlici.Checked == true && txtAd.Text != "" && txtSoyad.Text != "" && txtTc.Text != "" && txtTel.Text != "" && txtKullaniciAd.Text != "" && txtSifre.Text != "" && txtAdres.Text != "" && txtEmail.Text != "")
            {
                uyeEkle ue = new uyeEkle();
                ue.vtUyeEkle("tblAlici", txtAd.Text, txtSoyad.Text, txtKullaniciAd.Text, txtSifre.Text, txtEmail.Text, txtTel.Text, txtAdres.Text, txtTc.Text);
                MessageBox.Show("Başarıyla kayıt oldunuz! Giriş ekranına aktarılıyorsunuz...");
                this.Close();
                frmLoginAlici ag = new frmLoginAlici();
                ag.Show();

            }
            else if (rdbSatici.Checked == true && txtAd.Text != "" && txtSoyad.Text != "" && txtTc.Text != "" && txtTel.Text != "" && txtKullaniciAd.Text != "" && txtSifre.Text != "" && txtAdres.Text != "" && txtEmail.Text != "")
            {
                uyeEkle ue = new uyeEkle();
                ue.vtUyeEkle("tblSatici", txtAd.Text, txtSoyad.Text, txtKullaniciAd.Text, txtSifre.Text, txtEmail.Text, txtTel.Text, txtAdres.Text, txtTc.Text);
                MessageBox.Show("Başarıyla kayıt oldunuz! Giriş ekranına aktarılıyorsunuz...");
                this.Close();
                frmLoginSatici sg = new frmLoginSatici();
                sg.Show();
            }
            else
            {
                MessageBox.Show("Lütfen bütün bilgilerinizi girdiğinizden emin olunuz.");
            }

        }
    }
}
