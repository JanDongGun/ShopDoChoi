using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyShopDoChoi.Class;

namespace QuanLyShopDoChoi.Usercontrol
{
    public partial class uc_kind : UserControl
    {

        DataTable dt;
        BindingSource bs = new BindingSource();
        public uc_kind()
        {
            InitializeComponent();
        }

        private void uc_kind_Load(object sender, EventArgs e)
        {
            btnThemkind.Enabled = true;
            btnUpdatek.Enabled = false;
            btnXoakind.Enabled = false;
            dgvKind.AllowUserToAddRows = false;
            dgvKind.EditMode = DataGridViewEditMode.EditProgrammatically;
            GetDataTodgv();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThemkind_Click(object sender, EventArgs e)
        {
            if (txtTenLoaiDC.Text == "")
            {
                MessageBox.Show("hi");
            }
            else
            {
                string query = "INSERT INTO Kind(KindOfToy) VALUES (N'" + txtTenLoaiDC.Text + "')";
                Function.RunSQL(query);
                GetDataTodgv();
             
            }
            MacDinh();
        }

        private void btnUpdatek_Click(object sender, EventArgs e)
        {
            if (txtTenLoaiDC.Text == "")
            {
                MessageBox.Show("hi");
            }
            else
            {
                string query = "UPDATE Kind Set KindOfToy = N'" + txtTenLoaiDC.Text + "' WHERE KindID = " + txtKindID.Text;
                Function.RunSQL(query);
                GetDataTodgv();
                btnThemkind.Enabled = true;
            }
            MacDinh();

        }

        private void btnXoakind_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chắc chưa", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string query = "DELETE Kind WHERE KindID = " + txtKindID.Text;
                Function.RunSQL(query);
                GetDataTodgv();
                MacDinh();
                btnThemkind.Enabled = true;
            }
        }

        private void GetDataTodgv()
        {
            string Datatb;
            Datatb = "SELECT * FROM Kind";
            dt = Function.GetDataToTable(Datatb);
            bs.DataSource = dt;
            dgvKind.DataSource = bs;

        }

        private void MacDinh()
        {
            txtKindID.Text = "";
            txtTenLoaiDC.Text = "";
            btnXoakind.Enabled = false;
            btnUpdatek.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvKind_Click(object sender, EventArgs e)
        {

        }

        private void dgvKind_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtKindID.Text = Convert.ToString(dgvKind.CurrentRow.Cells["KindID"].Value);
            txtTenLoaiDC.Text = Convert.ToString(dgvKind.CurrentRow.Cells["KindOfToy"].Value);
            btnThemkind.Enabled = false;
            btnUpdatek.Enabled = true;
            btnXoakind.Enabled = true;


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            MacDinh();
            btnThemkind.Enabled = true;
        }
    }
}
