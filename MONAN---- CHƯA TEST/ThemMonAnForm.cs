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
    public partial class ThemMonAnForm : Form
    {
        public ThemMonAnForm()
        {
            InitializeComponent();
        }

        MONAN MonAn = new MONAN();
        MY_NH mynh = new MY_NH();


        //
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string monan = textboxMonAn.Text;
            int gia = Convert.ToInt32(textboxGia.Text);
            int soluong = Convert.ToInt32(textboxSoLuong.Text);
            int id = 0;
            string loai = "Thuc An";
            if (radioButtonNuocUong.Checked)
            {
                loai = "Nuoc Uong";
            }
            if (MonAn.InsertMonAn(id, monan, soluong, gia, loai))
            {
                MessageBox.Show("Add Success with id = " + id, "Mon An", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Add Fail", "Mon An", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //
        private void textboxLoai_VisibleChanged(object sender, EventArgs e)
        {
            string loai = "Thuc An";
            if (radioButtonNuocUong.Checked)
            {
                loai = "Nuoc Uong";
            }
            SqlCommand command = new SqlCommand("select * from monan where tenmon = @tenmon", mynh.GetConnection);
            command.Parameters.Add("@tenmon", SqlDbType.Char).Value = loai;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                labelstatus.Text = "Đã có món ăn này, vui lòng qua form chỉnh sửa";
                buttonAdd.Enabled = false;
            }
            else if (string.IsNullOrEmpty(textboxMonAn.Text))
            {
                labelstatus.Text = "vui lòng không để trống";
                buttonAdd.Enabled = false;
            }
            else
            {
                labelstatus.Text = "";
                buttonAdd.Enabled = true;
            }
        }



        //
        private void radioButtonThucAn_VisibleChanged(object sender, EventArgs e)
        {
            string loai = "Thuc An";
            if (radioButtonNuocUong.Checked)
            {
                loai = "Nuoc Uong";
            }
            SqlCommand command = new SqlCommand("select * from monan where tenmon = @tenmon", mynh.GetConnection);
            command.Parameters.Add("@tenmon", SqlDbType.Char).Value = loai;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                labelstatus.Text = "Đã có món ăn này, vui lòng qua form chỉnh sửa";
                buttonAdd.Enabled = true;
            }
            else if (string.IsNullOrEmpty(textboxMonAn.Text))
            {
                labelstatus.Text = "Vui lòng không để trống";
                buttonAdd.Enabled = true;
            }
            else
            {
                labelstatus.Text = "";
                buttonAdd.Enabled = true;
            }
        }


        //
        private void radioButtonNuocUong_VisibleChanged(object sender, EventArgs e)
        {

            string loai = "Thuc An";
            if (radioButtonNuocUong.Checked)
            {
                loai = "Nuoc Uong";
            }
            SqlCommand command = new SqlCommand("select * from monan where tenmon = @tenmon", mynh.GetConnection);
            command.Parameters.Add("@tenmon", SqlDbType.Char).Value = loai;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                labelstatus.Text = "Đã có món ăn này, vui lòng qua form chỉnh sửa";
                buttonAdd.Enabled = true;
            }
            else if (string.IsNullOrEmpty(textboxMonAn.Text))
            {
                labelstatus.Text = "Vui lòng không để trống";
                buttonAdd.Enabled = true;
            }
            else
            {
                labelstatus.Text = "";
                buttonAdd.Enabled = true;
            }
        }


        //
        private void ThemMonAnForm_Load(object sender, EventArgs e)
        {
            radioButtonThucAn.Checked = true;
        }

       
    }
}
