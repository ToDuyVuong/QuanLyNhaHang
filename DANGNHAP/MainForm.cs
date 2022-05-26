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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void thêmNhânSựToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangKyForm dangKyForm = new DangKyForm();
            dangKyForm.Show(this);
        }

        private void chỉnhSủaNhânSựToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChinhSuaNhanSuForm chinhSuForm = new ChinhSuaNhanSuForm();      
            chinhSuForm.Show(this); 
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachNhanSuForm danhSachNhanSuForm = new DanhSachNhanSuForm();
            danhSachNhanSuForm.Show(this);
        }

        private void thêmMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemMonAnForm themMonAnForm = new ThemMonAnForm();
            themMonAnForm.Show(this);
        }

        private void chỉnhSửaMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuaMonAnForm suaMonAnForm = new SuaMonAnForm();
            suaMonAnForm.Show(this);
        }

        private void thốngKêMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeMonAnForm thongKeMonAnForm = new ThongKeMonAnForm();
            thongKeMonAnForm.Show(this);
        }

        private void xuấtDanhSáchMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintForm printForm = new PrintForm();
            printForm.Show(this);
        }

        private void danhSáchMónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thêmBànĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemBanAnForm themBanAnForm = new ThemBanAnForm();
            themBanAnForm.Show(this);
        }
    }
}
