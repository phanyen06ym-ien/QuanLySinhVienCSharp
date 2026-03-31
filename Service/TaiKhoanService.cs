using QuanLySinhVienCSharp.Models;
using QuanLySinhVienCSharp.Service;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace QuanLySinhVienCSharp.Services
{
    public class TaiKhoanService
    {
        public List<TaiKhoan> GetAll()
        {
            List<TaiKhoan> list = new List<TaiKhoan>();

            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT * FROM TaiKhoan", conn);
                var r = cmd.ExecuteReader();

                while (r.Read())
                {
                    list.Add(new TaiKhoan
                    {
                        TenDangNhap = r["TenDangNhap"].ToString(),
                        MatKhau = r["MatKhau"].ToString(),
                        VaiTro = r["VaiTro"].ToString(),
                        MaSV = r["MaSV"]?.ToString(),
                        MaGV = r["MaGV"]?.ToString()
                    });
                }
            }

            return list;
        }

        public bool Add(string user, string pass, string role, string maSV = null, string maGV = null)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();
                string sql = "INSERT INTO TAIKHOAN (TenDangNhap, MatKhau, VaiTro, MaSV, MaGV) " +
                             "VALUES (@u, @p, @r, @msv, @mgv)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@u", user);
                cmd.Parameters.AddWithValue("@p", pass);
                cmd.Parameters.AddWithValue("@r", role);
                cmd.Parameters.AddWithValue("@msv", (object)maSV ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@mgv", (object)maGV ?? DBNull.Value);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(string user)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                var cmd = new SqlCommand(
                    "DELETE FROM TaiKhoan WHERE TenDangNhap=@u", conn);

                cmd.Parameters.AddWithValue("@u", user);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}