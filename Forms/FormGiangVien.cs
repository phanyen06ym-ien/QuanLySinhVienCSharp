using QuanLySinhVienCSharp.Services;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLySinhVienCSharp.Forms
{
    public partial class FormGiangVien : Form
    {
        private GiangVienService gvService = new GiangVienService();
        private DiemService diemService = new DiemService();

        private string maGV;

        
        public FormGiangVien(string maGV)
        {
            InitializeComponent();
            this.maGV = maGV;
        }

        private void FormGiangVien_Load(object sender, EventArgs e)
        {
            LoadThongTin();
            LoadDiem();
            LoadPhanCong();
        }

        private void LoadThongTin()
        {
            DataTable dt = gvService.GetById(maGV);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy giảng viên!");
                return;
            }

            var r = dt.Rows[0];

            lblMGV.Text = r["MaGV"]?.ToString() ?? "";
            lblNameGV.Text = r["HoTen"]?.ToString() ?? "";
            lblGioiTinh.Text = r["GioiTinh"]?.ToString() ?? "";
            lblEmail.Text = r["Email"]?.ToString() ?? "";
            lblDiaChi.Text = r["DiaChi"]?.ToString() ?? "";
            lblMaKhoa.Text = r["MaKhoa"]?.ToString() ?? "";
        }
        private void LoadPhanCong()
        {
            dgvLop.DataSource = gvService.GetPhanCong(maGV);
        }
        private void LoadDiem()
        {
            string hocKy = cboHocKy.Text;
            string namHoc = txtNamHoc.Text.Trim();
            string maHP = txtMaHP.Text;

            DataTable dt = diemService.GetByGiangVien(maGV);

            string filter = "";

            if (!string.IsNullOrEmpty(hocKy))
                filter += $"HocKy = {hocKy}";

            if (!string.IsNullOrEmpty(namHoc))
            {
                if (filter != "") filter += " AND ";
                filter += $"NamHoc = '{namHoc}'";
            }

            if (!string.IsNullOrEmpty(maHP))
            {
                if (filter != "") filter += " AND ";
                filter += $"MaHP = '{maHP}'";
            }

            if (!string.IsNullOrEmpty(filter))
                dt.DefaultView.RowFilter = filter;

            dgvDiem.DataSource = dt.DefaultView;
        }
        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadDiem();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvLop.Rows[e.RowIndex];

            txtMaHP.Text = row.Cells["MaHP"].Value?.ToString();
            cboHocKy.Text = row.Cells["HocKy"].Value?.ToString();
            txtNamHoc.Text = row.Cells["NamHoc"].Value?.ToString();

            LoadDiem();
        }

        private void btnXemDSLop_Click(object sender, EventArgs e)
        {
            LoadPhanCong();

            if (dgvLop.Rows.Count == 0)
            {
                MessageBox.Show("Không có lớp phụ trách!");
            }
        }

        private void tabNhap_Sua_Diem_Click(object sender, EventArgs e)
        {

        }

        private void btnLuuDiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaSV.Text) ||
                    string.IsNullOrWhiteSpace(txtMaHP.Text))
                {
                    MessageBox.Show("Thiếu mã SV hoặc mã HP!");
                    return;
                }

                int hocKy = int.Parse(cboHocKy.Text);
                string namHoc = txtNamHoc.Text;

                decimal cc = decimal.Parse(txtCC.Text);
                decimal bt = decimal.Parse(txtBT.Text);
                decimal gk = decimal.Parse(txtGK.Text);
                decimal ck = decimal.Parse(txtCK.Text);

                if (cc < 0 || cc > 10 || bt < 0 || bt > 10 ||
                    gk < 0 || gk > 10 || ck < 0 || ck > 10)
                {
                    MessageBox.Show("Điểm phải từ 0 đến 10!");
                    return;
                }

                bool kq;

                if (dgvDiem.CurrentRow != null)
                {
                    kq = diemService.SuaDiem(
                        txtMaSV.Text,
                        txtMaHP.Text,
                        hocKy,
                        namHoc,
                        cc, bt, gk, ck
                    );
                }
                else
                {
                    kq = diemService.NhapDiem(
                        txtMaSV.Text,
                        txtMaHP.Text,
                        hocKy,
                        namHoc,
                        cc, bt, gk, ck
                    );
                }

                if (kq)
                {
                    MessageBox.Show("Lưu điểm thành công!");
                    LoadDiem();
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu không hợp lệ!");
            }
        }
        

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDiem.CurrentRow != null)
            {
                string maSV = dgvDiem.CurrentRow.Cells["MaSV"].Value.ToString();
                string maHP = dgvDiem.CurrentRow.Cells["MaHP"].Value.ToString();

                var confirm = MessageBox.Show("Bạn có chắc muốn xóa điểm của sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    int hocKy = int.Parse(dgvDiem.CurrentRow.Cells["HocKy"].Value.ToString());
                    string namHoc = dgvDiem.CurrentRow.Cells["NamHoc"].Value.ToString();

                    if (diemService.XoaDiem(maSV, maHP, hocKy, namHoc))
                    {
                        MessageBox.Show("Xóa thành công!");
                        LoadDiem();
                    }
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabDangXuatGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabDangXuatGV.SelectedTab == tabPage1)
            {
                DialogResult rs = MessageBox.Show(
                    "Bạn có chắc muốn đăng xuất?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo
                );

                if (rs == DialogResult.Yes)
                {
                    this.Close();
                }
                else
                {
                    tabDangXuatGV.SelectedIndex = 0;
                }
            }
        }

        private void grbHSGV_Enter(object sender, EventArgs e)
        {

        }

        private void dgvDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvDiem.Rows[e.RowIndex];

            txtMaSV.Text = row.Cells["MaSV"].Value?.ToString();
            txtMaHP.Text = row.Cells["MaHP"].Value?.ToString();
            cboHocKy.Text = row.Cells["HocKy"].Value?.ToString();
            txtNamHoc.Text = row.Cells["NamHoc"].Value?.ToString();

            txtCC.Text = row.Cells["DiemChuyenCan"].Value?.ToString();
            txtBT.Text = row.Cells["DiemBaiTap"].Value?.ToString();
            txtGK.Text = row.Cells["DiemGiuaKy"].Value?.ToString();
            txtCK.Text = row.Cells["DiemCuoiKy"].Value?.ToString();
        }

        private void cboHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDiem();
        }
        private void dgvDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
       
    }
    }
}