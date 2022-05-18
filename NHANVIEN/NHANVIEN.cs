using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
//using System.Data.SqlClient.SqlException
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Web.UI.MobileControls;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    class NHANVIEN

    {
        MY_NH mynh = new MY_NH();

/*
        // Thêm Student
        public bool insertStudent(int Id, string fname, string lname, DateTime bdate,
            string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO std (id, fname, lname, bdate, gender," +
                "phone, address, picture) VALUES (@id, @fn, @ln, @bdt, @gdr,@phn, @adrs, @pic)", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }


        public DataTable getStudents(SqlCommand command)
        {
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        // Cập nhật Student
        public bool updateStudent(int Id, string fname, string lname, DateTime bdate,
            string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE std SET fname=@fn, lname= @ln, bdate= @bdt," +
                " gender= @gdr ,phone= @phn, address= @adrs, picture= @pic " +
                "WHERE id= @ID", mydb.GetConnection);
            command.Parameters.Add("@ID", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }


        // Xóa Student
        public bool deleteStudent(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM std WHERE id= @id", mydb.GetConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }


        // Hàm đếm số lượng 
        string execCount(string query)
        {
            mydb.openConnection();
            SqlCommand command = new SqlCommand(query, mydb.GetConnection);
            string count = command.ExecuteScalar().ToString();
            mydb.closeConnection();
            return count;
        }


        // Đếm tổng số students
        public string totalStudent()
        {
            return execCount("SELECT count(*) FROM std");
        }


        // Đếm tổng số Male
        public string totalMaleStudent()
        {
            return execCount("SELECT count(*) FROM std WHERE gender = 'Male'");
        }


        // Đếm tổng số Female
        public string totalFemaleStudent()
        {
            return execCount("SELECT count(*) FROM std WHERE gender = 'Female'");
        }*/
    }
}

