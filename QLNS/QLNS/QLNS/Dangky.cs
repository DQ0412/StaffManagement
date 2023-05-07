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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace QLNS
{
    public partial class Dangky : Form
    {
        public Dangky()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=MSITINTO\\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True";
        private void textBox1_Leave(object sender, EventArgs e)
        {
            UserModel m = new UserModel("", txttendn.Text, "", "", "", "", "", "");
            if (m.CheckIfUserExists(ConnectionSingleton.GetConnection()))
            {
                MessageBox.Show("User Exists");
                txttendn.Focus();
            }
        }
        private void btndk_Click(object sender, EventArgs e)
        {

            if (txthoten.Text == "" || txttendn.Text == "" || txtmk.Text == "" || txtsdt.Text == "" || dtns.Text == "" || txtemail.Text == "" || cbbcauhoi.Text == "" || txttraloi.Text == "")
            {
                MessageBox.Show("Please fill in the information to register");
            }
            else
            {
                

                UserModel u = new UserModel("", txttendn.Text, "", "","", "", "", "");
                if (u.CheckIfUserExists(ConnectionSingleton.GetConnection()))
                    MessageBox.Show("User Exists");
                else if (u.IsVaLid(txtemail.Text) == false)
                {
                    MessageBox.Show("Email is not valid");
                    txtemail.Focus();
                }
                else
                {

                    SqlConnection con = new SqlConnection(conString);
                    con.Open();
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        string q = "insert into dangky values('" + txthoten.Text.ToString() + "','" + txttendn.Text.ToString() + "','" + txtmk.Text.ToString() + "','" + txtsdt.Text.ToString() + "','" + dtns.Value.ToString() + "','" + txtemail.Text.ToString() + "', '" + cbbcauhoi.Text.ToString() + "', '" + txttraloi.Text.ToString() + "')";
                        SqlCommand cmd = new SqlCommand(q, con);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Dang ky thanh cong");
                        this.Close();
                        DangNhap f1 = new DangNhap();
                        f1.ShowDialog();
                    }
                }
            }
        }
    }
}
