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
            this.lvKind = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSuakind = new System.Windows.Forms.Button();
            this.btnThemkind = new System.Windows.Forms.Button();
            this.btnXoakind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTenLoaiDC
            // 
            this.txtTenLoaiDC.BackColor = System.Drawing.Color.White;
            this.txtTenLoaiDC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(176)))), ((int)(((byte)(211)))));
            this.txtTenLoaiDC.Location = new System.Drawing.Point(404, 86);
            this.txtTenLoaiDC.Name = "txtTenLoaiDC";
            this.txtTenLoaiDC.Size = new System.Drawing.Size(260, 22);
            this.txtTenLoaiDC.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name of toys";
            // 
            // lvKind
            // 
            this.lvKind.BackColor = System.Drawing.SystemColors.Window;
            this.lvKind.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvKind.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvKind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(176)))), ((int)(((byte)(211)))));
            this.lvKind.GridLines = true;
            this.lvKind.HideSelection = false;
            this.lvKind.Location = new System.Drawing.Point(3, 181);
            this.lvKind.Name = "lvKind";
            this.lvKind.Size = new System.Drawing.Size(1192, 312);
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
            this.columnHeader2.Text = "Name of toys";
            this.columnHeader2.Width = 512;
            // 
            // btnSuakind
            // 
            this.btnSuakind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(176)))), ((int)(((byte)(211)))));
            this.btnSuakind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuakind.ForeColor = System.Drawing.Color.White;
            this.btnSuakind.Location = new System.Drawing.Point(441, 526);
            this.btnSuakind.Name = "btnSuakind";
            this.btnSuakind.Size = new System.Drawing.Size(171, 39);
            this.btnSuakind.TabIndex = 3;
            this.btnSuakind.Text = "Modify";
            this.btnSuakind.UseVisualStyleBackColor = false;
            // 
            // btnThemkind
            // 
            this.btnThemkind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(176)))), ((int)(((byte)(211)))));
            this.btnThemkind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemkind.ForeColor = System.Drawing.Color.White;
            this.btnThemkind.Location = new System.Drawing.Point(206, 526);
            this.btnThemkind.Name = "btnThemkind";
            this.btnThemkind.Size = new System.Drawing.Size(162, 39);
            this.btnThemkind.TabIndex = 4;
            this.btnThemkind.Text = "Add";
            this.btnThemkind.UseVisualStyleBackColor = false;
            // 
            // btnXoakind
            // 
            this.btnXoakind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(176)))), ((int)(((byte)(211)))));
            this.btnXoakind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoakind.ForeColor = System.Drawing.Color.Transparent;
            this.btnXoakind.Location = new System.Drawing.Point(673, 526);
            this.btnXoakind.Name = "btnXoakind";
            this.btnXoakind.Size = new System.Drawing.Size(174, 39);
            this.btnXoakind.TabIndex = 5;
            this.btnXoakind.Text = "Delete";
            this.btnXoakind.UseVisualStyleBackColor = false;
            // 
            // uc_kind
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnXoakind);
            this.Controls.Add(this.btnThemkind);
            this.Controls.Add(this.btnSuakind);
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
        private System.Windows.Forms.Button btnSuakind;
        private System.Windows.Forms.Button btnThemkind;
        private System.Windows.Forms.Button btnXoakind;
    }
}
