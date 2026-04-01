using QuanLySinhVienCSharp.Models;
using QuanLySinhVienCSharp.Service;
using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySinhVienCSharp.Services
{
    public class HocPhanService
    {
        public DataTable GetAll()
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HocPhan", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool Add(HocPhan hp)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();
                string sql = "INSERT INTO HocPhan (MaHP, TenHP, TinChi, MaKhoa) VALUES (@ma, @ten, @stc, @makhoa)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", hp.MaHP);
                cmd.Parameters.AddWithValue("@ten", hp.TenHP);
                cmd.Parameters.AddWithValue("@stc", hp.TinChi);
                cmd.Parameters.AddWithValue("@makhoa", hp.MaKhoa);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public bool Update(HocPhan hp)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();
                string sql = "UPDATE HocPhan SET TenHP=@ten, TinChi=@stc, MaKhoa=@makhoa WHERE MaHP=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ma", hp.MaHP);
                cmd.Parameters.AddWithValue("@ten", hp.TenHP);
                cmd.Parameters.AddWithValue("@stc", hp.TinChi);
                cmd.Parameters.AddWithValue("@makhoa", hp.MaKhoa);
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(string maHP)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    SqlCommand cmdDiem = new SqlCommand(
                        "DELETE FROM DIEM WHERE MaHP = @ma", conn, trans);
                    cmdDiem.Parameters.AddWithValue("@ma", maHP);
                    cmdDiem.ExecuteNonQuery();

                    SqlCommand cmdDangKy = new SqlCommand(
                        "DELETE FROM DANGKY WHERE MaHP = @ma", conn, trans);
                    cmdDangKy.Parameters.AddWithValue("@ma", maHP);
                    cmdDangKy.ExecuteNonQuery();

                    SqlCommand cmdHP = new SqlCommand(
                        "DELETE FROM HOCPHAN WHERE MaHP = @ma", conn, trans);
                    cmdHP.Parameters.AddWithValue("@ma", maHP);

                    int result = cmdHP.ExecuteNonQuery();

                    trans.Commit();
                    return result > 0;
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw new Exception("Lỗi xóa học phần: " + ex.Message);
                }
            }
        }
    }
}