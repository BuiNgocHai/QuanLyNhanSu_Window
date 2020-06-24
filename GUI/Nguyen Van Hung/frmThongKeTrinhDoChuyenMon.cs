using BUS.BUS;
using Guna.UI.WinForms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using QuanLyNhanSu_Nhom6.Chung;
using System;
using System.IO;
using System.Windows.Forms;

namespace QuanLyNhanSu_Nhom6.Views
{
    public partial class frmThongKeTrinhDoChuyenMon : Form
    {
        public frmThongKeTrinhDoChuyenMon()
        {
            InitializeComponent();
        }
        
        

        private void  btnThongKe_Click(object sender, EventArgs e)
        {
            if (rdTrinhDo.Checked)
            {
                if (ThongKeTrinhDoChuyenMon_BUS.createInstance.thongKeTrinhDoChuyenMon(txtTrinhDo.Text, gunaDataGridView1, 1) == 0)
                {
                    frmCanhBaoOK.Instance.capNhatLoiNhan("Khong tim thay trinh do");
                    frmCanhBaoOK.Instance.ShowDialog();
                }
                else
                {
                    MessageBox.Show(frmLogin.tk);
                    lbNgay.Text = DateTime.Now.ToString();
                    lbNguoiLap.Text = frmLogin.tk;
                    ThongKeTrinhDoChuyenMon_BUS.createInstance.thongKeTrinhDoChuyenMon(txtTrinhDo.Text, gunaDataGridView1, 1);
                }
            }
            if (rdChuyenNganh.Checked)
            {
                if (ThongKeTrinhDoChuyenMon_BUS.createInstance.thongKeTrinhDoChuyenMon(txtChuyenNganh.Text, gunaDataGridView1, 2) == 0)
                {
                    frmCanhBaoOK.Instance.capNhatLoiNhan("Khong tim thay chuyen nganh");
                    frmCanhBaoOK.Instance.ShowDialog();
                }
                else
                {
                    lbNgay.Text = DateTime.Now.ToString();
                    ThongKeTrinhDoChuyenMon_BUS.createInstance.thongKeTrinhDoChuyenMon(txtTrinhDo.Text, gunaDataGridView1, 2);
                }
            }
        }

        private void frmThongKeTrinhDoChuyenMon_Load(object sender, EventArgs e)
        {

        }

        public  void  xuatBaoCao(GunaDataGridView dgv )
        {
            if (dgv.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "PDF (*.pdf)|*.pdf",
                    FileName = "Output.pdf"
                };
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            frmCanhBaoOK.Instance.capNhatLoiNhan("Đang có chương trình mở file này!!!");
                        }
                        frmCanhBaoOK.Instance.ShowDialog();
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dgv.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            BaseFont bf = BaseFont.CreateFont(@"C:\WINDOWS\Fonts\TIMES.TTF", BaseFont.IDENTITY_H, true);
                            iTextSharp.text.Font fonttitle = new iTextSharp.text.Font(bf, 15);
                            iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 10);
                            iTextSharp.text.Font fonttext = new iTextSharp.text.Font(bf, 12);

                            Paragraph header = new Paragraph
                            {
                                Alignment = Element.ALIGN_CENTER
                            };
                            Paragraph text = new Paragraph();

                            Chunk c1 = new Chunk("BÁO CÁO THỐNG KÊ TRÌNH ĐỘ CHUYÊN MÔN \n", fonttitle);
                            Chunk c2 = new Chunk(DateTime.Now.ToShortDateString() + "\n\n", font);
                            header.Add(c1);
                            header.Add(c2);

                            foreach (DataGridViewColumn column in dgv.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, fonttext));
                                pdfTable.AddCell(cell);
                            }


                            foreach (DataGridViewRow row in dgv.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    PdfPCell cell1 = new PdfPCell(new Phrase(cell.Value.ToString(), fonttext));
                                    pdfTable.AddCell(cell1);
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(header);
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            frmCanhBaoOK.Instance.capNhatLoiNhan("Xuất dữ liệu thành công!!!");
                            frmCanhBaoOK.Instance.ShowDialog();
                        }
                        catch (Exception ex)
                        {

                            frmCanhBaoOK.Instance.capNhatLoiNhan("Có lỗi xảy ra!!!");
                            frmCanhBaoOK.Instance.ShowDialog();
                        }
                    }
                }
            }
            else
            {

                frmCanhBaoOK.Instance.capNhatLoiNhan("Không có bản ghi nào được xuất!!!");
                frmCanhBaoOK.Instance.ShowDialog();
            }
        }

        private void BtnIn_Click(object sender, EventArgs e)
        {

            xuatBaoCao(gunaDataGridView1);
        }
    }
}
