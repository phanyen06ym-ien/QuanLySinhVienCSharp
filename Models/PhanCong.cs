using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVienCSharp.Models
{
    public class PhanCong
    {
        public string MaGV { get; set; }
        public string TenGV { get; set; } // thêm

        public string MaHP { get; set; }
        public string TenHP { get; set; } // thêm

        public string MaLop { get; set; }
        public string TenLop { get; set; } // thêm

        public int HocKy { get; set; }
        public string NamHoc { get; set; }

        public string PhongHoc { get; set; }
    }
}
