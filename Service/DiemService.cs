using QuanLySinhVienCSharp.Service;
using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySinhVienCSharp.Services
{
    public class DiemService
    {
        // ================= XEM TẤT CẢ / THEO SV =================
        public DataTable GetBangDiem(string maSV = null)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                using (SqlCommand cmd = new SqlCommand("spXemBangDiem", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (string.IsNullOrEmpty(maSV))
                        cmd.Parameters.AddWithValue("@MaSV", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@MaSV", maSV);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    return dt;
                }
            }
        }

        // ================= NHẬP ĐIỂM =================
        public bool NhapDiem(string maSV, string maHP, int hocKy, string namHoc,
            decimal diemCC, decimal diemBT, decimal diemGK, decimal diemCK)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                try
                {
                    using (SqlCommand cmd = new SqlCommand("spNhapDiem", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MaSV", maSV);
                        cmd.Parameters.AddWithValue("@MaHP", maHP);
                        cmd.Parameters.AddWithValue("@HocKy", hocKy);
                        cmd.Parameters.AddWithValue("@NamHoc", namHoc);

                        cmd.Parameters.Add("@DiemCC", SqlDbType.Decimal).Value = diemCC;
                        cmd.Parameters.Add("@DiemBT", SqlDbType.Decimal).Value = diemBT;
                        cmd.Parameters.Add("@DiemGK", SqlDbType.Decimal).Value = diemGK;
                        cmd.Parameters.Add("@DiemCK", SqlDbType.Decimal).Value = diemCK;

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("Lỗi nhập điểm: " + ex.Message);
                }
            }
        }

        // ================= SỬA ĐIỂM =================
        public bool SuaDiem(string maSV, string maHP, int hocKy, string namHoc,
            decimal diemCC, decimal diemBT, decimal diemGK, decimal diemCK)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                try
                {
                    using (SqlCommand cmd = new SqlCommand("spSuaDiem", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MaSV", maSV);
                        cmd.Parameters.AddWithValue("@MaHP", maHP);
                        cmd.Parameters.AddWithValue("@HocKy", hocKy);
                        cmd.Parameters.AddWithValue("@NamHoc", namHoc);

                        cmd.Parameters.Add("@DiemCC", SqlDbType.Decimal).Value = diemCC;
                        cmd.Parameters.Add("@DiemBT", SqlDbType.Decimal).Value = diemBT;
                        cmd.Parameters.Add("@DiemGK", SqlDbType.Decimal).Value = diemGK;
                        cmd.Parameters.Add("@DiemCK", SqlDbType.Decimal).Value = diemCK;

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("Lỗi sửa điểm: " + ex.Message);
                }
            }
        }

        // ================= XÓA ĐIỂM =================
        public bool XoaDiem(string maSV, string maHP, int hocKy, string namHoc)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                try
                {
                    using (SqlCommand cmd = new SqlCommand("spHuyDangKy", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MaSV", maSV);
                        cmd.Parameters.AddWithValue("@MaHP", maHP);
                        cmd.Parameters.AddWithValue("@HocKy", hocKy);
                        cmd.Parameters.AddWithValue("@NamHoc", namHoc);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("Lỗi xóa điểm: " + ex.Message);
                }
            }
        }

        // ================= LẤY THEO GIẢNG VIÊN =================
        public DataTable GetByGiangVien(string maGV)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                string sql = @"
                    SELECT *
                    FROM VIEW_BangDiem_Full
                    WHERE MaGV = @MaGV";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@MaGV", maGV);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}