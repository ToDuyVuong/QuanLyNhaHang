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
    public partial class ChinhSuaBanAnForm : Form
    {
        public ChinhSuaBanAnForm()
        {
            InitializeComponent();
        }

        BANAN banan = new BANAN();


        //
        private void buttonChinhSuaBanAn_Click(object sender, EventArgs e)
        {
            try
            {
                bool trangthai = false;
                if(radioButtonSuDung.Checked == true)
                {
                    trangthai = true;
                }    
                int soluongghe = Convert.ToInt32(textBoxSoLuongGhe.Text);
                int id = Convert.ToInt32(textBoxIdBanAn.Text);
                if(banan.UpdateBanAn(id, soluongghe, trangthai))
                {
                    MessageBox.Show("Chỉnh sửa bàn ăn thành công.", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ChinhSuaBanAnForm_Load(sender, e);
                }
                else
                    MessageBox.Show("Chỉnh sửa bàn ăn không thành công!!!", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch
            {
                MessageBox.Show("Chỉnh sửa bàn ăn gặp lỗi!!!", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }


        //
        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }


        //
        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if(textBoxIdBanAn.Text != "")
            {
                try
                {
                    int id = Convert.ToInt32(textBoxIdBanAn.Text);
                    SqlCommand command = new SqlCommand("SELECT * FROM banan WHERE  id = " + id);
                    fillGrid(command);
                }
                catch
                {
                    MessageBox.Show("Báo lỗi!!!", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }


        //
        private void ChinhSuaBanAnForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT id AS 'Ban An So', soluongghe AS 'So Luong Ghe Cua Ban', trangthai AS 'Trang Thai'  FROM banan");
            fillGrid(command);
            labelTongSoLuongBanAn.Text = ("Tổng Số Lượng Bàn Ăn: " + (dataGridViewChinhSuaBanAn.Rows.Count));
        }


        //
        // Nạp dữ liệu
        public void fillGrid(SqlCommand command)
        {
            dataGridViewChinhSuaBanAn.RowTemplate.ReadOnly = true;
            dataGridViewChinhSuaBanAn.RowTemplate.Height = 80;
            dataGridViewChinhSuaBanAn.DataSource = banan.GetBanAn(command);
            dataGridViewChinhSuaBanAn.AllowUserToAddRows = false;

            // Đếm số lượng Student
            //labelTotalStudents.Text = ("Total Students: " + dataGridView1.Rows.Count);
        }

        private void dataGridViewChinhSuaBanAn_DoubleClick(object sender, EventArgs e)
        {
            textBoxIdBanAn.Text = dataGridViewChinhSuaBanAn.CurrentRow.Cells[0].Value.ToString();
            textBoxSoLuongGhe.Text = dataGridViewChinhSuaBanAn.CurrentRow.Cells[1].Value.ToString();
            int id = Convert.ToInt32(textBoxIdBanAn.Text);
            string i = dataGridViewChinhSuaBanAn.CurrentRow.Cells[2].Value.ToString();
            if (i == "True")
                radioButtonSuDung.Checked = true;
            else
                radioButtonTrong.Checked = true;
            SqlCommand command = new SqlCommand("SELECT id AS 'Ban An So', soluongghe AS 'So Luong Ghe Cua Ban', trangthai AS 'Trang Thai'  FROM banan WHERE id = " + id);
            fillGrid(command);
            labelTongSoLuongBanAn.Text = ("");
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            // Xóa bàn ăn
            try
            {
                int id = Convert.ToInt32(textBoxIdBanAn.Text);

                if ((MessageBox.Show("Bạn có chắc chắn muốn xóa bàn ăn này chứ!!", "Thông Báo.",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (banan.DeleteBanAn(id))
                    {
                        MessageBox.Show("Đã xóa thành công.", "Thông Báo.", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        textBoxIdBanAn.Text = "";
                        textBoxSoLuongGhe.Text = "";
                        radioButtonTrong.Checked = false;
                        radioButtonSuDung.Checked = false;
                        ChinhSuaBanAnForm_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công!!! Id bàn không tồn tại!!!", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Báo lỗi!!!", "Thông Báo.",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonTaiLai_Click(object sender, EventArgs e)
        {
            ChinhSuaBanAnForm_Load(sender, e);
            textBoxIdBanAn.Text = "";
            textBoxSoLuongGhe.Text = "";
        }

        private void buttonThemBanAn_Click(object sender, EventArgs e)
        {
            try
            {
                if ((MessageBox.Show("Bạn có chắc chắn muốn thêm bàn ăn mới này chứ!!", "Thông Báo.",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (textBoxIdBanAn.Text != "" && textBoxSoLuongGhe.Text != "")
                    {
                        int id = Convert.ToInt32(textBoxIdBanAn.Text);
                        int soluongghe = Convert.ToInt32(textBoxSoLuongGhe.Text);
                        bool trangthai = true;
                        if (radioButtonTrong.Checked)
                            trangthai = false;
                        if (banan.InsertBanAn(id, soluongghe, trangthai))
                        {
                            MessageBox.Show("Đã thêm bàn ăn thành công.", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            ChinhSuaBanAnForm_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Thêm bàn ăn không thành công!!", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Hãy nhập đầy đủ thông tin!!", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }   
            }
            catch { }
        }
    }
}
