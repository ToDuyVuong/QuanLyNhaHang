using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Word;




namespace QuanLyNhaHang
{
    public partial class DoanhThuForm : Form
    {
        public DoanhThuForm()
        {
            InitializeComponent();
        }

        MY_NH mynh = new MY_NH();
        DOANHTHU doanhthu = new DOANHTHU();
        ORDER order = new ORDER();



        //
        private void DoanhThuForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT id AS 'Ma Doanh Thu', tongsotien AS 'Tong So Tien', ngaythanhtoan AS 'Ngay Thanh Toan' FROM doanhthu");
            dataGridViewDoanhThu.DataSource = doanhthu.GetDoanhThu(command);

            // Số tiền tạm tính.
            int tamtinh = 0;
            System.Data.DataTable table = new System.Data.DataTable();
            table = doanhthu.GetDoanhThu(command);
            int n = table.Rows.Count;
            for (int i = 0; i < n; i++)
            {
                tamtinh += Convert.ToInt32(table.Rows[i]["Tong So Tien"].ToString());
            }
            labelTongDoanhThu.Text = ("Tổng Doanh Thu:    " + tamtinh + " VND");

            textBoxMucTienBatDau.Enabled = false;
            textBoxMucTienKetThuc.Enabled = false;
            dateTimePickerNgayBatDau.Enabled = false;
            dateTimePickerNgayKetThuc.Enabled = false;
        }



