using QuanLySinhVienCSharp.Models;
using QuanLySinhVienCSharp.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySinhVienCSharp.Services
{
    public class DiemService
    {
        public DataTable GetAll()
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                string sql = @"SELECT * FROM VIEW_BangDiem_Full";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public bool NhapDiem(string maSV, string maHP, int hocKy, string namHoc,
                    double diemCC, double diemBT, double diemGK, double diemCK)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("sp_NhapDiem", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaSV", maSV);
                cmd.Parameters.AddWithValue("@MaHP", maHP);
                cmd.Parameters.AddWithValue("@HocKy", hocKy);
                cmd.Parameters.AddWithValue("@NamHoc", namHoc);
                cmd.Parameters.AddWithValue("@DiemCC", diemCC);
                cmd.Parameters.AddWithValue("@DiemBT", diemBT);
                cmd.Parameters.AddWithValue("@DiemGK", diemGK);
                cmd.Parameters.AddWithValue("@DiemCK", diemCK);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public bool SuaDiem(string maSV, string maHP, int hocKy, string namHoc,
                   double diemCC, double diemBT, double diemGK, double diemCK)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("sp_SuaDiem", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaSV", maSV);
                cmd.Parameters.AddWithValue("@MaHP", maHP);
                cmd.Parameters.AddWithValue("@HocKy", hocKy);
                cmd.Parameters.AddWithValue("@NamHoc", namHoc);
                cmd.Parameters.AddWithValue("@DiemCC", diemCC);
                cmd.Parameters.AddWithValue("@DiemBT", diemBT);
                cmd.Parameters.AddWithValue("@DiemGK", diemGK);
                cmd.Parameters.AddWithValue("@DiemCK", diemCK);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(string maSV, string maHP)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                string sql = "DELETE FROM DIEM WHERE MaSV=@MaSV AND MaHP=@MaHP";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@MaSV", maSV);
                cmd.Parameters.AddWithValue("@MaHP", maHP);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}