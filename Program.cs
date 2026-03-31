using System;
using System.Windows.Forms;
using QuanLySinhVienCSharp.Forms;

namespace QuanLySinhVienCSharp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 👇 CHẠY FORM ĐĂNG NHẬP
            Application.Run(new FormDangNhap());
        }
    }
}