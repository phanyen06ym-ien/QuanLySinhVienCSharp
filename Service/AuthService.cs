using QuanLySinhVienCSharp.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVienCSharp.Services
{
    public class AuthService
    {
        public string Login(string user, string pass)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("sp_Login", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@TenDangNhap", user.Trim());
                    cmd.Parameters.AddWithValue("@MatKhau", pass.Trim());

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader["VaiTro"].ToString();
                        }
                    }

                    return null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi đăng nhập: " + ex.Message);
                    return null;
                }
            }
        }
    }
}
