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


        //
        public DataTable GetNhanVien(SqlCommand command)
        {
            command.Connection = mynh.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }



        //
        public bool InsertNhanVien(int id, string hoten, string gioitinh, DateTime ngaysinh,
            string matkhau, string diachi, string sdt, MemoryStream hinh)
        {
            SqlCommand command = new SqlCommand("INSERT INTO nhanvien " +
                "(id_nhanvien, ho_ten, gioi_tinh, ngay_sinh, password, hinh, dia_chi, sdt) VALUES " +
                "(@id, @hoten, @gioitinh, @ngaysinh, @pass, @hinh, @diachi, @sdt)", mynh.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@hoten", SqlDbType.VarChar).Value = hoten;
            command.Parameters.Add("@gioitinh", SqlDbType.VarChar).Value = gioitinh;
            command.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = ngaysinh;
            command.Parameters.Add("@diachi", SqlDbType.VarChar).Value = diachi;
            command.Parameters.Add("@sdt", SqlDbType.VarChar).Value = sdt;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = matkhau;
            command.Parameters.Add("@hinh", SqlDbType.Image).Value = hinh.ToArray();
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


        //
        public bool UpdateNhanVien(int id, string hoten, string gioitinh, DateTime ngaysinh,
            string matkhau, string diachi, string sdt, MemoryStream hinh)
        {
            SqlCommand command = new SqlCommand("UPDATE nhanvien SET ho_ten = @hoten, gioi_tinh = @gioitinh, " +
                "dia_chi = @diachi, sdt =@sdt, hinh =@hinh WHERE id_nhanvien = @id", mynh.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@hoten", SqlDbType.VarChar).Value = hoten;
            command.Parameters.Add("@gioitinh", SqlDbType.VarChar).Value = gioitinh;
            command.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = ngaysinh;
            command.Parameters.Add("@diachi", SqlDbType.VarChar).Value = diachi;
            command.Parameters.Add("@sdt", SqlDbType.VarChar).Value = sdt;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = matkhau;
            command.Parameters.Add("@hinh", SqlDbType.Image).Value = hinh.ToArray();
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
        public bool DeleteNhanVien(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM nhanvien WHERE id_nhanvien= @id", mynh.GetConnection);

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

