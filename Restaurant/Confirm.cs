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
    public partial class frmconfirm : Form
    {
        public frmconfirm()
        {
            InitializeComponent();
        }

        private void Confirm_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "delete from tmp_history";
            int i = new DBClass().SqlExecute(sql);

            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmlogin frmlogin = new frmlogin();
            frmMain frmmain = new frmMain();
            this.Hide();
            frmmain.Hide();
            Globals.checkconfirm = 1;
            frmlogin.Show();
        }
    }
}
