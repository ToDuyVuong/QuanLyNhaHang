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
    }
}
