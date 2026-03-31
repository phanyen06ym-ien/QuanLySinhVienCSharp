using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVienCSharp.Models
{
    public  class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; } 
        public string MaLop { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public int? NamThu { get; set; }
        public string KhoaHoc { get; set; }
    }
}
