using QuanLySinhVienCSharp.Models;
using QuanLySinhVienCSharp.Service;
using QuanLySinhVienCSharp.Services;
using System;
using System.Data;
using System.Windows.Forms;
using OfficeOpenXml; 
using System.IO;

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
            if (string.IsNullOrWhiteSpace(txtMaLop.Text))
            {
                MessageBox.Show("Mã lớp không được để trống!");
                return null;
            }

            return new SinhVien
            {
                MaSV = txtMaSV.Text.Trim(),
                HoTen = txtHoTen.Text.Trim(),
                NgaySinh = DateTime.TryParse(txtNgaySinh.Text, out var d) ? d : DateTime.Now,
                GioiTinh = cboGioiTinhSV.Text,
                SDT = txtSDT.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim(),
                MaLop = txtMaLop.Text.Trim(),
                NamThu = int.TryParse(txtNamThu.Text, out var n) ? n : 1,
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
            SinhVien sv = GetSV();

            if (sv == null || string.IsNullOrEmpty(sv.MaSV))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (svService.Add(sv))
            {
                MessageBox.Show("Thêm sinh viên thành công!");
                LoadAll();
                ClearSVForm();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
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
            if (string.IsNullOrWhiteSpace(txtMaHP.Text)) return null;

            return new HocPhan
            {
                MaHP = txtMaHP.Text.Trim(),
                TenHP = txtTenHP.Text.Trim(),
                TinChi = int.TryParse(txtSoTinChi.Text, out var n) ? n : 0,
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
        private void btnThemHP_Click_1(object sender, EventArgs e)
        {
            HocPhan hp = GetHocPhanInput();
            if (hp == null)
            {
                MessageBox.Show("Vui lòng nhập Mã Học Phần!");
                return;
            }

            if (hpService.Add(hp))
            {
                MessageBox.Show("Thêm học phần thành công!");
                LoadAll();
                ClearHPForm();
            }
            else
            {
                MessageBox.Show("Thêm thất bại! Kiểm tra lại Mã HP hoặc Mã Khoa có tồn tại không.");
            }
        }
        private void btnXoaHP_Click_1(object sender, EventArgs e)
        {
            string maHP = txtMaHP.Text.Trim();

            if (string.IsNullOrEmpty(maHP))
            {
                MessageBox.Show("Vui lòng nhập hoặc chọn Mã Học Phần cần xóa!");
                return;
            }
            if (MessageBox.Show($"Bạn có chắc muốn xóa học phần {maHP}?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (hpService.Delete(maHP))
                {
                    MessageBox.Show("Đã xóa thành công!");
                    dgvHocPhan.DataSource = hpService.GetAll();

                    txtMaHP.Clear();
                    txtTenHP.Clear();
                    txtSoTinChi.Clear();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại! Học phần này có thể đang có dữ liệu liên quan.");
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
                string matKhau = "123456";

                if (string.IsNullOrEmpty(tenDN))
                {
                    MessageBox.Show("Nhập tài khoản!");
                    return;
                }

                if (tkService.Exists(tenDN))
                {
                    MessageBox.Show("Tài khoản đã tồn tại!");
                    return;
                }

                TaiKhoan tk = new TaiKhoan
                {
                    TenDangNhap = tenDN,
                    MatKhau = matKhau,
                    VaiTro = vaiTro,
                    MaSV = vaiTro == "SV" ? tenDN : null,
                    MaGV = vaiTro == "GV" ? tenDN : null
                };

                if (tkService.Add(tk))
                {
                    MessageBox.Show("Thêm tài khoản thành công!");

                    txtTaiKhoan.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnXoaTK_Click_1(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.CurrentRow == null) return;

            string tenDN = dgvTaiKhoan.CurrentRow.Cells["TenDangNhap"].Value.ToString();

            if (MessageBox.Show($"Xóa tài khoản {tenDN}?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (tkService.Delete(tenDN))
                {
                    MessageBox.Show("Đã xóa!");
                    dgvTaiKhoan.DataSource = tkService.GetAll();
                }
            }
        }
        private void btnTaiLaiTK_Click_1(object sender, EventArgs e)
        {
            LoadAll();
        }
        #endregion

        #region BÁO CÁO
        private void button1_Click(object sender, EventArgs e)
        {
            LoadTabBaoCao();
        }
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (!(dgvBaoCao.DataSource is DataTable dt))
            {
                MessageBox.Show("Không có dữ liệu để xuất!");
                return;
            }

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Bảng dữ liệu rỗng!");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Files|*.xlsx";
            sfd.FileName = "BaoCao_SinhVien_BangDiem.xlsx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                    using (ExcelPackage pck = new ExcelPackage())
                    {
                        var ws = pck.Workbook.Worksheets.Add("Danh sách");

                        ws.Cells["A1"].LoadFromDataTable(dt, true);

                        using (var range = ws.Cells[1, 1, 1, dt.Columns.Count])
                        {
                            range.Style.Font.Bold = true;
                            range.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                            range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);
                        }

                        ws.Cells.AutoFitColumns();

                        File.WriteAllBytes(sfd.FileName, pck.GetAsByteArray());
                    }

                    MessageBox.Show("Xuất Excel thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
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
    }
}