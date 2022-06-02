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
    public partial class ChinhSuaNguyenLieuForm : Form
    {
        public ChinhSuaNguyenLieuForm()
        {
            InitializeComponent();
        }
        MY_NH mynh = new MY_NH();
        NGUYENLIEU nguyenlieu = new NGUYENLIEU();

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChinhSuaNguyenLieuForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT id AS 'ID Nguyên Liệu', tennguyenlieu AS 'Tên Nguyên Liệu', khoiluong AS 'Khối Lượng', donvi AS 'Đơn Vị'," +
                " sotien AS 'Số Tiền' FROM nguyenlieu", mynh.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView.DataSource = table;
            dataGridView.ReadOnly = true;
        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
            textBoxTenNguyenLieu.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
            textBoxSoLuong.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
            comboBoxDonVi.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
            textBoxSoTien.Text = dataGridView.CurrentRow.Cells[4].Value.ToString();
            textBoxID.Enabled = false;
        }

        private void buttonCapNhat_Click(object sender, EventArgs e)
        {
            int soluong = Convert.ToInt32(textBoxSoLuong.Text);
            int id = Convert.ToInt32(textBoxID.Text);
            int sotien = Convert.ToInt32(textBoxSoTien.Text);
            if (nguyenlieu.UpdateNguyenLieu(id, textBoxTenNguyenLieu.Text, soluong, comboBoxDonVi.Text, sotien))
            {
                MessageBox.Show("Cập nhật thành công", "Cập nhật nguyên liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
            else
            {
                MessageBox.Show("Lỗi cập nhật nguyên liệu", "Cập nhật nguyên liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void refresh()
        {
            SqlCommand command = new SqlCommand("SELECT id AS 'ID Nguyên Liệu', tennguyenlieu AS 'Tên Nguyên Liệu', khoiluong AS 'Khối Lượng',donvi AS ' Đơn Vị',sotien AS 'Số Tiền' FROM nguyenlieu", mynh.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView.DataSource = table;
        }
        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (nguyenlieu.DeleteNguyenLieu(textBoxTenNguyenLieu.Text))
            {
                MessageBox.Show("Xóa thành công nguyên liệu " + textBoxTenNguyenLieu.Text,
                    " Xóa nguyên liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Xóa nguyên liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
