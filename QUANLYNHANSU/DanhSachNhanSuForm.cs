using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace QuanLyNhaHang
{
    public partial class DanhSachNhanSuForm : Form
    {
        public DanhSachNhanSuForm()
        {
            InitializeComponent();
        }

        NHANSU nhansu = new NHANSU();


        //
        private void DanhSachNhanSuForm_Load(object sender, EventArgs e)
        {
            radioButtonTatCa.Checked = true;

            double soluongnam = 0;
            double soluongnu = 0;
            soluongnam = Convert.ToDouble(nhansu.DemSoLuongNam(2));
            soluongnu = Convert.ToDouble(nhansu.DemSoLuongNu(2));
            // Tính %
            double tong = soluongnam + soluongnu;
            double phantramnam = soluongnam * 100 / tong;
            double phantramnu = soluongnu * 100 / tong;
            labelSoLuongNam.Text = ("Số lương 'Nam' chiếm: " + (phantramnam.ToString("0.00") + "%"));
            labelSoLuongNu.Text = ("Số lương 'Nữ' chiếm: " + (phantramnu.ToString("0.00") + "%"));
            labelTongSoLuongNhanSu.Text = ("Số lương số lượng quản lý và nhân viên là: " + (tong.ToString()));

            // Biểu đồ
            if (phantramnam == 0)
            {
                chartBieuDo.Series["NhanSu"].Points.AddXY("Nu", phantramnu);
            }
            else
            {
                if (phantramnu == 0)
                {
                    chartBieuDo.Series["NhanSu"].Points.AddXY("Nam", phantramnam);
                }
                else
                {
                    chartBieuDo.Series["NhanSu"].Points.AddXY("Nam", phantramnam);
                    chartBieuDo.Series["NhanSu"].Points.AddXY("Nu", phantramnu);
                }
            }
        }           


        

        
        //
        private void dataGridViewDanhSachNhanSu_DoubleClick(object sender, EventArgs e)
        {

        }


        //
        private void radioButtonChucVuNhanVien_CheckedChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT id AS 'Mã Nhân Viên', hoten AS 'Họ Tên', gioitinh AS 'Giới Tính'," +
                "ngaysinh AS 'Ngày Sinh', matkhau AS 'Mật Khẩu', diachi AS 'Địa Chỉ', sdt AS 'SDT', " +
                "hinh AS 'Hinh', chucvu AS 'Chức vụ' FROM nhansu WHERE chucvu = 'NhanVien'");
            fillGrid(command);
         //   BieuDo();
        }


        //
        private void radioButtonChucVuQuanLy_CheckedChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT id AS 'Mã Quản Lý', hoten AS 'Họ Tên', gioitinh AS 'Giới Tính'," +
                "ngaysinh AS 'Ngày Sinh', matkhau AS 'Mật Khẩu', diachi AS 'Địa Chỉ', sdt AS 'SDT', hinh AS 'Hinh', chucvu" +
                " AS 'Chức vụ' FROM nhansu WHERE chucvu = 'QuanLy'");
            fillGrid(command);
          //  BieuDo();
        }


        //
        private void radioButtonTatCa_CheckedChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT id AS 'Mã Nhân Sự', hoten AS 'Họ Tên', gioitinh AS " +
                "'Giới Tính', ngaysinh AS 'Ngày Sinh', matkhau AS 'Mật Khẩu', diachi AS 'Địa Chỉ', sdt AS" +
                " 'SDT', hinh AS 'Hinh', chucvu AS 'Chức vụ' FROM nhansu");
            fillGrid(command);
            chartBieuDo.ResetText();
           // BieuDo();
        }


        // Nạp dữ liệu
        public void fillGrid(SqlCommand command)
        {
            dataGridViewDanhSachNhanSu.RowTemplate.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridViewDanhSachNhanSu.RowTemplate.Height = 80;
            dataGridViewDanhSachNhanSu.DataSource = nhansu.GetNhanSu(command);
            picCol = (DataGridViewImageColumn)dataGridViewDanhSachNhanSu.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewDanhSachNhanSu.AllowUserToAddRows = false;

            // Đếm số lượng nhân sự
            labelTongSoLuong.Text = ("Tổng số lượng nhân sự: " + dataGridViewDanhSachNhanSu.Rows.Count);
        }


        //bieudo
        /*public void BieuDo()
        {
            double soluongnam = 0;
            double soluongnu = 0;
            if (radioButtonChucVuNhanVien.Checked)
            {
                soluongnam = Convert.ToDouble(nhansu.DemSoLuongNam(0));
                soluongnu = Convert.ToDouble(nhansu.DemSoLuongNu(0));
            }
            else
            {
                if (radioButtonChucVuQuanLy.Checked)
                {
                    soluongnam = Convert.ToDouble(nhansu.DemSoLuongNam(1));
                    soluongnu = Convert.ToDouble(nhansu.DemSoLuongNu(1));
                }
                else
                {
                    soluongnam = Convert.ToDouble(nhansu.DemSoLuongNam(2));
                    soluongnu = Convert.ToDouble(nhansu.DemSoLuongNu(2));
                }
            }
            // Tính %
            double tong = soluongnam + soluongnu;
            double phantramnam = soluongnam * 100 / tong;
            double phantramnu = soluongnu * 100 / tong;
            labelSoLuongNam.Text = ("Số lương 'Nam' chiếm: " + (phantramnam.ToString("0.00") + "%"));
            labelSoLuongNu.Text = ("Số lương 'Nữ' chiếm: " + (phantramnu.ToString("0.00") + "%"));

            // Biểu đồ
            if (phantramnam == 0)
            {
                chart.Series["NhanSu"].Points.AddXY("Nu", phantramnu);
            }
            else
            {
                if (phantramnu == 0)
                {
                    chart.Series["NhanSu"].Points.AddXY("Nam", phantramnam);
                }
                else
                {
                    chart.Series["NhanSu"].Points.AddXY("Nam", phantramnam);
                    chart.Series["NhanSu"].Points.AddXY("Nu", phantramnu);
                }
            }

        }*/


        //
        private void buttonPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            if(radioButtonTatCa.Checked)
                {
                print.Title = "Danh Sách Nhân Sự.";
            }
            else if(radioButtonChucVuQuanLy.Checked)
            {
                print.Title = "Danh Sách Quản Lý.";
            }
            else print.Title = "Danh Sách Nhân Viên.";

            print.SubTitle = String.Format("Data: {0}", DateTime.Now.Date);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "Foxlearn";
            print.FooterSpacing = 15;
            print.PrintDataGridView(dataGridViewDanhSachNhanSu);
        }


        //
        private void buttonXuatFileWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word Documents (.docx)|.docx";
            if (radioButtonTatCa.Checked)
            {
                sfd.FileName = "Danh Sách Nhân Sự.";
            }
            else if (radioButtonChucVuQuanLy.Checked)
            {
                sfd.FileName = "Danh Sách Quản Lý.";
            }
            else sfd.FileName = "Danh Sách Nhân Viên.";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Export_Data_To_Word(dataGridViewDanhSachNhanSu, sfd.FileName);
            }
        }


        //
        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }


        // Xuất ra File Word
        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                //add rows
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    } //end row loop
                } //end column loop

                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;

                //page orintation
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;

                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";

                    }
                }

                //table format
                oRange.Text = oTemp;

                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                    Type.Missing, Type.Missing, ref ApplyBorders,
                    Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing,
                    Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();


                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                //header row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                //add header row manually
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }

                //table style 
                oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                oDoc.Tables[1].Range.Shading.BackgroundPatternColor = Word.WdColor.wdColorWhite;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Color = Word.WdColor.wdColorBlack;

                int n = DGV.Rows.Count;
                for (int i = 0; i < n; i++)
                {
                    byte[] imgbyte = (byte[])DGV.Rows[i].Cells[7].Value;
                    Object oMissing = System.Reflection.Missing.Value;
                    MemoryStream ms = new MemoryStream(imgbyte);
                    System.Drawing.Image sparePicture = System.Drawing.Image.FromStream(ms);
                    System.Drawing.Image finalPic = (System.Drawing.Image)(new Bitmap(sparePicture, new
                        Size(90, 90)));
                    Clipboard.SetDataObject(finalPic);
                    var oPara2 = oDoc.Content.Paragraphs.Add(ref oMissing);
                    oDoc.Tables[1].Cell(2 + i, 8).Range.Paste();
                }

                //save the file
                oDoc.SaveAs2(filename);
            }
        }
    }
}
