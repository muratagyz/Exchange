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
    public partial class bakiyeYukle : Form
    {
        public bakiyeYukle()
        {
            InitializeComponent();
        }

        public string id;
        public int bakiye;
        SqlConnection con = new SqlConnection("Data Source=KAANZZDEMIR;Initial Catalog=Borsa;Integrated Security=True");
        aliciIslemler ali = new aliciIslemler();
        private void bakiyeYukle_Load(object sender, EventArgs e)
        {
            string isim = "";
            ali.isimCek(isim, id, lblKarsilama.Text, bakiye);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int eklenenBakiye = 0;
                eklenenBakiye = int.Parse(textBox1.Text);
                if (eklenenBakiye == 0)
                {
                    MessageBox.Show("Lütfen 0'dan farklı değer girin.");
                }
                else
                {

                    ali.onayBeklet(id, int.Parse(textBox1.Text));
                    MessageBox.Show("Bakiye ekleme işlemizin alınmıştır, en kısa süre içinde eklemeniz yapılacaktır.");
                    this.Hide();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Bir şeyler ters gitti.");
                throw;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
