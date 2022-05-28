﻿using System;
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
        public bool InsertOrderMon(int id, int idban, int idmon, int soluong, int gia, string tenmon)
        {
            SqlCommand command = new SqlCommand("INSERT INTO order " +
                "(id, idban, idmon, tenmon, soluong, gia) VALUES (@id, @idban, @idmon, @tenmon, @soluong, @gia)", mynh.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@idban", SqlDbType.Int).Value = idban;
            command.Parameters.Add("@idmon", SqlDbType.Int).Value = idmon;
            command.Parameters.Add("@soluong", SqlDbType.Int).Value = soluong;
            command.Parameters.Add("@gia", SqlDbType.Int).Value = gia;
            command.Parameters.Add("@tenmon", SqlDbType.NVarChar).Value = tenmon;
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
        public bool UpdateOrderMon(int id, int soluong, int idban, int idmon)
        {
            SqlCommand command = new SqlCommand("UPDATE order SET soluong = @soluong WHERE id = @id AND idban = @idban AND idmon = @idmon", mynh.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@idban", SqlDbType.Int).Value = idban;
            command.Parameters.Add("@idmon", SqlDbType.Int).Value = idmon;
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



        // Xóa 
        public bool DeleteOrderMon(int id, int idban, int idmon)
        {
            SqlCommand command = new SqlCommand("DELETE FROM order WHERE id = @id AND idban = @idban AND idmon = @idmon ", mynh.GetConnection);

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


        /*// Check 
        public bool CheckOrderMon(int id)
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
        }*/




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
