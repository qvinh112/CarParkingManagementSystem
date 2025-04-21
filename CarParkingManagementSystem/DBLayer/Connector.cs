using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkingManagementSystem.DBLayer
{
    public class Connector
    {
        string connStr = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=testDoXe;Integrated Security=True;TrustServerCertificate=True";
        //string connStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=testDoXe;Integrated Security=True";
        SqlConnection conn = null;

        public Connector()
        {
            conn = new SqlConnection(connStr);
        }

        public SqlConnection GetConnection()
        {
            return conn;
        }

        public void OpenConnection()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        public void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
    }
}
