using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using BUS.BUS;
using iTextSharp.text;
using iTextSharp.text.pdf;
using QuanLyNhanSu_Nhom6.Chung;
namespace QuanLyNhanSu_Nhom6.Views
{
    public partial class frmInThongKeTrinhDoNgoaiNgu : Form
    {
		
		public frmInThongKeTrinhDoNgoaiNgu()
        {
            InitializeComponent();
            this.gunaLabel1.Parent = gunaPictureBox1;
            this.gunaLabel1.BackColor = Color.Transparent;
            this.panelChonChucNang.Parent = gunaPictureBox1;
            this.panelChonMucThongKe.Parent = panel1;
        }

        private void frmInQuanLyTrinhDoNgoaiNgu_Load(object sender, EventArgs e)
        {
            cbNgoaiNgu.Enabled = false;
            cbTrinhDo.Enabled = false;            
            ThongKeTrinhDoNgoaiNgu_BUS.Instance.layDLNgoaiNgu_BUS(cbNgoaiNgu,cbTrinhDo);
            btnIn.Enabled = false;
            


        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
            cbNgoaiNgu.Enabled = true;
            cbTrinhDo.Enabled = false;
        }

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
            cbTrinhDo.Enabled = true;
            cbNgoaiNgu.Enabled = false;
        }

		private void btnXem_Click(object sender, EventArgs e)
		{
            if (rdTrinhDo.Checked)
            {
                int k = ThongKeTrinhDoNgoaiNgu_BUS.Instance.thongKe_BUS(cbNgoaiNgu, gunaDataGridView1, 1);
                if (k == 0)
                {
                    frmCanhBaoOK.Instance.capNhatLoiNhan("Không tìm thấy!");
                    frmCanhBaoOK.Instance.ShowDialog();
                }
                else
                {
                    btnIn.Enabled = true;
                }


            }
            else
            {
                int k = ThongKeTrinhDoNgoaiNgu_BUS.Instance.thongKe_BUS(cbNgoaiNgu, gunaDataGridView1, 2);
                if (k == 0)
                {
                    frmCanhBaoOK.Instance.capNhatLoiNhan("Không tìm thấy!");
                    frmCanhBaoOK.Instance.ShowDialog();
                }
                else
                {
                    btnIn.Enabled = true;
                }
            }
        }

        frmCanhBaoOK frm = new frmCanhBaoOK();
        private void btnXem_Click_1(object sender, EventArgs e)
        {
            if (rdTrinhDo.Checked)
            {
                int k = ThongKeTrinhDoNgoaiNgu_BUS.Instance.thongKe_BUS(cbTrinhDo, gunaDataGridView1, 1);
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
            else
            {
                int k = ThongKeTrinhDoNgoaiNgu_BUS.Instance.thongKe_BUS(cbNgoaiNgu, gunaDataGridView1, 2);
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

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (gunaDataGridView1.Rows.Count > 0)
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
                            PdfPTable pdfTable = new PdfPTable(gunaDataGridView1.Columns.Count);
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

                            Chunk c1 = new Chunk("BÁO CÁO THỐNG KÊ TRÌNH ĐỘ NGOẠI NGỮ \n", fonttitle);
                            Chunk c2 = new Chunk(DateTime.Now.ToShortDateString() + "\n\n", font);
                            header.Add(c1);
                            header.Add(c2);

                            foreach (DataGridViewColumn column in gunaDataGridView1.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, fonttext));
                                pdfTable.AddCell(cell);
                            }


                            foreach (DataGridViewRow row in gunaDataGridView1.Rows)
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
    }
}
