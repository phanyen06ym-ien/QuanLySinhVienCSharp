using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVienCSharp.Models
{
    public class DangKy
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }   // thêm
        public string MaHP { get; set; }
        public string TenHP { get; set; }   // thêm

        public int HocKy { get; set; }
        public string NamHoc { get; set; }

        public int TinChi { get; set; } // thêm
    }
}
