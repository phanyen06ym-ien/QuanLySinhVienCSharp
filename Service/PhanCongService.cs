using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySinhVienCSharp.Service
{
    public class PhanCongService
    {
        // ================= XEM THEO GIẢNG VIÊN =================
        public DataTable GetByMaGV(string maGV)
        {
            if (string.IsNullOrWhiteSpace(maGV))
                throw new Exception("Mã giảng viên không hợp lệ");

            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                using (SqlCommand cmd = new SqlCommand("spXemPhanCongTheoGV", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaGV", maGV.Trim());

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    return dt;
                }
            }
        }

        // ================= PHÂN CÔNG =================
        public bool PhanCong(string maGV, string maHP, string maLop, int hocKy, string namHoc, string phongHoc)
        {
            if (string.IsNullOrWhiteSpace(maGV) ||
                string.IsNullOrWhiteSpace(maHP) ||
                string.IsNullOrWhiteSpace(maLop))
                throw new Exception("Dữ liệu không hợp lệ");

            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                try
                {
                    using (SqlCommand cmd = new SqlCommand("spPhanCong", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MaGV", maGV.Trim());
                        cmd.Parameters.AddWithValue("@MaHP", maHP.Trim());
                        cmd.Parameters.AddWithValue("@MaLop", maLop.Trim());
                        cmd.Parameters.AddWithValue("@HocKy", hocKy);
                        cmd.Parameters.AddWithValue("@NamHoc", namHoc?.Trim());
                        cmd.Parameters.AddWithValue("@PhongHoc",
                            string.IsNullOrEmpty(phongHoc) ? (object)DBNull.Value : phongHoc);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("Phân công thất bại: " + ex.Message);
                }
            }
        }

        // ================= CẬP NHẬT PHÒNG =================
        public bool CapPhong(string maGV, string maHP, string maLop, int hocKy, string namHoc, string phongHoc)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                try
                {
                    using (SqlCommand cmd = new SqlCommand("spCapPhong", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MaGV", maGV);
                        cmd.Parameters.AddWithValue("@MaHP", maHP);
                        cmd.Parameters.AddWithValue("@MaLop", maLop);
                        cmd.Parameters.AddWithValue("@HocKy", hocKy);
                        cmd.Parameters.AddWithValue("@NamHoc", namHoc);
                        cmd.Parameters.AddWithValue("@PhongHoc", phongHoc);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("Cập nhật phòng thất bại: " + ex.Message);
                }
            }
        }
    }
}