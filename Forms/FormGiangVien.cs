using QuanLySinhVienCSharp.Services;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLySinhVienCSharp.Forms
{
    public partial class FormGiangVien : Form
    {
        GiangVienService gvService = new GiangVienService();
        DiemService diemService = new DiemService();

        string maGV = "GV01";

        public FormGiangVien(string maGV)
        {
            InitializeComponent();
            this.maGV = maGV;
        }

        private void FormGiangVien_Load(object sender, EventArgs e)
        {
            LoadThongTin();
            dgvDiem.DataSource = diemService.GetAll();
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

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            dgvDiem.DataSource = diemService.GetAll();
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
                MessageBox.Show("Giảng viên này hiện không phụ trách lớp nào.");
            }
        }

        private void tabNhap_Sua_Diem_Click(object sender, EventArgs e)
        {

        }

        private void btnLuuDiem_Click(object sender, EventArgs e)
        {
            try
            {
                string maSV = txtMaSV.Text.Trim();
                string maHP = txtMaHP.Text.Trim();
                int hocKy = int.Parse(cboHocKy.Text);
                string namHoc = txtNamHoc.Text.Trim();

                double diemCC = double.Parse(txtCC.Text);
                double diemBT = double.Parse(txtBT.Text);
                double diemGK = double.Parse(txtGK.Text);
                double diemCK = double.Parse(txtCK.Text);

                bool result = diemService.NhapDiem(maSV, maHP, hocKy, namHoc, diemCC, diemBT, diemGK, diemCK);

                if (result)
                {
                    MessageBox.Show("Nhập điểm thành công!");
                    dgvDiem.DataSource = diemService.GetAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
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
                        dgvDiem.DataSource = diemService.GetAll();
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
    }
}