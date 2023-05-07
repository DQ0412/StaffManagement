using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace QLNS
{
    public partial class BaoHiem : Form
    {
        public BaoHiem()
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
            string query = "SELECT * FROM BaoHiem Order by MaBH";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dtgbh.DataSource = ds.Tables[0];
                lbbanghi.Text = "Tổng số: " + (dtgbh.Rows.Count - 1) + " bản ghi";
            }
            else
            {
                dtgbh.DataSource = null;
                lbbanghi.Text = "Tổng số: 0 bản ghi";
            }
        }
        private void dtgcv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow selectedRow = dtgbh.Rows[i];

            txtmabh.Text = selectedRow.Cells["MaBH"].Value.ToString();
            txttenbh.Text = selectedRow.Cells["TenBH"].Value.ToString();
            dtngay.Text = selectedRow.Cells["Ngaylap"].Value.ToString();
            txtth.Text = selectedRow.Cells["Thoihan"].Value.ToString();

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
            txtmabh.Text = "";
            txttenbh.Text = "";
            txtth.Text = "";
            dtngay.Text = "";

            txtmabh.Focus();
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

            txtmabh.Focus();
            State = "Update";
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            txtmabh.Enabled = true;
            SetControl("Reset");
        }

        private void btnghi_Click(object sender, EventArgs e)
        {
            //if (txtmabh.Text == "") { MessageBox.Show("Chưa nhập thông tin mã bảo hiểm.", "thông báo"); txtmabh.Focus(); return; }
            if (State == "Insert")
            {
                int count = dtgbh.Rows.Count;
                if (count > 99)
                {
                    txtmabh.Text = "NS" + count++ + "";
                }
                else if (count > 9)
                {
                    txtmabh.Text = "NS0" + count++ + "";
                }
                else
                {
                    txtmabh.Text = "NS00" + count++ + "";
                }
                SqlConnection conn = new SqlConnection(conString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "Insert into BaoHiem(MaBH, TenBH, Ngaylap, Thoihan) Values ('" + txtmabh.Text.Trim() + "',N'" + txttenbh.Text.Trim() + "','" + dtngay.Value.ToString() + "',N'" + txtth.Text.Trim() + "')";
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
                string query = "Update BaoHiem SET TenBH =N'" + txttenbh.Text.Trim() + "',Ngaylap='" + dtngay.Value.ToString() + "',Thoihan=N'" + txtth.Text.Trim() + "' where MaBH='" + txtmabh.Text.Trim() + "'";
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
            string query = "DELETE FROM BaoHiem Where MaBH = '" + txtmabh.Text.Trim() + "'";
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

        private void btntim_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string keyword = txttim.Text.Trim();
            string query = "SELECT * FROM BaoHiem Where MaBH like '%" + keyword + "%'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dtgbh.DataSource = ds.Tables[0];
                lbbanghi.Text = "Tổng số: " + (dtgbh.Rows.Count - 1) + " bản ghi";
            }
            else
            {
                dtgbh.DataSource = null;
                lbbanghi.Text = "Tổng số: 0 bản ghi";
            }
        }
    }
}
