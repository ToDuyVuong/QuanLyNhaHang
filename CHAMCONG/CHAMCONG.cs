using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QuanLyNhaHang
{
     public class CHAMCONG
    {
        MY_NH mynh = new MY_NH();
        DateTime datetime = DateTime.Now;
        public bool DangNhap(string id, string password)
        {
            SqlCommand command = new SqlCommand("SELECT * from nhansu where id = @id and matkhau = @pass", mynh.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@pass", SqlDbType.NChar).Value = password;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string HoVaTen(string id, string password)
        {

            SqlCommand command = new SqlCommand("SELECT hoten FROM nhansu WHERE id = @id and matkhau = @pass", mynh.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@pass", SqlDbType.NChar).Value = password;
            var hoten = command.ToString();

            return hoten;
        }
        public bool CheckIn(int id, DateTime checkin, int gio, int phut, int giay)
        {
            SqlCommand command = new SqlCommand("INSERT INTO chamcong (id,checkin,gio,phut,giay) " +
                "VALUES(@id,@checkin,@gio,@phut,@giay)", mynh.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@checkin", SqlDbType.DateTime).Value = checkin;
            command.Parameters.Add("@gio", SqlDbType.Int).Value = gio;
            command.Parameters.Add("@phut", SqlDbType.Int).Value = phut;
            command.Parameters.Add("@giay", SqlDbType.Int).Value = giay;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckOut(int id, DateTime CheckOut, int gio, int phut, int giay)
        {
            SqlCommand command = new SqlCommand("INSERT INTO chamcong (id,checkout,gio,phut,giay) " +
                "VALUES(@id,@checkout,@gio,@phut,@giay)", mynh.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@checkout", SqlDbType.DateTime).Value = CheckOut;
            command.Parameters.Add("@gio", SqlDbType.Int).Value = gio;
            command.Parameters.Add("@phut", SqlDbType.Int).Value = phut;
            command.Parameters.Add("@giay", SqlDbType.Int).Value = giay;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}