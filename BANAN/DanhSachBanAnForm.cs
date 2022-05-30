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
    public partial class DanhSachBanAnForm : Form
    {
        public DanhSachBanAnForm()
        {
            InitializeComponent();
        }

        BANAN banan = new BANAN();
        MONAN monan = new MONAN();
        ORDER order = new ORDER();
        MY_NH mynh = new MY_NH();

        // Thoát
        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }


        //
        private void DanhSachBanAnForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT id AS 'Ban An So', soluongghe AS 'So Luong Ghe Cua Ban', trangthai AS 'Trang Thai'  FROM banan");
            fillGrid(command);


            // Số tiền tạm tính.
            int bantrong = 0;
            int bandangsudung = 0;
            SqlCommand command4 = new SqlCommand("SELECT * FROM banan ");
            DataTable table = new DataTable();
            table = banan.GetBanAn(command4);
            int n = table.Rows.Count;
            for (int i = 0; i < n; i++)
            {
                string trangthai = table.Rows[i]["trangthai"].ToString().Trim();
                if(trangthai == "True")
                {
                    bandangsudung++;
                }
                else
                {
                    bantrong++;
                }                
            }

            // Tính số lượng bàn
            labelTongSoLuongBanAn.Text = ("Tổng Số Bàn Ăn: " + (dataGridViewDanhSachBanAn.Rows.Count));
            labelDangSuDung.Text = ("Tổng Số Bàn Đang Được Sử Dụng: " + bandangsudung);
            labelTongSoLuongBanTrong.Text = ("Tổng Số Bàn Trống:: " + bantrong);

            textBoxTimKiem.Text = "";
        }


        
        // Nạp dữ liệu
        public void fillGrid(SqlCommand command)
        {
            dataGridViewDanhSachBanAn.RowTemplate.ReadOnly = true;
            dataGridViewDanhSachBanAn.RowTemplate.Height = 80;
            dataGridViewDanhSachBanAn.DataSource = banan.GetBanAn(command);
            dataGridViewDanhSachBanAn.AllowUserToAddRows = false;

            // Đếm số lượng Student
            //labelTotalStudents.Text = ("Total Students: " + dataGridView1.Rows.Count);
        }


        // Mở AddOrderForm
        private void dataGridViewDanhSachBanAn_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string trangthai = dataGridViewDanhSachBanAn.CurrentRow.Cells[2].Value.ToString();
                if (trangthai != "True")
                {
                    AddOrderForm addOrderForm = new AddOrderForm();
                    addOrderForm.textBoxBanAn.Text = dataGridViewDanhSachBanAn.CurrentRow.Cells[0].Value.ToString();
                    addOrderForm.Show(this);
                }
                else
                {
                    MessageBox.Show("Bàn này hiện đang được sử dụng!!  Xin hảy chọn bàn khác.", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch
            {
                MessageBox.Show("Báo lỗi!!!", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        // Tải lại
        private void buttonTaiLai_Click(object sender, EventArgs e)
        {
            DanhSachBanAnForm_Load(sender, e);
        }


        // Tìm kiếm theo số lượng chổ ngồi
        private void buttonTim_Click(object sender, EventArgs e)
        {
            try
            {
                int soluongghe = Convert.ToInt32(textBoxTimKiem.Text);
                SqlCommand command4 = new SqlCommand("SELECT * FROM banan WHERE soluongghe = @soluongghe", mynh.GetConnection);
                command4.Parameters.Add("@soluongghe", SqlDbType.Int).Value = soluongghe;
                dataGridViewDanhSachBanAn.DataSource =  banan.GetBanAn(command4);

            }
            catch
            {
                MessageBox.Show("Báo lỗi!!!", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
    }
}
