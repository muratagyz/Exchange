﻿using System;
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

namespace borsa.Admin
{
    public partial class uyeOnay : Form
    {
        public uyeOnay()
        {
            InitializeComponent();
        }

        private void uyeOnay_Load(object sender, EventArgs e)
        {

        }

        adminIslemler ai = new adminIslemler();

        private void btnListele_Click(object sender, EventArgs e)
        {
            if (rdbAlici.Checked == true && rdbSatici.Checked == false)
            {
                DataTable dt = new DataTable();
                ai.veriListele(dgwUyeler, dt, "tblAlici");
                dgwUyeler.DataSource = dt;
            }
            else if (rdbAlici.Checked == false && rdbSatici.Checked == true)
            {
                DataTable dt = new DataTable();
                ai.veriListele(dgwUyeler, dt, "tblSatici");
                dgwUyeler.DataSource = dt;
            }
        }

        private void dgwUyeler_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblId.Text = dgwUyeler.CurrentRow.Cells[3].Value.ToString();
            lblVeriSil.Text = dgwUyeler.CurrentRow.Cells[0].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = lblVeriSil.Text;
            if (rdbAlici.Checked == true && rdbSatici.Checked == false)
            {
                ai.veriSilme("tblAlici", id);
                MessageBox.Show("Alıcı silindi");
            }
            else if (rdbAlici.Checked == false && rdbSatici.Checked == true)
            {
                ai.veriSilme("tblSatici", id);
                MessageBox.Show("Satıcı silindi");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            AdminYonetim ay = new AdminYonetim();
            ay.Show();
            this.Hide();
        }
    }
}
