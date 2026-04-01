using QuanLySinhVienCSharp.Models;
using QuanLySinhVienCSharp.Service;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySinhVienCSharp.Services
{
    public class DangKyService
    {
        public bool DangKy(DangKy dk)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("dbo.spDangKyHoc", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaSV", dk.MaSV);
                cmd.Parameters.AddWithValue("@MaHP", dk.MaHP);
                cmd.Parameters.AddWithValue("@HocKy", dk.HocKy);
                cmd.Parameters.AddWithValue("@NamHoc", dk.NamHoc);

                return cmd.ExecuteNonQuery() > 0;
            }
        }



        public DataTable GetByMaSV(string maSV)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                string sql = @"SELECT dk.MaHP, hp.TenHP, dk.HocKy, dk.NamHoc
                       FROM DANGKY dk
                       JOIN HOCPHAN hp ON dk.MaHP = hp.MaHP
                       WHERE dk.MaSV = @MaSV";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@MaSV", maSV);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}