using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLNS
{
    public partial class ChucVu : Form
    {
        public ChucVu()
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
            string query = "SELECT * FROM ChucVu Order by MaCV";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dtgcv.DataSource = ds.Tables[0];
                lbbanghi.Text = "Tổng số: " + (dtgcv.Rows.Count - 1) + " bản ghi";
            }
            else
            {
                dtgcv.DataSource = null;
                lbbanghi.Text = "Tổng số: 0 bản ghi";
            }
        }
        private void PhongBan_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnthem.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnghi.Enabled = false;
            btnghi.Enabled = true;
            btnhuy.Enabled = true;

            txttim.Text = "";
            txtmacv.Text = "";
            txttencv.Text = "";
            txtmacv.Enabled = false;

            txtmacv.Focus();
            State = "Insert";
        }

        private void dtgcv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow selectedRow = dtgcv.Rows[i];

            txtmacv.Text = selectedRow.Cells["MaCV"].Value.ToString();
            txttencv.Text = selectedRow.Cells["TenCV"].Value.ToString();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            btnthem.Enabled = false;
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnghi.Enabled = false;
            btnghi.Enabled = true;
            btnhuy.Enabled = true;

            txtmacv.Focus();
            State = "Update";
        }

        private void btnghi_Click(object sender, EventArgs e)
        {
            int count = dtgcv.Rows.Count;
            if (count > 99)
            {
                txtmacv.Text = "CV" + count++ + "";
            }
            else if (count > 9)
            {
                txtmacv.Text = "CV0" + count++ + "";
            }
            else
            {
                txtmacv.Text = "CV00" + count++ + "";
            }
            //if (txtmacv.Text == "") { MessageBox.Show("Chưa nhập thông tin mã bảo hiểm.", "thông báo"); txtmacv.Focus(); return; }
            if (State == "Insert")
            {
                SqlConnection conn = new SqlConnection(conString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "Insert into ChucVu(MaCV, TenCV) Values ('" + txtmacv.Text.Trim() + "',N'" + txttencv.Text.Trim() + "')";
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
                string query = "Update ChucVu SET TenCV =N'" + txttencv.Text.Trim() + "' where MaCV='" + txtmacv.Text.Trim() + "'";
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
            string query = "DELETE FROM ChucVu Where MaCV = '" + txtmacv.Text.Trim() + "'";
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
            txtmacv.Enabled = true;
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
            string query = "SELECT * FROM ChucVu Where MaCV like '%" + keyword + "%'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dtgcv.DataSource = ds.Tables[0];
                lbbanghi.Text = "Tổng số: " + (dtgcv.Rows.Count - 1) + " bản ghi";
            }
            else
            {
                dtgcv.DataSource = null;
                lbbanghi.Text = "Tổng số: 0 bản ghi";
            }
        }

        private void txtmacv_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
