using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang
{
   public class PHANCONG
    {
        // 1 = ca 1 ca 2
        // 2 = ca 2 ca 3
        // 3 = ca 3 ca 1

        MY_NH mynh = new MY_NH();
        //
        public DataTable GetPhanCong(SqlCommand command)
        {
            command.Connection = mynh.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool InsertPhanCong(int id, string hoten, int calam, int quanly)
        {
;
            SqlCommand command = new SqlCommand("INSERT INTO phancong " +
                "(id, hoten, calam, quanly) VALUES (@id, @hoten, @calam, @quanly)", mynh.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@hoten", SqlDbType.VarChar).Value = hoten;
            command.Parameters.Add("@calam", SqlDbType.Int).Value = calam;
            command.Parameters.Add("@quanly", SqlDbType.Int).Value = quanly;
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

        public bool InsertPhanCongQuanLy(int id, string hoten, int calam)
        {
            int quanly = 1;
            SqlCommand command = new SqlCommand("INSERT INTO phancong " +
                "(id, hoten, calam, quanly) VALUES (@id, @hoten, @calam, @quanly)", mynh.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@hoten", SqlDbType.VarChar).Value = hoten;
            command.Parameters.Add("@calam", SqlDbType.Int).Value = calam;
            command.Parameters.Add("@quanly", SqlDbType.Int).Value = quanly;
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
        public bool UpdatePhanCong(int id, string hoten, int calam)
        {
            SqlCommand command = new SqlCommand("UPDATE phancong SET" +
                " id = @id, hoten = @hoten, calam = @calam WHERE id = @id", mynh.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@hoten", SqlDbType.VarChar).Value = hoten;
            command.Parameters.Add("@calam", SqlDbType.Int).Value = calam;
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
        public bool DeletePhanCong(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM phancong WHERE id = @id", mynh.GetConnection);

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


        public int CaLamViec()
        {
            Random rd = new Random();
            int t = rd.Next(1, 4);
            return t;
        }


    }
}
/*Chú Thích Mã Ca Làm Đối Với Quản Lý
Mã Ca = 1 => Ca 1 và Ca 2
Mã Ca = 2 => Ca 3 
Mã Ca = 3 => Ca 2 và Ca 3
Mã Ca = 4 => Ca 1 
Mã Ca = 5 => Ca 3 và Ca 1
Mã Ca = 6 => Ca 2 

*/