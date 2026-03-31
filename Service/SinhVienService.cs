using QuanLySinhVienCSharp.Models;
using QuanLySinhVienCSharp.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySinhVienCSharp.Services
{
    public class SinhVienService
    {
        public DataTable GetAll()
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT MaSV, HoTen, GioiTinh, MaLop, SDT, DiaChi, NamThu, KhoaHoc, NgaySinh FROM SinhVien",
                    conn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable GetById(string maSV)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                string sql = "SELECT * FROM VIEW_SinhVien_FullInfo WHERE MaSV = @ma";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@ma", maSV);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable GetHocPhanDaDangKy(string maSV)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                string sql = @"SELECT HP.MaHP, HP.TenHP, HP.TinChi, DK.HocKy, DK.NamHoc 
                       FROM DANGKY DK
                       INNER JOIN HOCPHAN HP ON DK.MaHP = HP.MaHP 
                       WHERE DK.MaSV = @ma";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@ma", maSV.Trim());

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable GetBangDiemTheoSV(string maSV)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                string sql = "SELECT MaHP, TenHP, TinChi, HocKy, NamHoc, DiemTongKet, XepLoai FROM VIEW_BangDiem_Full WHERE MaSV = @ma";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@ma", maSV);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable GetBangDiemChiTiet()
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                string sql = "SELECT * FROM VIEW_BangDiem_Full";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();

                try
                {
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi khi lấy dữ liệu từ View: " + ex.Message);
                }
            }
        }
        public DataTable GetHocPhanDeDangKy()
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                string sql = "SELECT MaHP, TenHP FROM HocPhan";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool Add(SinhVien sv)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                string sql = @"INSERT INTO SinhVien
            (MaSV, HoTen, GioiTinh, MaLop, SDT, DiaChi, NamThu, KhoaHoc, NgaySinh)
            VALUES (@MaSV,@HoTen,@GioiTinh,@MaLop,@SDT,@DiaChi,@NamThu,@KhoaHoc,@NgaySinh)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.Add("@MaSV", SqlDbType.VarChar).Value = sv.MaSV;
                cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = sv.HoTen;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = sv.GioiTinh;
                cmd.Parameters.Add("@MaLop", SqlDbType.VarChar).Value = sv.MaLop;
                cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = sv.SDT;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = sv.DiaChi;
                cmd.Parameters.Add("@NamThu", SqlDbType.Int).Value = (object)sv.NamThu ?? DBNull.Value;
                cmd.Parameters.Add("@KhoaHoc", SqlDbType.VarChar).Value = sv.KhoaHoc;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = sv.NgaySinh;

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Update(SinhVien sv)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                string sql = @"UPDATE SinhVien SET
            HoTen=@HoTen, GioiTinh=@GioiTinh, MaLop=@MaLop,
            SDT=@SDT, DiaChi=@DiaChi, NamThu=@NamThu,
            KhoaHoc=@KhoaHoc, NgaySinh=@NgaySinh
            WHERE MaSV=@MaSV";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@MaSV", sv.MaSV);
                cmd.Parameters.AddWithValue("@HoTen", sv.HoTen);
                cmd.Parameters.AddWithValue("@GioiTinh", sv.GioiTinh);
                cmd.Parameters.AddWithValue("@MaLop", sv.MaLop);
                cmd.Parameters.AddWithValue("@SDT", sv.SDT);
                cmd.Parameters.AddWithValue("@DiaChi", sv.DiaChi);
                cmd.Parameters.AddWithValue("@NamThu", (object)sv.NamThu ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@KhoaHoc", sv.KhoaHoc);
                cmd.Parameters.AddWithValue("@NgaySinh", sv.NgaySinh);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(string maSV)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();
                string sqlTK = "DELETE FROM TAIKHOAN WHERE MaSV = @ma";
                SqlCommand cmdTK = new SqlCommand(sqlTK, conn);
                cmdTK.Parameters.AddWithValue("@ma", maSV);
                cmdTK.ExecuteNonQuery();

                string sqlSV = "DELETE FROM SinhVien WHERE MaSV = @ma";
                SqlCommand cmdSV = new SqlCommand(sqlSV, conn);
                cmdSV.Parameters.AddWithValue("@ma", maSV);

                return cmdSV.ExecuteNonQuery() > 0;
            }
        }
    }
}