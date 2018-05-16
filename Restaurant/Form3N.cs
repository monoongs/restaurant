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
using DGVPrinterHelper;
namespace Restaurant
{
    public partial class frmtb3N : Form
    {

       

        public frmtb3N()
        {
            InitializeComponent();
                       
        }



        public string _lbltable2
        {
            get { return lbltable2.Text; }
            
        }

        public string _uppax2
        {
            get { return uppax2.Text; }

        }

        public string _txttotal
        {
            get { return txttotal.Text; }
        }

        //*****************************************//

        public string _txtcash
        {
            get { return txtcash.Text; }
        }

        public string _txtchange
        {
            get { return txtchange.Text; }
        }

        public string _lbldiscount
        {
            get { return lbldiscount.Text; }
        }

        public string _txttotal2
        {
            get { return txttotal2.Text; }
        }

        public string _date
        {
            get { return lbldate2.Text; }
        }

        public string _tsluer3
        {
            set { tsluser.Text = value; }
        }

        public string _pasi { get { return lblpasi.Text; } }
        public string _pasiaf { get { return lblpasiaf.Text; } }

        /*******************************************************************************/

        int sum = 0;
        int discount = 0;
        int checkdiscount1 = 0;
        int checkdiscount2 = 0;
        int checkdiscount3 = 0;
        int checkdiscount4 = 0;
        int checkdiscount5 = 0;
        
        //0"น้ำยาปลา", 1"น้ำยาไก่", 2"น้ำยาใต้", 3"น้ำพริก", 4"น้ำยาปู", 5"แกงเขียวหวาน", 6"น้ำเงี้ยว", 7"ขนมจีนแกงป่า", 8"ขนมจีนซาวน้ำ"
        double[] count1 = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        double[] count2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        double[] count3 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        double[] count4 = { 0, 0, 0, 0, 0};
        double[] count5 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

        /*******************************************************************************/



        int ttotal = 0;
       

        private void totalbutton()
        {
            int iTotal = 0;
            foreach (DataGridViewRow row2 in this.gvtb.Rows)
            {
                iTotal = iTotal + Convert.ToInt32(row2.Cells["price"].Value);
            }
            this.txttotal.Text = String.Format("{0}", iTotal);
            this.txttotal2.Text = String.Format("{0}", iTotal);

            lbldiscount.Text = "-".ToString();
        }

        double pasi, pasiaf;
        public void tax()
        {
            double a;
            a = int.Parse(txttotal.Text);
            pasi = a * 7 / 100;
            pasiaf = a - pasi;

            lblpasi.Text = pasi.ToString();
            lblpasiaf.Text = pasiaf.ToString();

        }

        void CheckRow(string menu, double price)
        {
            
            bool b = false;
            for (int i = 0; i < gvtb.RowCount; i++)
            {
                if (gvtb[1, i].Value.ToString() == menu)
                {
                    gvtb[0, i].Value = (int)gvtb[0, i].Value + 1;//qty
                    gvtb[2, i].Value = (int)gvtb[0, i].Value * price;//sum price
                    b = true;
                }
            }
            if (b == false)
                gvtb.Rows.Add(1, menu, price);//ถ้าไม่มีใน datagrid ก็ให้ Add
            gvtb.ClearSelection();

        }


        /*public void senttoinvoice() // ส่งค่าจาก Gridbox โต๊ะไปที่ ใบเสร็จ เดี๋ยวปรับปรุงอีกที
        {
            string contsting = "Data Source=CASPER_PC\\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True";
            SqlConnection conn = new ConnectDB().SqlStrCon();
            SqlCommand connectdb = new SqlCommand("select food_id , food_name , food_price from tmpOrder", conn);

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
            }
        }*/

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();

            DateTime localDate = DateTime.Now;
            string dateonly = localDate.ToString("dd/MM/yy");
            string timeonly = localDate.ToString("HH:mm");
            lbldate2.Text = dateonly.ToString();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ControlBox = false;

            gvtb.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            

            int PreferredZoomValue = 100;

            printPreviewDialog1.PrintPreviewControl.Zoom = PreferredZoomValue / 100f;
            printPreviewDialog2.PrintPreviewControl.Zoom = PreferredZoomValue / 100f;
            printPreviewDialog2.WindowState = FormWindowState.Maximized;
            printPreviewDialog1.WindowState = FormWindowState.Maximized;

            


            //gvtb.Rows[1].Visible = false;
            //gvtb.ColumnHeadersVisible = false;
            //gvtb.Rows[0].RowHeadersVisible = false;

        }

        


