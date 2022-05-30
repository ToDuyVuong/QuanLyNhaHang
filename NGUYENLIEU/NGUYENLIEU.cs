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
        public bool InsertNguyenLieu(int id, string tennguyenlieu, int khoiluong, string donvi)
        {
            SqlCommand command = new SqlCommand("INSERT INTO nguyenlieu " +
                "(id,tennguyenlieu, khoiluong, donvi) VALUES (@id, @tennguyenlieu, @khoiluong,@donvi)", mynh.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@tennguyenlieu", SqlDbType.VarChar).Value = tennguyenlieu;
            command.Parameters.Add("@khoiluong", SqlDbType.Int).Value = khoiluong;
            command.Parameters.Add("@donvi", SqlDbType.VarChar).Value = donvi;
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
        public int DemSoLuong()
        {
            int x;
            SqlCommand command = new SqlCommand("select count(*) from nguyenlieu", mynh.GetConnection);
            mynh.openConnection();
            x = (int)command.ExecuteScalar();
            mynh.closeConnection();
            return x;
        }

        // Chỉnh sửa 
        public bool UpdateNguyenLieu(int id, string tennguyenlieu, int khoiluong, string donvi)
        {
            SqlCommand command = new SqlCommand("UPDATE nguyenlieu SET" +
                " tennguyenlieu = @tennguyenlieu, khoiluong = @khoiluong, donvi = @donvi where id = @id", mynh.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@tennguyenlieu", SqlDbType.VarChar).Value = tennguyenlieu;
            command.Parameters.Add("@khoiluong", SqlDbType.Int).Value = khoiluong;
            command.Parameters.Add("@donvi", SqlDbType.VarChar).Value = donvi;
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
        public bool DeleteNguyenLieu(string tennguyenlieu)
        {
            SqlCommand command = new SqlCommand("DELETE FROM nguyenlieu WHERE tennguyenlieu = @tennguyenlieu", mynh.GetConnection);

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

        public DataTable TimTheoTen(string ten)
        {
            SqlCommand command = new SqlCommand("SELECT tennguyenlieu AS 'Tên Nguyên Liệu',khoiluong AS 'Khối Lượng', donvi AS 'Đơn Vị' FROM " +
                "nguyenlieu where tennguyenlieu = @tennguyenlieu", mynh.GetConnection);
            command.Parameters.Add("@tennguyenlieu", SqlDbType.NVarChar).Value = ten;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }

        public bool Verif(string dulieutrung)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM nguyenlieu WHERE tennguyenlieu = @tennguyenlieu", mynh.GetConnection);
            command.Parameters.Add("@tennguyenlieu", SqlDbType.NChar).Value = dulieutrung;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if ((table.Rows.Count > 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int TaoID()
        {
            int id = 0;
            while (doID(id))
            {
                id++;
            }
            return id;
        }
        public bool doID(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM nguyenlieu WHERE id = @id", mynh.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
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
        String execCount(String query)
        {
            SqlCommand command = new SqlCommand(query, mynh.GetConnection);
            mynh.openConnection();
            string count = command.ExecuteScalar().ToString();
            mynh.closeConnection();
            return count;
        }
        public String totalNguyenLieu()
        {
            return execCount("SELECT COUNT(*) FROM nguyenlieu");
        }
        public String totalNguyenLieuTinhTheoKgGr()
        {
            return execCount("SELECT COUNT(*) FROM nguyenlieu WHERE donvi = 'kg' OR donvi = 'gr'");
        }
        public String totalNguyenLieuTinhTheolml()
        {
            return execCount("SELECT COUNT(*) FROM nguyenlieu WHERE donvi = 'l' OR donvi = 'ml'");
        }
    }
}
