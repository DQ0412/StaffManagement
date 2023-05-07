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
    public partial class HopDong : Form
    {
        public HopDong()
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
            string query = "SELECT * FROM HopDong Order by SoHD";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dtghd.DataSource = ds.Tables[0];
                lbbanghi.Text = "Tổng số: " + (dtghd.Rows.Count - 1) + " bản ghi";
            }
            else
            {
                dtghd.DataSource = null;
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
            txtsohd.Text = "";
            txtmaloai.Text = "";
            txtnoidung.Text = "";
            dtngay.Text = "";

            txtsohd.Focus();
            State = "Insert";
        }

        private void dtghd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtghd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow selectedRow = dtghd.Rows[i];

            txtsohd.Text = selectedRow.Cells["SoHD"].Value.ToString();
            txtmaloai.Text = selectedRow.Cells["Maloai"].Value.ToString();
            dtngay.Text = selectedRow.Cells["Ngaylap"].Value.ToString();
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

            txtsohd.Focus();
            State = "Update";
        }

        private void btnghi_Click(object sender, EventArgs e)
        {
            if (txtsohd.Text == "") { MessageBox.Show("Chưa nhập thông tin mã bảo hiểm.", "thông báo"); txtsohd.Focus(); return; }
            if (State == "Insert")
            {
                SqlConnection conn = new SqlConnection(conString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "Insert into HopDong(SoHD, Maloai, Ngaylap, Noidung) Values ('" + txtsohd.Text.Trim() + "',N'" + txtmaloai.Text.Trim() + "','" + dtngay.Value.ToString() + "',N'" + txtnoidung.Text.Trim() + "')";
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
                string query = "Update HopDong SET Maloai ='" + txtmaloai.Text.Trim() + "',Ngaylap='" + dtngay.Value.ToString() + "',Thoihan=N'" + txtnoidung.Text.Trim() + "' where SoHD='" + txtsohd.Text.Trim() + "'";
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
            string query = "DELETE FROM HopDong Where MaBH = '" + txtsohd.Text.Trim() + "'";
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
            string query = "SELECT * FROM HopDong Where SoHD like '%" + keyword + "%'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dtghd.DataSource = ds.Tables[0];
                lbbanghi.Text = "Tổng số: " + (dtghd.Rows.Count - 1) + " bản ghi";
            }
            else
            {
                dtghd.DataSource = null;
                lbbanghi.Text = "Tổng số: 0 bản ghi";
            }
        }

        private void txtsohd_TextChanged(object sender, EventArgs e)
        {
            int count = dtghd.Rows.Count;
            if (count > 99)
            {
                txtsohd.Text = "HD" + count++ + "";
            }
            else if (count > 9)
            {
                txtsohd.Text = "HD0" + count++ + "";
            }
            else
            {
                txtsohd.Text = "HD00" + count++ + "";
            }
        }
    }
}
