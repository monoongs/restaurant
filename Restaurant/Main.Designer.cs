namespace Restaurant
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.stbexit = new System.Windows.Forms.ToolStripButton();
            this.lblfree = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.lblbusy = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsltime = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsldate = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbreport = new System.Windows.Forms.ToolStripButton();
            this.tsllogin = new System.Windows.Forms.ToolStripLabel();
            this.tslloginx = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnclear2 = new System.Windows.Forms.Button();
            this.btntb12 = new System.Windows.Forms.Button();
            this.btntb11 = new System.Windows.Forms.Button();
            this.btntb10 = new System.Windows.Forms.Button();
            this.btntb9 = new System.Windows.Forms.Button();
            this.btntb8 = new System.Windows.Forms.Button();
            this.btntb7 = new System.Windows.Forms.Button();
            this.btntb6 = new System.Windows.Forms.Button();
            this.btntb5 = new System.Windows.Forms.Button();
            this.btntb4 = new System.Windows.Forms.Button();
            this.btntb3 = new System.Windows.Forms.Button();
            this.btntb2 = new System.Windows.Forms.Button();
            this.btntb1 = new System.Windows.Forms.Button();
            this.btnclearhis = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stbexit,
            this.lblfree,
            this.toolStripSeparator4,
            this.lblbusy,
            this.toolStripSeparator2,
            this.tsltime,
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.tsldate,
            this.toolStripLabel3,
            this.toolStripSeparator3,
            this.toolStripSeparator5,
            this.tsbreport,
            this.tsllogin,
            this.tslloginx,
            this.toolStripSeparator6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 424);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(760, 27);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            this.toolStrip1.Layout += new System.Windows.Forms.LayoutEventHandler(this.toolStrip1_Layout);
            // 
            // stbexit
            // 
            this.stbexit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.stbexit.BackColor = System.Drawing.Color.Red;
            this.stbexit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stbexit.Image = ((System.Drawing.Image)(resources.GetObject("stbexit.Image")));
            this.stbexit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stbexit.Name = "stbexit";
            this.stbexit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stbexit.Size = new System.Drawing.Size(53, 24);
            this.stbexit.Text = "Exit";
            this.stbexit.Click += new System.EventHandler(this.stbexit_Click);
            // 
            // lblfree
            // 
            this.lblfree.ForeColor = System.Drawing.Color.Lime;
            this.lblfree.Name = "lblfree";
            this.lblfree.Size = new System.Drawing.Size(38, 24);
            this.lblfree.Text = "โต๊ะว่าง";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // lblbusy
            // 
            this.lblbusy.ForeColor = System.Drawing.Color.Red;
            this.lblbusy.Name = "lblbusy";
            this.lblbusy.Size = new System.Drawing.Size(92, 24);
            this.lblbusy.Text = "โต๊ะไม่ว่าง มี xx โต๊ะ";
            this.lblbusy.Click += new System.EventHandler(this.lblbusy_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tsltime
            // 
            this.tsltime.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsltime.Name = "tsltime";
            this.tsltime.Size = new System.Drawing.Size(34, 24);
            this.tsltime.Text = "Time";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(84, 24);
            this.toolStripLabel1.Text = "System Time : ";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsldate
            // 
            this.tsldate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsldate.Name = "tsldate";
            this.tsldate.Size = new System.Drawing.Size(86, 24);
            this.tsldate.Text = "toolStripLabel2";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(81, 24);
            this.toolStripLabel3.Text = "System Time :";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbreport
            // 
            this.tsbreport.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbreport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tsbreport.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbreport.Image = global::Restaurant.Properties.Resources.reportico;
            this.tsbreport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbreport.Name = "tsbreport";
            this.tsbreport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsbreport.Size = new System.Drawing.Size(74, 24);
            this.tsbreport.Text = "Report";
            this.tsbreport.Click += new System.EventHandler(this.tsbreport_Click);
            // 
            // tsllogin
            // 
            this.tsllogin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsllogin.ForeColor = System.Drawing.Color.Blue;
            this.tsllogin.Name = "tsllogin";
            this.tsllogin.Size = new System.Drawing.Size(46, 24);
            this.tsllogin.Text = "tsllogin";
            // 
            // tslloginx
            // 
            this.tslloginx.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslloginx.ForeColor = System.Drawing.Color.Blue;
            this.tslloginx.Name = "tslloginx";
            this.tslloginx.Size = new System.Drawing.Size(36, 24);
            this.tslloginx.Text = "User :";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(80, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Table 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(256, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Table 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(609, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Table 4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(430, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Table 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(609, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Table 8";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(430, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Table 7";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(256, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Table 6";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.Location = new System.Drawing.Point(80, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Table 5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.Location = new System.Drawing.Point(596, 377);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "Take-away 2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label10.Location = new System.Drawing.Point(416, 377);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 16);
            this.label10.TabIndex = 28;
            this.label10.Text = "Take-away 1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label11.Location = new System.Drawing.Point(256, 377);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "Table 10";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label12.Location = new System.Drawing.Point(80, 377);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "Table 9";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnclear2
            // 
            this.btnclear2.Location = new System.Drawing.Point(214, 340);
            this.btnclear2.Name = "btnclear2";
            this.btnclear2.Size = new System.Drawing.Size(119, 23);
            this.btnclear2.TabIndex = 30;
            this.btnclear2.Text = "Clear 2DTB ชั่วคราว";
            this.btnclear2.UseVisualStyleBackColor = true;
            this.btnclear2.Click += new System.EventHandler(this.button1_Click);
            // 
            // btntb12
            // 
            this.btntb12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntb12.Image = global::Restaurant.Properties.Resources._140722;
            this.btntb12.Location = new System.Drawing.Point(565, 291);
            this.btntb12.Name = "btntb12";
            this.btntb12.Size = new System.Drawing.Size(140, 72);
            this.btntb12.TabIndex = 12;
            this.btntb12.UseVisualStyleBackColor = true;
            this.btntb12.Click += new System.EventHandler(this.btntb12_Click);
            // 
            // btntb11
            // 
            this.btntb11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntb11.Image = global::Restaurant.Properties.Resources._140722;
            this.btntb11.Location = new System.Drawing.Point(388, 291);
            this.btntb11.Name = "btntb11";
            this.btntb11.Size = new System.Drawing.Size(140, 72);
            this.btntb11.TabIndex = 11;
            this.btntb11.UseVisualStyleBackColor = true;
            this.btntb11.Click += new System.EventHandler(this.btntb11_Click);
            // 
            // btntb10
            // 
            this.btntb10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntb10.Image = global::Restaurant.Properties.Resources._14072;
            this.btntb10.Location = new System.Drawing.Point(214, 291);
            this.btntb10.Name = "btntb10";
            this.btntb10.Size = new System.Drawing.Size(140, 72);
            this.btntb10.TabIndex = 10;
            this.btntb10.UseVisualStyleBackColor = true;
            this.btntb10.Click += new System.EventHandler(this.btntb10_Click);
            // 
            // btntb9
            // 
            this.btntb9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntb9.Image = global::Restaurant.Properties.Resources._14072;
            this.btntb9.Location = new System.Drawing.Point(39, 291);
            this.btntb9.Name = "btntb9";
            this.btntb9.Size = new System.Drawing.Size(140, 72);
            this.btntb9.TabIndex = 9;
            this.btntb9.UseVisualStyleBackColor = true;
            this.btntb9.Click += new System.EventHandler(this.btntb9_Click);
            // 
            // btntb8
            // 
            this.btntb8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntb8.Image = global::Restaurant.Properties.Resources._14072;
            this.btntb8.Location = new System.Drawing.Point(565, 162);
            this.btntb8.Name = "btntb8";
            this.btntb8.Size = new System.Drawing.Size(140, 72);
            this.btntb8.TabIndex = 8;
            this.btntb8.UseVisualStyleBackColor = true;
            this.btntb8.Click += new System.EventHandler(this.btntb8_Click);
            // 
            // btntb7
            // 
            this.btntb7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntb7.Image = global::Restaurant.Properties.Resources._14072;
            this.btntb7.Location = new System.Drawing.Point(388, 162);
            this.btntb7.Name = "btntb7";
            this.btntb7.Size = new System.Drawing.Size(140, 72);
            this.btntb7.TabIndex = 7;
            this.btntb7.UseVisualStyleBackColor = true;
            this.btntb7.Click += new System.EventHandler(this.btntb7_Click);
            // 
            // btntb6
            // 
            this.btntb6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntb6.Image = global::Restaurant.Properties.Resources._14072;
            this.btntb6.Location = new System.Drawing.Point(214, 162);
            this.btntb6.Name = "btntb6";
            this.btntb6.Size = new System.Drawing.Size(140, 72);
            this.btntb6.TabIndex = 6;
            this.btntb6.UseVisualStyleBackColor = true;
            this.btntb6.Click += new System.EventHandler(this.btntb6_Click);
            // 
            // btntb5
            // 
            this.btntb5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntb5.Image = global::Restaurant.Properties.Resources._14072;
            this.btntb5.Location = new System.Drawing.Point(39, 162);
            this.btntb5.Name = "btntb5";
            this.btntb5.Size = new System.Drawing.Size(140, 72);
            this.btntb5.TabIndex = 5;
            this.btntb5.UseVisualStyleBackColor = true;
            this.btntb5.Click += new System.EventHandler(this.btntb5_Click);
            // 
            // btntb4
            // 
            this.btntb4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntb4.Image = global::Restaurant.Properties.Resources._14072;
            this.btntb4.Location = new System.Drawing.Point(565, 35);
            this.btntb4.Name = "btntb4";
            this.btntb4.Size = new System.Drawing.Size(140, 72);
            this.btntb4.TabIndex = 4;
            this.btntb4.UseVisualStyleBackColor = true;
            this.btntb4.Click += new System.EventHandler(this.btntb4_Click);
            // 
            // btntb3
            // 
            this.btntb3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntb3.Image = global::Restaurant.Properties.Resources._14072;
            this.btntb3.Location = new System.Drawing.Point(388, 35);
            this.btntb3.Name = "btntb3";
            this.btntb3.Size = new System.Drawing.Size(140, 72);
            this.btntb3.TabIndex = 2;
            this.btntb3.UseVisualStyleBackColor = true;
            this.btntb3.Click += new System.EventHandler(this.btntb3_Click);
            // 
            // btntb2
            // 
            this.btntb2.BackColor = System.Drawing.SystemColors.Control;
            this.btntb2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntb2.Image = global::Restaurant.Properties.Resources._14072;
            this.btntb2.Location = new System.Drawing.Point(214, 35);
            this.btntb2.Name = "btntb2";
            this.btntb2.Size = new System.Drawing.Size(140, 72);
            this.btntb2.TabIndex = 1;
            this.btntb2.UseVisualStyleBackColor = false;
            this.btntb2.Click += new System.EventHandler(this.btntb2_Click);
            // 
            // btntb1
            // 
            this.btntb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntb1.Image = global::Restaurant.Properties.Resources._14072;
            this.btntb1.Location = new System.Drawing.Point(39, 35);
            this.btntb1.Name = "btntb1";
            this.btntb1.Size = new System.Drawing.Size(140, 72);
            this.btntb1.TabIndex = 0;
            this.btntb1.UseVisualStyleBackColor = true;
            this.btntb1.Click += new System.EventHandler(this.btntb1_Click);
            this.btntb1.MouseHover += new System.EventHandler(this.btntb1_MouseHover);
            // 
            // btnclearhis
            // 
            this.btnclearhis.Location = new System.Drawing.Point(388, 340);
            this.btnclearhis.Name = "btnclearhis";
            this.btnclearhis.Size = new System.Drawing.Size(75, 23);
            this.btnclearhis.TabIndex = 31;
            this.btnclearhis.Text = "Clear History";
            this.btnclearhis.UseVisualStyleBackColor = true;
            this.btnclearhis.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 451);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btntb12);
            this.Controls.Add(this.btntb11);
            this.Controls.Add(this.btntb10);
            this.Controls.Add(this.btntb9);
            this.Controls.Add(this.btntb8);
            this.Controls.Add(this.btntb7);
            this.Controls.Add(this.btntb6);
            this.Controls.Add(this.btntb5);
            this.Controls.Add(this.btntb4);
            this.Controls.Add(this.btntb3);
            this.Controls.Add(this.btntb2);
            this.Controls.Add(this.btntb1);
            this.Controls.Add(this.btnclear2);
            this.Controls.Add(this.btnclearhis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntb1;
        private System.Windows.Forms.Button btntb2;
        private System.Windows.Forms.Button btntb3;
        private System.Windows.Forms.Button btntb4;
        private System.Windows.Forms.Button btntb8;
        private System.Windows.Forms.Button btntb7;
        private System.Windows.Forms.Button btntb6;
        private System.Windows.Forms.Button btntb5;
        private System.Windows.Forms.Button btntb12;
        private System.Windows.Forms.Button btntb11;
        private System.Windows.Forms.Button btntb10;
        private System.Windows.Forms.Button btntb9;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton stbexit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripLabel lblbusy;
        private System.Windows.Forms.ToolStripLabel lblfree;
        private System.Windows.Forms.ToolStripLabel tsltime;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tsldate;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Button btnclear2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbreport;
        private System.Windows.Forms.Button btnclearhis;
        private System.Windows.Forms.ToolStripLabel tslloginx;
        private System.Windows.Forms.ToolStripLabel tsllogin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    }
}