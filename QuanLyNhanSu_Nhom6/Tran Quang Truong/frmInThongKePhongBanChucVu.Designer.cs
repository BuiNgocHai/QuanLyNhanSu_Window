using Guna.UI.WinForms;
using System.Drawing;

namespace QuanLyNhanSu_Nhom6.Views
{
    partial class frmInThongKePhongBanChucVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInThongKePhongBanChucVu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.btnMinimize = new Guna.UI.WinForms.GunaButton();
            this.btnExit = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelChonMucThongKe = new Guna.UI.WinForms.GunaPanel();
            this.cbTenChucVu = new Guna.UI.WinForms.GunaComboBox();
            this.cbTenPhongBan = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.panelChonChucNang = new Guna.UI.WinForms.GunaPanel();
            this.rdChucVu = new System.Windows.Forms.RadioButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.rdPhongBan = new System.Windows.Forms.RadioButton();
            this.btnThongKe = new Guna.UI.WinForms.GunaButton();
            this.btnIn = new Guna.UI.WinForms.GunaButton();
            this.gunaDataGridView2 = new Guna.UI.WinForms.GunaDataGridView();
            this.maNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenPhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelChonMucThongKe.SuspendLayout();
            this.panelChonChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(1042, 205);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 11;
            this.gunaPictureBox1.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.AnimationHoverSpeed = 0.07F;
            this.btnMinimize.AnimationSpeed = 0.03F;
            this.btnMinimize.BaseColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BorderColor = System.Drawing.Color.Black;
            this.btnMinimize.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMinimize.FocusedColor = System.Drawing.Color.Empty;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMinimize.ImageSize = new System.Drawing.Size(20, 20);
            this.btnMinimize.Location = new System.Drawing.Point(1082, 30);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(35)))), ((int)(((byte)(119)))));
            this.btnMinimize.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMinimize.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMinimize.OnHoverImage = null;
            this.btnMinimize.OnPressedColor = System.Drawing.Color.Black;
            this.btnMinimize.Size = new System.Drawing.Size(36, 24);
            this.btnMinimize.TabIndex = 14;
            // 
            // btnExit
            // 
            this.btnExit.AnimationHoverSpeed = 0.07F;
            this.btnExit.AnimationSpeed = 0.03F;
            this.btnExit.BaseColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderColor = System.Drawing.Color.Black;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.FocusedColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExit.Location = new System.Drawing.Point(1141, 30);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(35)))), ((int)(((byte)(119)))));
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(27, 24);
            this.btnExit.TabIndex = 13;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(373, 30);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(298, 30);
            this.gunaLabel1.TabIndex = 12;
            this.gunaLabel1.Text = "Thống kê phòng ban/chức vụ";
            this.gunaLabel1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelChonMucThongKe);
            this.panel1.Controls.Add(this.panelChonChucNang);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.gunaPictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 397);
            this.panel1.TabIndex = 15;
            // 
            // panelChonMucThongKe
            // 
            this.panelChonMucThongKe.BackColor = System.Drawing.Color.Transparent;
            this.panelChonMucThongKe.Controls.Add(this.cbTenChucVu);
            this.panelChonMucThongKe.Controls.Add(this.cbTenPhongBan);
            this.panelChonMucThongKe.Controls.Add(this.gunaLabel5);
            this.panelChonMucThongKe.Controls.Add(this.gunaLabel4);
            this.panelChonMucThongKe.Controls.Add(this.gunaLabel3);
            this.panelChonMucThongKe.Location = new System.Drawing.Point(43, 209);
            this.panelChonMucThongKe.Name = "panelChonMucThongKe";
            this.panelChonMucThongKe.Size = new System.Drawing.Size(553, 167);
            this.panelChonMucThongKe.TabIndex = 19;
            // 
            // cbTenChucVu
            // 
            this.cbTenChucVu.BackColor = System.Drawing.Color.Transparent;
            this.cbTenChucVu.BaseColor = System.Drawing.Color.White;
            this.cbTenChucVu.BorderColor = System.Drawing.Color.Silver;
            this.cbTenChucVu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTenChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenChucVu.FocusedColor = System.Drawing.Color.Empty;
            this.cbTenChucVu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTenChucVu.ForeColor = System.Drawing.Color.Black;
            this.cbTenChucVu.FormattingEnabled = true;
            this.cbTenChucVu.Location = new System.Drawing.Point(179, 103);
            this.cbTenChucVu.Name = "cbTenChucVu";
            this.cbTenChucVu.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbTenChucVu.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbTenChucVu.Radius = 10;
            this.cbTenChucVu.Size = new System.Drawing.Size(237, 31);
            this.cbTenChucVu.TabIndex = 25;
            // 
            // cbTenPhongBan
            // 
            this.cbTenPhongBan.BackColor = System.Drawing.Color.Transparent;
            this.cbTenPhongBan.BaseColor = System.Drawing.Color.White;
            this.cbTenPhongBan.BorderColor = System.Drawing.Color.Silver;
            this.cbTenPhongBan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTenPhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenPhongBan.FocusedColor = System.Drawing.Color.Empty;
            this.cbTenPhongBan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTenPhongBan.ForeColor = System.Drawing.Color.Black;
            this.cbTenPhongBan.FormattingEnabled = true;
            this.cbTenPhongBan.Location = new System.Drawing.Point(179, 50);
            this.cbTenPhongBan.Name = "cbTenPhongBan";
            this.cbTenPhongBan.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbTenPhongBan.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbTenPhongBan.Radius = 10;
            this.cbTenPhongBan.Size = new System.Drawing.Size(237, 31);
            this.cbTenPhongBan.TabIndex = 24;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.ForeColor = System.Drawing.Color.White;
            this.gunaLabel5.Location = new System.Drawing.Point(21, 108);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(89, 20);
            this.gunaLabel5.TabIndex = 23;
            this.gunaLabel5.Text = "Tên chức vụ:";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.ForeColor = System.Drawing.Color.White;
            this.gunaLabel4.Location = new System.Drawing.Point(21, 55);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(111, 20);
            this.gunaLabel4.TabIndex = 22;
            this.gunaLabel4.Text = "Tên phòng ban:";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel3.ForeColor = System.Drawing.Color.White;
            this.gunaLabel3.Location = new System.Drawing.Point(21, 10);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(162, 23);
            this.gunaLabel3.TabIndex = 21;
            this.gunaLabel3.Text = "Chọn mục thống kê";
            // 
            // panelChonChucNang
            // 
            this.panelChonChucNang.BackColor = System.Drawing.Color.Transparent;
            this.panelChonChucNang.Controls.Add(this.rdChucVu);
            this.panelChonChucNang.Controls.Add(this.gunaLabel2);
            this.panelChonChucNang.Controls.Add(this.rdPhongBan);
            this.panelChonChucNang.Location = new System.Drawing.Point(43, 79);
            this.panelChonChucNang.Name = "panelChonChucNang";
            this.panelChonChucNang.Size = new System.Drawing.Size(416, 110);
            this.panelChonChucNang.TabIndex = 18;
            // 
            // rdChucVu
            // 
            this.rdChucVu.AutoSize = true;
            this.rdChucVu.BackColor = System.Drawing.Color.Transparent;
            this.rdChucVu.ForeColor = System.Drawing.Color.White;
            this.rdChucVu.Location = new System.Drawing.Point(237, 66);
            this.rdChucVu.Name = "rdChucVu";
            this.rdChucVu.Size = new System.Drawing.Size(115, 21);
            this.rdChucVu.TabIndex = 20;
            this.rdChucVu.TabStop = true;
            this.rdChucVu.Text = "Theo chức vụ";
            this.rdChucVu.UseVisualStyleBackColor = false;
            this.rdChucVu.CheckedChanged += new System.EventHandler(this.rdChucVu_CheckedChanged);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(21, 23);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(259, 23);
            this.gunaLabel2.TabIndex = 19;
            this.gunaLabel2.Text = "Chọn chức năng muốn thống kê";
            // 
            // rdPhongBan
            // 
            this.rdPhongBan.AutoSize = true;
            this.rdPhongBan.BackColor = System.Drawing.Color.Transparent;
            this.rdPhongBan.ForeColor = System.Drawing.Color.White;
            this.rdPhongBan.Location = new System.Drawing.Point(25, 66);
            this.rdPhongBan.Name = "rdPhongBan";
            this.rdPhongBan.Size = new System.Drawing.Size(134, 21);
            this.rdPhongBan.TabIndex = 18;
            this.rdPhongBan.TabStop = true;
            this.rdPhongBan.Text = "Theo phòng ban";
            this.rdPhongBan.UseVisualStyleBackColor = false;
            this.rdPhongBan.CheckedChanged += new System.EventHandler(this.rdPhongBan_CheckedChanged);
            // 
            // btnThongKe
            // 
            this.btnThongKe.AnimationHoverSpeed = 0.07F;
            this.btnThongKe.AnimationSpeed = 0.03F;
            this.btnThongKe.BackColor = System.Drawing.Color.Transparent;
            this.btnThongKe.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnThongKe.BorderColor = System.Drawing.Color.Black;
            this.btnThongKe.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThongKe.FocusedColor = System.Drawing.Color.Empty;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Image = ((System.Drawing.Image)(resources.GetObject("btnThongKe.Image")));
            this.btnThongKe.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThongKe.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThongKe.Location = new System.Drawing.Point(527, 624);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnThongKe.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThongKe.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThongKe.OnHoverImage = null;
            this.btnThongKe.OnPressedColor = System.Drawing.Color.Black;
            this.btnThongKe.Radius = 15;
            this.btnThongKe.Size = new System.Drawing.Size(160, 42);
            this.btnThongKe.TabIndex = 17;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnIn
            // 
            this.btnIn.AnimationHoverSpeed = 0.07F;
            this.btnIn.AnimationSpeed = 0.03F;
            this.btnIn.BackColor = System.Drawing.Color.Transparent;
            this.btnIn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnIn.BorderColor = System.Drawing.Color.Black;
            this.btnIn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnIn.FocusedColor = System.Drawing.Color.Empty;
            this.btnIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnIn.ForeColor = System.Drawing.Color.White;
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnIn.ImageSize = new System.Drawing.Size(20, 20);
            this.btnIn.Location = new System.Drawing.Point(790, 624);
            this.btnIn.Name = "btnIn";
            this.btnIn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnIn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnIn.OnHoverForeColor = System.Drawing.Color.White;
            this.btnIn.OnHoverImage = null;
            this.btnIn.OnPressedColor = System.Drawing.Color.Black;
            this.btnIn.Radius = 15;
            this.btnIn.Size = new System.Drawing.Size(160, 42);
            this.btnIn.TabIndex = 18;
            this.btnIn.Text = "In";
            this.btnIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // gunaDataGridView2
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.gunaDataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gunaDataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.gunaDataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gunaDataGridView2.ColumnHeadersHeight = 27;
            this.gunaDataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNV,
            this.hoTen,
            this.ngaySinh,
            this.gioiTinh,
            this.soDT,
            this.email,
            this.ngayTD,
            this.tenPhongBan,
            this.tenCV});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView2.DefaultCellStyle = dataGridViewCellStyle6;
            this.gunaDataGridView2.EnableHeadersVisualStyles = false;
            this.gunaDataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.gunaDataGridView2.Location = new System.Drawing.Point(0, 434);
            this.gunaDataGridView2.Name = "gunaDataGridView2";
            this.gunaDataGridView2.RowHeadersVisible = false;
            this.gunaDataGridView2.RowTemplate.Height = 24;
            this.gunaDataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView2.Size = new System.Drawing.Size(1045, 164);
            this.gunaDataGridView2.TabIndex = 19;
            this.gunaDataGridView2.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.FeterRiver;
            this.gunaDataGridView2.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.gunaDataGridView2.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView2.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView2.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.gunaDataGridView2.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.gunaDataGridView2.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.gunaDataGridView2.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView2.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView2.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView2.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView2.ThemeStyle.HeaderStyle.Height = 27;
            this.gunaDataGridView2.ThemeStyle.ReadOnly = false;
            this.gunaDataGridView2.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.gunaDataGridView2.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView2.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView2.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gunaDataGridView2.ThemeStyle.RowsStyle.Height = 24;
            this.gunaDataGridView2.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.gunaDataGridView2.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // maNV
            // 
            this.maNV.DataPropertyName = "MANV";
            this.maNV.HeaderText = "Mã NV";
            this.maNV.Name = "maNV";
            // 
            // hoTen
            // 
            this.hoTen.DataPropertyName = "HOTEN";
            this.hoTen.HeaderText = "Họ tên";
            this.hoTen.Name = "hoTen";
            // 
            // ngaySinh
            // 
            this.ngaySinh.DataPropertyName = "NGAYSINH";
            this.ngaySinh.HeaderText = "Ngày sinh";
            this.ngaySinh.Name = "ngaySinh";
            // 
            // gioiTinh
            // 
            this.gioiTinh.DataPropertyName = "GIOITINH";
            this.gioiTinh.HeaderText = "Giới tính";
            this.gioiTinh.Name = "gioiTinh";
            // 
            // soDT
            // 
            this.soDT.DataPropertyName = "SODT";
            this.soDT.HeaderText = "SĐT";
            this.soDT.Name = "soDT";
            // 
            // email
            // 
            this.email.DataPropertyName = "EMAIL";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // ngayTD
            // 
            this.ngayTD.DataPropertyName = "NGAYTD";
            this.ngayTD.HeaderText = "Ngày TD";
            this.ngayTD.Name = "ngayTD";
            // 
            // tenPhongBan
            // 
            this.tenPhongBan.DataPropertyName = "TENPB";
            this.tenPhongBan.HeaderText = "Phòng ban";
            this.tenPhongBan.Name = "tenPhongBan";
            // 
            // tenCV
            // 
            this.tenCV.DataPropertyName = "TENCV";
            this.tenCV.HeaderText = "Chức vụ";
            this.tenCV.Name = "tenCV";
            // 
            // frmInThongKePhongBanChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1045, 725);
            this.Controls.Add(this.gunaDataGridView2);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInThongKePhongBanChucVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInThongKePhongBanChucVu";
            this.Load += new System.EventHandler(this.frmInThongKePhongBanChucVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelChonMucThongKe.ResumeLayout(false);
            this.panelChonMucThongKe.PerformLayout();
            this.panelChonChucNang.ResumeLayout(false);
            this.panelChonChucNang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaButton btnMinimize;
        private Guna.UI.WinForms.GunaButton btnExit;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Panel panel1;
        private GunaPanel panelChonMucThongKe;
        private GunaPanel panelChonChucNang;
        private System.Windows.Forms.RadioButton rdChucVu;
        private GunaLabel gunaLabel2;
        private System.Windows.Forms.RadioButton rdPhongBan;
        private GunaLabel gunaLabel5;
        private GunaLabel gunaLabel4;
        private GunaLabel gunaLabel3;
        private GunaButton btnThongKe;
        private GunaButton btnIn;
        private GunaComboBox cbTenChucVu;
        private GunaComboBox cbTenPhongBan;
        private GunaDataGridView gunaDataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenCV;
    }
}