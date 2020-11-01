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
            this.label4 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnXoapro = new System.Windows.Forms.Button();
            this.btnThempro = new System.Windows.Forms.Button();
            this.btnSuapro = new System.Windows.Forms.Button();
            this.txtTenSPpro = new System.Windows.Forms.TextBox();
            this.txtGiapro = new System.Windows.Forms.TextBox();
            this.txtsoluongpro = new System.Windows.Forms.TextBox();
            this.txtgiamgiapro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbsearchpro = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng còn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giảm giá";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 301);
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
            this.columnHeader2.Text = "Tên sản phẩm";
            this.columnHeader2.Width = 328;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá bán";
            this.columnHeader3.Width = 290;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giảm giá";
            this.columnHeader4.Width = 308;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số lượng còn";
            this.columnHeader5.Width = 202;
            // 
            // btnXoapro
            // 
            this.btnXoapro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(176)))), ((int)(((byte)(211)))));
            this.btnXoapro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoapro.ForeColor = System.Drawing.Color.Transparent;
            this.btnXoapro.Location = new System.Drawing.Point(649, 595);
            this.btnXoapro.Name = "btnXoapro";
            this.btnXoapro.Size = new System.Drawing.Size(174, 39);
            this.btnXoapro.TabIndex = 8;
            this.btnXoapro.Text = "Xóa";
            this.btnXoapro.UseVisualStyleBackColor = false;
            // 
            // btnThempro
            // 
            this.btnThempro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(176)))), ((int)(((byte)(211)))));
            this.btnThempro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThempro.ForeColor = System.Drawing.Color.White;
            this.btnThempro.Location = new System.Drawing.Point(182, 595);
            this.btnThempro.Name = "btnThempro";
            this.btnThempro.Size = new System.Drawing.Size(162, 39);
            this.btnThempro.TabIndex = 7;
            this.btnThempro.Text = "Thêm";
            this.btnThempro.UseVisualStyleBackColor = false;
            // 
            // btnSuapro
            // 
            this.btnSuapro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(176)))), ((int)(((byte)(211)))));
            this.btnSuapro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuapro.ForeColor = System.Drawing.Color.White;
            this.btnSuapro.Location = new System.Drawing.Point(417, 595);
            this.btnSuapro.Name = "btnSuapro";
            this.btnSuapro.Size = new System.Drawing.Size(171, 39);
            this.btnSuapro.TabIndex = 6;
            this.btnSuapro.Text = "Sửa";
            this.btnSuapro.UseVisualStyleBackColor = false;
            // 
            // txtTenSPpro
            // 
            this.txtTenSPpro.Location = new System.Drawing.Point(204, 49);
            this.txtTenSPpro.Name = "txtTenSPpro";
            this.txtTenSPpro.Size = new System.Drawing.Size(374, 20);
            this.txtTenSPpro.TabIndex = 9;
            // 
            // txtGiapro
            // 
            this.txtGiapro.Location = new System.Drawing.Point(204, 90);
            this.txtGiapro.Name = "txtGiapro";
            this.txtGiapro.Size = new System.Drawing.Size(374, 20);
            this.txtGiapro.TabIndex = 10;
            // 
            // txtsoluongpro
            // 
            this.txtsoluongpro.Location = new System.Drawing.Point(204, 134);
            this.txtsoluongpro.Name = "txtsoluongpro";
            this.txtsoluongpro.Size = new System.Drawing.Size(374, 20);
            this.txtsoluongpro.TabIndex = 11;
            // 
            // txtgiamgiapro
            // 
            this.txtgiamgiapro.Location = new System.Drawing.Point(204, 174);
            this.txtgiamgiapro.Name = "txtgiamgiapro";
            this.txtgiamgiapro.Size = new System.Drawing.Size(374, 20);
            this.txtgiamgiapro.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Search By";
            // 
            // cbsearchpro
            // 
            this.cbsearchpro.FormattingEnabled = true;
            this.cbsearchpro.Location = new System.Drawing.Point(204, 215);
            this.cbsearchpro.Name = "cbsearchpro";
            this.cbsearchpro.Size = new System.Drawing.Size(200, 21);
            this.cbsearchpro.TabIndex = 14;
            // 
            // uc_product
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cbsearchpro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtgiamgiapro);
            this.Controls.Add(this.txtsoluongpro);
            this.Controls.Add(this.txtGiapro);
            this.Controls.Add(this.txtTenSPpro);
            this.Controls.Add(this.btnXoapro);
            this.Controls.Add(this.btnThempro);
            this.Controls.Add(this.btnSuapro);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnXoapro;
        private System.Windows.Forms.Button btnThempro;
        private System.Windows.Forms.Button btnSuapro;
        private System.Windows.Forms.TextBox txtTenSPpro;
        private System.Windows.Forms.TextBox txtGiapro;
        private System.Windows.Forms.TextBox txtsoluongpro;
        private System.Windows.Forms.TextBox txtgiamgiapro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbsearchpro;
    }
}
