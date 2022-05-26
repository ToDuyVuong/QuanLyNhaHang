using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang
{
    public class BANAN
    {
        
        MY_NH mynh = new MY_NH();


        //
        public DataTable GetBanAn(SqlCommand command)
        {
            command.Connection = mynh.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        // Thêm mới
        public bool InsertBanAn(int id, int soluongghe, bool trangthai)
        {
            SqlCommand command = new SqlCommand("INSERT INTO banan " +
                "(id, soluongghe, trangthai) VALUES (@id, @soluongghe, @trangthai)", mynh.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@soluongghe", SqlDbType.Int).Value = soluongghe;
            command.Parameters.Add("@trangthai", SqlDbType.Bit).Value = trangthai;
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
        public bool UpdateBanAn(int id, int soluongghe, bool trangthai)
        {
            SqlCommand command = new SqlCommand("UPDATE banan SET id = @id, " +
                "soluongghe = @soluongghe, trangthai = @trangthai WHERE id = @id", mynh.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@soluongghe", SqlDbType.Int).Value = soluongghe;
            command.Parameters.Add("@trangthai", SqlDbType.Bit).Value = trangthai;
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
        public bool DeleteBanAn(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM banan WHERE id = @id", mynh.GetConnection);

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


        // Check 
        public bool CheckBanAn(int id)
        {
            SqlCommand command = new SqlCommand("SELECT id FROM banan WHERE id = @id", mynh.GetConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            mynh.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mynh.closeConnection();
                return false;
            }
            else
            {
                mynh.closeConnection();
                return true;
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
