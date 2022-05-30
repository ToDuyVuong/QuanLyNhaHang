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
using System.IO;
using System.Drawing.Printing;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Word;

namespace QuanLyNhaHang
{
    public partial class XuatDanhSachNguyenLieuForm : Form
    {
        public XuatDanhSachNguyenLieuForm()
        {
            InitializeComponent();
        }

        MY_NH mynh = new MY_NH();
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonExportToWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word Documents (.docx)|.docx";
            sfd.FileName = "DanhSachNguyenLieu.docx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Export_Data_To_Word(dataGridView1, sfd.FileName);
            }
        }
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

        

        private void buttonPrint_Click(object sender, EventArgs e)
        {
           /* PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;
            if (printDlg.ShowDialog() == DialogResult.OK)
                printDoc.Print();*/

            DGVPrinter print = new DGVPrinter();
             print.Title = "Danh Sách Nguyên Liệu.";

            print.SubTitle = String.Format("Data: {0}", DateTime.Now.Date);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "Foxlearn";
            print.FooterSpacing = 15;
            print.PrintDataGridView(dataGridView1);
        
    }

        private void XuatDanhSachNguyenLieuForm_Load(object sender, EventArgs e)
        {
            string strSQL = "SELECT id AS 'Mã Nguyên Liệu', tennguyenlieu AS 'Tên nguyên liệu',khoiluong AS 'Số lượng',donvi AS 'Đơn vị' from nguyenlieu";
            string strCon = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=myNH;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = strCon;


            dataGridView1.RowTemplate.Height = 80;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();

            try
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(strSQL, con);
                DataSet ds = new DataSet("nguyenlieu");
                adapter.Fill(ds, "nguyenlieu");
                System.Data.DataTable table = ds.Tables["nguyenlieu"];
                dataGridView1.DataSource = table;



                dataGridView1.AllowUserToAddRows = false;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error", ex.Message);
                if (con.State != ConnectionState.Closed)
                    con.Close();

            }
            finally
            {
                con.Dispose();
            }
            dataGridView1.ReadOnly = true;
        }
    }
}