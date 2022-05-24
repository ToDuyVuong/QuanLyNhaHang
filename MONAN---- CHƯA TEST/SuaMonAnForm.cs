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
    public partial class SuaMonAnForm : Form
    {
        public SuaMonAnForm()
        {
            InitializeComponent();
        }

        MONAN monan = new MONAN();


        //
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int SoLuong = Convert.ToInt32(textboxSoLuong.Text);
            int Gia = Convert.ToInt32(textboxGia.Text);
            if (monan.UpdateMonAn(comboxTenMon.Text, SoLuong, Gia))
            {
                MessageBox.Show("Updates success", "updates món ăn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
            }
            else
            {
                MessageBox.Show("Updates Fail", "updates món ăn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //
        public void refresh()
        {
            MONAN monan = new MONAN();
            SqlCommand command = new SqlCommand("select * from monan");
            datagridviewMonAn.ReadOnly = true;
            datagridviewMonAn.DataSource = monan.GetMonAn(command);
            datagridviewMonAn.AllowUserToAddRows = false;
        }

        private void SuaMonAnForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT *  FROM monan");
            fillGrid(command);
        }



        // Nạp dữ liệu
        public void fillGrid(SqlCommand command)
        {
            datagridviewMonAn.RowTemplate.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            datagridviewMonAn.RowTemplate.Height = 80;
            datagridviewMonAn.DataSource = monan.GetMonAn(command);
            datagridviewMonAn.AllowUserToAddRows = false;
        }



        // NÓ LÀ GÌ
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            comboxTenMon.Text = datagridviewMonAn.CurrentRow.Cells[1].Value.ToString();
            textboxSoLuong.Text = datagridviewMonAn.CurrentRow.Cells[2].Value.ToString();
            textboxGia.Text = datagridviewMonAn.CurrentRow.Cells[3].Value.ToString();

        }

        private void datagridviewMonAn_DoubleClick(object sender, EventArgs e)
        {
            comboxTenMon.Text = datagridviewMonAn.CurrentRow.Cells[1].Value.ToString();
            textboxSoLuong.Text = datagridviewMonAn.CurrentRow.Cells[2].Value.ToString();
            textboxGia.Text = datagridviewMonAn.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
