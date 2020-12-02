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
using System.Data.OleDb;

namespace QuanLyShopDoChoi.Usercontrol
{
    public partial class uc_product : UserControl
    {
        DataTable dt;
        BindingSource bs = new BindingSource();
        public uc_product()
        {
            InitializeComponent();
        }

        private void btnXoapro_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chắc chưa", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string query = "DELETE Toy WHERE ToyID = " + txtToyID.Text;
                Function.RunSQL(query);
                GetDataTodgv();
                MacDinh();
                btnThem.Enabled = true;
            }
        }

        private void btnSuapro_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cbSortpro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void uc_product_Load(object sender, EventArgs e)
        {

            btnThem.Enabled = true;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.EditMode = DataGridViewEditMode.EditProgrammatically;
            GetDataTodgv();
        }

        private void btnThempro_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Chắc chưa?", "Add", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "INSERT INTO Toy(ToyTitle, KindID, Price, Quantity, Note) VALUES (N'" + txtToyTitle.Text + "', " +
                    "N'" + cbKindToy.SelectedValue + "', N'" + txtPrice.Text + "', N'" + txtQty.Text + "', N'" + txtNote.Text + "')";
                Function.RunSQL(query);
                GetDataTodgv();
                MacDinh();
            }
        }
        private void GetDataTodgv()
        {
            string Datatb;
            Datatb = "SELECT * FROM Toy";
            dt = Function.GetDataToTable(Datatb);
            bs.DataSource = dt;
            dgvProducts.DataSource = bs;
            FillCombo();
         
        }

        private void MacDinh()
        {
            txtToyID.Text = "";
            cbKindToy.Text = "";
            txtToyTitle.Text = "";
            txtQty.Text = "";
            txtPrice.Text = "";
            txtNote.Text = "";
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtToyID.Text = Convert.ToString(dgvProducts.CurrentRow.Cells["ToyID"].Value);
            txtToyTitle.Text = Convert.ToString(dgvProducts.CurrentRow.Cells["ToyTitle"].Value);
            cbKindToy.SelectedValue = Convert.ToString(dgvProducts.CurrentRow.Cells["KindID"].Value);
            txtPrice.Text = Convert.ToString(dgvProducts.CurrentRow.Cells["Price"].Value);
            txtQty.Text = Convert.ToString(dgvProducts.CurrentRow.Cells["Quantity"].Value);
            txtNote.Text = Convert.ToString(dgvProducts.CurrentRow.Cells["Note"].Value);
            btnThem.Enabled = false;
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chắc chưa?", "Update", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string query = "UPDATE Toy Set ToyTitle = N'" + txtToyTitle.Text + "', KindID = N'" + cbKindToy.SelectedValue + "', Price = N'" + txtPrice.Text + "', " +
                    "Quantity = N'" + txtQty.Text + "', Note = N'" + txtNote.Text + "' WHERE ToyID = " + txtToyID.Text;
                Function.RunSQL(query);
                GetDataTodgv();
                MacDinh();
                btnThem.Enabled = true;
            }
        }

        private void FillCombo()
        {
            string sql = "SELECT * FROM Kind";
            Function.FillCombo(sql, cbKindToy, "KindID", "KindOfToy");
        }

        private void cbsearchpro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtsearchpro_TextChanged(object sender, EventArgs e)
        {
            dgvProducts.DataSource = dt;
            MessageBox.Show("DataSource type BEFORE = " + dgvProducts.DataSource.GetType().ToString());

            dt.DefaultView.RowFilter = string.Format("ToyTitle LIKE '%{0}%'", txtsearch.Text);

            MessageBox.Show("DataSource type AFTER = " + dgvProducts.DataSource.GetType().ToString());
        }
        private void txtsearch_Click(object sender, EventArgs e)
        {
         
        }
    }
}
