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
            SqlCommand command2 = new SqlCommand("SELECT id AS 'Ma Mon An', tenmon AS 'Ten Mon An', gia AS 'Gia'," +
                " soluong AS 'So Luong', loaithucan AS 'Loai Thuc An' FROM monan");
            dataGridViewMonAn.DataSource = monan.GetMonAn(command2);
          /*  //   SqlCommand command3 = new SqlCommand("SELECT tenmon AS 'Ten Mon', soluong AS 'So Luong', gia AS 'Gia' FROM order");

            int id = Convert.ToInt32(textBoxIdOrder.Text);
            int idmon = Convert.ToInt32(textBoxIdMon.Text);
            int idban = Convert.ToInt32(textBoxBanAn.Text);
            SqlCommand command3 = new SqlCommand("SELECT tenmon AS 'Ten Mon', soluong AS 'So Luong', gia AS 'Gia' FROM order  WHERE id = @id AND idban = @idban AND idmon = @idmon ", mynh.GetConnection);

            command3.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command3.Parameters.Add("@idban", SqlDbType.Int).Value = idban;
            command3.Parameters.Add("@idmon", SqlDbType.Int).Value = idmon;
            dataGridViewOrder.DataSource = order.GetOrder(command3);*/
        }



        //
        private void buttonThemMon_Click(object sender, EventArgs e)
        {
            /*try
            {*/
            /* SqlCommand command = new SqlCommand("SELECT id AS 'Ma Order', idban AS 'Ma Ban', idmon AS 'Ma Mon', tenmon AS 'Ten Mon'," +
                 " soluong AS 'So Luong', gia AS 'Gia' FROM order");*/
            SqlCommand command = new SqlCommand("SELECT * FROM order");
            /*
                            int id = Convert.ToInt32(textBoxIdOrder.Text);
                            int idmon = Convert.ToInt32(textBoxIdMon.Text);
                            int idban = Convert.ToInt32(textBoxBanAn.Text);
                            SqlCommand command3 = new SqlCommand("SELECT tenmon AS 'Ten Mon', soluong AS 'So Luong', gia AS 'Gia' FROM order  WHERE id = @id AND idban = @idban AND idmon = @idmon ", mynh.GetConnection);

                            command3.Parameters.Add("@id", SqlDbType.Int).Value = id;
                            command3.Parameters.Add("@idban", SqlDbType.Int).Value = idban;
                            command3.Parameters.Add("@idmon", SqlDbType.Int).Value = idmon;*/
            dataGridViewOrder.DataSource = order.GetOrder(command);
          /*  }
            catch
            {
                MessageBox.Show("Báo lỗi!!!", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
        }


        //
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
