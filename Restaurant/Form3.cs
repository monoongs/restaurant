using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;



namespace Restaurant
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        public string _txtusername
        {
            get { return txtusername.Text; }
        }

        frmtb1N frmtb1 = new frmtb1N();
        frmtb2 frmtb2 = new frmtb2();
        frmtb3N frmtb3 = new frmtb3N();
        frmtb4 frmtb4 = new frmtb4();
        frmtb5 frmtb5 = new frmtb5();
        frmtb6 frmtb6 = new frmtb6();
        frmtb7 frmtb7 = new frmtb7();
        frmtb8 frmtb8 = new frmtb8();
        frmtb9 frmtb9 = new frmtb9();
        frmtb10 frmtb10 = new frmtb10();
        frmtb11 frmtb11 = new frmtb11();
        frmtb12 frmtb12 = new frmtb12();

            

        SqlConnection Conn = new SqlConnection();


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            /*txtusername.TabStop = false;
            txtpswd.TabStop = false;

            txtusername.ForeColor = Color.Gray;
            txtusername.Text = "Username...";

            txtpswd.PasswordChar = '\0';
            txtpswd.ForeColor = Color.Gray;
            txtpswd.Text = "Password...";*/
            //txtusername.SelectionStart = 0;
            //txtusername.SelectionLength = txtusername.Text.Length;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //this.ControlBox = false;


        }


        private void InitializeMyControl()
        {
            // Set to no text.
            txtpswd.Text = "";
            // The password character is an asterisk.
            //txtpswd.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            txtpswd.MaxLength = 14;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            string strConnString = null;
            string strSQL = null;

            Globals.checkconfirm = 0;

            strConnString = "Data Source=CASPER_PC\\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True";
            objConn.ConnectionString = strConnString;
            objConn.Open();

            int intNumRows = 0;
            strSQL = "SELECT COUNT(*) FROM member WHERE username = '" + this.txtusername.Text + "' AND [password] = '" + this.txtpswd.Text + "' ";
            objCmd = new SqlCommand(strSQL, objConn);
            intNumRows = (int)objCmd.ExecuteScalar(); // (int สำคัญนะสาส)

            
            if (intNumRows > 0)
            {
                frmMain frmmain = new frmMain();
                
                frmmain.Show();
                
                frmmain._txtusernamex = txtusername.Text;
                

                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or Password Incorrect");
            }

            objConn.Close();
            objConn = null;
            
        }

        public void CreateMyPasswordTextBox()
        {
           TextBox txtpsw = new TextBox();
           txtpsw.MaxLength = 8;
           txtpsw.PasswordChar = '*';           
           txtpsw.CharacterCasing = CharacterCasing.Lower;            
           txtpsw.TextAlign = HorizontalAlignment.Center;
        }

        private void txtpswd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusername_Enter(object sender, EventArgs e)
        {

        }

        private void txtusername_Leave(object sender, EventArgs e)
        {

        }

        private void txtusername_Click(object sender, EventArgs e)
        {
            /*txtusername.ForeColor = Color.Black;
            txtusername.Text = "";*/
        }

        private void txtusername_Enter_1(object sender, EventArgs e)
        {
            /*if (txtusername.Text == "Username...")
            {
                txtusername.ForeColor = Color.Black;
                txtusername.Text = "";
            }   */         
           
        }

        private void txtusername_Leave_1(object sender, EventArgs e)
        {
            /*if (txtusername.Text == "")
            {
                txtusername.ForeColor = Color.Gray;
                txtusername.Text = "Username...";
            }*/
        }

        private void txtpswd_Enter(object sender, EventArgs e)
        {
            /*txtpswd.PasswordChar = '*';
            if (txtpswd.Text == "Password...")
            {
                txtpswd.ForeColor = Color.Black;
                txtpswd.Text = "";
            }*/
        }

        private void txtpswd_Leave(object sender, EventArgs e)
        {
           /* txtpswd.PasswordChar = '\0';
            if (txtpswd.Text == "")
            {
                txtpswd.ForeColor = Color.Gray;
                txtpswd.Text = "Password...";
            }*/
        }
    }
}
