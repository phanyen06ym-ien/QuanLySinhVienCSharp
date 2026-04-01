namespace QuanLySinhVienCSharp.Forms
{
    partial class FormGiangVien
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
            this.tabDangXuatGV = new System.Windows.Forms.TabControl();
            this.tabTTCNGV = new System.Windows.Forms.TabPage();
            this.grbHSGV = new System.Windows.Forms.GroupBox();
            this.lblMaKhoa = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblMGV = new System.Windows.Forms.Label();
            this.lblNameGV = new System.Windows.Forms.Label();
            this.lblDiaChiGV = new System.Windows.Forms.Label();
            this.lblGioiTinhGV = new System.Windows.Forms.Label();
            this.lblMaKhoaGV = new System.Windows.Forms.Label();
            this.lblEmailGV = new System.Windows.Forms.Label();
            this.lblTenGV = new System.Windows.Forms.Label();
            this.lblMaGV = new System.Windows.Forms.Label();
            this.tabLopPhuTrach = new System.Windows.Forms.TabPage();
            this.btnXemDSLop = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.tabNhap_Sua_Diem = new System.Windows.Forms.TabPage();
            this.txtHoTenSV = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblHoTenSV = new System.Windows.Forms.Label();
            this.txtCK = new System.Windows.Forms.TextBox();
            this.txtBT = new System.Windows.Forms.TextBox();
            this.txtNamHoc = new System.Windows.Forms.TextBox();
            this.txtMaHP = new System.Windows.Forms.TextBox();
            this.txtGK = new System.Windows.Forms.TextBox();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.cboHocKy = new System.Windows.Forms.ComboBox();
            this.lblCK = new System.Windows.Forms.Label();
            this.lblBT = new System.Windows.Forms.Label();
            this.lblNamHoc = new System.Windows.Forms.Label();
            this.lblMaHP = new System.Windows.Forms.Label();
            this.lblGK = new System.Windows.Forms.Label();
            this.lblCC = new System.Windows.Forms.Label();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.btnLuuDiem = new System.Windows.Forms.Button();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabDangXuatGV.SuspendLayout();
            this.tabTTCNGV.SuspendLayout();
            this.grbHSGV.SuspendLayout();
            this.tabLopPhuTrach.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.tabNhap_Sua_Diem.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDangXuatGV
            // 
            this.tabDangXuatGV.Controls.Add(this.tabTTCNGV);
            this.tabDangXuatGV.Controls.Add(this.tabLopPhuTrach);
            this.tabDangXuatGV.Controls.Add(this.tabNhap_Sua_Diem);
            this.tabDangXuatGV.Controls.Add(this.tabPage1);
            this.tabDangXuatGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabDangXuatGV.Location = new System.Drawing.Point(0, 0);
            this.tabDangXuatGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabDangXuatGV.Name = "tabDangXuatGV";
            this.tabDangXuatGV.SelectedIndex = 0;
            this.tabDangXuatGV.Size = new System.Drawing.Size(1749, 988);
            this.tabDangXuatGV.TabIndex = 0;
            this.tabDangXuatGV.SelectedIndexChanged += new System.EventHandler(this.tabDangXuatGV_SelectedIndexChanged);
            // 
            // tabTTCNGV
            // 
            this.tabTTCNGV.Controls.Add(this.grbHSGV);
            this.tabTTCNGV.Location = new System.Drawing.Point(4, 29);
            this.tabTTCNGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabTTCNGV.Name = "tabTTCNGV";
            this.tabTTCNGV.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabTTCNGV.Size = new System.Drawing.Size(1741, 955);
            this.tabTTCNGV.TabIndex = 0;
            this.tabTTCNGV.Text = "Thông TIn Cá Nhân";
            this.tabTTCNGV.UseVisualStyleBackColor = true;
            // 
            // grbHSGV
            // 
            this.grbHSGV.Controls.Add(this.lblMaKhoa);
            this.grbHSGV.Controls.Add(this.lblDiaChi);
            this.grbHSGV.Controls.Add(this.lblEmail);
            this.grbHSGV.Controls.Add(this.lblGioiTinh);
            this.grbHSGV.Controls.Add(this.lblMGV);
            this.grbHSGV.Controls.Add(this.lblNameGV);
            this.grbHSGV.Controls.Add(this.lblDiaChiGV);
            this.grbHSGV.Controls.Add(this.lblGioiTinhGV);
            this.grbHSGV.Controls.Add(this.lblMaKhoaGV);
            this.grbHSGV.Controls.Add(this.lblEmailGV);
            this.grbHSGV.Controls.Add(this.lblTenGV);
            this.grbHSGV.Controls.Add(this.lblMaGV);
            this.grbHSGV.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbHSGV.Location = new System.Drawing.Point(99, 112);
            this.grbHSGV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbHSGV.Name = "grbHSGV";
            this.grbHSGV.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbHSGV.Size = new System.Drawing.Size(1539, 725);
            this.grbHSGV.TabIndex = 1;
            this.grbHSGV.TabStop = false;
            this.grbHSGV.Text = "Hồ Sơ Giảng Viên";
            this.grbHSGV.Enter += new System.EventHandler(this.grbHSGV_Enter);
            // 
            // lblMaKhoa
            // 
            this.lblMaKhoa.AutoSize = true;
            this.lblMaKhoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKhoa.Location = new System.Drawing.Point(362, 662);
            this.lblMaKhoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaKhoa.Name = "lblMaKhoa";
            this.lblMaKhoa.Size = new System.Drawing.Size(104, 32);
            this.lblMaKhoa.TabIndex = 18;
            this.lblMaKhoa.Text = "..................";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(362, 420);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(104, 32);
            this.lblDiaChi.TabIndex = 15;
            this.lblDiaChi.Text = "..................";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(362, 534);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(104, 32);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "..................";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(362, 295);
            this.lblGioiTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(104, 32);
            this.lblGioiTinh.TabIndex = 13;
            this.lblGioiTinh.Text = "..................";
            // 
            // lblMGV
            // 
            this.lblMGV.AutoSize = true;
            this.lblMGV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMGV.Location = new System.Drawing.Point(362, 68);
            this.lblMGV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMGV.Name = "lblMGV";
            this.lblMGV.Size = new System.Drawing.Size(104, 32);
            this.lblMGV.TabIndex = 11;
            this.lblMGV.Text = "..................";
            // 
            // lblNameGV
            // 
            this.lblNameGV.AutoSize = true;
            this.lblNameGV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameGV.Location = new System.Drawing.Point(362, 185);
            this.lblNameGV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameGV.Name = "lblNameGV";
            this.lblNameGV.Size = new System.Drawing.Size(104, 32);
            this.lblNameGV.TabIndex = 10;
            this.lblNameGV.Text = "..................";
            // 
            // lblDiaChiGV
            // 
            this.lblDiaChiGV.AutoSize = true;
            this.lblDiaChiGV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChiGV.Location = new System.Drawing.Point(44, 420);
            this.lblDiaChiGV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiaChiGV.Name = "lblDiaChiGV";
            this.lblDiaChiGV.Size = new System.Drawing.Size(91, 32);
            this.lblDiaChiGV.TabIndex = 8;
            this.lblDiaChiGV.Text = "Địa Chỉ";
            // 
            // lblGioiTinhGV
            // 
            this.lblGioiTinhGV.AutoSize = true;
            this.lblGioiTinhGV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinhGV.Location = new System.Drawing.Point(46, 295);
            this.lblGioiTinhGV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGioiTinhGV.Name = "lblGioiTinhGV";
            this.lblGioiTinhGV.Size = new System.Drawing.Size(110, 32);
            this.lblGioiTinhGV.TabIndex = 7;
            this.lblGioiTinhGV.Text = "Giới Tính";
            // 
            // lblMaKhoaGV
            // 
            this.lblMaKhoaGV.AutoSize = true;
            this.lblMaKhoaGV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKhoaGV.Location = new System.Drawing.Point(44, 662);
            this.lblMaKhoaGV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaKhoaGV.Name = "lblMaKhoaGV";
            this.lblMaKhoaGV.Size = new System.Drawing.Size(109, 32);
            this.lblMaKhoaGV.TabIndex = 5;
            this.lblMaKhoaGV.Text = "Mã Khoa";
            // 
            // lblEmailGV
            // 
            this.lblEmailGV.AutoSize = true;
            this.lblEmailGV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailGV.Location = new System.Drawing.Point(46, 534);
            this.lblEmailGV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailGV.Name = "lblEmailGV";
            this.lblEmailGV.Size = new System.Drawing.Size(71, 32);
            this.lblEmailGV.TabIndex = 3;
            this.lblEmailGV.Text = "Email";
            // 
            // lblTenGV
            // 
            this.lblTenGV.AutoSize = true;
            this.lblTenGV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenGV.Location = new System.Drawing.Point(46, 185);
            this.lblTenGV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenGV.Name = "lblTenGV";
            this.lblTenGV.Size = new System.Drawing.Size(97, 32);
            this.lblTenGV.TabIndex = 1;
            this.lblTenGV.Text = "Họ Tên ";
            // 
            // lblMaGV
            // 
            this.lblMaGV.AutoSize = true;
            this.lblMaGV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaGV.Location = new System.Drawing.Point(46, 68);
            this.lblMaGV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaGV.Name = "lblMaGV";
            this.lblMaGV.Size = new System.Drawing.Size(172, 32);
            this.lblMaGV.TabIndex = 0;
            this.lblMaGV.Text = "Mã Giảng Viên";
            // 
            // tabLopPhuTrach
            // 
            this.tabLopPhuTrach.Controls.Add(this.btnXemDSLop);
            this.tabLopPhuTrach.Controls.Add(this.panel1);
            this.tabLopPhuTrach.Location = new System.Drawing.Point(4, 29);
            this.tabLopPhuTrach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabLopPhuTrach.Name = "tabLopPhuTrach";
            this.tabLopPhuTrach.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabLopPhuTrach.Size = new System.Drawing.Size(1741, 955);
            this.tabLopPhuTrach.TabIndex = 1;
            this.tabLopPhuTrach.Text = "Lớp Phụ Trách";
            this.tabLopPhuTrach.UseVisualStyleBackColor = true;
            // 
            // btnXemDSLop
            // 
            this.btnXemDSLop.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDSLop.Location = new System.Drawing.Point(705, 880);
            this.btnXemDSLop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXemDSLop.Name = "btnXemDSLop";
            this.btnXemDSLop.Size = new System.Drawing.Size(344, 58);
            this.btnXemDSLop.TabIndex = 2;
            this.btnXemDSLop.Text = "Xem Danh Sách Lớp";
            this.btnXemDSLop.UseVisualStyleBackColor = true;
            this.btnXemDSLop.Click += new System.EventHandler(this.btnXemDSLop_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvLop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1733, 866);
            this.panel1.TabIndex = 0;
            // 
            // dgvLop
            // 
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLop.Location = new System.Drawing.Point(0, 0);
            this.dgvLop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.RowHeadersWidth = 62;
            this.dgvLop.Size = new System.Drawing.Size(1733, 866);
            this.dgvLop.TabIndex = 0;
            this.dgvLop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLop_CellContentClick);
            // 
            // tabNhap_Sua_Diem
            // 
            this.tabNhap_Sua_Diem.Controls.Add(this.txtHoTenSV);
            this.tabNhap_Sua_Diem.Controls.Add(this.btnXoa);
            this.tabNhap_Sua_Diem.Controls.Add(this.lblHoTenSV);
            this.tabNhap_Sua_Diem.Controls.Add(this.txtCK);
            this.tabNhap_Sua_Diem.Controls.Add(this.txtBT);
            this.tabNhap_Sua_Diem.Controls.Add(this.txtNamHoc);
            this.tabNhap_Sua_Diem.Controls.Add(this.txtMaHP);
            this.tabNhap_Sua_Diem.Controls.Add(this.txtGK);
            this.tabNhap_Sua_Diem.Controls.Add(this.txtCC);
            this.tabNhap_Sua_Diem.Controls.Add(this.txtMaSV);
            this.tabNhap_Sua_Diem.Controls.Add(this.cboHocKy);
            this.tabNhap_Sua_Diem.Controls.Add(this.lblCK);
            this.tabNhap_Sua_Diem.Controls.Add(this.lblBT);
            this.tabNhap_Sua_Diem.Controls.Add(this.lblNamHoc);
            this.tabNhap_Sua_Diem.Controls.Add(this.lblMaHP);
            this.tabNhap_Sua_Diem.Controls.Add(this.lblGK);
            this.tabNhap_Sua_Diem.Controls.Add(this.lblCC);
            this.tabNhap_Sua_Diem.Controls.Add(this.lblHocKy);
            this.tabNhap_Sua_Diem.Controls.Add(this.lblMaSV);
            this.tabNhap_Sua_Diem.Controls.Add(this.panel2);
            this.tabNhap_Sua_Diem.Controls.Add(this.btnLuuDiem);
            this.tabNhap_Sua_Diem.Controls.Add(this.btnTaiLai);
            this.tabNhap_Sua_Diem.Location = new System.Drawing.Point(4, 29);
            this.tabNhap_Sua_Diem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabNhap_Sua_Diem.Name = "tabNhap_Sua_Diem";
            this.tabNhap_Sua_Diem.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabNhap_Sua_Diem.Size = new System.Drawing.Size(1741, 955);
            this.tabNhap_Sua_Diem.TabIndex = 2;
            this.tabNhap_Sua_Diem.Text = "Nhập/Sửa Điểm";
            this.tabNhap_Sua_Diem.UseVisualStyleBackColor = true;
            this.tabNhap_Sua_Diem.Click += new System.EventHandler(this.tabNhap_Sua_Diem_Click);
            // 
            // txtHoTenSV
            // 
            this.txtHoTenSV.Location = new System.Drawing.Point(660, 52);
            this.txtHoTenSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHoTenSV.Name = "txtHoTenSV";
            this.txtHoTenSV.Size = new System.Drawing.Size(148, 26);
            this.txtHoTenSV.TabIndex = 23;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(635, 359);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(140, 37);
            this.btnXoa.TabIndex = 22;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblHoTenSV
            // 
            this.lblHoTenSV.AutoSize = true;
            this.lblHoTenSV.Location = new System.Drawing.Point(508, 57);
            this.lblHoTenSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoTenSV.Name = "lblHoTenSV";
            this.lblHoTenSV.Size = new System.Drawing.Size(65, 20);
            this.lblHoTenSV.TabIndex = 21;
            this.lblHoTenSV.Text = "Họ Tên ";
            // 
            // txtCK
            // 
            this.txtCK.Location = new System.Drawing.Point(1101, 251);
            this.txtCK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCK.Name = "txtCK";
            this.txtCK.Size = new System.Drawing.Size(148, 26);
            this.txtCK.TabIndex = 20;
            // 
            // txtBT
            // 
            this.txtBT.Location = new System.Drawing.Point(234, 240);
            this.txtBT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBT.Name = "txtBT";
            this.txtBT.Size = new System.Drawing.Size(148, 26);
            this.txtBT.TabIndex = 19;
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.Location = new System.Drawing.Point(660, 135);
            this.txtNamHoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.Size = new System.Drawing.Size(148, 26);
            this.txtNamHoc.TabIndex = 18;
            // 
            // txtMaHP
            // 
            this.txtMaHP.Location = new System.Drawing.Point(1101, 40);
            this.txtMaHP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaHP.Name = "txtMaHP";
            this.txtMaHP.Size = new System.Drawing.Size(148, 26);
            this.txtMaHP.TabIndex = 17;
            // 
            // txtGK
            // 
            this.txtGK.Location = new System.Drawing.Point(660, 240);
            this.txtGK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGK.Name = "txtGK";
            this.txtGK.Size = new System.Drawing.Size(148, 26);
            this.txtGK.TabIndex = 16;
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(1101, 151);
            this.txtCC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(148, 26);
            this.txtCC.TabIndex = 15;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(234, 52);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(148, 26);
            this.txtMaSV.TabIndex = 14;
            // 
            // cboHocKy
            // 
            this.cboHocKy.FormattingEnabled = true;
            this.cboHocKy.Location = new System.Drawing.Point(234, 138);
            this.cboHocKy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(180, 28);
            this.cboHocKy.TabIndex = 13;
            // 
            // lblCK
            // 
            this.lblCK.AutoSize = true;
            this.lblCK.Location = new System.Drawing.Point(958, 251);
            this.lblCK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCK.Name = "lblCK";
            this.lblCK.Size = new System.Drawing.Size(72, 20);
            this.lblCK.TabIndex = 12;
            this.lblCK.Text = "CK(60%)";
            // 
            // lblBT
            // 
            this.lblBT.AutoSize = true;
            this.lblBT.Location = new System.Drawing.Point(68, 251);
            this.lblBT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBT.Name = "lblBT";
            this.lblBT.Size = new System.Drawing.Size(71, 20);
            this.lblBT.TabIndex = 11;
            this.lblBT.Text = "BT(15%)";
            // 
            // lblNamHoc
            // 
            this.lblNamHoc.AutoSize = true;
            this.lblNamHoc.Location = new System.Drawing.Point(508, 143);
            this.lblNamHoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNamHoc.Name = "lblNamHoc";
            this.lblNamHoc.Size = new System.Drawing.Size(75, 20);
            this.lblNamHoc.TabIndex = 10;
            this.lblNamHoc.Text = "Năm Hoc";
            // 
            // lblMaHP
            // 
            this.lblMaHP.AutoSize = true;
            this.lblMaHP.Location = new System.Drawing.Point(958, 51);
            this.lblMaHP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaHP.Name = "lblMaHP";
            this.lblMaHP.Size = new System.Drawing.Size(57, 20);
            this.lblMaHP.TabIndex = 9;
            this.lblMaHP.Text = "Mã HP";
            // 
            // lblGK
            // 
            this.lblGK.AutoSize = true;
            this.lblGK.Location = new System.Drawing.Point(508, 245);
            this.lblGK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGK.Name = "lblGK";
            this.lblGK.Size = new System.Drawing.Size(74, 20);
            this.lblGK.TabIndex = 8;
            this.lblGK.Text = "GK(20%)";
            // 
            // lblCC
            // 
            this.lblCC.AutoSize = true;
            this.lblCC.Location = new System.Drawing.Point(958, 151);
            this.lblCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCC.Name = "lblCC";
            this.lblCC.Size = new System.Drawing.Size(64, 20);
            this.lblCC.TabIndex = 7;
            this.lblCC.Text = "CC(5%)";
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Location = new System.Drawing.Point(68, 143);
            this.lblHocKy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(59, 20);
            this.lblHocKy.TabIndex = 6;
            this.lblHocKy.Text = "Học Kỳ";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(68, 57);
            this.lblMaSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(103, 20);
            this.lblMaSV.TabIndex = 5;
            this.lblMaSV.Text = "Mã Sinh Viên";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDiem);
            this.panel2.Location = new System.Drawing.Point(4, 409);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1732, 483);
            this.panel2.TabIndex = 4;
            // 
            // dgvDiem
            // 
            this.dgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDiem.Location = new System.Drawing.Point(0, 0);
            this.dgvDiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.RowHeadersWidth = 62;
            this.dgvDiem.Size = new System.Drawing.Size(1732, 483);
            this.dgvDiem.TabIndex = 1;
            // 
            // btnLuuDiem
            // 
            this.btnLuuDiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuDiem.Location = new System.Drawing.Point(813, 359);
            this.btnLuuDiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuuDiem.Name = "btnLuuDiem";
            this.btnLuuDiem.Size = new System.Drawing.Size(140, 37);
            this.btnLuuDiem.TabIndex = 3;
            this.btnLuuDiem.Text = "Lưu Điểm";
            this.btnLuuDiem.UseVisualStyleBackColor = true;
            this.btnLuuDiem.Click += new System.EventHandler(this.btnLuuDiem_Click);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiLai.Location = new System.Drawing.Point(984, 360);
            this.btnTaiLai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(140, 37);
            this.btnTaiLai.TabIndex = 2;
            this.btnTaiLai.Text = "Tải Lại";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1741, 955);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Đăng xuất";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // FormGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1749, 1050);
            this.Controls.Add(this.tabDangXuatGV);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormGiangVien";
            this.Text = "FormGiangVien";
            this.Load += new System.EventHandler(this.FormGiangVien_Load);
            this.tabDangXuatGV.ResumeLayout(false);
            this.tabTTCNGV.ResumeLayout(false);
            this.grbHSGV.ResumeLayout(false);
            this.grbHSGV.PerformLayout();
            this.tabLopPhuTrach.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.tabNhap_Sua_Diem.ResumeLayout(false);
            this.tabNhap_Sua_Diem.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDangXuatGV;
        private System.Windows.Forms.TabPage tabTTCNGV;
        private System.Windows.Forms.TabPage tabLopPhuTrach;
        private System.Windows.Forms.TabPage tabNhap_Sua_Diem;
        private System.Windows.Forms.GroupBox grbHSGV;
        private System.Windows.Forms.Label lblMaKhoa;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblMGV;
        private System.Windows.Forms.Label lblNameGV;
        private System.Windows.Forms.Label lblDiaChiGV;
        private System.Windows.Forms.Label lblGioiTinhGV;
        private System.Windows.Forms.Label lblMaKhoaGV;
        private System.Windows.Forms.Label lblEmailGV;
        private System.Windows.Forms.Label lblTenGV;
        private System.Windows.Forms.Label lblMaGV;
        private System.Windows.Forms.Button btnXemDSLop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvLop;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLuuDiem;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.TextBox txtCK;
        private System.Windows.Forms.TextBox txtBT;
        private System.Windows.Forms.TextBox txtNamHoc;
        private System.Windows.Forms.TextBox txtMaHP;
        private System.Windows.Forms.TextBox txtGK;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.ComboBox cboHocKy;
        private System.Windows.Forms.Label lblCK;
        private System.Windows.Forms.Label lblBT;
        private System.Windows.Forms.Label lblNamHoc;
        private System.Windows.Forms.Label lblMaHP;
        private System.Windows.Forms.Label lblGK;
        private System.Windows.Forms.Label lblCC;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.DataGridView dgvDiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblHoTenSV;
        private System.Windows.Forms.TextBox txtHoTenSV;
        private System.Windows.Forms.TabPage tabPage1;
    }
}