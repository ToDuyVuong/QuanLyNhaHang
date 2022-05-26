using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang
{
    public class NGUYENLIEU
    {

        MY_NH mynh = new MY_NH();



        //
        public DataTable GetNguyenLieu(SqlCommand command)
        {
            command.Connection = mynh.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        // Thêm mới
        public bool InsertNguyenLieu(int id, string tennguyenlieu, string khoiluong)
        {
            SqlCommand command = new SqlCommand("INSERT INTO nguyenlieu " +
                "(id, tennguyenlieu, khoiluong) VALUES @id, @tennguyenlieu, @khoiluong)", mynh.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@tennguyenlieu", SqlDbType.VarChar).Value = tennguyenlieu;
            command.Parameters.Add("@khoiluong", SqlDbType.VarChar).Value = khoiluong;
            mynh.openConnection();
            if (command.ExecuteNonQuery() == 1)
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


        // Chỉnh sửa 
        public bool UpdateNguyenLieu(int id, string tennguyenlieu, string khoiluong)
        {
            SqlCommand command = new SqlCommand("UPDATE nguyenlieu SET id = @id, " +
                "tennguyenlieu = @tennguyenlieu, khoiluong = @khoiluong WHERE id = @id", mynh.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@tennguyenlieu", SqlDbType.VarChar).Value = tennguyenlieu;
            command.Parameters.Add("@khoiluong", SqlDbType.VarChar).Value = khoiluong;
            mynh.openConnection();
            if (command.ExecuteNonQuery() == 1)
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



        // Xóa 
        public bool DeleteNguyenLieu(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM nguyenlieu WHERE id = @id", mynh.GetConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            mynh.openConnection();
            if (command.ExecuteNonQuery() == 1)
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


        // Hàm đếm số lượng 
        string execCount(string query)
        {
            mynh.openConnection();
            SqlCommand command = new SqlCommand(query, mynh.GetConnection);
            string count = command.ExecuteScalar().ToString();
            mynh.closeConnection();
            return count;
        }



    }
}
