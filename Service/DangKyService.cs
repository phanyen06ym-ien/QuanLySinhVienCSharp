using QuanLySinhVienCSharp.Models;
using QuanLySinhVienCSharp.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySinhVienCSharp.Services
{
    public class DangKyService
    {
        public bool DangKy(DangKy dk)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                try
                {
                    using (SqlCommand cmd = new SqlCommand("spDangKyHoc", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@MaSV", SqlDbType.VarChar).Value = dk.MaSV;
                        cmd.Parameters.Add("@MaHP", SqlDbType.VarChar).Value = dk.MaHP;
                        cmd.Parameters.Add("@HocKy", SqlDbType.Int).Value = dk.HocKy;
                        cmd.Parameters.Add("@NamHoc", SqlDbType.NVarChar).Value = dk.NamHoc;

                        cmd.ExecuteNonQuery(); // chỉ cần chạy OK là true
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("Lỗi đăng ký: " + ex.Message);
                }
            }
        }

        public List<DangKy> GetByMaSV(string maSV)
        {
            List<DangKy> list = new List<DangKy>();

            using (SqlConnection conn = new SqlConnection(DbHelper.connStr))
            {
                conn.Open();

                string sql = @"
            SELECT dk.MaSV, hp.TenHP, dk.MaHP, dk.HocKy, dk.NamHoc, hp.TinChi
            FROM DANGKY dk
            JOIN HOCPHAN hp ON dk.MaHP = hp.MaHP
            WHERE dk.MaSV = @MaSV";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@MaSV", SqlDbType.VarChar).Value = maSV;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new DangKy
                            {
                                MaSV = reader["MaSV"].ToString(),
                                MaHP = reader["MaHP"].ToString(),
                                TenHP = reader["TenHP"].ToString(),
                                HocKy = (int)reader["HocKy"],
                                NamHoc = reader["NamHoc"].ToString(),
                                TinChi = (int)reader["TinChi"]
                            });
                        }
                    }
                }
            }

            return list;
        }
    }
}