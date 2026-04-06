using QuanLySinhVienCSharp.Models;
using QuanLySinhVienCSharp.Service;
using QuanLySinhVienCSharp.Services;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Style;


namespace QuanLySinhVien
{
    // ===== KHỞI TẠO =====
    public partial class FormAdmin : Form
    {
        TaiKhoanService tkService = new TaiKhoanService();
        SinhVienService svService = new SinhVienService();
        GiangVienService gvService = new GiangVienService();
        HocPhanService hpService = new HocPhanService();
        LopService lopService = new LopService();

        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

            LoadAll();
            LoadLop();
            LoadTabBaoCao();

 

            cboGioiTinhSV.Items.Clear();
            cboGioiTinhSV.Items.AddRange(new string[] { "Nam", "Nữ" });

            cboVaiTro.Items.Clear();
            cboVaiTro.Items.AddRange(new string[] { "SV", "GV", "ADMIN" });
        }
        // ===== DÙNG CHUNG =====
        private void LoadAll()
        {
            dgvTaiKhoan.DataSource = tkService.GetAll();
            dgvSinhVien.DataSource = svService.GetAll();
            dgvGiangVien.DataSource = gvService.GetAll();
            dgvHocPhan.DataSource = hpService.GetAll();
        }

        private void LoadLop()
        {
            try
            {
                DataTable dt = lopService.GetAll();
                AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

                foreach (DataRow row in dt.Rows)
                {
                    collection.Add(row["MaLop"].ToString());
                }

                txtMaLop.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtMaLop.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtMaLop.AutoCompleteCustomSource = collection;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải lớp: " + ex.Message);
            }
        }