        private void btnyapla1_Click(object sender, EventArgs e)
        {
            Globals.checkprintbutton = true;
            this.CheckRow("น้ำยาปลา", 79);

            sum = sum + 79;
            count1[0] = count1[0] + 1;

            this.totalbutton();
            

            ///
            //Insert,delete,update แบบใช้ Parameters
            /* First TEST
            string sql4 = "Insert into tmpOrder(food_id,food_name,food_price) " +
                " Values(@food_id,@food_name,@food_price) ";
            SqlParameterCollection param2 = new SqlCommand().Parameters;
            param2.AddWithValue("food_id", SqlDbType.Int).Value = 00001;
            param2.AddWithValue("food_name", SqlDbType.VarChar).Value = "น้ำยาปลา";
            param2.AddWithValue("food_price", SqlDbType.Int).Value = 79;
            int i2 = new DBClass().SqlExecute(sql4, param2);*/


        }
        
        private void btnform1_Click(object sender, EventArgs e)
        {
            Form1 goform1 = new Form1();
            goform1.Show();


        }

        private void lbltotal_Click(object sender, EventArgs e)
        {

        }

        private void btnnamprig1_Click(object sender, EventArgs e)
        {
            this.CheckRow("น้ำพริก", 89);

            this.totalbutton();

            sum = sum + 89;
            count1[3] = count1[3] + 1;
        }

        private void lblchange_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        Bitmap bmp;
        private void btnprint_Click(object sender, EventArgs e)
        {
            /*Globals.checkprint = 1;*/
            /*
            for (int u = 0; u < gvtb.Rows.Count; u++)
            {
                string sql = "INSERT into tmpOrder (food_id,food_name,food_price) " +
                   " VALUES ('" + gvtb.Rows[u].Cells["ID"].Value + "','" + gvtb.Rows[u].Cells["Menu"].Value + "','" + gvtb.Rows[u].Cells["Price"].Value + "');";

                //MessageBox.Show(sql);
                int i = new DBClass().SqlExecute(sql);
                               

            }
            */
            /*frmrecipe1 frmrp1 = new frmrecipe1();
            frmrp1x._lbltablerx =_lbltable2;
            frmrp1x._uppaxrx = _uppax2;
            frmrp1x._txttotalx = _txttotal;
            frmrp1x._lbldiscountx = _lbldiscount;
            frmrp1x._txttotal2x = _txttotal2;
            frmrp1x.Show();*/
            /*
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Customer Report";
            printer.SubTitle = string.Format("-------------------------------45-------");
            
            //printer.PartText = string.Format("TEST");
            
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "FoxLearn";
            printer.FooterSpacing = 15;

            printer.PrintPreviewNoDisplay(gvtb);*/

            /************************************************************/
            if (gvtb.Rows.Count == 0)
            {
                MessageBox.Show("NO DATA");
            }

            else
            {
                gvtb.ClearSelection();

                tax();
                
                Globals.checkprint = 1;
                Globals.counttax = Globals.counttax + 1;
                                
                int height = gvtb.Height;
                gvtb.Height = gvtb.RowCount * gvtb.RowTemplate.Height * 4;
                bmp = new Bitmap(gvtb.Width, gvtb.Height);
                gvtb.DrawToBitmap(bmp, new Rectangle(0, 0, gvtb.Width, gvtb.Height));
                gvtb.Height = height;

                printPreviewDialog1.ShowDialog();

                lblbillid.Text = (Globals.dateno + Globals.counttax);          
                             

                
                
            }
                

            
            



        }

        private void clear_data()
        {
            while (gvtb.Rows.Count > 0)
            {
                gvtb.Rows.RemoveAt(0);
            }
            while (gvtb.Columns.Count > 3)
            {
                gvtb.Columns.RemoveAt(3);
            }

            txtchange.Text = "".ToString();
            txtcash.Text = 0.ToString();
            txttotal.Text = "".ToString();
            txttotal2.Text = "".ToString();
            lbldiscount.Text = "-".ToString();
            uppax2.Value = 1;

            //count1[0] = 0;
            int i = 0;
            do
            {
                count1[i] = 0;
                count2[i] = 0;
                i++;
            } while (i != 9);

            int h = 0;
            do
            {
                count3[h] = 0;
                h++;
            } while (h != 12);

            
            int g = 0;
            do
            {
                count4[g] = 0;
                g++;
            } while (g != 5) ;

            int f = 0;
            do
            {
                count5[f] = 0;
                f++;
            } while (f != 11);
        }

