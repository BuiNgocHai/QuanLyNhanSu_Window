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

        public bool themHoSoNhanVien(GunaTextBox mnv, GunaTextBox ten, GunaDateTimePicker nsinh, ComboBox gt, GunaTextBox sdt, GunaTextBox eml, GunaDateTimePicker ntd, ComboBox mpb, GunaTextBox tk, GunaTextBox mk, GunaTextBox q)
        {
            string manv = mnv.Text;
            string hoten = ten.Text;
            string ngaysinh = nsinh.Value.ToString();
            string gioitinh = gt.SelectedItem.ToString();
            string sodienthoai = sdt.Text;
            string email = eml.Text;
            string ngaytuyendung = ntd.Value.ToString();
            string mapb = mpb.SelectedValue.ToString();
            string taikhoan = tk.Text;
            string matkhau = mk.Text;
            string quyen = q.Text;
            bool output = qlhs.themHoSo(manv, hoten, Convert.ToDateTime(ngaysinh), gioitinh, sodienthoai, email, Convert.ToDateTime(ngaytuyendung), mapb, taikhoan, matkhau, quyen);
            return output;
        }

        public bool suaHoSoNhanVien(GunaTextBox mnv, GunaTextBox ten, GunaDateTimePicker nsinh, ComboBox gt, GunaTextBox sdt, GunaTextBox eml, GunaDateTimePicker ntd, ComboBox mpb, GunaTextBox tk, GunaTextBox mk, GunaTextBox q)
        {
            string manv = mnv.Text;
            string hoten = ten.Text;
            string ngaysinh = nsinh.Value.ToString();
            string gioitinh = gt.SelectedItem.ToString();
            string sodienthoai = sdt.Text;
            string email = eml.Text;
            string ngaytuyendung = ntd.Value.ToString();
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

        public bool timKiemHS(GunaTextBox mnv, GunaTextBox ten, GunaDateTimePicker ns, GunaTextBox gt, GunaTextBox sdt, GunaTextBox eml, GunaDateTimePicker ntd, GunaTextBox mpb, /*GunaTextBox tk, GunaTextBox mk, GunaTextBox q,*/DataGridView tdcm, DataGridView tdnn, DataGridView qtct)
        {
            HoSoNV_DTO nv = qlhs.timKiem(mnv.Text);
            try
            {
                ten.Text = nv.HoTen;
                ns.Value = nv.NgaySinh;
                gt.Text = nv.GioiTinh;
                sdt.Text = nv.SDT;
                eml.Text = nv.Email;
                ntd.Value = nv.NgayTD;
                mpb.Text = nv.MaPB;
                //tk.Text = nv.TaiKhoan;
                //mk.Text = nv.MatKhau;
                //q.Text = nv.Quyen;
                qlhs.hienThiTDCM(tdcm, mnv.Text);
                qlhs.hienThiTDNN(tdnn, mnv.Text);
                qlhs.hienThiQTCT(qtct, mnv.Text);

            }
            catch(Exception)
            {

            }
            if (nv.HoTen!= null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void xuatFile(GunaTextBox mnv, GunaTextBox ten, GunaDateTimePicker ns, GunaTextBox gt, GunaTextBox sdt, GunaTextBox eml, GunaDateTimePicker ntd, GunaTextBox mpb, DataGridView tdcm, DataGridView tdnn, DataGridView qtct)
        {
            BaseFont bf = BaseFont.CreateFont(@"C:\WINDOWS\Fonts\TIMES.TTF", BaseFont.IDENTITY_H, true);
            iTextSharp.text.Font fonttitle = new iTextSharp.text.Font(bf, 15);
            iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 12);
            iTextSharp.text.Font fonttext = new iTextSharp.text.Font(bf, 12);

            Paragraph header = new Paragraph
            {
                Alignment = Element.ALIGN_CENTER
            };
            Chunk c1 = new Chunk("HỒ SƠ NHÂN VIÊN \n", fonttitle);
            Chunk c2 = new Chunk(DateTime.Now.ToShortDateString() + "\n\n", font);
            header.Add(c1);
            header.Add(c2);
            string manv= "Mã Nhân Viên: "+mnv.Text+"\n";
            string tenvn = "Tên Nhân Viên: " + ten.Text + "\n";
            string ngaysinh = "Ngày Sinh: " + ns.Value.ToString() + "\n";
            string gioitinh = "Giới Tính: " + gt.Text + "\n";
            string sodt = "Số Điện Thoại: " + sdt.Text + "\n";
            string email = "Email: " + eml.Text + "\n";
            string ngaytuyendung = "Ngày Tuyển Dụng: " + ntd.Value.ToString() + "\n";
            string mapb = "Mã Phòng Ban: " + mpb.Text + "\n";
            //string taikhoan = "Tài Khoản: " + tk.Text + "\n";
            //string matkhau = "Mật Khẩu: " + mk.Text + "\n";
            //string quyen = "Quyền: " + q.Text + "\n";

            Paragraph text1 = new Paragraph();
            Chunk c3 = new Chunk(manv, font);
            Chunk c4 = new Chunk(tenvn, font);
            Chunk c5 = new Chunk(ngaysinh, font);
            Chunk c6 = new Chunk(gioitinh, font);
            Chunk c7 = new Chunk(sodt, font);
            Chunk c8 = new Chunk(email, font);
            Chunk c9 = new Chunk(ngaytuyendung, font);
            Chunk c10 = new Chunk(mapb, font);
            //Chunk c11 = new Chunk(taikhoan, font);
            //Chunk c12 = new Chunk(matkhau, font);
            //Chunk c13 = new Chunk(quyen, font);
            text1.Add(c3);
            text1.Add(c4);
            text1.Add(c5);
            text1.Add(c6);
            text1.Add(c7);
            text1.Add(c8);
            text1.Add(c9);
            text1.Add(c10);
            //text1.Add(c11);
            //text1.Add(c12);
            //text1.Add(c13);

            Paragraph text2 = new Paragraph();
            Chunk c14 = new Chunk("\nTrình Độ Chuyên Môn:", font);
            
            PdfPTable pdfTable = new PdfPTable(tdcm.Columns.Count);
            pdfTable.DefaultCell.Padding = 4;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            foreach (DataGridViewColumn column in tdcm.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, fonttext));
                pdfTable.AddCell(cell);
            }
            foreach (DataGridViewRow row in tdcm.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    PdfPCell cell1 = new PdfPCell(new Phrase(cell.Value.ToString(), fonttext));
                    pdfTable.AddCell(cell1);
                }
            }
            text2.Add(c14);
            text2.Add(pdfTable);

            Paragraph text3 = new Paragraph();
            Chunk c15 = new Chunk("\nTrình Độ Ngoại Ngữ:", font);

            PdfPTable pdfTable1 = new PdfPTable(tdnn.Columns.Count);
            pdfTable1.DefaultCell.Padding = 2;
            pdfTable1.WidthPercentage = 100;
            pdfTable1.HorizontalAlignment = Element.ALIGN_LEFT;
            foreach (DataGridViewColumn column in tdnn.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, fonttext));
                pdfTable1.AddCell(cell);
            }
            foreach (DataGridViewRow row in tdnn.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    PdfPCell cell1 = new PdfPCell(new Phrase(cell.Value.ToString(), fonttext));
                    pdfTable1.AddCell(cell1);
                }
            }
            text3.Add(c15);
            text3.Add(pdfTable1);

            Paragraph text4 = new Paragraph();
            Chunk c16 = new Chunk("\nQuá Trình Công Tác:", font);

            PdfPTable pdfTable2 = new PdfPTable(qtct.Columns.Count);
            pdfTable2.DefaultCell.Padding = 4;
            pdfTable2.WidthPercentage = 100;
            pdfTable2.HorizontalAlignment = Element.ALIGN_LEFT;
            foreach (DataGridViewColumn column in qtct.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, fonttext));
                pdfTable2.AddCell(cell);
            }
            foreach (DataGridViewRow row in qtct.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    PdfPCell cell1 = new PdfPCell(new Phrase(cell.Value.ToString(), fonttext));
                    pdfTable2.AddCell(cell1);
                }
            }
            text4.Add(c16);
            text4.Add(pdfTable2);

            string file_name = "D:\\" + "output.pdf";
            using (FileStream stream = new FileStream(file_name, FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(header);
                pdfDoc.Add(text1);
                pdfDoc.Add(text2);
                pdfDoc.Add(text3);
                pdfDoc.Add(text4);
                pdfDoc.Close();
                stream.Close();
            }
        }
    }
}
