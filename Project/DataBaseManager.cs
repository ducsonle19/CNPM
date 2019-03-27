using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class DataBaseManager
    {
        private SqlConnection connect;
        private SqlCommand cmd;

        public SqlConnection open()
        {
            connect = new SqlConnection("Data Source=DESKTOP-6O80SO8\\SQLEXPRESS;Initial Catalog=VeSinh;Integrated Security=True");
            connect.Open();

            return connect;
        }

        public void close()
        {
            try
            {
                connect.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        public DataTable executeQuery(String sql)
        {
            cmd = new SqlCommand(sql, connect);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        public DataTable executeQuery(String sql, SqlParameter[] parameters)
        {
            cmd = new SqlCommand(sql, connect);
            cmd.Parameters.AddRange(parameters);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
    }
}