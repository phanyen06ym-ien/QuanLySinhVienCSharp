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
                string sql = @"SELECT D.MaSV, S.HoTen, D.MaHP, H.TenHP, D.HocKy, D.NamHoc,
                              D.DiemChuyenCan, D.DiemBaiTap, D.DiemGiuaKy, D.DiemCuoiKy
                       FROM DIEM D
                       JOIN SINHVIEN S ON D.MaSV = S.MaSV
                       JOIN HOCPHAN H ON D.MaHP = H.MaHP";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public bool SaveOrUpdate(string maSV, string maHP, string hocKy, string namHoc, double diemCC, double diemBT, double diemGK, double diemCK)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();
                string sql = @"IF EXISTS (SELECT 1 FROM DIEM WHERE MaSV=@MaSV AND MaHP=@MaHP)
            BEGIN
                UPDATE DIEM SET HocKy=@HK, NamHoc=@Nam, DiemChuyenCan=@CC, DiemBaiTap=@BT, DiemGiuaKy=@GK, DiemCuoiKy=@CK
                WHERE MaSV=@MaSV AND MaHP=@MaHP
            END
            ELSE
            BEGIN
                INSERT INTO DIEM (MaSV, MaHP, HocKy, NamHoc, DiemChuyenCan, DiemBaiTap, DiemGiuaKy, DiemCuoiKy)
                VALUES (@MaSV, @MaHP, @HK, @Nam, @CC, @BT, @GK, @CK)
            END";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSV", maSV);
                cmd.Parameters.AddWithValue("@MaHP", maHP);
                cmd.Parameters.AddWithValue("@HK", hocKy);
                cmd.Parameters.AddWithValue("@Nam", namHoc);
                cmd.Parameters.AddWithValue("@CC", diemCC);
                cmd.Parameters.AddWithValue("@BT", diemBT);
                cmd.Parameters.AddWithValue("@GK", diemGK);
                cmd.Parameters.AddWithValue("@CK", diemCK);
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