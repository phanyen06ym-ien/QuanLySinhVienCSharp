using QuanLySinhVienCSharp.Models;
using QuanLySinhVienCSharp.Service;
using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySinhVienCSharp.Services
{
    public class GiangVienService
    {
        public DataTable GetAll()
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM GiangVien", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable GetById(string maGV)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                string sql = "SELECT * FROM GiangVien WHERE MaGV = @ma";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@ma", maGV);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool Add(GiangVien gv)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("sp_ThemGiangVien", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaGV", gv.MaGV);
                    cmd.Parameters.AddWithValue("@HoTen", gv.HoTen);
                    cmd.Parameters.AddWithValue("@GioiTinh", gv.GioiTinh);
                    cmd.Parameters.AddWithValue("@DiaChi", gv.DiaChi);
                    cmd.Parameters.AddWithValue("@Email", gv.Email);
                    cmd.Parameters.AddWithValue("@MaKhoa", gv.MaKhoa);

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi thêm giảng viên: " + ex.Message);
                }
            }
        }

        public bool Update(GiangVien gv)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("sp_SuaGiangVien", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaGV", gv.MaGV);
                    cmd.Parameters.AddWithValue("@HoTen", gv.HoTen);
                    cmd.Parameters.AddWithValue("@GioiTinh", gv.GioiTinh);
                    cmd.Parameters.AddWithValue("@DiaChi", gv.DiaChi);
                    cmd.Parameters.AddWithValue("@Email", gv.Email);
                    cmd.Parameters.AddWithValue("@MaKhoa", gv.MaKhoa);

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi cập nhật giảng viên: " + ex.Message);
                }
            }
        }

        public bool Delete(string maGV)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("sp_XoaGiangVien", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MaGV", maGV);

                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi xóa giảng viên: " + ex.Message);
                }
            }
        }
        public DataTable GetLopPhuTrach(string maGV)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                string sql = @"SELECT 
                            PC.MaLop, 
                            HP.TenHP AS [Học Phần], 
                            HP.TinChi AS [Tín Chỉ], 
                            PC.PhongHoc AS [Phòng Học]
                       FROM PHANCONG PC
                       INNER JOIN HOCPHAN HP ON PC.MaHP = HP.MaHP
                       WHERE PC.MaGV = @MaGV";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@MaGV", maGV);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

    }
}