﻿namespace QuanLyShopDoChoi.Usercontrol
{
    partial class uc_product
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Xe máy",
            "Xe",
            "800.000VND",
            "1525 cái"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Bộ lắm ráp tàu Thousand Sunny",
            "Hạng nặng",
            "56.999.999VND",
            "10 cái"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "3",
            "Búp bê lọ lem",
            "Búp bê",
            "6.999.999VND",
            "673 cái"}, -1);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnXoapro = new System.Windows.Forms.Button();
            this.btnThempro = new System.Windows.Forms.Button();
            this.btnSuapro = new System.Windows.Forms.Button();
            this.txtTenSPpro = new System.Windows.Forms.TextBox();
            this.txtGiapro = new System.Windows.Forms.TextBox();
            this.txtsoluongpro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbsearchpro = new System.Windows.Forms.ComboBox();
            this.btnUpdatepro = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbloaidcpro = new System.Windows.Forms.ComboBox();
            this.txtsearchpro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNotepro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSortpro = new System.Windows.Forms.ComboBox();
            this.cboSortpro1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.label1.Location = new System.Drawing.Point(148, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toy title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.label2.Location = new System.Drawing.Point(148, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.label3.Location = new System.Drawing.Point(148, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity ";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader6,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader4});
            this.listView1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listView1.Location = new System.Drawing.Point(0, 257);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1198, 236);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 73;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Toy title";
            this.columnHeader2.Width = 274;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Kind of toy";
            this.columnHeader6.Width = 289;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.Width = 183;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Quantity ";
            this.columnHeader5.Width = 218;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Note";
            this.columnHeader4.Width = 155;
            // 
            // btnXoapro
            // 
            this.btnXoapro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(176)))), ((int)(((byte)(211)))));
            this.btnXoapro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoapro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoapro.ForeColor = System.Drawing.Color.Transparent;
            this.btnXoapro.Location = new System.Drawing.Point(499, 520);
            this.btnXoapro.Name = "btnXoapro";
            this.btnXoapro.Size = new System.Drawing.Size(108, 33);
            this.btnXoapro.TabIndex = 8;
            this.btnXoapro.Text = "Delete";
            this.btnXoapro.UseVisualStyleBackColor = false;
            this.btnXoapro.Click += new System.EventHandler(this.btnXoapro_Click);
            // 
            // btnThempro
            // 
            this.btnThempro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(176)))), ((int)(((byte)(211)))));
            this.btnThempro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThempro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThempro.ForeColor = System.Drawing.Color.White;
            this.btnThempro.Location = new System.Drawing.Point(379, 155);
            this.btnThempro.Name = "btnThempro";
            this.btnThempro.Size = new System.Drawing.Size(108, 33);
            this.btnThempro.TabIndex = 7;
            this.btnThempro.Text = "Add";
            this.btnThempro.UseVisualStyleBackColor = false;
            // 
            // btnSuapro
            // 
            this.btnSuapro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(176)))), ((int)(((byte)(211)))));
            this.btnSuapro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuapro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuapro.ForeColor = System.Drawing.Color.White;
            this.btnSuapro.Location = new System.Drawing.Point(379, 520);
            this.btnSuapro.Name = "btnSuapro";
            this.btnSuapro.Size = new System.Drawing.Size(108, 33);
            this.btnSuapro.TabIndex = 6;
            this.btnSuapro.Text = "Edit";
            this.btnSuapro.UseVisualStyleBackColor = false;
            this.btnSuapro.Click += new System.EventHandler(this.btnSuapro_Click);
            // 
            // txtTenSPpro
            // 
            this.txtTenSPpro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSPpro.Location = new System.Drawing.Point(240, 20);
            this.txtTenSPpro.Name = "txtTenSPpro";
            this.txtTenSPpro.Size = new System.Drawing.Size(186, 27);
            this.txtTenSPpro.TabIndex = 9;
            // 
            // txtGiapro
            // 
            this.txtGiapro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiapro.Location = new System.Drawing.Point(240, 62);
            this.txtGiapro.Name = "txtGiapro";
            this.txtGiapro.Size = new System.Drawing.Size(186, 27);
            this.txtGiapro.TabIndex = 10;
            // 
            // txtsoluongpro
            // 
            this.txtsoluongpro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoluongpro.Location = new System.Drawing.Point(240, 104);
            this.txtsoluongpro.Name = "txtsoluongpro";
            this.txtsoluongpro.Size = new System.Drawing.Size(186, 27);
            this.txtsoluongpro.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.label5.Location = new System.Drawing.Point(610, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Search By";
            // 
            // cbsearchpro
            // 
            this.cbsearchpro.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbsearchpro.FormattingEnabled = true;
            this.cbsearchpro.Items.AddRange(new object[] {
            "ID",
            "Toy title",
            "Kind of toy",
            "Price"});
            this.cbsearchpro.Location = new System.Drawing.Point(688, 219);
            this.cbsearchpro.Name = "cbsearchpro";
            this.cbsearchpro.Size = new System.Drawing.Size(61, 24);
            this.cbsearchpro.TabIndex = 14;
            // 
            // btnUpdatepro
            // 
            this.btnUpdatepro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(176)))), ((int)(((byte)(211)))));
            this.btnUpdatepro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatepro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatepro.ForeColor = System.Drawing.Color.White;
            this.btnUpdatepro.Location = new System.Drawing.Point(499, 155);
            this.btnUpdatepro.Name = "btnUpdatepro";
            this.btnUpdatepro.Size = new System.Drawing.Size(108, 33);
            this.btnUpdatepro.TabIndex = 15;
            this.btnUpdatepro.Text = "Update";
            this.btnUpdatepro.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.label6.Location = new System.Drawing.Point(471, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Kind of toy";
            // 
            // cbloaidcpro
            // 
            this.cbloaidcpro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbloaidcpro.FormattingEnabled = true;
            this.cbloaidcpro.Items.AddRange(new object[] {
            "Xe",
            "Hạng nặng",
            "Búp bê"});
            this.cbloaidcpro.Location = new System.Drawing.Point(568, 19);
            this.cbloaidcpro.Name = "cbloaidcpro";
            this.cbloaidcpro.Size = new System.Drawing.Size(186, 29);
            this.cbloaidcpro.TabIndex = 17;
            // 
            // txtsearchpro
            // 
            this.txtsearchpro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearchpro.Location = new System.Drawing.Point(755, 218);
            this.txtsearchpro.Name = "txtsearchpro";
            this.txtsearchpro.Size = new System.Drawing.Size(104, 26);
            this.txtsearchpro.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.label4.Location = new System.Drawing.Point(471, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Note";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNotepro
            // 
            this.txtNotepro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotepro.Location = new System.Drawing.Point(568, 61);
            this.txtNotepro.Multiline = true;
            this.txtNotepro.Name = "txtNotepro";
            this.txtNotepro.Size = new System.Drawing.Size(186, 70);
            this.txtNotepro.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.label7.Location = new System.Drawing.Point(916, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "List";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cbSortpro
            // 
            this.cbSortpro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSortpro.FormattingEnabled = true;
            this.cbSortpro.Items.AddRange(new object[] {
            "A -> Z",
            "Kind",
            "Toys sold"});
            this.cbSortpro.Location = new System.Drawing.Point(949, 217);
            this.cbSortpro.Name = "cbSortpro";
            this.cbSortpro.Size = new System.Drawing.Size(72, 25);
            this.cbSortpro.TabIndex = 22;
            this.cbSortpro.SelectedIndexChanged += new System.EventHandler(this.cbSortpro_SelectedIndexChanged);
            // 
            // cboSortpro1
            // 
            this.cboSortpro1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSortpro1.FormattingEnabled = true;
            this.cboSortpro1.Items.AddRange(new object[] {
            "ID",
            "Kind of Toy"});
            this.cboSortpro1.Location = new System.Drawing.Point(1027, 217);
            this.cboSortpro1.Name = "cboSortpro1";
            this.cboSortpro1.Size = new System.Drawing.Size(72, 25);
            this.cboSortpro1.TabIndex = 23;
            // 
            // uc_product
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cboSortpro1);
            this.Controls.Add(this.cbSortpro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNotepro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsearchpro);
            this.Controls.Add(this.cbloaidcpro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnUpdatepro);
            this.Controls.Add(this.cbsearchpro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsoluongpro);
            this.Controls.Add(this.txtGiapro);
            this.Controls.Add(this.txtTenSPpro);
            this.Controls.Add(this.btnXoapro);
            this.Controls.Add(this.btnThempro);
            this.Controls.Add(this.btnSuapro);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(176)))), ((int)(((byte)(211)))));
            this.Name = "uc_product";
            this.Size = new System.Drawing.Size(1198, 637);
            this.Load += new System.EventHandler(this.uc_product_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnXoapro;
        private System.Windows.Forms.Button btnThempro;
        private System.Windows.Forms.Button btnSuapro;
        private System.Windows.Forms.TextBox txtTenSPpro;
        private System.Windows.Forms.TextBox txtGiapro;
        private System.Windows.Forms.TextBox txtsoluongpro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbsearchpro;
        private System.Windows.Forms.Button btnUpdatepro;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbloaidcpro;
        private System.Windows.Forms.TextBox txtsearchpro;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNotepro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbSortpro;
        private System.Windows.Forms.ComboBox cboSortpro1;
    }
}
