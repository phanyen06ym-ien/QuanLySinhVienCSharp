using QuanLySinhVienCSharp.Models;
using QuanLySinhVienCSharp.Service;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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

        public DataTable GetSV_ByLop(string maLop)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                string sql = "SELECT * FROM VIEW_SinhVien_FullInfo WHERE MaLop = @MaLop";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.Add("@MaLop", SqlDbType.VarChar).Value = maLop;

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable GetSV_ByHocPhan(string maHP)
        {

            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                string sql = @"
        SELECT DISTINCT sv.*
        FROM SINHVIEN sv
        JOIN DANGKY dk ON sv.MaSV = dk.MaSV
        WHERE dk.MaHP = @MaHP";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.Add("@MaHP", SqlDbType.VarChar).Value = maHP;

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetSV_ByKhoa(string maKhoa)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                string sql = @"
        SELECT sv.*
        FROM SINHVIEN sv
        JOIN LOPHOC l ON sv.MaLop = l.MaLop
        WHERE l.MaKhoa = @MaKhoa";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.Add("@MaKhoa", SqlDbType.VarChar).Value = maKhoa;

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // ================= LẤY THEO ID =================
        public DataTable GetById(string maSV)
        {
            if (string.IsNullOrWhiteSpace(maSV))
                throw new Exception("Mã sinh viên không hợp lệ");

            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                string sql = "SELECT * FROM VIEW_SinhVien_FullInfo WHERE MaSV = @MaSV";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.Add("@MaSV", SqlDbType.VarChar).Value = maSV.Trim();

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // ================= HỌC PHẦN ĐÃ ĐĂNG KÝ =================
        public DataTable GetHocPhanDaDangKy(string maSV)
        {
            if (string.IsNullOrWhiteSpace(maSV))
                throw new Exception("Mã sinh viên không hợp lệ");

            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("spXemDangKyTheoSV", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@MaSV", SqlDbType.VarChar).Value = maSV.Trim();

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // ================= BẢNG ĐIỂM =================
        public DataTable GetBangDiemTheoSV(string maSV)
        {
            if (string.IsNullOrWhiteSpace(maSV))
                throw new Exception("Mã sinh viên không hợp lệ");

            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("spXemBangDiem", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@MaSV", SqlDbType.VarChar).Value = maSV.Trim();

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // ================= BẢNG ĐIỂM FULL (ADMIN) =================
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
        public DataTable GetHocPhanDeDangKy(string maSV)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                string sql = @"
                    SELECT MaHP, TenHP 
                    FROM HOCPHAN
                    WHERE MaHP NOT IN (
                        SELECT MaHP FROM DANGKY WHERE MaSV = @MaSV
                    )";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.Add("@MaSV", SqlDbType.VarChar).Value = maSV.Trim();

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

                try
                {
                    using (SqlCommand cmd = new SqlCommand("spThemSinhVien", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@MaSV", SqlDbType.NVarChar).Value = sv.MaSV.Trim();
                        cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = sv.HoTen;
                        cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = sv.GioiTinh;
                        cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = sv.NgaySinh;
                        cmd.Parameters.Add("@MaLop", SqlDbType.VarChar).Value = sv.MaLop;
                        cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = sv.SDT ?? "";
                        cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = sv.DiaChi ?? "";
                        cmd.Parameters.Add("@NamThu", SqlDbType.Int).Value = sv.NamThu;
                        cmd.Parameters.Add("@KhoaHoc", SqlDbType.NVarChar).Value = sv.KhoaHoc ?? "";

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL ERROR: " + ex.Message);
                    return false;
                }
            }
        }

        // ================= CẬP NHẬT =================
        public bool Update(SinhVien sv)
        {
            if (sv == null || string.IsNullOrWhiteSpace(sv.MaSV))
                throw new Exception("Dữ liệu không hợp lệ");

            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                try
                {
                    using (SqlCommand cmd = new SqlCommand("spSuaSinhVien", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@MaSV", SqlDbType.VarChar).Value = sv.MaSV.Trim();
                        cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = sv.HoTen?.Trim();
                        cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = sv.GioiTinh?.Trim();
                        cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = (object)sv.NgaySinh ?? DBNull.Value;
                        cmd.Parameters.Add("@MaLop", SqlDbType.VarChar).Value = sv.MaLop?.Trim();
                        cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = sv.SDT?.Trim();
                        cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = sv.DiaChi?.Trim();
                        cmd.Parameters.Add("@NamThu", SqlDbType.Int).Value = (object)sv.NamThu ?? DBNull.Value;
                        cmd.Parameters.Add("@KhoaHoc", SqlDbType.NVarChar).Value = sv.KhoaHoc?.Trim();

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("Lỗi cập nhật: " + ex.Message);
                }
            }
        }

        // ================= XÓA =================
        public bool Delete(string maSV)
        {
            if (string.IsNullOrWhiteSpace(maSV))
                throw new Exception("Mã sinh viên không hợp lệ");

            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("spXoaSinhVien", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaSV", SqlDbType.VarChar).Value = maSV.Trim();

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public DataTable Search(string keyword)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                string sql = @"
            SELECT * FROM VIEW_SinhVien_FullInfo
            WHERE MaSV LIKE @kw 
               OR HoTen LIKE @kw 
               OR MaLop LIKE @kw";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.Add("@kw", SqlDbType.NVarChar).Value = "%" + keyword.Trim() + "%";

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public bool Exists(string maSV)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                string sql = "SELECT COUNT(*) FROM SINHVIEN WHERE MaSV = @MaSV";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@MaSV", SqlDbType.VarChar).Value = maSV.Trim();
                    conn.Open();

                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }
    }
}