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
    public partial class ThanhToanForm : Form
    {
        public ThanhToanForm()
        {
            InitializeComponent();
        }

        DanhSachOrderForm danhsachorder = new DanhSachOrderForm();
        BANAN banan = new BANAN();
        MONAN monan = new MONAN();
        ORDER order = new ORDER();
        MY_NH mynh = new MY_NH();

        private void buttonThanhToan_Click(object sender, EventArgs e)
        {

        }


        // Thoát
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ThanhToanForm_Load(object sender, EventArgs e)
        {
           /* textBoxBanAn.Text = danhsachorder.textBoxBanAn.Text;
            textBoxIdOrder.Text = danhsachorder.textBoxIdOrder.Text;
            textBoxBanAn.Enabled = false;
            textBoxIdOrder.Enabled = false;*/

            int id = Convert.ToInt32(danhsachorder.textBoxIdOrder.Text);/////////////////////////////////////////////// Loi
            int idban = Convert.ToInt32(danhsachorder.textBoxBanAn.Text);
            SqlCommand command = new SqlCommand("SELECT id AS 'Ma Order' idban AS 'Ma Ban' tenmon AS 'Ten Mon', soluong AS 'So Luong', gia AS 'Gia' " +
                "FROM od  WHERE id = @id, idban = @idban", mynh.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@idban", SqlDbType.Int).Value = idban;
            dataGridViewOrder.DataSource = order.GetOrder(command);

        }
    }
}
