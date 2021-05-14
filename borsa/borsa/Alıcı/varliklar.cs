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
    public partial class varliklar : Form
    {
        public varliklar()
        {
            InitializeComponent();
        }
        AliciYonetim ay = new AliciYonetim();
        public string id;

        public void listele()
        {
            adminIslemler ai = new adminIslemler();
            DataTable dt = new DataTable();
            ai.veriListele4(dataGridView1, dt, id);
            dataGridView1.DataSource = dt;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void varliklar_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
