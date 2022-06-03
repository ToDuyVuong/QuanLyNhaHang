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
    public partial class PhanCongNhanSuForm : Form
    {
        public PhanCongNhanSuForm()
        {
            InitializeComponent();
        }
        PHANCONG phancong = new PHANCONG();

        //
        private void PhanCongNhanSuForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT id AS 'Mã Nhân Sự', hoten AS 'Họ Và Tên', " +
                "calam AS 'Mã Ca Làm' FROM phancong");
            dataGridViewPhanCong.DataSource = phancong.GetPhanCong(command);
            labelPhanCong.Text = "Phân Công.";

        }


        //
        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }


        //
        private void dataGridViewPhanCong_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                textBoxId.Text = dataGridViewPhanCong.CurrentRow.Cells[0].Value.ToString();
                textBoxHoTen.Text = dataGridViewPhanCong.CurrentRow.Cells[1].Value.ToString().Trim();
                textBoxMaCaLam.Text = dataGridViewPhanCong.CurrentRow.Cells[2].Value.ToString();
            }
            catch
            {

            }
        }


        //
        private void buttonChinhSua_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxId.Text);
                string hoten = textBoxHoTen.Text;
                int calam = Convert.ToInt32(textBoxMaCaLam.Text);
                if (phancong.UpdatePhanCong(id, hoten, calam))
                {
                    PhanCongNhanSuForm_Load(sender, e);
                    MessageBox.Show("Chỉnh phân công thành công", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    MessageBox.Show("Chỉnh phân công không thành công", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch
            {
                MessageBox.Show("Báo lỗi.", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxId.Text);
                string hoten = textBoxHoTen.Text;
                int calam = Convert.ToInt32(textBoxMaCaLam.Text);
                if (phancong.InsertPhanCong(id, hoten, calam, 0))
                {
                    PhanCongNhanSuForm_Load(sender, e);
                    MessageBox.Show("Thêm phân công thành công thành công", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    MessageBox.Show("Thêm phân công không thành công", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch
            {
                MessageBox.Show("Báo lỗi.", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonTaiLai_Click(object sender, EventArgs e)
        {
            PhanCongNhanSuForm_Load(sender, e);
        }

        private void buttonDaoCaLam_Click(object sender, EventArgs e)
        {
            try
            {
                if ((MessageBox.Show("Xác Nhận Đảo Tòa Bộ Phân Công Nhân Viên", "Thông Báo.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes))
                {
                    SqlCommand command = new SqlCommand("SELECT *  FROM phancong WHERE quanly = 0");
                    DataTable table = new DataTable();
                    table = phancong.GetPhanCong(command);
                    int n = table.Rows.Count;
                    Random rd = new Random();
                    int calam = 0;
                    if ((MessageBox.Show("Đảo Bằng Cách Random Toàn Bộ.", "Thông Báo.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes))

                    {
                        for (int i = 0; i < n; i++)
                        {
                            calam = rd.Next(1, 4);
                            int id = Convert.ToInt32(table.Rows[i]["id"].ToString());
                            string hoten = table.Rows[i]["hoten"].ToString();
                            if (phancong.UpdatePhanCong(id, hoten, calam)) { }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < n; i++)
                        {
                            calam = Convert.ToInt32(table.Rows[i]["calam"].ToString());
                            int id = Convert.ToInt32(table.Rows[i]["id"].ToString());
                            string hoten = table.Rows[i]["hoten"].ToString();
                            calam++;
                            if (calam == 4)
                            { calam = 1; }
                            if (phancong.UpdatePhanCong(id, hoten, calam)) { }
                        }
                    }

                    PhanCongNhanSuForm_Load(sender, e);
                    MessageBox.Show("Thành công.", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }



            }
            catch
            {
                MessageBox.Show("Báo lỗi.", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxId.Text);
                if (phancong.DeletePhanCong(id))
                {
                    textBoxHoTen.Text = "";
                    textBoxId.Text = "";
                    textBoxMaCaLam.Text = "";

                    PhanCongNhanSuForm_Load(sender, e);
                    MessageBox.Show("Xóa thành công thành công", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    MessageBox.Show("Xóa không thành công", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch
            {
                MessageBox.Show("Báo lỗi.", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        //
        private void radioButtonTatCa_CheckedChanged(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand("SELECT id AS 'Mã Nhân Sự', hoten AS 'Họ Và Tên', " +
                "calam AS 'Mã Ca Làm' FROM phancong ");
            dataGridViewPhanCong.DataSource = phancong.GetPhanCong(command);
            labelPhanCong.Text = "Phân Công.";
        }


        //
        private void radioButtonQuanLy_CheckedChanged(object sender, EventArgs e)
        {
            SqlCommand command1 = new SqlCommand("SELECT id AS 'Mã Nhân Sự', hoten AS 'Họ Và Tên', " +
                "calam AS 'Mã Ca Làm' FROM phancong WHERE quanly = 1");
            dataGridViewPhanCong.DataSource = phancong.GetPhanCong(command1);
            labelPhanCong.Text = "Phân Công Quản Lý.";
        }

        private void radioButtonNhanVien_CheckedChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT id AS 'Mã Nhân Sự', hoten AS 'Họ Và Tên', " +
                "calam AS 'Mã Ca Làm' FROM phancong WHERE quanly = 0");
            dataGridViewPhanCong.DataSource = phancong.GetPhanCong(command);
            labelPhanCong.Text = "Phân Công Nhân Viên.";
        }

        private void buttonDaoCaQuanLy_Click(object sender, EventArgs e)
        {
            try
            {
                if ((MessageBox.Show("Xác Nhận Đảo Tòa Bộ Phân Công Quản Lý", "Thông Báo.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes))
                {
                    SqlCommand command = new SqlCommand("SELECT *  FROM phancong WHERE quanly = 1");
                    DataTable table = new DataTable();
                    table = phancong.GetPhanCong(command);
                    int n = table.Rows.Count;
                    int calam = 0;

                    for (int i = 0; i < n; i++)
                    {
                        calam = Convert.ToInt32(table.Rows[i]["calam"].ToString());
                        int id = Convert.ToInt32(table.Rows[i]["id"].ToString());
                        string hoten = table.Rows[i]["hoten"].ToString();
                        calam += 2;
                        if (calam == 8)
                        { calam = 1; }
                        if (calam == 7)
                        { calam = 2; }
                        if (phancong.UpdatePhanCong(id, hoten, calam)) { }
                    }


                    PhanCongNhanSuForm_Load(sender, e);
                    MessageBox.Show("Thành công.", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }



            }
            catch
            {
                MessageBox.Show("Báo lỗi.", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
