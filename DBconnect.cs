using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Student_Management_System
{
    internal class DBconnect
    {
        private SqlConnection connection = new SqlConnection("Data Source=localhost\\MSSQLSERVER01;Initial Catalog=siswa-db;Integrated Security=True;Encrypt=False");

        public SqlConnection getConnection
        {
            get { return connection; }
        }

        public void openConnect()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnect()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
