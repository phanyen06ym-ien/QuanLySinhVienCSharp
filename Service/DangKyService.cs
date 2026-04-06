using QuanLySinhVienCSharp.Models;
using QuanLySinhVienCSharp.Service;
using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySinhVienCSharp.Services
{
    public class DangKyService
    {
        // ================= ĐĂNG KÝ =================
        public bool DangKy(DangKy dk)
        {
            if (dk == null ||
                string.IsNullOrWhiteSpace(dk.MaSV) ||
                string.IsNullOrWhiteSpace(dk.MaHP))
                throw new Exception("Dữ liệu không hợp lệ");

            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                try
                {
                    using (SqlCommand cmd = new SqlCommand("spDangKyHoc", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MaSV", dk.MaSV.Trim());
                        cmd.Parameters.AddWithValue("@MaHP", dk.MaHP.Trim());
                        cmd.Parameters.AddWithValue("@HocKy", dk.HocKy);
                        cmd.Parameters.AddWithValue("@NamHoc", dk.NamHoc?.Trim());

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    // lấy lỗi từ SQL (RAISERROR)
                    throw new Exception("Đăng ký thất bại: " + ex.Message);
                }
            }
        }

        // ================= HỦY ĐĂNG KÝ =================
        public bool HuyDangKy(DangKy dk)
        {
            if (dk == null ||
                string.IsNullOrWhiteSpace(dk.MaSV) ||
                string.IsNullOrWhiteSpace(dk.MaHP))
                throw new Exception("Dữ liệu không hợp lệ");

            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                try
                {
                    using (SqlCommand cmd = new SqlCommand("spHuyDangKy", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MaSV", dk.MaSV.Trim());
                        cmd.Parameters.AddWithValue("@MaHP", dk.MaHP.Trim());
                        cmd.Parameters.AddWithValue("@HocKy", dk.HocKy);
                        cmd.Parameters.AddWithValue("@NamHoc", dk.NamHoc?.Trim());

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("Hủy đăng ký thất bại: " + ex.Message);
                }
            }
        }

        // ================= LẤY DANH SÁCH =================
        public DataTable GetByMaSV(string maSV)
        {
            if (string.IsNullOrWhiteSpace(maSV))
                throw new Exception("Mã sinh viên không hợp lệ");

            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                using (SqlCommand cmd = new SqlCommand("spXemDangKyTheoSV", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaSV", maSV.Trim());

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    return dt;
                }
            }
        }
    }
}