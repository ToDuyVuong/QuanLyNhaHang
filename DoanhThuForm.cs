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
    public partial class DoanhThuForm : Form
    {
        public DoanhThuForm()
        {
            InitializeComponent();
        }

        MY_NH mynh = new MY_NH();
        DOANHTHU doanhthu = new DOANHTHU();

        //
        private void DoanhThuForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM doanhthu");
            dataGridViewDoanhThu.DataSource = doanhthu.GetDoanhThu(command);
        }
    }
}
