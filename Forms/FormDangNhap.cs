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

        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtTaiKhoan.Text.Trim();
            string pass = txtMatKhau.Text.Trim();

            // 1. Kiểm tra rỗng
            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Nhập đầy đủ thông tin!");
                return;
            }

            try
            {
                // 2. Gọi service (đúng kiểu User)
                var u = auth.Login(user, pass);

                // 3. Kiểm tra login thất bại
                if (u == null)
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                    return;
                }

                // 4. Lấy role
                string role = u.VaiTro.ToUpper();

                Form f = null;

                // 5. Phân quyền mở form
                if (role == "ADMIN")
                {
                    f = new FormAdmin();
                }
                else if (role == "SV")
                {
                    f = new FormSinhVien(u.MaSV); // ⚠️ FIX: truyền MaSV
                }
                else if (role == "GV")
                {
                    f = new FormGiangVien(u.MaGV); // ⚠️ FIX: truyền MaGV
                }
                else
                {
                    MessageBox.Show("Không xác định vai trò!");
                    return;
                }

                // 6. Mở form
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
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
    }
        }
