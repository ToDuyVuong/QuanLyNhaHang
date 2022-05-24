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
    public partial class ThongKeMonAnForm : Form
    {
        public ThongKeMonAnForm()
        {
            InitializeComponent();
        }
        
        MONAN monan = new MONAN();


        //
        private void ThongKeMonAnForm_Load(object sender, EventArgs e)
        {
            
            double total = Convert.ToDouble(monan.Total());
            double nuocuong = Convert.ToDouble(monan.TotalNuoc());
            double thucan = Convert.ToDouble(monan.TotalThucAn());
            double phantramthucan = (thucan * (100 / total));
            double phantramnuocuong = (nuocuong * (100 / total));
            labelTong.Text = ("Total: " + total.ToString());
            chartCot.Series["DoAn"].Points.AddXY("Do An", thucan);
            chartCot.Series["DoAn"].Points.AddXY("Thuc Uong", nuocuong);
            chartTron.Series["Tron"].Points.AddXY("Do An", thucan);
            chartTron.Series["Tron"].Points.AddXY("Thuc Uong", nuocuong);
        }
    }
}
