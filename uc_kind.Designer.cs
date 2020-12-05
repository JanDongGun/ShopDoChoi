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
            this.txtTenLoaiDC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemkind = new System.Windows.Forms.Button();
            this.btnXoakind = new System.Windows.Forms.Button();
            this.btnUpdatek = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKindID = new System.Windows.Forms.TextBox();
            this.dgvKind = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKind)).BeginInit();
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
            // btnThemkind
            // 
            this.btnThemkind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(176)))), ((int)(((byte)(211)))));
            this.btnThemkind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemkind.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemkind.ForeColor = System.Drawing.Color.White;
            this.btnThemkind.Location = new System.Drawing.Point(285, 212);
            this.btnThemkind.Name = "btnThemkind";
            this.btnThemkind.Size = new System.Drawing.Size(108, 33);
            this.btnThemkind.TabIndex = 4;
            this.btnThemkind.Text = "Add";
            this.btnThemkind.UseVisualStyleBackColor = false;
            this.btnThemkind.Click += new System.EventHandler(this.btnThemkind_Click);
            // 
            // btnXoakind
            // 
            this.btnXoakind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(176)))), ((int)(((byte)(211)))));
            this.btnXoakind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoakind.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoakind.ForeColor = System.Drawing.Color.Transparent;
            this.btnXoakind.Location = new System.Drawing.Point(543, 212);
            this.btnXoakind.Name = "btnXoakind";
            this.btnXoakind.Size = new System.Drawing.Size(108, 33);
            this.btnXoakind.TabIndex = 5;
            this.btnXoakind.Text = "Delete";
            this.btnXoakind.UseVisualStyleBackColor = false;
            this.btnXoakind.Click += new System.EventHandler(this.btnXoakind_Click);
            // 
            // btnUpdatek
            // 
            this.btnUpdatek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(176)))), ((int)(((byte)(211)))));
            this.btnUpdatek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatek.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatek.ForeColor = System.Drawing.Color.White;
            this.btnUpdatek.Location = new System.Drawing.Point(416, 212);
            this.btnUpdatek.Name = "btnUpdatek";
            this.btnUpdatek.Size = new System.Drawing.Size(108, 33);
            this.btnUpdatek.TabIndex = 6;
            this.btnUpdatek.Text = "Update";
            this.btnUpdatek.UseVisualStyleBackColor = false;
            this.btnUpdatek.Click += new System.EventHandler(this.btnUpdatek_Click);
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
            // dgvKind
            // 
            this.dgvKind.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKind.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKind.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvKind.Location = new System.Drawing.Point(0, 370);
            this.dgvKind.MultiSelect = false;
            this.dgvKind.Name = "dgvKind";
            this.dgvKind.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKind.Size = new System.Drawing.Size(1198, 267);
            this.dgvKind.TabIndex = 27;
            this.dgvKind.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKind_CellClick);
            this.dgvKind.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvKind.Click += new System.EventHandler(this.dgvKind_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(176)))), ((int)(((byte)(211)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(667, 212);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 33);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // uc_kind
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvKind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKindID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnUpdatek);
            this.Controls.Add(this.btnXoakind);
            this.Controls.Add(this.btnThemkind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenLoaiDC);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "uc_kind";
            this.Size = new System.Drawing.Size(1198, 637);
            this.Load += new System.EventHandler(this.uc_kind_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKind)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenLoaiDC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemkind;
        private System.Windows.Forms.Button btnXoakind;
        private System.Windows.Forms.Button btnUpdatek;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKindID;
        private System.Windows.Forms.DataGridView dgvKind;
        private System.Windows.Forms.Button btnClear;
    }
}
