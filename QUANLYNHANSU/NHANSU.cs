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
    class NHANSU
    {
        MY_NH mynh = new MY_NH();



        //
        public DataTable GetNhanSu(SqlCommand command)
        {
            command.Connection = mynh.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        // Thêm mới
        public bool InsertNhanSu(int id, string hoten, string gioitinh, DateTime ngaysinh,
            string matkhau, string diachi, string sdt, MemoryStream hinh, string chucvu)
        {
            SqlCommand command = new SqlCommand("INSERT INTO nhansu " +
                "(id, hoten, gioitinh, ngaysinh, matkhau, hinh, diachi, sdt, chucvu) VALUES " +
                "(@id, @hoten, @gioitinh, @ngaysinh, @matkhau, @hinh, @diachi, @sdt, @chucvu)", mynh.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@hoten", SqlDbType.VarChar).Value = hoten;
            command.Parameters.Add("@gioitinh", SqlDbType.VarChar).Value = gioitinh;
            command.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = ngaysinh;
            command.Parameters.Add("@diachi", SqlDbType.VarChar).Value = diachi;
            command.Parameters.Add("@sdt", SqlDbType.VarChar).Value = sdt;
            command.Parameters.Add("@chucvu", SqlDbType.VarChar).Value = chucvu;
            command.Parameters.Add("@matkhau", SqlDbType.VarChar).Value = matkhau;
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


        // Chỉnh sửa 
        public bool UpdateNhanSu(int id, string hoten, string gioitinh, DateTime ngaysinh,
            string matkhau, string diachi, string sdt, MemoryStream hinh, string chucvu)
        {
            SqlCommand command = new SqlCommand("UPDATE nhansu SET hoten = @hoten, gioitinh = @gioitinh, " +
                "diachi = @diachi, sdt =@sdt, hinh = @hinh, matkhau = @matkhau, chucvu = @chucvu WHERE id = @id", mynh.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@hoten", SqlDbType.VarChar).Value = hoten;
            command.Parameters.Add("@gioitinh", SqlDbType.VarChar).Value = gioitinh;
            command.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = ngaysinh;
            command.Parameters.Add("@diachi", SqlDbType.VarChar).Value = diachi;
            command.Parameters.Add("@sdt", SqlDbType.VarChar).Value = sdt;
            command.Parameters.Add("@matkhau", SqlDbType.VarChar).Value = matkhau;
            command.Parameters.Add("@hinh", SqlDbType.Image).Value = hinh.ToArray();
            command.Parameters.Add("@chucvu", SqlDbType.VarChar).Value = chucvu;
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
        public bool DeleteNhanSu(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM nhansu WHERE id = @id", mynh.GetConnection);

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














        /* //
         public DataTable getUser(SqlCommand command)
         {
             command.Connection = mydb.GetConnection;
             SqlDataAdapter adapter = new SqlDataAdapter(command);
             DataTable table = new DataTable();
             adapter.Fill(table);
             return table;
         }


         //
         public DataTable GetUserById(Int32 userid)
         {
             SqlDataAdapter adapter = new SqlDataAdapter();
             DataTable table = new DataTable();
             SqlCommand command = new SqlCommand("SELECT * FROM hr Id = @uid", mydb.GetConnection);
             command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
             adapter.SelectCommand = command;
             adapter.Fill(table);
             return table;
         }


         //
         public bool insertUser(int id, string fname, string lname, string username, string password, MemoryStream picture)
         {
             SqlCommand command = new SqlCommand("INSERT INTO hr (Id, f_name, l_name, uname, pwd, pig) VALUES " +
                 "(@id, @fn, @ln, @un, @pass, @pic)", mydb.GetConnection);
             command.Parameters.Add("@id", SqlDbType.Int).Value = id;
             command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
             command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
             command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
             command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
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


         // 
         public bool usernameExist(string username, string operation, int userid = 0)
         {
             string query = "";
             if (operation == "register")
             {
                 query = "SELECT * FROM hr WHERE username = @un";
             }
             else
             {
                 if (operation == "edit")
                 {
                     query = "SELECT * FROM hr WHERE username = @un AND id <> @uid";
                 }
             }

             SqlCommand command = new SqlCommand();
             command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
             command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;

             SqlDataAdapter adapter = new SqlDataAdapter();
             DataTable table = new DataTable();

             adapter.SelectCommand = command;
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


         //updeteUser
         public bool updateUser(int userid, string fname, string lname, string username, string password, MemoryStream picture)
         {
             SqlCommand command = new SqlCommand("UPDATE hr SET f_name = @fn, l_name = @ln, uname = @un, pwd =@pass, fig =@pic WHERE " +
                 "id = @uid", mydb.GetConnection);
             command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
             command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
             command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
             command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
             command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
             command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
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
         }*/






    }
}