        int a, b, c;
        private void btncash_Click(object sender, EventArgs e)
        {

            if (txttotal2.Text == "")
            {
                MessageBox.Show("No DATA");
            }
            else
            {
                a = int.Parse(txttotal2.Text);
                b = int.Parse(txtcash.Text);
                c = b - a;

                if (Globals.checkprint == 0)
                {
                    MessageBox.Show("คุณยังไม่ได้ปริ๊นใบเสร็จใบแรก");
                }
                else if (Globals.checkprint == 1)
                {
                    if (string.IsNullOrWhiteSpace(txtcash.Text))
                    {
                        MessageBox.Show("ระบุเงินสดที่รับก่อน");
                    }

                    /*else if (Int32.TryParse(txtcash.Text, out outParse))
                    {
                        MessageBox.Show("ใส่เลขไอสัส");
                    }*/

                    else if (b < a)
                    {
                        MessageBox.Show("รับเงินมาน้อยกว่าราคาอาหาร");
                    }

                    else
                    {

                        txtchange.Text = c.ToString();

                        gvtb.ClearSelection();
                        printPreviewDialog2.ShowDialog();
                        DateTime time = DateTime.Now;
                        int lblbillidint = Convert.ToInt32(lblbillid.Text);
                        int txttotalint = Convert.ToInt32(txttotal.Text);
                        int txtcashint = Convert.ToInt32(txtcash.Text);
                        int txtchangeint = Convert.ToInt32(txtchange.Text);
                        int uppax2int = Convert.ToInt32(uppax2.Text);
                        int txttotal2int = Convert.ToInt32(txttotal2.Text);
                        float lblpasifloat = float.Parse(lblpasi.Text);
                        float lblpasiaffloat = float.Parse(lblpasiaf.Text);
                        string format = "dd/MM/yy";
                        string timeonlyformat = "HH:mm";
                        // lblpasiint = (lblpasi.Text);
                        // string lblpasiafint = (lblpasiaf.Text);
                        string lbldiscounttxt = (lbldiscount.Text);

                        //DATABASE Invoice 
                        string sql = "INSERT into invoice (รหัสใบเสร็จ,จำนวนลูกค้า,ราคา,ส่วนลด,ราคาสุทธิ,เงินสด,เงินทอน,ภาษี,ก่อนบวกภาษี,เวลา,วันที่) " +
                           " VALUES ('" + lblbillid.Text + "','" + uppax2int + "','" + txttotalint + "','" + lbldiscounttxt + "','" + txttotal2int + "','" + txtcashint + "','" + txtchangeint + "','" + lblpasifloat + "','" + lblpasiaffloat + "','" + time.ToString(timeonlyformat) + "','" + time.ToString(format) + "');";

                        //MessageBox.Show(sql);
                        int i = new DBClass().SqlExecute(sql);
                        //--------------------------------------------------------------------------/*/

                        //DATABASE invoice_detail
                        for (int u = 0; u < gvtb.Rows.Count; u++)
                        {
                            string sql2 = "INSERT into invoice_detail (รหัสใบเสร็จ,รายการอาหาร,จำนวน,ราคา,วันที่) " +
                               " VALUES ('" + lblbillid.Text + "','" + gvtb.Rows[u].Cells["menu"].Value + "','" + gvtb.Rows[u].Cells["id"].Value + "','" + gvtb.Rows[u].Cells["price"].Value + "','" + time.ToString(format) + "');";

                            //MessageBox.Show(sql);
                            int j = new DBClass().SqlExecute(sql2);


                        }


                        Globals.checkprint = 0;

                        Globals.pax = Globals.pax + uppax2int;
                        Globals.pasi = Globals.pasi + pasi;
                        Globals.sum = Globals.sum + sum;
                        Globals.discount = Globals.discount + discount;
                        int k = 0;
                        do
                        {
                            Globals.count1[k] = Globals.count1[k] + count1[k];
                            Globals.count2[k] = Globals.count2[k] + count2[k];
                            k++;
                        } while (k != 9);

                        int l = 0;
                        do
                        {
                            Globals.count3[l] = Globals.count3[l] + count3[l];
                            l++;
                        } while (l != 12);

                        int m = 0;
                        do
                        {
                            Globals.count4[m] = Globals.count4[m] + count4[m];
                            m++;
                        } while (m != 5);

                        int n = 0;
                        do
                        {
                            Globals.count5[n] = Globals.count5[n] + count5[n];
                            n++;
                        } while (n != 11);

                        /*
                        Globals.count1[0] = count1[0];
                        Globals.count1[1] = count1[1];
                        Globals.count1[2] = count1[2];
                        Globals.count1[3] = count1[3];
                        Globals.count1[4] = count1[4];
                        Globals.count1[5] = count1[5];
                        Globals.count1[6] = count1[6];
                        Globals.count1[7] = count1[7];
                        Globals.count1[8] = count1[8];
                        */

                    }

                }
            }
            

            

        }

        private void btnyapoo_Click(object sender, EventArgs e)
        {
            this.CheckRow("น้ำยาปู", 119);

            this.totalbutton();

            sum = sum + 119;
            count1[4] = count1[4] + 1;
        }

