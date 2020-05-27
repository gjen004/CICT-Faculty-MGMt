using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @try
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 13; i++)
            {
                this.dgvDay.Rows.Add();
            }
            
        }

        private void CommitSched()
        {
            foreach (DataGridViewCell cell in dgvDay.SelectedCells)
            {
                //change cell colour
                dgvDay.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Style.BackColor = Color.DimGray;
                dgvDay.ClearSelection();
            }
        }

        private void BtnSet_Click(object sender, EventArgs e)
        {
            CommitSched();
        }
    }
}
