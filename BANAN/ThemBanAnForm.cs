using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class ThemBanAnForm : Form
    {
        public ThemBanAnForm()
        {
            InitializeComponent();
        }

        BANAN banan = new BANAN();


        //
        private void radioButtonSuDung_CheckedChanged(object sender, EventArgs e)
        {

        }


        //
        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }


        //
        private void buttonThemBanAn_Click(object sender, EventArgs e)
        {
          try
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
            catch
            {
                MessageBox.Show("Lỗi!", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        // 
        private void ThemBanAnForm_Load(object sender, EventArgs e)
        {
            radioButtonTrong.Checked = true;
        }


        // Check Id Ban An
        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if(textBoxIdBanAn.Text != "")
            {
                int id = Convert.ToInt32(textBoxIdBanAn.Text);
                if(banan.CheckBanAn(id))
                {
                    textBoxSoLuongGhe.Focus();
                }
                else
                {
                    MessageBox.Show("Mã bàn ăn đã tồn tại! Hãy nhập mã mới.", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxIdBanAn.Focus();
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập mã bàn ăn!!", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        // 
        private void textBoxIdBanAn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                textBoxSoLuongGhe.Focus();
        }


        //
        private void textBoxSoLuongGhe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                buttonThemBanAn.Focus();
        }
    }
}
