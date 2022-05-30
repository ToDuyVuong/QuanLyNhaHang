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
    public partial class ThongKeNguyenLieuForm : Form
    {
        public ThongKeNguyenLieuForm()
        {
            InitializeComponent();
        }

        private void ThongKeNguyenLieuForm_Load(object sender, EventArgs e)
        {
            NGUYENLIEU nguyenlieu = new NGUYENLIEU();
            double total = Convert.ToDouble(nguyenlieu.totalNguyenLieu());
            double nguyenlieukho = Convert.ToDouble(nguyenlieu.totalNguyenLieuTinhTheoKgGr());
            double nguyenlieunuoc = Convert.ToDouble(nguyenlieu.totalNguyenLieuTinhTheolml());
            chart1.Series["Nguyên Liệu"].Points.AddXY("Nguyên liệu khô", nguyenlieukho);
            chart1.Series["Nguyên Liệu"].Points.AddXY("Nguyên liệu nước", nguyenlieunuoc);
            chartPie.Series["SeriesChartPie"].Points.AddXY("Nguyên liệu khô", nguyenlieukho);
            chartPie.Series["SeriesChartPie"].Points.AddXY("Nguyên liệu nước ", nguyenlieunuoc);
        }
    }
}
