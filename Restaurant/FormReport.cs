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
using DGVPrinterHelper;

namespace Restaurant
{
    public partial class frmreport : Form
    {
        public frmreport()
        {
            InitializeComponent();
        }
        

        bool checksearch,checksearch2,chart = false;
        int checkchart,checkchart2 = 0;
        

        private void frmreport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantDataSet.tmp_history' table. You can move, or remove it, as needed.
            this.tmp_historyTableAdapter.Fill(this.restaurantDataSet.tmp_history);
            /*string sql = "select *from invoice";
            DbClass objinvoice = new DbClass();
            DataTable invoice_dt = objinvoice.GetData(sql, "invoice_dt");

            dataGridView1.DataSource = invoice_dt;*/

            //dataGridView1.Rows[0].Cells[0].Selected = false;
            //dataGridView1.CurrentCell = null;

            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            //timer1.Start();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            dateTimePicker3.Value = DateTime.Now;

            txtsearch3.Text = "";

            this.btnsearch1.FlatAppearance.BorderSize = 0;
            this.btnsearch2.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.BorderColor = Color.Black;

            string sql = "SELECT * FROM invoice where รหัสใบเสร็จ =  '" +0+ "'";
            DbClass objinvoice = new DbClass();
            DataTable invoice_dt = objinvoice.GetData(sql, "invoice_dt");
            dataGridView1.DataSource = invoice_dt;

            string sql2 = "SELECT * FROM invoice_detail where รหัสใบเสร็จ =  '" + 0 + "'";
            DbClass objinvoice_detail = new DbClass();
            DataTable invoice_detail_dt = objinvoice_detail.GetData(sql2, "invoice_detail_dt");
            dataGridView2.DataSource = invoice_detail_dt;

            
           
            /*
            int n = gvtb3.Rows.Add();

            gvtb3.Rows[n].Cells[0].Value = Globals.menu1[0];
            gvtb3.Rows[n].Cells[1].Value = Globals.count1[0];
            */
        }

        private void btnsearch1_Click(object sender, EventArgs e)
        {
            if (txtsearch.Text == "")
            {
                string sql = "SELECT * FROM invoice where วันที่ =  '" + Globals.dateshort + "'";
                DbClass objinvoice = new DbClass();
                DataTable invoice_dt = objinvoice.GetData(sql, "invoice_dt");
                dataGridView1.DataSource = invoice_dt;
            }
            else if (checksearch == false)
            {
                string sql = "SELECT * FROM invoice where รหัสใบเสร็จ =  '" + txtsearch.Text + "'";
                DbClass objinvoice = new DbClass();
                DataTable invoice_dt = objinvoice.GetData(sql, "invoice_dt");
                dataGridView1.DataSource = invoice_dt;

            }
            else
            {
                string sql = "SELECT * FROM invoice where วันที่ =  '" + txtsearch.Text + "'";
                DbClass objinvoice = new DbClass();
                DataTable invoice_dt = objinvoice.GetData(sql, "invoice_dt");
                dataGridView1.DataSource = invoice_dt;
            }


            /*
            string contsting = "Data Source=CASPER_PC\\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True";
           SqlConnection conn = new ConnectDB().SqlStrCon();
           SqlCommand connectdb = new SqlCommand(sql, conn);

           try
           {
               SqlDataAdapter sda = new SqlDataAdapter();
               sda.SelectCommand = connectdb;
               DataTable dbdataset = new DataTable();
               sda.Fill(dbdataset);
               BindingSource bsource = new BindingSource();

               bsource.DataSource = dbdataset;
               dataGridView1.DataSource = bsource; //ชื่อดาต้ากริดวิว
               sda.Update(dbdataset);

           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
           }//*/


            

            //DataTable product_dt = objproduct.GetData(sql, "product_dt");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtsearch.Text = dateTimePicker1.Value.Date.ToString("dd/MM/yy");
            checksearch = true;
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            checksearch = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checksearch = false;
            txtsearch.Text = "";
            string sql = "SELECT * FROM invoice where รหัสใบเสร็จ =  '" + 0 + "'";
            DbClass objinvoice = new DbClass();
            DataTable invoice_dt = objinvoice.GetData(sql, "invoice_dt");
            dataGridView1.DataSource = invoice_dt;
        }

