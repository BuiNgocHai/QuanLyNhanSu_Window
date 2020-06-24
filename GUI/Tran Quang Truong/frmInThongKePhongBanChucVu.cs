using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using BUS.BUS;
using QuanLyNhanSu_Nhom6.Chung;
using Guna.UI.WinForms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;



namespace QuanLyNhanSu_Nhom6.Views
{
    public partial class frmInThongKePhongBanChucVu : Form
    {
        public frmInThongKePhongBanChucVu()
        {
            InitializeComponent();
            this.gunaLabel1.Parent = gunaPictureBox1;
            //this.gunaLabel1.BackColor = Color.Transparent;
            this.btnExit.Parent = gunaPictureBox1;
            this.btnExit.BackColor = Color.Transparent;
            this.panelChonChucNang.Parent = gunaPictureBox1;
            this.panelChonMucThongKe.Parent = panel1;

        }

        frmCanhBaoOK frm = new frmCanhBaoOK();

        private void frmInThongKePhongBanChucVu_Load(object sender, EventArgs e)
        {

            cbTenChucVu.Enabled = false;
            cbTenPhongBan.Enabled = false;
            btnIn.Enabled = false;
            QuanLyNhanVienChucVu_BUS.Instance.layDLCombox_BUS(cbTenChucVu);
            ThongKePhongBanChucVu_BUS.Instance.layDLTenPhongBan_BUS(cbTenPhongBan);
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdPhongBan_CheckedChanged(object sender, EventArgs e)
        {
            cbTenPhongBan.Enabled = true;
            cbTenChucVu.Enabled = false;
        }

        private void rdChucVu_CheckedChanged(object sender, EventArgs e)
        {
            cbTenChucVu.Enabled = true;
            cbTenPhongBan.Enabled = false;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (rdPhongBan.Checked)
            {
                int k =ThongKePhongBanChucVu_BUS.Instance.thongKe_BUS(cbTenPhongBan, gunaDataGridView2, 1);
                if(k==0)
                {
                    frm.capNhatLoiNhan("Không tìm thấy!");
                    frm.ShowDialog();
                }
                else
                {
                    btnIn.Enabled = true;
                }


            }
            else
            {
              int k =  ThongKePhongBanChucVu_BUS.Instance.thongKe_BUS(cbTenChucVu, gunaDataGridView2, 2);
                if (k == 0)
                {
                    frm.capNhatLoiNhan("Không tìm thấy!");
                    frm.ShowDialog();
                }
                else
                {
                    btnIn.Enabled = true;
                }
            }
            
        }
        public void xuatBaoCao(GunaDataGridView dgv)
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
                            frm.capNhatLoiNhan("Đang có chương trình mở file này!!!");                           
                            frm.ShowDialog();
                        }
                        
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

                            frm.capNhatLoiNhan("Xuất dữ liệu thành công!!!");
                            frm.ShowDialog();
                        }
                        catch (Exception ex)
                        {

                            frm.capNhatLoiNhan("Có lỗi xảy ra!!!");
                            frm.ShowDialog();
                        }
                    }
                }
            }
            else
            {

                frm.capNhatLoiNhan("Không có bản ghi nào được xuất!!!");
                frm.ShowDialog();
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            xuatBaoCao(gunaDataGridView2);
           
        }
    }

}
