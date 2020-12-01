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
using System.Data.SqlClient;
using System.Collections;

namespace QuanLyShopDoChoi
{
    public partial class UC_Customer : UserControl
    {
        DataTable datatbl;
        public UC_Customer()
        {
            InitializeComponent();
        }

        private void UC_Customer_Load(object sender, EventArgs e)
        {
            LoadDataToDgv();
        }
        private void ClearText()
        {
            txtCustomerID.Text = "";
            txtFullname.Text = "";
            txtAddress.Text = "";
            txtPhonenumber.Text = "";
        }
        private void LoadDataToDgv()
        {
            string sql;
            sql = "SELECT * FROM Customer";
            datatbl = Function.GetDataToTable(sql);
            dgvCustomer.DataSource = datatbl;
            dgvCustomer.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvCustomer.AllowUserToAddRows = false;
        }

        private void dgvCustomer_Click(object sender, EventArgs e)
        {
            txtCustomerID.Text = dgvCustomer.SelectedCells[0].Value.ToString();
            txtFullname.Text = dgvCustomer.SelectedCells[1].Value.ToString();
            txtAddress.Text = dgvCustomer.SelectedCells[2].Value.ToString();
            txtPhonenumber.Text = dgvCustomer.SelectedCells[3].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.SelectedRows.Count == 0) return;

            string cstmID = dgvCustomer.SelectedCells[0].Value.ToString();
            DialogResult dialogResult = MessageBox.Show("Bạn có thực sự muốn xóa", "XÓA", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "DELETE Customer WHERE CustomerID = '" + cstmID + "'";
                Function.RunSQL(query);
                dgvCustomer.Rows.Remove(dgvCustomer.SelectedRows[0]);
                ClearText();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {           
                string sql = "insert into Customer(Fullname, Address, Phonenumber) values (N'" + txtFullname.Text + "', N'" + txtAddress.Text + "', N'" + txtPhonenumber.Text + "')";
                Function.RunSQL(sql);
                LoadDataToDgv();
                ClearText();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtFullname.Text != "" && txtAddress.Text != "" && txtPhonenumber.Text != "")
            {
                string sql = "update Customer set Fullname= N'" + txtFullname.Text + "', Address= N'" + txtAddress.Text + "', Phonenumber= N'" + txtPhonenumber.Text + "' WHERE CustomerID = N'" + txtCustomerID.Text + "'";
                Function.RunSQL(sql);

                MessageBox.Show("Cập nhật thành công");
                LoadDataToDgv();
                ClearText();
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra", "Cập nhật thất bại");
                ClearText();
            }
        }
    }
}
