using QuanLySinhVienCSharp.Models;
using QuanLySinhVienCSharp.Service;
using QuanLySinhVienCSharp.Services;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class FormSinhVien : Form
    {
        
        DangKyService dkService = new DangKyService();
        DiemService diemService = new DiemService();
        SinhVienService svService = new SinhVienService();
        string maSV;
        

        public FormSinhVien(string maVao)
        {
            InitializeComponent();
            this.maSV = maVao;
        }

        private void FormSinhVien_Load(object sender, EventArgs e)
        {
            LoadThongTin();
            LoadComboHP();
            LoadDangKy();

            dgvKetQua.DataSource = svService.GetBangDiemTheoSV(this.maSV.Trim());
        }
        private void LoadThongTin()
        {
            DataTable dt = svService.GetById(this.maSV);

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow r = dt.Rows[0];

                lblMSV.Text = r["MaSV"].ToString();
                lblHoTen.Text = r["HoTen"].ToString();
                lblGT.Text = r["GioiTinh"].ToString();

                lblDate.Text = r["NgaySinh"] != DBNull.Value
                    ? Convert.ToDateTime(r["NgaySinh"]).ToString("dd/MM/yyyy")
                    : "";

                lblNumber.Text = r["SDT"].ToString();
                lblDC.Text = r["DiaChi"].ToString();
                lblML.Text = r["TenLop"].ToString();
                lblKH.Text = r["TenKhoa"].ToString();

                lblYear.Text = r["NamThu"] != DBNull.Value
                    ? r["NamThu"].ToString()
                    : "";
            }
        }

        private void LoadDangKy()
        {
            dgvDangKy.AutoGenerateColumns = true;
            dgvDangKy.DataSource = null;

            DataTable dtDK = svService.GetHocPhanDaDangKy(this.maSV.Trim());

            if (dtDK != null && dtDK.Rows.Count > 0)
            {
                dgvDangKy.DataSource = dtDK;

                dgvDangKy.Columns["MaHP"].HeaderText = "Mã HP";
                dgvDangKy.Columns["TenHP"].HeaderText = "Tên Học Phần";
                dgvDangKy.Columns["TinChi"].HeaderText = "Tín Chỉ";
                dgvDangKy.Columns["HocKy"].HeaderText = "Học Kỳ";
                dgvDangKy.Columns["NamHoc"].HeaderText = "Năm Học";

                dgvDangKy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (cboMaHP.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn học phần!");
                return;
            }

            try
            {
                var dk = new DangKy
                {
                    MaSV = maSV,
                    MaHP = cboMaHP.SelectedValue.ToString(),
                    HocKy = int.TryParse(cboHocKy.Text, out int hk) ? hk : 1,
                    NamHoc = txtNamHoc.Text
                };

                if (dkService.DangKy(dk))
                {
                    MessageBox.Show("Đăng ký thành công!");
                    LoadDangKy(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadThongTin();
            LoadDangKy();
            dgvKetQua.DataSource = svService.GetBangDiemTheoSV(this.maSV.Trim());
        }

        private void LoadComboHP()
        {
            DataTable dt = svService.GetHocPhanDeDangKy();

            if (dt != null && dt.Rows.Count > 0)
            {
                cboMaHP.DataSource = dt;
                cboMaHP.DisplayMember = "TenHP";
                cboMaHP.ValueMember = "MaHP";
            }

            if (cboHocKy.Items.Count == 0)
            {
                cboHocKy.Items.AddRange(new string[] { "1", "2", "3" });
                cboHocKy.SelectedIndex = 0;
            }
        }
        private void tabTTCNSV_Click(object sender, EventArgs e)
        {

        }

        private void grbHSSV_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvKetQua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblMSV_Click(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void lblGT_Click(object sender, EventArgs e)
        {

        }

        private void lblNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblDC_Click(object sender, EventArgs e)
        {

        }

        private void lblML_Click(object sender, EventArgs e)
        {

        }

        private void lblYear_Click(object sender, EventArgs e)
        {

        }

        private void lblKH_Click(object sender, EventArgs e)
        {

        }

        private void tabDKHP_Click(object sender, EventArgs e)
        {

        }



        private void tabDangXuatSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        
            if (tabDangXuatSV.SelectedTab == tabPage1)
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
                    tabDangXuatSV.SelectedIndex = 0;
                }
            }
        }
    }

       
    }
    
    