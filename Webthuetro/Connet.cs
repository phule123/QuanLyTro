using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace Webthuetro
{
    public class Connet
    {
        public string connect1 = @"Data Source=DESKTOP-I6A1Q3L\PHULE;Initial Catalog=DbTro;Integrated Security=True;";
        public SqlConnection con =new SqlConnection(@"Data Source=DESKTOP-I6A1Q3L\PHULE;Initial Catalog=DbTro;Integrated Security=True;");

        private void openconent()
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
                Console.WriteLine("docduocj");
            }
        }
        private void closeconent()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public Boolean excedata(string cmd)
        {
            openconent();
            Boolean check = false;

            try
            {
                SqlCommand cmds = new SqlCommand(cmd, con);
                cmds.ExecuteNonQuery();
                check = true;
            }
            catch
            {

            }

            closeconent();
            return check;
        }

        public DataTable readdata (string cmd)
        {
            openconent();
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmds = new SqlCommand(cmd, con);
                SqlDataAdapter da = new SqlDataAdapter(cmds);
                da.Fill(dt);
            }
            catch
            {
                dt = null;
            }

            closeconent();
            return dt;
        }
        public SqlConnection getConnection()
        {
            return con;
        }
        public DataTable ReadDataPaged(string sql, int pageNumber, int pageSize)
        {
            using (SqlConnection connection = new SqlConnection(connect1))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill((pageNumber - 1) * pageSize, pageSize, dt);
                        return dt;
                    }
                }
            }
        }
        public int GetRecordCount(string sql)
        {
            using (SqlConnection connection = new SqlConnection(connect1))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    return (int)command.ExecuteScalar();
                }
            }
        }

    }
}