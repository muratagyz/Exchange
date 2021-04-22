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

        private void button1_Click(object sender, EventArgs e)
        {
            girisKontrol validasyon = new girisKontrol();
            lblOnay.Text = validasyon.onayliMi(txtKullaniciAdi.Text,"tblSatici");
            validasyon.kontrol("tblSatici", "kad", "sifre", txtKullaniciAdi.Text, txtSifre.Text);
            if (validasyon.bilgiKontrol == true && lblOnay.Text == true.ToString())
            {
                MessageBox.Show("Başarılı bir şekilde giriş yaptınız.");
                SaticiYonteim sy = new SaticiYonteim();
                sy.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş işlemi başarısız.");
            }
        }
    }
}
