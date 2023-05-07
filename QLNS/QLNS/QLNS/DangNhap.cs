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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        public string taikhoan = "";
        public string quyen = "";
        public void btndn_Click(object sender, EventArgs e)
        {
            taikhoan = txttklg.Text;
            quyen = "";
            if (taikhoan.Equals("Admin"))
            {
                quyen = "admin";
            }
            else if (taikhoan.Equals("User"))
            {
                quyen = "user";
            }
            SqlConnection conn = new SqlConnection(@"Data Source=MSITINTO\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True");
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            SqlCommand cmd = new SqlCommand("select * from DangNhap Where Tendn = '" + txttklg.Text + "' and Matkhau = '" + txtmklg.Text + "'", conn);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            var rs = dt;
            if (rs.Rows.Count > 0)
            {
                MessageBox.Show("Dang nhap thanh cong!");
                this.Hide();
                //PhanQuyen pq = new PhanQuyen(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString());
                //pq.Show();
                Main m = new Main();
                m.Show();
            }
            else
            {
                MessageBox.Show("Dang nhap that bai!");
            }
        }

        private void btndk_Click(object sender, EventArgs e)
        {

        }

        private void cbmk_CheckedChanged(object sender, EventArgs e)
        {
            if (cbmk.Checked)
            {
                txtmklg.UseSystemPasswordChar = false;
            }
            else
            {
                txtmklg.UseSystemPasswordChar = true;
            }
        }

        private void llbquen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void txtmklg_TextChanged(object sender, EventArgs e)
        {

        }
    }
}