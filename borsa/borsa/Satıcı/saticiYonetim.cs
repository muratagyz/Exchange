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
    public partial class SaticiYonteim : Form
    {
        public SaticiYonteim()
        {
            InitializeComponent();
        }
        public string id;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            secimEkrani se = new secimEkrani();
            se.Show();
        }

        private void satisonayla_Click(object sender, EventArgs e)
        {
            this.Hide();
            Satıcı.urunEkle ue = new Satıcı.urunEkle();
            ue.id = label2.Text;
            ue.ShowDialog();

        }

        private void SaticiYonteim_Load(object sender, EventArgs e)
        {
            label2.Text = id;
        }
    }
}
