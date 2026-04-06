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
            try
            {
                using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
                {
                    using (SqlCommand cmd = new SqlCommand("spLogin", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@TenDangNhap", SqlDbType.NVarChar).Value = user.Trim();
                        cmd.Parameters.Add("@MatKhau", SqlDbType.NVarChar).Value = pass.Trim();

                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new TaiKhoan
                                {
                                    TenDangNhap = reader["TenDangNhap"]?.ToString(),
                                    VaiTro = reader["VaiTro"]?.ToString(),
                                    MaSV = reader["MaSV"] == DBNull.Value ? null : reader["MaSV"].ToString(),
                                    MaGV = reader["MaGV"] == DBNull.Value ? null : reader["MaGV"].ToString(),
                                    TenNguoiDung = reader["HoTen"]?.ToString(),
                                    MaKhoa = reader["MaKhoa"]?.ToString() // <-- THÊM DÒNG NÀY
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
            }
            return null;
        }

        // ================= LẤY THÔNG TIN USER =================
        public TaiKhoan GetUserInfo(string username)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                using (SqlCommand cmd = new SqlCommand("spGetUserInfo", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TenDangNhap", username.Trim());

                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new TaiKhoan
                            {
                                TenDangNhap = reader["TenDangNhap"]?.ToString(),
                                VaiTro = reader["VaiTro"]?.ToString(),
                                MaSV = reader["MaSV"] == DBNull.Value ? null : reader["MaSV"].ToString(),
                                MaGV = reader["MaGV"] == DBNull.Value ? null : reader["MaGV"].ToString(),
                                TenNguoiDung = reader["HoTen"]?.ToString(),
                                MaKhoa = reader["MaKhoa"]?.ToString() 
                            };
                        }
                    }
                }
            }
            return null;
        }

        // ================= ĐỔI MẬT KHẨU =================
        public bool ChangePassword(string username, string newPassword)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                using (SqlCommand cmd = new SqlCommand("spDoiMatKhau", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TenDangNhap", username.Trim());
                    cmd.Parameters.AddWithValue("@MatKhauMoi", newPassword.Trim());

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }
    }
}