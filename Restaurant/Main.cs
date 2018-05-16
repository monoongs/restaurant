using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Restaurant
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public string _txtusernamex
        {
            set { tsllogin.Text = value; }
        }

        public string _txtuser
        {
            get { return tsllogin.Text; }
        }

        frmtb1N frmtb1N = new frmtb1N();
        frmtb2 frmtb2 = new frmtb2();
        frmtb3N frmtb3N = new frmtb3N();
        frmtb4 frmtb4 = new frmtb4();
        frmtb5 frmtb5 = new frmtb5();
        frmtb6 frmtb6 = new frmtb6();
        frmtb7 frmtb7 = new frmtb7();
        frmtb8 frmtb8 = new frmtb8();
        frmtb9 frmtb9 = new frmtb9();
        frmtb10 frmtb10 = new frmtb10();
        frmtb11 frmtb11 = new frmtb11();
        frmtb12 frmtb12 = new frmtb12();


        private void btntb1_Click(object sender, EventArgs e)
        {
            Globals.status1 = 1;

            
            if (frmtb1N.WindowState == FormWindowState.Minimized)
            {
                frmtb1N.WindowState = FormWindowState.Normal;
            }
            else
            {
                frmtb1N._tsluer = tsllogin.Text;
                frmtb1N.Show();
            }
        }

        private void btntb2_Click(object sender, EventArgs e)
        {
            Globals.status2 = 1;

            

            if (frmtb2.WindowState == FormWindowState.Minimized)
            {
                frmtb2.WindowState = FormWindowState.Normal;
            }
            else
            {
                frmtb2._tsluer2 = tsllogin.Text;
                frmtb2.Show();
            }

                //frmtb2.Show();
            //this.Hide();
        }

        private void btntb3_Click(object sender, EventArgs e)
        {
            Globals.status3 = 1;

            
            if (frmtb3N.WindowState == FormWindowState.Minimized)
            {
                frmtb3N.WindowState = FormWindowState.Normal;
            }
            else
            {
                frmtb3N._tsluer3 = tsllogin.Text;
                frmtb3N.Show();
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnre_Click(object sender, EventArgs e)
        {
            
            //frmtb2.WindowState = FormWindowState.Normal;
            if (frmtb2.WindowState == FormWindowState.Minimized)
            {
                frmtb2.WindowState = FormWindowState.Normal;
            }

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();

            //กำหนด ให้เป็น Flat แบบ ไร้ขอบ
            this.btntb1.FlatAppearance.BorderSize = 0;
            this.btntb2.FlatAppearance.BorderSize = 0;
            this.btntb3.FlatAppearance.BorderSize = 0;
            this.btntb4.FlatAppearance.BorderSize = 0;
            this.btntb5.FlatAppearance.BorderSize = 0;
            this.btntb6.FlatAppearance.BorderSize = 0;
            this.btntb7.FlatAppearance.BorderSize = 0;
            this.btntb8.FlatAppearance.BorderSize = 0;
            this.btntb9.FlatAppearance.BorderSize = 0;
            this.btntb10.FlatAppearance.BorderSize = 0;
            this.btntb11.FlatAppearance.BorderSize = 0;
            this.btntb12.FlatAppearance.BorderSize = 0;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            //this.MinimizeBox = false;

        }

        private void btntb1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void stbexit_Click(object sender, EventArgs e)
        {
            frmconfirm frmconfirm = new frmconfirm();
            frmconfirm.Show();
            //MessageBox.Show("Do you want Exit ?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop);
            //Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime localdate = DateTime.Now;
            string date = localdate.ToString("dd/MM/yy");
            string time = localdate.ToString("HH:mm:ss");
            tsltime.Text = time.ToString();
            tsldate.Text = date.ToString();

            
            int busy = Globals.status1 + Globals.status2 + Globals.status3 + Globals.status4 + Globals.status5 + Globals.status6 + Globals.status7 + Globals.status8 + Globals.status9 + Globals.status10;
            int free = 10 - busy;

            lblfree.Text = "โต๊ะว่าง " + free.ToString() + " โต๊ะ";
            lblbusy.Text = "โต๊ะไม่ว่าง "+busy.ToString()+" โต๊ะ";

            if (Globals.checkconfirm == 1)
            {
                this.Hide();
            }

            if (Globals.status1 == 0)
            {
                btntb1.BackColor = Color.Transparent;
            }
            else
            {
                btntb1.BackColor = Color.Red;
            }

            if (Globals.status2 == 0)
            {
                btntb2.BackColor = Color.Transparent;
            }
            else
            {
                btntb2.BackColor = Color.Red;
            }

            if (Globals.status3 == 0)
            {
                btntb3.BackColor = Color.Transparent;
            }
            else
            {
                btntb3.BackColor = Color.Red;
            }

            if (Globals.status4 == 0)
            {
                btntb4.BackColor = Color.Transparent;
            }
            else
            {
                btntb4.BackColor = Color.Red;
            }

            if (Globals.status5 == 0)
            {
                btntb5.BackColor = Color.Transparent;
            }
            else
            {
                btntb5.BackColor = Color.Red;
            }

            if (Globals.status6 == 0)
            {
                btntb6.BackColor = Color.Transparent;
            }
            else
            {
                btntb6.BackColor = Color.Red;
            }

            if (Globals.status7 == 0)
            {
                btntb7.BackColor = Color.Transparent;
            }
            else
            {
                btntb7.BackColor = Color.Red;
            }

            if (Globals.status8 == 0)
            {
                btntb8.BackColor = Color.Transparent;
            }
            else
            {
                btntb8.BackColor = Color.Red;
            }

            if (Globals.status9 == 0)
            {
                btntb9.BackColor = Color.Transparent;
            }
            else
            {
                btntb9.BackColor = Color.Red;
            }

            if (Globals.status10 == 0)
            {
                btntb10.BackColor = Color.Transparent;
            }
            else
            {
                btntb10.BackColor = Color.Red;
            }

            if (Globals.status11 == 0)
            {
                btntb11.BackColor = Color.Transparent;
            }
            else
            {
                btntb11.BackColor = Color.Red;
            }

            if (Globals.status12 == 0)
            {
                btntb12.BackColor = Color.Transparent;
            }
            else
            {
                btntb12.BackColor = Color.Red;
            }


        }

        private void lblbusy_Click(object sender, EventArgs e)
        {

        }

        private void btntb5_Click(object sender, EventArgs e)
        {
            
            Globals.status5 = 1;

            if (frmtb5.WindowState == FormWindowState.Minimized)
            {
                frmtb5.WindowState = FormWindowState.Normal;
            }
            else
            {
                frmtb5._tsluer = tsllogin.Text;
                frmtb5.Show();
            }

        }

        private void btntb6_Click(object sender, EventArgs e)
        {
            
            Globals.status6 = 1;

            if (frmtb6.WindowState == FormWindowState.Minimized)
            {
                frmtb6.WindowState = FormWindowState.Normal;
            }
            else
            {
                frmtb6._tsluer = tsllogin.Text;
                frmtb6.Show();
            }
        }

        private void btntb4_Click(object sender, EventArgs e)
        {
            
            Globals.status4 = 1;

            if (frmtb4.WindowState == FormWindowState.Minimized)
            {
                frmtb4.WindowState = FormWindowState.Normal;
            }
            else
            {
                frmtb4._tsluer4 = tsllogin.Text;
                frmtb4.Show();
            }
        }

        private void btntb7_Click(object sender, EventArgs e)
        {
            
            Globals.status7 = 1;

            if (frmtb7.WindowState == FormWindowState.Minimized)
            {
                frmtb7.WindowState = FormWindowState.Normal;
            }
            else
            {
                frmtb7._tsluer = tsllogin.Text;
                frmtb7.Show();
            }
        }

        private void btntb8_Click(object sender, EventArgs e)
        {
            
            Globals.status8 = 1;

            if (frmtb8.WindowState == FormWindowState.Minimized)
            {
                frmtb8.WindowState = FormWindowState.Normal;
            }
            else
            {
                frmtb8._tsluer = tsllogin.Text;
                frmtb8.Show();
            }
        }

        private void btntb9_Click(object sender, EventArgs e)
        {
            
            Globals.status9 = 1;

            if (frmtb9.WindowState == FormWindowState.Minimized)
            {
                frmtb9.WindowState = FormWindowState.Normal;
            }
            else
            {
                frmtb9._tsluer = tsllogin.Text;
                frmtb9.Show();
            }
        }

        private void btntb10_Click(object sender, EventArgs e)
        {
           
            Globals.status10 = 1;

            if (frmtb10.WindowState == FormWindowState.Minimized)
            {
                frmtb10.WindowState = FormWindowState.Normal;
            }
            else
            {
                frmtb10._tsluer = tsllogin.Text;
                frmtb10.Show();
            }
        }

        private void btntb11_Click(object sender, EventArgs e)
        {
            
            Globals.status11 = 1;

            if (frmtb11.WindowState == FormWindowState.Minimized)
            {
                frmtb11.WindowState = FormWindowState.Normal;
            }
            else
            {
                frmtb11._tsluer = tsllogin.Text;
                frmtb11.Show();
            }
        }

        private void btntb12_Click(object sender, EventArgs e)
        {
            
            Globals.status12 = 1;

            if (frmtb12.WindowState == FormWindowState.Minimized)
            {
                frmtb12.WindowState = FormWindowState.Normal;
            }
            else
            {
                frmtb12._tsluer = tsllogin.Text;
                frmtb12.Show();
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip1_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "delete from invoice where วันที่ =  '" + Globals.dateshort + "'";
            int i = new DBClass().SqlExecute(sql);

            string sql2 = "delete from invoice_detail where วันที่ =  '" + Globals.dateshort + "'";
            int j = new DBClass().SqlExecute(sql2);

            //string sql3 = "delete from history_chart";
            //int k = new DBClass().SqlExecute(sql3);

        }

        private void tsbreport_Click(object sender, EventArgs e)
        {
            frmreport frmreport = new frmreport();
            frmreport.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "delete from history_sale";
            int i = new DBClass().SqlExecute(sql);
        }
    }
}
