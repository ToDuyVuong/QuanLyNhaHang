using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang
{
  public  class MONAN
    {
        MY_NH mynh = new MY_NH();
        public bool InsertMonAn(int id, string MonAn, int SoLuong, int Gia, string Loai)
        {
            while (TaoID(id))
            {
                id++;
            }
            SqlCommand command = new SqlCommand("insert into monan (id,tenmon,soluong,gia,loaithucan)"
            + " values (@id,@tenmon,@soluong,@gia,@loai)", mynh.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@tenmon", SqlDbType.Char).Value = MonAn;
            command.Parameters.Add("@soluong", SqlDbType.Int).Value = SoLuong;
            command.Parameters.Add("@gia", SqlDbType.Int).Value = Gia;
            command.Parameters.Add("@loai", SqlDbType.Char).Value = Loai;
            mynh.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mynh.closeConnection();
                return true;
            }
            else
            {
                mynh.closeConnection();
                return false;
            }

        }
        bool TaoID(int x)
        {
            SqlCommand command = new SqlCommand("select * from monan where id = @id", mynh.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            command.Parameters.Add("@id", SqlDbType.Int).Value = x;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool UpdateMonAn(string MonAn, int SoLuong, int Gia)
        {
            SqlCommand command = new SqlCommand("update monan set soluong = @soluong, gia = @gia where tenmon = @monan", mynh.GetConnection);
            command.Parameters.Add("@soluong", SqlDbType.Int).Value = SoLuong;
            command.Parameters.Add("@gia", SqlDbType.Int).Value = Gia;
            command.Parameters.Add("@monan", SqlDbType.Char).Value = MonAn;
            mynh.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                mynh.closeConnection();
                return true;
            }
            else
            {
                mynh.closeConnection();
                return false;
            }
        }
        String ExecCount(String query)
        {
            SqlCommand command = new SqlCommand(query, mynh.GetConnection);
            mynh.openConnection();
            string count = command.ExecuteScalar().ToString();
            mynh.closeConnection();
            return count;
        }
        public string Total()
        {
            return ExecCount("select count (*) from monan");
        }
        public string TotalNuoc()
        {
            return ExecCount("select count (*) from monan where loaithucan = 'Nuoc Uong' ");
        }
        public string TotalThucAn()
        {
            return ExecCount("select count (*) from monan where loaithucan =  'Thuc An'");
        }
        public DataTable GetMonAn(SqlCommand command)
        {
            command.Connection = mynh.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
