using QuanLySinhVienCSharp.Models;
using QuanLySinhVienCSharp.Service;
using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySinhVienCSharp.Services
{
    public class HocPhanService
    {
        // ================= LẤY DANH SÁCH =================
        public DataTable GetAll()
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                using (SqlCommand cmd = new SqlCommand("spXemHocPhan", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    return dt;
                }
            }
        }

        // ================= THÊM =================
        public bool Add(HocPhan hp)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                try
                {
                    using (SqlCommand cmd = new SqlCommand("spThemHocPhan", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MaHP", hp.MaHP);
                        cmd.Parameters.AddWithValue("@TenHP", hp.TenHP);
                        cmd.Parameters.AddWithValue("@TinChi", hp.TinChi);
                        cmd.Parameters.AddWithValue("@MaKhoa", hp.MaKhoa);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("Lỗi thêm học phần: " + ex.Message);
                }
            }
        }

        // ================= CẬP NHẬT =================
        public bool Update(HocPhan hp)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                try
                {
                    using (SqlCommand cmd = new SqlCommand("spSuaHocPhan", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MaHP", hp.MaHP);
                        cmd.Parameters.AddWithValue("@TenHP", hp.TenHP);
                        cmd.Parameters.AddWithValue("@TinChi", hp.TinChi);
                        cmd.Parameters.AddWithValue("@MaKhoa", hp.MaKhoa);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("Lỗi cập nhật học phần: " + ex.Message);
                }
            }
        }

        // ================= XÓA =================
        public bool Delete(string maHP)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                try
                {
                    using (SqlCommand cmd = new SqlCommand("spXoaHocPhan", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MaHP", maHP);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("Lỗi xóa học phần: " + ex.Message);
                }
            }
        }
    }
}