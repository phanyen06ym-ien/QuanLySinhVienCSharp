using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVienCSharp.Service
{
    public class DbHelper
    {
        // Cập nhật Data Source để khớp với server trong ảnh của bạn
        public static string connStr =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLySinhVien;Integrated Security=True;TrustServerCertificate=True";
    }
}