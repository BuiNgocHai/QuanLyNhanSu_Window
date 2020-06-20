namespace QuanLyNhanSu_Nhom6.Views
{
    partial class frmQLDanhMucPhongBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLDanhMucPhongBan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txbMaPhongBan = new Guna.UI.WinForms.GunaTextBox();
            this.txbTenPhongBan = new Guna.UI.WinForms.GunaTextBox();
            this.txbNgayThanhLap = new Guna.UI.WinForms.GunaTextBox();
            this.btnThemPhongBan = new Guna.UI.WinForms.GunaButton();
            this.btnSuaPhongBan = new Guna.UI.WinForms.GunaButton();
            this.btnXoaPhongBan = new Guna.UI.WinForms.GunaButton();
            this.btnThoat = new Guna.UI.WinForms.GunaButton();
            this.btnBoTimPhongBan = new Guna.UI.WinForms.GunaButton();
            this.btnTimKiemPhongBan = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnNhapLai = new Guna.UI.WinForms.GunaButton();
            this.dtGridViewPhongBan = new Guna.UI.WinForms.GunaDataGridView();
            this.MAPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewPhongBan)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(154, 194);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(118, 17);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Ngày Thành Lập";
            this.gunaLabel2.Click += new System.EventHandler(this.gunaLabel2_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(154, 151);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(108, 17);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "Tên Phòng Ban";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(154, 108);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(105, 17);
            this.gunaLabel4.TabIndex = 3;
            this.gunaLabel4.Text = "Mã Phòng Ban";
            // 
            // txbMaPhongBan
            // 
            this.txbMaPhongBan.BaseColor = System.Drawing.Color.White;
            this.txbMaPhongBan.BorderColor = System.Drawing.Color.Silver;
            this.txbMaPhongBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbMaPhongBan.FocusedBaseColor = System.Drawing.Color.White;
            this.txbMaPhongBan.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txbMaPhongBan.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txbMaPhongBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbMaPhongBan.Location = new System.Drawing.Point(304, 106);
            this.txbMaPhongBan.Name = "txbMaPhongBan";
            this.txbMaPhongBan.PasswordChar = '\0';
            this.txbMaPhongBan.SelectedText = "";
            this.txbMaPhongBan.Size = new System.Drawing.Size(386, 27);
            this.txbMaPhongBan.TabIndex = 5;
            this.txbMaPhongBan.TextChanged += new System.EventHandler(this.gunaTextBox1_TextChanged);
            // 
            // txbTenPhongBan
            // 
            this.txbTenPhongBan.BaseColor = System.Drawing.Color.White;
            this.txbTenPhongBan.BorderColor = System.Drawing.Color.Silver;
            this.txbTenPhongBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTenPhongBan.FocusedBaseColor = System.Drawing.Color.White;
            this.txbTenPhongBan.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txbTenPhongBan.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txbTenPhongBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbTenPhongBan.Location = new System.Drawing.Point(304, 149);
            this.txbTenPhongBan.Name = "txbTenPhongBan";
            this.txbTenPhongBan.PasswordChar = '\0';
            this.txbTenPhongBan.SelectedText = "";
            this.txbTenPhongBan.Size = new System.Drawing.Size(386, 27);
            this.txbTenPhongBan.TabIndex = 6;
            this.txbTenPhongBan.TextChanged += new System.EventHandler(this.gunaTextBox2_TextChanged);
            // 
            // txbNgayThanhLap
            // 
            this.txbNgayThanhLap.BaseColor = System.Drawing.Color.White;
            this.txbNgayThanhLap.BorderColor = System.Drawing.Color.Silver;
            this.txbNgayThanhLap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNgayThanhLap.FocusedBaseColor = System.Drawing.Color.White;
            this.txbNgayThanhLap.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txbNgayThanhLap.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txbNgayThanhLap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txbNgayThanhLap.Location = new System.Drawing.Point(304, 192);
            this.txbNgayThanhLap.Name = "txbNgayThanhLap";
            this.txbNgayThanhLap.PasswordChar = '\0';
            this.txbNgayThanhLap.SelectedText = "";
            this.txbNgayThanhLap.Size = new System.Drawing.Size(386, 27);
            this.txbNgayThanhLap.TabIndex = 7;
            this.txbNgayThanhLap.TextChanged += new System.EventHandler(this.gunaTextBox3_TextChanged);
            // 
            // btnThemPhongBan
            // 
            this.btnThemPhongBan.AnimationHoverSpeed = 0.07F;
            this.btnThemPhongBan.AnimationSpeed = 0.03F;
            this.btnThemPhongBan.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnThemPhongBan.BorderColor = System.Drawing.Color.Black;
            this.btnThemPhongBan.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThemPhongBan.FocusedColor = System.Drawing.Color.Empty;
            this.btnThemPhongBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemPhongBan.ForeColor = System.Drawing.Color.White;
            this.btnThemPhongBan.Image = ((System.Drawing.Image)(resources.GetObject("btnThemPhongBan.Image")));
            this.btnThemPhongBan.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThemPhongBan.Location = new System.Drawing.Point(803, 158);
            this.btnThemPhongBan.Name = "btnThemPhongBan";
            this.btnThemPhongBan.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnThemPhongBan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThemPhongBan.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThemPhongBan.OnHoverImage = null;
            this.btnThemPhongBan.OnPressedColor = System.Drawing.Color.Black;
            this.btnThemPhongBan.Size = new System.Drawing.Size(148, 42);
            this.btnThemPhongBan.TabIndex = 8;
            this.btnThemPhongBan.Text = "Thêm Phòng Ban";
            this.btnThemPhongBan.Click += new System.EventHandler(this.btnThemPhongBan_Click);
            // 
            // btnSuaPhongBan
            // 
            this.btnSuaPhongBan.AnimationHoverSpeed = 0.07F;
            this.btnSuaPhongBan.AnimationSpeed = 0.03F;
            this.btnSuaPhongBan.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSuaPhongBan.BorderColor = System.Drawing.Color.Black;
            this.btnSuaPhongBan.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSuaPhongBan.FocusedColor = System.Drawing.Color.Empty;
            this.btnSuaPhongBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSuaPhongBan.ForeColor = System.Drawing.Color.White;
            this.btnSuaPhongBan.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaPhongBan.Image")));
            this.btnSuaPhongBan.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSuaPhongBan.Location = new System.Drawing.Point(803, 216);
            this.btnSuaPhongBan.Name = "btnSuaPhongBan";
            this.btnSuaPhongBan.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSuaPhongBan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSuaPhongBan.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSuaPhongBan.OnHoverImage = null;
            this.btnSuaPhongBan.OnPressedColor = System.Drawing.Color.Black;
            this.btnSuaPhongBan.Size = new System.Drawing.Size(148, 42);
            this.btnSuaPhongBan.TabIndex = 9;
            this.btnSuaPhongBan.Text = "Sửa Phòng Ban";
            this.btnSuaPhongBan.Click += new System.EventHandler(this.btnSuaPhongBan_Click);
            // 
            // btnXoaPhongBan
            // 
            this.btnXoaPhongBan.AnimationHoverSpeed = 0.07F;
            this.btnXoaPhongBan.AnimationSpeed = 0.03F;
            this.btnXoaPhongBan.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnXoaPhongBan.BorderColor = System.Drawing.Color.Black;
            this.btnXoaPhongBan.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXoaPhongBan.FocusedColor = System.Drawing.Color.Empty;
            this.btnXoaPhongBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoaPhongBan.ForeColor = System.Drawing.Color.White;
            this.btnXoaPhongBan.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaPhongBan.Image")));
            this.btnXoaPhongBan.ImageSize = new System.Drawing.Size(20, 20);
            this.btnXoaPhongBan.Location = new System.Drawing.Point(803, 274);
            this.btnXoaPhongBan.Name = "btnXoaPhongBan";
            this.btnXoaPhongBan.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnXoaPhongBan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXoaPhongBan.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXoaPhongBan.OnHoverImage = null;
            this.btnXoaPhongBan.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoaPhongBan.Size = new System.Drawing.Size(148, 42);
            this.btnXoaPhongBan.TabIndex = 10;
            this.btnXoaPhongBan.Text = "Xóa Phòng Ban";
            this.btnXoaPhongBan.Click += new System.EventHandler(this.btnXoaPhongBan_Click);
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
            this.btnThoat.Location = new System.Drawing.Point(803, 448);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnThoat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThoat.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThoat.OnHoverImage = null;
            this.btnThoat.OnPressedColor = System.Drawing.Color.Black;
            this.btnThoat.Size = new System.Drawing.Size(148, 42);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnBoTimPhongBan
            // 
            this.btnBoTimPhongBan.AnimationHoverSpeed = 0.07F;
            this.btnBoTimPhongBan.AnimationSpeed = 0.03F;
            this.btnBoTimPhongBan.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnBoTimPhongBan.BorderColor = System.Drawing.Color.Black;
            this.btnBoTimPhongBan.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBoTimPhongBan.FocusedColor = System.Drawing.Color.Empty;
            this.btnBoTimPhongBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBoTimPhongBan.ForeColor = System.Drawing.Color.White;
            this.btnBoTimPhongBan.Image = ((System.Drawing.Image)(resources.GetObject("btnBoTimPhongBan.Image")));
            this.btnBoTimPhongBan.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBoTimPhongBan.Location = new System.Drawing.Point(803, 390);
            this.btnBoTimPhongBan.Name = "btnBoTimPhongBan";
            this.btnBoTimPhongBan.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnBoTimPhongBan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBoTimPhongBan.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBoTimPhongBan.OnHoverImage = null;
            this.btnBoTimPhongBan.OnPressedColor = System.Drawing.Color.Black;
            this.btnBoTimPhongBan.Size = new System.Drawing.Size(148, 42);
            this.btnBoTimPhongBan.TabIndex = 12;
            this.btnBoTimPhongBan.Text = "Xem";
            this.btnBoTimPhongBan.Click += new System.EventHandler(this.btnBoTimPhongBan_Click);
            // 
            // btnTimKiemPhongBan
            // 
            this.btnTimKiemPhongBan.AnimationHoverSpeed = 0.07F;
            this.btnTimKiemPhongBan.AnimationSpeed = 0.03F;
            this.btnTimKiemPhongBan.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnTimKiemPhongBan.BorderColor = System.Drawing.Color.Black;
            this.btnTimKiemPhongBan.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTimKiemPhongBan.FocusedColor = System.Drawing.Color.Empty;
            this.btnTimKiemPhongBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTimKiemPhongBan.ForeColor = System.Drawing.Color.White;
            this.btnTimKiemPhongBan.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemPhongBan.Image")));
            this.btnTimKiemPhongBan.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTimKiemPhongBan.Location = new System.Drawing.Point(803, 332);
            this.btnTimKiemPhongBan.Name = "btnTimKiemPhongBan";
            this.btnTimKiemPhongBan.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnTimKiemPhongBan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTimKiemPhongBan.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTimKiemPhongBan.OnHoverImage = null;
            this.btnTimKiemPhongBan.OnPressedColor = System.Drawing.Color.Black;
            this.btnTimKiemPhongBan.Size = new System.Drawing.Size(148, 42);
            this.btnTimKiemPhongBan.TabIndex = 11;
            this.btnTimKiemPhongBan.Text = "Tìm Kiếm";
            this.btnTimKiemPhongBan.Click += new System.EventHandler(this.btnTimKiemPhongBan_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.FloralWhite;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaLabel1.Location = new System.Drawing.Point(391, 25);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(263, 32);
            this.gunaLabel1.TabIndex = 16;
            this.gunaLabel1.Text = "Danh Mục Phòng Ban";
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
            this.btnNhapLai.Location = new System.Drawing.Point(803, 100);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnNhapLai.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnNhapLai.OnHoverForeColor = System.Drawing.Color.White;
            this.btnNhapLai.OnHoverImage = null;
            this.btnNhapLai.OnPressedColor = System.Drawing.Color.Black;
            this.btnNhapLai.Size = new System.Drawing.Size(148, 42);
            this.btnNhapLai.TabIndex = 17;
            this.btnNhapLai.Text = "Nhập Lại";
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // dtGridViewPhongBan
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dtGridViewPhongBan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dtGridViewPhongBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridViewPhongBan.BackgroundColor = System.Drawing.Color.White;
            this.dtGridViewPhongBan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGridViewPhongBan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGridViewPhongBan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridViewPhongBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dtGridViewPhongBan.ColumnHeadersHeight = 21;
            this.dtGridViewPhongBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAPB,
            this.TENPB,
            this.NGAYTL});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridViewPhongBan.DefaultCellStyle = dataGridViewCellStyle15;
            this.dtGridViewPhongBan.EnableHeadersVisualStyles = false;
            this.dtGridViewPhongBan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtGridViewPhongBan.Location = new System.Drawing.Point(87, 296);
            this.dtGridViewPhongBan.Name = "dtGridViewPhongBan";
            this.dtGridViewPhongBan.RowHeadersVisible = false;
            this.dtGridViewPhongBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridViewPhongBan.Size = new System.Drawing.Size(686, 241);
            this.dtGridViewPhongBan.TabIndex = 18;
            this.dtGridViewPhongBan.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dtGridViewPhongBan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtGridViewPhongBan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtGridViewPhongBan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtGridViewPhongBan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtGridViewPhongBan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtGridViewPhongBan.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtGridViewPhongBan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtGridViewPhongBan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtGridViewPhongBan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtGridViewPhongBan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtGridViewPhongBan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtGridViewPhongBan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtGridViewPhongBan.ThemeStyle.HeaderStyle.Height = 21;
            this.dtGridViewPhongBan.ThemeStyle.ReadOnly = false;
            this.dtGridViewPhongBan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtGridViewPhongBan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGridViewPhongBan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtGridViewPhongBan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtGridViewPhongBan.ThemeStyle.RowsStyle.Height = 22;
            this.dtGridViewPhongBan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtGridViewPhongBan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtGridViewPhongBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridViewPhongBan_CellClick);
            this.dtGridViewPhongBan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridViewPhongBan_CellContentClick);
            // 
            // MAPB
            // 
            this.MAPB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MAPB.DataPropertyName = "MAPB";
            this.MAPB.HeaderText = "Mã Phòng Ban";
            this.MAPB.MinimumWidth = 50;
            this.MAPB.Name = "MAPB";
            // 
            // TENPB
            // 
            this.TENPB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENPB.DataPropertyName = "TENPB";
            this.TENPB.HeaderText = "Tên Phòng Ban";
            this.TENPB.MinimumWidth = 50;
            this.TENPB.Name = "TENPB";
            // 
            // NGAYTL
            // 
            this.NGAYTL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NGAYTL.DataPropertyName = "NGAYTL";
            this.NGAYTL.HeaderText = "Ngày Thành Lập";
            this.NGAYTL.MinimumWidth = 50;
            this.NGAYTL.Name = "NGAYTL";
            // 
            // frmQLDanhMucPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1012, 560);
            this.Controls.Add(this.dtGridViewPhongBan);
            this.Controls.Add(this.btnNhapLai);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnBoTimPhongBan);
            this.Controls.Add(this.btnTimKiemPhongBan);
            this.Controls.Add(this.btnXoaPhongBan);
            this.Controls.Add(this.btnSuaPhongBan);
            this.Controls.Add(this.btnThemPhongBan);
            this.Controls.Add(this.txbNgayThanhLap);
            this.Controls.Add(this.txbTenPhongBan);
            this.Controls.Add(this.txbMaPhongBan);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Name = "frmQLDanhMucPhongBan";
            this.Text = "frmQLDanhMucPhongBan";
            this.Load += new System.EventHandler(this.frmQLDanhMucPhongBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewPhongBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaTextBox txbMaPhongBan;
        private Guna.UI.WinForms.GunaTextBox txbTenPhongBan;
        private Guna.UI.WinForms.GunaTextBox txbNgayThanhLap;
        private Guna.UI.WinForms.GunaButton btnThemPhongBan;
        private Guna.UI.WinForms.GunaButton btnSuaPhongBan;
        private Guna.UI.WinForms.GunaButton btnXoaPhongBan;
        private Guna.UI.WinForms.GunaButton btnThoat;
        private Guna.UI.WinForms.GunaButton btnBoTimPhongBan;
        private Guna.UI.WinForms.GunaButton btnTimKiemPhongBan;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton btnNhapLai;
        private Guna.UI.WinForms.GunaDataGridView dtGridViewPhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYTL;
    }
}