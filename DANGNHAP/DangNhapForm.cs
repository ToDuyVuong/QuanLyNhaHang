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
    public partial class DangNhapForm : Form
    {
        public DangNhapForm()
        {
            InitializeComponent();
        }



        // Load Form thêm tài khỏa
        private void buttonThemTaiKhoan_Click(object sender, EventArgs e)
        {
            ThemTaiKhoanForm themTaiKhoan = new ThemTaiKhoanForm();
            themTaiKhoan.Show(this);
        }



        private void buttonDangNhap_Click(object sender, EventArgs e)
        {

        }


        // Đóng chương trình
        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
