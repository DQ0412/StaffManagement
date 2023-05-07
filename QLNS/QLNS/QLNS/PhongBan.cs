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

namespace QLNS
{
    public partial class PhongBan : Form
    {
        public PhongBan()
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
            string query = "SELECT * FROM PhongBan Order by MaPB";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dtgpb.DataSource = ds.Tables[0];
                lbbanghi.Text = "Tổng số: " + (dtgpb.Rows.Count - 1) + " bản ghi";
            }
            else
            {
                dtgpb.DataSource = null;
                lbbanghi.Text = "Tổng số: 0 bản ghi";
            }
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            int count = dtgpb.Rows.Count;
            if (count > 99)
            {
                txtmapb.Text = "NV" + count++ + "";
            }
            else if (count > 9)
            {
                txtmapb.Text = "NV0" + count++ + "";
            }
            else
            {
                txtmapb.Text = "NV00" + count++ + "";
            }
            txtmapb.Enabled = false;
            btnthem.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnghi.Enabled = false;
            btnghi.Enabled = true;
            btnhuy.Enabled = true;


            txttim.Text = "";
            txtmapb.Text = "";
            txttenpb.Text = "";


            txtmapb.Focus();
            State = "Insert";
        }

        private void dtgpb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow selectedRow = dtgpb.Rows[i];

            txtmapb.Text = selectedRow.Cells["MaPB"].Value.ToString();
            txttenpb.Text = selectedRow.Cells["TenPB"].Value.ToString();

        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            btnthem.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnghi.Enabled = false;
            btnghi.Enabled = true;
            btnhuy.Enabled = true;

            txtmapb.Focus();
            State = "Update";
        }

        private void btnghi_Click(object sender, EventArgs e)
        {
            //if (txtmapb.Text == "") { MessageBox.Show("Chưa nhập thông tin mã bảo hiểm.", "thông báo"); txtmapb.Focus(); return; }
            if (State == "Insert")
            {
                int count = dtgpb.Rows.Count;
                if (count > 99)
                {
                    txtmapb.Text = "NS" + count++ + "";
                }
                else if (count > 9)
                {
                    txtmapb.Text = "NS0" + count++ + "";
                }
                else
                {
                    txtmapb.Text = "NS00" + count++ + "";
                }
                SqlConnection conn = new SqlConnection(conString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "Insert into PhongBan(MaPB, TenPB) Values ('" + txtmapb.Text.Trim() + "',N'" + txttenpb.Text.Trim() + "')";
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
                string query = "Update PhongBan SET TenPB =N'" + txttenpb.Text.Trim() + "' where MaPB='" + txtmapb.Text.Trim() + "'";
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
            txtmapb.Enabled = true;
            SqlConnection conn = new SqlConnection(conString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = "DELETE FROM PhongBan Where MaPB = '" + txtmapb.Text.Trim() + "'";
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
            txtmapb.Enabled = true;
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
            string query = "SELECT * FROM PhongBan Where MaPB like '%" + keyword + "%'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dtgpb.DataSource = ds.Tables[0];
                lbbanghi.Text = "Tổng số: " + (dtgpb.Rows.Count - 1) + " bản ghi";
            }
            else
            {
                dtgpb.DataSource = null;
                lbbanghi.Text = "Tổng số: 0 bản ghi";
            }
        }

        private void txtmapb_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
