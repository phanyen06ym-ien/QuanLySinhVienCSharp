using QuanLySinhVienCSharp.Models;
using QuanLySinhVienCSharp.Service;
using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySinhVienCSharp.Services
{
    public class AuthService
    {
        // ================= LOGIN =================
        public TaiKhoan Login(string user, string pass)
        {
            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
                throw new Exception("Thiếu tài khoản hoặc mật khẩu");

            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("spLogin", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@TenDangNhap", SqlDbType.VarChar).Value = user.Trim();
                    cmd.Parameters.Add("@MatKhau", SqlDbType.VarChar).Value = pass.Trim();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new TaiKhoan
                            {
                                TenDangNhap = reader["TenDangNhap"]?.ToString(),
                                VaiTro = reader["VaiTro"]?.ToString(),
                                MaSV = reader["MaSV"] as string,
                                MaGV = reader["MaGV"] as string,
                                TenNguoiDung = reader["HoTen"]?.ToString()
                            };
                        }
                    }
                }
            }

            return null; // sai login
        }

        // ================= CHECK USER =================
        public bool CheckUserExists(string username)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM TAIKHOAN WHERE TenDangNhap = @user";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = username.Trim();
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }

        // ================= ĐỔI MẬT KHẨU =================
        public bool ChangePassword(string username, string newPassword)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                // kiểm tra user tồn tại
                if (!CheckUserExists(username))
                    throw new Exception("Tài khoản không tồn tại");

                string query = "UPDATE TAIKHOAN SET MatKhau = @pass WHERE TenDangNhap = @user";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = username;
                    cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = newPassword;

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // ================= LẤY THÔNG TIN USER =================
        public TaiKhoan GetUserInfo(string username)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                string query = @"
                    SELECT 
                        tk.TenDangNhap,
                        tk.VaiTro,
                        tk.MaSV,
                        tk.MaGV,
                        COALESCE(sv.HoTen, gv.HoTen, N'Admin') AS HoTen
                    FROM TAIKHOAN tk
                    LEFT JOIN SINHVIEN sv ON tk.MaSV = sv.MaSV
                    LEFT JOIN GIANGVIEN gv ON tk.MaGV = gv.MaGV
                    WHERE tk.TenDangNhap = @user";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = username;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new TaiKhoan
                            {
                                TenDangNhap = reader["TenDangNhap"]?.ToString(),
                                VaiTro = reader["VaiTro"]?.ToString(),
                                MaSV = reader["MaSV"] as string,
                                MaGV = reader["MaGV"] as string,
                                TenNguoiDung = reader["HoTen"]?.ToString()
                            };
                        }
                    }
                }
            }

            return null;
        }
    }
}