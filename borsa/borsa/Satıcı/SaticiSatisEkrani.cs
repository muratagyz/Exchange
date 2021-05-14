using borsa.Concrete;
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
    public partial class SaticiSatisEkrani : Form
    {
        public SaticiSatisEkrani()
        {
            InitializeComponent();
        }
        public string id;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                urun product = new urun();
                product.urunAdi = txtAd.Text;
                product.urunFiyati = txtFiyat.Text;
                product.urunMiktar = txtMiktar.Text;
                product.saticiId = lblId.Text;
                urunManager productManager = new urunManager();
                productManager.urunSatis(product.urunAdi, product.urunFiyati, product.urunMiktar, product.saticiId);
                MessageBox.Show("Ürün başarıyla eklendi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Ürün ekleme başarısız.");
                throw;
            }
        }

        private void SaticiSatisEkrani_Load(object sender, EventArgs e)
        {
            lblId.Text = id;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
