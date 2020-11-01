using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            frmlogin login = new frmlogin();
            main.ShowDialog();
            login.Close();
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

        }
    }
}
