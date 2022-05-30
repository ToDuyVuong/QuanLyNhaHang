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
        DOANHTHU doanhthu = new DOANHTHU();

        // Thanh toan
        private void buttonThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                //
                int id = Convert.ToInt32(textBoxIdOrder.Text);
                int idban = Convert.ToInt32(textBoxBanAn.Text);

                // Tổng tiền
                SqlCommand command = new SqlCommand("SELECT  id AS 'Ma Order', idban AS 'Ma Ban', tenmon AS 'Ten Mon', soluong AS 'So Luong', " +
                     "gia AS 'Gia' FROM od  WHERE id = @id AND idban = @idban", mynh.GetConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@idban", SqlDbType.Int).Value = idban;
                int tamtinh = 0;
                DataTable table = new DataTable();
                table = order.GetOrder(command);
                int n = table.Rows.Count;
                for (int i = 0; i < n; i++)
                {
                    tamtinh += Convert.ToInt32(table.Rows[i]["gia"].ToString());
                }
                string tongtien = ("Tổng sô tiền là: " + tamtinh + " VND");

                if ((MessageBox.Show("Xác nhận thanh toán. " + tongtien, "Thông Báo.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {

                    if ((MessageBox.Show("Bạn có muốn In Hóa Đơn hay không.", "Thông Báo.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {

                        // Tiêu Đề In
                        DGVPrinter print = new DGVPrinter();
                        print.Title = ("Hóa Đơn");
                        print.SubTitle = String.Format("Mã Order: " + id + "             Mã Bàn: " + idban + "                              " + tongtien);

                        // In
                        print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                        print.PageNumbers = true;
                        print.PageNumberInHeader = false;
                        print.PorportionalColumns = true;
                        print.HeaderCellAlignment = StringAlignment.Near;
                        print.Footer = "Foxlearn";
                        print.FooterSpacing = 15;
                        print.PrintDataGridView(dataGridViewOrder);
                    }

                    // Upde trạng thái bàn
                    banan.UpdateTrangThaiBanAn(idban, false);

                    // Upde trạng thái đã thanh toán
                    string trangthai = "thanhtoan";
                    order.UpdateTrangThaiOrder(id, idban, trangthai);
                    MessageBox.Show("Thanh Toán Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Question);

                    //Ttải lại dataGridViewOrder trống
                    SqlCommand command1 = new SqlCommand("SELECT id AS 'Ma Order', idban AS 'Ma Ban', tenmon AS 'Ten Mon', soluong AS 'So Luong', " +
                                "gia AS 'Gia' FROM od  WHERE id = @id AND idban = @idban", mynh.GetConnection);
                    command1.Parameters.Add("@id", SqlDbType.Int).Value = 0;
                    command1.Parameters.Add("@idban", SqlDbType.Int).Value = 0;
                    dataGridViewOrder.DataSource = order.GetOrder(command1);

                    // Tải lại dataGridViewOrderBan trống
                    SqlCommand command3 = new SqlCommand("SELECT id AS 'Ma Order', idban AS 'Ma Ban'" +
                                ", trangthai AS 'Trang Thai' FROM od WHERE trangthai = 'order' GROUP BY id, idban, trangthai");
                    dataGridViewOrderBan.DataSource = order.GetOrder(command3);

                    textBoxBanAn.Text = "";
                    textBoxIdOrder.Text = "";
                    textBoxIdOrder.Enabled = false;
                    textBoxBanAn.Enabled = false;

                    // Cập nhật doanh thu
                    DateTime dt = DateTime.Now;
                    String.Format("{0:dd-MM-yyyy}", dt);
                    doanhthu.InsertDoanhThu(id, tamtinh, dt);

                }
            }
            catch
            {
                MessageBox.Show("Báo lỗi!!!", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        // Thoát
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ThanhToanForm_Load(object sender, EventArgs e)
        {

            try
            {
                int id = Convert.ToInt32(textBoxIdOrder.Text);
                int idban = Convert.ToInt32(textBoxBanAn.Text);
                SqlCommand command = new SqlCommand("SELECT id AS 'Ma Order', idban AS 'Ma Ban', tenmon AS 'Ten Mon', soluong AS 'So Luong', " +
                    "gia AS 'Gia' FROM od  WHERE id = @id AND idban = @idban", mynh.GetConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@idban", SqlDbType.Int).Value = idban;
                dataGridViewOrder.DataSource = order.GetOrder(command);
                int tamtinh = 0;
                DataTable table = new DataTable();
                table = order.GetOrder(command);
                int n = table.Rows.Count;
                for (int i = 0; i < n; i++)
                {
                    tamtinh += Convert.ToInt32(table.Rows[i]["gia"].ToString());
                }
                labelTamTinh.Text = ("Tạm tính: " + tamtinh + " VND");
            }
            catch
            {
                SqlCommand command = new SqlCommand("SELECT id AS 'Ma Order', idban AS 'Ma Ban', tenmon AS 'Ten Mon', soluong AS 'So Luong', " +
                    "gia AS 'Gia' FROM od  WHERE id = @id AND idban = @idban", mynh.GetConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = 0;
                command.Parameters.Add("@idban", SqlDbType.Int).Value = 0;
                dataGridViewOrder.DataSource = order.GetOrder(command);
            }


            SqlCommand command3 = new SqlCommand("SELECT id AS 'Ma Order', idban AS 'Ma Ban'" +
                    ", trangthai AS 'Trang Thai' FROM od WHERE trangthai = 'order' GROUP BY id, idban, trangthai");
            dataGridViewOrderBan.DataSource = order.GetOrder(command3);


            textBoxIdOrder.Enabled = false;
            textBoxBanAn.Enabled = false;

        }

        private void dataGridViewOrderBan_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                textBoxIdOrder.Text = dataGridViewOrderBan.CurrentRow.Cells[0].Value.ToString();
                textBoxBanAn.Text = dataGridViewOrderBan.CurrentRow.Cells[1].Value.ToString();
                textBoxIdOrder.Enabled = false;
                textBoxBanAn.Enabled = false;

                int id = Convert.ToInt32(textBoxIdOrder.Text);
                int idban = Convert.ToInt32(textBoxBanAn.Text);

                SqlCommand command = new SqlCommand("SELECT  id AS 'Ma Order', idban AS 'Ma Ban', tenmon AS 'Ten Mon', soluong AS 'So Luong', " +
                    "gia AS 'Gia' FROM od  WHERE id = @id AND idban = @idban", mynh.GetConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@idban", SqlDbType.Int).Value = idban;
                dataGridViewOrder.DataSource = order.GetOrder(command);

                int tamtinh = 0;
                DataTable table = new DataTable();
                table = order.GetOrder(command);
                int n = table.Rows.Count;
                for (int i = 0; i < n; i++)
                {
                    tamtinh += Convert.ToInt32(table.Rows[i]["gia"].ToString());
                }
                labelTamTinh.Text = ("Tạm tính: " + tamtinh + " VND");
            }
            catch
            {

            }
        }
    }
}
