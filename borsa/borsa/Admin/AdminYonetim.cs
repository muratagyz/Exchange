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
    public partial class AdminYonetim : Form
    {
        public AdminYonetim()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            secimEkrani se = new secimEkrani();
            se.Show();
        }

        private void uyeonayla_Click(object sender, EventArgs e)
        {
            Admin.uyeOnay uo = new Admin.uyeOnay();
            uo.Show();
            this.Hide();
        }

        private void satisonayla_Click(object sender, EventArgs e)
        {
            Admin.satisOnay so = new Admin.satisOnay();
            so.Show();
            this.Hide();
        }
    }
}
