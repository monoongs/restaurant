namespace Restaurant
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.greencurry = new System.Windows.Forms.Button();
            this.btnyapoo = new System.Windows.Forms.Button();
            this.btnnamprig1 = new System.Windows.Forms.Button();
            this.btnyapla1 = new System.Windows.Forms.Button();
            this.lvtb1 = new System.Windows.Forms.ListView();
            this.ColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbltotal = new System.Windows.Forms.Label();
            this.btnprinttb1 = new System.Windows.Forms.Button();
            this.btncashtb1 = new System.Windows.Forms.Button();
            this.btnhold = new System.Windows.Forms.Button();
            this.btnform2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.btnform2);
            this.panel1.Controls.Add(this.greencurry);
            this.panel1.Controls.Add(this.btnyapoo);
            this.panel1.Controls.Add(this.btnnamprig1);
            this.panel1.Controls.Add(this.btnyapla1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 577);
            this.panel1.TabIndex = 0;
            // 
            // greencurry
            // 
            this.greencurry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.greencurry.Location = new System.Drawing.Point(17, 83);
            this.greencurry.Name = "greencurry";
            this.greencurry.Size = new System.Drawing.Size(149, 38);
            this.greencurry.TabIndex = 4;
            this.greencurry.Text = "ขนมจีนแกงเขียวหวาน";
            this.greencurry.UseVisualStyleBackColor = true;
            this.greencurry.Click += new System.EventHandler(this.greencurry_Click);
            this.greencurry.MouseLeave += new System.EventHandler(this.btncashtb1_Click);
            // 
            // btnyapoo
            // 
            this.btnyapoo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnyapoo.Location = new System.Drawing.Point(336, 30);
            this.btnyapoo.Name = "btnyapoo";
            this.btnyapoo.Size = new System.Drawing.Size(149, 40);
            this.btnyapoo.TabIndex = 3;
            this.btnyapoo.Text = "ขนมจีนน้ำยาปู";
            this.btnyapoo.UseVisualStyleBackColor = true;
            this.btnyapoo.Click += new System.EventHandler(this.btnyapoo_Click);
            this.btnyapoo.MouseLeave += new System.EventHandler(this.btncashtb1_Click);
            // 
            // btnnamprig1
            // 
            this.btnnamprig1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnnamprig1.Location = new System.Drawing.Point(172, 28);
            this.btnnamprig1.Name = "btnnamprig1";
            this.btnnamprig1.Size = new System.Drawing.Size(149, 40);
            this.btnnamprig1.TabIndex = 2;
            this.btnnamprig1.Text = "ขนมจีนน้ำพริก";
            this.btnnamprig1.UseVisualStyleBackColor = true;
            this.btnnamprig1.Click += new System.EventHandler(this.btnnamprigtb1_Click);
            this.btnnamprig1.MouseLeave += new System.EventHandler(this.btncashtb1_Click);
            // 
            // btnyapla1
            // 
            this.btnyapla1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnyapla1.Location = new System.Drawing.Point(17, 28);
            this.btnyapla1.Name = "btnyapla1";
            this.btnyapla1.Size = new System.Drawing.Size(149, 40);
            this.btnyapla1.TabIndex = 0;
            this.btnyapla1.Text = "ขนมจีนน้ำยาปลา";
            this.btnyapla1.UseVisualStyleBackColor = true;
            this.btnyapla1.Click += new System.EventHandler(this.btnyapla_Click);
            this.btnyapla1.MouseLeave += new System.EventHandler(this.btncashtb1_Click);
            // 
            // lvtb1
            // 
            this.lvtb1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader,
            this.ColumnHeader1,
            this.ColumnHeader2});
            this.lvtb1.Location = new System.Drawing.Point(543, 12);
            this.lvtb1.Name = "lvtb1";
            this.lvtb1.Size = new System.Drawing.Size(340, 278);
            this.lvtb1.TabIndex = 1;
            this.lvtb1.UseCompatibleStateImageBehavior = false;
            this.lvtb1.View = System.Windows.Forms.View.Details;
            this.lvtb1.SelectedIndexChanged += new System.EventHandler(this.lvtb1_SelectedIndexChanged);
            // 
            // ColumnHeader
            // 
            this.ColumnHeader.Text = "รหัสสินค้า";
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "ชื่อสินค้า";
            this.ColumnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ColumnHeader1.Width = 89;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "ราคา";
            this.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ColumnHeader2.Width = 98;
            // 
            // lbltotal
            // 
            this.lbltotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbltotal.Location = new System.Drawing.Point(758, 310);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(68, 73);
            this.lbltotal.TabIndex = 2;
            this.lbltotal.Text = "0";
            // 
            // btnprinttb1
            // 
            this.btnprinttb1.Location = new System.Drawing.Point(744, 416);
            this.btnprinttb1.Name = "btnprinttb1";
            this.btnprinttb1.Size = new System.Drawing.Size(122, 62);
            this.btnprinttb1.TabIndex = 3;
            this.btnprinttb1.Text = "PRINT";
            this.btnprinttb1.UseVisualStyleBackColor = true;
            this.btnprinttb1.Click += new System.EventHandler(this.btnprinttb1_Click);
            // 
            // btncashtb1
            // 
            this.btncashtb1.Location = new System.Drawing.Point(556, 416);
            this.btncashtb1.Name = "btncashtb1";
            this.btncashtb1.Size = new System.Drawing.Size(122, 62);
            this.btncashtb1.TabIndex = 4;
            this.btncashtb1.Text = "CASH";
            this.btncashtb1.UseVisualStyleBackColor = true;
            this.btncashtb1.Click += new System.EventHandler(this.btncashtb1_Click);
            // 
            // btnhold
            // 
            this.btnhold.Location = new System.Drawing.Point(744, 516);
            this.btnhold.Name = "btnhold";
            this.btnhold.Size = new System.Drawing.Size(122, 62);
            this.btnhold.TabIndex = 5;
            this.btnhold.Text = "HOLD";
            this.btnhold.UseVisualStyleBackColor = true;
            // 
            // btnform2
            // 
            this.btnform2.Location = new System.Drawing.Point(33, 491);
            this.btnform2.Name = "btnform2";
            this.btnform2.Size = new System.Drawing.Size(149, 50);
            this.btnform2.TabIndex = 7;
            this.btnform2.Text = "ไปฟอร์ม 2";
            this.btnform2.UseVisualStyleBackColor = true;
            this.btnform2.Click += new System.EventHandler(this.btnform2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(904, 601);
            this.Controls.Add(this.btnhold);
            this.Controls.Add(this.btncashtb1);
            this.Controls.Add(this.btnprinttb1);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lvtb1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvtb1;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button btnprinttb1;
        private System.Windows.Forms.Button btncashtb1;
        private System.Windows.Forms.Button btnhold;
        private System.Windows.Forms.Button btnyapla1;
        private System.Windows.Forms.Button btnnamprig1;
        private System.Windows.Forms.Button btnyapoo;
        private System.Windows.Forms.ColumnHeader ColumnHeader;
        private System.Windows.Forms.ColumnHeader ColumnHeader1;
        private System.Windows.Forms.ColumnHeader ColumnHeader2;
        private System.Windows.Forms.Button greencurry;
        private System.Windows.Forms.Button btnform2;
    }
}

