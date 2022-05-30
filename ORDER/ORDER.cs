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
    public class ORDER
    {

        MY_NH mynh = new MY_NH();


        //
        public DataTable GetOrder(SqlCommand command)
        {
            command.Connection = mynh.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        // Thêm mới
        public bool InsertOrderMon(int id, int idban, int idmon, string tenmon, int soluong, int gia)
        {
            string trangthai = "cho";
            SqlCommand command = new SqlCommand("INSERT INTO od " +
                "(id, idban, idmon, tenmon, soluong, gia, trangthai) VALUES (@id, @idban, @idmon, @tenmon, @soluong, @gia, @trangthai)", mynh.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@idban", SqlDbType.Int).Value = idban;
            command.Parameters.Add("@idmon", SqlDbType.Int).Value = idmon;
            command.Parameters.Add("@soluong", SqlDbType.Int).Value = soluong;
            command.Parameters.Add("@gia", SqlDbType.Int).Value = gia;
            command.Parameters.Add("@tenmon", SqlDbType.NVarChar).Value = tenmon;
            command.Parameters.Add("@trangthai", SqlDbType.NChar).Value = trangthai;
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
        public bool UpdateOrderMon(int id, int idban, int idmon, int soluong, int gia)
        {
           
            SqlCommand command = new SqlCommand("UPDATE od SET soluong = @soluong, gia = @gia WHERE id = @id AND idban = @idban AND idmon = @idmon", mynh.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@idban", SqlDbType.Int).Value = idban;
            command.Parameters.Add("@idmon", SqlDbType.Int).Value = idmon;
            command.Parameters.Add("@gia", SqlDbType.Int).Value = gia;
            command.Parameters.Add("@soluong", SqlDbType.Int).Value = soluong;
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
        public bool UpdateTrangThaiOrder(int id, int idban, string trangthai)
        {

            if (trangthai == "order" || trangthai == "")
            {
                SqlCommand command = new SqlCommand("UPDATE od SET trangthai = @trangthai WHERE id = @id AND idban = @idban ", mynh.GetConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@idban", SqlDbType.Int).Value = idban;
                command.Parameters.Add("@trangthai", SqlDbType.NVarChar).Value = trangthai;
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
            else
            {
                SqlCommand command = new SqlCommand("UPDATE od SET trangthai = @trangthai WHERE id = @id AND idban = @idban ", mynh.GetConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@idban", SqlDbType.Int).Value = idban;
                command.Parameters.Add("@trangthai", SqlDbType.NVarChar).Value = trangthai;
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
            
        }


        // Xóa món trong Order
        public bool DeleteOrderMon(int id, int idban, int idmon)
        {
            SqlCommand command = new SqlCommand("DELETE FROM od WHERE id = @id AND idban = @idban AND idmon = @idmon ", mynh.GetConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@idban", SqlDbType.Int).Value = idban;
            command.Parameters.Add("@idmon", SqlDbType.Int).Value = idmon;
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


        // Xóa Order của bàn
        public bool DeleteOrdeBan(int id, int idban)
        {
            SqlCommand command = new SqlCommand("DELETE FROM od WHERE idban = @idban AND id = @id", mynh.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@idban", SqlDbType.Int).Value = idban;
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


        // Xóa Order
        public bool DeleteOrder(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM od WHERE id = @id", mynh.GetConnection);
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
        public bool CheckOrderMon(int id, int idban, int idmon)
        {
            SqlCommand command = new SqlCommand("SELECT id FROM od WHERE id = @id AND idban = @idban AND idmon = @idmon ", mynh.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@idban", SqlDbType.Int).Value = idban;
            command.Parameters.Add("@idmon", SqlDbType.Int).Value = idmon;
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



        // Check Id Order
        public bool CheckIdOder(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM od WHERE id = @id ", mynh.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }



        // Hàm đếm số lượng 
        public  string execCount(string query)
        {
            mynh.openConnection();
            SqlCommand command = new SqlCommand(query, mynh.GetConnection);
            string count = command.ExecuteScalar().ToString();
            mynh.closeConnection();
            return count;
        }






    }
}
