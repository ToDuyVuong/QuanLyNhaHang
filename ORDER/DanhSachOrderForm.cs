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
    public partial class DanhSachOrderForm : Form
    {
        public DanhSachOrderForm()
        {
            InitializeComponent();
        }

        BANAN banan = new BANAN();
        MONAN monan = new MONAN();
        ORDER order = new ORDER();
        MY_NH mynh = new MY_NH();




        // Thoát
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }



        // Load
        private void DanhSachOrderForm_Load(object sender, EventArgs e)
        {
            SqlCommand command1 = new SqlCommand("SELECT id AS 'Ma Ban An', soluongghe AS 'So Luong Ghe', trangthai AS 'Trang Thai' FROM banan");
            dataGridViewBanAn.DataSource = banan.GetBanAn(command1);

            SqlCommand command2 = new SqlCommand("SELECT id AS 'Ma Mon An', tenmon AS 'Ten Mon An', gia AS 'Gia', " +
                " soluong AS 'So Luong', loaithucan AS 'Loai Thuc An' FROM monan");
            dataGridViewMonAn.DataSource = monan.GetMonAn(command2);
            textBoxBanAn.Enabled = false;
            textBoxIdOrder.Enabled = false;
            try
            {

                SqlCommand command3 = new SqlCommand("SELECT id AS 'Ma Order', idban AS 'Ma Ban'" +
                    ", trangthai AS 'Trang Thai' FROM od  WHERE trangthai = 'cho' OR trangthai = 'order'" +
                    " GROUP BY id, idban, trangthai");
                dataGridViewOrderBan.DataSource = order.GetOrder(command3);



            }
            catch
            {
                MessageBox.Show("Báo lỗi!!!", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }



        // Chọn bàn và chuyển trạng thái bàn
        private void dataGridViewBanAn_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int idban = Convert.ToInt32(dataGridViewBanAn.CurrentRow.Cells[0].Value.ToString());

                textBoxBanAn.Text = dataGridViewBanAn.CurrentRow.Cells[0].Value.ToString();
                textBoxBanAn.Enabled = false;
                SqlCommand command3 = new SqlCommand("SELECT id AS 'Ma Order', idban AS 'Ma Ban'" +
                    ", trangthai AS 'Trang Thai' FROM od WHERE idban = @idban GROUP BY id, idban, trangthai", mynh.GetConnection);
               /* SqlCommand command3 = new SqlCommand("SELECT id AS 'Ma Order', idban AS 'Ma Ban'" +
                    " FROM od WHERE idban = @idban, trangthai = 'order' GROUP BY id, idban", mynh.GetConnection);*/
                command3.Parameters.Add("@idban", SqlDbType.Int).Value = idban;
                dataGridViewOrderBan.DataSource = order.GetOrder(command3);

                

            }
            catch
            {
                MessageBox.Show("Báo lỗi!!!", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }



        // Chinh Sửa Order
        private void dataGridViewOrder_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị
                textBoxTenMon.Text = dataGridViewOrder.CurrentRow.Cells[0].Value.ToString();
                textBoxSoLuongMon.Text = dataGridViewOrder.CurrentRow.Cells[1].Value.ToString();
                textBoxGia.Text = dataGridViewOrder.CurrentRow.Cells[2].Value.ToString();
                int id = Convert.ToInt32(textBoxIdOrder.Text);
                int idban = Convert.ToInt32(textBoxBanAn.Text);
                string tenmon = dataGridViewOrder.CurrentRow.Cells[0].Value.ToString();

                SqlCommand command4 = new SqlCommand("SELECT * FROM od  WHERE id = @id AND idban = @idban AND tenmon = @tenmon", mynh.GetConnection);
                command4.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command4.Parameters.Add("@idban", SqlDbType.Int).Value = idban;
                command4.Parameters.Add("@tenmon", SqlDbType.NVarChar).Value = tenmon;
                DataTable table = new DataTable();
                table = order.GetOrder(command4);
                textBoxIdMon.Text = table.Rows[0]["idmon"].ToString();
                textBoxLoaiThucAn.Text = "";



            }
            catch
            {
                MessageBox.Show("Báo lỗi!!!", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }



        // Chọn Bàn
        private void dataGridViewOrderBan_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                textBoxIdOrder.Text = dataGridViewOrderBan.CurrentRow.Cells[0].Value.ToString();
                textBoxBanAn.Text = dataGridViewOrderBan.CurrentRow.Cells[1].Value.ToString();
                textBoxIdOrder.Enabled = false;

                int id = Convert.ToInt32(textBoxIdOrder.Text);
                int idban = Convert.ToInt32(textBoxBanAn.Text);

                SqlCommand command = new SqlCommand("SELECT tenmon AS 'Ten Mon', soluong AS 'So Luong', " +
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
                MessageBox.Show("Báo lỗi!!!", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        // Chọn món đó ra các textbox
        private void dataGridViewMonAn_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                //
                textBoxIdMon.Enabled = false;
                textBoxGia.Enabled = false;
                textBoxLoaiThucAn.Enabled = false;
                textBoxTenMon.Enabled = false;

                //
                textBoxIdMon.Text = dataGridViewMonAn.CurrentRow.Cells[0].Value.ToString();
                textBoxTenMon.Text = dataGridViewMonAn.CurrentRow.Cells[1].Value.ToString();
                textBoxSoLuongMon.Text = "1";
                textBoxGia.Text = dataGridViewMonAn.CurrentRow.Cells[2].Value.ToString();
                textBoxLoaiThucAn.Text = dataGridViewMonAn.CurrentRow.Cells[4].Value.ToString();



            }
            catch
            {
                MessageBox.Show("Báo lỗi!!!", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }




        }



        //  + giảm số lượng ở table món ăn
        private void buttonThemMon_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị
                int id = Convert.ToInt32(textBoxIdOrder.Text);
                int idmon = Convert.ToInt32(textBoxIdMon.Text);
                int idban = Convert.ToInt32(textBoxBanAn.Text);
                string tenmon = textBoxTenMon.Text;
                string loaithucan = textBoxLoaiThucAn.Text;
                int gia = Convert.ToInt32(textBoxGia.Text);
                int soluongmon = Convert.ToInt32(textBoxSoLuongMon.Text);

                if (textBoxLoaiThucAn.Text != "")
                {

                    // Thêm món
                    if (order.CheckOrderMon(id, idban, idmon))
                    {
                        if (order.InsertOrderMon(id, idban, idmon, tenmon, soluongmon, gia))
                        {
                            SqlCommand command = new SqlCommand("SELECT tenmon AS 'Ten Mon', soluong AS 'So Luong', gia AS 'Gia' FROM od  WHERE id = @id AND idban = @idban", mynh.GetConnection);
                            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                            command.Parameters.Add("@idban", SqlDbType.Int).Value = idban;
                            dataGridViewOrder.DataSource = order.GetOrder(command);

                            banan.UpdateTrangThaiBanAn(idban, true);
                            int soluong = Convert.ToInt32(dataGridViewMonAn.CurrentRow.Cells[3].Value.ToString());
                            int soluongconlai = soluong - soluongmon;
                            monan.UpdateSoLuongMonAn(tenmon, soluongconlai);
                            DanhSachOrderForm_Load(sender, e);

                            // Số tiền tạm tính.
                            int tamtinh = 0;
                            SqlCommand command4 = new SqlCommand("SELECT * FROM od  WHERE id = @id AND idban = @idban", mynh.GetConnection);
                            command4.Parameters.Add("@id", SqlDbType.Int).Value = id;
                            command4.Parameters.Add("@idban", SqlDbType.Int).Value = idban;
                            DataTable table = new DataTable();
                            table = order.GetOrder(command4);
                            int n = table.Rows.Count;
                            for (int i = 0; i < n; i++)
                            {
                                tamtinh += Convert.ToInt32(table.Rows[i]["gia"].ToString());
                            }
                            labelTamTinh.Text = ("Tạm tính: " + tamtinh + " VND");

                            MessageBox.Show("Đã thêm món thành công", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Thêm món không thành công!", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Món này đã tồn tại trong Order bạn có thể chỉnh sửa nó lại!", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (order.UpdateOrderMon(id, idban, idmon, soluongmon, gia))
                    {
                        SqlCommand command = new SqlCommand("SELECT tenmon AS 'Ten Mon', soluong AS 'So Luong', gia AS 'Gia' FROM od  WHERE id = @id AND idban = @idban", mynh.GetConnection);
                        command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        command.Parameters.Add("@idban", SqlDbType.Int).Value = idban;
                        dataGridViewOrder.DataSource = order.GetOrder(command);

                        banan.UpdateTrangThaiBanAn(idban, true);
                        int soluong = Convert.ToInt32(dataGridViewMonAn.CurrentRow.Cells[3].Value.ToString());
                        int soluongconlai = soluong - soluongmon;
                        monan.UpdateSoLuongMonAn(tenmon, soluongconlai);
                        DanhSachOrderForm_Load(sender, e);

                        // Số tiền tạm tính.
                        int tamtinh = 0;
                        SqlCommand command4 = new SqlCommand("SELECT * FROM od  WHERE id = @id AND idban = @idban", mynh.GetConnection);
                        command4.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        command4.Parameters.Add("@idban", SqlDbType.Int).Value = idban;
                        DataTable table = new DataTable();
                        table = order.GetOrder(command4);
                        int n = table.Rows.Count;
                        for (int i = 0; i < n; i++)
                        {
                            tamtinh += Convert.ToInt32(table.Rows[i]["gia"].ToString());
                        }
                        labelTamTinh.Text = ("Tạm tính: " + tamtinh + " VND");

                        MessageBox.Show("Đã chỉnh sửa món thành công", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Chỉnh sửa món không thành công!", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
            }
            catch
            {
                MessageBox.Show("Báo lỗi!!!", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        // Order xuất hóa đơn + xác nhận
        private void buttonOrder_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxIdOrder.Text);
                int idban = Convert.ToInt32(textBoxBanAn.Text);
                string trangthai = "order";
                order.UpdateTrangThaiOrder(id, idban, trangthai);
                SqlCommand command = new SqlCommand("SELECT tenmon AS 'Ten Mon', soluong AS 'So Luong', gia AS 'Gia' FROM od  WHERE id = @id", mynh.GetConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = 0;
                dataGridViewOrder.DataSource = order.GetOrder(command);


                SqlCommand command3 = new SqlCommand("SELECT id AS 'Ma Order', idban AS 'Ma Ban'" +
                    ", trangthai AS 'Trang Thai' FROM od WHERE idban = @idban GROUP BY id, idban, trangthai", mynh.GetConnection);
                command3.Parameters.Add("@idban", SqlDbType.Int).Value = idban;
                dataGridViewOrderBan.DataSource = order.GetOrder(command3);

                MessageBox.Show("Order thành công.", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Question);

                textBoxIdOrder.Text = "";
                textBoxIdMon.Text = "";
                textBoxSoLuongMon.Text = "";
                textBoxTenMon.Text = "";
                textBoxGia.Text = "";
                textBoxBanAn.Text = "";
                textBoxLoaiThucAn.Text = "";
                labelTamTinh.Text = ("Tạm tính: ");
            }
            catch
            {
                MessageBox.Show("Báo lỗi!!!", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        // Check Id order
        private void buttonCheckOrder_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxIdOrder.Text);
                if (order.CheckIdOder(id))
                {
                    MessageBox.Show("Id hợp lệ", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    MessageBox.Show("Id đã tồn tại!!", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Báo lỗi!!!", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        // Xóa Order Bàn
        private void buttonXoaBan_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxIdOrder.Text);
                int idban = Convert.ToInt32(textBoxBanAn.Text);

                order.DeleteOrdeBan(id, idban);

                textBoxBanAn.Enabled = true;
                textBoxIdOrder.Enabled = true;

                SqlCommand command3 = new SqlCommand("SELECT id AS 'Ma Order', idban AS 'Ma Ban'" +
                    ", trangthai AS 'Trang Thai' FROM od WHERE idban = @idban GROUP BY id, idban, trangthai", mynh.GetConnection);
                command3.Parameters.Add("@idban", SqlDbType.Int).Value = 0;
                dataGridViewOrderBan.DataSource = order.GetOrder(command3);

                SqlCommand command = new SqlCommand("SELECT tenmon AS 'Ten Mon', soluong AS 'So Luong', gia AS 'Gia' FROM od  WHERE id = @id AND idban = @idban", mynh.GetConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = 0;
                command.Parameters.Add("@idban", SqlDbType.Int).Value = 0;
                dataGridViewOrder.DataSource = order.GetOrder(command);

                DanhSachOrderForm_Load(sender, e);

                MessageBox.Show("Xóa bàn order thành công.", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Question);

                textBoxIdOrder.Text = "";
                textBoxIdMon.Text = "";
                textBoxSoLuongMon.Text = "";
                textBoxTenMon.Text = "";
                textBoxGia.Text = "";
                textBoxBanAn.Text = "";
                textBoxLoaiThucAn.Text = "";
                labelTamTinh.Text = ("Tạm tính: ");
            }
            catch
            {
                MessageBox.Show("Báo lỗi!!!", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }



        // Điều chỉnh số lượng và cập nhật giá.
        private void textBoxSoLuongMon_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    int idmon = Convert.ToInt32(textBoxIdMon.Text);
                    SqlCommand command4 = new SqlCommand("SELECT * FROM monan WHERE id = @idmon", mynh.GetConnection);
                    command4.Parameters.Add("@idmon", SqlDbType.Int).Value = idmon;
                    DataTable table = new DataTable();
                    table = monan.GetMonAn(command4);

                    int soluongmon = Convert.ToInt32(textBoxSoLuongMon.Text);
                    int soluong = Convert.ToInt32(dataGridViewMonAn.CurrentRow.Cells[3].Value.ToString());
                    if (soluongmon <= soluong)
                    {
                        int gia = Convert.ToInt32(table.Rows[0]["gia"].ToString());
                        textBoxGia.Text = (gia * soluongmon).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Món đã hết hoặc không đủ.", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            catch
            {
                MessageBox.Show("Báo lỗi!!!", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }



        // Thanh toán
        private void buttonThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                ThanhToanForm thanhToanForm = new ThanhToanForm();
                int id = Convert.ToInt32(textBoxIdOrder.Text);
                int idban = Convert.ToInt32(textBoxBanAn.Text);
                if (MessageBox.Show("Xác nhận thanh toán.", "Thông Báo.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    thanhToanForm.textBoxIdOrder.Text = textBoxIdOrder.Text;
                    thanhToanForm.textBoxBanAn.Text = textBoxBanAn.Text;
                    thanhToanForm.Show(this);
                }
            }
            catch
            {
                MessageBox.Show("Báo lỗi!!!", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }



        // Hiện tát cả bàn đã order
        private void radioButtonDaOrder_CheckedChanged(object sender, EventArgs e)
        {
            try
            {                
                textBoxBanAn.Enabled = false;
                textBoxIdOrder.Enabled = false;
                SqlCommand command3 = new SqlCommand("SELECT id AS 'Ma Order', idban AS 'Ma Ban'" +
                    ", trangthai AS 'Trang Thai' FROM od WHERE trangthai = 'order' GROUP BY id, idban, trangthai");
                dataGridViewOrderBan.DataSource = order.GetOrder(command3);



            }
            catch
            {
                MessageBox.Show("Báo lỗi!!!", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        

        // Hiện tát cả order bàn
        private void radioButtonTatCa_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxBanAn.Enabled = false;
                textBoxIdOrder.Enabled = false;
                SqlCommand command3 = new SqlCommand("SELECT id AS 'Ma Order', idban AS 'Ma Ban'" +
                    ", trangthai AS 'Trang Thai' FROM od  WHERE trangthai = 'cho' OR trangthai = 'order' GROUP BY id, idban, trangthai");
                
                dataGridViewOrderBan.DataSource = order.GetOrder(command3);



            }
            catch
            {
                MessageBox.Show("Báo lỗi!!!", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        // Tải lại
        private void buttonTaiLai_Click(object sender, EventArgs e)
        {
            DanhSachOrderForm_Load(sender, e);
        }
    }
}
