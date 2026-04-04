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
        // ================= LẤY DANH SÁCH =================
        public List<TaiKhoan> GetAll()
        {
            List<TaiKhoan> list = new List<TaiKhoan>();

            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                string sql = @"
                    SELECT tk.*, 
                           COALESCE(sv.HoTen, gv.HoTen, N'Admin') AS TenNguoiDung
                    FROM TAIKHOAN tk
                    LEFT JOIN SINHVIEN sv ON tk.MaSV = sv.MaSV
                    LEFT JOIN GIANGVIEN gv ON tk.MaGV = gv.MaGV";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        list.Add(new TaiKhoan
                        {
                            TenDangNhap = r["TenDangNhap"]?.ToString(),
                            MatKhau = r["MatKhau"]?.ToString(),
                            VaiTro = r["VaiTro"]?.ToString(),

                            MaSV = r["MaSV"] == DBNull.Value ? null : r["MaSV"].ToString(),
                            MaGV = r["MaGV"] == DBNull.Value ? null : r["MaGV"].ToString(),

                            TenNguoiDung = r["TenNguoiDung"]?.ToString()
                        });
                    }
                }
            }

            return list;
        }

        // ================= THÊM =================
        public bool Add(TaiKhoan tk)
        {
            if (tk == null) throw new ArgumentNullException(nameof(tk));

            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                string sql = @"
                    INSERT INTO TAIKHOAN (TenDangNhap, MatKhau, VaiTro, MaSV, MaGV) 
                    VALUES (@u, @p, @r, @msv, @mgv)";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@u", SqlDbType.NVarChar).Value = tk.TenDangNhap;
                    cmd.Parameters.Add("@p", SqlDbType.NVarChar).Value = tk.MatKhau;
                    cmd.Parameters.Add("@r", SqlDbType.NVarChar).Value = tk.VaiTro;

                    cmd.Parameters.Add("@msv", SqlDbType.NVarChar).Value =
                        (object)tk.MaSV ?? DBNull.Value;

                    cmd.Parameters.Add("@mgv", SqlDbType.NVarChar).Value =
                        (object)tk.MaGV ?? DBNull.Value;

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // ================= XÓA =================
        public bool Delete(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new Exception("Username không hợp lệ");

            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                string sql = "DELETE FROM TAIKHOAN WHERE TenDangNhap = @u";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@u", SqlDbType.NVarChar).Value = username;
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // ================= KIỂM TRA USER =================
        public bool Exists(string username)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                string sql = "SELECT COUNT(*) FROM TAIKHOAN WHERE TenDangNhap = @u";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@u", SqlDbType.NVarChar).Value = username;
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }
    }
}