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
    public partial class QDKT : Form
    {
        public QDKT()
        {
            InitializeComponent();
            SetControl("Reset");
            GetData();
        }
        public static string State = "-1";
        public string conString = "Data Source=LAPTOP-EKGRU032\\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True";
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
            string query = "SELECT * FROM QuyetDinhKhenThuong Order by SoQDKT";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dtgqdkt.DataSource = ds.Tables[0];
                lbbanghi.Text = "Tổng số: " + (dtgqdkt.Rows.Count - 1) + " bản ghi";
            }
            else
            {
                dtgqdkt.DataSource = null;
                lbbanghi.Text = "Tổng số: 0 bản ghi";
            }
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
            txtsoqdkt.Text = "";
            txttien.Text = "";
            txtnoidung.Text = "";
            dtngay.Text = "";

            txtsoqdkt.Focus();
            State = "Insert";
        }

        private void dtgqdkt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow selectedRow = dtgqdkt.Rows[i];

            txtsoqdkt.Text = selectedRow.Cells["SoQDKT"].Value.ToString();
            dtngay.Text = selectedRow.Cells["NgayQD"].Value.ToString();
            txttien.Text = selectedRow.Cells["Sotienthuong"].Value.ToString();
            txtnoidung.Text = selectedRow.Cells["Noidung"].Value.ToString();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            btnthem.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnghi.Enabled = false;
            btnghi.Enabled = true;
            btnhuy.Enabled = true;

            txtsoqdkt.Focus();
            State = "Update";
        }

        private void btnghi_Click(object sender, EventArgs e)
        {
            if (txtsoqdkt.Text == "") { MessageBox.Show("Chưa nhập thông tin mã bảo hiểm.", "thông báo"); txtsoqdkt.Focus(); return; }
            if (State == "Insert")
            {
                SqlConnection conn = new SqlConnection(conString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "Insert into QuyetDinhKhenThuong(SoQDKT, NgayQD, Noidung, Sotienthuong) Values ('" + txtsoqdkt.Text.Trim() + "','" + dtngay.Value.ToString() + "',N'" + txtnoidung.Text.Trim() + "',N'" + txttien.Text.Trim() + "')";
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
                string query = "Update QuyetDinhKhenThuong SET Noidung ='" + txtnoidung.Text.Trim() + "',NgayQD='" + dtngay.Value.ToString() + "',Sotienthuong=N'" + txttien.Text.Trim() + "' where SoQDKT='" + txtsoqdkt.Text.Trim() + "'";
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
            string query = "DELETE FROM QuyetDinhKhenThuong Where SoQDKT = '" + txtsoqdkt.Text.Trim() + "'";
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
            string query = "SELECT * FROM QuyetDinhKhenThuong Where SoQDKT like '%" + keyword + "%'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dtgqdkt.DataSource = ds.Tables[0];
                lbbanghi.Text = "Tổng số: " + (dtgqdkt.Rows.Count - 1) + " bản ghi";
            }
            else
            {
                dtgqdkt.DataSource = null;
                lbbanghi.Text = "Tổng số: 0 bản ghi";
            }
        }
    }
}
