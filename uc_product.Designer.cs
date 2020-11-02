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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.label1.Location = new System.Drawing.Point(148, 19);
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
            this.label2.Location = new System.Drawing.Point(148, 61);
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
            this.label3.Location = new System.Drawing.Point(148, 103);
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
            this.listView1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 222);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1192, 271);
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
            this.btnXoapro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoapro.ForeColor = System.Drawing.Color.Transparent;
            this.btnXoapro.Location = new System.Drawing.Point(515, 520);
            this.btnXoapro.Name = "btnXoapro";
            this.btnXoapro.Size = new System.Drawing.Size(90, 39);
            this.btnXoapro.TabIndex = 8;
            this.btnXoapro.Text = "Delete";
            this.btnXoapro.UseVisualStyleBackColor = false;
            this.btnXoapro.Click += new System.EventHandler(this.btnXoapro_Click);
            // 
            // btnThempro
            // 
            this.btnThempro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(176)))), ((int)(((byte)(211)))));
            this.btnThempro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThempro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThempro.ForeColor = System.Drawing.Color.White;
            this.btnThempro.Location = new System.Drawing.Point(408, 155);
            this.btnThempro.Name = "btnThempro";
            this.btnThempro.Size = new System.Drawing.Size(86, 39);
            this.btnThempro.TabIndex = 7;
            this.btnThempro.Text = "Add";
            this.btnThempro.UseVisualStyleBackColor = false;
            // 
            // btnSuapro
            // 
            this.btnSuapro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(176)))), ((int)(((byte)(211)))));
            this.btnSuapro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuapro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuapro.ForeColor = System.Drawing.Color.White;
            this.btnSuapro.Location = new System.Drawing.Point(403, 520);
            this.btnSuapro.Name = "btnSuapro";
            this.btnSuapro.Size = new System.Drawing.Size(91, 39);
            this.btnSuapro.TabIndex = 6;
            this.btnSuapro.Text = "Edit";
            this.btnSuapro.UseVisualStyleBackColor = false;
            this.btnSuapro.Click += new System.EventHandler(this.btnSuapro_Click);
            // 
            // txtTenSPpro
            // 
            this.txtTenSPpro.Location = new System.Drawing.Point(240, 20);
            this.txtTenSPpro.Name = "txtTenSPpro";
            this.txtTenSPpro.Size = new System.Drawing.Size(186, 20);
            this.txtTenSPpro.TabIndex = 9;
            // 
            // txtGiapro
            // 
            this.txtGiapro.Location = new System.Drawing.Point(240, 62);
            this.txtGiapro.Name = "txtGiapro";
            this.txtGiapro.Size = new System.Drawing.Size(186, 20);
            this.txtGiapro.TabIndex = 10;
            // 
            // txtsoluongpro
            // 
            this.txtsoluongpro.Location = new System.Drawing.Point(240, 104);
            this.txtsoluongpro.Name = "txtsoluongpro";
            this.txtsoluongpro.Size = new System.Drawing.Size(186, 20);
            this.txtsoluongpro.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.label5.Location = new System.Drawing.Point(786, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Search By";
            // 
            // cbsearchpro
            // 
            this.cbsearchpro.FormattingEnabled = true;
            this.cbsearchpro.Location = new System.Drawing.Point(904, 184);
            this.cbsearchpro.Name = "cbsearchpro";
            this.cbsearchpro.Size = new System.Drawing.Size(61, 21);
            this.cbsearchpro.TabIndex = 14;
            // 
            // btnUpdatepro
            // 
            this.btnUpdatepro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(176)))), ((int)(((byte)(211)))));
            this.btnUpdatepro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatepro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatepro.ForeColor = System.Drawing.Color.White;
            this.btnUpdatepro.Location = new System.Drawing.Point(515, 155);
            this.btnUpdatepro.Name = "btnUpdatepro";
            this.btnUpdatepro.Size = new System.Drawing.Size(90, 39);
            this.btnUpdatepro.TabIndex = 15;
            this.btnUpdatepro.Text = "Update";
            this.btnUpdatepro.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.label6.Location = new System.Drawing.Point(471, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Kind of toy";
            // 
            // cbloaidcpro
            // 
            this.cbloaidcpro.FormattingEnabled = true;
            this.cbloaidcpro.Location = new System.Drawing.Point(568, 19);
            this.cbloaidcpro.Name = "cbloaidcpro";
            this.cbloaidcpro.Size = new System.Drawing.Size(186, 21);
            this.cbloaidcpro.TabIndex = 17;
            // 
            // txtsearchpro
            // 
            this.txtsearchpro.Location = new System.Drawing.Point(981, 185);
            this.txtsearchpro.Name = "txtsearchpro";
            this.txtsearchpro.Size = new System.Drawing.Size(104, 20);
            this.txtsearchpro.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.label4.Location = new System.Drawing.Point(471, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Note";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNotepro
            // 
            this.txtNotepro.Location = new System.Drawing.Point(568, 61);
            this.txtNotepro.Multiline = true;
            this.txtNotepro.Name = "txtNotepro";
            this.txtNotepro.Size = new System.Drawing.Size(186, 63);
            this.txtNotepro.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.label7.Location = new System.Drawing.Point(786, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "Sort by nhan";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cbSortpro
            // 
            this.cbSortpro.FormattingEnabled = true;
            this.cbSortpro.Items.AddRange(new object[] {
            "A -> Z",
            "Kind"});
            this.cbSortpro.Location = new System.Drawing.Point(904, 146);
            this.cbSortpro.Name = "cbSortpro";
            this.cbSortpro.Size = new System.Drawing.Size(181, 21);
            this.cbSortpro.TabIndex = 22;
            this.cbSortpro.SelectedIndexChanged += new System.EventHandler(this.cbSortpro_SelectedIndexChanged);
            // 
            // uc_product
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
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
    }
}
