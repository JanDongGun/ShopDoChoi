using QuanLyShopDoChoi.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyShopDoChoi.Class;
using System.Data.SqlClient;

namespace QuanLyShopDoChoi
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }
        private void pbExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("bạn có thực sự muốn thoát ?", "THOÁT", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
                Function.DisConnect();
            }
        }
        private void btnLogin_Click_1(object sender, EventArgs e)
        {          
            string query = "SELECT Username,Password FROM Account WHERE Username = '" + txtUsername.Text + "' and Password = '" + txtPassword.Text + "'";            
            if (Function.GetDataToTable(query).Rows.Count > 0)
            {
                frmMain main = new frmMain();
                main.Usname = txtUsername.Text;
                main.ShowDialog();               
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng. Vui lòng kiểm tra lại", "Đăng nhập thất bại");
            }            
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmlogin_Load_1(object sender, EventArgs e)
        {
            Function.Connect();
<<<<<<< HEAD
=======
        }
        private void btnLogin_Enter_1(object sender, EventArgs e)
        {

>>>>>>> d94b5dd681a8189de6c73d080c5304e6b50ed2dc
        }
    }
}
