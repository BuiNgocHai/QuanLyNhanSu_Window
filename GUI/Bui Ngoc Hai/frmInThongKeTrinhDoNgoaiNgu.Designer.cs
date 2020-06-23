using Guna.UI.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyNhanSu_Nhom6.Views
{
	partial class frmInThongKeTrinhDoNgoaiNgu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInThongKeTrinhDoNgoaiNgu));
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.btnXem = new Guna.UI.WinForms.GunaButton();
            this.btnIn = new Guna.UI.WinForms.GunaButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.panelChonChucNang = new Guna.UI.WinForms.GunaPanel();
            this.rdNgoaiNgu = new System.Windows.Forms.RadioButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.rdTrinhDo = new System.Windows.Forms.RadioButton();
            this.panelChonMucThongKe = new Guna.UI.WinForms.GunaPanel();
            this.cbNgoaiNgu = new Guna.UI.WinForms.GunaComboBox();
            this.cbTrinhDo = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.panelChonChucNang.SuspendLayout();
            this.panelChonMucThongKe.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaDataGridView1
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gunaDataGridView1.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(0, 443);
            this.gunaDataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowHeadersWidth = 51;
            this.gunaDataGridView1.RowTemplate.Height = 24;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(1233, 150);
            this.gunaDataGridView1.TabIndex = 16;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Alizarin;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = false;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // btnXem
            // 
            this.btnXem.AnimationHoverSpeed = 0.07F;
            this.btnXem.AnimationSpeed = 0.03F;
            this.btnXem.BackColor = System.Drawing.Color.Transparent;
            this.btnXem.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnXem.BorderColor = System.Drawing.Color.Black;
            this.btnXem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXem.FocusedColor = System.Drawing.Color.Empty;
            this.btnXem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.Image")));
            this.btnXem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXem.ImageSize = new System.Drawing.Size(30, 30);
            this.btnXem.Location = new System.Drawing.Point(714, 648);
            this.btnXem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXem.Name = "btnXem";
            this.btnXem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnXem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXem.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXem.OnHoverImage = null;
            this.btnXem.OnPressedColor = System.Drawing.Color.Black;
            this.btnXem.Radius = 15;
            this.btnXem.Size = new System.Drawing.Size(160, 42);
            this.btnXem.TabIndex = 17;
            this.btnXem.Text = "Xem trước";
            this.btnXem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnIn.ImageSize = new System.Drawing.Size(30, 30);
            this.btnIn.Location = new System.Drawing.Point(976, 648);
            this.btnIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.gunaPictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(1234, 206);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 11;
            this.gunaPictureBox1.TabStop = false;
            this.gunaPictureBox1.Click += new System.EventHandler(this.gunaPictureBox1_Click);
            // 
            // panelChonChucNang
            // 
            this.panelChonChucNang.BackColor = System.Drawing.Color.Transparent;
            this.panelChonChucNang.Controls.Add(this.rdNgoaiNgu);
            this.panelChonChucNang.Controls.Add(this.gunaLabel2);
            this.panelChonChucNang.Controls.Add(this.rdTrinhDo);
            this.panelChonChucNang.Location = new System.Drawing.Point(43, 79);
            this.panelChonChucNang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelChonChucNang.Name = "panelChonChucNang";
            this.panelChonChucNang.Size = new System.Drawing.Size(416, 110);
            this.panelChonChucNang.TabIndex = 18;
            // 
            // rdNgoaiNgu
            // 
            this.rdNgoaiNgu.AutoSize = true;
            this.rdNgoaiNgu.BackColor = System.Drawing.Color.Transparent;
            this.rdNgoaiNgu.ForeColor = System.Drawing.Color.White;
            this.rdNgoaiNgu.Location = new System.Drawing.Point(237, 66);
            this.rdNgoaiNgu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdNgoaiNgu.Name = "rdNgoaiNgu";
            this.rdNgoaiNgu.Size = new System.Drawing.Size(133, 21);
            this.rdNgoaiNgu.TabIndex = 20;
            this.rdNgoaiNgu.TabStop = true;
            this.rdNgoaiNgu.Text = "Theo Ngoại Ngữ";
            this.rdNgoaiNgu.UseVisualStyleBackColor = false;
            this.rdNgoaiNgu.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
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
            // rdTrinhDo
            // 
            this.rdTrinhDo.AutoSize = true;
            this.rdTrinhDo.BackColor = System.Drawing.Color.Transparent;
            this.rdTrinhDo.ForeColor = System.Drawing.Color.White;
            this.rdTrinhDo.Location = new System.Drawing.Point(25, 66);
            this.rdTrinhDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdTrinhDo.Name = "rdTrinhDo";
            this.rdTrinhDo.Size = new System.Drawing.Size(114, 21);
            this.rdTrinhDo.TabIndex = 18;
            this.rdTrinhDo.TabStop = true;
            this.rdTrinhDo.Text = "Theo trình độ";
            this.rdTrinhDo.UseVisualStyleBackColor = false;
            // 
            // panelChonMucThongKe
            // 
            this.panelChonMucThongKe.BackColor = System.Drawing.Color.Transparent;
            this.panelChonMucThongKe.Controls.Add(this.cbNgoaiNgu);
            this.panelChonMucThongKe.Controls.Add(this.cbTrinhDo);
            this.panelChonMucThongKe.Controls.Add(this.gunaLabel5);
            this.panelChonMucThongKe.Controls.Add(this.gunaLabel4);
            this.panelChonMucThongKe.Controls.Add(this.gunaLabel3);
            this.panelChonMucThongKe.Location = new System.Drawing.Point(43, 209);
            this.panelChonMucThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelChonMucThongKe.Name = "panelChonMucThongKe";
            this.panelChonMucThongKe.Size = new System.Drawing.Size(553, 167);
            this.panelChonMucThongKe.TabIndex = 19;
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
            this.cbNgoaiNgu.Items.AddRange(new object[] {
            "Tất cả các chức vụ"});
            this.cbNgoaiNgu.Location = new System.Drawing.Point(179, 103);
            this.cbNgoaiNgu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNgoaiNgu.Name = "cbNgoaiNgu";
            this.cbNgoaiNgu.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbNgoaiNgu.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbNgoaiNgu.Radius = 10;
            this.cbNgoaiNgu.Size = new System.Drawing.Size(237, 31);
            this.cbNgoaiNgu.TabIndex = 25;
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
            this.cbTrinhDo.Items.AddRange(new object[] {
            "Tất cả phòng ban"});
            this.cbTrinhDo.Location = new System.Drawing.Point(179, 50);
            this.cbTrinhDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTrinhDo.Name = "cbTrinhDo";
            this.cbTrinhDo.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbTrinhDo.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbTrinhDo.Radius = 10;
            this.cbTrinhDo.Size = new System.Drawing.Size(237, 31);
            this.cbTrinhDo.TabIndex = 24;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.ForeColor = System.Drawing.Color.White;
            this.gunaLabel5.Location = new System.Drawing.Point(21, 108);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(83, 20);
            this.gunaLabel5.TabIndex = 23;
            this.gunaLabel5.Text = "Ngoại Ngữ";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.ForeColor = System.Drawing.Color.White;
            this.gunaLabel4.Location = new System.Drawing.Point(21, 55);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(65, 20);
            this.gunaLabel4.TabIndex = 22;
            this.gunaLabel4.Text = "Trình Độ";
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
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(431, 30);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(370, 35);
            this.gunaLabel1.TabIndex = 12;
            this.gunaLabel1.Text = "Thống Kê Trình Độ Ngoại Ngữ";
            this.gunaLabel1.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.panelChonMucThongKe);
            this.panel1.Controls.Add(this.panelChonChucNang);
            this.panel1.Controls.Add(this.gunaPictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1233, 398);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // frmInThongKeTrinhDoNgoaiNgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1233, 733);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimizeBox = false;
            this.Name = "frmInThongKeTrinhDoNgoaiNgu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInThongKeTrinhDoNgoaiNgu";
            this.Load += new System.EventHandler(this.frmInQuanLyTrinhDoNgoaiNgu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.panelChonChucNang.ResumeLayout(false);
            this.panelChonChucNang.PerformLayout();
            this.panelChonMucThongKe.ResumeLayout(false);
            this.panelChonMucThongKe.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private GunaDataGridView gunaDataGridView1;
		private GunaButton btnXem;
		private GunaButton btnIn;
        private GunaPictureBox gunaPictureBox1;
        private GunaPanel panelChonChucNang;
        private RadioButton rdNgoaiNgu;
        private GunaLabel gunaLabel2;
        private RadioButton rdTrinhDo;
        private GunaPanel panelChonMucThongKe;
        private GunaComboBox cbNgoaiNgu;
        private GunaComboBox cbTrinhDo;
        private GunaLabel gunaLabel5;
        private GunaLabel gunaLabel4;
        private GunaLabel gunaLabel3;
        private GunaLabel gunaLabel1;
        private Panel panel1;

	}
}