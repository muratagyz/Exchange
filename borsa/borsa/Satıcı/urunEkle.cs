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
using System.Data.Sql;
using borsa.Concrete;

namespace borsa.Satıcı
{
    public partial class urunEkle : Form
    {

        public string id;

        public urunEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            urun product = new urun();

            product.urunAdi = txtAd.Text;
            product.urunFiyati = txtFiyat.Text;
            product.urunMiktar = txtMiktar.Text;
            product.saticiId = lblId.Text;

            urunManager productManager = new urunManager();
            productManager.urunSatis(product.urunAdi, product.urunFiyati, product.urunMiktar, product.saticiId);
        }

        private void urunEkle_Load(object sender, EventArgs e)
        {
            lblId.Text = id;
        }
    }
}
