using QuanLySinhVienCSharp.Services;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using QuanLySinhVien;

namespace QuanLySinhVienCSharp.Forms
{
    public partial class FormDangNhap : Form
    {
        AuthService auth = new AuthService();

        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnDangNhap;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string user = txtTaiKhoan.Text.Trim();
            string pass = txtMatKhau.Text.Trim();

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Nhập đầy đủ thông tin!");
                return;
            }

            try
            {
                // 1. Chỉ cần gọi Login một lần duy nhất
                var u = auth.Login(user, pass);

                if (u == null)
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu hoặc tài khoản bị khóa!");
                    txtMatKhau.Clear();
                    txtMatKhau.Focus();
                    return;
                }

                // 2. Điều hướng dựa trên u (đã có đủ thông tin VaiTro, MaSV, MaGV)
                string role = u.VaiTro?.Trim().ToUpper() ?? "";
                Form f = null;

                if (role == "ADMIN")
                    f = new FormAdmin();
                else if (role == "SV")
                    f = new FormSinhVien(u.MaSV);
                else if (role == "GV")
                    f = new FormGiangVien(u.MaGV);

                if (f == null)
                {
                    MessageBox.Show("Không xác định được vai trò người dùng!");
                    return;
                }

                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
        }

    }
}