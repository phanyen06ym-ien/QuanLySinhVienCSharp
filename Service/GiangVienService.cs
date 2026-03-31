using QuanLySinhVienCSharp.Models;
using QuanLySinhVienCSharp.Service;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySinhVienCSharp.Services
{
    public class GiangVienService
    {
        public DataTable GetAll()
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM GiangVien", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public bool Add(GiangVien gv)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                string sql = @"INSERT INTO GiangVien
            (MaGV, HoTen, GioiTinh, DiaChi, Email, MaKhoa)
            VALUES (@MaGV,@HoTen,@GT,@DC,@Email,@MaKhoa)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@MaGV", gv.MaGV);
                cmd.Parameters.AddWithValue("@HoTen", gv.HoTen);
                cmd.Parameters.AddWithValue("@GT", gv.GioiTinh);
                cmd.Parameters.AddWithValue("@DC", gv.DiaChi);
                cmd.Parameters.AddWithValue("@Email", gv.Email);
                cmd.Parameters.AddWithValue("@MaKhoa", gv.MaKhoa);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Update(GiangVien gv)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                string sql = @"UPDATE GiangVien SET
            HoTen=@HoTen, GioiTinh=@GT, DiaChi=@DC,
            Email=@Email, MaKhoa=@MaKhoa
            WHERE MaGV=@MaGV";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@MaGV", gv.MaGV);
                cmd.Parameters.AddWithValue("@HoTen", gv.HoTen);
                cmd.Parameters.AddWithValue("@GT", gv.GioiTinh);
                cmd.Parameters.AddWithValue("@DC", gv.DiaChi);
                cmd.Parameters.AddWithValue("@Email", gv.Email);
                cmd.Parameters.AddWithValue("@MaKhoa", gv.MaKhoa);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(string maGV)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM GiangVien WHERE MaGV=@MaGV", conn);

                cmd.Parameters.AddWithValue("@MaGV", maGV);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public DataTable GetById(string maGV)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT * FROM GiangVien WHERE MaGV=@MaGV", conn);

                da.SelectCommand.Parameters.AddWithValue("@MaGV", maGV);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable GetLopPhuTrach(string maGV)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                string sql = @"SELECT 
                            PC.MaLop, 
                            HP.TenHP AS [Học Phần], 
                            HP.TinChi AS [Tín Chỉ], 
                            PC.PhongHoc AS [Phòng Học]
                       FROM PHANCONG PC
                       INNER JOIN HOCPHAN HP ON PC.MaHP = HP.MaHP
                       WHERE PC.MaGV = @MaGV";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@MaGV", maGV);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

    }
}