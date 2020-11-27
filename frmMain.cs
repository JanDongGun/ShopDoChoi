using QuanLyShopDoChoi.Usercontrol;
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
            UC_Home uch = new UC_Home();
            AddControlsToPanel(uch);
        }

        private void moveSidePanel(Control btn)
        {
            panelside.Top = btn.Top;
            panelside.Height = btn.Height;
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHome);
            UC_Home uch = new UC_Home();
            AddControlsToPanel(uch);
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSell);
            UC_Sales ucs = new UC_Sales();
            AddControlsToPanel(ucs);
        }
        private void btnKind_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnKind);
            uc_kind uk = new uc_kind();
            AddControlsToPanel(uk);
            
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnProduct);
            uc_product up = new uc_product();
            AddControlsToPanel(up);
        }


        private void btnCustomer_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnCustomer);
            UC_Customer ucctm = new UC_Customer();
            AddControlsToPanel(ucctm);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnAccount);
            UC_Account ucac = new UC_Account();
            AddControlsToPanel(ucac);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void ptbExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
