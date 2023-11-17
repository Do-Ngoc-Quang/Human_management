using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Human_management.Modle
{
    public class Class_pgdatabase
    {

        //
        public int getid(string connectionstring, string sql)
        {
            int id = 0;
            DataSet dataset = new DataSet();
            DataTable datatable = new DataTable();
            datatable = null;
            try
            {
                NpgsqlConnection connection = new NpgsqlConnection(connectionstring);
                connection.Open();
                NpgsqlDataAdapter dataadapter = new NpgsqlDataAdapter(sql, connection);
                dataset.Reset();
                dataadapter.Fill(dataset);
                datatable = dataset.Tables[0];
                connection.Close();
            }
            catch
            {
                id = 0;
            }
            if (datatable.Rows.Count == 1)
            {
                id = int.Parse(datatable.Rows[0][0].ToString());
            }
            return id;
        }

        public string getValue(string connectionstring, string sql)
        {
            string value = "";
            DataSet dataset = new DataSet();
            DataTable datatable = new DataTable();
            datatable = null;
            try
            {
                NpgsqlConnection connection = new NpgsqlConnection(connectionstring);
                connection.Open();
                NpgsqlDataAdapter dataadapter = new NpgsqlDataAdapter(sql, connection);
                dataset.Reset();
                dataadapter.Fill(dataset);
                datatable = dataset.Tables[0];
                connection.Close();
            }
            catch
            {
                value = null;
            }
            if (datatable.Rows.Count == 1)
            {
                value = datatable.Rows[0][0].ToString();
            }
            return value;
        }


        public DataTable getDataTable(string connectionString, string sqlCommand)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                DataSet dataset = new DataSet();
                DataTable datatable = new DataTable();
                try
                {
                    // Open the connection
                    connection.Open();

                    NpgsqlDataAdapter dataadapter = new NpgsqlDataAdapter(sqlCommand, connectionString);
                    dataset.Reset();
                    dataadapter.Fill(dataset);
                    datatable = dataset.Tables[0];

                    //Close the connection
                    connection.Close();
                }
                catch (Exception ex)
                {
                    return null;
                }
                return datatable;
            }
        }

        public Boolean Runsql(string connectionString, string sql)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    //Thực thi câu lệnh insert
                    NpgsqlCommand command = new NpgsqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                    connection.Close();

                    return true;

                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        public int ExecuteSqlCommand_Register(string connectionString, string insertQuery, string selectQuery)
        {
            DataSet dataset = new DataSet();
            DataTable datatable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    //Kiểm tra trong database đã có username người dùng nhập vào hay chưa, có thì báo lỗi, còn chưa thì tạo tài khoản mới
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(selectQuery, connection);
                    dataset.Reset();
                    adapter.Fill(dataset);
                    datatable = dataset.Tables[0];

                    if (datatable.Rows.Count == 1)
                    {
                        return -1;
                    }
                    else
                    {
                        //Thực thi câu lệnh insert
                        NpgsqlCommand command = new NpgsqlCommand(insertQuery, connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    
                }
                catch (Exception ex)
                {
                    return 0;
                }
                
                return 1;
            }
        }

        
    }
}
