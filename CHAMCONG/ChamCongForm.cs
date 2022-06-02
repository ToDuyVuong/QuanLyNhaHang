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
    public partial class ChamCongForm : Form
    {
        public ChamCongForm()
        {
            InitializeComponent();
        }
        MY_NH mynh = new MY_NH();

        private void buttonCLose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChamCongForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT chamcong.id AS 'ID Nhân Viên', chamcong.checkin" +
                " AS 'checkin',chamcong.checkout AS 'checkout', chamcong.gio AS 'Giờ',chamcong.phut AS 'Phút'," +
                "nhansu.hoten AS 'Họ Và Tên' FROM chamcong  INNER JOIN nhansu ON chamcong.id = nhansu.id ", mynh.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.ReadOnly = true;
        }
    }
}
