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
        }

        private void LoadThongTin()
        {
            DataTable dt = gvService.GetById(maGV);

            if (dt.Rows.Count > 0)
            {
                var r = dt.Rows[0];
                lblMGV.Text = r["MaGV"].ToString();
                lblNameGV.Text = r["HoTen"].ToString();
                lblGioiTinh.Text = r["GioiTinh"].ToString();
                lblEmail.Text = r["Email"].ToString();
                lblDiaChi.Text = r["DiaChi"].ToString();
                lblMaKhoa.Text = r["MaKhoa"].ToString();
            }
        }
        private void LoadDiem()
        {
            string hocKy = cboHocKy.Text;
            string namHoc = txtNamHoc.Text.Trim();

            DataTable dt = diemService.GetByGiangVien(maGV);

            // lọc thêm trên C#
            if (!string.IsNullOrEmpty(hocKy))
            {
                dt.DefaultView.RowFilter = $"HocKy = {hocKy}";
            }

            if (!string.IsNullOrEmpty(namHoc))
            {
                dt.DefaultView.RowFilter += $" AND NamHoc = '{namHoc}'";
            }

            dgvDiem.DataSource = dt;
        }
        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            dgvDiem.DataSource = diemService.GetByGiangVien(maGV);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXemDSLop_Click(object sender, EventArgs e)
        {
            dgvLop.DataSource = gvService.GetLopPhuTrach(maGV);

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

                bool kq = diemService.NhapDiem(
                    txtMaSV.Text,
                    txtMaHP.Text,
                    hocKy,
                    namHoc,
                    cc, bt, gk, ck
                );

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
                    if (diemService.Delete(maSV, maHP)) // Đảm bảo DiemService đã có hàm Delete
                    {
                        MessageBox.Show("Xóa thành công!");
                        dgvDiem.DataSource = diemService.GetByGiangVien(maGV);
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

        }

        private void cboHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDiem();
        }
        private void dgvDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDiem.CurrentRow == null) return;

            txtMaSV.Text = dgvDiem.CurrentRow.Cells["MaSV"].Value.ToString();
            txtMaHP.Text = dgvDiem.CurrentRow.Cells["MaHP"].Value.ToString();
            cboHocKy.Text = dgvDiem.CurrentRow.Cells["HocKy"].Value.ToString();
            txtNamHoc.Text = dgvDiem.CurrentRow.Cells["NamHoc"].Value.ToString();

            txtCC.Text = dgvDiem.CurrentRow.Cells["DiemChuyenCan"].Value.ToString();
            txtBT.Text = dgvDiem.CurrentRow.Cells["DiemBaiTap"].Value.ToString();
            txtGK.Text = dgvDiem.CurrentRow.Cells["DiemGiuaKy"].Value.ToString();
            txtCK.Text = dgvDiem.CurrentRow.Cells["DiemCuoiKy"].Value.ToString();
        }
    }
}