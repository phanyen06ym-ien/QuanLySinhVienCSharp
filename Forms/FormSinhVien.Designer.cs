namespace QuanLySinhVien
{
    partial class FormSinhVien
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
            this.tabDangXuatSV = new System.Windows.Forms.TabControl();
            this.tabTTCNSV = new System.Windows.Forms.TabPage();
            this.grbHSSV = new System.Windows.Forms.GroupBox();
            this.lblKH = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblML = new System.Windows.Forms.Label();
            this.lblDC = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblGT = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblMSV = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNamThu = new System.Windows.Forms.Label();
            this.lblKhoaHoc = new System.Windows.Forms.Label();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblTenSV = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.tabDKHP = new System.Windows.Forms.TabPage();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.cboMaHP = new System.Windows.Forms.ComboBox();
            this.lblMaHP = new System.Windows.Forms.Label();
            this.cboHocKy = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDangKy = new System.Windows.Forms.DataGridView();
            this.txtNamHoc = new System.Windows.Forms.TextBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.lblNamHoc = new System.Windows.Forms.Label();
            this.tabKQHT = new System.Windows.Forms.TabPage();
            this.btnLamMoi0 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabDangXuatSV.SuspendLayout();
            this.tabTTCNSV.SuspendLayout();
            this.grbHSSV.SuspendLayout();
            this.tabDKHP.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangKy)).BeginInit();
            this.tabKQHT.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDangXuatSV
            // 
            this.tabDangXuatSV.Controls.Add(this.tabTTCNSV);
            this.tabDangXuatSV.Controls.Add(this.tabDKHP);
            this.tabDangXuatSV.Controls.Add(this.tabKQHT);
            this.tabDangXuatSV.Controls.Add(this.tabPage1);
            this.tabDangXuatSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabDangXuatSV.Location = new System.Drawing.Point(0, 0);
            this.tabDangXuatSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabDangXuatSV.Name = "tabDangXuatSV";
            this.tabDangXuatSV.SelectedIndex = 0;
            this.tabDangXuatSV.Size = new System.Drawing.Size(1749, 934);
            this.tabDangXuatSV.TabIndex = 0;
            this.tabDangXuatSV.SelectedIndexChanged += new System.EventHandler(this.tabDangXuatSV_SelectedIndexChanged);
            // 
            // tabTTCNSV
            // 
            this.tabTTCNSV.Controls.Add(this.grbHSSV);
            this.tabTTCNSV.Location = new System.Drawing.Point(4, 29);
            this.tabTTCNSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabTTCNSV.Name = "tabTTCNSV";
            this.tabTTCNSV.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabTTCNSV.Size = new System.Drawing.Size(1741, 901);
            this.tabTTCNSV.TabIndex = 0;
            this.tabTTCNSV.Text = "Thông Tin Cá Nhân";
            this.tabTTCNSV.UseVisualStyleBackColor = true;
            this.tabTTCNSV.Click += new System.EventHandler(this.tabTTCNSV_Click);
            // 
            // grbHSSV
            // 
            this.grbHSSV.Controls.Add(this.lblKH);
            this.grbHSSV.Controls.Add(this.lblYear);
            this.grbHSSV.Controls.Add(this.lblML);
            this.grbHSSV.Controls.Add(this.lblDC);
            this.grbHSSV.Controls.Add(this.lblNumber);
            this.grbHSSV.Controls.Add(this.lblGT);
            this.grbHSSV.Controls.Add(this.lblDate);
            this.grbHSSV.Controls.Add(this.lblMSV);
            this.grbHSSV.Controls.Add(this.lblHoTen);
            this.grbHSSV.Controls.Add(this.lblDiaChi);
            this.grbHSSV.Controls.Add(this.lblGioiTinh);
            this.grbHSSV.Controls.Add(this.lblNamThu);
            this.grbHSSV.Controls.Add(this.lblKhoaHoc);
            this.grbHSSV.Controls.Add(this.lblMaLop);
            this.grbHSSV.Controls.Add(this.lblSDT);
            this.grbHSSV.Controls.Add(this.lblNgaySinh);
            this.grbHSSV.Controls.Add(this.lblTenSV);
            this.grbHSSV.Controls.Add(this.lblMaSV);
            this.grbHSSV.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbHSSV.Location = new System.Drawing.Point(86, 77);
            this.grbHSSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbHSSV.Name = "grbHSSV";
            this.grbHSSV.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbHSSV.Size = new System.Drawing.Size(1539, 725);
            this.grbHSSV.TabIndex = 0;
            this.grbHSSV.TabStop = false;
            this.grbHSSV.Text = "Hồ Sơ Sinh Viên";
            this.grbHSSV.Enter += new System.EventHandler(this.grbHSSV_Enter);
            // 
            // lblKH
            // 
            this.lblKH.AutoSize = true;
            this.lblKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKH.Location = new System.Drawing.Point(362, 662);
            this.lblKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKH.Name = "lblKH";
            this.lblKH.Size = new System.Drawing.Size(104, 32);
            this.lblKH.TabIndex = 18;
            this.lblKH.Text = "..................";
            this.lblKH.Click += new System.EventHandler(this.lblKH_Click);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(362, 588);
            this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(104, 32);
            this.lblYear.TabIndex = 17;
            this.lblYear.Text = "..................";
            this.lblYear.Click += new System.EventHandler(this.lblYear_Click);
            // 
            // lblML
            // 
            this.lblML.AutoSize = true;
            this.lblML.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblML.Location = new System.Drawing.Point(362, 515);
            this.lblML.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblML.Name = "lblML";
            this.lblML.Size = new System.Drawing.Size(104, 32);
            this.lblML.TabIndex = 16;
            this.lblML.Text = "..................";
            this.lblML.Click += new System.EventHandler(this.lblML_Click);
            // 
            // lblDC
            // 
            this.lblDC.AutoSize = true;
            this.lblDC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDC.Location = new System.Drawing.Point(362, 437);
            this.lblDC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDC.Name = "lblDC";
            this.lblDC.Size = new System.Drawing.Size(104, 32);
            this.lblDC.TabIndex = 15;
            this.lblDC.Text = "..................";
            this.lblDC.Click += new System.EventHandler(this.lblDC_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(362, 368);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(104, 32);
            this.lblNumber.TabIndex = 14;
            this.lblNumber.Text = "..................";
            this.lblNumber.Click += new System.EventHandler(this.lblNumber_Click);
            // 
            // lblGT
            // 
            this.lblGT.AutoSize = true;
            this.lblGT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGT.Location = new System.Drawing.Point(362, 295);
            this.lblGT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGT.Name = "lblGT";
            this.lblGT.Size = new System.Drawing.Size(104, 32);
            this.lblGT.TabIndex = 13;
            this.lblGT.Text = "..................";
            this.lblGT.Click += new System.EventHandler(this.lblGT_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(362, 214);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(104, 32);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "..................";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // lblMSV
            // 
            this.lblMSV.AutoSize = true;
            this.lblMSV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMSV.Location = new System.Drawing.Point(362, 68);
            this.lblMSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMSV.Name = "lblMSV";
            this.lblMSV.Size = new System.Drawing.Size(104, 32);
            this.lblMSV.TabIndex = 11;
            this.lblMSV.Text = "..................";
            this.lblMSV.Click += new System.EventHandler(this.lblMSV_Click);
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(362, 145);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(104, 32);
            this.lblHoTen.TabIndex = 10;
            this.lblHoTen.Text = "..................";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(46, 437);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(91, 32);
            this.lblDiaChi.TabIndex = 8;
            this.lblDiaChi.Text = "Địa Chỉ";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(46, 295);
            this.lblGioiTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(110, 32);
            this.lblGioiTinh.TabIndex = 7;
            this.lblGioiTinh.Text = "Giới Tính";
            // 
            // lblNamThu
            // 
            this.lblNamThu.AutoSize = true;
            this.lblNamThu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamThu.Location = new System.Drawing.Point(44, 588);
            this.lblNamThu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNamThu.Name = "lblNamThu";
            this.lblNamThu.Size = new System.Drawing.Size(113, 32);
            this.lblNamThu.TabIndex = 6;
            this.lblNamThu.Text = "Năm Thứ";
            // 
            // lblKhoaHoc
            // 
            this.lblKhoaHoc.AutoSize = true;
            this.lblKhoaHoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhoaHoc.Location = new System.Drawing.Point(44, 662);
            this.lblKhoaHoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKhoaHoc.Name = "lblKhoaHoc";
            this.lblKhoaHoc.Size = new System.Drawing.Size(117, 32);
            this.lblKhoaHoc.TabIndex = 5;
            this.lblKhoaHoc.Text = "Khóa Học";
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLop.Location = new System.Drawing.Point(46, 515);
            this.lblMaLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(94, 32);
            this.lblMaLop.TabIndex = 4;
            this.lblMaLop.Text = "Mã Lớp";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(46, 368);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(164, 32);
            this.lblSDT.TabIndex = 3;
            this.lblSDT.Text = "Số Điện Thoại";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(44, 214);
            this.lblNgaySinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(124, 32);
            this.lblNgaySinh.TabIndex = 2;
            this.lblNgaySinh.Text = "Ngày Sinh";
            // 
            // lblTenSV
            // 
            this.lblTenSV.AutoSize = true;
            this.lblTenSV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSV.Location = new System.Drawing.Point(44, 145);
            this.lblTenSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenSV.Name = "lblTenSV";
            this.lblTenSV.Size = new System.Drawing.Size(97, 32);
            this.lblTenSV.TabIndex = 1;
            this.lblTenSV.Text = "Họ Tên ";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSV.Location = new System.Drawing.Point(46, 68);
            this.lblMaSV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(157, 32);
            this.lblMaSV.TabIndex = 0;
            this.lblMaSV.Text = "Mã Sinh Viên";
            // 
            // tabDKHP
            // 
            this.tabDKHP.Controls.Add(this.btnDangKy);
            this.tabDKHP.Controls.Add(this.cboMaHP);
            this.tabDKHP.Controls.Add(this.lblMaHP);
            this.tabDKHP.Controls.Add(this.cboHocKy);
            this.tabDKHP.Controls.Add(this.panel1);
            this.tabDKHP.Controls.Add(this.txtNamHoc);
            this.tabDKHP.Controls.Add(this.btnLamMoi);
            this.tabDKHP.Controls.Add(this.lblHocKy);
            this.tabDKHP.Controls.Add(this.lblNamHoc);
            this.tabDKHP.Location = new System.Drawing.Point(4, 29);
            this.tabDKHP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabDKHP.Name = "tabDKHP";
            this.tabDKHP.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabDKHP.Size = new System.Drawing.Size(1741, 901);
            this.tabDKHP.TabIndex = 1;
            this.tabDKHP.Text = "Đăng Ký Học Phần";
            this.tabDKHP.UseVisualStyleBackColor = true;
            this.tabDKHP.Click += new System.EventHandler(this.tabDKHP_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.Location = new System.Drawing.Point(1040, 18);
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(182, 54);
            this.btnDangKy.TabIndex = 10;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // cboMaHP
            // 
            this.cboMaHP.FormattingEnabled = true;
            this.cboMaHP.Location = new System.Drawing.Point(124, 26);
            this.cboMaHP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboMaHP.Name = "cboMaHP";
            this.cboMaHP.Size = new System.Drawing.Size(180, 28);
            this.cboMaHP.TabIndex = 9;
            // 
            // lblMaHP
            // 
            this.lblMaHP.AutoSize = true;
            this.lblMaHP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHP.Location = new System.Drawing.Point(32, 26);
            this.lblMaHP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaHP.Name = "lblMaHP";
            this.lblMaHP.Size = new System.Drawing.Size(85, 32);
            this.lblMaHP.TabIndex = 8;
            this.lblMaHP.Text = "Mã HP";
            // 
            // cboHocKy
            // 
            this.cboHocKy.FormattingEnabled = true;
            this.cboHocKy.Location = new System.Drawing.Point(464, 29);
            this.cboHocKy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(180, 28);
            this.cboHocKy.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvDangKy);
            this.panel1.Location = new System.Drawing.Point(12, 77);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1713, 732);
            this.panel1.TabIndex = 6;
            // 
            // dgvDangKy
            // 
            this.dgvDangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDangKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDangKy.Location = new System.Drawing.Point(0, 0);
            this.dgvDangKy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDangKy.Name = "dgvDangKy";
            this.dgvDangKy.RowHeadersWidth = 62;
            this.dgvDangKy.Size = new System.Drawing.Size(1713, 732);
            this.dgvDangKy.TabIndex = 0;
            this.dgvDangKy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.Location = new System.Drawing.Point(844, 29);
            this.txtNamHoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.Size = new System.Drawing.Size(148, 26);
            this.txtNamHoc.TabIndex = 7;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(759, 834);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(182, 45);
            this.btnLamMoi.TabIndex = 2;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblHocKy
            // 
            this.lblHocKy.AutoSize = true;
            this.lblHocKy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHocKy.Location = new System.Drawing.Point(350, 25);
            this.lblHocKy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHocKy.Name = "lblHocKy";
            this.lblHocKy.Size = new System.Drawing.Size(88, 32);
            this.lblHocKy.TabIndex = 5;
            this.lblHocKy.Text = "Học Kỳ";
            // 
            // lblNamHoc
            // 
            this.lblNamHoc.AutoSize = true;
            this.lblNamHoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamHoc.Location = new System.Drawing.Point(708, 26);
            this.lblNamHoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNamHoc.Name = "lblNamHoc";
            this.lblNamHoc.Size = new System.Drawing.Size(114, 32);
            this.lblNamHoc.TabIndex = 4;
            this.lblNamHoc.Text = "Năm Học";
            // 
            // tabKQHT
            // 
            this.tabKQHT.Controls.Add(this.btnLamMoi0);
            this.tabKQHT.Controls.Add(this.panel2);
            this.tabKQHT.Location = new System.Drawing.Point(4, 29);
            this.tabKQHT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabKQHT.Name = "tabKQHT";
            this.tabKQHT.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabKQHT.Size = new System.Drawing.Size(1741, 901);
            this.tabKQHT.TabIndex = 2;
            this.tabKQHT.Text = "Kết Quả Học Tập";
            this.tabKQHT.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi0
            // 
            this.btnLamMoi0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi0.Location = new System.Drawing.Point(770, 834);
            this.btnLamMoi0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLamMoi0.Name = "btnLamMoi0";
            this.btnLamMoi0.Size = new System.Drawing.Size(182, 51);
            this.btnLamMoi0.TabIndex = 2;
            this.btnLamMoi0.Text = "Làm Mới";
            this.btnLamMoi0.UseVisualStyleBackColor = true;
            this.btnLamMoi0.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvKetQua);
            this.panel2.Location = new System.Drawing.Point(-6, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1734, 825);
            this.panel2.TabIndex = 0;
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKetQua.Location = new System.Drawing.Point(0, 0);
            this.dgvKetQua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.RowHeadersWidth = 62;
            this.dgvKetQua.Size = new System.Drawing.Size(1734, 825);
            this.dgvKetQua.TabIndex = 0;
            this.dgvKetQua.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKetQua_CellContentClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1741, 901);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Đăng Xuất";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // FormSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1749, 1050);
            this.Controls.Add(this.tabDangXuatSV);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormSinhVien";
            this.Text = "FormSinhVien";
            this.Load += new System.EventHandler(this.FormSinhVien_Load);
            this.tabDangXuatSV.ResumeLayout(false);
            this.tabTTCNSV.ResumeLayout(false);
            this.grbHSSV.ResumeLayout(false);
            this.grbHSSV.PerformLayout();
            this.tabDKHP.ResumeLayout(false);
            this.tabDKHP.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangKy)).EndInit();
            this.tabKQHT.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDangXuatSV;
        private System.Windows.Forms.TabPage tabTTCNSV;
        private System.Windows.Forms.TabPage tabDKHP;
        private System.Windows.Forms.TabPage tabKQHT;
        private System.Windows.Forms.GroupBox grbHSSV;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblNamThu;
        private System.Windows.Forms.Label lblKhoaHoc;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblTenSV;
        private System.Windows.Forms.Label lblKH;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblML;
        private System.Windows.Forms.Label lblDC;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblGT;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblMSV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboHocKy;
        private System.Windows.Forms.TextBox txtNamHoc;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.Label lblNamHoc;
        private System.Windows.Forms.Button btnLamMoi0;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.ComboBox cboMaHP;
        private System.Windows.Forms.Label lblMaHP;
        private System.Windows.Forms.DataGridView dgvDangKy;
        private System.Windows.Forms.TabPage tabPage1;
    }
}