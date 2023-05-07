using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS
{
    public partial class ThongtinNV : Form
    {
        public string conString = "Data Source=MSITINTO\\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True";
        public static string State = "-1";


        public ThongtinNV()
        {
            InitializeComponent();
            SetControl("Reset");
            GetData();

        }

        public void SetControl(string State)
        {
            switch (State)
            {
                case "Reset":
                    btnadd.Enabled = true;
                    btndele.Enabled = true;
                    btnup.Enabled = true;
                    btnhuy.Enabled = true;
                    btntim.Enabled = true;
                    btnghi.Enabled = false;
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
            string query = "SELECT * FROM NhanVien ";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dtgnv.DataSource = ds.Tables[0];
                lbbanghi.Text = "Tổng số: " + (dtgnv.Rows.Count - 1) + " bản ghi";
            }
            else
            {
                dtgnv.DataSource = null;
                lbbanghi.Text = "Tổng số: 0 bản ghi";
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnadd.Enabled = false;
            btnup.Enabled = false;
            btndele.Enabled = false;
            btnghi.Enabled = true;
            btnhuy.Enabled = true;
            txtmanv.Enabled = false;
            txttim.Text = "";
            txtmanv.Text = "";
            txtten.Text = "";
            txtgt.Text = "";
            txtdc.Text = "";
            txtqq.Text = "";
            dtns.Text = "";
            txtsdt.Text = "";

            txtluong.Text = "";

            txttim.Enabled = false;
            txtmanv.Focus();
            State = "Insert";

            cbtdhv.DisplayMember = "MaTDHV";
            string sql1 = "select MaTDHV from TrinhDoHV";
            cbtdhv.DataSource = LoadComboBox(sql1);

            cbmapb.DisplayMember = "MaPB";
            string sql2 = "select MaPB from PhongBan";
            cbmapb.DataSource = LoadComboBox(sql2);

            cbcv.DisplayMember = "MaCV";
            string sql3 = "select MaCV from ChucVu";
            cbcv.DataSource = LoadComboBox(sql3);

            cbbh.DisplayMember = "MaBH";
            string sql4 = "select MaBH from BaoHiem";
            cbbh.DataSource = LoadComboBox(sql4);



        }
        public DataTable LoadComboBox(String sql)
        {
            SqlConnection connection = new SqlConnection(conString);
            //string mapb = "select MaPB from PhongBan";
            //string macv = "select MaCV from ChucVu";
            //string matdhv = "select MaHD from TrinhDoHV";
            //string mabh = "select MaBH from BaoHiem";

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                //var read = command.ExecuteReader();
                //var dt1 = new DataTable();
                //dt1.Load(read);

                SqlDataAdapter d = new SqlDataAdapter(command);
                d.SelectCommand = command;
                DataTable dt = new DataTable();
                d.Fill(dt);
                return dt;
            }


        }
        private void dtgnv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow selectedRow = dtgnv.Rows[i];

            txtmanv.Text = selectedRow.Cells["MaNV"].Value.ToString();
            txtten.Text = selectedRow.Cells["TenNV"].Value.ToString();
            txtgt.Text = selectedRow.Cells["Gioitinh"].Value.ToString();
            txtdc.Text = selectedRow.Cells["MaNV"].Value.ToString();
            txtqq.Text = selectedRow.Cells["Quequan"].Value.ToString();
            dtns.Text = selectedRow.Cells["Ngaysinh"].Value.ToString();
            txtsdt.Text = selectedRow.Cells["SDT"].Value.ToString();
            cbtdhv.Text = selectedRow.Cells["TrinhdoHV"].Value.ToString();
            cbmapb.Text = selectedRow.Cells["MaPB"].Value.ToString();
            cbcv.Text = selectedRow.Cells["MaCV"].Value.ToString();
            cbbh.Text = selectedRow.Cells["MaBH"].Value.ToString();
            txtluong.Text = selectedRow.Cells["Luong"].Value.ToString();
        }

        private void btnxem_Click(object sender, EventArgs e)
        {


        }

        private void dtgnv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnghi_Click(object sender, EventArgs e)
        {
            //if (txtmanv.Text == "") { MessageBox.Show("Chưa nhập thông tin mã nhân viên.", "thông báo"); txtmanv.Focus(); return; }
            if (State == "Insert")
            {
                int count = dtgnv.Rows.Count;
                if (count > 99)
                {
                    txtmanv.Text = "NVM" + count++ + "";
                }
                else if (count > 9)
                {
                    txtmanv.Text = "NVM0" + count++ + "";
                }
                else
                {
                    txtmanv.Text = "NVM00" + count++ + "";
                }
                SqlConnection conn = new SqlConnection(conString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "Insert into NhanVien(MaNV, TenNV, Gioitinh, Diachi, Quequan, Ngaysinh, SDT, TrinhdoHV, MaCV, MaPB, MaBH, Luong) Values ('" + txtmanv.Text.Trim() + "',N'" + txtten.Text.Trim() + "',N'" + txtgt.Text.Trim() + "',N'" + txtdc.Text.Trim() + "',N'" + txtqq.Text.Trim() + "','" + dtns.Value.ToString() + "','" + txtsdt.Text.Trim() + "',N'" + cbtdhv.Text.Trim() + "','" + cbcv.Text.Trim() + "','" + cbmapb.Text.Trim() + "','" + cbbh.Text.Trim() + "','" + txtluong.Text.Trim() + "')";

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
                string query = "Update NhanVien SET TenNV =N'" + txtten.Text.Trim() + "',Gioitinh=N'" + txtgt.Text.Trim() + "',Diachi=N'" + txtdc.Text.Trim() + "',Quequan=N'" + txtqq.Text.Trim() + "',Ngaysinh='" + dtns.Value.ToString() + "',SDT='" + txtsdt.Text.Trim() + "',TrinhdoHV=N'" + cbtdhv.Text.Trim() + "',MaCV='" + cbcv.Text.Trim() + "',MaPB='" + cbmapb.Text.Trim() + "',MaBH='" + cbbh.Text.Trim() + "',Luong='" + txtluong.Text.Trim() + "' Where MaNV = '" + txtmanv.Text.Trim() + "'";
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

        private void btnup_Click(object sender, EventArgs e)
        {
            btnadd.Enabled = false;
            btnup.Enabled = false;
            btndele.Enabled = false;
            btnghi.Enabled = true;
            btnhuy.Enabled = true;
            txttim.Enabled = false;
            btntim.Enabled = false;
            txtmanv.Focus();
            State = "Update";
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            txtmanv.Enabled = true;
            txttim.Enabled = true;
            SetControl("Reset");
        }

        private void btndele_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = "DELETE FROM NhanVien Where MaNV = '" + txtmanv.Text.Trim() + "'";
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
            string query = "SELECT * FROM NhanVien Where MaNV like '%" + keyword + "%'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dtgnv.DataSource = ds.Tables[0];
                lbbanghi.Text = "Tổng số: " + (dtgnv.Rows.Count - 1) + " bản ghi";
            }
            else
            {
                dtgnv.DataSource = null;
                lbbanghi.Text = "Tổng số: 0 bản ghi";
            }
        }



       

        private void btnin_Click(object sender, EventArgs e)
        {
            Print pr = new Print();
            pr.ShowDialog();
        }
    }
}
