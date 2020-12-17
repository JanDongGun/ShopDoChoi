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

namespace QuanLyShopDoChoi
{

    public partial class UC_Sales : UserControl
    {
        DataTable tbBill;
        DataTable tbBillInFo;
        public UC_Sales()
        {
            InitializeComponent();
        }

        public string fo
        {
            get { return txtUserName.Text; }
            set { txtUserName.Text = value; }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadDataBill()
        {
            string sql;
            sql = "select * from Bill";
            tbBill = Function.GetDataToTable(sql);

            dtgvBill.DataSource = tbBill;
            dtgvBill.AllowUserToAddRows = false;
            dtgvBill.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void LoadDataBillInFo()
        {
            string sql;
            sql = "select a.ToyID, b.ToyTitle, a.Quantity, a.Discount, a.Amount from Billinfo AS a, Toy As b WHERE a.BillID = '" + txtBillID.Text + "' AND a.ToyID = b.ToyID";

            tbBillInFo = Function.GetDataToTable(sql);


            dtgvBillInfo.DataSource = tbBillInFo;
            dtgvBillInfo.AllowUserToAddRows = false;
            dtgvBillInfo.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void UC_Sales_Load(object sender, EventArgs e)
        {
            string sql = "select ToyID, ToyTitle from Toy";
            Function.FillCombo(sql, cboToy, "ToyID", "ToyTitle");

            sql = "select * from Customer";
            Function.FillCombo(sql, cboCus, "CustomerID", "FullName");

            txtBillID.Text = Function.CreateKey("Bill");

            cboToy.SelectedIndex = -1;
            cboCus.SelectedIndex = -1;
            txtSearch.Enabled = false;
            txtSearch.ReadOnly = true;
            btnFinish.Enabled = false;
            btnClear.Enabled = false;

            LoadDataBill();
            LoadDataBillInFo();
        }

        private void ResetValue()
        {
            txtDiscount.Text = "";
            txtPrice.Text = "";
            dtpkDayOfSale.Value = DateTime.Now;
            cboToy.SelectedIndex = -1;
            cboCus.SelectedIndex = -1;
            txtAmount.Text = "";
            txtQuantity.Text = "";
            lblTotalAmount.Text = "0";
            txtBillID.Text = "";

            txtBillID.Text = Function.CreateKey("Bill");

            
        }

        private void ResetValueToyInfo()
        {
            txtDiscount.Text = "";
            txtPrice.Text = "";
            dtpkDayOfSale.Value = DateTime.Now;
            cboToy.SelectedIndex = -1;
            txtAmount.Text = "";
            txtQuantity.Text = "";
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            string sql;
            int qty, qtyReserve, totalAmount, newTotalAmount;

            sql = "Select BillID from Bill Where BillID = '" + txtBillID.Text + "'";
            if (!Function.checkKey(sql))
            {
                if (cboCus.Text == "")
                {
                    MessageBox.Show("Customer is not available", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    return;
                }

                sql = "INSERT INTO Bill VALUES (N'" + txtBillID.Text + "',N'" + txtUserName.Text + "', '" + cboCus.SelectedValue + "','" + dtpkDayOfSale.Value + "','" + lblTotalAmount.Text + "')";
                Function.RunSQL(sql);
            }


            if (cboToy.Text == "")
            {
                MessageBox.Show("Toy is not available", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtQuantity.Text == "")
            {
                MessageBox.Show("Quantity is not available", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQuantity.Focus();
                return;
            }

            sql = "SELECT ToyID from Billinfo where BillID = '" + txtBillID.Text + "' AND ToyID = '" + cboToy.SelectedValue + "'";
            if (Function.checkKey(sql))
            {
                MessageBox.Show("Please enter another Toy", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValueToyInfo();
                cboToy.Focus();
                return;
            }

            qty = Convert.ToInt32(Function.GetFieldValue("SELECT Quantity from Toy where ToyID = '" + cboToy.SelectedValue + "'"));
            if (Convert.ToInt32(txtQuantity.Text) > qty)
            {
                MessageBox.Show("The number of '" + cboToy.Text + "' is only " + qty, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQuantity.Text = "";
                txtQuantity.Focus();
                return;
            }

            sql = "INSERT INTO Billinfo VALUES (N'" + txtBillID.Text + "','" + cboToy.SelectedValue + "','" + txtQuantity.Text + "','" + txtPrice.Text + "','" + txtDiscount.Text + "','" + txtAmount.Text + "')";
            Function.RunSQL(sql);
            LoadDataBillInFo();

            // Cặp nhật số lượng của mặt hàng vào bảng tblToy
            qtyReserve = qty - Convert.ToInt32(txtQuantity.Text);
            sql = "UPDATE Toy SET Quantity = " + qtyReserve + " WHERE ToyID = '" + cboToy.SelectedValue + "' ";
            Function.RunSQL(sql);

            // Cặp nhật lại tổng tiền cho hóa đơn bán
            totalAmount = Convert.ToInt32(Function.GetFieldValue("SELECT TotalAmount FROM Bill where BillID = '" + txtBillID.Text + "'"));
            newTotalAmount = totalAmount + Convert.ToInt32(txtAmount.Text);
            sql = "UPDATE Bill SET TotalAmount = " + newTotalAmount + " WHERE BillID = '" + txtBillID.Text + "'";
            Function.RunSQL(sql);
            lblTotalAmount.Text = newTotalAmount.ToString();
            btnClear.Enabled = true;
            btnFinish.Enabled = true;
            ResetValueToyInfo();
        }


        private void btnFinish_Click(object sender, EventArgs e)
        {
            ResetValue();
            LoadDataBillInFo();
            LoadDataBill();

            cboCus.Enabled = true;
            dtpkDayOfSale.Enabled = true;
            btnSell.Enabled = true;
            btnFinish.Enabled = false;
            btnClear.Enabled = false;
        }

        private void cboToy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboToy.SelectedIndex != -1)
            {
                int cboChoice;
                Int32.TryParse(cboToy.SelectedValue.ToString(), out cboChoice);

                txtPrice.Text = Function.GetFieldValue("SELECT Price from Toy Where ToyID='" + cboChoice + "'");
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            txtAmount.Text = CalAmount().ToString();
        }



        private int CalAmount()
        {
            int tt, sl, dg, gg;
            if (txtQuantity.Text == "")
            {
                sl = 0;
            }
            else
            {
                sl = Convert.ToInt32(txtQuantity.Text);
            }

            if (txtDiscount.Text == "")
            {
                gg = 0;
            }
            else
            {
                gg = Convert.ToInt32(txtDiscount.Text);
            }

            if (txtPrice.Text == "")
            {
                dg = 0;
            }
            else
            {
                dg = Convert.ToInt32(txtPrice.Text);
            }

            tt = sl * dg - sl * dg * gg / 100;

            return tt;
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            txtAmount.Text = CalAmount().ToString();
        }

        private void dtgvBill_Click(object sender, EventArgs e)
        {
            txtBillID.Text = dtgvBill.CurrentRow.Cells["BillID"].Value.ToString();
            txtUserName.Text = dtgvBill.CurrentRow.Cells["UserName"].Value.ToString();
            cboCus.SelectedValue = dtgvBill.CurrentRow.Cells["CustomerID"].Value;
            dtpkDayOfSale.Value = DateTime.Parse(dtgvBill.CurrentRow.Cells["DayOfSale"].Value.ToString());
            lblTotalAmount.Text = dtgvBill.CurrentRow.Cells["TotalAmount"].Value.ToString();
            cboCus.Enabled = false;
            dtpkDayOfSale.Enabled = false;

            dtgvBillInfo.ContextMenuStrip = null;

            LoadDataBillInFo();
            btnSell.Enabled = false;

            btnFinish.Enabled = false;
            btnClear.Enabled = false;
            ResetValueToyInfo();


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "";



            if (cboSearch.Text == "CustomerID")
            {
                sql = "SELECT * FROM Bill Where CustomerID like '%" + txtSearch.Text + "%'";
            }

            if (cboSearch.Text == "UserName")
            {
                sql = "SELECT * FROM Bill Where UserName like '%" + txtSearch.Text + "%'";
            }

            tbBill = Function.GetDataToTable(sql);
            dtgvBill.DataSource = tbBill;
        }

        private void cboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Enabled = true;
            txtSearch.ReadOnly = false;
        }

        private void dtpkFrom_ValueChanged(object sender, EventArgs e)
        {
            dtpk_change();
        }

        private void dtpkTo_ValueChanged(object sender, EventArgs e)
        {
            dtpk_change();
        }

        private void dtpk_change()
        {
            string sql;
            sql = "SELECT * FROM Bill where DayOfSale >= '" + dtpkFrom.Value + "' and DayOfSale <= '" + dtpkTo.Value + "' ";

            tbBill = Function.GetDataToTable(sql);
            dtgvBill.DataSource = tbBill;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string MaHangxoa, sql;
            int ThanhTienxoa, SoLuongxoa, sl, slcon, tong, tongmoi;
 
            if ((MessageBox.Show("Are you sure you want to delete this item?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                //Xóa hàng và cập nhật lại số lượng hàng 
                MaHangxoa = dtgvBillInfo.CurrentRow.Cells["ToyID"].Value.ToString();
                SoLuongxoa = Convert.ToInt32(dtgvBillInfo.CurrentRow.Cells["Quantity"].Value.ToString());
                ThanhTienxoa = Convert.ToInt32(dtgvBillInfo.CurrentRow.Cells["Amount"].Value.ToString());
                sql = "DELETE Billinfo WHERE BillID=N'" + txtBillID.Text + "' AND ToyID = N'" + MaHangxoa + "'";
                Function.RunSQL(sql);
                // Cập nhật lại số lượng cho các mặt hàng
                sl = Convert.ToInt32(Function.GetFieldValue("SELECT Quantity FROM Toy WHERE ToyID = N'" + MaHangxoa + "'"));
                slcon = sl + SoLuongxoa;
                sql = "UPDATE Toy SET Quantity =" + slcon + " WHERE ToyID= N'" + MaHangxoa + "'";
                Function.RunSQL(sql);
                // Cập nhật lại tổng tiền cho hóa đơn bán
                tong = Convert.ToInt32(Function.GetFieldValue("SELECT TotalAmount FROM Bill WHERE BillID = N'" + txtBillID.Text + "'"));
                tongmoi = tong - ThanhTienxoa;
                sql = "UPDATE Bill SET TotalAmount =" + tongmoi + " WHERE BillID = N'" + txtBillID.Text + "'";
                Function.RunSQL(sql);
                lblTotalAmount.Text = tongmoi.ToString();
                LoadDataBillInFo();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            double sl, slcon, slxoa;
            if (MessageBox.Show("Are you sure you want to clear this table ", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "SELECT ToyID,Quantity FROM BillInfo WHERE BillID = N'" + txtBillID.Text + "'";
                DataTable tblHang = Function.GetDataToTable(sql);
                for (int hang = 0; hang <= tblHang.Rows.Count - 1; hang++)
                {
                    // Cập nhật lại số lượng cho các mặt hàng
                    sl = Convert.ToInt32(Function.GetFieldValue("SELECT Quantity FROM Toy WHERE ToyID = N'" + tblHang.Rows[hang][0].ToString() + "'"));
                    slxoa = Convert.ToInt32(tblHang.Rows[hang][1].ToString());
                    slcon = sl + slxoa;
                    sql = "UPDATE Toy SET Quantity =" + slcon + " WHERE ToyID= N'" + tblHang.Rows[hang][0].ToString() + "'";
                    Function.RunSQL(sql);
                }

                //Xóa chi tiết hóa đơn
                sql = "DELETE Billinfo WHERE BillID=N'" + txtBillID.Text + "'";
                Function.RunSQL(sql);

                //Xóa hóa đơn
                sql = "DELETE Bill WHERE BillID=N'" + txtBillID.Text + "'";
                Function.RunSQL(sql);
                ResetValue();
                LoadDataBillInFo();

                btnClear.Enabled = false;
                btnFinish.Enabled = false;
                btnSell.Enabled = true;
            }
        }
    }
}
