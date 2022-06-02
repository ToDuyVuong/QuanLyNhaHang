using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang
{
   public class DOANHTHU
    {
        MY_NH mynh = new MY_NH();

        //
        public DataTable GetDoanhThu(SqlCommand command)
        {
            command.Connection = mynh.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        // Thêm mới
        public bool InsertDoanhThu(int id, int tongsotien, DateTime ngaythanhtoan)
        {
            SqlCommand command = new SqlCommand("INSERT INTO doanhthu " +
                "(id, tongsotien, ngaythanhtoan) VALUES (@id, @tongsotien, @ngaythanhtoan)", mynh.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@tongsotien", SqlDbType.Int).Value = tongsotien;
            command.Parameters.Add("@ngaythanhtoan", SqlDbType.Date).Value = ngaythanhtoan;
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
        public bool UpdateDoanhThu(int id, int tongsotien, DateTime ngaythanhtoan)
        {
            SqlCommand command = new SqlCommand("UPDATE doanhthu SET id = @id, " +
                "tongsotien = @tongsotien, ngaythanhtoan = @ngaythanhtoan WHERE id = @id", mynh.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@tongsotien", SqlDbType.Int).Value = tongsotien;
            command.Parameters.Add("@ngaythanhtoan", SqlDbType.Date).Value = ngaythanhtoan;
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
        public bool DeleteDoanhThu(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM doanhthu WHERE id = @id", mynh.GetConnection);
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



/*
        public DataTable DoanhThu()
        {
            SqlCommand command = new SqlCommand("SELECT SUM(tongsotien) AS 'tongtien', ngaythanhtoan AS 'Ngay Thanh Toan' FROM doanhthu  GROUP BY ngaythanhtoan");
            

            // Số tiền tạm tính.
            int tamtinh = 0;
            System.Data.DataTable table = new System.Data.DataTable();
            table = doanhthu.DoanhThu(command);
            int n = table.Rows.Count;
            for (int i = 0; i < n; i++)
            {
                tamtinh += Convert.ToInt32(table.Rows[i]["Tong So Tien"].ToString());
            }
            labelTongDoanhThu.Text = ("Tổng Doanh Thu:    " + tamtinh + " VND");
        }*/



    }
}
