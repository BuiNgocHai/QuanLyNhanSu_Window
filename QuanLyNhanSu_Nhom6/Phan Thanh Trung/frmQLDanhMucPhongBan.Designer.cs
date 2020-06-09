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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLDanhMucPhongBan));
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.dtGridViewPhongBan = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox3 = new Guna.UI.WinForms.GunaTextBox();
            this.btnThemPhongBan = new Guna.UI.WinForms.GunaButton();
            this.btnSuaPhongBan = new Guna.UI.WinForms.GunaButton();
            this.btnXoaPhongBan = new Guna.UI.WinForms.GunaButton();
            this.btnThoat = new Guna.UI.WinForms.GunaButton();
            this.btnBoTimPhongBan = new Guna.UI.WinForms.GunaButton();
            this.btnTimKiemPhongBan = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewPhongBan)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(86, 188);
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
            this.gunaLabel3.Location = new System.Drawing.Point(86, 145);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(108, 17);
            this.gunaLabel3.TabIndex = 2;
            this.gunaLabel3.Text = "Tên Phòng Ban";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(86, 102);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(105, 17);
            this.gunaLabel4.TabIndex = 3;
            this.gunaLabel4.Text = "Mã Phòng Ban";
            // 
            // dtGridViewPhongBan
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtGridViewPhongBan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGridViewPhongBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridViewPhongBan.BackgroundColor = System.Drawing.Color.White;
            this.dtGridViewPhongBan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGridViewPhongBan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGridViewPhongBan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridViewPhongBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtGridViewPhongBan.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridViewPhongBan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtGridViewPhongBan.EnableHeadersVisualStyles = false;
            this.dtGridViewPhongBan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtGridViewPhongBan.Location = new System.Drawing.Point(77, 246);
            this.dtGridViewPhongBan.Name = "dtGridViewPhongBan";
            this.dtGridViewPhongBan.RowHeadersVisible = false;
            this.dtGridViewPhongBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridViewPhongBan.Size = new System.Drawing.Size(860, 288);
            this.dtGridViewPhongBan.TabIndex = 4;
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
            this.dtGridViewPhongBan.ThemeStyle.HeaderStyle.Height = 4;
            this.dtGridViewPhongBan.ThemeStyle.ReadOnly = false;
            this.dtGridViewPhongBan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtGridViewPhongBan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGridViewPhongBan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtGridViewPhongBan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtGridViewPhongBan.ThemeStyle.RowsStyle.Height = 22;
            this.dtGridViewPhongBan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtGridViewPhongBan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox1.Location = new System.Drawing.Point(236, 100);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.SelectedText = "";
            this.gunaTextBox1.Size = new System.Drawing.Size(344, 27);
            this.gunaTextBox1.TabIndex = 5;
            this.gunaTextBox1.TextChanged += new System.EventHandler(this.gunaTextBox1_TextChanged);
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox2.Location = new System.Drawing.Point(236, 143);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.SelectedText = "";
            this.gunaTextBox2.Size = new System.Drawing.Size(344, 27);
            this.gunaTextBox2.TabIndex = 6;
            this.gunaTextBox2.TextChanged += new System.EventHandler(this.gunaTextBox2_TextChanged);
            // 
            // gunaTextBox3
            // 
            this.gunaTextBox3.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox3.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox3.Location = new System.Drawing.Point(236, 186);
            this.gunaTextBox3.Name = "gunaTextBox3";
            this.gunaTextBox3.PasswordChar = '\0';
            this.gunaTextBox3.SelectedText = "";
            this.gunaTextBox3.Size = new System.Drawing.Size(344, 27);
            this.gunaTextBox3.TabIndex = 7;
            this.gunaTextBox3.TextChanged += new System.EventHandler(this.gunaTextBox3_TextChanged);
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
            this.btnThemPhongBan.Location = new System.Drawing.Point(617, 85);
            this.btnThemPhongBan.Name = "btnThemPhongBan";
            this.btnThemPhongBan.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnThemPhongBan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThemPhongBan.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThemPhongBan.OnHoverImage = null;
            this.btnThemPhongBan.OnPressedColor = System.Drawing.Color.Black;
            this.btnThemPhongBan.Size = new System.Drawing.Size(148, 42);
            this.btnThemPhongBan.TabIndex = 8;
            this.btnThemPhongBan.Text = "Thêm Phòng Ban";
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
            this.btnSuaPhongBan.Location = new System.Drawing.Point(617, 133);
            this.btnSuaPhongBan.Name = "btnSuaPhongBan";
            this.btnSuaPhongBan.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSuaPhongBan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSuaPhongBan.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSuaPhongBan.OnHoverImage = null;
            this.btnSuaPhongBan.OnPressedColor = System.Drawing.Color.Black;
            this.btnSuaPhongBan.Size = new System.Drawing.Size(148, 42);
            this.btnSuaPhongBan.TabIndex = 9;
            this.btnSuaPhongBan.Text = "Sửa Phòng Ban";
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
            this.btnXoaPhongBan.Location = new System.Drawing.Point(617, 181);
            this.btnXoaPhongBan.Name = "btnXoaPhongBan";
            this.btnXoaPhongBan.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnXoaPhongBan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXoaPhongBan.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXoaPhongBan.OnHoverImage = null;
            this.btnXoaPhongBan.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoaPhongBan.Size = new System.Drawing.Size(148, 42);
            this.btnXoaPhongBan.TabIndex = 10;
            this.btnXoaPhongBan.Text = "Xóa Phòng Ban";
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
            this.btnThoat.Location = new System.Drawing.Point(780, 181);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnThoat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThoat.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThoat.OnHoverImage = null;
            this.btnThoat.OnPressedColor = System.Drawing.Color.Black;
            this.btnThoat.Size = new System.Drawing.Size(148, 42);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
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
            this.btnBoTimPhongBan.Location = new System.Drawing.Point(780, 133);
            this.btnBoTimPhongBan.Name = "btnBoTimPhongBan";
            this.btnBoTimPhongBan.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnBoTimPhongBan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBoTimPhongBan.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBoTimPhongBan.OnHoverImage = null;
            this.btnBoTimPhongBan.OnPressedColor = System.Drawing.Color.Black;
            this.btnBoTimPhongBan.Size = new System.Drawing.Size(148, 42);
            this.btnBoTimPhongBan.TabIndex = 12;
            this.btnBoTimPhongBan.Text = "Bỏ Tìm";
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
            this.btnTimKiemPhongBan.Location = new System.Drawing.Point(780, 85);
            this.btnTimKiemPhongBan.Name = "btnTimKiemPhongBan";
            this.btnTimKiemPhongBan.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnTimKiemPhongBan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTimKiemPhongBan.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTimKiemPhongBan.OnHoverImage = null;
            this.btnTimKiemPhongBan.OnPressedColor = System.Drawing.Color.Black;
            this.btnTimKiemPhongBan.Size = new System.Drawing.Size(148, 42);
            this.btnTimKiemPhongBan.TabIndex = 11;
            this.btnTimKiemPhongBan.Text = "Tìm Kiếm";
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
            // frmQLDanhMucPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1012, 560);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnBoTimPhongBan);
            this.Controls.Add(this.btnTimKiemPhongBan);
            this.Controls.Add(this.btnXoaPhongBan);
            this.Controls.Add(this.btnSuaPhongBan);
            this.Controls.Add(this.btnThemPhongBan);
            this.Controls.Add(this.gunaTextBox3);
            this.Controls.Add(this.gunaTextBox2);
            this.Controls.Add(this.gunaTextBox1);
            this.Controls.Add(this.dtGridViewPhongBan);
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
        private Guna.UI.WinForms.GunaDataGridView dtGridViewPhongBan;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox2;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox3;
        private Guna.UI.WinForms.GunaButton btnThemPhongBan;
        private Guna.UI.WinForms.GunaButton btnSuaPhongBan;
        private Guna.UI.WinForms.GunaButton btnXoaPhongBan;
        private Guna.UI.WinForms.GunaButton btnThoat;
        private Guna.UI.WinForms.GunaButton btnBoTimPhongBan;
        private Guna.UI.WinForms.GunaButton btnTimKiemPhongBan;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
    }
}