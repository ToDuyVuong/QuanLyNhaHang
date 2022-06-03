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
    public partial class DanhSachMonForm : Form
    {
        public DanhSachMonForm()
        {
            InitializeComponent();
        }

        MONAN monan = new MONAN();
        MY_NH mynh = new MY_NH();

        //
        private void DanhSachMonForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT id AS 'Ma Mon', tenmon AS 'Ten Mon', gia AS 'Gia'" +
                ", soluong AS 'So Luong', loaithucan AS 'Loai Thuc An'  FROM monan");
            fillGrid(command);
        }



        // Nạp dữ liệu
        public void fillGrid(SqlCommand command)
        {
            dataGridView1.RowTemplate.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = monan.GetMonAn(command);
            dataGridView1.AllowUserToAddRows = false;
        }


        //
        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT id AS 'Ma Mon', tenmon AS 'Ten Mon', gia AS 'Gia'" +
                ", soluong AS 'So Luong', loaithucan AS 'Loai Thuc An'  FROM monan WHERE tenmon LIKE'%" + textBoxTimKiem.Text + "%'");
            fillGrid(command);
        }

        private void buttonTaiLai_Click(object sender, EventArgs e)
        {
            DanhSachMonForm_Load(sender, e);
        }
    }
}
