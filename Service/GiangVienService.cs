using QuanLySinhVienCSharp.Models;
using QuanLySinhVienCSharp.Service;
using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySinhVienCSharp.Services
{
    public class GiangVienService
    {
        // ================= LẤY DANH SÁCH =================
        public DataTable GetAll()
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                using (SqlCommand cmd = new SqlCommand("spXemGiangVien", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        // ================= LẤY THEO ID =================
        public DataTable GetById(string maGV)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                string sql = "SELECT * FROM GIANGVIEN WHERE MaGV = @MaGV";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@MaGV", maGV);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }

        // ================= THÊM =================
        public bool Add(GiangVien gv)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                try
                {
                    using (SqlCommand cmd = new SqlCommand("spThemGiangVien", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MaGV", gv.MaGV);
                        cmd.Parameters.AddWithValue("@HoTen", gv.HoTen);
                        cmd.Parameters.AddWithValue("@GioiTinh", gv.GioiTinh);
                        cmd.Parameters.AddWithValue("@DiaChi", gv.DiaChi);
                        cmd.Parameters.AddWithValue("@Email", gv.Email);
                        cmd.Parameters.AddWithValue("@MaKhoa", gv.MaKhoa);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("Lỗi thêm giảng viên: " + ex.Message);
                }
            }
        }

        // ================= CẬP NHẬT =================
        public bool Update(GiangVien gv)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                try
                {
                    using (SqlCommand cmd = new SqlCommand("spSuaGiangVien", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MaGV", gv.MaGV);
                        cmd.Parameters.AddWithValue("@HoTen", gv.HoTen);
                        cmd.Parameters.AddWithValue("@GioiTinh", gv.GioiTinh);
                        cmd.Parameters.AddWithValue("@DiaChi", gv.DiaChi);
                        cmd.Parameters.AddWithValue("@Email", gv.Email);
                        cmd.Parameters.AddWithValue("@MaKhoa", gv.MaKhoa);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("Lỗi cập nhật giảng viên: " + ex.Message);
                }
            }
        }

        // ================= XÓA =================
        public bool Delete(string maGV)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                try
                {
                    using (SqlCommand cmd = new SqlCommand("spXoaGiangVien", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MaGV", maGV);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("Lỗi xóa giảng viên: " + ex.Message);
                }
            }
        }

        // tìm kiếm 
        public DataTable Search(string keyword)
        {
            DataTable dt = GetAll();
            DataRow[] rows = dt.Select($"MaGV LIKE '%{keyword}%' OR HoTen LIKE '%{keyword}%'");
            DataTable result = dt.Clone();
            foreach (var r in rows)
                result.ImportRow(r);
            return result;
        }

        // ================= LỚP + HỌC PHẦN PHỤ TRÁCH =================
        public DataTable GetPhanCong(string maGV)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                using (SqlCommand cmd = new SqlCommand("spXemPhanCongTheoGV", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MaGV", maGV);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    return dt;
                }
            }
        }
    }
}