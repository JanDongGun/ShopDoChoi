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

namespace QuanLyShopDoChoi
{
    public partial class UC_Account : UserControl
    {
        DataTable datatbl;
        public UC_Account()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connectionString = "server=.; database = ToyStore; Integrated Security = true;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            sqlConnection.Open();
            sqlCommand.CommandText = "DELETE FROM Account Where Username  = '" + dgvAccount.Rows[0].Cells["Username"].Value + "'";
            sqlCommand.ExecuteNonQuery();

            for (int i = 0; i < dgvAccount.Rows.Count - 1; i++)
            {
                string query = string.Format("" +
                    "INSERT INTO Account(Username, Password, Fullname, Phonenumber, Role)" + " " +
                    "VALUES (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}')",
                    txtUsername.Text,
                    txtPassword.Text,
                    txtFullname.Text,
                    txtPhonenumber.Text,
                    txtRole.Text);
                sqlCommand.CommandText = query;
                sqlCommand.ExecuteNonQuery();
                break;
            }
            LoadDataToDgv();
            sqlConnection.Close();
        }

        private void UC_Account_Load(object sender, EventArgs e)
        {
            LoadDataToDgv();
        }
        private void LoadDataToDgv()
        {
            string sql;
            sql = "SELECT * FROM Account";
            datatbl = Function.GetDataToTable(sql);
            dgvAccount.DataSource = datatbl;
            dgvAccount.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvAccount.AllowUserToAddRows = false;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = "server=.; database = ToyStore; Integrated Security = true;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            if (txtUsername.Text != "" && txtPassword.Text != "" && txtFullname.Text != "" && txtPhonenumber.Text != "" && txtRole.Text != "")
            {
                sqlCommand = new SqlCommand("update Account set Password=@password, Fullname=@fullname, Phonenumber=@phonenumber,Role=@role where Username=@username", sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@username", txtUsername.Text);
                sqlCommand.Parameters.AddWithValue("@password", txtPassword.Text);
                sqlCommand.Parameters.AddWithValue("@fullname", txtFullname.Text);
                sqlCommand.Parameters.AddWithValue("@phonenumber", txtPhonenumber.Text);
                sqlCommand.Parameters.AddWithValue("@role", txtRole.Text);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công");
                sqlConnection.Close();
                LoadDataToDgv();

                txtUsername.Text = "";
                txtPassword.Text = "";
                txtFullname.Text = "";
                txtPhonenumber.Text = "";
                txtRole.Text = "";
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra", "Cập nhật thất bại");
            }
        }                   
        private void dgvAccount_Click(object sender, EventArgs e)
        {
            txtUsername.Text = dgvAccount.SelectedCells[0].Value.ToString();
            txtPassword.Text = dgvAccount.SelectedCells[1].Value.ToString();
            txtFullname.Text = dgvAccount.SelectedCells[2].Value.ToString();
            txtPhonenumber.Text = dgvAccount.SelectedCells[3].Value.ToString();
            txtRole.Text = dgvAccount.SelectedCells[4].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAccount.SelectedRows.Count == 0) return;

            var selectedRow = dgvAccount.SelectedRows[0];
            string usname = selectedRow.Cells[0].Value.ToString();

            string connectionString = "server=.; database = ToyStore; Integrated Security = true;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            DialogResult dialogResult = MessageBox.Show("Bạn có thực sự muốn xóa", "XÓA", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "DELETE FROM Account WHERE Username = '" + usname + "'";
                sqlCommand.CommandText = query;

                sqlConnection.Open();
                int numOfRowsEffected = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                if (numOfRowsEffected == 1)
                {
                    dgvAccount.Rows.Remove(selectedRow);
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra", "Xóa thất bại");
                }
            }      
        }
    }
}
