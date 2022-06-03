using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang
{
   public class CHEBIENMONAN
    {
        MY_NH mynh = new MY_NH();


        public DataTable GetCheBienMonAn(SqlCommand command)
        {
            command.Connection = mynh.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        // Thêm mới
        public bool InsertCheBienMonAn(int id, string tenmon, int soluong, string tennguyenlieu, int khoiluong, string donvi)
        {
            DateTime dt = DateTime.Now;
            String.Format("{0:dd-MM-yyyy}", dt);
            SqlCommand command = new SqlCommand("INSERT INTO chebienmonan " +
                "(id, tenmon, soluong, tennguyenlieu, khoiluong, donvi, ngaychebien) VALUES " +
                "(@id, @tenmon, @soluong, @tennguyenlieu, @khoiluong, @donvi, @ngaychebien)", mynh.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@khoiluong", SqlDbType.Int).Value = khoiluong;
            command.Parameters.Add("@donvi", SqlDbType.NVarChar).Value = donvi;
            command.Parameters.Add("@soluong", SqlDbType.Int).Value = soluong;
            command.Parameters.Add("@tenmon", SqlDbType.NVarChar).Value = tenmon;
            command.Parameters.Add("@tennguyenlieu", SqlDbType.NChar).Value = tennguyenlieu;
            command.Parameters.Add("@ngaychebien", SqlDbType.Date).Value = dt;
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
        public bool UpdateCheBienMonAn(int id, string tenmon, int soluong, string tennguyenlieu, int khoiluong, string donvi)
        {

            SqlCommand command = new SqlCommand("UPDATE chebienmonan SET soluong = @soluong, khoiluong = @khoiluong," +
                " donvi = @donvi WHERE id = @id AND tenmon = @tenmon", mynh.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@khoiluong", SqlDbType.Int).Value = khoiluong;
            command.Parameters.Add("@donvi", SqlDbType.NVarChar).Value = donvi;
            command.Parameters.Add("@tenmon", SqlDbType.NVarChar).Value = tenmon;
            command.Parameters.Add("@soluong", SqlDbType.Int).Value = soluong;
            command.Parameters.Add("@tennguyenlieu", SqlDbType.NChar).Value = tennguyenlieu;
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

        

        // Xóa món trong Order
        public bool DeleteCheBienMonAn(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM chebienmonan WHERE id = @id ", mynh.GetConnection);

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





        // Tạo Id Orde
        public int TaoIdCheBienMonAn()
        {
            int x;

            SqlCommand command4 = new SqlCommand("SELECT id FROM chebienmonan");
            DataTable table = new DataTable();
            table = GetCheBienMonAn(command4);
            int n = table.Rows.Count - 1;
            if (n == -1)
            {
                return 0;
            }
            else
            {
                x = Convert.ToInt32(table.Rows[n]["id"].ToString()) + 1;
                return x;
            }
        }
    }
}
