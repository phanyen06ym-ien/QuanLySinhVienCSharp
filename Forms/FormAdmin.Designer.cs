using System;

namespace QuanLySinhVien
{
    partial class FormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabDangXuat = new System.Windows.Forms.TabControl();
            this.tabQLTK = new System.Windows.Forms.TabPage();
            this.btnTaiLaiTK = new System.Windows.Forms.Button();
            this.btnThemTK = new System.Windows.Forms.Button();
            this.btnXoaTK = new System.Windows.Forms.Button();
            this.cboVaiTro = new System.Windows.Forms.ComboBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.lblVaiTro = new System.Windows.Forms.Label();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.tabQLSV = new System.Windows.Forms.TabPage();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.cboGioiTinhSV = new System.Windows.Forms.ComboBox();
            this.btnTaiLaiSV = new System.Windows.Forms.Button();
            this.btnXoaSV = new System.Windows.Forms.Button();
            this.btnSuaSV = new System.Windows.Forms.Button();
            this.btnThemSV = new System.Windows.Forms.Button();
            this.txtKhoaHoc = new System.Windows.Forms.TextBox();
            this.txtNamThu = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblKhoaHoc = new System.Windows.Forms.Label();
            this.lblNamThu = new System.Windows.Forms.Label();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblTenSV = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.tabQLGV = new System.Windows.Forms.TabPage();
            this.btnTaiLaiGV = new System.Windows.Forms.Button();
            this.btnXoaGV = new System.Windows.Forms.Button();
            this.btnSuaGV = new System.Windows.Forms.Button();
            this.btnThemGV = new System.Windows.Forms.Button();
            this.txtMaKhoaGV = new System.Windows.Forms.TextBox();
            this.txtDiaChiGV = new System.Windows.Forms.TextBox();
            this.txtHoTenGV = new System.Windows.Forms.TextBox();
            this.txtEmailGV = new System.Windows.Forms.TextBox();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.cboGioiTinhGV = new System.Windows.Forms.ComboBox();
            this.lblMaGV = new System.Windows.Forms.Label();
            this.lblTenGV = new System.Windows.Forms.Label();
            this.lblGT = new System.Windows.Forms.Label();
            this.lblDC = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblMaKhoa = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvGiangVien = new System.Windows.Forms.DataGridView();
            this.tabHocPhan = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.btnTaiLaiHP = new System.Windows.Forms.Button();
            this.btnXoaHP = new System.Windows.Forms.Button();
            this.btnThemHP = new System.Windows.Forms.Button();
            this.txtTenHP = new System.Windows.Forms.TextBox();
            this.txtSoTinChi = new System.Windows.Forms.TextBox();
            this.txtMaHP = new System.Windows.Forms.TextBox();
            this.lblSoTinChi = new System.Windows.Forms.Label();
            this.lblTenHP = new System.Windows.Forms.Label();
            this.lblMaHP = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvHocPhan = new System.Windows.Forms.DataGridView();
            this.tabBaoCao = new System.Windows.Forms.TabPage();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.dgvBaoCao = new System.Windows.Forms.DataGridView();
            this.btnTaiDuLieu = new System.Windows.Forms.Button();
            this.tabDangXuatAD = new System.Windows.Forms.TabPage();
            this.tabDangXuat.SuspendLayout();
            this.tabQLTK.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.tabQLSV.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.tabQLGV.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiangVien)).BeginInit();
            this.tabHocPhan.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocPhan)).BeginInit();
            this.tabBaoCao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDangXuat
            // 
            this.tabDangXuat.Controls.Add(this.tabQLTK);
            this.tabDangXuat.Controls.Add(this.tabQLSV);
            this.tabDangXuat.Controls.Add(this.tabQLGV);
            this.tabDangXuat.Controls.Add(this.tabHocPhan);
            this.tabDangXuat.Controls.Add(this.tabBaoCao);
            this.tabDangXuat.Controls.Add(this.tabDangXuatAD);
            this.tabDangXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabDangXuat.Location = new System.Drawing.Point(0, 0);
            this.tabDangXuat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabDangXuat.Name = "tabDangXuat";
            this.tabDangXuat.SelectedIndex = 0;
            this.tabDangXuat.Size = new System.Drawing.Size(1762, 989);
            this.tabDangXuat.TabIndex = 0;
            // 
            // tabQLTK
            // 
            this.tabQLTK.Controls.Add(this.btnTaiLaiTK);
            this.tabQLTK.Controls.Add(this.btnThemTK);
            this.tabQLTK.Controls.Add(this.btnXoaTK);
            this.tabQLTK.Controls.Add(this.cboVaiTro);
            this.tabQLTK.Controls.Add(this.txtTaiKhoan);
            this.tabQLTK.Controls.Add(this.lblVaiTro);
            this.tabQLTK.Controls.Add(this.lblTaiKhoan);
            this.tabQLTK.Controls.Add(this.panel1);
            this.tabQLTK.Location = new System.Drawing.Point(4, 29);
            this.tabQLTK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabQLTK.Name = "tabQLTK";
            this.tabQLTK.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabQLTK.Size = new System.Drawing.Size(1754, 956);
            this.tabQLTK.TabIndex = 0;
            this.tabQLTK.Text = "Quản Lý Tài Khoản";
            this.tabQLTK.UseVisualStyleBackColor = true;
            // 
            // btnTaiLaiTK
            // 
            this.btnTaiLaiTK.Location = new System.Drawing.Point(998, 188);
            this.btnTaiLaiTK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTaiLaiTK.Name = "btnTaiLaiTK";
            this.btnTaiLaiTK.Size = new System.Drawing.Size(144, 49);
            this.btnTaiLaiTK.TabIndex = 7;
            this.btnTaiLaiTK.Text = "Tải Lại";
            this.btnTaiLaiTK.UseVisualStyleBackColor = true;
            this.btnTaiLaiTK.Click += new System.EventHandler(this.btnTaiLaiTK_Click_1);
            // 
            // btnThemTK
            // 
            this.btnThemTK.Location = new System.Drawing.Point(621, 188);
            this.btnThemTK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemTK.Name = "btnThemTK";
            this.btnThemTK.Size = new System.Drawing.Size(144, 49);
            this.btnThemTK.TabIndex = 6;
            this.btnThemTK.Text = "Thêm";
            this.btnThemTK.UseVisualStyleBackColor = true;
            this.btnThemTK.Click += new System.EventHandler(this.btnThemTK_Click_1);
            // 
            // btnXoaTK
            // 
            this.btnXoaTK.Location = new System.Drawing.Point(800, 188);
            this.btnXoaTK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaTK.Name = "btnXoaTK";
            this.btnXoaTK.Size = new System.Drawing.Size(144, 49);
            this.btnXoaTK.TabIndex = 5;
            this.btnXoaTK.Text = "Xóa";
            this.btnXoaTK.UseVisualStyleBackColor = true;
            this.btnXoaTK.Click += new System.EventHandler(this.btnXoaTK_Click_1);
            // 
            // cboVaiTro
            // 
            this.cboVaiTro.FormattingEnabled = true;
            this.cboVaiTro.Items.AddRange(new object[] {
            "SV",
            "GV",
            "ADMIN"});
            this.cboVaiTro.Location = new System.Drawing.Point(998, 63);
            this.cboVaiTro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboVaiTro.Name = "cboVaiTro";
            this.cboVaiTro.Size = new System.Drawing.Size(180, 28);
            this.cboVaiTro.TabIndex = 4;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(640, 65);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(148, 26);
            this.txtTaiKhoan.TabIndex = 3;
            // 
            // lblVaiTro
            // 
            this.lblVaiTro.AutoSize = true;
            this.lblVaiTro.Location = new System.Drawing.Point(906, 75);
            this.lblVaiTro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVaiTro.Name = "lblVaiTro";
            this.lblVaiTro.Size = new System.Drawing.Size(59, 20);
            this.lblVaiTro.TabIndex = 2;
            this.lblVaiTro.Text = "Vai Trò";
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Location = new System.Drawing.Point(506, 75);
            this.lblTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(80, 20);
            this.lblTaiKhoan.TabIndex = 1;
            this.lblTaiKhoan.Text = "Tài Khoản";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvTaiKhoan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(4, 253);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1746, 698);
            this.panel1.TabIndex = 0;
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.dgvTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.RowHeadersWidth = 62;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(1746, 698);
            this.dgvTaiKhoan.TabIndex = 0;
            // 
            // tabQLSV
            // 
            this.tabQLSV.Controls.Add(this.txtMaLop);
            this.tabQLSV.Controls.Add(this.cboGioiTinhSV);
            this.tabQLSV.Controls.Add(this.btnTaiLaiSV);
            this.tabQLSV.Controls.Add(this.btnXoaSV);
            this.tabQLSV.Controls.Add(this.btnSuaSV);
            this.tabQLSV.Controls.Add(this.btnThemSV);
            this.tabQLSV.Controls.Add(this.txtKhoaHoc);
            this.tabQLSV.Controls.Add(this.txtNamThu);
            this.tabQLSV.Controls.Add(this.txtDiaChi);
            this.tabQLSV.Controls.Add(this.txtSDT);
            this.tabQLSV.Controls.Add(this.txtNgaySinh);
            this.tabQLSV.Controls.Add(this.txtHoTen);
            this.tabQLSV.Controls.Add(this.txtMaSV);
            this.tabQLSV.Controls.Add(this.lblMaSV);
            this.tabQLSV.Controls.Add(this.lblKhoaHoc);
            this.tabQLSV.Controls.Add(this.lblNamThu);
            this.tabQLSV.Controls.Add(this.lblMaLop);
            this.tabQLSV.Controls.Add(this.lblDiaChi);
            this.tabQLSV.Controls.Add(this.lblSDT);
            this.tabQLSV.Controls.Add(this.lblGioiTinh);
            this.tabQLSV.Controls.Add(this.lblNgaySinh);
            this.tabQLSV.Controls.Add(this.lblTenSV);
            this.tabQLSV.Controls.Add(this.panel2);
            this.tabQLSV.Location = new System.Drawing.Point(4, 29);
            this.tabQLSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabQLSV.Name = "tabQLSV";
            this.tabQLSV.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabQLSV.Size = new System.Drawing.Size(1754, 956);
            this.tabQLSV.TabIndex = 1;
            this.tabQLSV.Text = "Quản Lý Sinh Viên";
            this.tabQLSV.UseVisualStyleBackColor = true;
            this.tabQLSV.Click += new System.EventHandler(this.tabQLSV_Click);
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(1256, 32);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(125, 26);
            this.txtMaLop.TabIndex = 30;
            this.txtMaLop.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cboGioiTinhSV
            // 
            this.cboGioiTinhSV.FormattingEnabled = true;
            this.cboGioiTinhSV.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinhSV.Location = new System.Drawing.Point(310, 168);
            this.cboGioiTinhSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboGioiTinhSV.Name = "cboGioiTinhSV";
            this.cboGioiTinhSV.Size = new System.Drawing.Size(236, 28);
            this.cboGioiTinhSV.TabIndex = 29;
            // 
            // btnTaiLaiSV
            // 
            this.btnTaiLaiSV.Location = new System.Drawing.Point(1062, 272);
            this.btnTaiLaiSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTaiLaiSV.Name = "btnTaiLaiSV";
            this.btnTaiLaiSV.Size = new System.Drawing.Size(112, 35);
            this.btnTaiLaiSV.TabIndex = 28;
            this.btnTaiLaiSV.Text = "Tải Lại";
            this.btnTaiLaiSV.UseVisualStyleBackColor = true;
            // 
            // btnXoaSV
            // 
            this.btnXoaSV.Location = new System.Drawing.Point(882, 272);
            this.btnXoaSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaSV.Name = "btnXoaSV";
            this.btnXoaSV.Size = new System.Drawing.Size(112, 35);
            this.btnXoaSV.TabIndex = 27;
            this.btnXoaSV.Text = "Xóa";
            this.btnXoaSV.UseVisualStyleBackColor = true;
            this.btnXoaSV.Click += new System.EventHandler(this.btnXoaSV_Click);
            // 
            // btnSuaSV
            // 
            this.btnSuaSV.Location = new System.Drawing.Point(684, 272);
            this.btnSuaSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSuaSV.Name = "btnSuaSV";
            this.btnSuaSV.Size = new System.Drawing.Size(112, 35);
            this.btnSuaSV.TabIndex = 26;
            this.btnSuaSV.Text = "Sửa";
            this.btnSuaSV.UseVisualStyleBackColor = true;
            this.btnSuaSV.Click += new System.EventHandler(this.btnSuaSV_Click);
            // 
            // btnThemSV
            // 
            this.btnThemSV.Location = new System.Drawing.Point(501, 272);
            this.btnThemSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemSV.Name = "btnThemSV";
            this.btnThemSV.Size = new System.Drawing.Size(112, 35);
            this.btnThemSV.TabIndex = 25;
            this.btnThemSV.Text = "Thêm";
            this.btnThemSV.UseVisualStyleBackColor = true;
            this.btnThemSV.Click += new System.EventHandler(this.btnThemSV_Click);
            // 
            // txtKhoaHoc
            // 
            this.txtKhoaHoc.Location = new System.Drawing.Point(1256, 168);
            this.txtKhoaHoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKhoaHoc.Name = "txtKhoaHoc";
            this.txtKhoaHoc.Size = new System.Drawing.Size(204, 26);
            this.txtKhoaHoc.TabIndex = 24;
            // 
            // txtNamThu
            // 
            this.txtNamThu.Location = new System.Drawing.Point(1256, 95);
            this.txtNamThu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNamThu.Name = "txtNamThu";
            this.txtNamThu.Size = new System.Drawing.Size(204, 26);
            this.txtNamThu.TabIndex = 23;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(782, 172);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(211, 26);
            this.txtDiaChi.TabIndex = 21;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(782, 91);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(211, 26);
            this.txtSDT.TabIndex = 20;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(782, 32);
            this.txtNgaySinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(211, 26);
            this.txtNgaySinh.TabIndex = 19;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(310, 95);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(236, 26);
            this.txtHoTen.TabIndex = 17;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(310, 32);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(236, 26);
            this.txtMaSV.TabIndex = 16;
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSV.Location = new System.Drawing.Point(134, 28);
            this.lblMaSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(157, 32);
            this.lblMaSV.TabIndex = 15;
            this.lblMaSV.Text = "Mã Sinh Viên";
            // 
            // lblKhoaHoc
            // 
            this.lblKhoaHoc.AutoSize = true;
            this.lblKhoaHoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhoaHoc.Location = new System.Drawing.Point(1080, 168);
            this.lblKhoaHoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKhoaHoc.Name = "lblKhoaHoc";
            this.lblKhoaHoc.Size = new System.Drawing.Size(117, 32);
            this.lblKhoaHoc.TabIndex = 14;
            this.lblKhoaHoc.Text = "Khóa Học";
            // 
            // lblNamThu
            // 
            this.lblNamThu.AutoSize = true;
            this.lblNamThu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamThu.Location = new System.Drawing.Point(1080, 95);
            this.lblNamThu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNamThu.Name = "lblNamThu";
            this.lblNamThu.Size = new System.Drawing.Size(113, 32);
            this.lblNamThu.TabIndex = 13;
            this.lblNamThu.Text = "Năm Thứ";
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLop.Location = new System.Drawing.Point(1080, 32);
            this.lblMaLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(94, 32);
            this.lblMaLop.TabIndex = 12;
            this.lblMaLop.Text = "Mã Lớp";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(614, 163);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(91, 32);
            this.lblDiaChi.TabIndex = 11;
            this.lblDiaChi.Text = "Địa Chỉ";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(614, 95);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(164, 32);
            this.lblSDT.TabIndex = 10;
            this.lblSDT.Text = "Số Điện Thoại";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(134, 168);
            this.lblGioiTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(110, 32);
            this.lblGioiTinh.TabIndex = 9;
            this.lblGioiTinh.Text = "Giới Tính";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(614, 32);
            this.lblNgaySinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(124, 32);
            this.lblNgaySinh.TabIndex = 8;
            this.lblNgaySinh.Text = "Ngày Sinh";
            // 
            // lblTenSV
            // 
            this.lblTenSV.AutoSize = true;
            this.lblTenSV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSV.Location = new System.Drawing.Point(134, 91);
            this.lblTenSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenSV.Name = "lblTenSV";
            this.lblTenSV.Size = new System.Drawing.Size(97, 32);
            this.lblTenSV.TabIndex = 7;
            this.lblTenSV.Text = "Họ Tên ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvSinhVien);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(4, 323);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1746, 628);
            this.panel2.TabIndex = 0;
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSinhVien.Location = new System.Drawing.Point(0, 0);
            this.dgvSinhVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.RowHeadersWidth = 62;
            this.dgvSinhVien.Size = new System.Drawing.Size(1746, 628);
            this.dgvSinhVien.TabIndex = 0;
            // 
            // tabQLGV
            // 
            this.tabQLGV.Controls.Add(this.btnTaiLaiGV);
            this.tabQLGV.Controls.Add(this.btnXoaGV);
            this.tabQLGV.Controls.Add(this.btnSuaGV);
            this.tabQLGV.Controls.Add(this.btnThemGV);
            this.tabQLGV.Controls.Add(this.txtMaKhoaGV);
            this.tabQLGV.Controls.Add(this.txtDiaChiGV);
            this.tabQLGV.Controls.Add(this.txtHoTenGV);
            this.tabQLGV.Controls.Add(this.txtEmailGV);
            this.tabQLGV.Controls.Add(this.txtMaGV);
            this.tabQLGV.Controls.Add(this.cboGioiTinhGV);
            this.tabQLGV.Controls.Add(this.lblMaGV);
            this.tabQLGV.Controls.Add(this.lblTenGV);
            this.tabQLGV.Controls.Add(this.lblGT);
            this.tabQLGV.Controls.Add(this.lblDC);
            this.tabQLGV.Controls.Add(this.lblEmail);
            this.tabQLGV.Controls.Add(this.lblMaKhoa);
            this.tabQLGV.Controls.Add(this.panel3);
            this.tabQLGV.Location = new System.Drawing.Point(4, 29);
            this.tabQLGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabQLGV.Name = "tabQLGV";
            this.tabQLGV.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabQLGV.Size = new System.Drawing.Size(1754, 956);
            this.tabQLGV.TabIndex = 2;
            this.tabQLGV.Text = "Quản Lý Giảng Viên";
            this.tabQLGV.UseVisualStyleBackColor = true;
            // 
            // btnTaiLaiGV
            // 
            this.btnTaiLaiGV.Location = new System.Drawing.Point(1041, 360);
            this.btnTaiLaiGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTaiLaiGV.Name = "btnTaiLaiGV";
            this.btnTaiLaiGV.Size = new System.Drawing.Size(112, 35);
            this.btnTaiLaiGV.TabIndex = 21;
            this.btnTaiLaiGV.Text = "Tải Lại";
            this.btnTaiLaiGV.UseVisualStyleBackColor = true;
            // 
            // btnXoaGV
            // 
            this.btnXoaGV.Location = new System.Drawing.Point(892, 360);
            this.btnXoaGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaGV.Name = "btnXoaGV";
            this.btnXoaGV.Size = new System.Drawing.Size(112, 35);
            this.btnXoaGV.TabIndex = 20;
            this.btnXoaGV.Text = "Xóa";
            this.btnXoaGV.UseVisualStyleBackColor = true;
            this.btnXoaGV.Click += new System.EventHandler(this.btnXoaGV_Click);
            // 
            // btnSuaGV
            // 
            this.btnSuaGV.Location = new System.Drawing.Point(748, 360);
            this.btnSuaGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSuaGV.Name = "btnSuaGV";
            this.btnSuaGV.Size = new System.Drawing.Size(112, 35);
            this.btnSuaGV.TabIndex = 19;
            this.btnSuaGV.Text = "Sửa";
            this.btnSuaGV.UseVisualStyleBackColor = true;
            this.btnSuaGV.Click += new System.EventHandler(this.btnSuaGV_Click);
            // 
            // btnThemGV
            // 
            this.btnThemGV.Location = new System.Drawing.Point(602, 360);
            this.btnThemGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemGV.Name = "btnThemGV";
            this.btnThemGV.Size = new System.Drawing.Size(112, 35);
            this.btnThemGV.TabIndex = 18;
            this.btnThemGV.Text = "Thêm";
            this.btnThemGV.UseVisualStyleBackColor = true;
            this.btnThemGV.Click += new System.EventHandler(this.btnThemGV_Click);
            // 
            // txtMaKhoaGV
            // 
            this.txtMaKhoaGV.Location = new System.Drawing.Point(1227, 222);
            this.txtMaKhoaGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaKhoaGV.Name = "txtMaKhoaGV";
            this.txtMaKhoaGV.Size = new System.Drawing.Size(234, 26);
            this.txtMaKhoaGV.TabIndex = 17;
            // 
            // txtDiaChiGV
            // 
            this.txtDiaChiGV.Location = new System.Drawing.Point(1227, 134);
            this.txtDiaChiGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiaChiGV.Name = "txtDiaChiGV";
            this.txtDiaChiGV.Size = new System.Drawing.Size(234, 26);
            this.txtDiaChiGV.TabIndex = 16;
            // 
            // txtHoTenGV
            // 
            this.txtHoTenGV.Location = new System.Drawing.Point(1227, 55);
            this.txtHoTenGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHoTenGV.Name = "txtHoTenGV";
            this.txtHoTenGV.Size = new System.Drawing.Size(234, 26);
            this.txtHoTenGV.TabIndex = 15;
            // 
            // txtEmailGV
            // 
            this.txtEmailGV.Location = new System.Drawing.Point(640, 217);
            this.txtEmailGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmailGV.Name = "txtEmailGV";
            this.txtEmailGV.Size = new System.Drawing.Size(234, 26);
            this.txtEmailGV.TabIndex = 14;
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(640, 55);
            this.txtMaGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(234, 26);
            this.txtMaGV.TabIndex = 13;
            // 
            // cboGioiTinhGV
            // 
            this.cboGioiTinhGV.FormattingEnabled = true;
            this.cboGioiTinhGV.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinhGV.Location = new System.Drawing.Point(640, 132);
            this.cboGioiTinhGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboGioiTinhGV.Name = "cboGioiTinhGV";
            this.cboGioiTinhGV.Size = new System.Drawing.Size(234, 28);
            this.cboGioiTinhGV.TabIndex = 12;
            // 
            // lblMaGV
            // 
            this.lblMaGV.AutoSize = true;
            this.lblMaGV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaGV.Location = new System.Drawing.Point(444, 55);
            this.lblMaGV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaGV.Name = "lblMaGV";
            this.lblMaGV.Size = new System.Drawing.Size(172, 32);
            this.lblMaGV.TabIndex = 1;
            this.lblMaGV.Text = "Mã Giảng Viên";
            // 
            // lblTenGV
            // 
            this.lblTenGV.AutoSize = true;
            this.lblTenGV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenGV.Location = new System.Drawing.Point(1062, 55);
            this.lblTenGV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenGV.Name = "lblTenGV";
            this.lblTenGV.Size = new System.Drawing.Size(97, 32);
            this.lblTenGV.TabIndex = 2;
            this.lblTenGV.Text = "Họ Tên ";
            // 
            // lblGT
            // 
            this.lblGT.AutoSize = true;
            this.lblGT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGT.Location = new System.Drawing.Point(444, 132);
            this.lblGT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGT.Name = "lblGT";
            this.lblGT.Size = new System.Drawing.Size(110, 32);
            this.lblGT.TabIndex = 8;
            this.lblGT.Text = "Giới Tính";
            // 
            // lblDC
            // 
            this.lblDC.AutoSize = true;
            this.lblDC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDC.Location = new System.Drawing.Point(1062, 132);
            this.lblDC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDC.Name = "lblDC";
            this.lblDC.Size = new System.Drawing.Size(91, 32);
            this.lblDC.TabIndex = 9;
            this.lblDC.Text = "Địa Chỉ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(444, 217);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(71, 32);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            // 
            // lblMaKhoa
            // 
            this.lblMaKhoa.AutoSize = true;
            this.lblMaKhoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKhoa.Location = new System.Drawing.Point(1062, 217);
            this.lblMaKhoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaKhoa.Name = "lblMaKhoa";
            this.lblMaKhoa.Size = new System.Drawing.Size(109, 32);
            this.lblMaKhoa.TabIndex = 11;
            this.lblMaKhoa.Text = "Mã Khoa";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvGiangVien);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(4, 411);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1746, 540);
            this.panel3.TabIndex = 0;
            // 
            // dgvGiangVien
            // 
            this.dgvGiangVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiangVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGiangVien.Location = new System.Drawing.Point(0, 0);
            this.dgvGiangVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvGiangVien.Name = "dgvGiangVien";
            this.dgvGiangVien.RowHeadersWidth = 62;
            this.dgvGiangVien.Size = new System.Drawing.Size(1746, 540);
            this.dgvGiangVien.TabIndex = 0;
            // 
            // tabHocPhan
            // 
            this.tabHocPhan.Controls.Add(this.label1);
            this.tabHocPhan.Controls.Add(this.txtMaKhoa);
            this.tabHocPhan.Controls.Add(this.btnTaiLaiHP);
            this.tabHocPhan.Controls.Add(this.btnXoaHP);
            this.tabHocPhan.Controls.Add(this.btnThemHP);
            this.tabHocPhan.Controls.Add(this.txtTenHP);
            this.tabHocPhan.Controls.Add(this.txtSoTinChi);
            this.tabHocPhan.Controls.Add(this.txtMaHP);
            this.tabHocPhan.Controls.Add(this.lblSoTinChi);
            this.tabHocPhan.Controls.Add(this.lblTenHP);
            this.tabHocPhan.Controls.Add(this.lblMaHP);
            this.tabHocPhan.Controls.Add(this.panel4);
            this.tabHocPhan.Location = new System.Drawing.Point(4, 29);
            this.tabHocPhan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabHocPhan.Name = "tabHocPhan";
            this.tabHocPhan.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabHocPhan.Size = new System.Drawing.Size(1754, 956);
            this.tabHocPhan.TabIndex = 3;
            this.tabHocPhan.Text = "Học Phần";
            this.tabHocPhan.UseVisualStyleBackColor = true;
            this.tabHocPhan.Click += new System.EventHandler(this.tabHocPhan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(750, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã Khoa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(832, 146);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(230, 26);
            this.txtMaKhoa.TabIndex = 10;
            this.txtMaKhoa.TextChanged += new System.EventHandler(this.txtMaKhoa_TextChanged);
            // 
            // btnTaiLaiHP
            // 
            this.btnTaiLaiHP.Location = new System.Drawing.Point(1035, 223);
            this.btnTaiLaiHP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTaiLaiHP.Name = "btnTaiLaiHP";
            this.btnTaiLaiHP.Size = new System.Drawing.Size(112, 35);
            this.btnTaiLaiHP.TabIndex = 9;
            this.btnTaiLaiHP.Text = "Tải Lại";
            this.btnTaiLaiHP.UseVisualStyleBackColor = true;
            this.btnTaiLaiHP.Click += new System.EventHandler(this.btnTaiLaiHP_Click);
            // 
            // btnXoaHP
            // 
            this.btnXoaHP.Location = new System.Drawing.Point(819, 223);
            this.btnXoaHP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoaHP.Name = "btnXoaHP";
            this.btnXoaHP.Size = new System.Drawing.Size(112, 35);
            this.btnXoaHP.TabIndex = 8;
            this.btnXoaHP.Text = "Xóa";
            this.btnXoaHP.UseVisualStyleBackColor = true;
            this.btnXoaHP.Click += new System.EventHandler(this.btnXoaHP_Click_1);
            // 
            // btnThemHP
            // 
            this.btnThemHP.Location = new System.Drawing.Point(615, 223);
            this.btnThemHP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemHP.Name = "btnThemHP";
            this.btnThemHP.Size = new System.Drawing.Size(112, 35);
            this.btnThemHP.TabIndex = 7;
            this.btnThemHP.Text = "Thêm";
            this.btnThemHP.UseVisualStyleBackColor = true;
            this.btnThemHP.Click += new System.EventHandler(this.btnThemHP_Click_1);
            // 
            // txtTenHP
            // 
            this.txtTenHP.Location = new System.Drawing.Point(832, 85);
            this.txtTenHP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenHP.Name = "txtTenHP";
            this.txtTenHP.Size = new System.Drawing.Size(230, 26);
            this.txtTenHP.TabIndex = 6;
            // 
            // txtSoTinChi
            // 
            this.txtSoTinChi.Location = new System.Drawing.Point(1240, 85);
            this.txtSoTinChi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoTinChi.Name = "txtSoTinChi";
            this.txtSoTinChi.Size = new System.Drawing.Size(253, 26);
            this.txtSoTinChi.TabIndex = 5;
            this.txtSoTinChi.TextChanged += new System.EventHandler(this.txtSoTinChi_TextChanged);
            // 
            // txtMaHP
            // 
            this.txtMaHP.Location = new System.Drawing.Point(465, 85);
            this.txtMaHP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaHP.Name = "txtMaHP";
            this.txtMaHP.Size = new System.Drawing.Size(223, 26);
            this.txtMaHP.TabIndex = 4;
            // 
            // lblSoTinChi
            // 
            this.lblSoTinChi.AutoSize = true;
            this.lblSoTinChi.Location = new System.Drawing.Point(1142, 89);
            this.lblSoTinChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoTinChi.Name = "lblSoTinChi";
            this.lblSoTinChi.Size = new System.Drawing.Size(81, 20);
            this.lblSoTinChi.TabIndex = 3;
            this.lblSoTinChi.Text = "Số Tín Chỉ";
            // 
            // lblTenHP
            // 
            this.lblTenHP.AutoSize = true;
            this.lblTenHP.Location = new System.Drawing.Point(750, 89);
            this.lblTenHP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenHP.Name = "lblTenHP";
            this.lblTenHP.Size = new System.Drawing.Size(62, 20);
            this.lblTenHP.TabIndex = 2;
            this.lblTenHP.Text = "Tên HP";
            // 
            // lblMaHP
            // 
            this.lblMaHP.AutoSize = true;
            this.lblMaHP.Location = new System.Drawing.Point(388, 89);
            this.lblMaHP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaHP.Name = "lblMaHP";
            this.lblMaHP.Size = new System.Drawing.Size(57, 20);
            this.lblMaHP.TabIndex = 1;
            this.lblMaHP.Text = "Mã HP";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvHocPhan);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(4, 274);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1746, 677);
            this.panel4.TabIndex = 0;
            // 
            // dgvHocPhan
            // 
            this.dgvHocPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocPhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHocPhan.Location = new System.Drawing.Point(0, 0);
            this.dgvHocPhan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvHocPhan.Name = "dgvHocPhan";
            this.dgvHocPhan.RowHeadersWidth = 62;
            this.dgvHocPhan.Size = new System.Drawing.Size(1746, 677);
            this.dgvHocPhan.TabIndex = 0;
            // 
            // tabBaoCao
            // 
            this.tabBaoCao.Controls.Add(this.btnTaiDuLieu);
            this.tabBaoCao.Controls.Add(this.dgvBaoCao);
            this.tabBaoCao.Controls.Add(this.btnXuatExcel);
            this.tabBaoCao.Location = new System.Drawing.Point(4, 29);
            this.tabBaoCao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabBaoCao.Name = "tabBaoCao";
            this.tabBaoCao.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabBaoCao.Size = new System.Drawing.Size(1754, 956);
            this.tabBaoCao.TabIndex = 4;
            this.tabBaoCao.Text = "Báo Cáo";
            this.tabBaoCao.UseVisualStyleBackColor = true;
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Location = new System.Drawing.Point(986, 68);
            this.btnXuatExcel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(159, 49);
            this.btnXuatExcel.TabIndex = 3;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // dgvBaoCao
            // 
            this.dgvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCao.Location = new System.Drawing.Point(3, 143);
            this.dgvBaoCao.Name = "dgvBaoCao";
            this.dgvBaoCao.RowHeadersWidth = 62;
            this.dgvBaoCao.RowTemplate.Height = 28;
            this.dgvBaoCao.Size = new System.Drawing.Size(1751, 805);
            this.dgvBaoCao.TabIndex = 4;
            this.dgvBaoCao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnTaiDuLieu
            // 
            this.btnTaiDuLieu.Location = new System.Drawing.Point(742, 68);
            this.btnTaiDuLieu.Name = "btnTaiDuLieu";
            this.btnTaiDuLieu.Size = new System.Drawing.Size(159, 49);
            this.btnTaiDuLieu.TabIndex = 5;
            this.btnTaiDuLieu.Text = "Tải Lên";
            this.btnTaiDuLieu.UseVisualStyleBackColor = true;
            this.btnTaiDuLieu.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabDangXuatAD
            // 
            this.tabDangXuatAD.Location = new System.Drawing.Point(4, 29);
            this.tabDangXuatAD.Name = "tabDangXuatAD";
            this.tabDangXuatAD.Padding = new System.Windows.Forms.Padding(3);
            this.tabDangXuatAD.Size = new System.Drawing.Size(1754, 956);
            this.tabDangXuatAD.TabIndex = 5;
            this.tabDangXuatAD.Text = "Đăng xuất";
            this.tabDangXuatAD.UseVisualStyleBackColor = true;
            this.tabDangXuatAD.Click += new System.EventHandler(this.tabDangXuatAD_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1762, 1050);
            this.Controls.Add(this.tabDangXuat);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.tabDangXuat.ResumeLayout(false);
            this.tabQLTK.ResumeLayout(false);
            this.tabQLTK.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.tabQLSV.ResumeLayout(false);
            this.tabQLSV.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.tabQLGV.ResumeLayout(false);
            this.tabQLGV.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiangVien)).EndInit();
            this.tabHocPhan.ResumeLayout(false);
            this.tabHocPhan.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocPhan)).EndInit();
            this.tabBaoCao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            this.ResumeLayout(false);

        }

        private void btnTaiLaiSV1_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.TabControl tabDangXuat;
        private System.Windows.Forms.TabPage tabQLTK;
        private System.Windows.Forms.ComboBox cboVaiTro;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label lblVaiTro;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabQLSV;
        private System.Windows.Forms.TabPage tabQLGV;
        private System.Windows.Forms.TabPage tabHocPhan;
        private System.Windows.Forms.TabPage tabBaoCao;
        private System.Windows.Forms.Button btnTaiLaiTK;
        private System.Windows.Forms.Button btnThemTK;
        private System.Windows.Forms.Button btnXoaTK;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Label lblTenSV;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Label lblNamThu;
        private System.Windows.Forms.Label lblKhoaHoc;
        private System.Windows.Forms.TextBox txtKhoaHoc;
        private System.Windows.Forms.TextBox txtNamThu;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Button btnXoaSV;
        private System.Windows.Forms.Button btnSuaSV;
        private System.Windows.Forms.Button btnThemSV;
        private System.Windows.Forms.Button btnTaiLaiSV;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvGiangVien;
        private System.Windows.Forms.Label lblMaGV;
        private System.Windows.Forms.Label lblTenGV;
        private System.Windows.Forms.Label lblGT;
        private System.Windows.Forms.Label lblDC;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnTaiLaiGV;
        private System.Windows.Forms.Button btnXoaGV;
        private System.Windows.Forms.Button btnSuaGV;
        private System.Windows.Forms.Button btnThemGV;
        private System.Windows.Forms.TextBox txtMaKhoaGV;
        private System.Windows.Forms.TextBox txtDiaChiGV;
        private System.Windows.Forms.TextBox txtHoTenGV;
        private System.Windows.Forms.TextBox txtEmailGV;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.ComboBox cboGioiTinhGV;
        private System.Windows.Forms.Label lblMaKhoa;
        private System.Windows.Forms.ComboBox cboGioiTinhSV;
        private System.Windows.Forms.TextBox txtTenHP;
        private System.Windows.Forms.TextBox txtSoTinChi;
        private System.Windows.Forms.TextBox txtMaHP;
        private System.Windows.Forms.Label lblSoTinChi;
        private System.Windows.Forms.Label lblTenHP;
        private System.Windows.Forms.Label lblMaHP;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvHocPhan;
        private System.Windows.Forms.Button btnTaiLaiHP;
        private System.Windows.Forms.Button btnXoaHP;
        private System.Windows.Forms.Button btnThemHP;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.DataGridView dgvBaoCao;
        private System.Windows.Forms.Button btnTaiDuLieu;
        private System.Windows.Forms.TabPage tabDangXuatAD;
    }
}