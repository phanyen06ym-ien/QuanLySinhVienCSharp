using QuanLySinhVienCSharp.Models;
using QuanLySinhVienCSharp.Service;
using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySinhVienCSharp.Services
{
    public class HocPhanService
    {
        // ================= LẤY DANH SÁCH =================
        public DataTable GetAll()
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                string sql = "SELECT * FROM HOCPHAN"; // OK

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // ================= THÊM =================
        public bool Add(HocPhan hp)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(@"
                    INSERT INTO HOCPHAN (MaHP, TenHP, TinChi, MaKhoa)
                    VALUES (@MaHP, @TenHP, @TinChi, @MaKhoa)", conn))
                {
                    cmd.Parameters.Add("@MaHP", SqlDbType.VarChar).Value = hp.MaHP;
                    cmd.Parameters.Add("@TenHP", SqlDbType.NVarChar).Value = hp.TenHP;
                    cmd.Parameters.Add("@TinChi", SqlDbType.Int).Value = hp.TinChi;
                    cmd.Parameters.Add("@MaKhoa", SqlDbType.VarChar).Value = hp.MaKhoa;

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // ================= CẬP NHẬT =================
        public bool Update(HocPhan hp)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(@"
                    UPDATE HOCPHAN
                    SET TenHP = @TenHP,
                        TinChi = @TinChi,
                        MaKhoa = @MaKhoa
                    WHERE MaHP = @MaHP", conn))
                {
                    cmd.Parameters.Add("@MaHP", SqlDbType.VarChar).Value = hp.MaHP;
                    cmd.Parameters.Add("@TenHP", SqlDbType.NVarChar).Value = hp.TenHP;
                    cmd.Parameters.Add("@TinChi", SqlDbType.Int).Value = hp.TinChi;
                    cmd.Parameters.Add("@MaKhoa", SqlDbType.VarChar).Value = hp.MaKhoa;

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // ================= XÓA =================
        public bool Delete(string maHP)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    // ❗ nếu DB đã có CASCADE thì KHÔNG cần 2 dòng dưới
                    using (SqlCommand cmdDiem = new SqlCommand(
                        "DELETE FROM DIEM WHERE MaHP = @MaHP", conn, trans))
                    {
                        cmdDiem.Parameters.Add("@MaHP", SqlDbType.VarChar).Value = maHP;
                        cmdDiem.ExecuteNonQuery();
                    }

                    using (SqlCommand cmdDangKy = new SqlCommand(
                        "DELETE FROM DANGKY WHERE MaHP = @MaHP", conn, trans))
                    {
                        cmdDangKy.Parameters.Add("@MaHP", SqlDbType.VarChar).Value = maHP;
                        cmdDangKy.ExecuteNonQuery();
                    }

                    using (SqlCommand cmdHP = new SqlCommand(
                        "DELETE FROM HOCPHAN WHERE MaHP = @MaHP", conn, trans))
                    {
                        cmdHP.Parameters.Add("@MaHP", SqlDbType.VarChar).Value = maHP;

                        int result = cmdHP.ExecuteNonQuery();
                        trans.Commit();

                        return result > 0;
                    }
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