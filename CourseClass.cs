using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_Management_System;
using System.Data.SqlClient;

namespace StudentManagementSystem
{
    internal class CourseClass
    {
        DBconnect connect = new DBconnect();

        public bool insertCourse(string namaKursus, int jam, string desk)
        {
            SqlCommand command = new SqlCommand("INSERT INTO kursus(NamaKursus, Jam, Deskripsi) VALUES (@nk, @jam, @desk)", connect.getConnection);

            command.Parameters.Add("@nk", SqlDbType.VarChar).Value = namaKursus;
            command.Parameters.Add("@jam", SqlDbType.Int).Value = jam;
            command.Parameters.Add("@desk", SqlDbType.VarChar).Value = desk;

            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            } else
            {
                connect.closeConnect();
                return false;
            }
        }

        public DataTable getCourseList(SqlCommand command)
        {
            command.Connection = connect.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool isCourseExists(string namaKursus)
        {
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM kursus WHERE NamaKursus = @nk", connect.getConnection);
            command.Parameters.Add("@nk", SqlDbType.VarChar).Value = namaKursus;

            connect.openConnect();
            int count = Convert.ToInt32(command.ExecuteScalar());
            connect.closeConnect();

            return count > 0;
        }


        public bool updateKursus(int idKursus, string namaKursus, int jam, string desk)
        {
            SqlCommand command = new SqlCommand("UPDATE kursus SET NamaKursus = @nk, Jam = @jam, Deskripsi = @desk WHERE IdKursus = @id", connect.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = idKursus;
            command.Parameters.Add("@nk", SqlDbType.VarChar).Value = namaKursus;
            command.Parameters.Add("@jam", SqlDbType.Int).Value = jam;
            command.Parameters.Add("@desk", SqlDbType.VarChar).Value = desk;

            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            } else
            {
                connect.closeConnect();
                return false;
            }
        }

        public bool hapusKursus(int idKursus)
        {
            SqlCommand command = new SqlCommand("DELETE FROM kursus WHERE IdKursus = @id", connect.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = idKursus;

            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            } else
            {
                connect.closeConnect();
                return false;
            }
        }

        public DataTable cariKursus(string searchdata)
        {
            string query = ("SELECT * FROM kursus WHERE CONCAT(IdKursus, NamaKursus) LIKE @search");
            SqlCommand command = new SqlCommand(query, connect.getConnection);
            command.Parameters.AddWithValue("@search", "%" + searchdata + "%");

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
