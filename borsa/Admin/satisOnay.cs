using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace borsa.Admin
{
    public partial class satisOnay : Form
    {
        public satisOnay()
        {
            InitializeComponent();
        }

        private void satisOnay_Load(object sender, EventArgs e)
        {


        }
        adminIslemler ai = new adminIslemler();

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            ai.veriListele2(dataGridView1, dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblUrunId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            lblUrunAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            lblSatici.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            lblDurum.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            if (lblDurum.Text == "False")
            {
                lblDurum.Text = "Onaylı Değil";
            }
            else if (lblDurum.Text == "True")
            {
                lblDurum.Text = "Onaylı";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ai.onay("tblUrun", lblUrunId.Text);
            DataTable dt = new DataTable();
            ai.veriListele2(dataGridView1, dt);
            dataGridView1.DataSource = dt;
            MessageBox.Show("Ürün satışa çıkarıldı!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ai.red("tblUrun", lblUrunId.Text);
            DataTable dt = new DataTable();
            ai.veriListele2(dataGridView1, dt);
            dataGridView1.DataSource = dt;
            MessageBox.Show("Ürün pazardan çekildi...");
        }

        private void label10_Click(object sender, EventArgs e)
        {
            AdminYonetim ay = new AdminYonetim();
            ay.Show();
            this.Hide();
        }
    }
}
