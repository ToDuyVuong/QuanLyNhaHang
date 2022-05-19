using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class ChinhSuaNhanSuForm : Form
    {
        public ChinhSuaNhanSuForm()
        {
            InitializeComponent();
        }


        NHANSU nhansu = new NHANSU();


        //
        private void ChinhSuaNhanSuForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM nhansu");
            fillGrid(command);
        }


        //
        private void buttonTimKiem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxTaiKhoan.Text);

            SqlCommand command = new SqlCommand("SELECT * FROM nhansu WHERE  id =" + id);
            fillGrid(command);
        }
            


        //
        // Nạp dữ liệu
        public void fillGrid(SqlCommand command)
        {
            dataGridViewChinhSuaNhanSu.RowTemplate.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridViewChinhSuaNhanSu.RowTemplate.Height = 80;
            dataGridViewChinhSuaNhanSu.DataSource = nhansu.GetNhanSu(command);                        
            picCol = (DataGridViewImageColumn)dataGridViewChinhSuaNhanSu.Columns[5];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewChinhSuaNhanSu.AllowUserToAddRows = false;

            // Đếm số lượng Student
            //labelTotalStudents.Text = ("Total Students: " + dataGridView1.Rows.Count);
        }



        // Tỉa hình lên
        private void buttonTaiHinhLen_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
                pictureBoxPictureHinh.Image = Image.FromFile(opf.FileName);
        }


        // Chỉnh sửa tài khoản
        private void buttonChinhSuaTaiKhoan_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxTaiKhoan.Text);
            string hoten = textBoxHoTen.Text;
            string gioitinh = "Nam";
            if (radioButtonGioiTinhNu.Checked)
            {
                gioitinh = "Nu";
            }
            string chucvu = "QuanLy";
            if(radioButtonNhanVien.Checked)
            {
                chucvu = "NhanVien";
            }
            DateTime ngaysinh = dateTimePickerNgaySinh.Value;
            string diachi = textBoxDiaChi.Text;
            string sdt = textBoxSDT.Text;
            string matkhau = textBoxMatKhau.Text;
            string xacnhanmatkhau = textBoxXacNhanMatKhau.Text;
            MemoryStream hinh = new MemoryStream();
            int born_year = dateTimePickerNgaySinh.Value.Year;
            int this_year = DateTime.Now.Year;

            // Kiểm tra tuổi có nằm trong độ tuổi lao động hay không
            if (((this_year - born_year) < 18) || ((this_year - born_year) > 60))
            {
                MessageBox.Show("Độ tuổi lao đông từ 18 tới 60 tuổi", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (CheckDongTrong())
                {
                    MessageBox.Show("Thông tin chưa được điều đầy đủ.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    if (matkhau == xacnhanmatkhau)
                    {
                        if (radioButtonQuanLy.Checked == true)
                        {
                            pictureBoxPictureHinh.Image.Save(hinh, pictureBoxPictureHinh.Image.RawFormat);
                            if (nhansu.UpdateNhanSu(id, hoten, gioitinh, ngaysinh, matkhau, diachi, sdt, hinh, chucvu))
                                MessageBox.Show("Chỉnh sửa thông tin quản lý thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("Lỗi!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            pictureBoxPictureHinh.Image.Save(hinh, pictureBoxPictureHinh.Image.RawFormat);
                            if (nhansu.UpdateNhanSu(id, hoten, gioitinh, ngaysinh, matkhau, diachi, sdt, hinh, chucvu))
                                MessageBox.Show("Chỉnh sửa thông tin nhân viên thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("Lỗi!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu xác nhận không trùng khớp!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }

            // Tải lại
            SqlCommand command = new SqlCommand("SELECT * FROM nhansu");
            fillGrid(command);
        }



        // chuc nang kiem tra du lieu input
        bool CheckDongTrong()
        {
            if ((textBoxTaiKhoan.Text.Trim() == "")
                || (textBoxMatKhau.Text.Trim() == "")
                || (textBoxHoTen.Text.Trim() == "")
                || (textBoxDiaChi.Text.Trim() == "")
                || (textBoxSDT.Text.Trim() == "")
                || (textBoxXacNhanMatKhau.Text.Trim() == "")
                || (pictureBoxPictureHinh.Image == null)
                || (radioButtonGioiTinhNam.Checked == true
                || radioButtonGioiTinhNu.Checked == true)
                || (radioButtonQuanLy.Checked == true
                || radioButtonNhanVien.Checked == true))
                return false;
            else
                return true;
        }


        // Đóng Form
        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }


        //
        private void radioButtonChucVuNhanVien_CheckedChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM nhansu WHERE chucvu = 'NhanVien'");
            fillGrid(command);
            LamTrong(1);
           
        }


        //
        private void radioButtonChucVuQuanLy_CheckedChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM nhansu WHERE chucvu = 'QuanLy'");
            fillGrid(command);
            LamTrong(2);
        }


        //
        private void dataGridViewChinhSuaNhanSu_DoubleClick(object sender, EventArgs e)
        {
            textBoxTaiKhoan.Text = dataGridViewChinhSuaNhanSu.CurrentRow.Cells[0].Value.ToString();
            textBoxHoTen.Text = dataGridViewChinhSuaNhanSu.CurrentRow.Cells[1].Value.ToString();
            textBoxMatKhau.Text = dataGridViewChinhSuaNhanSu.CurrentRow.Cells[4].Value.ToString();
            dateTimePickerNgaySinh.Value = (DateTime)dataGridViewChinhSuaNhanSu.CurrentRow.Cells[3].Value;
            // Sử lý phần giới tính
            if ((dataGridViewChinhSuaNhanSu.CurrentRow.Cells[2].Value.ToString() == "Nam"))
                radioButtonGioiTinhNam.Checked = true;
            else
                radioButtonGioiTinhNu.Checked = true;

            textBoxSDT.Text = dataGridViewChinhSuaNhanSu.CurrentRow.Cells[7].Value.ToString();
            textBoxDiaChi.Text = dataGridViewChinhSuaNhanSu.CurrentRow.Cells[6].Value.ToString();

            // Sử lý ảnh
            byte[] pic;
            pic = (byte[])dataGridViewChinhSuaNhanSu.CurrentRow.Cells[5].Value;
            MemoryStream pictrure = new MemoryStream(pic);
            pictureBoxPictureHinh.Image = Image.FromStream(pictrure);
            if (dataGridViewChinhSuaNhanSu.CurrentRow.Cells[8].Value.ToString() == "NhanVien")
            {
                radioButtonNhanVien.Checked = true;
            }
            else
            {
                radioButtonQuanLy.Checked = true;
            }
        }


        //
        private void textBoxTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                buttonTimKiem.Focus();
            }
        }


        //
        private void dataGridViewChinhSuaNhanSu_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxTaiKhoan.Text = dataGridViewChinhSuaNhanSu.CurrentRow.Cells[0].Value.ToString();
            textBoxHoTen.Text = dataGridViewChinhSuaNhanSu.CurrentRow.Cells[1].Value.ToString();
            textBoxMatKhau.Text = dataGridViewChinhSuaNhanSu.CurrentRow.Cells[4].Value.ToString();
            dateTimePickerNgaySinh.Value = (DateTime)dataGridViewChinhSuaNhanSu.CurrentRow.Cells[3].Value;
            // Sử lý phần giới tính
            if ((dataGridViewChinhSuaNhanSu.CurrentRow.Cells[2].Value.ToString() == "Nam"))
                radioButtonGioiTinhNam.Checked = true;
            else
                radioButtonGioiTinhNu.Checked = true;

            textBoxSDT.Text = dataGridViewChinhSuaNhanSu.CurrentRow.Cells[7].Value.ToString();
            textBoxDiaChi.Text = dataGridViewChinhSuaNhanSu.CurrentRow.Cells[6].Value.ToString();

            // Sử lý ảnh
            byte[] pic;
            pic = (byte[])dataGridViewChinhSuaNhanSu.CurrentRow.Cells[5].Value;
            MemoryStream pictrure = new MemoryStream(pic);
            pictureBoxPictureHinh.Image = Image.FromStream(pictrure);
            if(dataGridViewChinhSuaNhanSu.CurrentRow.Cells[8].Value.ToString() == "NhanVien")
            {
                radioButtonNhanVien.Checked = true;
            }
            else
            {
                radioButtonQuanLy.Checked = true;
            }
        }


        // Tải lại dữ liệu
        private void buttonTaiLai_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM nhansu");
            fillGrid(command);
            LamTrong(0);
        }


        //
        private void buttonXoa_Click(object sender, EventArgs e)
        {
            // Xóa nhân sự
            try
            {
                int id = Convert.ToInt32(textBoxTaiKhoan.Text);                
                
                if ((MessageBox.Show("Bạn có chắc chắn muốn xóa nhân sự này chứ!!", "Xóa Nhân Sự",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (nhansu.DeleteNhanSu(id))
                    {
                        MessageBox.Show("Đã xóa thành công.", "Xóa Nhân Sự", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        textBoxTaiKhoan.Text = "";
                        textBoxMatKhau.Text = "";
                        textBoxXacNhanMatKhau.Text = "";
                        textBoxHoTen.Text = "";
                        radioButtonNhanVien.Checked = false;
                        radioButtonQuanLy.Checked = false;
                        textBoxDiaChi.Text = "";
                        textBoxSDT.Text = "";
                        dateTimePickerNgaySinh.Value = DateTime.Now;
                        pictureBoxPictureHinh.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công!!!", "Xóa Nhân Sự", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("ID không tồn tại.", "Xóa Nhân Sự",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
         
        
        //
        public void LamTrong(int n)
        {
            textBoxTaiKhoan.Text = "";
            textBoxMatKhau.Text = "";
            textBoxXacNhanMatKhau.Text = "";
            textBoxHoTen.Text = "";
            radioButtonNhanVien.Checked = false;
            radioButtonQuanLy.Checked = false;
            textBoxDiaChi.Text = "";
            textBoxSDT.Text = "";
            dateTimePickerNgaySinh.Value = DateTime.Now;
            pictureBoxPictureHinh.Image = null;
            if (n == 0)
            {
                radioButtonChucVuNhanVien.Checked = false;
                radioButtonChucVuQuanLy.Checked = false;
            }
        }
    }
}
