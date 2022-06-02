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
    public partial class DanhSachNguyenLieuForm : Form
    {
        public DanhSachNguyenLieuForm()
        {
            InitializeComponent();
        }
        NGUYENLIEU nguyenlieu = new NGUYENLIEU();
        MY_NH mynh = new MY_NH();
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void buttonTimTheoTen_Click(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand("SELECT tennguyenlieu AS 'Tên Nguyên Liệu',khoiluong AS 'Khối Lượng',donvi AS 'Đơn Vị',sotien AS 'Số Tiền' FROM " +
                "nguyenlieu where tennguyenlieu = @tennguyenlieu", mynh.GetConnection);
            command.Parameters.Add("@tennguyenlieu", SqlDbType.NVarChar).Value = textBoxTen.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.ReadOnly = true;
        }

        private void buttonTimTheoLoai_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT tennguyenlieu AS 'Tên Nguyên Liệu',khoiluong AS 'Khối Lượng',donvi AS 'Đơn Vị',sotien AS 'Số Tiền' FROM " +
                "nguyenlieu where donvi = @donvi", mynh.GetConnection);
            command.Parameters.Add("@donvi", SqlDbType.NChar).Value = comboBoxTimTheoLoai.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.ReadOnly = true;
        }

      

        private void DanhSachNguyenLieuForm_Load_1(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT tennguyenlieu AS 'Tên Nguyên Liệu', khoiluong AS 'Khối Lượng',donvi AS 'Đơn Vị', sotien AS 'Số Tiền'  FROM nguyenlieu ", mynh.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.ReadOnly = true;
            comboBoxTimTheoLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand("SELECT id AS 'ID Nguyên Liệu', tennguyenlieu AS 'Tên Nguyên Liệu', khoiluong AS 'Khối Lượng',donvi AS ' Đơn Vị',sotien AS 'Số Tiền' FROM nguyenlieu", mynh.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void buttonTimTheoKhoang_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT tennguyenlieu AS 'Tên Nguyên Liệu',khoiluong AS 'Khối Lượng',donvi AS 'Đơn Vị',sotien AS 'Số Tiền' FROM " +
                "nguyenlieu where khoiluong BETWEEN @mocdau AND @moccuoi", mynh.GetConnection);
            command.Parameters.Add("@mocdau", SqlDbType.Int).Value = textBoxMocDau.Text;
            command.Parameters.Add("@moccuoi", SqlDbType.Int).Value = textBoxMocCuoi.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.ReadOnly = true;
        }
    }
}
