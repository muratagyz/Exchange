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
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace borsa.Alici
{
    public partial class rapor : Form
    {
        public rapor()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=KAANZZDEMIR;Initial Catalog=Borsa;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tblVarlik where islemTarih BETWEEN '" + dateTimePicker1.Text + "' AND '" + dateTimePicker2.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;
            da.Fill(dt);
            con.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog file = new SaveFileDialog();
            file.Filter = "PDF DOSYALARI(*.pdf)|*.pdf";
            file.Title = "PDF RAPOR";
            if (file.ShowDialog() == DialogResult.OK)
            {
                FileStream dosya = File.Open(file.FileName, FileMode.Create);
                Document pdf = new Document();
                PdfWriter.GetInstance(pdf, dosya);
                pdf.Open();
                pdf.AddAuthor("Kaan Özdemir");
                pdf.AddCreator("Murat Ağyüz");
                pdf.AddTitle("RAPOR PDF");
                pdf.AddSubject("Ürün satın alma raporu");
                pdf.AddKeywords("Rapor");
                for (int i = 1; i < dataGridView1.RowCount; i++)
                {
                    Paragraph p = new Paragraph("Satın alınan tarih: " + dataGridView1.Rows[i-1].Cells[5].Value.ToString());
                    Paragraph p1 = new Paragraph("Satın alınan ürün: " + dataGridView1.Rows[i-1].Cells[1].Value.ToString());
                    Paragraph p2 = new Paragraph("Satın alınan tutar: " + dataGridView1.Rows[i-1].Cells[3].Value.ToString());
                    Paragraph p3 = new Paragraph("Satın alınan miktar: " + dataGridView1.Rows[i-1].Cells[2].Value.ToString());
                    pdf.Add(p);
                    pdf.Add(p1);
                    pdf.Add(p2);
                    pdf.Add(p3);
                }
                pdf.Close();
                MessageBox.Show("İşlem başarılı.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
