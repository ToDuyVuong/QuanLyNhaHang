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
    public partial class ThemNguyenLieuForm : Form
    {
        public ThemNguyenLieuForm()
        {
            InitializeComponent();
        }
        NGUYENLIEU nguyenlieu = new NGUYENLIEU();
        MY_NH mynh = new MY_NH();
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            int id = nguyenlieu.TaoID();
            int soluong = Convert.ToInt32(textBoxKhoiLuong.Text);
            if (Verif(textBoxTenNguyenLieu.Text))
            {
                MessageBox.Show("Tên nguyên liệu đã có sẵn, Vui lòng qua update", "Thêm Nguyên Liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nguyenlieu.InsertNguyenLieu(id, textBoxTenNguyenLieu.Text, soluong, comboBoxDonVi.Text))
            {
                MessageBox.Show("Nguyên liệu " + textBoxTenNguyenLieu.Text + " Được thêm thành công với id = " + (id + 1), "Thêm Nguyên Liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm Thất Bại", "Thêm Nguyên Liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public bool Verif(string dulieutrung)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM nguyenlieu WHERE tennguyenlieu = @tennguyenlieu", mynh.GetConnection);
            command.Parameters.Add("@tennguyenlieu", SqlDbType.NChar).Value = dulieutrung;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if ((table.Rows.Count > 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ThemNguyenLieuForm_Load(object sender, EventArgs e)
        {
            comboBoxDonVi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }
    }
}
