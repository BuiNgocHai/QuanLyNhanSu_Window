namespace QuanLyNhanSu_Nhom6.Views
{
    partial class frmQuanLyTrinhDoChuyenMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyTrinhDoChuyenMon));
            this.pl = new Guna.UI.WinForms.GunaPanel();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNganh = new Guna.UI.WinForms.GunaTextBox();
            this.codeTenNV = new Guna.UI.WinForms.GunaLabel();
            this.btnThoat = new Guna.UI.WinForms.GunaButton();
            this.btnXoa = new Guna.UI.WinForms.GunaButton();
            this.btnCapNhat = new Guna.UI.WinForms.GunaButton();
            this.btnThem = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.cbbLoaiHinhDaoTao = new Guna.UI.WinForms.GunaComboBox();
            this.cbbTrinhDo = new Guna.UI.WinForms.GunaComboBox();
            this.txtTruongDaoTao = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.btnTimKiem = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtMaNhanVien = new Guna.UI.WinForms.GunaTextBox();
            this.pl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pl
            // 
            this.pl.Controls.Add(this.gunaDataGridView1);
            this.pl.Controls.Add(this.txtNganh);
            this.pl.Controls.Add(this.codeTenNV);
            this.pl.Controls.Add(this.btnThoat);
            this.pl.Controls.Add(this.btnXoa);
            this.pl.Controls.Add(this.btnCapNhat);
            this.pl.Controls.Add(this.btnThem);
            this.pl.Controls.Add(this.gunaLabel8);
            this.pl.Controls.Add(this.cbbLoaiHinhDaoTao);
            this.pl.Controls.Add(this.cbbTrinhDo);
            this.pl.Controls.Add(this.txtTruongDaoTao);
            this.pl.Controls.Add(this.gunaLabel7);
            this.pl.Controls.Add(this.gunaLabel6);
            this.pl.Controls.Add(this.gunaLabel5);
            this.pl.Controls.Add(this.gunaLabel4);
            this.pl.Controls.Add(this.gunaLabel3);
            this.pl.Controls.Add(this.gunaLabel2);
            this.pl.Location = new System.Drawing.Point(-1, 133);
            this.pl.Name = "pl";
            this.pl.Size = new System.Drawing.Size(1208, 603);
            this.pl.TabIndex = 0;
            // 
            // gunaDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDataGridView1.ColumnHeadersHeight = 27;
            this.gunaDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(120, 371);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowTemplate.Height = 24;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(918, 149);
            this.gunaDataGridView1.TabIndex = 23;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 27;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = false;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã nhân viên";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ngành";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Trình độ";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Loại hình đào tạo";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Trường đào tạo";
            this.Column5.Name = "Column5";
            // 
            // txtNganh
            // 
            this.txtNganh.BaseColor = System.Drawing.Color.White;
            this.txtNganh.BorderColor = System.Drawing.Color.Silver;
            this.txtNganh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNganh.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNganh.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNganh.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNganh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNganh.Location = new System.Drawing.Point(353, 137);
            this.txtNganh.Name = "txtNganh";
            this.txtNganh.PasswordChar = '\0';
            this.txtNganh.SelectedText = "";
            this.txtNganh.Size = new System.Drawing.Size(286, 30);
            this.txtNganh.TabIndex = 22;
            // 
            // codeTenNV
            // 
            this.codeTenNV.AutoSize = true;
            this.codeTenNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.codeTenNV.Location = new System.Drawing.Point(157, 28);
            this.codeTenNV.Name = "codeTenNV";
            this.codeTenNV.Size = new System.Drawing.Size(85, 20);
            this.codeTenNV.TabIndex = 21;
            this.codeTenNV.Text = "codeTenNV";
            // 
            // btnThoat
            // 
            this.btnThoat.AnimationHoverSpeed = 0.07F;
            this.btnThoat.AnimationSpeed = 0.03F;
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnThoat.BorderColor = System.Drawing.Color.Black;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThoat.FocusedColor = System.Drawing.Color.Empty;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThoat.Location = new System.Drawing.Point(693, 203);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnThoat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThoat.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThoat.OnHoverImage = null;
            this.btnThoat.OnPressedColor = System.Drawing.Color.Black;
            this.btnThoat.Radius = 20;
            this.btnThoat.Size = new System.Drawing.Size(143, 35);
            this.btnThoat.TabIndex = 20;
            this.btnThoat.Text = "Thoát";
            // 
            // btnXoa
            // 
            this.btnXoa.AnimationHoverSpeed = 0.07F;
            this.btnXoa.AnimationSpeed = 0.03F;
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnXoa.BorderColor = System.Drawing.Color.Black;
            this.btnXoa.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXoa.FocusedColor = System.Drawing.Color.Empty;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageSize = new System.Drawing.Size(20, 20);
            this.btnXoa.Location = new System.Drawing.Point(853, 201);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnXoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXoa.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXoa.OnHoverImage = null;
            this.btnXoa.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoa.Radius = 20;
            this.btnXoa.Size = new System.Drawing.Size(143, 35);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xoá";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.AnimationHoverSpeed = 0.07F;
            this.btnCapNhat.AnimationSpeed = 0.03F;
            this.btnCapNhat.BackColor = System.Drawing.Color.Transparent;
            this.btnCapNhat.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnCapNhat.BorderColor = System.Drawing.Color.Black;
            this.btnCapNhat.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCapNhat.FocusedColor = System.Drawing.Color.Empty;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCapNhat.Location = new System.Drawing.Point(853, 147);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCapNhat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCapNhat.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCapNhat.OnHoverImage = null;
            this.btnCapNhat.OnPressedColor = System.Drawing.Color.Black;
            this.btnCapNhat.Radius = 20;
            this.btnCapNhat.Size = new System.Drawing.Size(143, 35);
            this.btnCapNhat.TabIndex = 17;
            this.btnCapNhat.Text = "Cập nhật";
            // 
            // btnThem
            // 
            this.btnThem.AnimationHoverSpeed = 0.07F;
            this.btnThem.AnimationSpeed = 0.03F;
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnThem.BorderColor = System.Drawing.Color.Black;
            this.btnThem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThem.FocusedColor = System.Drawing.Color.Empty;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThem.Location = new System.Drawing.Point(693, 147);
            this.btnThem.Name = "btnThem";
            this.btnThem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnThem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThem.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThem.OnHoverImage = null;
            this.btnThem.OnPressedColor = System.Drawing.Color.Black;
            this.btnThem.Radius = 20;
            this.btnThem.Size = new System.Drawing.Size(139, 35);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Them";
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel8.Location = new System.Drawing.Point(362, 108);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(86, 20);
            this.gunaLabel8.TabIndex = 14;
            this.gunaLabel8.Text = "gunaLabel8";
            // 
            // cbbLoaiHinhDaoTao
            // 
            this.cbbLoaiHinhDaoTao.BackColor = System.Drawing.Color.Transparent;
            this.cbbLoaiHinhDaoTao.BaseColor = System.Drawing.Color.White;
            this.cbbLoaiHinhDaoTao.BorderColor = System.Drawing.Color.Silver;
            this.cbbLoaiHinhDaoTao.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbLoaiHinhDaoTao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiHinhDaoTao.FocusedColor = System.Drawing.Color.Empty;
            this.cbbLoaiHinhDaoTao.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbLoaiHinhDaoTao.ForeColor = System.Drawing.Color.Black;
            this.cbbLoaiHinhDaoTao.FormattingEnabled = true;
            this.cbbLoaiHinhDaoTao.Location = new System.Drawing.Point(353, 221);
            this.cbbLoaiHinhDaoTao.Name = "cbbLoaiHinhDaoTao";
            this.cbbLoaiHinhDaoTao.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbLoaiHinhDaoTao.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbLoaiHinhDaoTao.Size = new System.Drawing.Size(286, 31);
            this.cbbLoaiHinhDaoTao.TabIndex = 13;
            // 
            // cbbTrinhDo
            // 
            this.cbbTrinhDo.BackColor = System.Drawing.Color.Transparent;
            this.cbbTrinhDo.BaseColor = System.Drawing.Color.White;
            this.cbbTrinhDo.BorderColor = System.Drawing.Color.Silver;
            this.cbbTrinhDo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTrinhDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTrinhDo.FocusedColor = System.Drawing.Color.Empty;
            this.cbbTrinhDo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbTrinhDo.ForeColor = System.Drawing.Color.Black;
            this.cbbTrinhDo.FormattingEnabled = true;
            this.cbbTrinhDo.Location = new System.Drawing.Point(353, 173);
            this.cbbTrinhDo.Name = "cbbTrinhDo";
            this.cbbTrinhDo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbTrinhDo.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbTrinhDo.Size = new System.Drawing.Size(286, 31);
            this.cbbTrinhDo.TabIndex = 12;
            // 
            // txtTruongDaoTao
            // 
            this.txtTruongDaoTao.BaseColor = System.Drawing.Color.White;
            this.txtTruongDaoTao.BorderColor = System.Drawing.Color.Silver;
            this.txtTruongDaoTao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTruongDaoTao.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTruongDaoTao.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTruongDaoTao.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTruongDaoTao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTruongDaoTao.Location = new System.Drawing.Point(353, 258);
            this.txtTruongDaoTao.Name = "txtTruongDaoTao";
            this.txtTruongDaoTao.PasswordChar = '\0';
            this.txtTruongDaoTao.SelectedText = "";
            this.txtTruongDaoTao.Size = new System.Drawing.Size(286, 30);
            this.txtTruongDaoTao.TabIndex = 10;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel7.Location = new System.Drawing.Point(30, 28);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(99, 20);
            this.gunaLabel7.TabIndex = 5;
            this.gunaLabel7.Text = "Tên nhân viên";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.Location = new System.Drawing.Point(173, 268);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(116, 20);
            this.gunaLabel6.TabIndex = 4;
            this.gunaLabel6.Text = "Trường  đạo tạo";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(173, 230);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(125, 20);
            this.gunaLabel5.TabIndex = 3;
            this.gunaLabel5.Text = "Loại hình đào tạo";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(229, 184);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(63, 20);
            this.gunaLabel4.TabIndex = 2;
            this.gunaLabel4.Text = "Trình độ";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(229, 147);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(57, 20);
            this.gunaLabel3.TabIndex = 1;
            this.gunaLabel3.Text = "Ngành ";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(201, 108);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(97, 20);
            this.gunaLabel2.TabIndex = 0;
            this.gunaLabel2.Text = "Mã nhân viên";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AnimationHoverSpeed = 0.07F;
            this.btnTimKiem.AnimationSpeed = 0.03F;
            this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnTimKiem.BorderColor = System.Drawing.Color.Black;
            this.btnTimKiem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTimKiem.FocusedColor = System.Drawing.Color.Empty;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTimKiem.Location = new System.Drawing.Point(727, 41);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnTimKiem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTimKiem.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTimKiem.OnHoverImage = null;
            this.btnTimKiem.OnPressedColor = System.Drawing.Color.Black;
            this.btnTimKiem.Radius = 20;
            this.btnTimKiem.Size = new System.Drawing.Size(119, 42);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(348, 63);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(97, 20);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Mã nhân viên";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.BaseColor = System.Drawing.Color.White;
            this.txtMaNhanVien.BorderColor = System.Drawing.Color.Silver;
            this.txtMaNhanVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNhanVien.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMaNhanVien.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMaNhanVien.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaNhanVien.Location = new System.Drawing.Point(451, 51);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.PasswordChar = '\0';
            this.txtMaNhanVien.SelectedText = "";
            this.txtMaNhanVien.Size = new System.Drawing.Size(252, 32);
            this.txtMaNhanVien.TabIndex = 2;
            // 
            // frmQuanLyTrinhDoChuyenMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 739);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.pl);
            this.Controls.Add(this.btnTimKiem);
            this.Name = "frmQuanLyTrinhDoChuyenMon";
            this.Text = "frmQuanLyTrinhDoChuyenMon";
            this.Load += new System.EventHandler(this.frmQuanLyTrinhDoChuyenMon_Load);
            this.pl.ResumeLayout(false);
            this.pl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel pl;
        private Guna.UI.WinForms.GunaButton btnTimKiem;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox txtMaNhanVien;
        private Guna.UI.WinForms.GunaTextBox txtTruongDaoTao;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaComboBox cbbLoaiHinhDaoTao;
        private Guna.UI.WinForms.GunaComboBox cbbTrinhDo;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaLabel codeTenNV;
        private Guna.UI.WinForms.GunaButton btnThoat;
        private Guna.UI.WinForms.GunaButton btnXoa;
        private Guna.UI.WinForms.GunaButton btnCapNhat;
        private Guna.UI.WinForms.GunaButton btnThem;
        private Guna.UI.WinForms.GunaTextBox txtNganh;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}