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
    public partial class CheBienMonAnForm : Form
    {
        public CheBienMonAnForm()
        {
            InitializeComponent();
        }

        MONAN monan = new MONAN();
        NGUYENLIEU nguyenlieu = new NGUYENLIEU();
        CHEBIENMONAN chebienmonan = new CHEBIENMONAN();
        MY_NH mynh = new MY_NH();

        //
        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }


        //
        private void CheBienMonAnForm_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT id AS 'Ma Mon', tenmon AS 'Ten Mon', soluong AS 'So Luong' FROM monan");
                dataGridViewMonAn.DataSource = monan.GetMonAn(command);

                SqlCommand command2 = new SqlCommand("SELECT tennguyenlieu AS 'Tên Nguyên Liệu', khoiluong AS " +
                    "'Khối Lượng / Thể Tích',donvi AS 'Đơn Vị' FROM nguyenlieu ");
                dataGridViewNguyenLieu.DataSource = nguyenlieu.GetNguyenLieu(command2);

                SqlCommand command3 = new SqlCommand("SELECT id AS 'Mã Chế Biến', tenmon AS 'Tên Món', soluong AS 'Số Lượng Chế Biến'," +
                        " tennguyenlieu AS 'Tên Nguyên Liệu', khoiluong AS 'Khối Lượng / Thể Tích', donvi AS 'Đơn Vị', " +
                        "ngaychebien AS 'Ngày Chế Biến' FROM chebienmonan ");
                dataGridViewCheBienMon.DataSource = chebienmonan.GetCheBienMonAn(command3);
            }
            catch
            {
                MessageBox.Show("Báo lỗi!!!", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        //
        private void dataGridViewMonAn_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                textBoxTenMon.Text = dataGridViewMonAn.CurrentRow.Cells[1].Value.ToString();
                textBoxTenMon.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Báo lỗi!!!", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        //
        private void dataGridViewNguyenLieu_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                textBoxTenNguyenLieu.Text = dataGridViewNguyenLieu.CurrentRow.Cells[0].Value.ToString();
                textBoxDonVi.Text = dataGridViewNguyenLieu.CurrentRow.Cells[2].Value.ToString();

                textBoxDonVi.Enabled = false;
                textBoxTenNguyenLieu.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Báo lỗi!!!", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        //
        private void dataGridViewCheBienMon_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                textBoxIdCheBien.Text = dataGridViewCheBienMon.CurrentRow.Cells[0].Value.ToString();
                textBoxTenMon.Text = dataGridViewCheBienMon.CurrentRow.Cells[1].Value.ToString();
                textBoxSoPhanMuonCheBien.Text = dataGridViewCheBienMon.CurrentRow.Cells[2].Value.ToString();
                textBoxTenNguyenLieu.Text = dataGridViewCheBienMon.CurrentRow.Cells[3].Value.ToString();
                textBoxKhoiLuongTheTich.Text = dataGridViewCheBienMon.CurrentRow.Cells[4].Value.ToString();
                textBoxDonVi.Text = dataGridViewCheBienMon.CurrentRow.Cells[5].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Báo lỗi!!!", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        //
        private void radioButtonKhoiLuong_CheckedChanged(object sender, EventArgs e)
        {
            try
            {               
                SqlCommand command2 = new SqlCommand("SELECT tennguyenlieu AS 'Tên Nguyên Liệu', khoiluong AS " +
                    "'Khối Lượng',donvi AS 'Đơn Vị' FROM nguyenlieu WHERE donvi = 'kg' OR donvi = 'gr' ");
                dataGridViewNguyenLieu.DataSource = nguyenlieu.GetNguyenLieu(command2);
            }
            catch
            {
                MessageBox.Show("Báo lỗi!!!", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        //
        private void radioButtonTheTich_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command2 = new SqlCommand("SELECT tennguyenlieu AS 'Tên Nguyên Liệu', khoiluong AS " +
                    "'Thể Tích',donvi AS 'Đơn Vị' FROM nguyenlieu WHERE donvi = 'l' OR donvi = 'ml' ");
                dataGridViewNguyenLieu.DataSource = nguyenlieu.GetNguyenLieu(command2);
            }
            catch
            {
                MessageBox.Show("Báo lỗi!!!", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        //
        private void radioButtonTatCa_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command2 = new SqlCommand("SELECT tennguyenlieu AS 'Tên Nguyên Liệu', khoiluong AS " +
                    "'Khối Lượng / Thể Tích',donvi AS 'Đơn Vị' FROM nguyenlieu ");
                dataGridViewNguyenLieu.DataSource = nguyenlieu.GetNguyenLieu(command2);
            }
            catch
            {
                MessageBox.Show("Báo lỗi!!!", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        //
        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxIdCheBien.Text);
                string tenmon = textBoxTenMon.Text;
                int soluongmonchebien = Convert.ToInt32(textBoxSoPhanMuonCheBien.Text);
                string tennguyenlieu = textBoxTenNguyenLieu.Text;
                int khoiluongcansudung = Convert.ToInt32(textBoxKhoiLuongTheTich.Text);
                string donvi = textBoxDonVi.Text;

                if (chebienmonan.InsertCheBienMonAn(id, tenmon, soluongmonchebien, tennguyenlieu, khoiluongcansudung, donvi))
                {
                    int soluongnguyenlieusudung = Convert.ToInt32(textBoxKhoiLuongTheTich.Text);
                    int khoiluong = Convert.ToInt32(dataGridViewNguyenLieu.CurrentRow.Cells[1].Value.ToString());
                    int khoiluongconlai = khoiluong - soluongnguyenlieusudung;

                    int soluongmon = Convert.ToInt32(textBoxSoPhanMuonCheBien.Text);
                    int soluong = Convert.ToInt32(dataGridViewMonAn.CurrentRow.Cells[2].Value.ToString());
                    int soluongconlai = soluong + soluongmon;

                    if (khoiluongconlai >= 0)
                    {


                        SqlCommand command2 = new SqlCommand("SELECT id AS 'Mã Chế Biến', tenmon AS 'Tên Món', soluong AS 'Số Lượng Chế Biến'," +
                                " tennguyenlieu AS 'Tên Nguyên Liệu', khoiluong AS 'Khối Lượng / Thể Tích', donvi AS 'Đơn Vị', " +
                                "ngaychebien AS 'Ngày Chế Biến' FROM chebienmonan WHERE id = @id", mynh.GetConnection);
                        command2.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        dataGridViewCheBienMon.DataSource = chebienmonan.GetCheBienMonAn(command2);


                        monan.UpdateSoLuongMonAn(tenmon, soluongconlai);



                        nguyenlieu.UpdateSoLuongNguyenLieu(tennguyenlieu, khoiluongconlai);

                        SqlCommand command = new SqlCommand("SELECT id AS 'Ma Mon', tenmon AS 'Ten Mon', soluong AS 'So Luong' FROM monan");
                        dataGridViewMonAn.DataSource = monan.GetMonAn(command);

                        SqlCommand command21 = new SqlCommand("SELECT tennguyenlieu AS 'Tên Nguyên Liệu', khoiluong AS " +
                            "'Khối Lượng / Thể Tích',donvi AS 'Đơn Vị' FROM nguyenlieu ");
                        dataGridViewNguyenLieu.DataSource = nguyenlieu.GetNguyenLieu(command21);
                        MessageBox.Show("Thêm chế biến thành công.", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                    else
                    {
                        MessageBox.Show("Khối lượng / Thể Tích không đủ", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }



            }
            catch
            {
                MessageBox.Show("Báo lỗi!!!", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        //
        private void buttonTaoMa_Click(object sender, EventArgs e)
        {
            textBoxIdCheBien.Text = chebienmonan.TaoIdCheBienMonAn().ToString();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxIdCheBien.Text);
                string tenmon = textBoxTenMon.Text;
                int soluongmonchebien = Convert.ToInt32(dataGridViewCheBienMon.CurrentRow.Cells[2].Value.ToString());
                string tennguyenlieu = textBoxTenNguyenLieu.Text;
                int khoiluongcansudung = Convert.ToInt32(dataGridViewCheBienMon.CurrentRow.Cells[4].Value.ToString());
                string donvi = textBoxDonVi.Text;

            int sl1 = Convert.ToInt32(textBoxSoPhanMuonCheBien.Text);
            int kl2 = Convert.ToInt32(textBoxKhoiLuongTheTich.Text);

            if (chebienmonan.UpdateCheBienMonAn(id, tenmon, sl1,  tennguyenlieu, kl2, donvi))
                {
                    int soluongnguyenlieusudung = Convert.ToInt32(textBoxKhoiLuongTheTich.Text);
                    int khoiluong = Convert.ToInt32(dataGridViewNguyenLieu.CurrentRow.Cells[1].Value.ToString());
                    int khoiluongconlai = khoiluong - soluongnguyenlieusudung + khoiluongcansudung;

                    int soluongmon = Convert.ToInt32(textBoxSoPhanMuonCheBien.Text);
                    int soluong = Convert.ToInt32(dataGridViewMonAn.CurrentRow.Cells[2].Value.ToString());
                    int soluongconlai = soluong + soluongmon - soluongmonchebien;

                    if (khoiluongconlai >= 0)
                    {


                        SqlCommand command2 = new SqlCommand("SELECT id AS 'Mã Chế Biến', tenmon AS 'Tên Món', soluong AS 'Số Lượng Chế Biến'," +
                                " tennguyenlieu AS 'Tên Nguyên Liệu', khoiluong AS 'Khối Lượng / Thể Tích', donvi AS 'Đơn Vị', " +
                                "ngaychebien AS 'Ngày Chế Biến' FROM chebienmonan WHERE id = @id", mynh.GetConnection);
                        command2.Parameters.Add("@id", SqlDbType.Int).Value = id;
                        dataGridViewCheBienMon.DataSource = chebienmonan.GetCheBienMonAn(command2);


                        monan.UpdateSoLuongMonAn(tenmon, soluongconlai);



                        nguyenlieu.UpdateSoLuongNguyenLieu(tennguyenlieu, khoiluongconlai);

                        SqlCommand command = new SqlCommand("SELECT id AS 'Ma Mon', tenmon AS 'Ten Mon', soluong AS 'So Luong' FROM monan");
                        dataGridViewMonAn.DataSource = monan.GetMonAn(command);

                        SqlCommand command21 = new SqlCommand("SELECT tennguyenlieu AS 'Tên Nguyên Liệu', khoiluong AS " +
                            "'Khối Lượng / Thể Tích',donvi AS 'Đơn Vị' FROM nguyenlieu ");
                        dataGridViewNguyenLieu.DataSource = nguyenlieu.GetNguyenLieu(command21);

                        MessageBox.Show("Chỉnh sửa thành công.", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Question);

                    }
                    else
                    {
                        MessageBox.Show("Khối lượng / Thể Tích không đủ", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }



        }
            catch
            {
                MessageBox.Show("Báo lỗi!!!", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
}
    }
}
