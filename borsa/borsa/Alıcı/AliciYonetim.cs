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
    public partial class AliciYonetim : Form
    {
        public AliciYonetim()
        {
            InitializeComponent();
        }

        private void satisonayla_Click(object sender, EventArgs e)
        {

        }

        private void sonislemler_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            secimEkrani se = new secimEkrani();
            se.Show();
        }
    }
}
