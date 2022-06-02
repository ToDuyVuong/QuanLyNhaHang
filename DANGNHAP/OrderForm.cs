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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }


        //
        private void orderNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrderForm orderForm = new AddOrderForm();
            orderForm.Show(this);
        }


        //
        private void danhSáchOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachOrderForm danhSachOrderForm = new DanhSachOrderForm();
            danhSachOrderForm.Show(this);
        }

        private void danhSáchBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachBanAnForm danhSachBanAnForm = new DanhSachBanAnForm();
            danhSachBanAnForm.Show(this);
        }

        private void buttonDanhSachBanAn_Click(object sender, EventArgs e)
        {
            DanhSachBanAnForm danhSachBanAnForm = new DanhSachBanAnForm();
            danhSachBanAnForm.Show(this);
        }

        private void buttonDanhSachMon_Click(object sender, EventArgs e)
        {
            DanhSachMonForm printForm = new DanhSachMonForm();
            printForm.Show(this);
        }

        private void buttonOrderNew_Click(object sender, EventArgs e)
        {
            AddOrderForm orderForm = new AddOrderForm();
            orderForm.Show(this);
        }

        private void buttonThanhToan_Click(object sender, EventArgs e)
        {
            ThanhToanForm thanhToanForm = new ThanhToanForm();
            thanhToanForm.Show(this);
        }


        // Thoát
        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonDanhSachOrder_Click(object sender, EventArgs e)
        {
            DanhSachOrderForm danhSachOrderForm = new DanhSachOrderForm();
            danhSachOrderForm.Show(this);
        }
    }
}
