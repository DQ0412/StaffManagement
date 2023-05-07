using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net.Mail;

namespace QLNS
{
    internal class UserModel
    {
        private TextBox textBox1;

        public string Hoten { get; set; }
        public string Tendn { get; set; }
        public string Matkhau { get; set; }
        public string Sdt { get; set; }
        public string Ngaysinh { get; set; }
        public string Email { get; set; }
        public string Cauhoi { get; set; }
        public string Traloi { get; set; }

        public UserModel() { }

        public UserModel(string hoten, string tendn, string matkhau, string sdt, string ngaysinh, string email, string cauhoi, string traloi)
        {

            Hoten = hoten;
            Tendn = tendn;
            Matkhau = matkhau;
            Sdt = sdt;
            Ngaysinh = ngaysinh;
            Email = email;
            Cauhoi = cauhoi;
            Traloi = traloi;
        }

        public UserModel(TextBox textBox1)
        {
            this.textBox1 = textBox1;
        }

        public void InsertUser(SqlConnection connection)
        {
            string query = "INSERT INTO dangky ( hoten, tendn, matkhau,sdt, ngaysinh, email, cauhoi, traloi) " +
                           "VALUES ( @HoTen, @Tendn, @Matkhau,@Sdt, @Ngaysinh,  @Email, @Cauhoi, @Traloi)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@HoTen", Hoten);
                command.Parameters.AddWithValue("@Tendn", Tendn);
                command.Parameters.AddWithValue("@Matkhau", Matkhau);
                command.Parameters.AddWithValue("@Sdt", Sdt);
                command.Parameters.AddWithValue("@Ngaysinh", Ngaysinh);

                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@Cauhoi", Cauhoi);
                command.Parameters.AddWithValue("@Traloi", Traloi);
                command.ExecuteNonQuery();
            }
        }

        public bool CheckIfUserExists(SqlConnection connection)
        {
            string query = "SELECT COUNT(*) FROM dangky WHERE Tendn = @Tendn";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Tendn", Tendn);

                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }
        public bool CheckSecurityQT(SqlConnection connection)
        {
            string query = "SELECT COUNT(*) FROM dangky WHERE Cauhoi like @Cauhoi and Traloi like @Traloi";

            using (SqlCommand command = new SqlCommand(query, connection))
            {


                command.Parameters.AddWithValue("@Cauhoi", Cauhoi);
                command.Parameters.AddWithValue("@Traloi", Traloi);

                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }

        public bool CheckPassWord(SqlConnection connection)
        {
            string query = "SELECT COUNT(*) FROM dangky WHERE Tendn like @Tendn and Matkhau like @Matkhau";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Tendn", Tendn);
                command.Parameters.AddWithValue("@Matkhau", Matkhau);
                int count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }

        
        public bool IsVaLid(string email)
        {
            var valid = true;
            try
            {
                var emailaddress = new MailAddress(email);
            }
            catch
            {
                valid = false;
            }
            return valid;
        }
    }
}

