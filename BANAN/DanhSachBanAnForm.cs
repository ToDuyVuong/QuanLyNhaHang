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
    public partial class DanhSachBanAnForm : Form
    {
        public DanhSachBanAnForm()
        {
            InitializeComponent();
        }

        BANAN banan = new BANAN();


        //
        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }


        //
        private void DanhSachBanAnForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT id AS 'Ban An So', soluongghe AS 'So Luong Ghe Cua Ban', trangthai AS 'Trang Thai'  FROM banan");
            fillGrid(command);
            labelTongSoLuongBanAn.Text = ("Tổng Số Lượng Bàn Ăn: " + (dataGridViewDanhSachBanAn.Rows.Count));
        }


        //
        // Nạp dữ liệu
        public void fillGrid(SqlCommand command)
        {
            dataGridViewDanhSachBanAn.RowTemplate.ReadOnly = true;
            dataGridViewDanhSachBanAn.RowTemplate.Height = 80;
            dataGridViewDanhSachBanAn.DataSource = banan.GetBanAn(command);
            dataGridViewDanhSachBanAn.AllowUserToAddRows = false;

            // Đếm số lượng Student
            //labelTotalStudents.Text = ("Total Students: " + dataGridView1.Rows.Count);
        }
    }
}
