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
    public partial class HoaDonForm : Form
    {
        public HoaDonForm()
        {
            InitializeComponent();
        }

        //
        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OrderDanhSachForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonXacNhan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order thành công.", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
