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
        }

        
        //
        private void dataGridViewDanhSachNhanSu_DoubleClick(object sender, EventArgs e)
        {

        }


        //
        private void radioButtonChucVuNhanVien_CheckedChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM nhansu WHERE chucvu = 'NhanVien'");
            fillGrid(command);
        }


        //
        private void radioButtonChucVuQuanLy_CheckedChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM nhansu WHERE chucvu = 'QuanLy'");
            fillGrid(command);
        }


        //
        private void radioButtonTatCa_CheckedChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM nhansu");
            fillGrid(command);
        }


        // Nạp dữ liệu
        public void fillGrid(SqlCommand command)
        {
            dataGridViewDanhSachNhanSu.RowTemplate.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridViewDanhSachNhanSu.RowTemplate.Height = 80;
            dataGridViewDanhSachNhanSu.DataSource = nhansu.GetNhanSu(command);
            picCol = (DataGridViewImageColumn)dataGridViewDanhSachNhanSu.Columns[5];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewDanhSachNhanSu.AllowUserToAddRows = false;

            // Đếm số lượng nhân sự
            labelSoLuong.Text = ("Số lượng nhân sự: " + dataGridViewDanhSachNhanSu.Rows.Count);
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {

        }

        private void buttonXuatFileWord_Click(object sender, EventArgs e)
        {

        }
    }
}
