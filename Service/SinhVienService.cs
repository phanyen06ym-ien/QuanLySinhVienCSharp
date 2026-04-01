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
                    "SELECT * FROM VIEW_SinhVien_FullInfo",
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
            try
            {
                using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("sp_ThemSinhVien", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MaSV", sv.MaSV.Trim());
                    cmd.Parameters.AddWithValue("@HoTen", sv.HoTen);
                    cmd.Parameters.AddWithValue("@GioiTinh", sv.GioiTinh);
                    cmd.Parameters.AddWithValue("@NgaySinh", sv.NgaySinh);
                    cmd.Parameters.AddWithValue("@MaLop", sv.MaLop);
                    cmd.Parameters.AddWithValue("@SDT", sv.SDT);
                    cmd.Parameters.AddWithValue("@DiaChi", sv.DiaChi);
                    cmd.Parameters.AddWithValue("@NamThu", (object)sv.NamThu ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@KhoaHoc", sv.KhoaHoc);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Lỗi Database: " + ex.Message, "Thông báo lỗi");
                return false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Lỗi hệ thống: " + ex.Message);
                return false;
            }
        }

        public bool Update(SinhVien sv)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("sp_SuaSinhVien", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaSV", sv.MaSV);
                    cmd.Parameters.AddWithValue("@HoTen", sv.HoTen);
                    cmd.Parameters.AddWithValue("@GioiTinh", sv.GioiTinh);
                    cmd.Parameters.AddWithValue("@NgaySinh", sv.NgaySinh);
                    cmd.Parameters.AddWithValue("@MaLop", sv.MaLop);
                    cmd.Parameters.AddWithValue("@SDT", sv.SDT);
                    cmd.Parameters.AddWithValue("@DiaChi", sv.DiaChi);

                    cmd.Parameters.AddWithValue("@NamThu", (object)sv.NamThu ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@KhoaHoc", sv.KhoaHoc);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Lỗi cập nhật Database: " + ex.Message, "Thông báo");
                return false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Lỗi hệ thống: " + ex.Message);
                return false;
            }
        }

        public bool Delete(string maSV)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("sp_XoaSinhVien", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaSV", maSV);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}