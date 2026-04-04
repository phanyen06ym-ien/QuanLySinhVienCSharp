using QuanLySinhVienCSharp.Models;
using QuanLySinhVienCSharp.Service;
using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySinhVienCSharp.Services
{
    public class SinhVienService
    {
        // ================= LẤY DANH SÁCH =================
        public DataTable GetAll()
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT * FROM VIEW_SinhVien_FullInfo", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // ================= LẤY THEO ID =================
        public DataTable GetById(string maSV)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                string sql = "SELECT * FROM VIEW_SinhVien_FullInfo WHERE MaSV = @MaSV";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.Add("@MaSV", SqlDbType.VarChar).Value = maSV;

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // ================= HỌC PHẦN ĐÃ ĐĂNG KÝ =================
        public DataTable GetHocPhanDaDangKy(string maSV)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                // ✅ dùng Stored Procedure thay vì query tay
                SqlDataAdapter da = new SqlDataAdapter("spXemDangKyTheoSV", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@MaSV", SqlDbType.VarChar).Value = maSV;

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // ================= BẢNG ĐIỂM =================
        public DataTable GetBangDiemTheoSV(string maSV)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("spXemBangDiem", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@MaSV", SqlDbType.VarChar).Value = maSV;

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetBangDiemChiTiet()
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("spXemBangDiem", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // ================= DANH SÁCH HỌC PHẦN =================
        public DataTable GetHocPhanDeDangKy()
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                string sql = "SELECT MaHP, TenHP FROM HOCPHAN";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // ================= THÊM =================
        public bool Add(SinhVien sv)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("spThemSinhVien", conn)) // ✅ FIX
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@MaSV", SqlDbType.VarChar).Value = sv.MaSV.Trim();
                    cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = sv.HoTen;
                    cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = sv.GioiTinh;
                    cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = (object)sv.NgaySinh ?? DBNull.Value;
                    cmd.Parameters.Add("@MaLop", SqlDbType.VarChar).Value = sv.MaLop;
                    cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = sv.SDT;
                    cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = sv.DiaChi;
                    cmd.Parameters.Add("@NamThu", SqlDbType.Int).Value = (object)sv.NamThu ?? DBNull.Value;
                    cmd.Parameters.Add("@KhoaHoc", SqlDbType.NVarChar).Value = sv.KhoaHoc;

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // ================= CẬP NHẬT =================
        public bool Update(SinhVien sv)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("spSuaSinhVien", conn)) // ✅ FIX
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@MaSV", SqlDbType.VarChar).Value = sv.MaSV;
                    cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = sv.HoTen;
                    cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = sv.GioiTinh;
                    cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = (object)sv.NgaySinh ?? DBNull.Value;
                    cmd.Parameters.Add("@MaLop", SqlDbType.VarChar).Value = sv.MaLop;
                    cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = sv.SDT;
                    cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = sv.DiaChi;
                    cmd.Parameters.Add("@NamThu", SqlDbType.Int).Value = (object)sv.NamThu ?? DBNull.Value;
                    cmd.Parameters.Add("@KhoaHoc", SqlDbType.NVarChar).Value = sv.KhoaHoc;

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // ================= XÓA =================
        public bool Delete(string maSV)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("spXoaSinhVien", conn)) 
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaSV", SqlDbType.VarChar).Value = maSV;

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}