        private void btnshowall_Click(object sender, EventArgs e)
        {
            string sql = "select *from invoice";
            DbClass objinvoice = new DbClass();
            DataTable invoice_dt = objinvoice.GetData(sql, "invoice_dt");

            dataGridView1.DataSource = invoice_dt;
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("ไม่มีข้อมูลในตาราง");
            }
            else
            {
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "Invoice Report";
                printer.SubTitle = Globals.dateonly;

                printer.PartText = string.Format("/");

                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "Kanom Chine Bangkok";
                printer.FooterSpacing = 15;

                printer.PrintPreviewNoDisplay(dataGridView1);
            }
                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtsearch.Text == "")
            {
                string sql = "SELECT * FROM invoice_detail where วันที่ =  '" + Globals.dateshort + "'";
                DbClass objinvoice_detail = new DbClass();
                DataTable invoice_detail_dt = objinvoice_detail.GetData(sql, "invoice_detail_dt");
                dataGridView2.DataSource = invoice_detail_dt;
            }
            else if (checksearch2 == false)
            {
                string sql = "SELECT * FROM invoice_detail where รหัสใบเสร็จ =  '" + txtsearch2n.Text + "'";
                DbClass objinvoice_detail = new DbClass();
                DataTable invoice_detail_dt = objinvoice_detail.GetData(sql, "invoice_detail_dt");
                dataGridView2.DataSource = invoice_detail_dt;
            }
            else if (checksearch2 == true)
            {
                string sql = "SELECT * FROM invoice_detail where วันที่ =  '" + txtsearch2.Text + "'";
                DbClass objinvoice_detail = new DbClass();
                DataTable invoice_detail_dt = objinvoice_detail.GetData(sql, "invoice_detail_dt");
                dataGridView2.DataSource = invoice_detail_dt;
            }
        }

        private void btnshowall2_Click(object sender, EventArgs e)
        {
            string sql = "select *from invoice_detail";
            DbClass objinvoice_detail = new DbClass();
            DataTable invoice_detail_dt = objinvoice_detail.GetData(sql, "invoice_detail_dt");
            dataGridView2.DataSource = invoice_detail_dt;
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView2.ClearSelection();
        }

        private void dateTimePicker1_Validated(object sender, EventArgs e)
        {
            /*txtsearch.Text = dateTimePicker1.Value.Date.ToString("dd/MM/yy");
            checksearch = true;*/
        }

        private void txtsearch2_TextChanged(object sender, EventArgs e)
        {
            checksearch2 = false;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            txtsearch2.Text = dateTimePicker2.Value.Date.ToString("dd/MM/yy");
            checksearch2 = true;
            
        }

        private void btnclear2_Click(object sender, EventArgs e)
        {
            checksearch2 = false;
            txtsearch2.Text = "";
            string sql = "SELECT * FROM invoice_detail where รหัสใบเสร็จ =  '" + 0 + "'";
            DbClass objinvoice_detail = new DbClass();
            DataTable invoice_detail_dt = objinvoice_detail.GetData(sql, "invoice_detail_dt");
            dataGridView2.DataSource = invoice_detail_dt;
        }

        private void btnprint2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count == 0)
            {
                MessageBox.Show("ไม่มีข้อมูลในตาราง");
            }
            else
            {
                DGVPrinter printer2 = new DGVPrinter();
                printer2.Title = "Invoice_Detail Report";
                //printer2.SubTitle = txtsearch2.Text;
                printer2.SubTitle = Globals.dateonly;

                printer2.PartText = string.Format("/");

                printer2.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer2.PageNumbers = true;
                printer2.PageNumberInHeader = false;
                printer2.PorportionalColumns = true;
                printer2.HeaderCellAlignment = StringAlignment.Near;
                printer2.Footer = "Kanom Chine Bangkok";
                printer2.FooterSpacing = 15;

                printer2.PrintPreviewNoDisplay(dataGridView2);
            }
        }

        private void txtsearch_Enter(object sender, EventArgs e)
        {
            checksearch = false;
            txtsearch.Text = "";
        }

        private void lblinvoice_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtsearch2_Enter(object sender, EventArgs e)
        {
            checksearch2 = false;
            txtsearch2.Text = Globals.dateno;
            
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            gvtb3.Visible = true;
            gvtb4.Visible = false;
            button1.Visible = true;
            button4.Visible = false;
            gvtb3.Rows.Clear();

            double[] percount1 = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            double[] percount2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            double[] percount3 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            double[] percount4 = { 0, 0, 0, 0, 0, };
            double[] percount5 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            double[] sum1 = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            double[] sum2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            double[] sum3 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            double[] sum4 = { 0, 0, 0, 0, 0, };
            double[] sum5 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            double sutti = Globals.sum - Globals.discount - Globals.pasi;
            double perhead = Globals.sum / Globals.pax;

            int i = 0;
            do
            {
                percount1[i] = (Globals.count1[i] * 100) /(Globals.count1[0] + Globals.count1[1] + Globals.count1[2] + Globals.count1[3] + Globals.count1[4] + Globals.count1[5] + Globals.count1[6] + Globals.count1[7] + Globals.count1[8]+ Globals.count2[0] + Globals.count2[1] + Globals.count2[2] + Globals.count2[3] + Globals.count2[4] + Globals.count2[5] + Globals.count2[6] + Globals.count2[7] + Globals.count2[8]+ Globals.count3[0] + Globals.count3[1] + Globals.count3[2] + Globals.count3[3] + Globals.count3[4] + Globals.count3[5] + Globals.count3[6] + Globals.count3[7] + Globals.count3[8] + Globals.count3[9] + Globals.count3[10] + Globals.count3[11]+ Globals.count4[0] + Globals.count4[1] + Globals.count4[2] + Globals.count4[3] + Globals.count4[4] + Globals.count5[0] + Globals.count5[1] + Globals.count5[2] + Globals.count5[3] + Globals.count5[4] + Globals.count5[5] + Globals.count5[6] + Globals.count5[7] + Globals.count5[8] + Globals.count5[9] + Globals.count5[10]);
                percount2[i] = (Globals.count2[i] * 100) / (Globals.count1[0] + Globals.count1[1] + Globals.count1[2] + Globals.count1[3] + Globals.count1[4] + Globals.count1[5] + Globals.count1[6] + Globals.count1[7] + Globals.count1[8] + Globals.count2[0] + Globals.count2[1] + Globals.count2[2] + Globals.count2[3] + Globals.count2[4] + Globals.count2[5] + Globals.count2[6] + Globals.count2[7] + Globals.count2[8] + Globals.count3[0] + Globals.count3[1] + Globals.count3[2] + Globals.count3[3] + Globals.count3[4] + Globals.count3[5] + Globals.count3[6] + Globals.count3[7] + Globals.count3[8] + Globals.count3[9] + Globals.count3[10] + Globals.count3[11]+ Globals.count4[0] + Globals.count4[1] + Globals.count4[2] + Globals.count4[3] + Globals.count4[4]+ Globals.count5[0] + Globals.count5[1] + Globals.count5[2] + Globals.count5[3] + Globals.count5[4] + Globals.count5[5] + Globals.count5[6] + Globals.count5[7] + Globals.count5[8] + Globals.count5[9] + Globals.count5[10]);
                sum1[i] = (Globals.price1[i] * Globals.count1[i]) * 100 / Globals.sum;
                sum2[i] = (Globals.price2[i] * Globals.count2[i]) * 100 / Globals.sum;
                i++;
            } while (i != 9);

            int j = 0;
            do
            {
                percount3[j] = (Globals.count3[j] * 100) / (Globals.count1[0] + Globals.count1[1] + Globals.count1[2] + Globals.count1[3] + Globals.count1[4] + Globals.count1[5] + Globals.count1[6] + Globals.count1[7] + Globals.count1[8] + Globals.count2[0] + Globals.count2[1] + Globals.count2[2] + Globals.count2[3] + Globals.count2[4] + Globals.count2[5] + Globals.count2[6] + Globals.count2[7] + Globals.count2[8] + Globals.count3[0] + Globals.count3[1] + Globals.count3[2] + Globals.count3[3] + Globals.count3[4] + Globals.count3[5] + Globals.count3[6] + Globals.count3[7] + Globals.count3[8] + Globals.count3[9] + Globals.count3[10] + Globals.count3[11]+ Globals.count4[0] + Globals.count4[1] + Globals.count4[2] + Globals.count4[3] + Globals.count4[4] + Globals.count5[0] + Globals.count5[1] + Globals.count5[2] + Globals.count5[3] + Globals.count5[4] + Globals.count5[5] + Globals.count5[6] + Globals.count5[7] + Globals.count5[8] + Globals.count5[9] + Globals.count5[10]);
                sum3[j] = (Globals.price3[j] * Globals.count3[j]) * 100 / Globals.sum;
                j++;
            } while (j != 12);

            int k = 0;
            do
            {
                percount4[k] = (Globals.count4[k] * 100) / (Globals.count1[0] + Globals.count1[1] + Globals.count1[2] + Globals.count1[3] + Globals.count1[4] + Globals.count1[5] + Globals.count1[6] + Globals.count1[7] + Globals.count1[8] + Globals.count2[0] + Globals.count2[1] + Globals.count2[2] + Globals.count2[3] + Globals.count2[4] + Globals.count2[5] + Globals.count2[6] + Globals.count2[7] + Globals.count2[8] + Globals.count3[0] + Globals.count3[1] + Globals.count3[2] + Globals.count3[3] + Globals.count3[4] + Globals.count3[5] + Globals.count3[6] + Globals.count3[7] + Globals.count3[8] + Globals.count3[9] + Globals.count3[10] + Globals.count3[11] + Globals.count4[0] + Globals.count4[1] + Globals.count4[2] + Globals.count4[3] + Globals.count4[4] + Globals.count5[0] + Globals.count5[1] + Globals.count5[2] + Globals.count5[3] + Globals.count5[4] + Globals.count5[5] + Globals.count5[6] + Globals.count5[7] + Globals.count5[8] + Globals.count5[9] + Globals.count5[10]);
                sum4[k] = (Globals.price4[k] * Globals.count4[k]) * 100 / Globals.sum;
                k++;
            } while (k != 5);

            int l = 0;
            do
            {
                percount5[l] = (Globals.count5[l] * 100) / (Globals.count1[0] + Globals.count1[1] + Globals.count1[2] + Globals.count1[3] + Globals.count1[4] + Globals.count1[5] + Globals.count1[6] + Globals.count1[7] + Globals.count1[8] + Globals.count2[0] + Globals.count2[1] + Globals.count2[2] + Globals.count2[3] + Globals.count2[4] + Globals.count2[5] + Globals.count2[6] + Globals.count2[7] + Globals.count2[8] + Globals.count3[0] + Globals.count3[1] + Globals.count3[2] + Globals.count3[3] + Globals.count3[4] + Globals.count3[5] + Globals.count3[6] + Globals.count3[7] + Globals.count3[8] + Globals.count3[9] + Globals.count3[10] + Globals.count3[11] + Globals.count4[0] + Globals.count4[1] + Globals.count4[2] + Globals.count4[3] + Globals.count4[4] + Globals.count5[0] + Globals.count5[1] + Globals.count5[2] + Globals.count5[3] + Globals.count5[4] + Globals.count5[5] + Globals.count5[6] + Globals.count5[7] + Globals.count5[8] + Globals.count5[9] + Globals.count5[10]);
                sum5[l] = (Globals.price5[l] * Globals.count5[l]) * 100 / Globals.sum;
                l++;
            } while (l != 11);


            /*
            percount1[0] = (Globals.count1[0] * 100) / (Globals.count1[0] + Globals.count1[1] + Globals.count1[2] + Globals.count1[3] + Globals.count1[4] + Globals.count1[5] + Globals.count1[6] + Globals.count1[7] + Globals.count1[8]);
            percount1[1] = (Globals.count1[1] * 100) / (Globals.count1[0] + Globals.count1[1] + Globals.count1[2] + Globals.count1[3] + Globals.count1[4] + Globals.count1[5] + Globals.count1[6] + Globals.count1[7] + Globals.count1[8]);
            percount1[2] = (Globals.count1[2] * 100) / (Globals.count1[0] + Globals.count1[1] + Globals.count1[2] + Globals.count1[3] + Globals.count1[4] + Globals.count1[5] + Globals.count1[6] + Globals.count1[7] + Globals.count1[8]);
            percount1[3] = (Globals.count1[3] * 100) / (Globals.count1[0] + Globals.count1[1] + Globals.count1[2] + Globals.count1[3] + Globals.count1[4] + Globals.count1[5] + Globals.count1[6] + Globals.count1[7] + Globals.count1[8]);
            percount1[4] = (Globals.count1[4] * 100) / (Globals.count1[0] + Globals.count1[1] + Globals.count1[2] + Globals.count1[3] + Globals.count1[4] + Globals.count1[5] + Globals.count1[6] + Globals.count1[7] + Globals.count1[8]);
            percount1[5] = (Globals.count1[5] * 100) / (Globals.count1[0] + Globals.count1[1] + Globals.count1[2] + Globals.count1[3] + Globals.count1[4] + Globals.count1[5] + Globals.count1[6] + Globals.count1[7] + Globals.count1[8]);
            percount1[6] = (Globals.count1[6] * 100) / (Globals.count1[0] + Globals.count1[1] + Globals.count1[2] + Globals.count1[3] + Globals.count1[4] + Globals.count1[5] + Globals.count1[6] + Globals.count1[7] + Globals.count1[8]);
            percount1[7] = (Globals.count1[7] * 100) / (Globals.count1[0] + Globals.count1[1] + Globals.count1[2] + Globals.count1[3] + Globals.count1[4] + Globals.count1[5] + Globals.count1[6] + Globals.count1[7] + Globals.count1[8]);
            percount1[8] = (Globals.count1[8] * 100) / (Globals.count1[0] + Globals.count1[1] + Globals.count1[2] + Globals.count1[3] + Globals.count1[4] + Globals.count1[5] + Globals.count1[6] + Globals.count1[7] + Globals.count1[8]);
            */

            int a = 0;
            do
            {
                gvtb3.Rows.Add(Globals.menu1[a], Globals.price1[a], Globals.count1[a], percount1[a].ToString("#.##") + "%", Globals.price1[a] * Globals.count1[a], sum1[a].ToString("#.##") + "%",Globals.dateshort);
                a++;
            } while (a != 9);

            int b = 0;
            do
            {
                gvtb3.Rows.Add(Globals.menu2[b], Globals.price2[b], Globals.count2[b], percount2[b].ToString("#.##") + "%", Globals.price2[b] * Globals.count2[b], sum2[b].ToString("#.##") + "%", Globals.dateshort);
                b++;
            } while (b != 9);

            int c = 0;
            do
            {
                gvtb3.Rows.Add(Globals.menu3[c], Globals.price3[c], Globals.count3[c], percount3[c].ToString("#.##") + "%", Globals.price3[c] * Globals.count3[c], sum3[c].ToString("#.##") + "%", Globals.dateshort);
                c++;
            } while (c != 12);

            int d = 0;
            do
            {
                gvtb3.Rows.Add(Globals.menu4[d], Globals.price4[d], Globals.count4[d], percount4[d].ToString("#.##") + "%", Globals.price4[d] * Globals.count4[d], sum4[d].ToString("#.##") + "%", Globals.dateshort);
                d++;
            } while (d != 5);

            int f = 0;
            do
            {
                gvtb3.Rows.Add(Globals.menu5[f], Globals.price5[f], Globals.count5[f], percount5[f].ToString("#.##") + "%", Globals.price5[f] * Globals.count5[f], sum5[f].ToString("#.##") + "%", Globals.dateshort);
                f++;
            } while (f != 11);

            gvtb3.Rows.Add("", "", "", "", "", "", Globals.dateshort);
            gvtb3.Rows.Add("", "", "", "ยอดขายทั้งหมด", "", Globals.sum, Globals.dateshort);
            gvtb3.Rows.Add("", "", "", "ส่วนลดทั้งหมด", "", Globals.discount, Globals.dateshort);
            gvtb3.Rows.Add("", "", "", "ภาษี", "", Globals.pasi, Globals.dateshort);
            gvtb3.Rows.Add("", "", "", "ยอดขายสุทธิ", "",sutti.ToString("#.##"), Globals.dateshort);
            gvtb3.Rows.Add("", "", "", "จำนวนลูกค้าทั้งหมด", "", Globals.pax, Globals.dateshort);
            gvtb3.Rows.Add("", "", "", "ยอดขายต่อลูกค้าหนึ่งคน", "", perhead.ToString("#.##"), Globals.dateshort);
            /*
            gvtb3.Rows.Add(Globals.menu1[0], Globals.price1[0], Globals.count1[0], percount1[0].ToString("#.##") + "%", Globals.price1[0] * Globals.count1[0], percount1[0].ToString("#.##")+"%");
            gvtb3.Rows.Add(Globals.menu1[1], Globals.price1[1], Globals.count1[1],percount1[1].ToString("#.##")+"%", Globals.price1[1] * Globals.count1[1], (Globals.price1[1] * Globals.count1[1])*100/Globals.sum+"%");
            gvtb3.Rows.Add(Globals.menu1[2], Globals.price1[2], Globals.count1[2],percount1[2].ToString("#.##")+"%", Globals.price1[2] * Globals.count1[2], (Globals.price1[2] * Globals.count1[2])*100/Globals.sum+"%");
            gvtb3.Rows.Add(Globals.menu1[3], Globals.price1[3], Globals.count1[3], percount1[3].ToString("#.##") + "%", Globals.price1[3] * Globals.count1[3], (Globals.price1[3] * Globals.count1[3]) * 100 / Globals.sum + "%");
            gvtb3.Rows.Add(Globals.menu1[4], Globals.price1[4], Globals.count1[4], percount1[4].ToString("#.##") + "%", Globals.price1[4] * Globals.count1[4], (Globals.price1[4] * Globals.count1[4]) * 100 / Globals.sum + "%");
            gvtb3.Rows.Add(Globals.menu1[5], Globals.price1[5], Globals.count1[5], percount1[5].ToString("#.##") + "%", Globals.price1[5] * Globals.count1[5], (Globals.price1[5] * Globals.count1[5]) * 100 / Globals.sum + "%");
            gvtb3.Rows.Add(Globals.menu1[6], Globals.price1[6], Globals.count1[6], percount1[6].ToString("#.##") + "%", Globals.price1[6] * Globals.count1[6], (Globals.price1[6] * Globals.count1[6]) * 100 / Globals.sum + "%");
            gvtb3.Rows.Add(Globals.menu1[7], Globals.price1[7], Globals.count1[7], percount1[7].ToString("#.##") + "%", Globals.price1[7] * Globals.count1[7], (Globals.price1[7] * Globals.count1[7]) * 100 / Globals.sum + "%");
            gvtb3.Rows.Add(Globals.menu1[8], Globals.price1[8], Globals.count1[8], percount1[8].ToString("#.##") + "%", Globals.price1[8] * Globals.count1[8], (Globals.price1[8] * Globals.count1[8]) * 100 / Globals.sum + "%");
            */


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*gvtb3.Rows.Clear();

            int n = gvtb3.Rows.Add();

            gvtb3.Rows[n].Cells[0].Value = Globals.menu1[0];
            gvtb3.Rows[n].Cells[1].Value = Globals.count1[0];*/

            label4.Text = checkchart.ToString();
            label5.Text = checkchart2.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int a = 7 + 7 / 7 + 7 * 7 - 7;
            MessageBox.Show("Anser {0}" + a);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            DGVPrinter printer3 = new DGVPrinter();
            printer3.Title = "Sales Summary";
            printer3.SubTitle = Globals.dateonly;

            printer3.PartText = string.Format("/");

            printer3.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer3.PageNumbers = true;
            printer3.PageNumberInHeader = false;
            printer3.PorportionalColumns = true;
            printer3.HeaderCellAlignment = StringAlignment.Near;
            printer3.Footer = "Kanom Chine Bangkok";
            printer3.FooterSpacing = 15;

            printer3.PrintPreviewNoDisplay(gvtb3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result1 = MessageBox.Show("Do you want to end this day ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                if (Globals.checkendday == 0)
                {
                    //DATABASE history_sale 
                    for (int u = 0; u < gvtb3.Rows.Count; u++)
                    {
                        string sql = "INSERT into history_sale (รายการอาหาร,ราคา,จำนวน,[%จำนวน],ราคารวม,[%ราคารวม],วันที่) " +
                       " VALUES ('" + gvtb3.Rows[u].Cells["menu"].Value + "','" + gvtb3.Rows[u].Cells["count"].Value + "','" + gvtb3.Rows[u].Cells["Column1"].Value + "','" + gvtb3.Rows[u].Cells["Column2"].Value + "','" + gvtb3.Rows[u].Cells["Column3"].Value + "','" + gvtb3.Rows[u].Cells["Column4"].Value + "','" + gvtb3.Rows[u].Cells["Column5"].Value + "');";

                        //MessageBox.Show(sql);
                        int i = new DBClass().SqlExecute(sql);
                    }

                    MessageBox.Show("Saved Successfully");
                    DialogResult result = MessageBox.Show("Do you want to Exit ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string sql3 = "delete from tmp_history";
                        int h = new DBClass().SqlExecute(sql3);

                        Application.Exit();
                    }
                    else if (result == DialogResult.No)
                    {
                        this.Close();
                    }
                    Globals.checkendday = Globals.checkendday + 1;
                }
                else if (Globals.checkendday == 1)
                {
                    MessageBox.Show("Endday was successed");
                }
            }
            



        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            txtsearch3.Text = dateTimePicker3.Value.Date.ToString("dd/MM/yy");

            while (gvtb6.Rows.Count > 0)
            {
                gvtb6.Rows.RemoveAt(0);
            }
            while (gvtb6.Columns.Count > 6)
            {
                gvtb6.Columns.RemoveAt(6);
            }

            string sql = "delete from tmp_history";
            int i = new DBClass().SqlExecute(sql);

            checkchart2 = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtsearch3.Text == "")
            {
                gvtb3.Visible = true;
                gvtb4.Visible = false;
                button1.Visible = true;
                button4.Visible = false;
                gvtb3.Rows.Clear();

                double[] percount1 = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                double[] percount2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                double[] percount3 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                double[] percount4 = { 0, 0, 0, 0, 0, };
                double[] percount5 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                double[] sum1 = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                double[] sum2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                double[] sum3 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                double[] sum4 = { 0, 0, 0, 0, 0, };
                double[] sum5 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

                double sutti = Globals.sum - Globals.discount - Globals.pasi;
                double perhead = Globals.sum / Globals.pax;
                int i = 0;
                do
                {
                    percount1[i] = (Globals.count1[i] * 100) / (Globals.count1[0] + Globals.count1[1] + Globals.count1[2] + Globals.count1[3] + Globals.count1[4] + Globals.count1[5] + Globals.count1[6] + Globals.count1[7] + Globals.count1[8] + Globals.count2[0] + Globals.count2[1] + Globals.count2[2] + Globals.count2[3] + Globals.count2[4] + Globals.count2[5] + Globals.count2[6] + Globals.count2[7] + Globals.count2[8] + Globals.count3[0] + Globals.count3[1] + Globals.count3[2] + Globals.count3[3] + Globals.count3[4] + Globals.count3[5] + Globals.count3[6] + Globals.count3[7] + Globals.count3[8] + Globals.count3[9] + Globals.count3[10] + Globals.count3[11] + Globals.count4[0] + Globals.count4[1] + Globals.count4[2] + Globals.count4[3] + Globals.count4[4] + Globals.count5[0] + Globals.count5[1] + Globals.count5[2] + Globals.count5[3] + Globals.count5[4] + Globals.count5[5] + Globals.count5[6] + Globals.count5[7] + Globals.count5[8] + Globals.count5[9] + Globals.count5[10]);
                    percount2[i] = (Globals.count2[i] * 100) / (Globals.count1[0] + Globals.count1[1] + Globals.count1[2] + Globals.count1[3] + Globals.count1[4] + Globals.count1[5] + Globals.count1[6] + Globals.count1[7] + Globals.count1[8] + Globals.count2[0] + Globals.count2[1] + Globals.count2[2] + Globals.count2[3] + Globals.count2[4] + Globals.count2[5] + Globals.count2[6] + Globals.count2[7] + Globals.count2[8] + Globals.count3[0] + Globals.count3[1] + Globals.count3[2] + Globals.count3[3] + Globals.count3[4] + Globals.count3[5] + Globals.count3[6] + Globals.count3[7] + Globals.count3[8] + Globals.count3[9] + Globals.count3[10] + Globals.count3[11] + Globals.count4[0] + Globals.count4[1] + Globals.count4[2] + Globals.count4[3] + Globals.count4[4] + Globals.count5[0] + Globals.count5[1] + Globals.count5[2] + Globals.count5[3] + Globals.count5[4] + Globals.count5[5] + Globals.count5[6] + Globals.count5[7] + Globals.count5[8] + Globals.count5[9] + Globals.count5[10]);
                    sum1[i] = (Globals.price1[i] * Globals.count1[i]) * 100 / Globals.sum;
                    sum2[i] = (Globals.price2[i] * Globals.count2[i]) * 100 / Globals.sum;
                    i++;
                } while (i != 9);

                int j = 0;
                do
                {
                    percount3[j] = (Globals.count3[j] * 100) / (Globals.count1[0] + Globals.count1[1] + Globals.count1[2] + Globals.count1[3] + Globals.count1[4] + Globals.count1[5] + Globals.count1[6] + Globals.count1[7] + Globals.count1[8] + Globals.count2[0] + Globals.count2[1] + Globals.count2[2] + Globals.count2[3] + Globals.count2[4] + Globals.count2[5] + Globals.count2[6] + Globals.count2[7] + Globals.count2[8] + Globals.count3[0] + Globals.count3[1] + Globals.count3[2] + Globals.count3[3] + Globals.count3[4] + Globals.count3[5] + Globals.count3[6] + Globals.count3[7] + Globals.count3[8] + Globals.count3[9] + Globals.count3[10] + Globals.count3[11] + Globals.count4[0] + Globals.count4[1] + Globals.count4[2] + Globals.count4[3] + Globals.count4[4] + Globals.count5[0] + Globals.count5[1] + Globals.count5[2] + Globals.count5[3] + Globals.count5[4] + Globals.count5[5] + Globals.count5[6] + Globals.count5[7] + Globals.count5[8] + Globals.count5[9] + Globals.count5[10]);
                    sum3[j] = (Globals.price3[j] * Globals.count3[j]) * 100 / Globals.sum;
                    j++;
                } while (j != 12);

                int k = 0;
                do
                {
                    percount4[k] = (Globals.count4[k] * 100) / (Globals.count1[0] + Globals.count1[1] + Globals.count1[2] + Globals.count1[3] + Globals.count1[4] + Globals.count1[5] + Globals.count1[6] + Globals.count1[7] + Globals.count1[8] + Globals.count2[0] + Globals.count2[1] + Globals.count2[2] + Globals.count2[3] + Globals.count2[4] + Globals.count2[5] + Globals.count2[6] + Globals.count2[7] + Globals.count2[8] + Globals.count3[0] + Globals.count3[1] + Globals.count3[2] + Globals.count3[3] + Globals.count3[4] + Globals.count3[5] + Globals.count3[6] + Globals.count3[7] + Globals.count3[8] + Globals.count3[9] + Globals.count3[10] + Globals.count3[11] + Globals.count4[0] + Globals.count4[1] + Globals.count4[2] + Globals.count4[3] + Globals.count4[4] + Globals.count5[0] + Globals.count5[1] + Globals.count5[2] + Globals.count5[3] + Globals.count5[4] + Globals.count5[5] + Globals.count5[6] + Globals.count5[7] + Globals.count5[8] + Globals.count5[9] + Globals.count5[10]);
                    sum4[k] = (Globals.price4[k] * Globals.count4[k]) * 100 / Globals.sum;
                    k++;
                } while (k != 5);

                int l = 0;
                do
                {
                    percount5[l] = (Globals.count5[l] * 100) / (Globals.count1[0] + Globals.count1[1] + Globals.count1[2] + Globals.count1[3] + Globals.count1[4] + Globals.count1[5] + Globals.count1[6] + Globals.count1[7] + Globals.count1[8] + Globals.count2[0] + Globals.count2[1] + Globals.count2[2] + Globals.count2[3] + Globals.count2[4] + Globals.count2[5] + Globals.count2[6] + Globals.count2[7] + Globals.count2[8] + Globals.count3[0] + Globals.count3[1] + Globals.count3[2] + Globals.count3[3] + Globals.count3[4] + Globals.count3[5] + Globals.count3[6] + Globals.count3[7] + Globals.count3[8] + Globals.count3[9] + Globals.count3[10] + Globals.count3[11] + Globals.count4[0] + Globals.count4[1] + Globals.count4[2] + Globals.count4[3] + Globals.count4[4] + Globals.count5[0] + Globals.count5[1] + Globals.count5[2] + Globals.count5[3] + Globals.count5[4] + Globals.count5[5] + Globals.count5[6] + Globals.count5[7] + Globals.count5[8] + Globals.count5[9] + Globals.count5[10]);
                    sum5[l] = (Globals.price5[l] * Globals.count5[l]) * 100 / Globals.sum;
                    l++;
                } while (l != 11);

                

                int a = 0;
                do
                {
                    gvtb3.Rows.Add(Globals.menu1[a], Globals.price1[a], Globals.count1[a], percount1[a].ToString("#.##") + "%", Globals.price1[a] * Globals.count1[a], sum1[a].ToString("#.##") + "%", Globals.dateshort);
                    a++;
                } while (a != 9);

                int b = 0;
                do
                {
                    gvtb3.Rows.Add(Globals.menu2[b], Globals.price2[b], Globals.count2[b], percount2[b].ToString("#.##") + "%", Globals.price2[b] * Globals.count2[b], sum2[b].ToString("#.##") + "%", Globals.dateshort);
                    b++;
                } while (b != 9);

                int c = 0;
                do
                {
                    gvtb3.Rows.Add(Globals.menu3[c], Globals.price3[c], Globals.count3[c], percount3[c].ToString("#.##") + "%", Globals.price3[c] * Globals.count3[c], sum3[c].ToString("#.##") + "%", Globals.dateshort);
                    c++;
                } while (c != 12);

                int d = 0;
                do
                {
                    gvtb3.Rows.Add(Globals.menu4[d], Globals.price4[d], Globals.count4[d], percount4[d].ToString("#.##") + "%", Globals.price4[d] * Globals.count4[d], sum4[d].ToString("#.##") + "%", Globals.dateshort);
                    d++;
                } while (d != 5);

                int f = 0;
                do
                {
                    gvtb3.Rows.Add(Globals.menu5[f], Globals.price5[f], Globals.count5[f], percount5[f].ToString("#.##") + "%", Globals.price5[f] * Globals.count5[f], sum5[f].ToString("#.##") + "%", Globals.dateshort);
                    f++;
                } while (f != 11);

                gvtb3.Rows.Add("", "", "", "", "", "", Globals.dateshort);
                gvtb3.Rows.Add("", "", "", "ยอดขายทั้งหมด", "", Globals.sum, Globals.dateshort);
                gvtb3.Rows.Add("", "", "", "ส่วนลดทั้งหมด", "", Globals.discount, Globals.dateshort);
                gvtb3.Rows.Add("", "", "", "ภาษี", "", Globals.pasi, Globals.dateshort);
                gvtb3.Rows.Add("", "", "", "ยอดขายสุทธิ", "", sutti.ToString("#.##"), Globals.dateshort);
                gvtb3.Rows.Add("", "", "", "จำนวนลูกค้าทั้งหมด", "", Globals.pax, Globals.dateshort);
                gvtb3.Rows.Add("", "", "", "ยอดขายต่อลูกค้าหนึ่งคน", "", perhead.ToString("#.##"), Globals.dateshort);



            }
            else if (txtsearch3.Text == Globals.dateshort)
            {
                gvtb4.Visible = true;
                gvtb3.Visible = false;
                button1.Visible = false;
                button4.Visible = true;

                string sql = "SELECT รายการอาหาร,ราคา,จำนวน,[%จำนวน],ราคารวม,[%ราคารวม] FROM history_sale where วันที่ =  '" + Globals.dateshort + "'";
                DbClass objhistory_sale = new DbClass();
                DataTable history_sale_dt = objhistory_sale.GetData(sql, "history_sale_dt");
                gvtb4.DataSource = history_sale_dt;
            }
            else
            {
                gvtb4.Visible = true;
                gvtb3.Visible = false;
                button1.Visible = false;
                button4.Visible = true;
                string sql = "SELECT รายการอาหาร,ราคา,จำนวน,[%จำนวน],ราคารวม,[%ราคารวม] FROM history_sale where วันที่ =  '" + txtsearch3.Text + "'";
                DbClass objhistory_sale = new DbClass();
                DataTable history_sale_dt = objhistory_sale.GetData(sql, "history_sale_dt");
                gvtb4.DataSource = history_sale_dt;
            }
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            DGVPrinter printer4 = new DGVPrinter();
            printer4.Title = "Sales Summary";
            printer4.SubTitle = txtsearch3.Text;

            printer4.PartText = string.Format("/");

            printer4.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer4.PageNumbers = true;
            printer4.PageNumberInHeader = false;
            printer4.PorportionalColumns = true;
            printer4.HeaderCellAlignment = StringAlignment.Near;
            printer4.Footer = "Kanom Chine Bangkok";
            printer4.FooterSpacing = 15;

            printer4.PrintPreviewNoDisplay(gvtb4);
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you to end this day ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Yes");
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("No");
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
                      
        }

        private void btnchart_Click(object sender, EventArgs e)
        {
            if (txtsearch3.Text == "")
            {
                if (checkchart == 0)
                {
                    //MessageBox.Show("Chart OPEN !");

                    double[] percount1 = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                    double[] percount2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                    double[] percount3 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                    double[] percount4 = { 0, 0, 0, 0, 0, };
                    double[] percount5 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                    double[] sum1 = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                    double[] sum2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                    double[] sum3 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                    double[] sum4 = { 0, 0, 0, 0, 0, };
                    double[] sum5 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

                    double sutti = Globals.sum - Globals.discount - Globals.pasi;
                    double perhead = Globals.sum / Globals.pax;
                    int i = 0;
                    do
                    {
                        percount1[i] = (Globals.count1[i] * 100) / (Globals.count1[0] + Globals.count1[1] + Globals.count1[2] + Globals.count1[3] + Globals.count1[4] + Globals.count1[5] + Globals.count1[6] + Globals.count1[7] + Globals.count1[8] + Globals.count2[0] + Globals.count2[1] + Globals.count2[2] + Globals.count2[3] + Globals.count2[4] + Globals.count2[5] + Globals.count2[6] + Globals.count2[7] + Globals.count2[8] + Globals.count3[0] + Globals.count3[1] + Globals.count3[2] + Globals.count3[3] + Globals.count3[4] + Globals.count3[5] + Globals.count3[6] + Globals.count3[7] + Globals.count3[8] + Globals.count3[9] + Globals.count3[10] + Globals.count3[11] + Globals.count4[0] + Globals.count4[1] + Globals.count4[2] + Globals.count4[3] + Globals.count4[4] + Globals.count5[0] + Globals.count5[1] + Globals.count5[2] + Globals.count5[3] + Globals.count5[4] + Globals.count5[5] + Globals.count5[6] + Globals.count5[7] + Globals.count5[8] + Globals.count5[9] + Globals.count5[10]);
                        percount2[i] = (Globals.count2[i] * 100) / (Globals.count1[0] + Globals.count1[1] + Globals.count1[2] + Globals.count1[3] + Globals.count1[4] + Globals.count1[5] + Globals.count1[6] + Globals.count1[7] + Globals.count1[8] + Globals.count2[0] + Globals.count2[1] + Globals.count2[2] + Globals.count2[3] + Globals.count2[4] + Globals.count2[5] + Globals.count2[6] + Globals.count2[7] + Globals.count2[8] + Globals.count3[0] + Globals.count3[1] + Globals.count3[2] + Globals.count3[3] + Globals.count3[4] + Globals.count3[5] + Globals.count3[6] + Globals.count3[7] + Globals.count3[8] + Globals.count3[9] + Globals.count3[10] + Globals.count3[11] + Globals.count4[0] + Globals.count4[1] + Globals.count4[2] + Globals.count4[3] + Globals.count4[4] + Globals.count5[0] + Globals.count5[1] + Globals.count5[2] + Globals.count5[3] + Globals.count5[4] + Globals.count5[5] + Globals.count5[6] + Globals.count5[7] + Globals.count5[8] + Globals.count5[9] + Globals.count5[10]);
                        sum1[i] = (Globals.price1[i] * Globals.count1[i]) * 100 / Globals.sum;
                        sum2[i] = (Globals.price2[i] * Globals.count2[i]) * 100 / Globals.sum;
                        i++;
                    } while (i != 9);

                    int j = 0;
                    do
                    {
                        percount3[j] = (Globals.count3[j] * 100) / (Globals.count1[0] + Globals.count1[1] + Globals.count1[2] + Globals.count1[3] + Globals.count1[4] + Globals.count1[5] + Globals.count1[6] + Globals.count1[7] + Globals.count1[8] + Globals.count2[0] + Globals.count2[1] + Globals.count2[2] + Globals.count2[3] + Globals.count2[4] + Globals.count2[5] + Globals.count2[6] + Globals.count2[7] + Globals.count2[8] + Globals.count3[0] + Globals.count3[1] + Globals.count3[2] + Globals.count3[3] + Globals.count3[4] + Globals.count3[5] + Globals.count3[6] + Globals.count3[7] + Globals.count3[8] + Globals.count3[9] + Globals.count3[10] + Globals.count3[11] + Globals.count4[0] + Globals.count4[1] + Globals.count4[2] + Globals.count4[3] + Globals.count4[4] + Globals.count5[0] + Globals.count5[1] + Globals.count5[2] + Globals.count5[3] + Globals.count5[4] + Globals.count5[5] + Globals.count5[6] + Globals.count5[7] + Globals.count5[8] + Globals.count5[9] + Globals.count5[10]);
                        sum3[j] = (Globals.price3[j] * Globals.count3[j]) * 100 / Globals.sum;
                        j++;
                    } while (j != 12);

                    int k = 0;
                    do
                    {
                        percount4[k] = (Globals.count4[k] * 100) / (Globals.count1[0] + Globals.count1[1] + Globals.count1[2] + Globals.count1[3] + Globals.count1[4] + Globals.count1[5] + Globals.count1[6] + Globals.count1[7] + Globals.count1[8] + Globals.count2[0] + Globals.count2[1] + Globals.count2[2] + Globals.count2[3] + Globals.count2[4] + Globals.count2[5] + Globals.count2[6] + Globals.count2[7] + Globals.count2[8] + Globals.count3[0] + Globals.count3[1] + Globals.count3[2] + Globals.count3[3] + Globals.count3[4] + Globals.count3[5] + Globals.count3[6] + Globals.count3[7] + Globals.count3[8] + Globals.count3[9] + Globals.count3[10] + Globals.count3[11] + Globals.count4[0] + Globals.count4[1] + Globals.count4[2] + Globals.count4[3] + Globals.count4[4] + Globals.count5[0] + Globals.count5[1] + Globals.count5[2] + Globals.count5[3] + Globals.count5[4] + Globals.count5[5] + Globals.count5[6] + Globals.count5[7] + Globals.count5[8] + Globals.count5[9] + Globals.count5[10]);
                        sum4[k] = (Globals.price4[k] * Globals.count4[k]) * 100 / Globals.sum;
                        k++;
                    } while (k != 5);

                    int l = 0;
                    do
                    {
                        percount5[l] = (Globals.count5[l] * 100) / (Globals.count1[0] + Globals.count1[1] + Globals.count1[2] + Globals.count1[3] + Globals.count1[4] + Globals.count1[5] + Globals.count1[6] + Globals.count1[7] + Globals.count1[8] + Globals.count2[0] + Globals.count2[1] + Globals.count2[2] + Globals.count2[3] + Globals.count2[4] + Globals.count2[5] + Globals.count2[6] + Globals.count2[7] + Globals.count2[8] + Globals.count3[0] + Globals.count3[1] + Globals.count3[2] + Globals.count3[3] + Globals.count3[4] + Globals.count3[5] + Globals.count3[6] + Globals.count3[7] + Globals.count3[8] + Globals.count3[9] + Globals.count3[10] + Globals.count3[11] + Globals.count4[0] + Globals.count4[1] + Globals.count4[2] + Globals.count4[3] + Globals.count4[4] + Globals.count5[0] + Globals.count5[1] + Globals.count5[2] + Globals.count5[3] + Globals.count5[4] + Globals.count5[5] + Globals.count5[6] + Globals.count5[7] + Globals.count5[8] + Globals.count5[9] + Globals.count5[10]);
                        sum5[l] = (Globals.price5[l] * Globals.count5[l]) * 100 / Globals.sum;
                        l++;
                    } while (l != 11);



                    int a = 0;
                    do
                    {
                        if (Globals.count1[a] != 0)
                        {
                            gvtb5.Rows.Add(Globals.menu1[a], Globals.price1[a], Globals.count1[a], percount1[a] = Math.Round(percount1[a], 2), Globals.price1[a] * Globals.count1[a], sum1[a] = Math.Round(sum1[a], 2), Globals.dateshort);
                        }
                        a++;
                    } while (a != 9);

                    int b = 0;
                    do
                    {
                        if (Globals.count2[b] != 0)
                        {
                            gvtb5.Rows.Add(Globals.menu2[b], Globals.price2[b], Globals.count2[b], percount2[b] = Math.Round(percount2[b], 2), Globals.price2[b] * Globals.count2[b], sum2[b] = Math.Round(sum2[b], 2), Globals.dateshort);
                        }
                        b++;
                    } while (b != 9);

                    int c = 0;
                    do
                    {
                        if (Globals.count3[c] != 0)
                        {
                            gvtb5.Rows.Add(Globals.menu3[c], Globals.price3[c], Globals.count3[c], percount3[c] = Math.Round(percount3[c], 2), Globals.price3[c] * Globals.count3[c], sum3[c] = Math.Round(sum3[c], 2), Globals.dateshort);
                        }
                        c++;
                    } while (c != 12);

                    int d = 0;
                    do
                    {
                        if (Globals.count4[d] != 0)
                        {
                            gvtb5.Rows.Add(Globals.menu4[d], Globals.price4[d], Globals.count4[d], percount4[d] = Math.Round(percount4[d], 2), Globals.price4[d] * Globals.count4[d], sum4[d] = Math.Round(sum4[d], 2), Globals.dateshort);
                        }
                        d++;
                    } while (d != 5);

                    int f = 0;
                    do
                    {
                        if (Globals.count5[f] != 0)
                        {
                            gvtb5.Rows.Add(Globals.menu5[f], Globals.price5[f], Globals.count5[f], percount5[f] = Math.Round(percount5[f], 2), Globals.price5[f] * Globals.count5[f], sum5[f] = Math.Round(sum5[f], 2), Globals.dateshort);
                        }
                        f++;
                    } while (f != 11);

                    /******************************/

                    //DATABASE history_sale 
                    for (int v = 0; v < gvtb5.Rows.Count; v++)
                    {
                        string sql2 = "INSERT into tmp_history (name,price,qty,pqty,total,ptotal,date) " +
                       " VALUES ('" + gvtb5.Rows[v].Cells["menu2"].Value + "','" + gvtb5.Rows[v].Cells["count2"].Value + "','" + gvtb5.Rows[v].Cells["Column11"].Value + "','" + gvtb5.Rows[v].Cells["Column22"].Value + "','" + gvtb5.Rows[v].Cells["Column33"].Value + "','" + gvtb5.Rows[v].Cells["Column44"].Value + "','" + gvtb5.Rows[v].Cells["Column55"].Value + "');";

                        //MessageBox.Show(sql);
                        int m = new DBClass().SqlExecute(sql2);
                    }

                    //DATABASE history_chart 
                    for (int x = 0; x < gvtb5.Rows.Count; x++)
                    {
                        string sql3 = "INSERT into history_chart (name,price,qty,pqty,total,ptotal,date) " +
                       " VALUES ('" + gvtb5.Rows[x].Cells["menu2"].Value + "','" + gvtb5.Rows[x].Cells["count2"].Value + "','" + gvtb5.Rows[x].Cells["Column11"].Value + "','" + gvtb5.Rows[x].Cells["Column22"].Value + "','" + gvtb5.Rows[x].Cells["Column33"].Value + "','" + gvtb5.Rows[x].Cells["Column44"].Value + "','" + gvtb5.Rows[x].Cells["Column55"].Value + "');";

                        //MessageBox.Show(sql);
                        int n = new DBClass().SqlExecute(sql3);
                    }
                    /********************************/
                    checkchart = 1;
                    checkchart2 = 0;
                    frmchart frmchart = new frmchart();
                    frmchart.Show();
                }
                else if (checkchart == 1)
                {
                    checkchart2 = 0;
                    frmchart frmchart = new frmchart();
                    frmchart.Show();
                }

                
            }
            
            else 
            {
                if (checkchart2 == 0)
                {
                    label3.Text = "YEP!";
                    string sql = "SELECT name,price,qty,pqty,total,ptotal FROM history_chart where date=  '" + txtsearch3.Text + "'";
                    DbClass objhistory_sale = new DbClass();
                    DataTable history_chart_dt = objhistory_sale.GetData(sql, "history_chart_dt");
                    gvtb6.DataSource = history_chart_dt;

                    for (int w = 0; w < gvtb6.Rows.Count; w++)
                    {
                        string sql3 = "INSERT into tmp_history (name,price,qty,pqty,total,ptotal) " +
                       " VALUES ('" + gvtb6.Rows[w].Cells["name"].Value + "','" + gvtb6.Rows[w].Cells["price"].Value + "','" + gvtb6.Rows[w].Cells["qty"].Value + "','" + gvtb6.Rows[w].Cells["pqty"].Value + "','" + gvtb6.Rows[w].Cells["total"].Value + "','" + gvtb6.Rows[w].Cells["ptotal"].Value + "');";

                        //MessageBox.Show(sql);
                        int n = new DBClass().SqlExecute(sql3);
                    }
                    checkchart2 = 1;
                    frmchart frmchart = new frmchart();
                    frmchart.Show();
                }
                else if (checkchart2 == 1)
                {
                    label3.Text = "Hey!";
                    frmchart frmchart = new frmchart();
                    frmchart.Show();
                }
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void txtsearch2n_Enter(object sender, EventArgs e)
        {
            checksearch2 = false;
            txtsearch2n.Text = Globals.dateno;
            
        }

        private void txtsearch3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        public void DrawPieRectangleF(PaintEventArgs e)
        {

            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);

            // Create rectangle for ellipse.
            RectangleF rect = new RectangleF(0.0F, 0.0F, 200.0F, 100.0F);

            // Create start and sweep angles.
            float startAngle = 0.0F;
            float sweepAngle = 45.0F;

            // Draw pie to screen.
            e.Graphics.DrawPie(blackPen, rect, startAngle, sweepAngle);
        }
    }
}
