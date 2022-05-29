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
    public partial class AddOrderForm : Form
    {
        public AddOrderForm()
        {
            InitializeComponent();
        }

        BANAN banan = new BANAN();
        MONAN monan = new MONAN();
        ORDER order = new ORDER();
        MY_NH mynh = new MY_NH();

        private void AddOrderForm_Load(object sender, EventArgs e)
        {
            SqlCommand command1 = new SqlCommand("SELECT id AS 'Ma Ban An', soluongghe AS 'So Luong Ghe', trangthai AS 'Trang Thai' FROM banan");
            dataGridViewBanAn.DataSource = banan.GetBanAn(command1);
            SqlCommand command2 = new SqlCommand("SELECT id AS 'Ma Mon An', tenmon AS 'Ten Mon An', gia AS 'Gia', " +
                " soluong AS 'So Luong', loaithucan AS 'Loai Thuc An' FROM monan");
            dataGridViewMonAn.DataSource = monan.GetMonAn(command2);
            textBoxIdOrder.Focus();
        }



        //
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
                        AddOrderForm_Load(sender, e);

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


        // Chọn bàn và chuyển trạng thái bàn
        private void dataGridViewBanAn_DoubleClick(object sender, EventArgs e)
        {
            if (banan.CheckTrangThaiBanAn(Convert.ToInt32(dataGridViewBanAn.CurrentRow.Cells[0].Value.ToString())))
            {
                textBoxBanAn.Text = dataGridViewBanAn.CurrentRow.Cells[0].Value.ToString();
                textBoxBanAn.Enabled = false;
            }
            else
            {
                MessageBox.Show("Bàn ăn đã có khách sử dụng!!!", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }


        // Chọn món đó ra các textbox
        private void dataGridViewMonAn_DoubleClick(object sender, EventArgs e)
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


        // Truyền lại món để chỉnh sửa/xóa món đó
        private void dataGridViewOrder_DoubleClick(object sender, EventArgs e)
        {

        }


        // Order xuất hóa đơn + xác nhận + giảm số lượng ở table món ăn
        private void buttonOrder_Click(object sender, EventArgs e)
        {

        }


        // Xóa món
        private void buttonXoaMon_Click(object sender, EventArgs e)
        {

        }


        // Xóa Order
        private void buttonXoaOrder_Click(object sender, EventArgs e)
        {

        }


        // Điều chỉnh số lượng và cập nhật giá.
        private void textBoxSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                int soluongmon = Convert.ToInt32(textBoxSoLuongMon.Text);
                int soluong = Convert.ToInt32(dataGridViewMonAn.CurrentRow.Cells[3].Value.ToString());
                if (soluongmon <= soluong)
                {
                    int gia = Convert.ToInt32(dataGridViewMonAn.CurrentRow.Cells[2].Value.ToString());
                    textBoxGia.Text = (gia * soluongmon).ToString();
                }
                else
                {
                    MessageBox.Show("Món đã hết hoặc không đủ.", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }

           
        }
    }
}
