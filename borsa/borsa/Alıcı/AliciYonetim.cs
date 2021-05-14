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
using borsa.Alıcı;

namespace borsa
{
    public partial class AliciYonetim : Form
    {
        public AliciYonetim()
        {
            InitializeComponent();
        }

        public string id;
        public int bakiye;
        Alıcı.bakiyeYukle by = new Alıcı.bakiyeYukle();

        private void satisonayla_Click(object sender, EventArgs e)
        {
            satinAl sa = new satinAl();
            sa.id = id;
            sa.enSonBakiye = bakiye;
            sa.ShowDialog();
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


        private void button2_Click(object sender, EventArgs e)
        {
            if (lblBakiye.Text == null || lblBakiye.Text == "")
            {
                bakiye = by.bakiye;
            }
            by.id = label4.Text;
            by.bakiye = bakiye;
            by.ShowDialog();
        }


        private void AliciYonetim_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=KAANZZDEMIR;Initial Catalog=Borsa;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select bakiye from tblAlici where id=' " + id + " '", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                bakiye = Convert.ToInt32(dr["bakiye"]);
            }
            lblBakiye.Text = bakiye.ToString();
            label4.Text = id;
            dr.Close();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            varliklar v = new varliklar();
            v.id = id;
            v.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
