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

            if (user == "" || pass == "")
            {
                MessageBox.Show("Nhập đầy đủ thông tin!");
                return;
            }

            string role = auth.Login(user, pass);

            if (role == null)
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                return;
            }

            role = role.ToUpper();

            Form f = null;

            if (role == "ADMIN")
            {
                f = new FormAdmin();
            }
            else if (role == "SV")
            {
                f = new FormSinhVien(user);
            }
            else if (role == "GV")
            {
                f = new FormGiangVien(user);
            }

            if (f != null)
            {
                this.Hide();        
                f.ShowDialog();     
                this.Show();        
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
        }
