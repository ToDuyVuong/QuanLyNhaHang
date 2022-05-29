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
    }
}
