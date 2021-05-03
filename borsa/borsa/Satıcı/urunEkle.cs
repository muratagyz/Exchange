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

namespace borsa.Satıcı
{
    public partial class urunEkle : Form
    {
        public urunEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=KAANZZDEMIR;Initial Catalog=Borsa;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO tblUrun (urunAd, urunMiktar, urunFiyat) VALUES(" + txtAd.Text + "," + txtMiktar.Text + "," + txtFiyat.Text + ")", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
