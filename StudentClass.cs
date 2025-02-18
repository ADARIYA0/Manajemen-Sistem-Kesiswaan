using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Management_System
{
    internal class StudentClass
    {
        DBconnect connect = new DBconnect();

        public bool insertStudent(string nama, string telepon, DateTime tanggalLahir, string jenisKelamin, string alamat, byte[] img)
        {
            SqlCommand command = new SqlCommand("INSERT INTO siswa(NamaMurid, Telepon, TanggalLahir, JenisKelamin, Alamat, FotoMurid) VALUES(@nama, @telepon, @lahir, @jenisKelamin, @alamat, @img)", connect.getConnection);

            command.Parameters.Add("@nama", SqlDbType.VarChar).Value = nama;
            command.Parameters.Add("@telepon", SqlDbType.VarChar).Value = telepon;
            command.Parameters.Add("@lahir", SqlDbType.Date).Value = tanggalLahir;
            command.Parameters.Add("@jenisKelamin", SqlDbType.VarChar).Value = jenisKelamin;
            command.Parameters.Add("@alamat", SqlDbType.VarChar).Value = alamat;
            command.Parameters.Add("@img", SqlDbType.Image).Value = img;

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

        public DataTable getStudentlist()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM siswa", connect.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public string exeCount(string query)
        {
            SqlCommand command = new SqlCommand(query, connect.getConnection);
            connect.openConnect();
            string count = command.ExecuteScalar().ToString();
            connect.closeConnect();
            return count;
        }

        public string jumlahMurid()
        {
            return exeCount("SELECT COUNT(*) FROM siswa");
        }

        public string muridLaki()
        {
            return exeCount("SELECT COUNT(*) FROM siswa WHERE LOWER(JenisKelamin) = 'laki'");
        }

        public string muridPerempuan()
        {
            return exeCount("SELECT COUNT(*) FROM siswa WHERE LOWER(JenisKelamin) = 'Perempuan'");
        }

        public DataTable cariMurid(string searchdata)
        {
            string query = ("SELECT * FROM siswa WHERE CONCAT(Id, NamaMurid, Alamat) LIKE @search");
            SqlCommand command = new SqlCommand(query, connect.getConnection);
            command.Parameters.AddWithValue("@search", "%" + searchdata + "%");

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool updateStudent(int id, string nama, string telepon, DateTime tanggalLahir, string jenisKelamin, string alamat, byte[] img)
        {
            SqlCommand command = new SqlCommand("UPDATE siswa SET NamaMurid = @nama, Telepon = @telepon, TanggalLahir = @lahir, JenisKelamin = @jenisKelamin, Alamat = @alamat, FotoMurid = @img WHERE Id = @id", connect.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@nama", SqlDbType.VarChar).Value = nama;
            command.Parameters.Add("@telepon", SqlDbType.VarChar).Value = telepon;
            command.Parameters.Add("@lahir", SqlDbType.Date).Value = tanggalLahir;
            command.Parameters.Add("@jenisKelamin", SqlDbType.VarChar).Value = jenisKelamin;
            command.Parameters.Add("@alamat", SqlDbType.VarChar).Value = alamat;
            command.Parameters.Add("@img", SqlDbType.Image).Value = img;

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

        public bool deleteStudent(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM siswa WHERE Id = @id", connect.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

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

        public DataTable getList(SqlCommand command)
        {
            command.Connection = connect.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
