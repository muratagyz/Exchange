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

namespace borsa.Admin
{
    public partial class uyeOnay : Form
    {
        public uyeOnay()
        {
            InitializeComponent();
            datagridwievGorunum dgwg = datagridwievGorunum();
            dgwg.gorunum(dgwUyeler);
        }

        private void uyeOnay_Load(object sender, EventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=KAANZZDEMIR;Initial Catalog=Borsa;Integrated Security=True");
            con.Open();
            if (rdbAlici.Checked==true && rdbSatici.Checked == false)
            {
                SqlCommand cmd = new SqlCommand("select ad,soyad,kad from tblAlici", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgwUyeler.DataSource = dt;
            }
            else if (rdbAlici.Checked == false && rdbSatici.Checked == true)
            {
                SqlCommand cmd = new SqlCommand("select ad,soyad,kad from tblSatici", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgwUyeler.DataSource = dt;
            }
            con.Close();
        }
    }
}
