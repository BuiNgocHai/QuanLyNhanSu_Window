﻿namespace GUI.Phan_Thanh_Trung
{
    partial class frmQuanLyHoSo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyHoSo));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel12 = new Guna.UI.WinForms.GunaLabel();
            this.txbMaNV = new Guna.UI.WinForms.GunaTextBox();
            this.txbTenNV = new Guna.UI.WinForms.GunaTextBox();
            this.txbNgaySinh = new Guna.UI.WinForms.GunaTextBox();
            this.txbSoDT = new Guna.UI.WinForms.GunaTextBox();
            this.txbEmail = new Guna.UI.WinForms.GunaTextBox();
            this.txbNgayTD = new Guna.UI.WinForms.GunaTextBox();
            this.txbTaiKhoan = new Guna.UI.WinForms.GunaTextBox();
            this.txbMatKhau = new Guna.UI.WinForms.GunaTextBox();
            this.txbQuyen = new Guna.UI.WinForms.GunaTextBox();
            this.cbBoxGioiTinh = new Guna.UI.WinForms.GunaComboBox();
            this.cbBoxMaPB = new Guna.UI.WinForms.GunaComboBox();
            this.dtGridViewHoSo = new Guna.UI.WinForms.GunaDataGridView();
            this.MANV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SODT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAIKHOAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATKHAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUYEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNhapLai = new Guna.UI.WinForms.GunaButton();
            this.btnThoat = new Guna.UI.WinForms.GunaButton();
            this.btnXemHoSo = new Guna.UI.WinForms.GunaButton();
            this.btnTimKiemHoSo = new Guna.UI.WinForms.GunaButton();
            this.btnXoaHoSo = new Guna.UI.WinForms.GunaButton();
            this.btnSuaHoSo = new Guna.UI.WinForms.GunaButton();
            this.btnThemHoSo = new Guna.UI.WinForms.GunaButton();
            this.btnChuyenQTCT = new Guna.UI.WinForms.GunaButton();
            this.btnChuyenNVCV = new Guna.UI.WinForms.GunaButton();
            this.btnChuyenTDCM = new Guna.UI.WinForms.GunaButton();
            this.btnChuyenTDNN = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel13 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewHoSo)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(535, 11);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(299, 54);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Quản Lý Hồ Sơ";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(93, 101);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(102, 20);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Mã Nhân Viên";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(93, 161);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(104, 20);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "Tên Nhân Viên";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(93, 222);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(76, 20);
            this.gunaLabel4.TabIndex = 3;
            this.gunaLabel4.Text = "Ngày Sinh";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(93, 271);
            this.gunaLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(68, 20);
            this.gunaLabel5.TabIndex = 4;
            this.gunaLabel5.Text = "Giới Tính";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.Location = new System.Drawing.Point(93, 321);
            this.gunaLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(102, 20);
            this.gunaLabel6.TabIndex = 5;
            this.gunaLabel6.Text = "Số Điện Thoại";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel7.Location = new System.Drawing.Point(93, 362);
            this.gunaLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(46, 20);
            this.gunaLabel7.TabIndex = 6;
            this.gunaLabel7.Text = "Email";
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel8.Location = new System.Drawing.Point(629, 101);
            this.gunaLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(127, 20);
            this.gunaLabel8.TabIndex = 7;
            this.gunaLabel8.Text = "Ngày Tuyển Dụng";
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel9.Location = new System.Drawing.Point(629, 149);
            this.gunaLabel9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(107, 20);
            this.gunaLabel9.TabIndex = 8;
            this.gunaLabel9.Text = "Tên Phòng Ban";
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel10.Location = new System.Drawing.Point(629, 262);
            this.gunaLabel10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(72, 20);
            this.gunaLabel10.TabIndex = 9;
            this.gunaLabel10.Text = "Mật Khẩu";
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.AutoSize = true;
            this.gunaLabel11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel11.Location = new System.Drawing.Point(629, 203);
            this.gunaLabel11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(73, 20);
            this.gunaLabel11.TabIndex = 10;
            this.gunaLabel11.Text = "Tài Khoản";
            // 
            // gunaLabel12
            // 
            this.gunaLabel12.AutoSize = true;
            this.gunaLabel12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel12.Location = new System.Drawing.Point(629, 321);
            this.gunaLabel12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel12.Name = "gunaLabel12";
            this.gunaLabel12.Size = new System.Drawing.Size(51, 20);
            this.gunaLabel12.TabIndex = 11;
            this.gunaLabel12.Text = "Quyền";
            // 
            // txbMaNV
            // 
            this.txbMaNV.BaseColor = System.Drawing.Color.White;
            this.txbMaNV.BorderColor = System.Drawing.Color.Silver;
            this.txbMaNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbMaNV.FocusedBaseColor = System.Drawing.Color.White;
            this.txbMaNV.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txbMaNV.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txbMaNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbMaNV.Location = new System.Drawing.Point(237, 90);
            this.txbMaNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbMaNV.Name = "txbMaNV";
            this.txbMaNV.PasswordChar = '\0';
            this.txbMaNV.SelectedText = "";
            this.txbMaNV.Size = new System.Drawing.Size(319, 37);
            this.txbMaNV.TabIndex = 12;
            // 
            // txbTenNV
            // 
            this.txbTenNV.BaseColor = System.Drawing.Color.White;
            this.txbTenNV.BorderColor = System.Drawing.Color.Silver;
            this.txbTenNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTenNV.FocusedBaseColor = System.Drawing.Color.White;
            this.txbTenNV.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txbTenNV.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txbTenNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbTenNV.Location = new System.Drawing.Point(237, 150);
            this.txbTenNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbTenNV.Name = "txbTenNV";
            this.txbTenNV.PasswordChar = '\0';
            this.txbTenNV.SelectedText = "";
            this.txbTenNV.Size = new System.Drawing.Size(319, 37);
            this.txbTenNV.TabIndex = 13;
            // 
            // txbNgaySinh
            // 
            this.txbNgaySinh.BaseColor = System.Drawing.Color.White;
            this.txbNgaySinh.BorderColor = System.Drawing.Color.Silver;
            this.txbNgaySinh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNgaySinh.FocusedBaseColor = System.Drawing.Color.White;
            this.txbNgaySinh.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txbNgaySinh.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txbNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbNgaySinh.Location = new System.Drawing.Point(237, 210);
            this.txbNgaySinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbNgaySinh.Name = "txbNgaySinh";
            this.txbNgaySinh.PasswordChar = '\0';
            this.txbNgaySinh.SelectedText = "";
            this.txbNgaySinh.Size = new System.Drawing.Size(319, 37);
            this.txbNgaySinh.TabIndex = 14;
            // 
            // txbSoDT
            // 
            this.txbSoDT.BaseColor = System.Drawing.Color.White;
            this.txbSoDT.BorderColor = System.Drawing.Color.Silver;
            this.txbSoDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSoDT.FocusedBaseColor = System.Drawing.Color.White;
            this.txbSoDT.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txbSoDT.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txbSoDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbSoDT.Location = new System.Drawing.Point(237, 308);
            this.txbSoDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbSoDT.Name = "txbSoDT";
            this.txbSoDT.PasswordChar = '\0';
            this.txbSoDT.SelectedText = "";
            this.txbSoDT.Size = new System.Drawing.Size(319, 37);
            this.txbSoDT.TabIndex = 15;
            // 
            // txbEmail
            // 
            this.txbEmail.BaseColor = System.Drawing.Color.White;
            this.txbEmail.BorderColor = System.Drawing.Color.Silver;
            this.txbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbEmail.FocusedBaseColor = System.Drawing.Color.White;
            this.txbEmail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txbEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txbEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbEmail.Location = new System.Drawing.Point(237, 368);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.PasswordChar = '\0';
            this.txbEmail.SelectedText = "";
            this.txbEmail.Size = new System.Drawing.Size(319, 37);
            this.txbEmail.TabIndex = 16;
            // 
            // txbNgayTD
            // 
            this.txbNgayTD.BaseColor = System.Drawing.Color.White;
            this.txbNgayTD.BorderColor = System.Drawing.Color.Silver;
            this.txbNgayTD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNgayTD.FocusedBaseColor = System.Drawing.Color.White;
            this.txbNgayTD.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txbNgayTD.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txbNgayTD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbNgayTD.Location = new System.Drawing.Point(773, 90);
            this.txbNgayTD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbNgayTD.Name = "txbNgayTD";
            this.txbNgayTD.PasswordChar = '\0';
            this.txbNgayTD.SelectedText = "";
            this.txbNgayTD.Size = new System.Drawing.Size(319, 37);
            this.txbNgayTD.TabIndex = 17;
            // 
            // txbTaiKhoan
            // 
            this.txbTaiKhoan.BaseColor = System.Drawing.Color.White;
            this.txbTaiKhoan.BorderColor = System.Drawing.Color.Silver;
            this.txbTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTaiKhoan.FocusedBaseColor = System.Drawing.Color.White;
            this.txbTaiKhoan.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txbTaiKhoan.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txbTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbTaiKhoan.Location = new System.Drawing.Point(773, 191);
            this.txbTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbTaiKhoan.Name = "txbTaiKhoan";
            this.txbTaiKhoan.PasswordChar = '\0';
            this.txbTaiKhoan.SelectedText = "";
            this.txbTaiKhoan.Size = new System.Drawing.Size(319, 37);
            this.txbTaiKhoan.TabIndex = 18;
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.BaseColor = System.Drawing.Color.White;
            this.txbMatKhau.BorderColor = System.Drawing.Color.Silver;
            this.txbMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbMatKhau.FocusedBaseColor = System.Drawing.Color.White;
            this.txbMatKhau.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txbMatKhau.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txbMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbMatKhau.Location = new System.Drawing.Point(773, 251);
            this.txbMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.PasswordChar = '\0';
            this.txbMatKhau.SelectedText = "";
            this.txbMatKhau.Size = new System.Drawing.Size(319, 37);
            this.txbMatKhau.TabIndex = 19;
            // 
            // txbQuyen
            // 
            this.txbQuyen.BaseColor = System.Drawing.Color.White;
            this.txbQuyen.BorderColor = System.Drawing.Color.Silver;
            this.txbQuyen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbQuyen.FocusedBaseColor = System.Drawing.Color.White;
            this.txbQuyen.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txbQuyen.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txbQuyen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbQuyen.Location = new System.Drawing.Point(773, 311);
            this.txbQuyen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbQuyen.Name = "txbQuyen";
            this.txbQuyen.PasswordChar = '\0';
            this.txbQuyen.SelectedText = "";
            this.txbQuyen.Size = new System.Drawing.Size(319, 37);
            this.txbQuyen.TabIndex = 20;
            // 
            // cbBoxGioiTinh
            // 
            this.cbBoxGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.cbBoxGioiTinh.BaseColor = System.Drawing.Color.White;
            this.cbBoxGioiTinh.BorderColor = System.Drawing.Color.Silver;
            this.cbBoxGioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBoxGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxGioiTinh.FocusedColor = System.Drawing.Color.Empty;
            this.cbBoxGioiTinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbBoxGioiTinh.ForeColor = System.Drawing.Color.Black;
            this.cbBoxGioiTinh.FormattingEnabled = true;
            this.cbBoxGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbBoxGioiTinh.Location = new System.Drawing.Point(239, 261);
            this.cbBoxGioiTinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbBoxGioiTinh.Name = "cbBoxGioiTinh";
            this.cbBoxGioiTinh.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbBoxGioiTinh.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbBoxGioiTinh.Size = new System.Drawing.Size(169, 31);
            this.cbBoxGioiTinh.TabIndex = 21;
            // 
            // cbBoxMaPB
            // 
            this.cbBoxMaPB.BackColor = System.Drawing.Color.Transparent;
            this.cbBoxMaPB.BaseColor = System.Drawing.Color.White;
            this.cbBoxMaPB.BorderColor = System.Drawing.Color.Silver;
            this.cbBoxMaPB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBoxMaPB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxMaPB.FocusedColor = System.Drawing.Color.Empty;
            this.cbBoxMaPB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbBoxMaPB.ForeColor = System.Drawing.Color.Black;
            this.cbBoxMaPB.FormattingEnabled = true;
            this.cbBoxMaPB.Location = new System.Drawing.Point(773, 143);
            this.cbBoxMaPB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbBoxMaPB.Name = "cbBoxMaPB";
            this.cbBoxMaPB.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbBoxMaPB.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbBoxMaPB.Size = new System.Drawing.Size(219, 31);
            this.cbBoxMaPB.TabIndex = 22;
            // 
            // dtGridViewHoSo
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtGridViewHoSo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGridViewHoSo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridViewHoSo.BackgroundColor = System.Drawing.Color.White;
            this.dtGridViewHoSo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGridViewHoSo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGridViewHoSo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridViewHoSo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtGridViewHoSo.ColumnHeadersHeight = 59;
            this.dtGridViewHoSo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANV,
            this.HOTEN,
            this.NGAYSINH,
            this.GIOITINH,
            this.SODT,
            this.EMAIL,
            this.NGAYTD,
            this.MAPB,
            this.TAIKHOAN,
            this.MATKHAU,
            this.QUYEN});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridViewHoSo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtGridViewHoSo.EnableHeadersVisualStyles = false;
            this.dtGridViewHoSo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtGridViewHoSo.Location = new System.Drawing.Point(71, 425);
            this.dtGridViewHoSo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtGridViewHoSo.Name = "dtGridViewHoSo";
            this.dtGridViewHoSo.RowHeadersVisible = false;
            this.dtGridViewHoSo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridViewHoSo.Size = new System.Drawing.Size(1115, 247);
            this.dtGridViewHoSo.TabIndex = 23;
            this.dtGridViewHoSo.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dtGridViewHoSo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtGridViewHoSo.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtGridViewHoSo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtGridViewHoSo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtGridViewHoSo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtGridViewHoSo.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtGridViewHoSo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtGridViewHoSo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtGridViewHoSo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtGridViewHoSo.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtGridViewHoSo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtGridViewHoSo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtGridViewHoSo.ThemeStyle.HeaderStyle.Height = 59;
            this.dtGridViewHoSo.ThemeStyle.ReadOnly = false;
            this.dtGridViewHoSo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtGridViewHoSo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGridViewHoSo.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtGridViewHoSo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtGridViewHoSo.ThemeStyle.RowsStyle.Height = 22;
            this.dtGridViewHoSo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtGridViewHoSo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtGridViewHoSo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridViewHoSo_CellClick);
            // 
            // MANV
            // 
            this.MANV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MANV.DataPropertyName = "MANV";
            this.MANV.HeaderText = "Mã Nhân Viên";
            this.MANV.MinimumWidth = 50;
            this.MANV.Name = "MANV";
            this.MANV.Width = 137;
            // 
            // HOTEN
            // 
            this.HOTEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.HOTEN.DataPropertyName = "HOTEN";
            this.HOTEN.HeaderText = "Họ Tên";
            this.HOTEN.MinimumWidth = 50;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Width = 87;
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            this.NGAYSINH.HeaderText = "Ngày Sinh";
            this.NGAYSINH.MinimumWidth = 50;
            this.NGAYSINH.Name = "NGAYSINH";
            this.NGAYSINH.Width = 110;
            // 
            // GIOITINH
            // 
            this.GIOITINH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GIOITINH.DataPropertyName = "GIOITINH";
            this.GIOITINH.HeaderText = "Giới Tính";
            this.GIOITINH.MinimumWidth = 50;
            this.GIOITINH.Name = "GIOITINH";
            this.GIOITINH.Width = 99;
            // 
            // SODT
            // 
            this.SODT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SODT.DataPropertyName = "SODT";
            this.SODT.HeaderText = "Số Điện Thoại";
            this.SODT.MinimumWidth = 50;
            this.SODT.Name = "SODT";
            this.SODT.Width = 136;
            // 
            // EMAIL
            // 
            this.EMAIL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "Email";
            this.EMAIL.MinimumWidth = 50;
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Width = 81;
            // 
            // NGAYTD
            // 
            this.NGAYTD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NGAYTD.DataPropertyName = "NGAYTD";
            this.NGAYTD.HeaderText = "Ngày Tuyển Dụng";
            this.NGAYTD.MinimumWidth = 50;
            this.NGAYTD.Name = "NGAYTD";
            this.NGAYTD.Width = 166;
            // 
            // MAPB
            // 
            this.MAPB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MAPB.DataPropertyName = "MAPB";
            this.MAPB.HeaderText = "Mã Phòng Ban";
            this.MAPB.MinimumWidth = 50;
            this.MAPB.Name = "MAPB";
            this.MAPB.Width = 142;
            // 
            // TAIKHOAN
            // 
            this.TAIKHOAN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TAIKHOAN.DataPropertyName = "TAIKHOAN";
            this.TAIKHOAN.HeaderText = "Tài Khoản";
            this.TAIKHOAN.MinimumWidth = 50;
            this.TAIKHOAN.Name = "TAIKHOAN";
            this.TAIKHOAN.Width = 105;
            // 
            // MATKHAU
            // 
            this.MATKHAU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MATKHAU.DataPropertyName = "MATKHAU";
            this.MATKHAU.HeaderText = "Mật Khẩu";
            this.MATKHAU.MinimumWidth = 50;
            this.MATKHAU.Name = "MATKHAU";
            this.MATKHAU.Width = 105;
            // 
            // QUYEN
            // 
            this.QUYEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.QUYEN.DataPropertyName = "QUYEN";
            this.QUYEN.HeaderText = "Quyền";
            this.QUYEN.MinimumWidth = 50;
            this.QUYEN.Name = "QUYEN";
            this.QUYEN.Width = 91;
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.AnimationHoverSpeed = 0.07F;
            this.btnNhapLai.AnimationSpeed = 0.03F;
            this.btnNhapLai.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnNhapLai.BorderColor = System.Drawing.Color.Black;
            this.btnNhapLai.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNhapLai.FocusedColor = System.Drawing.Color.Empty;
            this.btnNhapLai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNhapLai.ForeColor = System.Drawing.Color.White;
            this.btnNhapLai.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapLai.Image")));
            this.btnNhapLai.ImageSize = new System.Drawing.Size(20, 20);
            this.btnNhapLai.Location = new System.Drawing.Point(1252, 49);
            this.btnNhapLai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnNhapLai.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNhapLai.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNhapLai.OnHoverImage = null;
            this.btnNhapLai.OnPressedColor = System.Drawing.Color.Black;
            this.btnNhapLai.Size = new System.Drawing.Size(197, 52);
            this.btnNhapLai.TabIndex = 30;
            this.btnNhapLai.Text = "Nhập Lại";
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AnimationHoverSpeed = 0.07F;
            this.btnThoat.AnimationSpeed = 0.03F;
            this.btnThoat.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnThoat.BorderColor = System.Drawing.Color.Black;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThoat.FocusedColor = System.Drawing.Color.Empty;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThoat.Location = new System.Drawing.Point(1252, 478);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnThoat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThoat.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThoat.OnHoverImage = null;
            this.btnThoat.OnPressedColor = System.Drawing.Color.Black;
            this.btnThoat.Size = new System.Drawing.Size(197, 52);
            this.btnThoat.TabIndex = 29;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXemHoSo
            // 
            this.btnXemHoSo.AnimationHoverSpeed = 0.07F;
            this.btnXemHoSo.AnimationSpeed = 0.03F;
            this.btnXemHoSo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnXemHoSo.BorderColor = System.Drawing.Color.Black;
            this.btnXemHoSo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXemHoSo.FocusedColor = System.Drawing.Color.Empty;
            this.btnXemHoSo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXemHoSo.ForeColor = System.Drawing.Color.White;
            this.btnXemHoSo.Image = ((System.Drawing.Image)(resources.GetObject("btnXemHoSo.Image")));
            this.btnXemHoSo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnXemHoSo.Location = new System.Drawing.Point(1252, 406);
            this.btnXemHoSo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXemHoSo.Name = "btnXemHoSo";
            this.btnXemHoSo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnXemHoSo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXemHoSo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXemHoSo.OnHoverImage = null;
            this.btnXemHoSo.OnPressedColor = System.Drawing.Color.Black;
            this.btnXemHoSo.Size = new System.Drawing.Size(197, 52);
            this.btnXemHoSo.TabIndex = 28;
            this.btnXemHoSo.Text = "Xem";
            this.btnXemHoSo.Click += new System.EventHandler(this.btnXemHoSo_Click);
            // 
            // btnTimKiemHoSo
            // 
            this.btnTimKiemHoSo.AnimationHoverSpeed = 0.07F;
            this.btnTimKiemHoSo.AnimationSpeed = 0.03F;
            this.btnTimKiemHoSo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnTimKiemHoSo.BorderColor = System.Drawing.Color.Black;
            this.btnTimKiemHoSo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTimKiemHoSo.FocusedColor = System.Drawing.Color.Empty;
            this.btnTimKiemHoSo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTimKiemHoSo.ForeColor = System.Drawing.Color.White;
            this.btnTimKiemHoSo.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemHoSo.Image")));
            this.btnTimKiemHoSo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTimKiemHoSo.Location = new System.Drawing.Point(1252, 335);
            this.btnTimKiemHoSo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimKiemHoSo.Name = "btnTimKiemHoSo";
            this.btnTimKiemHoSo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnTimKiemHoSo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTimKiemHoSo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTimKiemHoSo.OnHoverImage = null;
            this.btnTimKiemHoSo.OnPressedColor = System.Drawing.Color.Black;
            this.btnTimKiemHoSo.Size = new System.Drawing.Size(197, 52);
            this.btnTimKiemHoSo.TabIndex = 27;
            this.btnTimKiemHoSo.Text = "Tìm Kiếm";
            this.btnTimKiemHoSo.Click += new System.EventHandler(this.btnTimKiemHoSo_Click);
            // 
            // btnXoaHoSo
            // 
            this.btnXoaHoSo.AnimationHoverSpeed = 0.07F;
            this.btnXoaHoSo.AnimationSpeed = 0.03F;
            this.btnXoaHoSo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnXoaHoSo.BorderColor = System.Drawing.Color.Black;
            this.btnXoaHoSo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXoaHoSo.FocusedColor = System.Drawing.Color.Empty;
            this.btnXoaHoSo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoaHoSo.ForeColor = System.Drawing.Color.White;
            this.btnXoaHoSo.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaHoSo.Image")));
            this.btnXoaHoSo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnXoaHoSo.Location = new System.Drawing.Point(1252, 263);
            this.btnXoaHoSo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoaHoSo.Name = "btnXoaHoSo";
            this.btnXoaHoSo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnXoaHoSo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXoaHoSo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXoaHoSo.OnHoverImage = null;
            this.btnXoaHoSo.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoaHoSo.Size = new System.Drawing.Size(197, 52);
            this.btnXoaHoSo.TabIndex = 26;
            this.btnXoaHoSo.Text = "Xóa Hồ Sơ";
            this.btnXoaHoSo.Click += new System.EventHandler(this.btnXoaHoSo_Click);
            // 
            // btnSuaHoSo
            // 
            this.btnSuaHoSo.AnimationHoverSpeed = 0.07F;
            this.btnSuaHoSo.AnimationSpeed = 0.03F;
            this.btnSuaHoSo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSuaHoSo.BorderColor = System.Drawing.Color.Black;
            this.btnSuaHoSo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSuaHoSo.FocusedColor = System.Drawing.Color.Empty;
            this.btnSuaHoSo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSuaHoSo.ForeColor = System.Drawing.Color.White;
            this.btnSuaHoSo.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaHoSo.Image")));
            this.btnSuaHoSo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSuaHoSo.Location = new System.Drawing.Point(1252, 192);
            this.btnSuaHoSo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSuaHoSo.Name = "btnSuaHoSo";
            this.btnSuaHoSo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSuaHoSo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSuaHoSo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSuaHoSo.OnHoverImage = null;
            this.btnSuaHoSo.OnPressedColor = System.Drawing.Color.Black;
            this.btnSuaHoSo.Size = new System.Drawing.Size(197, 52);
            this.btnSuaHoSo.TabIndex = 25;
            this.btnSuaHoSo.Text = "Sửa Hồ Sơ";
            this.btnSuaHoSo.Click += new System.EventHandler(this.btnSuaHoSo_Click);
            // 
            // btnThemHoSo
            // 
            this.btnThemHoSo.AnimationHoverSpeed = 0.07F;
            this.btnThemHoSo.AnimationSpeed = 0.03F;
            this.btnThemHoSo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnThemHoSo.BorderColor = System.Drawing.Color.Black;
            this.btnThemHoSo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThemHoSo.FocusedColor = System.Drawing.Color.Empty;
            this.btnThemHoSo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemHoSo.ForeColor = System.Drawing.Color.White;
            this.btnThemHoSo.Image = ((System.Drawing.Image)(resources.GetObject("btnThemHoSo.Image")));
            this.btnThemHoSo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThemHoSo.Location = new System.Drawing.Point(1252, 121);
            this.btnThemHoSo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemHoSo.Name = "btnThemHoSo";
            this.btnThemHoSo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnThemHoSo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThemHoSo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThemHoSo.OnHoverImage = null;
            this.btnThemHoSo.OnPressedColor = System.Drawing.Color.Black;
            this.btnThemHoSo.Size = new System.Drawing.Size(197, 52);
            this.btnThemHoSo.TabIndex = 24;
            this.btnThemHoSo.Text = "Thêm Hồ Sơ";
            this.btnThemHoSo.Click += new System.EventHandler(this.btnThemHoSo_Click);
            // 
            // btnChuyenQTCT
            // 
            this.btnChuyenQTCT.AnimationHoverSpeed = 0.07F;
            this.btnChuyenQTCT.AnimationSpeed = 0.03F;
            this.btnChuyenQTCT.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnChuyenQTCT.BorderColor = System.Drawing.Color.Black;
            this.btnChuyenQTCT.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnChuyenQTCT.FocusedColor = System.Drawing.Color.Empty;
            this.btnChuyenQTCT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChuyenQTCT.ForeColor = System.Drawing.Color.White;
            this.btnChuyenQTCT.Image = ((System.Drawing.Image)(resources.GetObject("btnChuyenQTCT.Image")));
            this.btnChuyenQTCT.ImageSize = new System.Drawing.Size(20, 20);
            this.btnChuyenQTCT.Location = new System.Drawing.Point(257, 695);
            this.btnChuyenQTCT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChuyenQTCT.Name = "btnChuyenQTCT";
            this.btnChuyenQTCT.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnChuyenQTCT.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnChuyenQTCT.OnHoverForeColor = System.Drawing.Color.White;
            this.btnChuyenQTCT.OnHoverImage = null;
            this.btnChuyenQTCT.OnPressedColor = System.Drawing.Color.Black;
            this.btnChuyenQTCT.Size = new System.Drawing.Size(213, 52);
            this.btnChuyenQTCT.TabIndex = 31;
            this.btnChuyenQTCT.Text = "Quá Trình Công Tác";
            // 
            // btnChuyenNVCV
            // 
            this.btnChuyenNVCV.AnimationHoverSpeed = 0.07F;
            this.btnChuyenNVCV.AnimationSpeed = 0.03F;
            this.btnChuyenNVCV.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnChuyenNVCV.BorderColor = System.Drawing.Color.Black;
            this.btnChuyenNVCV.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnChuyenNVCV.FocusedColor = System.Drawing.Color.Empty;
            this.btnChuyenNVCV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChuyenNVCV.ForeColor = System.Drawing.Color.White;
            this.btnChuyenNVCV.Image = ((System.Drawing.Image)(resources.GetObject("btnChuyenNVCV.Image")));
            this.btnChuyenNVCV.ImageSize = new System.Drawing.Size(20, 20);
            this.btnChuyenNVCV.Location = new System.Drawing.Point(493, 695);
            this.btnChuyenNVCV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChuyenNVCV.Name = "btnChuyenNVCV";
            this.btnChuyenNVCV.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnChuyenNVCV.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnChuyenNVCV.OnHoverForeColor = System.Drawing.Color.White;
            this.btnChuyenNVCV.OnHoverImage = null;
            this.btnChuyenNVCV.OnPressedColor = System.Drawing.Color.Black;
            this.btnChuyenNVCV.Size = new System.Drawing.Size(213, 52);
            this.btnChuyenNVCV.TabIndex = 32;
            this.btnChuyenNVCV.Text = "Nhân Viên - Chức Vụ";
            // 
            // btnChuyenTDCM
            // 
            this.btnChuyenTDCM.AnimationHoverSpeed = 0.07F;
            this.btnChuyenTDCM.AnimationSpeed = 0.03F;
            this.btnChuyenTDCM.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnChuyenTDCM.BorderColor = System.Drawing.Color.Black;
            this.btnChuyenTDCM.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnChuyenTDCM.FocusedColor = System.Drawing.Color.Empty;
            this.btnChuyenTDCM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChuyenTDCM.ForeColor = System.Drawing.Color.White;
            this.btnChuyenTDCM.Image = ((System.Drawing.Image)(resources.GetObject("btnChuyenTDCM.Image")));
            this.btnChuyenTDCM.ImageSize = new System.Drawing.Size(20, 20);
            this.btnChuyenTDCM.Location = new System.Drawing.Point(721, 695);
            this.btnChuyenTDCM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChuyenTDCM.Name = "btnChuyenTDCM";
            this.btnChuyenTDCM.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnChuyenTDCM.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnChuyenTDCM.OnHoverForeColor = System.Drawing.Color.White;
            this.btnChuyenTDCM.OnHoverImage = null;
            this.btnChuyenTDCM.OnPressedColor = System.Drawing.Color.Black;
            this.btnChuyenTDCM.Size = new System.Drawing.Size(213, 52);
            this.btnChuyenTDCM.TabIndex = 33;
            this.btnChuyenTDCM.Text = "Trình Độ Chuyên Môn";
            // 
            // btnChuyenTDNN
            // 
            this.btnChuyenTDNN.AnimationHoverSpeed = 0.07F;
            this.btnChuyenTDNN.AnimationSpeed = 0.03F;
            this.btnChuyenTDNN.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnChuyenTDNN.BorderColor = System.Drawing.Color.Black;
            this.btnChuyenTDNN.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnChuyenTDNN.FocusedColor = System.Drawing.Color.Empty;
            this.btnChuyenTDNN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChuyenTDNN.ForeColor = System.Drawing.Color.White;
            this.btnChuyenTDNN.Image = ((System.Drawing.Image)(resources.GetObject("btnChuyenTDNN.Image")));
            this.btnChuyenTDNN.ImageSize = new System.Drawing.Size(20, 20);
            this.btnChuyenTDNN.Location = new System.Drawing.Point(943, 695);
            this.btnChuyenTDNN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChuyenTDNN.Name = "btnChuyenTDNN";
            this.btnChuyenTDNN.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnChuyenTDNN.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnChuyenTDNN.OnHoverForeColor = System.Drawing.Color.White;
            this.btnChuyenTDNN.OnHoverImage = null;
            this.btnChuyenTDNN.OnPressedColor = System.Drawing.Color.Black;
            this.btnChuyenTDNN.Size = new System.Drawing.Size(213, 52);
            this.btnChuyenTDNN.TabIndex = 34;
            this.btnChuyenTDNN.Text = "Trình Độ Ngoại Ngữ";
            // 
            // gunaLabel13
            // 
            this.gunaLabel13.AutoSize = true;
            this.gunaLabel13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel13.Location = new System.Drawing.Point(95, 710);
            this.gunaLabel13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel13.Name = "gunaLabel13";
            this.gunaLabel13.Size = new System.Drawing.Size(108, 25);
            this.gunaLabel13.TabIndex = 35;
            this.gunaLabel13.Text = "Chuyển tới";
            // 
            // frmQuanLyHoSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1545, 782);
            this.Controls.Add(this.gunaLabel13);
            this.Controls.Add(this.btnChuyenTDNN);
            this.Controls.Add(this.btnChuyenTDCM);
            this.Controls.Add(this.btnChuyenNVCV);
            this.Controls.Add(this.btnChuyenQTCT);
            this.Controls.Add(this.btnNhapLai);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXemHoSo);
            this.Controls.Add(this.btnTimKiemHoSo);
            this.Controls.Add(this.btnXoaHoSo);
            this.Controls.Add(this.btnSuaHoSo);
            this.Controls.Add(this.btnThemHoSo);
            this.Controls.Add(this.dtGridViewHoSo);
            this.Controls.Add(this.cbBoxMaPB);
            this.Controls.Add(this.cbBoxGioiTinh);
            this.Controls.Add(this.txbQuyen);
            this.Controls.Add(this.txbMatKhau);
            this.Controls.Add(this.txbTaiKhoan);
            this.Controls.Add(this.txbNgayTD);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbSoDT);
            this.Controls.Add(this.txbNgaySinh);
            this.Controls.Add(this.txbTenNV);
            this.Controls.Add(this.txbMaNV);
            this.Controls.Add(this.gunaLabel12);
            this.Controls.Add(this.gunaLabel11);
            this.Controls.Add(this.gunaLabel10);
            this.Controls.Add(this.gunaLabel9);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmQuanLyHoSo";
            this.Text = "frmQuanLyHoSo";
            this.Load += new System.EventHandler(this.frmQuanLyHoSo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewHoSo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaLabel gunaLabel11;
        private Guna.UI.WinForms.GunaLabel gunaLabel12;
        private Guna.UI.WinForms.GunaTextBox txbMaNV;
        private Guna.UI.WinForms.GunaTextBox txbTenNV;
        private Guna.UI.WinForms.GunaTextBox txbNgaySinh;
        private Guna.UI.WinForms.GunaTextBox txbSoDT;
        private Guna.UI.WinForms.GunaTextBox txbEmail;
        private Guna.UI.WinForms.GunaTextBox txbNgayTD;
        private Guna.UI.WinForms.GunaTextBox txbTaiKhoan;
        private Guna.UI.WinForms.GunaTextBox txbMatKhau;
        private Guna.UI.WinForms.GunaTextBox txbQuyen;
        private Guna.UI.WinForms.GunaComboBox cbBoxGioiTinh;
        private Guna.UI.WinForms.GunaComboBox cbBoxMaPB;
        private Guna.UI.WinForms.GunaDataGridView dtGridViewHoSo;
        private Guna.UI.WinForms.GunaButton btnNhapLai;
        private Guna.UI.WinForms.GunaButton btnThoat;
        private Guna.UI.WinForms.GunaButton btnXemHoSo;
        private Guna.UI.WinForms.GunaButton btnTimKiemHoSo;
        private Guna.UI.WinForms.GunaButton btnXoaHoSo;
        private Guna.UI.WinForms.GunaButton btnSuaHoSo;
        private Guna.UI.WinForms.GunaButton btnThemHoSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SODT;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAIKHOAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATKHAU;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUYEN;
        private Guna.UI.WinForms.GunaButton btnChuyenQTCT;
        private Guna.UI.WinForms.GunaButton btnChuyenNVCV;
        private Guna.UI.WinForms.GunaButton btnChuyenTDCM;
        private Guna.UI.WinForms.GunaButton btnChuyenTDNN;
        private Guna.UI.WinForms.GunaLabel gunaLabel13;
    }
}