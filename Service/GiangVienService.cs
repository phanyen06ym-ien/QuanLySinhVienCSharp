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
                // ✅ dùng VIEW thay vì table
                string sql = "SELECT * FROM VIEW_GiangVien_FullInfo";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // ================= LẤY THEO ID =================
        public DataTable GetById(string maGV)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                string sql = "SELECT * FROM VIEW_GiangVien_FullInfo WHERE MaGV = @ma";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.Add("@ma", SqlDbType.VarChar).Value = maGV;

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

                using (SqlCommand cmd = new SqlCommand("spThemGiangVien", conn)) // ✅ FIX tên SP
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@MaGV", SqlDbType.VarChar).Value = gv.MaGV;
                    cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = gv.HoTen;
                    cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = gv.GioiTinh;
                    cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = gv.DiaChi;
                    cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = gv.Email;
                    cmd.Parameters.Add("@MaKhoa", SqlDbType.VarChar).Value = gv.MaKhoa;

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // ================= CẬP NHẬT =================
        public bool Update(GiangVien gv)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("spSuaGiangVien", conn)) // ✅ FIX tên SP
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@MaGV", SqlDbType.VarChar).Value = gv.MaGV;
                    cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = gv.HoTen;
                    cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = gv.GioiTinh;
                    cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = gv.DiaChi;
                    cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = gv.Email;
                    cmd.Parameters.Add("@MaKhoa", SqlDbType.VarChar).Value = gv.MaKhoa;

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // ================= XÓA =================
        public bool Delete(string maGV)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("spXoaGiangVien", conn)) // ✅ FIX tên SP
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@MaGV", SqlDbType.VarChar).Value = maGV;

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // ================= LỚP PHỤ TRÁCH =================
        public DataTable GetLopPhuTrach(string maGV)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                string sql = @"
                    SELECT 
                        PC.MaLop, 
                        HP.TenHP,
                        HP.TinChi,
                        PC.PhongHoc
                    FROM PHANCONG PC
                    INNER JOIN HOCPHAN HP ON PC.MaHP = HP.MaHP
                    WHERE PC.MaGV = @MaGV";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.Add("@MaGV", SqlDbType.VarChar).Value = maGV;

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}