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
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }
        public bool KiemTra()
        {
            if (txtUser.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUser.Focus();
                return false;
            }
            else if (txtOldPass.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtOldPass.Focus();
                return false;
            }
            else if (txtNewPass.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewPass.Focus();
                return false;
            }
            else if (txtNewPass2.Text == "")
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewPass2.Focus();
                return false;
            }
            else if (txtNewPass.Text != txtNewPass2.Text)
            {
                MessageBox.Show("Mật khẩu mới và mật khẩu xác nhận không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNewPass2.Focus();
                txtNewPass2.Focus();
                txtNewPass2.SelectAll();
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (KiemTra())
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

                    cmd.CommandText = "SP_Update_Pass";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@User", SqlDbType.Char).Value = txtUser.Text;
                    cmd.Parameters.Add("@OldPass", SqlDbType.Char).Value = txtOldPass.Text;
                    cmd.Parameters.Add("@NewPass", SqlDbType.Char).Value = txtNewPass.Text;

                    cmd.Connection = conn;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Đã đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    DangNhap dangNhap = new DangNhap();
                    dangNhap.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
