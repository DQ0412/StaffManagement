using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace QLNS
{
    public partial class TDHV : Form
    {
        public TDHV()
        {
            InitializeComponent();
            SetControl("Reset");
            GetData();
        }
        public static string State = "-1";
        public string conString = "Data Source=MSITINTO\\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True";
        public void SetControl(String state)
        {
            switch (state)
            {
                case "Reset":
                    btnthem.Enabled = true;
                    btnsua.Enabled = true;
                    btnxoa.Enabled = true;
                    btnhuy.Enabled = true;

                    lbbanghi.Text = "";
                    break;
                default:
                    break;
            }
        }
        public void GetData()
        {
            SqlConnection conn = new SqlConnection(conString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = "SELECT * FROM TrinhDoHV order by MaTDHV";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dtgtdhv.DataSource = ds.Tables[0];
                lbbanghi.Text = "Tổng số: " + (dtgtdhv.Rows.Count - 1) + " bản ghi";
            }
            else
            {
                dtgtdhv.DataSource = null;
                lbbanghi.Text = "Tổng số: 0 bản ghi";
            }
        }

        private void dtgtdhv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow selectedRow = dtgtdhv.Rows[i];

            txtmatdhv.Text = selectedRow.Cells["MaTDHV"].Value.ToString();
            txttentdhv.Text = selectedRow.Cells["TenTDHV"].Value.ToString();
            txtcn.Text = selectedRow.Cells["ChuyenNganh"].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnthem.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnghi.Enabled = false;
            btnghi.Enabled = true;
            btnhuy.Enabled = true;
            txttim.Text = "";
            txtmatdhv.Text = "";
            txttentdhv.Text = "";
            txtcn.Text = "";


            txtmatdhv.Focus();
            State = "Insert";
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            btnthem.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnghi.Enabled = false;
            btnghi.Enabled = true;
            btnhuy.Enabled = true;

            txtmatdhv.Focus();
            State = "Update";
        }

        private void btnghi_Click(object sender, EventArgs e)
        {
            if (txtmatdhv.Text == "") { MessageBox.Show("Chưa nhập thông tin mã bảo hiểm.", "thông báo"); txtmatdhv.Focus(); return; }
            if (State == "Insert")
            {
                SqlConnection conn = new SqlConnection(conString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "Insert into TrinhDoHV(MaTDHV, TenTDHV, ChuyenNganh) Values ('" + txtmatdhv.Text.Trim() + "',N'" + txttentdhv.Text.Trim() + "',N'" + txtcn.Text.Trim() + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                var result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Thêm dữ liệu thành công");
                    GetData();
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu thất bại ");
                }

            }
            else if (State == "Update")
            {
                SqlConnection conn = new SqlConnection(conString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "Update TrinhDoHV SET TenTDHV =N'" + txttentdhv.Text.Trim() + "',ChuyenNganh=N'" + txtcn.Text.Trim() + "' where MaTDHV='" + txtmatdhv.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                var result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    GetData();
                }
                else
                {
                    MessageBox.Show("Cập nhật dữ liệu thất bại ");
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = "DELETE FROM TrinhDoHV Where MaTDHV = '" + txtmatdhv.Text.Trim() + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            var result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Xóa dữ liệu thành công");
                GetData();
            }
            else
            {
                MessageBox.Show("Xóa dữ liệu thất bại ");
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            SetControl("Reset");
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string keyword = txttim.Text.Trim();
            string query = "SELECT * FROM TrinhDoHV Where MaTDHV like '%" + keyword + "%'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dtgtdhv.DataSource = ds.Tables[0];
                lbbanghi.Text = "Tổng số: " + (dtgtdhv.Rows.Count - 1) + " bản ghi";
            }
            else
            {
                dtgtdhv.DataSource = null;
                lbbanghi.Text = "Tổng số: 0 bản ghi";
            }
        }
    }
}
