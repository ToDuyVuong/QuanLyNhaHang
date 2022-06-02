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
    public partial class DangKyForm : Form
    {
        public DangKyForm()
        {
            InitializeComponent();
        }

        NHANSU nhansu = new NHANSU();


        //
        private void DangKyForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM nhansu WHERE chucvu = 'QuanLy'");

            

            DataTable table = new DataTable();
            table = nhansu.GetNhanSu(command);

            if (table.Rows.Count == 2)
            {
                radioButtonQuanLy.Enabled = false;
            }    
        }

        private void buttonThemTaiKhoan_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxTaiKhoan.Text);
            string hoten = textBoxHoTen.Text;
            string gioitinh = "Nam";
            if (radioButtonGioiTinhNu.Checked)
            {
                gioitinh = "Nu";
            }
            string chucvu = "NhanVien";
            if(radioButtonQuanLy.Checked)
            {
                chucvu = "QuanLy";
            }
            DateTime ngaysinh = dateTimePickerNgaySinh.Value;
            string diachi = textBoxDiaChi.Text;
            string sdt = textBoxSDT.Text;
            string matkhau = textBoxMatKhau.Text;
            string xacnhanmatkhau = textBoxXacNhanMatKhau.Text;

            MemoryStream hinh = new MemoryStream();
            int born_year = dateTimePickerNgaySinh.Value.Year;
            int this_year = DateTime.Now.Year;

            // sv tu 10 - 100
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
                            if (nhansu.InsertNhanSu(id, hoten, gioitinh, ngaysinh, matkhau, diachi, sdt, hinh, chucvu))
                                MessageBox.Show("Đăng ký tài khoản quản lý mới thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            else
                                MessageBox.Show("Lỗi!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            pictureBoxPictureHinh.Image.Save(hinh, pictureBoxPictureHinh.Image.RawFormat);
                            if (nhansu.InsertNhanSu(id, hoten, gioitinh, ngaysinh, matkhau, diachi, sdt, hinh, chucvu))
                                MessageBox.Show("Đăng ký tài khoản nhanvien mới thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                || radioButtonGioiTinhNu.Checked == true )
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

        private void buttonTaiHinhLen_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
                pictureBoxPictureHinh.Image = Image.FromFile(opf.FileName);
        }
    }
}
