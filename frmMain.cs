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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void moveSidePanel(Control btn)
        {
            panelside.Top = btn.Top;
            panelside.Height = btn.Height;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHome);
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSell);
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnBill);
        }

        private void btnKind_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnKind);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnProduct);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnUser);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnCustomer);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnAccount);
        }
    }
}
