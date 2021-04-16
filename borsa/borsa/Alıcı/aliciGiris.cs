using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void button1_Click(object sender, EventArgs e)
        {

            girisKontrol validasyon = new girisKontrol();
            validasyon.kontrol("tblAlici", "kad", "sifre", txtKullaniciAdi.Text, txtSifre.Text);
            if (validasyon.bilgiKontrol == true)
            {
                AliciYonetim ay = new AliciYonetim();
                ay.Show();
                this.Hide();
            }
        }

        private void frmLoginAlici_Load(object sender, EventArgs e)
        {

        }
    }
}
