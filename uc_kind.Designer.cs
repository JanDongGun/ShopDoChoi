namespace QuanLyShopDoChoi.Usercontrol
{
    partial class uc_kind
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
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Xe "}, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Hạng nặng"}, -1);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "3",
            "Búp bê"}, -1);
            this.txtTenLoaiDC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvKind = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThemkind = new System.Windows.Forms.Button();
            this.btnXoakind = new System.Windows.Forms.Button();
            this.btnUpdatek = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKindID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTenLoaiDC
            // 
            this.txtTenLoaiDC.BackColor = System.Drawing.Color.White;
            this.txtTenLoaiDC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaiDC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(176)))), ((int)(((byte)(211)))));
            this.txtTenLoaiDC.Location = new System.Drawing.Point(418, 153);
            this.txtTenLoaiDC.Name = "txtTenLoaiDC";
            this.txtTenLoaiDC.Size = new System.Drawing.Size(237, 27);
            this.txtTenLoaiDC.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.label1.Location = new System.Drawing.Point(311, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kind of toy";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lvKind
            // 
            this.lvKind.BackColor = System.Drawing.SystemColors.Window;
            this.lvKind.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvKind.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvKind.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvKind.ForeColor = System.Drawing.Color.Black;
            this.lvKind.GridLines = true;
            this.lvKind.HideSelection = false;
            this.lvKind.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem7,
            listViewItem8,
            listViewItem9});
            this.lvKind.Location = new System.Drawing.Point(0, 325);
            this.lvKind.Name = "lvKind";
            this.lvKind.Size = new System.Drawing.Size(1198, 312);
            this.lvKind.TabIndex = 2;
            this.lvKind.UseCompatibleStateImageBehavior = false;
            this.lvKind.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 308;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kind of toy";
            this.columnHeader2.Width = 512;
            // 
            // btnThemkind
            // 
            this.btnThemkind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(176)))), ((int)(((byte)(211)))));
            this.btnThemkind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemkind.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemkind.ForeColor = System.Drawing.Color.White;
            this.btnThemkind.Location = new System.Drawing.Point(337, 220);
            this.btnThemkind.Name = "btnThemkind";
            this.btnThemkind.Size = new System.Drawing.Size(108, 33);
            this.btnThemkind.TabIndex = 4;
            this.btnThemkind.Text = "Add";
            this.btnThemkind.UseVisualStyleBackColor = false;
            // 
            // btnXoakind
            // 
            this.btnXoakind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(176)))), ((int)(((byte)(211)))));
            this.btnXoakind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoakind.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoakind.ForeColor = System.Drawing.Color.Transparent;
            this.btnXoakind.Location = new System.Drawing.Point(595, 220);
            this.btnXoakind.Name = "btnXoakind";
            this.btnXoakind.Size = new System.Drawing.Size(108, 33);
            this.btnXoakind.TabIndex = 5;
            this.btnXoakind.Text = "Delete";
            this.btnXoakind.UseVisualStyleBackColor = false;
            // 
            // btnUpdatek
            // 
            this.btnUpdatek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(176)))), ((int)(((byte)(211)))));
            this.btnUpdatek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatek.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatek.ForeColor = System.Drawing.Color.White;
            this.btnUpdatek.Location = new System.Drawing.Point(468, 220);
            this.btnUpdatek.Name = "btnUpdatek";
            this.btnUpdatek.Size = new System.Drawing.Size(108, 33);
            this.btnUpdatek.TabIndex = 6;
            this.btnUpdatek.Text = "Update";
            this.btnUpdatek.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.label8.Location = new System.Drawing.Point(458, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 58);
            this.label8.TabIndex = 24;
            this.label8.Text = "Kinds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.label2.Location = new System.Drawing.Point(311, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "Kind ID";
            // 
            // txtKindID
            // 
            this.txtKindID.BackColor = System.Drawing.SystemColors.Control;
            this.txtKindID.Enabled = false;
            this.txtKindID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKindID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(176)))), ((int)(((byte)(211)))));
            this.txtKindID.Location = new System.Drawing.Point(418, 108);
            this.txtKindID.Name = "txtKindID";
            this.txtKindID.ReadOnly = true;
            this.txtKindID.Size = new System.Drawing.Size(237, 27);
            this.txtKindID.TabIndex = 25;
            // 
            // uc_kind
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKindID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnUpdatek);
            this.Controls.Add(this.btnXoakind);
            this.Controls.Add(this.btnThemkind);
            this.Controls.Add(this.lvKind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenLoaiDC);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(176)))), ((int)(((byte)(211)))));
            this.Name = "uc_kind";
            this.Size = new System.Drawing.Size(1198, 637);
            this.Load += new System.EventHandler(this.uc_kind_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenLoaiDC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvKind;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnThemkind;
        private System.Windows.Forms.Button btnXoakind;
        private System.Windows.Forms.Button btnUpdatek;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKindID;
    }
}
