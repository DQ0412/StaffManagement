using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLNS
{
    public static class ConnectionSingleton
    {
        static SqlConnection conn;
        public static SqlConnection GetConnection()
        {
            if (conn == null)
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder["Data Source"] = "MSITINTO\\SQLEXPRESS";
                builder["integrated Security"] = true;
                builder["Initial Catalog"] = "QLNS";
                builder.UserID = "MSITINTO\\SQLEXPRESS";
                conn = new SqlConnection(builder.ConnectionString);
                conn.Open();
                return conn;
            }
            else
                return conn;
        }
    }
}
