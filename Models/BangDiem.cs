using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVienCSharp.Models
{
    public class BangDiem
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }

        public string MaHP { get; set; }
        public string TenHP { get; set; }
        public int TinChi { get; set; }

        public int HocKy { get; set; }
        public string NamHoc { get; set; }

        public decimal? DiemChuyenCan { get; set; }
        public decimal? DiemBaiTap { get; set; }
        public decimal? DiemGiuaKy { get; set; }
        public decimal? DiemCuoiKy { get; set; }

        public decimal? DiemTongKet { get; set; }

        public string XepLoai { get; set; }
    }
}