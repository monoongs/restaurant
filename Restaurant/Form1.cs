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
    public partial class Form1 : Form
    {
        string[] id = new string[] { "00001", "00002", "00003","00004" };
        string[] food = new string[] { "น้ายาปลา", "น้ำพริก", "น้ำยาปู","แกงเขียวหวาน" };
        int[] price = new int[] { 79, 89, 119, 89 };


        
       

        public Form1()
        {
            InitializeComponent();

            
        }

       
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnyapla_Click(object sender, EventArgs e)
        {
            string[] btnyapla1 = { "00001", "น้ำยาปลา", "79" };
            Convert.ToInt32(btnyapla1[2]);

            ListViewItem l1 = new ListViewItem(btnyapla1[0]);
            l1.SubItems.Add(btnyapla1[1]);
            l1.SubItems.Add(btnyapla1[2]);
            lvtb1.Items.Add(l1);

            var sum = this.lvtb1.Items //อ้างตัวแปรthis
              .Cast<ListViewItem>()
              .Sum(item => int.Parse(item.SubItems[2].Text));
            lbltotal.Text = sum.ToString();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnnamprigtb1_Click(object sender, EventArgs e)
        {
            /*string[] btnnamprig = { "00002", "น้ำพริก", "89" };
            Convert.ToInt32(btnnamprig[2]);

            ListViewItem l1 = new ListViewItem(btnnamprig[0]);
            l1.SubItems.Add(btnnamprig[1]);
            l1.SubItems.Add(btnnamprig[2]);
            lvtb1.Items.Add(l1);*/

            string[] btnnamprig = { "00002", "น้ำพริก", "89" };
            Convert.ToInt32(btnnamprig[2]);

            ListViewItem l1 = new ListViewItem(btnnamprig[0]);
            l1.SubItems.Add(btnnamprig[1]);
            l1.SubItems.Add(btnnamprig[2]);
            lvtb1.Items.Add(l1);

            var sum = this.lvtb1.Items //อ้างตัวแปรthis
              .Cast<ListViewItem>()
              .Sum(item => int.Parse(item.SubItems[2].Text));
            lbltotal.Text = sum.ToString();

        }




        public class list1
        {
           
        }

        private void lvtb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnyapoo_Click(object sender, EventArgs e)
        {
            string[] a = { "00003", "น้ำยาปู", "119" };
            string b = "119";
            //Convert.ToInt32(btnyapoo[2]);

            ListViewItem l1 = new ListViewItem(a[0]);
            l1.SubItems.Add(a[1]);
            l1.SubItems.Add(b);
            lvtb1.Items.Add(l1);

            //lbltotal.Text = btnyapoo[2];

            var sum = this.lvtb1.Items //อ้างตัวแปรthis
              .Cast<ListViewItem>()
              .Sum(item => int.Parse(item.SubItems[2].Text));
            lbltotal.Text = sum.ToString();
        }

        private void greencurry_Click(object sender, EventArgs e)
        {
            
            string[] greencurry = { "00004", "แกงเขียวหวาน", "89" };
            Convert.ToInt32(greencurry[2]);

            string[] a = { "00004", "แกงเขียวหวาน","89" };
            int b = 89;

            ListViewItem l1 = new ListViewItem(a[0]);
            l1.SubItems.Add(a[1]);
            l1.SubItems.Add(b.ToString());
            lvtb1.Items.Add(l1);

            var sum = this.lvtb1.Items //อ้างตัวแปรthis
              .Cast<ListViewItem>()
              .Sum(item => int.Parse(item.SubItems[2].Text));
            lbltotal.Text = sum.ToString();

        }

        private void btncashtb1_Click(object sender, EventArgs e)
        {
            var sum = this.lvtb1.Items //อ้างตัวแปรthis
              .Cast<ListViewItem>()
              .Sum(item => int.Parse(item.SubItems[2].Text) );
            lbltotal.Text = sum.ToString();
        }

        private void btnprinttb1_Click(object sender, EventArgs e)
        {
            

        }

        private void btnform2_Click(object sender, EventArgs e)
        {
            frmtb2 goFormtb2 = new frmtb2();
            goFormtb2.Show();
        }
    }
}
