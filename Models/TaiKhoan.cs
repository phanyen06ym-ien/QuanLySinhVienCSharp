using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVienCSharp.Models
{
    public class TaiKhoan
    {
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string VaiTro { get; set; }

        public string MaSV { get; set; }
        public string MaGV { get; set; }

        public string TenNguoiDung { get; set; } // thêm
    }
}
