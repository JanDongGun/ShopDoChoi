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
            }
            MacDinh();
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
            if (cbSort.SelectedItem == "Price")
            {
                this.dgvProducts.Sort(this.dgvProducts.Columns[3], ListSortDirection.Ascending);
            }
            else
            {
                if (cbSort.SelectedItem == "A -> Z")
                {
                    this.dgvProducts.Sort(this.dgvProducts.Columns[1], ListSortDirection.Ascending);
                }
                else
                {
                    this.dgvProducts.Sort(this.dgvProducts.Columns[2], ListSortDirection.Ascending);
                }
            }
        }

        private void uc_product_Load(object sender, EventArgs e)
        {
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.EditMode = DataGridViewEditMode.EditProgrammatically;
            GetDataTodgv();
            MacDinh();
        }

        private void btnThempro_Click(object sender, EventArgs e)
        {
            if (txtToyTitle.Text == "" || txtPrice.Text == "" || txtQty.Text == "" || cbKindToy.Text == "")
            {
                MessageBox.Show("Them ho cai");
            }
            else
            {
                string query = "INSERT INTO Toy(ToyTitle, KindID, Price, Quantity, Note) VALUES (N'" + txtToyTitle.Text + "', " +
                    "N'" + cbKindToy.SelectedValue + "', N'" + txtPrice.Text + "', N'" + txtQty.Text + "', N'" + txtNote.Text + "')";
                Function.RunSQL(query);
                GetDataTodgv();
            }
            MacDinh();
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
            txtsearch.Enabled = false;
            btnThem.Enabled = true;
            btnCapNhat.Enabled = false;
            btnXoa.Enabled = false;
            txtToyID.Text = "";
            cbKindToy.SelectedIndex = -1;
            txtToyTitle.Text = "";
            txtQty.Text = "";
            txtPrice.Text = "";
            txtNote.Text = "";
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
            if (txtToyTitle.Text == "" || txtPrice.Text == "" || txtQty.Text == "" || cbKindToy.Text == "")
            {
                MessageBox.Show("Cap nhat ho");
            }
            else
            {
                string query = "UPDATE Toy Set ToyTitle = N'" + txtToyTitle.Text + "', KindID = N'" + cbKindToy.SelectedValue + "', Price = N'" + txtPrice.Text + "', " +
                    "Quantity = N'" + txtQty.Text + "', Note = N'" + txtNote.Text + "' WHERE ToyID = " + txtToyID.Text;
                Function.RunSQL(query);
                GetDataTodgv();
            }
            MacDinh();
        }

        private void FillCombo()
        {
            string sql = "SELECT * FROM Kind";
            Function.FillCombo(sql, cbKindToy, "KindID", "KindOfToy");

        }

        private void cbsearchpro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbsearch.SelectedItem == "")
            {
                txtsearch.Enabled = false;
            }
            else
            {
                txtsearch.Enabled = true;
            }
        }

        private void txtsearchpro_TextChanged(object sender, EventArgs e)
        {
            if (cbsearch.SelectedItem == "Toy title")
            {
                dt.DefaultView.RowFilter = string.Format("ToyTitle LIKE '%{0}%'", txtsearch.Text);
            }
            else
            {
                if (cbsearch.SelectedItem == "ID")
                {
                    if (txtsearch.Text == "")
                    {
                        GetDataTodgv();
                    }
                    else
                    {
                        dt.DefaultView.RowFilter = string.Format("ToyID = '{0}'", txtsearch.Text);
                    }
                }
                else
                {
                    if (cbsearch.SelectedItem == "Price")
                    {
                        if (txtsearch.Text == "")
                        {
                            GetDataTodgv();
                        }
                        else
                        {
                            dt.DefaultView.RowFilter = string.Format("Price = '{0}'", txtsearch.Text);
                        }
                    }
                }
            }

        }
        private void txtsearch_Click(object sender, EventArgs e)
        {

        }

        private void txtsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbsearch.SelectedItem == "ID" || cbsearch.SelectedItem == "Price")
            {
                if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                    e.Handled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            MacDinh();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
