namespace QuanLyShopDoChoi.Usercontrol
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
            "80.000VND",
            "1525 cái"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Bộ lắm ráp tàu Thousand Sunny",
            "Hạng nặng",
            "60.000VND",
            "10 cái"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "3",
            "Búp bê lọ lem",
            "Búp bê",
            "200.000VND",
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
            this.txtToyID = new System.Windows.Forms.TextBox();
            this.txtToyTitle = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbsearchpro = new System.Windows.Forms.ComboBox();
            this.btnUpdatepro = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbloaidcpro = new System.Windows.Forms.ComboBox();
            this.txtsearchpro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSortpro = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.label1.Location = new System.Drawing.Point(150, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toy ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.label2.Location = new System.Drawing.Point(150, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Toy Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.label3.Location = new System.Drawing.Point(150, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
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
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listView1.Location = new System.Drawing.Point(0, 347);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1020, 271);
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
            this.columnHeader6.Width = 237;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.Width = 183;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Quantity ";
            this.columnHeader5.Width = 151;
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
            this.btnXoapro.Location = new System.Drawing.Point(572, 268);
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
            this.btnThempro.Location = new System.Drawing.Point(329, 268);
            this.btnThempro.Name = "btnThempro";
            this.btnThempro.Size = new System.Drawing.Size(108, 33);
            this.btnThempro.TabIndex = 7;
            this.btnThempro.Text = "Add";
            this.btnThempro.UseVisualStyleBackColor = false;
            // 
            // txtToyID
            // 
            this.txtToyID.Enabled = false;
            this.txtToyID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToyID.Location = new System.Drawing.Point(242, 125);
            this.txtToyID.Name = "txtToyID";
            this.txtToyID.ReadOnly = true;
            this.txtToyID.Size = new System.Drawing.Size(186, 27);
            this.txtToyID.TabIndex = 9;
            // 
            // txtToyTitle
            // 
            this.txtToyTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToyTitle.Location = new System.Drawing.Point(242, 167);
            this.txtToyTitle.Name = "txtToyTitle";
            this.txtToyTitle.Size = new System.Drawing.Size(186, 27);
            this.txtToyTitle.TabIndex = 10;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(242, 209);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(186, 27);
            this.txtPrice.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.label5.Location = new System.Drawing.Point(612, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
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
            this.cbsearchpro.Location = new System.Drawing.Point(690, 322);
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
            this.btnUpdatepro.Location = new System.Drawing.Point(449, 268);
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
            this.label6.Location = new System.Drawing.Point(473, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Kind of toy";
            // 
            // cbloaidcpro
            // 
            this.cbloaidcpro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbloaidcpro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbloaidcpro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbloaidcpro.FormattingEnabled = true;
            this.cbloaidcpro.Items.AddRange(new object[] {
            "Xe",
            "Hạng nặng",
            "Búp bê"});
            this.cbloaidcpro.Location = new System.Drawing.Point(570, 124);
            this.cbloaidcpro.Name = "cbloaidcpro";
            this.cbloaidcpro.Size = new System.Drawing.Size(186, 29);
            this.cbloaidcpro.TabIndex = 17;
            // 
            // txtsearchpro
            // 
            this.txtsearchpro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearchpro.Location = new System.Drawing.Point(757, 321);
            this.txtsearchpro.Name = "txtsearchpro";
            this.txtsearchpro.Size = new System.Drawing.Size(104, 26);
            this.txtsearchpro.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.label4.Location = new System.Drawing.Point(473, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Quantity";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(570, 166);
            this.txtQty.Multiline = true;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(186, 28);
            this.txtQty.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.label7.Location = new System.Drawing.Point(907, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 16);
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
            this.cbSortpro.Location = new System.Drawing.Point(940, 320);
            this.cbSortpro.Name = "cbSortpro";
            this.cbSortpro.Size = new System.Drawing.Size(80, 25);
            this.cbSortpro.TabIndex = 22;
            this.cbSortpro.SelectedIndexChanged += new System.EventHandler(this.cbSortpro_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.label8.Location = new System.Drawing.Point(389, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(225, 58);
            this.label8.TabIndex = 23;
            this.label8.Text = "Products";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.label9.Location = new System.Drawing.Point(473, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 21);
            this.label9.TabIndex = 24;
            this.label9.Text = "Note";
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(570, 208);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(186, 28);
            this.txtNote.TabIndex = 25;
            // 
            // uc_product
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbSortpro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsearchpro);
            this.Controls.Add(this.cbloaidcpro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnUpdatepro);
            this.Controls.Add(this.cbsearchpro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtToyTitle);
            this.Controls.Add(this.txtToyID);
            this.Controls.Add(this.btnXoapro);
            this.Controls.Add(this.btnThempro);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(176)))), ((int)(((byte)(211)))));
            this.Name = "uc_product";
            this.Size = new System.Drawing.Size(934, 538);
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
        private System.Windows.Forms.TextBox txtToyID;
        private System.Windows.Forms.TextBox txtToyTitle;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbsearchpro;
        private System.Windows.Forms.Button btnUpdatepro;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbloaidcpro;
        private System.Windows.Forms.TextBox txtsearchpro;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbSortpro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNote;
    }
}
