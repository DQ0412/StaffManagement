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
    public partial class Luong : Form
    {
        public Luong()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public bool KTThongTin()
        {
            if (txtmanv.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmanv.Focus();
                return false;
            }
            if (txtgt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtgt.Focus();
                return false;
            }
            if (txthoten.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txthoten.Focus();
                return false;
            }
            if (txtphong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập phòng ban", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtphong.Focus();
                return false;
            }
            if (txtchucvu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtchucvu.Focus();
                return false;
            }
            if (txtbophan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập bộ phận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbophan.Focus();
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (KTThongTin())
            {
                try
                {
                    SqlConnection conn = new SqlConnection();
                    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                    builder["Data Source"] = "MSITINTO\\SQLEXPRESS";
                    builder["integrated Security"] = true;
                    builder["Initial Catalog"] = "QLNS";
                    builder.UserID = "MSITINTO\\SQLEXPRESS";
                    conn = new SqlConnection(builder.ConnectionString); SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "SP_Luong";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaNV", SqlDbType.Char).Value = txtmanv.Text;
                    cmd.Parameters.Add("@Gioitinh", SqlDbType.Char).Value = txtgt.Text;
                    cmd.Parameters.Add("@Hoten", SqlDbType.NVarChar).Value = txthoten.Text;
                    cmd.Parameters.Add("@Phong", SqlDbType.NVarChar).Value = txtphong.Text;
                    cmd.Parameters.Add("@ChucVu", SqlDbType.NVarChar).Value = txtchucvu.Text;
                    cmd.Parameters.Add("@BoPhan", SqlDbType.NVarChar).Value = txtbophan.Text;
                    cmd.Parameters.Add("@SoNgayLam", SqlDbType.Char).Value = txtsongaylam.Text;
                    cmd.Parameters.Add("@Thang", SqlDbType.Char).Value = txtthang.Text;
                    cmd.Parameters.Add("@HeSoLuong", SqlDbType.Float).Value = txthesoluong.Text;
                    cmd.Parameters.Add("@LuongCoBan", SqlDbType.Char).Value = txtluongcoban.Text;
                    cmd.Parameters.Add("@UngLuong", SqlDbType.Char).Value = txtungluong.Text;
                    cmd.Parameters.Add("@LuongPhuCap", SqlDbType.Char).Value = txtluongphucap.Text;
                    cmd.Parameters.Add("@Tong", SqlDbType.Char).Value = lbltong.Text;




                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Đã lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_Tong_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy số ngày làm từ TextBox
                int songay = int.Parse(txtsongaylam.Text);

                // Lấy hệ số lương từ TextBox
                float heso = float.Parse(txthesoluong.Text);

                // Lấy lương cơ bản từ TextBox
                int luongcb = int.Parse(txtluongcoban.Text);

                // Lấy lương phụ cấp từ TextBox
                int phucap = int.Parse(txtluongphucap.Text);

                // Lấy ứng lương từ TextBox
                int ungluong = int.Parse(txtungluong.Text);

                // Tính lương
                double salary = (luongcb * heso) * songay + phucap - ungluong;

                // Hiển thị kết quả lương trên Label
                lbltong.Text = $"Lương: {salary}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
