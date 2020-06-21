using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using Guna.UI.WinForms;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Org.BouncyCastle.Asn1.Cms;

namespace BUS
{
    public class QuanLyHoSo_BUS
    {
        private FileStream fs;
        private static QuanLyHoSo_BUS instance;
        private HoSo_DAO qlhs = new HoSo_DAO();
        public static QuanLyHoSo_BUS Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new QuanLyHoSo_BUS();
                }

                return instance;
            }
        }
        public QuanLyHoSo_BUS()
        {

        }

        public void hienThi(DataGridView dt)
        {
            qlhs.hienThi(dt);
        }

        public void loadCBBox(ComboBox cb)
        {
            qlhs.loadCBBox(cb);
        }

        public bool themHoSoNhanVien(GunaTextBox mnv, GunaTextBox ten, GunaTextBox nsinh, ComboBox gt, GunaTextBox sdt, GunaTextBox eml, GunaTextBox ntd, ComboBox mpb, GunaTextBox tk, GunaTextBox mk, GunaTextBox q)
        {
            string manv = mnv.Text;
            string hoten = ten.Text;
            string ngaysinh = nsinh.Text;
            string gioitinh = gt.SelectedItem.ToString();
            string sodienthoai = sdt.Text;
            string email = eml.Text;
            string ngaytuyendung = ntd.Text;
            string mapb = mpb.SelectedValue.ToString();
            string taikhoan = tk.Text;
            string matkhau = mk.Text;
            string quyen = q.Text;
            bool output = qlhs.themHoSo(manv, hoten, Convert.ToDateTime(ngaysinh), gioitinh, sodienthoai, email, Convert.ToDateTime(ngaytuyendung), mapb, taikhoan, matkhau, quyen);
            return output;
        }

        public bool suaHoSoNhanVien(GunaTextBox mnv, GunaTextBox ten, GunaTextBox nsinh, ComboBox gt, GunaTextBox sdt, GunaTextBox eml, GunaTextBox ntd, ComboBox mpb, GunaTextBox tk, GunaTextBox mk, GunaTextBox q)
        {
            string manv = mnv.Text;
            string hoten = ten.Text;
            string ngaysinh = nsinh.Text;
            string gioitinh = gt.SelectedItem.ToString();
            string sodienthoai = sdt.Text;
            string email = eml.Text;
            string ngaytuyendung = ntd.Text;
            string mapb = mpb.SelectedValue.ToString();
            string taikhoan = tk.Text;
            string matkhau = mk.Text;
            string quyen = q.Text;
            bool output = qlhs.suaHoSo(manv, hoten, Convert.ToDateTime(ngaysinh), gioitinh, sodienthoai, email, Convert.ToDateTime(ngaytuyendung), mapb, taikhoan, matkhau, quyen);
            return output;
        }
        public void timKiemHoSoNhanVien(DataGridView dt,GunaTextBox mnv)
        {
            string manv = mnv.Text;
            qlhs.timKiemHoSo(dt,manv);
        }
        public bool xoaHoSoNhanVien(GunaTextBox mnv)
        {
            string manv = mnv.Text;
            bool output = qlhs.xoaHoSo(manv);
            return output;
        }

        public void timKiemHS(GunaTextBox mnv, GunaTextBox ten, GunaTextBox ns, GunaTextBox gt, GunaTextBox sdt, GunaTextBox eml, GunaTextBox ntd, GunaTextBox mpb, GunaTextBox tk, GunaTextBox mk, GunaTextBox q,DataGridView tdcm, DataGridView tdnn, DataGridView qtct)
        {
            HoSoNV_DTO nv = qlhs.timKiem(mnv.Text);
            ten.Text = nv.HoTen;
            ns.Text = nv.NgaySinh.ToString();
            gt.Text = nv.GioiTinh;
            sdt.Text = nv.SDT;
            eml.Text = nv.Email;
            ntd.Text = nv.NgayTD.ToString();
            mpb.Text = nv.MaPB;
            tk.Text = nv.TaiKhoan;
            mk.Text = nv.MatKhau;
            q.Text = nv.Quyen;
            qlhs.hienThiTDCM(tdcm, mnv.Text);
            qlhs.hienThiTDNN(tdnn, mnv.Text);
            qlhs.hienThiQTCT(qtct, mnv.Text);
        }

        public void xuatFile(GunaTextBox mnv, GunaTextBox ten, GunaTextBox ns, GunaTextBox gt, GunaTextBox sdt, GunaTextBox eml, GunaTextBox ntd, GunaTextBox mpb, GunaTextBox tk, GunaTextBox mk, GunaTextBox q, DataGridView tdcm, DataGridView tdnn, DataGridView qtct)
        {
            BaseFont bfTimes = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);

            Font times = new Font(bfTimes, 12, iTextSharp.text.Font.NORMAL);
            string file_name = "C:\\Users\\HIT.ishiki\\Desktop\\QuanLyNhanSu_Window\\assets\\output_file\\" + "output.pdf";
            fs= new FileStream(file_name, FileMode.Create, FileAccess.Write, FileShare.None);
            Document doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, fs);
            doc.Open();
            doc.Add(new Paragraph("Hồ Sơ Nhân Viên\n",times));
            doc.Add(new Paragraph("Mã Nhân Viên: "+ mnv.Text+ "\n",times));
            doc.Add(new Paragraph("Tên Nhân Viên: " + ten.Text+"\n", times));
            doc.Add(new Paragraph("Ngày Sinh: " + ns.Text+"\n", times));
            doc.Add(new Paragraph("Giới Tính: " + gt.Text + "\n", times));
            doc.Add(new Paragraph("Số Điện Thoại: " + sdt.Text + "\n", times));
            doc.Add(new Paragraph("Email: " + eml.Text + "\n", times));
            doc.Add(new Paragraph("Ngày Tuyển Dụng: " + ntd.Text + "\n", times));
            doc.Add(new Paragraph("Phòng Ban: " + mpb.Text + "\n", times));
            doc.Add(new Paragraph("Tài Khoản: " + tk.Text + "\n", times));
            doc.Add(new Paragraph("Mật Khẩu: " + mk.Text + "\n", times));
            doc.Add(new Paragraph("Quyền: " + q.Text + "\n", times));
            doc.Add(new Paragraph("Trình Độ Chuyên Môn:\n", times));
            doc.Add(new Paragraph("\t"));

            PdfPTable pdfTable = new PdfPTable(tdcm.Columns.Count);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

            foreach (DataGridViewColumn column in tdcm.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, times));
                pdfTable.AddCell(cell);
            }

            foreach (DataGridViewRow row in tdcm.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value.ToString());
                }
            }
            doc.Add(pdfTable);

            doc.Add(new Paragraph("Trình Độ Ngoại Ngữ:\n", times));
            doc.Add(new Paragraph("\t"));

            PdfPTable pdfTable1 = new PdfPTable(tdcm.Columns.Count);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

            foreach (DataGridViewColumn column in tdcm.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, times));
                pdfTable1.AddCell(cell);
            }

            foreach (DataGridViewRow row in tdcm.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable1.AddCell(cell.Value.ToString());
                }
            }
            doc.Add(pdfTable1);

            doc.Add(new Paragraph("Quá Trình Công Tác:\n", times));
            doc.Add(new Paragraph("\t"));

            PdfPTable pdfTable2 = new PdfPTable(tdcm.Columns.Count);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

            foreach (DataGridViewColumn column in tdcm.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, times));
                pdfTable2.AddCell(cell);
            }

            foreach (DataGridViewRow row in tdcm.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable2.AddCell(cell.Value.ToString());
                }
            }
            doc.Add(pdfTable2);
            doc.Close();
        }
    }
}
