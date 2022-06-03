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
    public partial class DangNhapForm : Form
    {
        public DangNhapForm()
        {
            InitializeComponent();
        }

        NHANSU nhansu = new NHANSU();


        // Load Form thêm tài khỏa
        private void buttonThemTaiKhoan_Click(object sender, EventArgs e)
        {
            /* ThemTaiKhoanForm themTaiKhoan = new ThemTaiKhoanForm();
             themTaiKhoan.Show(this);*/
        }


        // Đăng nhâp
        // Quản lý có toàn quyền
        // Nhân viên chỉ dùng mục đích checkin
        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            MY_NH mynh = new MY_NH();

            try
            {
                if (textBoxTaiKhoan.Text != "" && textBoxMatKhau.Text != "")
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM nhansu WHERE id = @id AND matkhau = @matkhau", mynh.GetConnection);

                    command.Parameters.Add("@id", SqlDbType.VarChar).Value = textBoxTaiKhoan.Text;
                    command.Parameters.Add("@matkhau", SqlDbType.VarChar).Value = textBoxMatKhau.Text;

                    DataTable table = new DataTable();
                    table = nhansu.GetNhanSu(command);

                    if (table.Rows.Count > 0)
                    {
                        string chucvu = table.Rows[0]["chucvu"].ToString().Trim();

                        if (chucvu == "QuanLy") // Dành cho quản lý
                        {


                            MessageBox.Show("Đăng nhập thành công", "Thông báo đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadingForm loading = new LoadingForm();
                            loading.Show(this);

                            MainForm mainForm = new MainForm();
                            mainForm.Show(this);
                        }
                        else   // Dành cho nhân viên
                        {
                            MessageBox.Show("Đăng nhập thành công", "Thông báo đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadingForm loading = new LoadingForm();
                            loading.Show(this);

                            OrderForm orderForm = new OrderForm();
                            orderForm.Show(this);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc Mật khẩu đăng nhập không chính xác", "Thông báo đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }


                }
                else // Yêu cầu nhập đầy đủ thông tin
                {
                    MessageBox.Show("Tài khoản / Mật khẩu  chưa được nhập", "Thông báo đăng nhậpp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Báo lỗi.", "Thông Báo.", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }


        // Đóng chương trình
        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }


        //
        private void textBoxTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                textBoxMatKhau.Focus();
        }


        //
        private void textBoxMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                buttonDangNhap.Focus();
        }


        //
        private void DangNhapForm_Load(object sender, EventArgs e)
        {
            textBoxTaiKhoan.Focus();

        }


        //
        private void radioButtonQuanLy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                buttonDangNhap.Focus();
        }


        //
        private void buttonDangKy_Click(object sender, EventArgs e)
        {
            DangKyForm dangKy = new DangKyForm();
            dangKy.Show(this);
        }



        // Order
        private void radioButtonMucDichOrder_CheckedChanged(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.Show(this);
        }


        // Main Form Nhanh
        private void radioButtonMucDichQuanLy_CheckedChanged(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show(this);
        }


        DateTime date = DateTime.Now;
        CHAMCONG chamcong = new CHAMCONG();
        MY_NH mynh = new MY_NH();


        //
        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime checkin = Convert.ToDateTime(DateTime.Now.ToString());
                int gio = date.Hour;
                int phut = date.Minute;
                int giay = date.Second;
                int id = Convert.ToInt32(textBoxTaiKhoan.Text);
                string hovaten = chamcong.HoVaTen(textBoxTaiKhoan.Text, textBoxMatKhau.Text);
                if (textBoxTaiKhoan.Text == "")
                {
                    textBoxTaiKhoan.Focus();
                }
                else if (textBoxMatKhau.Text == "")
                {
                    textBoxMatKhau.Focus();
                }
                if (chamcong.DangNhap(textBoxTaiKhoan.Text, textBoxMatKhau.Text))
                {
                    if (chamcong.CheckIn(id, checkin, gio, phut, giay))
                    {
                        MessageBox.Show("check in thành công ", "checkin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }


            }
            catch
            {
                MessageBox.Show("Check In Không Thành Công ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        //
        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            try
            {

               

                DateTime checkout = Convert.ToDateTime(DateTime.Now.ToString());
                int gio = date.Hour;
                int phut = date.Minute;
                int giay = date.Second;
                int id = Convert.ToInt32(textBoxTaiKhoan.Text);
                if (textBoxTaiKhoan.Text == "")
                {
                    textBoxTaiKhoan.Focus();
                }
                else if (textBoxMatKhau.Text == "")
                {
                    textBoxMatKhau.Focus();
                }
                else if (chamcong.DangNhap(textBoxTaiKhoan.Text, textBoxMatKhau.Text))
                {
                    if (chamcong.CheckOut(id, checkout, gio, phut, giay))
                    {
                        MessageBox.Show("Check Out Thành Công ", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }


            }
            catch
            {
                MessageBox.Show("Check Out Không Thành Công ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //
        private void buttonKhachOrder_Click(object sender, EventArgs e)
        {
            LoadingForm loading = new LoadingForm();
            loading.Show(this);
            AddOrderForm addOrderForm = new AddOrderForm();
            addOrderForm.Show(this);
        }
    }
}
