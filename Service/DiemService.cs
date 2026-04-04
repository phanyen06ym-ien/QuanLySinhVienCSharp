using QuanLySinhVienCSharp.Service;
using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySinhVienCSharp.Services
{
    public class DiemService
    {
        // ================= LẤY TẤT CẢ =================
        public DataTable GetAll()
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                string sql = "SELECT * FROM VIEW_BangDiem_Full";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
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
                    using (SqlCommand cmd = new SqlCommand("spNhapDiem", conn)) // FIX
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@MaSV", SqlDbType.VarChar).Value = maSV;
                        cmd.Parameters.Add("@MaHP", SqlDbType.VarChar).Value = maHP;
                        cmd.Parameters.Add("@HocKy", SqlDbType.Int).Value = hocKy;
                        cmd.Parameters.Add("@NamHoc", SqlDbType.NVarChar).Value = namHoc;
                        cmd.Parameters.Add("@DiemCC", SqlDbType.Decimal).Value = diemCC;
                        cmd.Parameters.Add("@DiemBT", SqlDbType.Decimal).Value = diemBT;
                        cmd.Parameters.Add("@DiemGK", SqlDbType.Decimal).Value = diemGK;
                        cmd.Parameters.Add("@DiemCK", SqlDbType.Decimal).Value = diemCK;

                        cmd.ExecuteNonQuery(); // FIX
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
                    using (SqlCommand cmd = new SqlCommand("spSuaDiem", conn)) // FIX
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@MaSV", SqlDbType.VarChar).Value = maSV;
                        cmd.Parameters.Add("@MaHP", SqlDbType.VarChar).Value = maHP;
                        cmd.Parameters.Add("@HocKy", SqlDbType.Int).Value = hocKy;
                        cmd.Parameters.Add("@NamHoc", SqlDbType.NVarChar).Value = namHoc;
                        cmd.Parameters.Add("@DiemCC", SqlDbType.Decimal).Value = diemCC;
                        cmd.Parameters.Add("@DiemBT", SqlDbType.Decimal).Value = diemBT;
                        cmd.Parameters.Add("@DiemGK", SqlDbType.Decimal).Value = diemGK;
                        cmd.Parameters.Add("@DiemCK", SqlDbType.Decimal).Value = diemCK;

                        cmd.ExecuteNonQuery(); // FIX
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("Lỗi sửa điểm: " + ex.Message);
                }
            }
        }

        // ================= XÓA =================
        public bool Delete(string maSV, string maHP)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                try
                {
                    string sql = "DELETE FROM DIEM WHERE MaSV=@MaSV AND MaHP=@MaHP";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add("@MaSV", SqlDbType.VarChar).Value = maSV;
                        cmd.Parameters.Add("@MaHP", SqlDbType.VarChar).Value = maHP;

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi xóa điểm: " + ex.Message);
                }
            }
        }
        public DataTable GetByGiangVien(string maGV)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                string sql = @"
            SELECT *
            FROM VIEW_BangDiem_Full
            WHERE MaGV = @MaGV";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.Add("@MaGV", SqlDbType.VarChar).Value = maGV;

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}