        private void LoadTabBaoCao()
        {
            try
            {
                dgvBaoCao.DataSource = svService.GetBangDiemChiTiet();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        #region SINH VIÊN
        private SinhVien GetSV()
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) ||
         string.IsNullOrWhiteSpace(txtHoTen.Text) ||
         string.IsNullOrWhiteSpace(txtNgaySinh.Text) ||
         string.IsNullOrWhiteSpace(txtMaLop.Text) ||
         string.IsNullOrWhiteSpace(txtNamThu.Text) ||
         string.IsNullOrWhiteSpace(cboGioiTinhSV.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return null;
            }

            if (!DateTime.TryParse(txtNgaySinh.Text, out DateTime ngaySinh))
            {
                MessageBox.Show("Ngày sinh không hợp lệ!");
                return null;
            }

            if (!int.TryParse(txtNamThu.Text, out int namThu))
            {
                MessageBox.Show("Năm thứ phải là số!");
                return null;
            }

            if (namThu < 1 || namThu > 6)
            {
                MessageBox.Show("Năm thứ phải từ 1 đến 6!");
                return null;
            }

            return new SinhVien
            {
                MaSV = txtMaSV.Text.Trim(),
                HoTen = txtHoTen.Text.Trim(),
                NgaySinh = ngaySinh,
                GioiTinh = cboGioiTinhSV.Text.Trim(),
                SDT = txtSDT.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim(),
                MaLop = txtMaLop.Text.Trim(),
                NamThu = namThu,
                KhoaHoc = txtKhoaHoc.Text.Trim()
            };
        }
        private void ClearSVForm()
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtNgaySinh.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtMaLop.Clear();
            txtNamThu.Clear();
            txtKhoaHoc.Clear();
        }
        private void btnThemSV_Click(object sender, EventArgs e)
        {
            try
            {
                SinhVien sv = GetSV();
                if (sv == null) return;

                if (svService.Exists(sv.MaSV))
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại!");
                    return;
                }

                if (svService.Add(sv))
                {
                    MessageBox.Show("Thêm sinh viên thành công!");
                    LoadAll();
                    ClearSVForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message);
            }
        }
        private void btnSuaSV_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSV();
            if (sv == null) return;

            if (svService.Update(sv))
            {
                MessageBox.Show("Cập nhật thông tin thành công!");
                dgvSinhVien.DataSource = svService.GetAll();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }
        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            if (string.IsNullOrEmpty(maSV))
            {
                MessageBox.Show("Hãy chọn hoặc nhập Mã Sinh Viên cần xóa!");
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn xóa sinh viên {maSV}?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (svService.Delete(maSV))
                {
                    MessageBox.Show("Đã xóa sinh viên!");
                    dgvSinhVien.DataSource = svService.GetAll();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại! Sinh viên này có thể đang liên kết với bảng điểm.");
                }
            }
        }
        #endregion
        #region GIẢNG VIÊN

        private GiangVien GetGV()
        {
            if (string.IsNullOrWhiteSpace(txtMaGV.Text)) return null;

            return new GiangVien
            {
                MaGV = txtMaGV.Text.Trim(),
                HoTen = txtHoTenGV.Text.Trim(),
                GioiTinh = cboGioiTinhGV.Text,
                DiaChi = txtDiaChiGV.Text.Trim(),
                Email = txtEmailGV.Text.Trim(),
                MaKhoa = txtMaKhoaGV.Text.Trim()
            };
        }
        private void ClearGVForm()
        {
            txtMaGV.Clear();
            txtHoTenGV.Clear();
            txtEmailGV.Clear();
            txtDiaChiGV.Clear();
            txtMaKhoaGV.Clear();
        }

        private void btnThemGV_Click(object sender, EventArgs e)
        {
            GiangVien gv = GetGV();

            if (gv == null)
            {
                MessageBox.Show("Vui lòng nhập Mã Giảng Viên!");
                return;
            }

            if (gvService.Add(gv))
            {
                MessageBox.Show("Thêm giảng viên thành công!");
                LoadAll();
                ClearGVForm();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }
        private void btnSuaGV_Click(object sender, EventArgs e)
        {
            GiangVien gv = GetGV();
            if (gv == null) return;

            if (gvService.Update(gv))
            {
                MessageBox.Show("Cập nhật thành công!");
                dgvGiangVien.DataSource = gvService.GetAll();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại! Kiểm tra lại Mã Khoa.");
            }
        }
        private void btnXoaGV_Click(object sender, EventArgs e)
        {
            string maGV = txtMaGV.Text.Trim();
            if (string.IsNullOrEmpty(maGV)) return;

            if (MessageBox.Show($"Xóa giảng viên {maGV}?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (gvService.Delete(maGV))
                {
                    MessageBox.Show("Đã xóa!");
                    dgvGiangVien.DataSource = gvService.GetAll();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại! Giảng viên này có thể đang dạy các học phần.");
                }
            }
        }
        private void btnTaiLaiGV_Click(object sender, EventArgs e)
        {
            dgvGiangVien.DataSource = gvService.GetAll();
        }
        #endregion

        #region HỌC PHẦN
        private HocPhan GetHocPhanInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaHP.Text))
            {
                MessageBox.Show("Nhập mã học phần!");
                return null;
            }
            if (string.IsNullOrWhiteSpace(txtTenHP.Text))
            {
                MessageBox.Show("Nhập tên học phần!");
                return null;
            }
            if (!int.TryParse(txtSoTinChi.Text, out int tinChi))
            {
                MessageBox.Show("Tín chỉ phải là số!");
                return null;
            }
            if (string.IsNullOrWhiteSpace(txtMaKhoa.Text))
            {
                MessageBox.Show("Nhập mã khoa!");
                return null;
            }

            return new HocPhan
            {
                MaHP = txtMaHP.Text.Trim(),
                TenHP = txtTenHP.Text.Trim(),
                TinChi = tinChi,
                MaKhoa = txtMaKhoa.Text.Trim()
            };
        }
        private void ClearHPForm()
        {
            txtMaHP.Clear();
            txtTenHP.Clear();
            txtSoTinChi.Clear();
            txtMaKhoa.Clear();
        }
        private void LoadHocPhan()
        {
            try
            {
                dgvHocPhan.DataSource = hpService.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải học phần: " + ex.Message);
            }
        }

        private void btnThemHP_Click_1(object sender, EventArgs e)
        {
            var hp = GetHocPhanInput();
            if (hp == null) return;

            try
            {
                if (hpService.Add(hp))
                {
                    MessageBox.Show("Thêm học phần thành công!");
                    LoadHocPhan();
                    ClearHPForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnXoaHP_Click_1(object sender, EventArgs e)
        {
            string maHP = txtMaHP.Text.Trim();
            if (string.IsNullOrEmpty(maHP))
            {
                MessageBox.Show("Chọn hoặc nhập mã học phần cần xóa!");
                return;
            }

            if (MessageBox.Show($"Xóa học phần {maHP}?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (hpService.Delete(maHP))
                    {
                        MessageBox.Show("Đã xóa học phần!");
                        LoadHocPhan();
                        ClearHPForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnTaiLaiHP_Click(object sender, EventArgs e)
        {
            dgvHocPhan.DataSource = hpService.GetAll();
        }
        #endregion

        #region TÀI KHOẢN
        private void btnThemTK_Click_1(object sender, EventArgs e)
        {
            try
            {
                string tenDN = txtTaiKhoan.Text.Trim();
                string vaiTro = cboVaiTro.Text;
                string matKhau = txtMatKhau.Text.Trim(); 

                // 1. Validate
                if (string.IsNullOrEmpty(tenDN))
                {
                    MessageBox.Show("Nhập tài khoản!");
                    return;
                }

                if (string.IsNullOrEmpty(matKhau))
                {
                    MessageBox.Show("Nhập mật khẩu!");
                    return;
                }

                if (string.IsNullOrEmpty(vaiTro))
                {
                    MessageBox.Show("Chọn vai trò!");
                    return;
                }

                if (tkService.Exists(tenDN))
                {
                    MessageBox.Show("Tài khoản đã tồn tại!");
                    return;
                }

                // 3. Gán đúng logic
                TaiKhoan tk = new TaiKhoan
                {
                    TenDangNhap = tenDN,
                    MatKhau = matKhau,
                    VaiTro = vaiTro,
                    MaSV = null,
                    MaGV = null
                };

                if (vaiTro == "SV")
                {
                    tk.MaSV = tenDN;
                }
                else if (vaiTro == "GV")
                {
                    tk.MaGV = tenDN;
                }

                if (tkService.Add(tk))
                {
                    MessageBox.Show("Thêm tài khoản thành công!");

                    LoadAll(); 

                    txtTaiKhoan.Clear();
                    txtMatKhau.Clear();
                    cboVaiTro.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void btnXoaTK_Click_1(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.CurrentRow == null)
            {
                MessageBox.Show("Chọn tài khoản cần xóa!");
                return;
            }

            string tenDN = dgvTaiKhoan.CurrentRow.Cells["TenDangNhap"]?.Value?.ToString();

            if (string.IsNullOrEmpty(tenDN))
            {
                MessageBox.Show("Dữ liệu không hợp lệ!");
                return;
            }

            if (MessageBox.Show($"Xóa tài khoản {tenDN}?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (tkService.Delete(tenDN))
                {
                    MessageBox.Show("Đã xóa!");
                    LoadAll();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }
        private void btnTaiLaiTK_Click_1(object sender, EventArgs e)
        {
            LoadAll();
        }
        #endregion

        #region BÁO CÁO
       
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (!(dgvBaoCao.DataSource is DataTable dt) || dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Excel Files|*.xlsx",
                FileName = "BaoCao_SinhVien.xlsx"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (ExcelPackage package = new ExcelPackage())
                    {
                        var ws = package.Workbook.Worksheets.Add("BaoCao");

                        ws.Cells["A1"].LoadFromDataTable(dt, true);

                        int rowCount = dt.Rows.Count + 1;
                        int colCount = dt.Columns.Count;

                        using (var range = ws.Cells[1, 1, 1, colCount])
                        {
                            range.Style.Font.Bold = true;
                            range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                            range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);
                        }

                        using (var range = ws.Cells[1, 1, rowCount, colCount])
                        {
                            range.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                            range.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                            range.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                            range.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        }

                        ws.Cells.AutoFitColumns();

                        FileInfo fi = new FileInfo(sfd.FileName);
                        package.SaveAs(fi);
                    }

                    MessageBox.Show("Xuất Excel thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất file: " + ex.Message);
                }
            }
        }
        #endregion
        #region ĐĂNG XUẤT
        private void tabDangXuatAD_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close(); // quay về login
            }
        }
        #endregion



        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thoát?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }


        private void txtMaKhoa_TextChanged(object sender, EventArgs e)
        {

        }


        private void tabHocPhan_Click(object sender, EventArgs e)
        {

        }

        private void txtSoTinChi_TextChanged(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvHocPhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                DataGridViewRow row = dgvHocPhan.Rows[e.RowIndex];
                txtMaHP.Text = row.Cells[0].Value?.ToString();
                txtTenHP.Text = row.Cells[1].Value?.ToString();
                txtSoTinChi.Text = row.Cells[2].Value?.ToString();
                txtMaKhoa.Text = row.Cells[3].Value?.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị chi tiết: " + ex.Message);
            }
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void btnTaiLaiSV_Click(object sender, EventArgs e)
        {
            dgvSinhVien.DataSource = svService.GetAll();
        }

       

        private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvTaiKhoan.Rows[e.RowIndex];

                txtTaiKhoan.Text = row.Cells["TenDangNhap"].Value?.ToString();
                cboVaiTro.Text = row.Cells["VaiTro"].Value?.ToString();
            }
        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSinhVien.Rows.Count)
            {
                var row = dgvSinhVien.Rows[e.RowIndex];

                txtMaSV.Text = row.Cells["MaSV"].Value?.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();

                if (row.Cells["NgaySinh"].Value != DBNull.Value)
                    txtNgaySinh.Text = Convert.ToDateTime(row.Cells["NgaySinh"].Value).ToString("yyyy-MM-dd");
                else
                    txtNgaySinh.Clear();

                cboGioiTinhSV.Text = row.Cells["GioiTinh"].Value?.ToString();
                txtSDT.Text = row.Cells["SDT"].Value?.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
                txtMaLop.Text = row.Cells["MaLop"].Value?.ToString();
                txtNamThu.Text = row.Cells["NamThu"].Value?.ToString();
                txtKhoaHoc.Text = row.Cells["KhoaHoc"].Value?.ToString();
            }
        }

        private void btnSearchSV_Click(object sender, EventArgs e)
        {
            string keyword = txtSearchSV.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Nhập từ khóa tìm kiếm!");
                return;
            }

            dgvSinhVien.DataSource = svService.Search(keyword);
        }

        private void tabQLGV_Click(object sender, EventArgs e)
        {

        }

        private void dgvGiangVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvGiangVien.Rows.Count)
            {
                var row = dgvGiangVien.Rows[e.RowIndex];

                txtMaGV.Text = row.Cells["MaGV"].Value?.ToString();
                txtHoTenGV.Text = row.Cells["HoTen"].Value?.ToString();
                cboGioiTinhGV.Text = row.Cells["GioiTinh"].Value?.ToString();
                txtDiaChiGV.Text = row.Cells["DiaChi"].Value?.ToString();
                txtEmailGV.Text = row.Cells["Email"].Value?.ToString();
                txtMaKhoaGV.Text = row.Cells["MaKhoa"].Value?.ToString();
            }
        }

        private void btnSearchGV_Click(object sender, EventArgs e)
        {
            string keyword = txtSearchGV.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                dgvGiangVien.DataSource = gvService.GetAll(); // hiện tất cả
            }
            else
            {
                dgvGiangVien.DataSource = gvService.Search(keyword); // tìm kiếm
            }
        }

        private void btnSuaHP_Click(object sender, EventArgs e)
        {
            var hp = GetHocPhanInput();
            if (hp == null) return;

            try
            {
                if (hpService.Update(hp))
                {
                    MessageBox.Show("Cập nhật học phần thành công!");
                    LoadHocPhan();
                    ClearHPForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSVTheoKhoa_Click(object sender, EventArgs e)
        {
            string maKhoa = txtSVTheoKhoa.Text.Trim();

            if (string.IsNullOrEmpty(maKhoa))
            {
                MessageBox.Show("Nhập mã khoa!");
                return;
            }

            var dt = svService.GetSV_ByKhoa(maKhoa);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!");
            }

            dgvBaoCao.DataSource = dt;
        }

        private void tabBaoCao_Click(object sender, EventArgs e)
        {
            LoadTabBaoCao();
        }

        private void dgvBaoCao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLoadSV_Click(object sender, EventArgs e)
        {
            dgvBaoCao.DataSource = svService.GetAll();
        }

        private void btnSVTheoLop_Click(object sender, EventArgs e)
        {
            string maLop = txtSVTheoLop.Text.Trim();

            if (string.IsNullOrEmpty(maLop))
            {
                MessageBox.Show("Nhập mã lớp!");
                return;
            }

            var dt = svService.GetSV_ByLop(maLop);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!");
            }

            dgvBaoCao.DataSource = dt;
        }

        private void btnSVTheoHP_Click(object sender, EventArgs e)
        {
            string maHP = txtSVTheoHP.Text.Trim();

            if (string.IsNullOrEmpty(maHP))
            {
                MessageBox.Show("Nhập mã học phần!");
                return;
            }

            var dt = svService.GetSV_ByHocPhan(maHP);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!");
            }

            dgvBaoCao.DataSource = dt;
        }
    }
}