        private void greencurry_Click(object sender, EventArgs e)
        {
            this.CheckRow("แกงเขียวหวาน",89);

            this.totalbutton();

            sum = sum + 89;
            count1[5] = count1[5] + 1;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            this.clear_data();
        }
        /*if (gvtb.SelectedCells.Count > 0)
            {
                int selectrowindex = gvtb.SelectedCells[3].RowIndex;
        DataGridViewRow selectedRow = gvtb.Rows[selectrowindex];
        sum = sum - selectrowindex;
                MessageBox.Show(sum.ToString()); 
            }*/
    private void btndel_Click(object sender, EventArgs e)
        {

            if (this.gvtb.SelectedRows.Count > 0)
            {
                int selectedrowindex = gvtb.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = gvtb.Rows[selectedrowindex];

                string a = Convert.ToString(selectedRow.Cells["price"].Value);

                int b = int.Parse(a);

                sum = sum - b;

                gvtb.Rows.RemoveAt(this.gvtb.SelectedRows[0].Index);

                this.totalbutton();
            }
                        
            


        }

        private void delete_data()
        {
            string sql = "delete from tmpOrder";
            int i = new DBClass().SqlExecute(sql);

        }
        

        private void button1_Click(object sender, EventArgs e)
        {

            

            this.clear_data();
            this.Hide();
            this.delete_data();

            Globals.status3= 0; //end

            //this.lbltable2 = null;       



        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnhold_Click(object sender, EventArgs e)
        {
            frmMain frmmain = new frmMain();
            //this.Hide();
            //frmmain.Show();
            this.WindowState = FormWindowState.Minimized;
            //this.Visible = true;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Button button = new Button();
            button.Click += new EventHandler(button_Click);

            
        }
        protected void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            // identify which button was clicked and perform necessary actions
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btndis10_Click(object sender, EventArgs e)
        {
            int iTotal = 0;

            if (checkdiscount1 == 0)
            {
                foreach (DataGridViewRow row2 in this.gvtb.Rows)
                {
                    iTotal = iTotal + Convert.ToInt32(row2.Cells["price"].Value);
                }
                this.txttotal.Text = String.Format("{0}", iTotal);
                lbldiscount.Text = "10%";

                discount = iTotal * 10 / 100;
                
                ttotal = iTotal * 90 / 100 + 1;
                txttotal2.Text = ttotal.ToString();

                checkdiscount1 = 1;

                checkdiscount2 = 0;
                checkdiscount3 = 0;
                checkdiscount4 = 0;
                checkdiscount5 = 0;
            }
            else if (checkdiscount1==1)
            {
                this.totalbutton();
                discount = 0;
                checkdiscount1 = 0;
                checkdiscount2 = 0;
                checkdiscount3 = 0;
                checkdiscount4 = 0;
                checkdiscount5 = 0;
            }
            

        }

        private void btndis15_Click(object sender, EventArgs e)
        {

            int iTotal = 0;
           
            if (checkdiscount2 == 0)
            {
                foreach (DataGridViewRow row2 in this.gvtb.Rows)
                {
                    iTotal = iTotal + Convert.ToInt32(row2.Cells["price"].Value);
                }
                this.txttotal.Text = String.Format("{0}", iTotal);
                lbldiscount.Text = "15%";

                discount = iTotal * 15 / 100;
                
                ttotal = iTotal * 85 / 100 + 1;
                txttotal2.Text = ttotal.ToString();

                checkdiscount2 = 1;

                checkdiscount1 = 0;
                checkdiscount3 = 0;
                checkdiscount4 = 0;
                checkdiscount5 = 0;
            }
            else if (checkdiscount2 == 1)
            {
                this.totalbutton();
                discount = 0;
                checkdiscount2 = 0;
                checkdiscount1 = 0;
                checkdiscount5 = 0;
                checkdiscount3 = 0;
                checkdiscount4 = 0;
            }

        }

        private void btndis20_Click(object sender, EventArgs e)
        {
            int iTotal = 0;
            
            if (checkdiscount3 == 0)
            {
                foreach (DataGridViewRow row2 in this.gvtb.Rows)
                {
                    iTotal = iTotal + Convert.ToInt32(row2.Cells["price"].Value);
                }
                this.txttotal.Text = String.Format("{0}", iTotal);
                lbldiscount.Text = "20%";

                discount = iTotal * 20 / 100;
                
                ttotal = iTotal * 80 / 100 + 1;
                txttotal2.Text = ttotal.ToString();

                checkdiscount3 = 1;

                checkdiscount2 = 0;
                checkdiscount1 = 0;
                checkdiscount4 = 0;
                checkdiscount5 = 0;
            }
            else if (checkdiscount3 == 1)
            {
                this.totalbutton();
                discount = 0;
                checkdiscount3 = 0;
                checkdiscount1 = 0;
                checkdiscount2 = 0;
                
                checkdiscount4 = 0;
                checkdiscount5 = 0;
            }

        }

        private void btndis100_Click(object sender, EventArgs e)
        {
            int iTotal = 0;
            
            if (checkdiscount5 == 0)
            {
                foreach (DataGridViewRow row2 in this.gvtb.Rows)
                {
                    iTotal = iTotal + Convert.ToInt32(row2.Cells["price"].Value);
                }
                this.txttotal.Text = String.Format("{0}", iTotal);
                lbldiscount.Text = "FREE";

                discount = iTotal * 0;
                
                ttotal = iTotal * 0;
                txttotal2.Text = ttotal.ToString();

                checkdiscount5 = 1;

                checkdiscount2 = 0;
                checkdiscount3 = 0;
                checkdiscount4 = 0;
                checkdiscount1 = 0;
            }
            else if (checkdiscount5 == 1)
            {
                this.totalbutton();
                discount = 0;
                checkdiscount5 = 0;
                checkdiscount1 = 0;
                checkdiscount2 = 0;
                checkdiscount3 = 0;
                checkdiscount4 = 0;
                
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int[] col = { 130, 250, 410 ,500};
            Font fnt = new Font("Angsana New", 20);
            Font fnt0 = new Font("Angsana New", 20,FontStyle.Italic);
            Font fnt1 = new Font("Angsana New", 24, FontStyle.Bold);
            Font fnt2 = new Font("Angsana New", 24);
            Pen blackpen = new Pen(Color.Black, 3);
            Pen blackpen2 = new Pen(Color.Black, 5);
            int line = 100;
            
            Point p1 = new Point(130, line + 130 );
            Point p2 = new Point(750, line + 130);
            Point p3 = new Point(130, line + 201);
            Point p4 = new Point(750, line + 201);

            int height2 = bmp.Height / 4;

            Point p5 = new Point(200, height2 + line + 432);
            Point p6 = new Point(670, height2 + line + 432);
            Point p7 = new Point(200, height2 + line + 647);
            Point p8 = new Point(670, height2 + line + 647);
            

            //e.Graphics.DrawString("l",fnt, Brushes.Black, 408, line-30);
            e.Graphics.DrawString("KANOM CHINE BANGKOK CO.,LTD", fnt, Brushes.Black, 250, line);//27 250 408-(13.5*12)
            e.Graphics.DrawString("THE MALL BANGKAE / TEL. 02-454-9435", fnt, Brushes.Black, 232, line+28);
            e.Graphics.DrawString("RECEITPT / TAX INVOICE", fnt, Brushes.Black, 295, line+56);

            e.Graphics.DrawLine(blackpen,p1,p2);//line+130

            //e.Graphics.DrawString("BILL : 0000" + Globals.counttax, fnt2, Brushes.Black, col[0], line + 140);
            e.Graphics.DrawString("BILL : " + Globals.dateno+ Globals.counttax, fnt2, Brushes.Black, col[0], line + 140);
            e.Graphics.DrawString("Table : 3",fnt2, Brushes.Black, 315, line + 140);
            e.Graphics.DrawString("Pax : " + _uppax2, fnt2, Brushes.Black, 460, line + 140);
            e.Graphics.DrawString(""+Globals.date, fnt2, Brushes.Black, 560, line + 140);

            e.Graphics.DrawLine(blackpen,p3, p4);//+28
            e.Graphics.DrawLine(blackpen, p3, p4);

            e.Graphics.DrawString("จำนวน",fnt,Brushes.Black,245,line+230);
            e.Graphics.DrawString("รายการ", fnt, Brushes.Black, 335, line+230);
            e.Graphics.DrawString("ราคา", fnt, Brushes.Black, 549, line+230);

            e.Graphics.DrawImage(bmp, 215, line + 285);

            e.Graphics.DrawString("ราคา", fnt, Brushes.Black, 335, height2 + line + 322);
            e.Graphics.DrawString(_txttotal, fnt, Brushes.Black, 549, height2+line+322/*+line + 345*/);

            e.Graphics.DrawString("ส่วลด", fnt, Brushes.Black, 130, height2 + line + 362);
            e.Graphics.DrawString(_lbldiscount, fnt, Brushes.Black, 245, height2 + line + 362);
            e.Graphics.DrawString("ราคาสุทธิ", fnt, Brushes.Black, 335, height2 + line + 362);
            e.Graphics.DrawString(_txttotal2, fnt1, Brushes.Black, 549, height2 + line + 362);

            e.Graphics.DrawLine(blackpen, p5,p6);//+477

            //e.Graphics.DrawString("Description", fnt2, Brushes.Black, 365, height2 + line + 492);

            e.Graphics.DrawString("( VAT  7%    : " + _pasi + "          VAT ABLE    : " + _pasiaf +")", fnt0, Brushes.Black, 245, height2 + line + 462);
            /*e.Graphics.DrawString("( VAT 7%", fnt0, Brushes.Black, 130, height2 + line +462);
            e.Graphics.DrawString(_pasi, fnt0, Brushes.Black, 245, height2 + line +462);
            e.Graphics.DrawString("VAT ABLE",fnt0, Brushes.Black, 335, height2 + line +462);
            e.Graphics.DrawString(_pasiaf+" )", fnt0, Brushes.Black, 549, height2 + line +462);*/

            //e.Graphics.DrawLine(blackpen, p7, p8); //647

            //e.Graphics.DrawString("*** THANK YOU ***", fnt, Brushes.Black, 350, height2 + line +517);//27 250 408-(13.5*12)
            //e.Graphics.DrawString("** Please Come again**", fnt, Brushes.Black, 315, height2 + line + 562);
            //e.Graphics.DrawString("www.kanomchinebangkok.com", fnt, Brushes.Black, 280, height2 + line + 552);

            



            /*
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Customer Report";
            printer.SubTitle = string.Format("-------------------------------45-------");

            //printer.PartText = string.Format("TEST");

            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "FoxLearn";
            printer.FooterSpacing = 15;*/

            ////printer.PrintPreviewNoDisplay(gvtb);


            //e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void gvtb_SelectionChanged(object sender, EventArgs e)
        {
            /*
            if (gvtb.SelectedCells.Count > 0)
            {
                int selectedrowindex = gvtb.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = gvtb.Rows[selectedrowindex];

                string a = Convert.ToString(selectedRow.Cells["price"].Value);

                int b = int.Parse(a);

                lblrowindex.Text = b.ToString();

            }
            */
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            int iTotal = 0;
            int discount = 0;
            if (checkdiscount4 == 0)
            {
                foreach (DataGridViewRow row2 in this.gvtb.Rows)
                {
                    iTotal = iTotal + Convert.ToInt32(row2.Cells["price"].Value);
                }
                this.txttotal.Text = String.Format("{0}", iTotal);
                lbldiscount.Text = "50%";

                discount = iTotal * 50 / 100;
                
                ttotal = iTotal * 50 / 100 + 1;
                txttotal2.Text = ttotal.ToString();

                checkdiscount4 = 1;

                checkdiscount2 = 0;
                checkdiscount3 = 0;
                checkdiscount1 = 0;
                checkdiscount5 = 0;
            }
            else if (checkdiscount4 == 1)
            {
                this.totalbutton();
                discount = 0;
                checkdiscount4 = 0;
                checkdiscount1 = 0;
                checkdiscount2 = 0;
                checkdiscount3 = 0;
                
                checkdiscount5 = 0;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int[] col = { 130, 250, 410, 500 };
            Font fnt = new Font("Angsana New", 20);
            Font fnt0 = new Font("Angsana New", 20, FontStyle.Italic);
            Font fnt1 = new Font("Angsana New", 24, FontStyle.Bold);
            Font fnt2 = new Font("Angsana New", 24);
            Pen blackpen = new Pen(Color.Black, 3);
            Pen blackpen2 = new Pen(Color.Black, 5);
            int line = 100;

            Point p1 = new Point(130, line + 130);
            Point p2 = new Point(750, line + 130);
            Point p3 = new Point(130, line + 201);
            Point p4 = new Point(750, line + 201);

            int height2 = bmp.Height / 4;

            Point p5 = new Point(200, height2 + line + 500);
            Point p6 = new Point(670, height2 + line + 500);
            Point p7 = new Point(200, height2 + line + 647);
            Point p8 = new Point(670, height2 + line + 647);


            //e.Graphics.DrawString("l",fnt, Brushes.Black, 408, line-30);
            e.Graphics.DrawString("KANOM CHINE BANGKOK CO.,LTD", fnt, Brushes.Black, 250, line);//27 250 408-(13.5*12)
            e.Graphics.DrawString("THE MALL BANGKAE / TEL. 02-454-9435", fnt, Brushes.Black, 232, line + 28);
            e.Graphics.DrawString("RECEITPT / TAX INVOICE", fnt, Brushes.Black, 295, line + 56);

            e.Graphics.DrawLine(blackpen, p1, p2);//line+130

            e.Graphics.DrawString("BILL : " + Globals.dateno + Globals.counttax, fnt2, Brushes.Black, col[0], line + 140);
            e.Graphics.DrawString("Table : 3", fnt2, Brushes.Black, 315, line + 140);
            e.Graphics.DrawString("Pax : " + _uppax2, fnt2, Brushes.Black, 460, line + 140);
            e.Graphics.DrawString("" + Globals.date, fnt2, Brushes.Black, 560, line + 140);

            e.Graphics.DrawLine(blackpen, p3, p4);//+28
            e.Graphics.DrawLine(blackpen, p3, p4);

            e.Graphics.DrawString("จำนวน", fnt, Brushes.Black, 245, line + 230);
            e.Graphics.DrawString("รายการ", fnt, Brushes.Black, 335, line + 230);
            e.Graphics.DrawString("ราคา", fnt, Brushes.Black, 549, line + 230);

            e.Graphics.DrawImage(bmp, 215, line + 285);

            e.Graphics.DrawString("ราคา", fnt, Brushes.Black, 335, height2 + line + 322);
            e.Graphics.DrawString(_txttotal, fnt, Brushes.Black, 549, height2 + line + 322/*+line + 345*/);

            e.Graphics.DrawString("ส่วลด", fnt, Brushes.Black, 130, height2 + line + 362);
            e.Graphics.DrawString(_lbldiscount, fnt, Brushes.Black, 245, height2 + line + 362);
            e.Graphics.DrawString("ราคาสุทธิ", fnt, Brushes.Black, 335, height2 + line + 362);
            e.Graphics.DrawString(_txttotal2, fnt1, Brushes.Black, 549, height2 + line + 362);

            e.Graphics.DrawString("เงินสด", fnt, Brushes.Black, 335, height2 + line + 402);
            e.Graphics.DrawString(_txtcash, fnt, Brushes.Black, 549, height2 + line + 402);

            e.Graphics.DrawString("เงินทอน", fnt, Brushes.Black, 335, height2 + line + 440);
            e.Graphics.DrawString(_txtchange, fnt, Brushes.Black, 549, height2 + line + 440);


            e.Graphics.DrawLine(blackpen, p5, p6);//+477 677 500

            //e.Graphics.DrawString("Description", fnt2, Brushes.Black, 365, height2 + line + 492+28);

            e.Graphics.DrawString("( VAT  7%    : "+ _pasi+"          VAT ABLE    : "+_pasiaf+ "          Payment  Cash    :  " + _txtcash+")", fnt0, Brushes.Black, 130, height2 + line +477+48);
            //e.Graphics.DrawString(_pasi, fnt, Brushes.Black, 210, height2 + line +477+48);
            //e.Graphics.DrawString("VAT ABLE : "+_pasiaf, fnt, Brushes.Black, 245, height2 + line + 477+48);
            //e.Graphics.DrawString(_pasiaf, fnt, Brushes.Black, 549, height2 + line + 477+48);

            //e.Graphics.DrawString("Payment : Cash", fnt, Brushes.Black, 335, height2 + line + 587 + 43+40);
            //e.Graphics.DrawString(_txtcash, fnt, Brushes.Black, 549, height2 + line + 587 + 43+40);

            //e.Graphics.DrawLine(blackpen, p7, p8); //647

            /*e.Graphics.DrawString("THANK YOU", fnt, Brushes.Black, 350, height2 + line + 677+28+40);//27 250 408-(13.5*12)
            e.Graphics.DrawString("** Please Come again**", fnt, Brushes.Black, 315, height2 + line + 722+28+40);
            e.Graphics.DrawString("www.kanomchinebangkok.com", fnt, Brushes.Black, 280, height2 + line + 767+28+40);*/
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            this.CheckRow("น้ำยาใต้", 79);

            this.totalbutton();

            sum = sum + 79;
            count1[2] = count1[2] + 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.CheckRow("น้ำเงี้ยว", 89);

            this.totalbutton();

            sum = sum + 89;
            count1[6] = count1[6] + 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.CheckRow("แกงป่า", 79);

            this.totalbutton();

            sum = sum + 79;
            count1[7] = count1[7] + 1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.CheckRow("ปีกไก่รมควัน", 129);

            this.totalbutton();

            sum = sum + 129;
            count2[0] = count2[0] + 1;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.CheckRow("ลูกชิ้นปลาบางกอก", 79);
            sum = sum + 79;
            count2[1] = count2[1] + 1;
            this.totalbutton();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.CheckRow("หมูหมักลวกจิ้ม", 119);
            sum = sum + 119;
            count2[2] = count2[2] + 1;
            this.totalbutton();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.CheckRow("ปอเปี๊ยะบางกอก", 89);
            sum = sum + 129;
            count2[3] = count2[3] + 1;
            this.totalbutton();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.CheckRow("หมูนุ่มบางกอก", 119);
            sum = sum + 119;
            count2[4] = count2[4] + 1;
            this.totalbutton();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.CheckRow("คอหมูอบจิ้มแจ่ว", 119);

            this.totalbutton();

            sum = sum + 119;
            count2[5] = count2[5] + 1;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.CheckRow("ยำลูกชิ้น", 99);
            sum = sum + 99;
            count2[6] = count2[6] + 1;
            this.totalbutton();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.CheckRow("ทอดมันกุ้ง", 119);
            sum = sum + 119;
            count2[7] = count2[7] + 1;
            this.totalbutton();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.CheckRow("ปลากะพงลวกจิ้ม", 119);
            sum = sum + 129;
            count2[8] = count2[8] + 1;
            this.totalbutton();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.CheckRow("คะน้าหมูกรอบ", 129);
            sum = sum + 129;
            count3[0] = count3[0] + 1;
            this.totalbutton();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.CheckRow("ผัดผักรวมมิตร", 119);
            sum = sum + 119;
            count3[1] = count3[1] + 1;
            this.totalbutton();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.CheckRow("หมูกรอบผัดพริกเผา", 119);
            sum = sum + 119;
            count3[2] = count3[2] + 1;
            this.totalbutton();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.CheckRow("น้ำพริกกุ้งสด", 119);
            sum = sum + 119;
            count3[3] = count3[3] + 1;
            this.totalbutton();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.CheckRow("หมูนุ่มผัดกะปิ", 119);
            sum = sum + 119;
            count3[4] = count3[4] + 1;
            this.totalbutton();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.CheckRow("แกงส้มชะอมไข่", 139);
            sum = sum + 139;
            count3[5] = count3[5] + 1;
            this.totalbutton();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.CheckRow("แกงเลียง", 149);
            sum = sum + 149;
            count3[6] = count3[6] + 1;
            this.totalbutton();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.CheckRow("ต้มยำเห็ด", 139);
            sum = sum + 139;
            count3[7] = count3[7] + 1;
            this.totalbutton();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.CheckRow("ต้มแซ่บกระดูกอ่อน", 139);
            sum = sum + 139;
            count3[8] = count3[8] + 1;
            this.totalbutton();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            
            this.CheckRow("น้ำยาไก่", 79);

            this.totalbutton();

            sum = sum + 79;
            count1[1] = count1[1] + 1;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            this.CheckRow("ซาวน้ำ", 129);

            this.totalbutton();

            sum = sum + 129;
            count1[8] = count1[8] + 1;
        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void txtcash_Click(object sender, EventArgs e)
        {
            txtcash.Clear();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            this.CheckRow("ไอศครีมกะทิ", 29);
            this.totalbutton();
            sum = sum + 29;
            count4[0] = count4[0] + 1;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            this.CheckRow("กล้วยไข่ไอศครีม", 35);
            this.totalbutton();
            sum = sum + 35;
            count4[1] = count4[1] + 1;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            this.CheckRow("กล้วยไข่บวชชี", 35);
            this.totalbutton();
            sum = sum + 35;
            count4[2] = count4[2] + 1;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            this.CheckRow("เฉาก๊วย", 29);
            this.totalbutton();
            sum = sum + 29;
            count4[3] = count4[3] + 1;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            this.CheckRow("ทับทิมกรอบ", 35);
            this.totalbutton();
            sum = sum + 35;
            count4[4] = count4[4] + 1;
        }

        private void button42_Click(object sender, EventArgs e)
        {
            this.CheckRow("น้ำใบเตย", 29);
            this.totalbutton();
            sum = sum + 29;
            count5[0] = count5[0] + 1;

        }

        private void button43_Click(object sender, EventArgs e)
        {
            this.CheckRow("น้ำตะไคร้", 29);
            this.totalbutton();
            sum = sum + 29;
            count5[1] = count5[1] + 1;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            this.CheckRow("น้ำเก๊กฮวย", 29);
            this.totalbutton();
            sum = sum + 29;
            count5[2] = count5[2] + 1;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            this.CheckRow("น้ำกระเจี๊ยบ", 29);
            this.totalbutton();
            sum = sum + 29;
            count5[3] = count5[3] + 1;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            this.CheckRow("น้ำลำใย", 29);
            this.totalbutton();
            sum = sum + 29;
            count5[4] = count5[4] + 1;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            this.CheckRow("น้ำมะนาว", 79);
            this.totalbutton();
            sum = sum + 79;
            count5[5] = count5[5] + 1;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            this.CheckRow("ชามะนาว", 49);
            this.totalbutton();
            sum = sum + 49;
            count5[6] = count5[6] + 1;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            this.CheckRow("กาแฟเย็น", 49);
            this.totalbutton();
            sum = sum + 49;
            count5[8] = count5[8] + 1;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            this.CheckRow("น้ำแข็ง", 3);
            this.totalbutton();
            sum = sum + 3;
            count5[9] = count5[9] + 1;
        }

        private void button26_Click_1(object sender, EventArgs e)
        {
            this.CheckRow("น้ำเปล่า", 15);
            this.totalbutton();
            sum = sum + 29;
            count5[10] = count5[10] + 1;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            this.CheckRow("ข้าวเปล่า", 15);
            sum = sum + 15;
            count3[9] = count3[9] + 1;
            this.totalbutton();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            this.CheckRow("ข้าวเหนียว", 15);
            sum = sum + 15;
            count3[10] = count3[10] + 1;
            this.totalbutton();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            this.CheckRow("ขนมจีนเปล่า", 15);
            sum = sum + 15;
            count3[11] = count3[11] + 1;
            this.totalbutton();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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

            tslfree.Text = "โต๊ะว่าง " + free.ToString() + " โต๊ะ";
            tslbusy.Text = "โต๊ะไม่ว่าง " + busy.ToString() + " โต๊ะ";

            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private void txtcash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }           
        }

        private void button44_Click(object sender, EventArgs e)
        {
            this.CheckRow("ชาเย็น", 49);
            this.totalbutton();
            sum = sum + 49;
            count5[7] = count5[7] + 1;
        }

        /*
        Globals.count++;
            showc.Text = Globals.count.ToString();

            /*count++;
            showc.Text = count.ToString();*/
        /*
        if(showc != null)
        {
            showc.Text = count.ToString();
        }*/
    }
}
