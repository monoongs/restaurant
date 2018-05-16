using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class frmchart : Form
    {
        public frmchart()
        {
            InitializeComponent();
        }

        private void frmchart_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantDataSet.tmp_history' table. You can move, or remove it, as needed.
            this.tmp_historyTableAdapter.Fill(this.restaurantDataSet.tmp_history);
            // TODO: This line of code loads data into the 'restaurantDataSet.tmp_history' table. You can move, or remove it, as needed.
            this.tmp_historyTableAdapter.Fill(this.restaurantDataSet.tmp_history);

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmphistoryBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            chart1.Printing.PrintPreview();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
