namespace GUI.Phan_Thanh_Trung
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
            this.txbSoDT = new Guna.UI.WinForms.GunaTextBox();
            this.txbEmail = new Guna.UI.WinForms.GunaTextBox();
            this.txbTaiKhoan = new Guna.UI.WinForms.GunaTextBox();
            this.txbMatKhau = new Guna.UI.WinForms.GunaTextBox();
            this.txbQuyen = new Guna.UI.WinForms.GunaTextBox();
            this.cbBoxGioiTinh = new Guna.UI.WinForms.GunaComboBox();
            this.cbBoxMaPB = new Guna.UI.WinForms.GunaComboBox();
            this.dtGridViewHoSo = new Guna.UI.WinForms.GunaDataGridView();
            this.maNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dtPickerNS = new Guna.UI.WinForms.GunaDateTimePicker();
            this.dtPickerNTD = new Guna.UI.WinForms.GunaDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewHoSo)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(392, 7);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(151, 28);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Quản Lý Hồ Sơ";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(4, 72);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(82, 15);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Mã Nhân Viên";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(4, 121);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(84, 15);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "Tên Nhân Viên";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(4, 171);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(61, 15);
            this.gunaLabel4.TabIndex = 3;
            this.gunaLabel4.Text = "Ngày Sinh";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(4, 210);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(55, 15);
            this.gunaLabel5.TabIndex = 4;
            this.gunaLabel5.Text = "Giới Tính";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.Location = new System.Drawing.Point(4, 251);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(80, 15);
            this.gunaLabel6.TabIndex = 5;
            this.gunaLabel6.Text = "Số Điện Thoại";
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel7.Location = new System.Drawing.Point(4, 284);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(36, 15);
            this.gunaLabel7.TabIndex = 6;
            this.gunaLabel7.Text = "Email";
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel8.ForeColor = System.Drawing.Color.White;
            this.gunaLabel8.Location = new System.Drawing.Point(406, 72);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(103, 15);
            this.gunaLabel8.TabIndex = 7;
            this.gunaLabel8.Text = "Ngày Tuyển Dụng";
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel9.ForeColor = System.Drawing.Color.White;
            this.gunaLabel9.Location = new System.Drawing.Point(406, 111);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(87, 15);
            this.gunaLabel9.TabIndex = 8;
            this.gunaLabel9.Text = "Tên Phòng Ban";
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel10.ForeColor = System.Drawing.Color.White;
            this.gunaLabel10.Location = new System.Drawing.Point(406, 203);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(58, 15);
            this.gunaLabel10.TabIndex = 9;
            this.gunaLabel10.Text = "Mật Khẩu";
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.AutoSize = true;
            this.gunaLabel11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel11.ForeColor = System.Drawing.Color.White;
            this.gunaLabel11.Location = new System.Drawing.Point(406, 155);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(59, 15);
            this.gunaLabel11.TabIndex = 10;
            this.gunaLabel11.Text = "Tài Khoản";
            // 
            // gunaLabel12
            // 
            this.gunaLabel12.AutoSize = true;
            this.gunaLabel12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel12.ForeColor = System.Drawing.Color.White;
            this.gunaLabel12.Location = new System.Drawing.Point(406, 251);
            this.gunaLabel12.Name = "gunaLabel12";
            this.gunaLabel12.Size = new System.Drawing.Size(42, 15);
            this.gunaLabel12.TabIndex = 11;
            this.gunaLabel12.Text = "Quyền";
            // 
            // txbMaNV
            // 
            this.txbMaNV.BackColor = System.Drawing.Color.Transparent;
            this.txbMaNV.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.txbMaNV.BorderColor = System.Drawing.Color.Silver;
            this.txbMaNV.BorderSize = 0;
            this.txbMaNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbMaNV.FocusedBaseColor = System.Drawing.Color.White;
            this.txbMaNV.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txbMaNV.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txbMaNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbMaNV.ForeColor = System.Drawing.Color.White;
            this.txbMaNV.Location = new System.Drawing.Point(112, 63);
            this.txbMaNV.Name = "txbMaNV";
            this.txbMaNV.PasswordChar = '\0';
            this.txbMaNV.Radius = 10;
            this.txbMaNV.SelectedText = "";
            this.txbMaNV.Size = new System.Drawing.Size(239, 30);
            this.txbMaNV.TabIndex = 12;
            // 
            // txbTenNV
            // 
            this.txbTenNV.BackColor = System.Drawing.Color.Transparent;
            this.txbTenNV.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.txbTenNV.BorderColor = System.Drawing.Color.Silver;
            this.txbTenNV.BorderSize = 0;
            this.txbTenNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTenNV.FocusedBaseColor = System.Drawing.Color.White;
            this.txbTenNV.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txbTenNV.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txbTenNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbTenNV.ForeColor = System.Drawing.Color.White;
            this.txbTenNV.Location = new System.Drawing.Point(112, 112);
            this.txbTenNV.Name = "txbTenNV";
            this.txbTenNV.PasswordChar = '\0';
            this.txbTenNV.Radius = 10;
            this.txbTenNV.SelectedText = "";
            this.txbTenNV.Size = new System.Drawing.Size(239, 30);
            this.txbTenNV.TabIndex = 13;
            // 
            // txbSoDT
            // 
            this.txbSoDT.BackColor = System.Drawing.Color.Transparent;
            this.txbSoDT.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.txbSoDT.BorderColor = System.Drawing.Color.Silver;
            this.txbSoDT.BorderSize = 0;
            this.txbSoDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbSoDT.FocusedBaseColor = System.Drawing.Color.White;
            this.txbSoDT.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txbSoDT.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txbSoDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbSoDT.ForeColor = System.Drawing.Color.White;
            this.txbSoDT.Location = new System.Drawing.Point(112, 240);
            this.txbSoDT.Name = "txbSoDT";
            this.txbSoDT.PasswordChar = '\0';
            this.txbSoDT.Radius = 10;
            this.txbSoDT.SelectedText = "";
            this.txbSoDT.Size = new System.Drawing.Size(239, 30);
            this.txbSoDT.TabIndex = 15;
            // 
            // txbEmail
            // 
            this.txbEmail.BackColor = System.Drawing.Color.Transparent;
            this.txbEmail.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.txbEmail.BorderColor = System.Drawing.Color.Silver;
            this.txbEmail.BorderSize = 0;
            this.txbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbEmail.FocusedBaseColor = System.Drawing.Color.White;
            this.txbEmail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txbEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txbEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbEmail.ForeColor = System.Drawing.Color.White;
            this.txbEmail.Location = new System.Drawing.Point(112, 289);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.PasswordChar = '\0';
            this.txbEmail.Radius = 10;
            this.txbEmail.SelectedText = "";
            this.txbEmail.Size = new System.Drawing.Size(239, 30);
            this.txbEmail.TabIndex = 16;
            // 
            // txbTaiKhoan
            // 
            this.txbTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.txbTaiKhoan.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.txbTaiKhoan.BorderColor = System.Drawing.Color.Silver;
            this.txbTaiKhoan.BorderSize = 0;
            this.txbTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTaiKhoan.FocusedBaseColor = System.Drawing.Color.White;
            this.txbTaiKhoan.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txbTaiKhoan.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txbTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.txbTaiKhoan.Location = new System.Drawing.Point(514, 145);
            this.txbTaiKhoan.Name = "txbTaiKhoan";
            this.txbTaiKhoan.PasswordChar = '\0';
            this.txbTaiKhoan.Radius = 10;
            this.txbTaiKhoan.SelectedText = "";
            this.txbTaiKhoan.Size = new System.Drawing.Size(239, 30);
            this.txbTaiKhoan.TabIndex = 18;
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.txbMatKhau.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.txbMatKhau.BorderColor = System.Drawing.Color.Silver;
            this.txbMatKhau.BorderSize = 0;
            this.txbMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbMatKhau.FocusedBaseColor = System.Drawing.Color.White;
            this.txbMatKhau.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txbMatKhau.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txbMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbMatKhau.ForeColor = System.Drawing.Color.White;
            this.txbMatKhau.Location = new System.Drawing.Point(514, 194);
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.PasswordChar = '\0';
            this.txbMatKhau.Radius = 10;
            this.txbMatKhau.SelectedText = "";
            this.txbMatKhau.Size = new System.Drawing.Size(239, 30);
            this.txbMatKhau.TabIndex = 19;
            // 
            // txbQuyen
            // 
            this.txbQuyen.BackColor = System.Drawing.Color.Transparent;
            this.txbQuyen.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.txbQuyen.BorderColor = System.Drawing.Color.Silver;
            this.txbQuyen.BorderSize = 0;
            this.txbQuyen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbQuyen.FocusedBaseColor = System.Drawing.Color.White;
            this.txbQuyen.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txbQuyen.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txbQuyen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbQuyen.ForeColor = System.Drawing.Color.White;
            this.txbQuyen.Location = new System.Drawing.Point(514, 243);
            this.txbQuyen.Name = "txbQuyen";
            this.txbQuyen.PasswordChar = '\0';
            this.txbQuyen.Radius = 10;
            this.txbQuyen.SelectedText = "";
            this.txbQuyen.Size = new System.Drawing.Size(239, 30);
            this.txbQuyen.TabIndex = 20;
            // 
            // cbBoxGioiTinh
            // 
            this.cbBoxGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.cbBoxGioiTinh.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.cbBoxGioiTinh.BorderColor = System.Drawing.Color.Silver;
            this.cbBoxGioiTinh.BorderSize = 0;
            this.cbBoxGioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBoxGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxGioiTinh.FocusedColor = System.Drawing.Color.Empty;
            this.cbBoxGioiTinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbBoxGioiTinh.ForeColor = System.Drawing.Color.White;
            this.cbBoxGioiTinh.FormattingEnabled = true;
            this.cbBoxGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbBoxGioiTinh.Location = new System.Drawing.Point(114, 202);
            this.cbBoxGioiTinh.Name = "cbBoxGioiTinh";
            this.cbBoxGioiTinh.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbBoxGioiTinh.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbBoxGioiTinh.Radius = 10;
            this.cbBoxGioiTinh.Size = new System.Drawing.Size(128, 26);
            this.cbBoxGioiTinh.TabIndex = 21;
            // 
            // cbBoxMaPB
            // 
            this.cbBoxMaPB.BackColor = System.Drawing.Color.Transparent;
            this.cbBoxMaPB.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.cbBoxMaPB.BorderColor = System.Drawing.Color.Silver;
            this.cbBoxMaPB.BorderSize = 0;
            this.cbBoxMaPB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBoxMaPB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxMaPB.FocusedColor = System.Drawing.Color.Empty;
            this.cbBoxMaPB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbBoxMaPB.ForeColor = System.Drawing.Color.White;
            this.cbBoxMaPB.FormattingEnabled = true;
            this.cbBoxMaPB.Location = new System.Drawing.Point(514, 106);
            this.cbBoxMaPB.Name = "cbBoxMaPB";
            this.cbBoxMaPB.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbBoxMaPB.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbBoxMaPB.Radius = 10;
            this.cbBoxMaPB.Size = new System.Drawing.Size(165, 26);
            this.cbBoxMaPB.TabIndex = 22;
            // 
            // dtGridViewHoSo
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.dtGridViewHoSo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGridViewHoSo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridViewHoSo.BackgroundColor = System.Drawing.Color.White;
            this.dtGridViewHoSo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGridViewHoSo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGridViewHoSo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridViewHoSo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtGridViewHoSo.ColumnHeadersHeight = 27;
            this.dtGridViewHoSo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNhanVien,
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
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridViewHoSo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtGridViewHoSo.EnableHeadersVisualStyles = false;
            this.dtGridViewHoSo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.dtGridViewHoSo.Location = new System.Drawing.Point(0, 347);
            this.dtGridViewHoSo.Name = "dtGridViewHoSo";
            this.dtGridViewHoSo.RowHeadersVisible = false;
            this.dtGridViewHoSo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridViewHoSo.Size = new System.Drawing.Size(923, 178);
            this.dtGridViewHoSo.TabIndex = 23;
            this.dtGridViewHoSo.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Alizarin;
            this.dtGridViewHoSo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.dtGridViewHoSo.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtGridViewHoSo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtGridViewHoSo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtGridViewHoSo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtGridViewHoSo.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtGridViewHoSo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.dtGridViewHoSo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.dtGridViewHoSo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtGridViewHoSo.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtGridViewHoSo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtGridViewHoSo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtGridViewHoSo.ThemeStyle.HeaderStyle.Height = 27;
            this.dtGridViewHoSo.ThemeStyle.ReadOnly = false;
            this.dtGridViewHoSo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            this.dtGridViewHoSo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGridViewHoSo.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtGridViewHoSo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtGridViewHoSo.ThemeStyle.RowsStyle.Height = 22;
            this.dtGridViewHoSo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            this.dtGridViewHoSo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtGridViewHoSo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridViewHoSo_CellClick);
            // 
            // maNhanVien
            // 
            this.maNhanVien.DataPropertyName = "MaNV";
            this.maNhanVien.HeaderText = "Mã NV";
            this.maNhanVien.Name = "maNhanVien";
            // 
            // HOTEN
            // 
            this.HOTEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HOTEN.DataPropertyName = "HOTEN";
            this.HOTEN.HeaderText = "Họ Tên";
            this.HOTEN.Name = "HOTEN";
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            this.NGAYSINH.HeaderText = "Ngày Sinh";
            this.NGAYSINH.Name = "NGAYSINH";
            // 
            // GIOITINH
            // 
            this.GIOITINH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GIOITINH.DataPropertyName = "GIOITINH";
            this.GIOITINH.HeaderText = "Giới Tính";
            this.GIOITINH.Name = "GIOITINH";
            // 
            // SODT
            // 
            this.SODT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SODT.DataPropertyName = "SODT";
            this.SODT.HeaderText = "SĐT";
            this.SODT.Name = "SODT";
            // 
            // EMAIL
            // 
            this.EMAIL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "Email";
            this.EMAIL.Name = "EMAIL";
            // 
            // NGAYTD
            // 
            this.NGAYTD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NGAYTD.DataPropertyName = "NGAYTD";
            this.NGAYTD.HeaderText = "Ngày TD";
            this.NGAYTD.Name = "NGAYTD";
            // 
            // MAPB
            // 
            this.MAPB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MAPB.DataPropertyName = "MAPB";
            this.MAPB.HeaderText = "Mã PB";
            this.MAPB.Name = "MAPB";
            // 
            // TAIKHOAN
            // 
            this.TAIKHOAN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TAIKHOAN.DataPropertyName = "TAIKHOAN";
            this.TAIKHOAN.HeaderText = "Tài Khoản";
            this.TAIKHOAN.Name = "TAIKHOAN";
            // 
            // MATKHAU
            // 
            this.MATKHAU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MATKHAU.DataPropertyName = "MATKHAU";
            this.MATKHAU.HeaderText = "Mật Khẩu";
            this.MATKHAU.Name = "MATKHAU";
            // 
            // QUYEN
            // 
            this.QUYEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QUYEN.DataPropertyName = "QUYEN";
            this.QUYEN.HeaderText = "Quyền";
            this.QUYEN.Name = "QUYEN";
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.AnimationHoverSpeed = 0.07F;
            this.btnNhapLai.AnimationSpeed = 0.03F;
            this.btnNhapLai.BackColor = System.Drawing.Color.Transparent;
            this.btnNhapLai.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnNhapLai.BorderColor = System.Drawing.Color.Black;
            this.btnNhapLai.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNhapLai.FocusedColor = System.Drawing.Color.Empty;
            this.btnNhapLai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNhapLai.ForeColor = System.Drawing.Color.White;
            this.btnNhapLai.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapLai.Image")));
            this.btnNhapLai.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNhapLai.ImageSize = new System.Drawing.Size(20, 20);
            this.btnNhapLai.Location = new System.Drawing.Point(514, 284);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnNhapLai.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNhapLai.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNhapLai.OnHoverImage = null;
            this.btnNhapLai.OnPressedColor = System.Drawing.Color.Black;
            this.btnNhapLai.Radius = 15;
            this.btnNhapLai.Size = new System.Drawing.Size(148, 42);
            this.btnNhapLai.TabIndex = 30;
            this.btnNhapLai.Text = "Nhập Lại";
            this.btnNhapLai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // btnXemHoSo
            // 
            this.btnXemHoSo.AnimationHoverSpeed = 0.07F;
            this.btnXemHoSo.AnimationSpeed = 0.03F;
            this.btnXemHoSo.BackColor = System.Drawing.Color.Transparent;
            this.btnXemHoSo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnXemHoSo.BorderColor = System.Drawing.Color.Black;
            this.btnXemHoSo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXemHoSo.FocusedColor = System.Drawing.Color.Empty;
            this.btnXemHoSo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXemHoSo.ForeColor = System.Drawing.Color.White;
            this.btnXemHoSo.Image = ((System.Drawing.Image)(resources.GetObject("btnXemHoSo.Image")));
            this.btnXemHoSo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXemHoSo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnXemHoSo.Location = new System.Drawing.Point(778, 268);
            this.btnXemHoSo.Name = "btnXemHoSo";
            this.btnXemHoSo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnXemHoSo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXemHoSo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXemHoSo.OnHoverImage = null;
            this.btnXemHoSo.OnPressedColor = System.Drawing.Color.Black;
            this.btnXemHoSo.Radius = 15;
            this.btnXemHoSo.Size = new System.Drawing.Size(127, 42);
            this.btnXemHoSo.TabIndex = 28;
            this.btnXemHoSo.Text = "Xem";
            this.btnXemHoSo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXemHoSo.Click += new System.EventHandler(this.btnXemHoSo_Click);
            // 
            // btnTimKiemHoSo
            // 
            this.btnTimKiemHoSo.AnimationHoverSpeed = 0.07F;
            this.btnTimKiemHoSo.AnimationSpeed = 0.03F;
            this.btnTimKiemHoSo.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiemHoSo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnTimKiemHoSo.BorderColor = System.Drawing.Color.Black;
            this.btnTimKiemHoSo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTimKiemHoSo.FocusedColor = System.Drawing.Color.Empty;
            this.btnTimKiemHoSo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTimKiemHoSo.ForeColor = System.Drawing.Color.White;
            this.btnTimKiemHoSo.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemHoSo.Image")));
            this.btnTimKiemHoSo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTimKiemHoSo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTimKiemHoSo.Location = new System.Drawing.Point(778, 211);
            this.btnTimKiemHoSo.Name = "btnTimKiemHoSo";
            this.btnTimKiemHoSo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnTimKiemHoSo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTimKiemHoSo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTimKiemHoSo.OnHoverImage = null;
            this.btnTimKiemHoSo.OnPressedColor = System.Drawing.Color.Black;
            this.btnTimKiemHoSo.Radius = 15;
            this.btnTimKiemHoSo.Size = new System.Drawing.Size(127, 42);
            this.btnTimKiemHoSo.TabIndex = 27;
            this.btnTimKiemHoSo.Text = "Tìm Kiếm";
            this.btnTimKiemHoSo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTimKiemHoSo.Click += new System.EventHandler(this.btnTimKiemHoSo_Click);
            // 
            // btnXoaHoSo
            // 
            this.btnXoaHoSo.AnimationHoverSpeed = 0.07F;
            this.btnXoaHoSo.AnimationSpeed = 0.03F;
            this.btnXoaHoSo.BackColor = System.Drawing.Color.Transparent;
            this.btnXoaHoSo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnXoaHoSo.BorderColor = System.Drawing.Color.Black;
            this.btnXoaHoSo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXoaHoSo.FocusedColor = System.Drawing.Color.Empty;
            this.btnXoaHoSo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoaHoSo.ForeColor = System.Drawing.Color.White;
            this.btnXoaHoSo.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaHoSo.Image")));
            this.btnXoaHoSo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXoaHoSo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnXoaHoSo.Location = new System.Drawing.Point(778, 153);
            this.btnXoaHoSo.Name = "btnXoaHoSo";
            this.btnXoaHoSo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnXoaHoSo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXoaHoSo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXoaHoSo.OnHoverImage = null;
            this.btnXoaHoSo.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoaHoSo.Radius = 15;
            this.btnXoaHoSo.Size = new System.Drawing.Size(127, 42);
            this.btnXoaHoSo.TabIndex = 26;
            this.btnXoaHoSo.Text = "Xóa Hồ Sơ";
            this.btnXoaHoSo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXoaHoSo.Click += new System.EventHandler(this.btnXoaHoSo_Click);
            // 
            // btnSuaHoSo
            // 
            this.btnSuaHoSo.AnimationHoverSpeed = 0.07F;
            this.btnSuaHoSo.AnimationSpeed = 0.03F;
            this.btnSuaHoSo.BackColor = System.Drawing.Color.Transparent;
            this.btnSuaHoSo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSuaHoSo.BorderColor = System.Drawing.Color.Black;
            this.btnSuaHoSo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSuaHoSo.FocusedColor = System.Drawing.Color.Empty;
            this.btnSuaHoSo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSuaHoSo.ForeColor = System.Drawing.Color.White;
            this.btnSuaHoSo.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaHoSo.Image")));
            this.btnSuaHoSo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSuaHoSo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSuaHoSo.Location = new System.Drawing.Point(778, 95);
            this.btnSuaHoSo.Name = "btnSuaHoSo";
            this.btnSuaHoSo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSuaHoSo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSuaHoSo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSuaHoSo.OnHoverImage = null;
            this.btnSuaHoSo.OnPressedColor = System.Drawing.Color.Black;
            this.btnSuaHoSo.Radius = 15;
            this.btnSuaHoSo.Size = new System.Drawing.Size(127, 42);
            this.btnSuaHoSo.TabIndex = 25;
            this.btnSuaHoSo.Text = "Sửa Hồ Sơ";
            this.btnSuaHoSo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSuaHoSo.Click += new System.EventHandler(this.btnSuaHoSo_Click);
            // 
            // btnThemHoSo
            // 
            this.btnThemHoSo.AnimationHoverSpeed = 0.07F;
            this.btnThemHoSo.AnimationSpeed = 0.03F;
            this.btnThemHoSo.BackColor = System.Drawing.Color.Transparent;
            this.btnThemHoSo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnThemHoSo.BorderColor = System.Drawing.Color.Black;
            this.btnThemHoSo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThemHoSo.FocusedColor = System.Drawing.Color.Empty;
            this.btnThemHoSo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemHoSo.ForeColor = System.Drawing.Color.White;
            this.btnThemHoSo.Image = ((System.Drawing.Image)(resources.GetObject("btnThemHoSo.Image")));
            this.btnThemHoSo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThemHoSo.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThemHoSo.Location = new System.Drawing.Point(778, 39);
            this.btnThemHoSo.Name = "btnThemHoSo";
            this.btnThemHoSo.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnThemHoSo.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThemHoSo.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThemHoSo.OnHoverImage = null;
            this.btnThemHoSo.OnPressedColor = System.Drawing.Color.Black;
            this.btnThemHoSo.Radius = 15;
            this.btnThemHoSo.Size = new System.Drawing.Size(127, 42);
            this.btnThemHoSo.TabIndex = 24;
            this.btnThemHoSo.Text = "Thêm Hồ Sơ";
            this.btnThemHoSo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThemHoSo.Click += new System.EventHandler(this.btnThemHoSo_Click);
            // 
            // btnChuyenQTCT
            // 
            this.btnChuyenQTCT.AnimationHoverSpeed = 0.07F;
            this.btnChuyenQTCT.AnimationSpeed = 0.03F;
            this.btnChuyenQTCT.BackColor = System.Drawing.Color.Transparent;
            this.btnChuyenQTCT.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnChuyenQTCT.BorderColor = System.Drawing.Color.Black;
            this.btnChuyenQTCT.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnChuyenQTCT.FocusedColor = System.Drawing.Color.Empty;
            this.btnChuyenQTCT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChuyenQTCT.ForeColor = System.Drawing.Color.White;
            this.btnChuyenQTCT.Image = ((System.Drawing.Image)(resources.GetObject("btnChuyenQTCT.Image")));
            this.btnChuyenQTCT.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnChuyenQTCT.ImageSize = new System.Drawing.Size(20, 20);
            this.btnChuyenQTCT.Location = new System.Drawing.Point(192, 540);
            this.btnChuyenQTCT.Name = "btnChuyenQTCT";
            this.btnChuyenQTCT.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnChuyenQTCT.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnChuyenQTCT.OnHoverForeColor = System.Drawing.Color.White;
            this.btnChuyenQTCT.OnHoverImage = null;
            this.btnChuyenQTCT.OnPressedColor = System.Drawing.Color.Black;
            this.btnChuyenQTCT.Radius = 15;
            this.btnChuyenQTCT.Size = new System.Drawing.Size(160, 42);
            this.btnChuyenQTCT.TabIndex = 31;
            this.btnChuyenQTCT.Text = "Quá Trình Công Tác";
            this.btnChuyenQTCT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnChuyenNVCV
            // 
            this.btnChuyenNVCV.AnimationHoverSpeed = 0.07F;
            this.btnChuyenNVCV.AnimationSpeed = 0.03F;
            this.btnChuyenNVCV.BackColor = System.Drawing.Color.Transparent;
            this.btnChuyenNVCV.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnChuyenNVCV.BorderColor = System.Drawing.Color.Black;
            this.btnChuyenNVCV.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnChuyenNVCV.FocusedColor = System.Drawing.Color.Empty;
            this.btnChuyenNVCV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChuyenNVCV.ForeColor = System.Drawing.Color.White;
            this.btnChuyenNVCV.Image = ((System.Drawing.Image)(resources.GetObject("btnChuyenNVCV.Image")));
            this.btnChuyenNVCV.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnChuyenNVCV.ImageSize = new System.Drawing.Size(20, 20);
            this.btnChuyenNVCV.Location = new System.Drawing.Point(369, 540);
            this.btnChuyenNVCV.Name = "btnChuyenNVCV";
            this.btnChuyenNVCV.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnChuyenNVCV.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnChuyenNVCV.OnHoverForeColor = System.Drawing.Color.White;
            this.btnChuyenNVCV.OnHoverImage = null;
            this.btnChuyenNVCV.OnPressedColor = System.Drawing.Color.Black;
            this.btnChuyenNVCV.Radius = 15;
            this.btnChuyenNVCV.Size = new System.Drawing.Size(160, 42);
            this.btnChuyenNVCV.TabIndex = 32;
            this.btnChuyenNVCV.Text = "Nhân Viên - Chức Vụ";
            this.btnChuyenNVCV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnChuyenTDCM
            // 
            this.btnChuyenTDCM.AnimationHoverSpeed = 0.07F;
            this.btnChuyenTDCM.AnimationSpeed = 0.03F;
            this.btnChuyenTDCM.BackColor = System.Drawing.Color.Transparent;
            this.btnChuyenTDCM.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnChuyenTDCM.BorderColor = System.Drawing.Color.Black;
            this.btnChuyenTDCM.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnChuyenTDCM.FocusedColor = System.Drawing.Color.Empty;
            this.btnChuyenTDCM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChuyenTDCM.ForeColor = System.Drawing.Color.White;
            this.btnChuyenTDCM.Image = ((System.Drawing.Image)(resources.GetObject("btnChuyenTDCM.Image")));
            this.btnChuyenTDCM.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnChuyenTDCM.ImageSize = new System.Drawing.Size(20, 20);
            this.btnChuyenTDCM.Location = new System.Drawing.Point(540, 540);
            this.btnChuyenTDCM.Name = "btnChuyenTDCM";
            this.btnChuyenTDCM.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnChuyenTDCM.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnChuyenTDCM.OnHoverForeColor = System.Drawing.Color.White;
            this.btnChuyenTDCM.OnHoverImage = null;
            this.btnChuyenTDCM.OnPressedColor = System.Drawing.Color.Black;
            this.btnChuyenTDCM.Radius = 15;
            this.btnChuyenTDCM.Size = new System.Drawing.Size(160, 42);
            this.btnChuyenTDCM.TabIndex = 33;
            this.btnChuyenTDCM.Text = "Trình Độ Chuyên Môn";
            this.btnChuyenTDCM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnChuyenTDNN
            // 
            this.btnChuyenTDNN.AnimationHoverSpeed = 0.07F;
            this.btnChuyenTDNN.AnimationSpeed = 0.03F;
            this.btnChuyenTDNN.BackColor = System.Drawing.Color.Transparent;
            this.btnChuyenTDNN.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnChuyenTDNN.BorderColor = System.Drawing.Color.Black;
            this.btnChuyenTDNN.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnChuyenTDNN.FocusedColor = System.Drawing.Color.Empty;
            this.btnChuyenTDNN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChuyenTDNN.ForeColor = System.Drawing.Color.White;
            this.btnChuyenTDNN.Image = ((System.Drawing.Image)(resources.GetObject("btnChuyenTDNN.Image")));
            this.btnChuyenTDNN.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnChuyenTDNN.ImageSize = new System.Drawing.Size(20, 20);
            this.btnChuyenTDNN.Location = new System.Drawing.Point(706, 540);
            this.btnChuyenTDNN.Name = "btnChuyenTDNN";
            this.btnChuyenTDNN.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnChuyenTDNN.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnChuyenTDNN.OnHoverForeColor = System.Drawing.Color.White;
            this.btnChuyenTDNN.OnHoverImage = null;
            this.btnChuyenTDNN.OnPressedColor = System.Drawing.Color.Black;
            this.btnChuyenTDNN.Radius = 15;
            this.btnChuyenTDNN.Size = new System.Drawing.Size(160, 42);
            this.btnChuyenTDNN.TabIndex = 34;
            this.btnChuyenTDNN.Text = "Trình Độ Ngoại Ngữ";
            this.btnChuyenTDNN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel13
            // 
            this.gunaLabel13.AutoSize = true;
            this.gunaLabel13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel13.Location = new System.Drawing.Point(70, 552);
            this.gunaLabel13.Name = "gunaLabel13";
            this.gunaLabel13.Size = new System.Drawing.Size(84, 20);
            this.gunaLabel13.TabIndex = 35;
            this.gunaLabel13.Text = "Chuyển tới";
            // 
            // dtPickerNS
            // 
            this.dtPickerNS.BaseColor = System.Drawing.Color.White;
            this.dtPickerNS.BorderColor = System.Drawing.Color.Silver;
            this.dtPickerNS.CustomFormat = null;
            this.dtPickerNS.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtPickerNS.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtPickerNS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtPickerNS.ForeColor = System.Drawing.Color.Black;
            this.dtPickerNS.Location = new System.Drawing.Point(112, 158);
            this.dtPickerNS.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtPickerNS.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtPickerNS.Name = "dtPickerNS";
            this.dtPickerNS.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtPickerNS.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtPickerNS.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtPickerNS.OnPressedColor = System.Drawing.Color.Black;
            this.dtPickerNS.Size = new System.Drawing.Size(239, 30);
            this.dtPickerNS.TabIndex = 36;
            this.dtPickerNS.Text = "Wednesday, June 24, 2020";
            this.dtPickerNS.Value = new System.DateTime(2020, 6, 24, 9, 2, 11, 721);
            // 
            // dtPickerNTD
            // 
            this.dtPickerNTD.BaseColor = System.Drawing.Color.White;
            this.dtPickerNTD.BorderColor = System.Drawing.Color.Silver;
            this.dtPickerNTD.CustomFormat = null;
            this.dtPickerNTD.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtPickerNTD.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtPickerNTD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtPickerNTD.ForeColor = System.Drawing.Color.Black;
            this.dtPickerNTD.Location = new System.Drawing.Point(514, 63);
            this.dtPickerNTD.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtPickerNTD.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtPickerNTD.Name = "dtPickerNTD";
            this.dtPickerNTD.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtPickerNTD.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtPickerNTD.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtPickerNTD.OnPressedColor = System.Drawing.Color.Black;
            this.dtPickerNTD.Size = new System.Drawing.Size(239, 30);
            this.dtPickerNTD.TabIndex = 37;
            this.dtPickerNTD.Text = "Wednesday, June 24, 2020";
            this.dtPickerNTD.Value = new System.DateTime(2020, 6, 24, 9, 2, 11, 721);
            // 
            // frmQuanLyHoSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(925, 602);
            this.Controls.Add(this.dtPickerNTD);
            this.Controls.Add(this.dtPickerNS);
            this.Controls.Add(this.gunaLabel13);
            this.Controls.Add(this.btnChuyenTDNN);
            this.Controls.Add(this.btnChuyenTDCM);
            this.Controls.Add(this.btnChuyenNVCV);
            this.Controls.Add(this.btnChuyenQTCT);
            this.Controls.Add(this.btnNhapLai);
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
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbSoDT);
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
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private Guna.UI.WinForms.GunaTextBox txbSoDT;
        private Guna.UI.WinForms.GunaTextBox txbEmail;
        private Guna.UI.WinForms.GunaTextBox txbTaiKhoan;
        private Guna.UI.WinForms.GunaTextBox txbMatKhau;
        private Guna.UI.WinForms.GunaTextBox txbQuyen;
        private Guna.UI.WinForms.GunaComboBox cbBoxGioiTinh;
        private Guna.UI.WinForms.GunaComboBox cbBoxMaPB;
        private Guna.UI.WinForms.GunaDataGridView dtGridViewHoSo;
        private Guna.UI.WinForms.GunaButton btnNhapLai;
        private Guna.UI.WinForms.GunaButton btnXemHoSo;
        private Guna.UI.WinForms.GunaButton btnTimKiemHoSo;
        private Guna.UI.WinForms.GunaButton btnXoaHoSo;
        private Guna.UI.WinForms.GunaButton btnSuaHoSo;
        private Guna.UI.WinForms.GunaButton btnThemHoSo;
        private Guna.UI.WinForms.GunaButton btnChuyenQTCT;
        private Guna.UI.WinForms.GunaButton btnChuyenNVCV;
        private Guna.UI.WinForms.GunaButton btnChuyenTDCM;
        private Guna.UI.WinForms.GunaButton btnChuyenTDNN;
        private Guna.UI.WinForms.GunaLabel gunaLabel13;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanVien;
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
        private Guna.UI.WinForms.GunaDateTimePicker dtPickerNS;
        private Guna.UI.WinForms.GunaDateTimePicker dtPickerNTD;
    }
}