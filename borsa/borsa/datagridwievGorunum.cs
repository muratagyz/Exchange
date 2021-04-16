using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Windows.Forms;
using System.Drawing;

namespace borsa
{
    public class datagridwievGorunum
    {
        public void gorunum(DataGridView dgw)
        {
            dgw.BorderStyle = BorderStyle.None;
            dgw.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
            dgw.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 45);
            dgw.DefaultCellStyle.SelectionForeColor = Color.White;
            dgw.EnableHeadersVisualStyles = false;
            dgw.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgw.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
            dgw.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgw.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgw.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
