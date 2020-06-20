using System;
using System.Windows.Forms;

namespace GUI.Hai
{
    partial class frmQuanLyTrinhDoNgoaiNgu
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
            this.btnTimKiem = new Guna.UI.WinForms.GunaAdvenceButton();
            this.lbMaNV = new Guna.UI.WinForms.GunaLabel();
            this.txtMaNV = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.cbTrinhDo = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.btnXoa = new Guna.UI.WinForms.GunaButton();
            this.btnCapNhat = new Guna.UI.WinForms.GunaButton();
            this.btnThem = new Guna.UI.WinForms.GunaButton();
            this.codeTenNV = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.cbNgoaiNgu = new Guna.UI.WinForms.GunaComboBox();
            this.codeMaCV = new Guna.UI.WinForms.GunaLabel();
            this.codeMaNV = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.btnMinimize = new Guna.UI.WinForms.GunaButton();
            this.btnExit = new Guna.UI.WinForms.GunaButton();
            this.manhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngoaingu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trinhDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AnimationHoverSpeed = 0.07F;
            this.btnTimKiem.AnimationSpeed = 0.03F;
            this.btnTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.btnTimKiem.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnTimKiem.BorderColor = System.Drawing.Color.Black;
            this.btnTimKiem.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnTimKiem.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnTimKiem.CheckedForeColor = System.Drawing.Color.White;
            this.btnTimKiem.CheckedImage = null;
            this.btnTimKiem.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnTimKiem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTimKiem.FocusedColor = System.Drawing.Color.Empty;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Image = null;
            this.btnTimKiem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTimKiem.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTimKiem.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnTimKiem.Location = new System.Drawing.Point(438, 97);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnTimKiem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTimKiem.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTimKiem.OnHoverImage = null;
            this.btnTimKiem.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnTimKiem.OnPressedColor = System.Drawing.Color.Black;
            this.btnTimKiem.Radius = 15;
            this.btnTimKiem.Size = new System.Drawing.Size(119, 37);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbMaNV.ForeColor = System.Drawing.Color.White;
            this.lbMaNV.Location = new System.Drawing.Point(52, 115);
            this.lbMaNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(96, 19);
            this.lbMaNV.TabIndex = 2;
            this.lbMaNV.Text = "Mã nhân viên:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.BackColor = System.Drawing.Color.Transparent;
            this.txtMaNV.BaseColor = System.Drawing.Color.White;
            this.txtMaNV.BorderColor = System.Drawing.Color.Silver;
            this.txtMaNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNV.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMaNV.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMaNV.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaNV.Location = new System.Drawing.Point(180, 108);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.PasswordChar = '\0';
            this.txtMaNV.Radius = 10;
            this.txtMaNV.SelectedText = "";
            this.txtMaNV.Size = new System.Drawing.Size(220, 26);
            this.txtMaNV.TabIndex = 1;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(246, 33);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(240, 25);
            this.gunaLabel2.TabIndex = 4;
            this.gunaLabel2.Text = "Quản Lý Trinh Độ Ngoại Ngữ";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPanel1.Controls.Add(this.btnThoat);
            this.gunaPanel1.Controls.Add(this.cbTrinhDo);
            this.gunaPanel1.Controls.Add(this.gunaLabel8);
            this.gunaPanel1.Controls.Add(this.btnXoa);
            this.gunaPanel1.Controls.Add(this.btnCapNhat);
            this.gunaPanel1.Controls.Add(this.btnThem);
            this.gunaPanel1.Controls.Add(this.codeTenNV);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Controls.Add(this.cbNgoaiNgu);
            this.gunaPanel1.Controls.Add(this.codeMaCV);
            this.gunaPanel1.Controls.Add(this.codeMaNV);
            this.gunaPanel1.Controls.Add(this.gunaLabel6);
            this.gunaPanel1.Controls.Add(this.gunaLabel5);
            this.gunaPanel1.Controls.Add(this.gunaLabel3);
            this.gunaPanel1.Controls.Add(this.gunaDataGridView1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 188);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(784, 401);
            this.gunaPanel1.TabIndex = 6;
            this.gunaPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel1_Paint);
            // 
            // cbTrinhDo
            // 
            this.cbTrinhDo.BackColor = System.Drawing.Color.Transparent;
            this.cbTrinhDo.BaseColor = System.Drawing.Color.White;
            this.cbTrinhDo.BorderColor = System.Drawing.Color.Silver;
            this.cbTrinhDo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTrinhDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrinhDo.FocusedColor = System.Drawing.Color.Empty;
            this.cbTrinhDo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTrinhDo.ForeColor = System.Drawing.Color.Black;
            this.cbTrinhDo.FormattingEnabled = true;
            this.cbTrinhDo.Location = new System.Drawing.Point(180, 139);
            this.cbTrinhDo.Margin = new System.Windows.Forms.Padding(2);
            this.cbTrinhDo.Name = "cbTrinhDo";
            this.cbTrinhDo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbTrinhDo.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbTrinhDo.Radius = 10;
            this.cbTrinhDo.Size = new System.Drawing.Size(222, 26);
            this.cbTrinhDo.TabIndex = 41;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel8.ForeColor = System.Drawing.Color.White;
            this.gunaLabel8.Location = new System.Drawing.Point(261, 246);
            this.gunaLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(281, 19);
            this.gunaLabel8.TabIndex = 40;
            this.gunaLabel8.Text = "Danh sách trình độ ngoại ngữ của nhân viên";
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
            this.btnXoa.Image = null;
            this.btnXoa.ImageSize = new System.Drawing.Size(20, 20);
            this.btnXoa.Location = new System.Drawing.Point(548, 146);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnXoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXoa.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXoa.OnHoverImage = null;
            this.btnXoa.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoa.Radius = 15;
            this.btnXoa.Size = new System.Drawing.Size(91, 33);
            this.btnXoa.TabIndex = 37;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnCapNhat.Image = null;
            this.btnCapNhat.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCapNhat.Location = new System.Drawing.Point(668, 98);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCapNhat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCapNhat.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCapNhat.OnHoverImage = null;
            this.btnCapNhat.OnPressedColor = System.Drawing.Color.Black;
            this.btnCapNhat.Radius = 15;
            this.btnCapNhat.Size = new System.Drawing.Size(91, 33);
            this.btnCapNhat.TabIndex = 36;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
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
            this.btnThem.Image = null;
            this.btnThem.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThem.Location = new System.Drawing.Point(548, 98);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnThem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThem.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThem.OnHoverImage = null;
            this.btnThem.OnPressedColor = System.Drawing.Color.Black;
            this.btnThem.Radius = 15;
            this.btnThem.Size = new System.Drawing.Size(91, 33);
            this.btnThem.TabIndex = 38;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // codeTenNV
            // 
            this.codeTenNV.AutoSize = true;
            this.codeTenNV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.codeTenNV.ForeColor = System.Drawing.Color.White;
            this.codeTenNV.Location = new System.Drawing.Point(363, 16);
            this.codeTenNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.codeTenNV.Name = "codeTenNV";
            this.codeTenNV.Size = new System.Drawing.Size(0, 19);
            this.codeTenNV.TabIndex = 35;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(247, 16);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(97, 19);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Tên nhân viên:";
            // 
            // cbNgoaiNgu
            // 
            this.cbNgoaiNgu.BackColor = System.Drawing.Color.Transparent;
            this.cbNgoaiNgu.BaseColor = System.Drawing.Color.White;
            this.cbNgoaiNgu.BorderColor = System.Drawing.Color.Silver;
            this.cbNgoaiNgu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbNgoaiNgu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNgoaiNgu.FocusedColor = System.Drawing.Color.Empty;
            this.cbNgoaiNgu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbNgoaiNgu.ForeColor = System.Drawing.Color.Black;
            this.cbNgoaiNgu.FormattingEnabled = true;
            this.cbNgoaiNgu.Location = new System.Drawing.Point(180, 92);
            this.cbNgoaiNgu.Margin = new System.Windows.Forms.Padding(2);
            this.cbNgoaiNgu.Name = "cbNgoaiNgu";
            this.cbNgoaiNgu.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbNgoaiNgu.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbNgoaiNgu.Radius = 10;
            this.cbNgoaiNgu.Size = new System.Drawing.Size(222, 26);
            this.cbNgoaiNgu.TabIndex = 32;
            this.cbNgoaiNgu.SelectedValueChanged += new System.EventHandler(this.cbTenCV_SelectedValueChanged);
            // 
            // codeMaCV
            // 
            this.codeMaCV.AutoSize = true;
            this.codeMaCV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.codeMaCV.ForeColor = System.Drawing.Color.White;
            this.codeMaCV.Location = new System.Drawing.Point(177, 56);
            this.codeMaCV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.codeMaCV.Name = "codeMaCV";
            this.codeMaCV.Size = new System.Drawing.Size(0, 19);
            this.codeMaCV.TabIndex = 31;
            // 
            // codeMaNV
            // 
            this.codeMaNV.AutoSize = true;
            this.codeMaNV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.codeMaNV.ForeColor = System.Drawing.Color.White;
            this.codeMaNV.Location = new System.Drawing.Point(177, 16);
            this.codeMaNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.codeMaNV.Name = "codeMaNV";
            this.codeMaNV.Size = new System.Drawing.Size(0, 19);
            this.codeMaNV.TabIndex = 30;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel6.ForeColor = System.Drawing.Color.White;
            this.gunaLabel6.Location = new System.Drawing.Point(84, 146);
            this.gunaLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(61, 19);
            this.gunaLabel6.TabIndex = 28;
            this.gunaLabel6.Text = "Trình Độ";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel5.ForeColor = System.Drawing.Color.White;
            this.gunaLabel5.Location = new System.Drawing.Point(62, 98);
            this.gunaLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(82, 19);
            this.gunaLabel5.TabIndex = 27;
            this.gunaLabel5.Text = "Ngoại Ngữ: ";
            this.gunaLabel5.Click += new System.EventHandler(this.gunaLabel5_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaLabel3.ForeColor = System.Drawing.Color.White;
            this.gunaLabel3.Location = new System.Drawing.Point(52, 16);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(96, 19);
            this.gunaLabel3.TabIndex = 25;
            this.gunaLabel3.Text = "Mã nhân viên:";
            // 
            // gunaDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDataGridView1.ColumnHeadersHeight = 27;
            this.gunaDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manhanvien,
            this.tenNhanVien,
            this.ngoaingu,
            this.trinhDo});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(0, 267);
            this.gunaDataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowTemplate.Height = 24;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(784, 133);
            this.gunaDataGridView1.TabIndex = 1;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.FeterRiver;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 27;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = false;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gunaDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellClick);
            this.gunaDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellContentClick);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Location = new System.Drawing.Point(562, 0);
            this.gunaPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(220, 241);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 5;
            this.gunaPictureBox1.TabStop = false;
            this.gunaPictureBox1.UseTransfarantBackground = true;
            // 
            // btnMinimize
            // 
            this.btnMinimize.AnimationHoverSpeed = 0.07F;
            this.btnMinimize.AnimationSpeed = 0.03F;
            this.btnMinimize.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.btnMinimize.BorderColor = System.Drawing.Color.Black;
            this.btnMinimize.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMinimize.FocusedColor = System.Drawing.Color.Empty;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = null;
            this.btnMinimize.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMinimize.ImageSize = new System.Drawing.Size(20, 20);
            this.btnMinimize.Location = new System.Drawing.Point(822, 10);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(35)))), ((int)(((byte)(119)))));
            this.btnMinimize.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMinimize.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMinimize.OnHoverImage = null;
            this.btnMinimize.OnPressedColor = System.Drawing.Color.Black;
            this.btnMinimize.Size = new System.Drawing.Size(27, 20);
            this.btnMinimize.TabIndex = 10;
            // 
            // btnExit
            // 
            this.btnExit.AnimationHoverSpeed = 0.07F;
            this.btnExit.AnimationSpeed = 0.03F;
            this.btnExit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.btnExit.BorderColor = System.Drawing.Color.Black;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.FocusedColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = null;
            this.btnExit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExit.Location = new System.Drawing.Point(854, 10);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(35)))), ((int)(((byte)(119)))));
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 9;
            // 
            // manhanvien
            // 
            this.manhanvien.DataPropertyName = "MANV";
            this.manhanvien.HeaderText = "Mã Nhân Viên";
            this.manhanvien.Name = "manhanvien";
            // 
            // tenNhanVien
            // 
            this.tenNhanVien.DataPropertyName = "TENNV";
            this.tenNhanVien.HeaderText = "Tên Nhân Viên";
            this.tenNhanVien.Name = "tenNhanVien";
            // 
            // ngoaingu
            // 
            this.ngoaingu.DataPropertyName = "NGOAINGU";
            this.ngoaingu.HeaderText = "Ngoại Ngữ";
            this.ngoaingu.Name = "ngoaingu";
            // 
            // trinhDo
            // 
            this.trinhDo.DataPropertyName = "TRINHDO";
            this.trinhDo.HeaderText = "Trình Độ";
            this.trinhDo.Name = "trinhDo";
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
            this.btnThoat.Image = null;
            this.btnThoat.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThoat.Location = new System.Drawing.Point(668, 146);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnThoat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThoat.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThoat.OnHoverImage = null;
            this.btnThoat.OnPressedColor = System.Drawing.Color.Black;
            this.btnThoat.Radius = 15;
            this.btnThoat.Size = new System.Drawing.Size(91, 33);
            this.btnThoat.TabIndex = 42;
            this.btnThoat.Text = "Thoát";
            // 
            // frmQuanLyTrinhDoNgoaiNgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(784, 589);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.lbMaNV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmQuanLyTrinhDoNgoaiNgu";
            this.Load += new System.EventHandler(this.frmQuanLyTrinhDoNgoaiNgu_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmQuanLyTrinhDoNgoaiNgu_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void cbTenCV_SelectedValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Guna.UI.WinForms.GunaAdvenceButton btnTimKiem;
        private Guna.UI.WinForms.GunaLabel lbMaNV;
        private Guna.UI.WinForms.GunaTextBox txtMaNV;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton btnXoa;
        private Guna.UI.WinForms.GunaButton btnCapNhat;
        private Guna.UI.WinForms.GunaButton btnThem;
        private Guna.UI.WinForms.GunaLabel codeTenNV;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaComboBox cbNgoaiNgu;
        private Guna.UI.WinForms.GunaLabel codeMaCV;
        private Guna.UI.WinForms.GunaLabel codeMaNV;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaButton btnMinimize;
        private Guna.UI.WinForms.GunaButton btnExit;
        private Guna.UI.WinForms.GunaComboBox cbTrinhDo;
        private DataGridViewTextBoxColumn manhanvien;
        private DataGridViewTextBoxColumn tenNhanVien;
        private DataGridViewTextBoxColumn ngoaingu;
        private DataGridViewTextBoxColumn trinhDo;
        private Guna.UI.WinForms.GunaButton btnThoat;
    }
}