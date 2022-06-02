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
    public partial class ThongKeDoanhThuForm : Form
    {
        public ThongKeDoanhThuForm()
        {
            InitializeComponent();
        }


        // 
        THONGKE thongke = new THONGKE();



        private void ThongKeDoanhThuForm_Load(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT ngaythanhtoan AS 'Ngay', SUM(tongsotien) AS 'Doanh thu' FROM doanhthu  GROUP BY ngaythanhtoan");
            table = thongke.GetThongKe(command);
            dataGridViewDoanhThu.DataSource = table;

            // Số tiền tạm tính.
            int tamtinh = 0;
            int n = table.Rows.Count;
            for (int i = 0; i < n; i++)
            {
                tamtinh += Convert.ToInt32(table.Rows[i]["Doanh thu"].ToString());
            }
            labelTongDoanhThu.Text = ("Tổng Doanh Thu: " + tamtinh + " VND");

            chartDoanhThu.DataSource = table;
            chartDoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Ngay Thang Nam";
            chartDoanhThu.Series["doanhthu"].XValueMember = "Ngay";
            chartDoanhThu.Series["doanhthu"].YValueMembers = "Doanh thu";
        }



        //
        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButtonLocTheoNgay_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
        }

        private void buttonLoc_Click(object sender, EventArgs e)
        {
            if(radioButtonLocTheoNgay.Checked == true)
            {
                string date1 = dateTimePickerNgayBatDau.Value.ToString("yyyy-MM-dd");
                string date2 = dateTimePickerNgayKetThuc.Value.ToString("yyyy-MM-dd");
                SqlCommand command = new SqlCommand("SELECT  ngaythanhtoan AS 'Ngay', SUM(tongsotien) AS 'Doanh thu' FROM doanhthu WHERE ngaythanhtoan   BETWEEN '" + date1 + " ' AND '" + date2 + "'" + " GROUP BY ngaythanhtoan");
                dataGridViewDoanhThu.DataSource = thongke.GetThongKe(command);

                // Số tiền tạm tính.
                int tamtinh = 0;
                DataTable table = new DataTable();
                table = thongke.GetThongKe(command);
                int n = table.Rows.Count;
                for (int i = 0; i < n; i++)
                {
                    tamtinh += Convert.ToInt32(table.Rows[i]["Doanh thu"].ToString());
                }
                labelTongDoanhThu.Text = ("Tổng Doanh Thu: " + tamtinh + " VND");
                labelBieuDoDoanhThu.Text = "Biểu Đồ Doanh Thu Từ :   " + date1 + "  Đến  " + date2;

                chartDoanhThu.DataSource = table;
                chartDoanhThu.ChartAreas["ChartArea1"].AxisX.Title = "Ngay Thang Nam";
                chartDoanhThu.Series["doanhthu"].XValueMember = "Ngay";
                chartDoanhThu.Series["doanhthu"].YValueMembers = "Doanh thu";
            }    
        }
    }
}
