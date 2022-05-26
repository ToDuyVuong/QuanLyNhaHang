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
                int id = Convert.ToInt32(textBoxIdBanAn.Text);

                SqlCommand command = new SqlCommand("SELECT * FROM banan WHERE  id =" + id);
                fillGrid(command);
            }
        }


        //
        private void ChinhSuaBanAnForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM banan");
            fillGrid(command);
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
            string i = dataGridViewChinhSuaBanAn.CurrentRow.Cells[2].Value.ToString();
            if (i == "True")
                radioButtonSuDung.Checked = true;
            else
                radioButtonTrong.Checked = true;
      //      if(dataGridViewChinhSuaNhanSu.CurrentRow.Cells[4].Value.ToString() == true)
        }
    }
}
