using QuanLySinhVienCSharp.Service;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVienCSharp.Services
{
    public class AuthService
    {
        public string Login(string user, string pass)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                string q = @"SELECT VaiTro 
                         FROM TaiKhoan 
                         WHERE TenDangNhap=@u AND MatKhau=@p";

                SqlCommand cmd = new SqlCommand(q, conn);
                cmd.Parameters.AddWithValue("@u", user);
                cmd.Parameters.AddWithValue("@p", pass);

                var result = cmd.ExecuteScalar();
                return result?.ToString();
            }
        }
    }
}
