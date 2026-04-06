using QuanLySinhVienCSharp.Models;
using QuanLySinhVienCSharp.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySinhVienCSharp.Services
{
    public class TaiKhoanService
    {
        // ================= DANH SÁCH =================
        public List<TaiKhoan> GetAll()
        {
            List<TaiKhoan> list = new List<TaiKhoan>();

            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM VIEW_TaiKhoan_FullInfo", conn))
                {
                    conn.Open();

                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            list.Add(new TaiKhoan
                            {
                                TenDangNhap = r["TenDangNhap"]?.ToString(),
                                VaiTro = r["VaiTro"]?.ToString(),
                                TenNguoiDung = r["TenNguoiDung"]?.ToString()
                            });
                        }
                    }
                }
            }

            return list;
        }

        // ================= THÊM =================
        public bool Add(TaiKhoan tk)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("spThemTaiKhoan", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Dùng NVarChar cho mật khẩu
                    cmd.Parameters.Add("@TenDangNhap", SqlDbType.VarChar).Value = tk.TenDangNhap.Trim();
                    cmd.Parameters.Add("@MatKhau", SqlDbType.NVarChar).Value = tk.MatKhau.Trim();
                    cmd.Parameters.Add("@VaiTro", SqlDbType.NVarChar).Value = tk.VaiTro;
                    cmd.Parameters.Add("@MaSV", SqlDbType.VarChar).Value = (object)tk.MaSV ?? DBNull.Value;
                    cmd.Parameters.Add("@MaGV", SqlDbType.VarChar).Value = (object)tk.MaGV ?? DBNull.Value;

                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
        }

        // ================= XÓA =================
        public bool Delete(string username)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("spXoaTaiKhoan", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TenDangNhap", username.Trim());

                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
        }
        public bool Exists(string username)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                string sql = "SELECT COUNT(*) FROM TAIKHOAN WHERE TenDangNhap = @TenDangNhap";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@TenDangNhap", SqlDbType.VarChar).Value = username.Trim();

                    conn.Open();

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}