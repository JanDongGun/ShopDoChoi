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
    public partial class UC_Account : UserControl
    {
        DataTable datatbl;
        public UC_Account()
        {
            InitializeComponent();
        }
        private bool CheckID()
        {
            string query = "SELECT Username FROM Account WHERE Username = N'" + dgvAccount.SelectedCells[0].Value.ToString() + "'";

            if (Function.GetFieldValue(query) == txtUsername.Text)
            {
                return true;
            }
            return false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckID())
            {
                MessageBox.Show("Thêm thất bại");
            }
            else
            {
                string sql = "insert into Account(Username, Password, Fullname, Phonenumber, Role) values (N'"+ txtUsername.Text + "', N'" + txtPassword.Text + "', N'" + txtFullname.Text + "', N'" + txtPhonenumber.Text + "', N'" + cboRole.Text +"')";
                Function.RunSQL(sql);
                LoadDataToDgv();
                ClearText();
            }
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
            FillCbb();
        }
        private void FillCbb()
        {
            List<string> comboSource = new List<string>();
            comboSource.Add("Admin");
            comboSource.Add("Staff");
            cboRole.DataSource = comboSource;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = "server=.; database = ToyStore; Integrated Security = true;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            if (txtUsername.Text != "" && txtPassword.Text != "" && txtFullname.Text != "" && txtPhonenumber.Text != "" && cboRole.Text != "")
            {
                string sql = "update Account set Password= N'"+txtPassword.Text+"', Fullname= N'"+txtFullname.Text + "', Phonenumber= N'"+ txtPhonenumber.Text+"', Role= N'"+cboRole.Text+"' where Username= N'"+ txtUsername.Text + "'";
                Function.RunSQL(sql);
               
                MessageBox.Show("Cập nhật thành công");
                LoadDataToDgv();
                ClearText();         
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
            cboRole.Text = dgvAccount.SelectedCells[4].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAccount.SelectedRows.Count == 0) return;

            string usname = dgvAccount.SelectedCells[0].Value.ToString();
            DialogResult dialogResult = MessageBox.Show("Bạn có thực sự muốn xóa", "XÓA", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "DELETE Account WHERE Username = '" + usname + "'";
                Function.RunSQL(query);
                dgvAccount.Rows.Remove(dgvAccount.SelectedRows[0]);
                ClearText();
            }      
        }
        private void ClearText()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtFullname.Text = "";
            txtPhonenumber.Text = "";
            cboRole.Text = "";
        }
    }
}
