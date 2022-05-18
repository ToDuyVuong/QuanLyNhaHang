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



        // Load Form thêm tài khỏa
        private void buttonThemTaiKhoan_Click(object sender, EventArgs e)
        {
            ThemTaiKhoanForm themTaiKhoan = new ThemTaiKhoanForm();
            themTaiKhoan.Show(this);
        }



        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            MY_NH mynh = new MY_NH();

            if(textBoxTaiKhoan.Text != "" && textBoxMatKhau.Text != "" &&
                (radioButtonQuanLy.Checked != true || radioButtonNhanVien.Checked != true))
            {
                SqlDataAdapter ad = new SqlDataAdapter();
                DataTable dt = new DataTable();
                if (radioButtonQuanLy.Checked != true)
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM quanly WHERE id_quanly = @id AND password =@password", mynh.GetConnection);

                    command.Parameters.Add("@id", SqlDbType.VarChar).Value = textBoxTaiKhoan.Text;
                    command.Parameters.Add("@password", SqlDbType.VarChar).Value = textBoxMatKhau.Text;

                    ad.SelectCommand = command;

                    ad.Fill(dt);

                    if ((dt.Rows.Count > 0))
                    {
                        int userid = Convert.ToInt32(dt.Rows[0][0].ToString());
                        // Globals.SetGlobalUserId(userid);
                        MessageBox.Show("Đăng nhập thành công", "Thông báo đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc Mật khẩu đăng nhập không chính xác", "Thông báo đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM nhanvien WHERE id_nhanvien = @id AND password =@password", mynh.GetConnection);

                    command.Parameters.Add("@id", SqlDbType.VarChar).Value = textBoxTaiKhoan.Text;
                    command.Parameters.Add("@password", SqlDbType.VarChar).Value = textBoxMatKhau.Text;

                    ad.SelectCommand = command;

                    ad.Fill(dt);

                    if ((dt.Rows.Count > 0))
                    {
                        int userid = Convert.ToInt32(dt.Rows[0][0].ToString());
                        // Globals.SetGlobalUserId(userid);
                        MessageBox.Show("Đăng nhập thành công", "Thông báo đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc Mật khẩu đăng nhập không chính xác", "Thông báo đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Tài khoản / Mật khẩu / Chức vụ / Ca làm việc chưa được nhập", "Thông báo đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           



            /* MY_DB db = new MY_DB();

             SqlDataAdapter ad = new SqlDataAdapter();

             DataTable dt = new DataTable();

             SqlCommand command = new SqlCommand("SELECT * FROM Login WHERE username = @user AND password =@password", db.GetConnection);

             command.Parameters.Add("@user", SqlDbType.VarChar).Value = textUser.Text;
             command.Parameters.Add("@password", SqlDbType.VarChar).Value = textPass.Text;

             ad.SelectCommand = command;

             ad.Fill(dt);

             if ((dt.Rows.Count > 0))
             {
                 MessageBox.Show("Đăng nhập thành công", "Thông báo đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 this.DialogResult = DialogResult.OK;                
             }
             else
             {
                 MessageBox.Show("Tài khoản hoặc Mật khẩu đăng nhập không chính xác", "Thông báo đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }*/
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
                radioButtonQuanLy.Focus();
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
    }
}
