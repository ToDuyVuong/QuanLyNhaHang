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
    public partial class ThongKeMonForm : Form
    {
        public ThongKeMonForm()
        {
            InitializeComponent();
        }

        MY_NH mynh = new MY_NH();
        THONGKE thongke = new THONGKE();
        BANAN banan = new BANAN();
        MONAN monan = new MONAN();
        ORDER order = new ORDER();

        // Thoát
        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        //
        private void ThongKeMonForm_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT tenmon AS 'Ten Mon', ngaythanhtoan AS 'Ngay', SUM(soluong) AS 'So Luong', " +
                "SUM(gia) AS 'Tong Tien' FROM doanhthu INNER JOIN  od ON od.id = doanhthu.id GROUP BY doanhthu.ngaythanhtoan," +
                " od.tenmon ORDER BY 'So Luong' DESC ");
            table = thongke.GetThongKe(command);
            dataGridViewThongKeTheoMon.DataSource = table;

            // Số tiền tạm tính.
            int tamtinh = 0;
            table = thongke.GetThongKe(command);
            int n = table.Rows.Count;
            for (int i = 0; i < n; i++)
            {
                tamtinh += Convert.ToInt32(table.Rows[i]["So Luong"].ToString());
            }
            labelTongSoLuongMon.Text = ("Tổng Số Lượng Mon: " + tamtinh);

            chartThongKeMon.DataSource = table;
            chartThongKeMon.ChartAreas["ChartArea1"].AxisX.Title = "Ten Mon";
            chartThongKeMon.Series["mon"].XValueMember = "Ten Mon";
            chartThongKeMon.Series["mon"].YValueMembers = "So Luong";
            groupBox2.Enabled = false;
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
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT tenmon AS 'Ten Mon', ngaythanhtoan AS 'Ngay', SUM(od.soluong) AS 'So Luong'" +
                    ",  SUM(od.gia) AS 'Tong Tien' FROM doanhthu INNER JOIN od ON od.id = doanhthu.id  WHERE doanhthu.ngaythanhtoan " +
                    "  BETWEEN '" + date1 + " ' AND '" + date2 + "'" + "  GROUP BY doanhthu.ngaythanhtoan, od.tenmon" +
                    " ORDER BY 'So Luong' DESC");
                table = thongke.GetThongKe(command);
                dataGridViewThongKeTheoMon.DataSource = table;

                // Số tiền tạm tính.
                int tamtinh = 0;
                table = thongke.GetThongKe(command);
                int n = table.Rows.Count;
                for (int i = 0; i < n; i++)
                {
                    tamtinh += Convert.ToInt32(table.Rows[i]["So Luong"].ToString());
                }
                labelTongSoLuongMon.Text = ("Tổng Số Lượng Mon: " + tamtinh);
                labelBieuDoDoanhThu.Text = "Biểu Đồ Thống Kê Theo Món Từ :   " + date1 + "  Đến  " + date2; ;

                chartThongKeMon.DataSource = table;
                chartThongKeMon.ChartAreas["ChartArea1"].AxisX.Title = "Ten Mon";
                chartThongKeMon.Series["mon"].XValueMember = "Ten Mon";
                chartThongKeMon.Series["mon"].YValueMembers = "So Luong";/*
                chartThongKeMon.Series["doanhthu"].XValueMember = "Ten Mon";
                chartThongKeMon.Series["doanhthu"].YValueMembers = "Tong Tien";*/
            }    
        }
    }
}