        //
        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonTheoMucTien.Checked == true)
                {
                    int batdautu = Convert.ToInt32(textBoxMucTienBatDau.Text);
                    int ketthu = Convert.ToInt32(textBoxMucTienKetThuc.Text);
                    SqlCommand command = new SqlCommand("SELECT id AS 'Ma Doanh Thu', tongsotien AS 'Tong So Tien', ngaythanhtoan AS 'Ngay Thanh Toan'" +
                        " FROM doanhthu WHERE tongsotien >= @batdautu AND tongsotien <= @ketthu", mynh.GetConnection);
                    command.Parameters.Add("@batdautu", SqlDbType.Int).Value = batdautu;
                    command.Parameters.Add("@ketthu", SqlDbType.Int).Value = ketthu;
                    dataGridViewDoanhThu.DataSource = doanhthu.GetDoanhThu(command);

                    // Số tiền tạm tính.
                    int tamtinh = 0;
                    System.Data.DataTable table = new System.Data.DataTable();
                    table = doanhthu.GetDoanhThu(command);
                    int n = table.Rows.Count;
                    for (int i = 0; i < n; i++)
                    {
                        tamtinh += Convert.ToInt32(table.Rows[i]["Tong So Tien"].ToString());
                    }
                    labelTongDoanhThu.Text = ("Tổng Doanh Thu: " + tamtinh + " VND");
                }
                else
                {
                    if (radioButtonTheoNgay.Checked == true)
                    {
                        string date1 = dateTimePickerNgayBatDau.Value.ToString("yyyy-MM-dd");
                        string date2 = dateTimePickerNgayKetThuc.Value.ToString("yyyy-MM-dd");
                        SqlCommand command = new SqlCommand("SELECT id AS 'Ma Doanh Thu', tongsotien AS 'Tong So Tien', ngaythanhtoan AS 'Ngay Thanh Toan'" +
                        " FROM doanhthu WHERE ngaythanhtoan BETWEEN '" + date1 + " ' AND'" + date2 + "'");
                        dataGridViewDoanhThu.DataSource = doanhthu.GetDoanhThu(command);

                        // Số tiền tạm tính.
                        int tamtinh = 0;
                        System.Data.DataTable table = new System.Data.DataTable();
                        table = doanhthu.GetDoanhThu(command);
                        int n = table.Rows.Count;
                        for (int i = 0; i < n; i++)
                        {
                            tamtinh += Convert.ToInt32(table.Rows[i]["Tong So Tien"].ToString());
                        }
                        labelTongDoanhThu.Text = ("Tổng Doanh Thu: " + tamtinh + " VND");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Báo lỗi!!!", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        //
        private void buttonXuatFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn Muốn Xuất File Word Chứ?", "Thông Báo.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "Word Documents (.docx)|.docx";
                    sfd.FileName = "Doanh Thu.docx";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        sfd.Title = String.Format("Tổng danh sách doanh thu");
                        Export_Data_To_Word(dataGridViewDoanhThu, sfd.FileName);

                    }

                }
            }
            catch
            {
                MessageBox.Show("Báo lỗi!!!", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        //
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



                //save the file
                oDoc.SaveAs2(filename);
            }
        }

        

        //
        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }



        //
        private void radioButtonTheoNgay_CheckedChanged(object sender, EventArgs e)
        {
            textBoxMucTienBatDau.Enabled = false;
            textBoxMucTienKetThuc.Enabled = false;
            dateTimePickerNgayBatDau.Enabled = true;
            dateTimePickerNgayKetThuc.Enabled = true;
        }



        //
        private void radioButtonTheoMucTien_CheckedChanged(object sender, EventArgs e)
        {
            textBoxMucTienBatDau.Enabled = true;
            textBoxMucTienKetThuc.Enabled = true;
            dateTimePickerNgayBatDau.Enabled = false;
            dateTimePickerNgayKetThuc.Enabled = false;
        }



        //
        private void buttonInFile_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Muốn In File Này Chứ?", "Thông Báo.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                // Tiêu Đề In
                DGVPrinter print = new DGVPrinter();
                print.Title = ("Doanh Thu");
                if (radioButtonTheoMucTien.Checked == true)
                {
                    int batdautu = Convert.ToInt32(textBoxMucTienBatDau.Text);
                    int ketthu = Convert.ToInt32(textBoxMucTienKetThuc.Text);
                    print.SubTitle = String.Format("Doanh thu theo mức tiền từ:  " + batdautu + "            đến        " + ketthu);
                }
                else
                {
                    if (radioButtonTheoNgay.Checked == true)
                    {
                        string date1 = dateTimePickerNgayBatDau.Value.ToString("dd-MM-yyyy");
                        string date2 = dateTimePickerNgayKetThuc.Value.ToString("dd-MM-yyyy");
                        print.SubTitle = String.Format("Doanh thu theo ngày:    " + date1 + "    đến    " + date2);
                    }
                    else
                    {
                        print.SubTitle = String.Format("Tổng danh sách doanh thu");
                    }
                }


                // In
                print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                print.PageNumbers = true;
                print.PageNumberInHeader = false;
                print.PorportionalColumns = true;
                print.HeaderCellAlignment = StringAlignment.Near;
                print.Footer = "Foxlearn";
                print.FooterSpacing = 15;
                print.PrintDataGridView(dataGridViewDoanhThu);
            }
        }



        //
        private void dataGridViewDoanhThu_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                OrderDanhSachForm orderDanhSachForm = new OrderDanhSachForm();
                int id = Convert.ToInt32(dataGridViewDoanhThu.CurrentRow.Cells[0].Value.ToString());

                SqlCommand command = new SqlCommand("SELECT id AS 'Ma Order', idban AS 'Ma Ban', tenmon AS 'Ten Mon', soluong AS 'So Luong', " +
                    "gia AS 'Gia' FROM od  WHERE id = @id ", mynh.GetConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                orderDanhSachForm.dataGridViewOrder.DataSource = order.GetOrder(command);

                int tamtinh = 0;
                System.Data.DataTable table = new System.Data.DataTable();
                table = order.GetOrder(command);
                int n = table.Rows.Count;
                for (int i = 0; i < n; i++)
                {
                    tamtinh += Convert.ToInt32(table.Rows[i]["gia"].ToString());
                }
                orderDanhSachForm.labelTongDoanhThu.Text = ("Tạm tính: " + tamtinh + " VND");
                orderDanhSachForm.Show(this);
            }
            catch
            {

            }
        }
    }
}
