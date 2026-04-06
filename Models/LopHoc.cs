using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVienCSharp.Models
{
    public class LopHoc
    {
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public string ChuyenNganh { get; set; }

        public string CoVanHocTap { get; set; }
        public string TenCoVan { get; set; } // thêm

        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; } // thêm
    }
}
