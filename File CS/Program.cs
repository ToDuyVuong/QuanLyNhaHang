using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DangNhapForm dangNhap = new DangNhapForm();


            if (dangNhap.ShowDialog() == DialogResult.OK)
            {
                if (dangNhap.radioButtonMucDichOrder.Checked)
                {
                    // Application.Run(new Progressbar());
                    Application.Run(new OrderForm());
                }
                else
                {
                    Application.Run(new MainForm());
                }
            }
            /*else
            {
                Application.Exit();
            }*/





            /*if (dangNhap.ShowDialog() == DialogResult.OK)
            {
                if (dangNhap.radioButtonQuanLy.Checked == true && dangNhap.radioButtonMucDichQuanLy.Checked == true)
                {
                    // Application.Run(new Progressbar());
                    Application.Run(new MainForm());
                }
                else
                {
                    Application.Run(new OrderForm());
                }    
            }
            *//*else
            {
                Application.Exit();
            }*/








            // Application.Run(new DangNhapForm());
        }
    }
}
