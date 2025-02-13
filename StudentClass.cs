using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Student_Management_System
{
    internal class StudentClass
    {
        DBconnect connect = new DBconnect();

        public bool insertStudent(string nama, string telepon, DateTime tanggalLahir, string jenisKelamin, string alamat, byte[] img)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO siswa(NamaMurid, Telepon, TanggalLahir, JenisKelamin, Alamat, FotoMurid) VALUES(@nama, @telepon, @lahir, @jenisKelamin, @alamat, @img)", connect.getconnection);

            command.Parameters.Add("@nama", MySqlDbType.VarChar).Value = nama;
            command.Parameters.Add("@telepon", MySqlDbType.VarChar).Value = telepon;
            command.Parameters.Add("@lahir", MySqlDbType.Date).Value = tanggalLahir;
            command.Parameters.Add("@jenisKelamin", MySqlDbType.VarChar).Value = jenisKelamin;
            command.Parameters.Add("@alamat", MySqlDbType.VarChar).Value = alamat;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

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
            MySqlCommand command = new MySqlCommand("SELECT * FROM siswa", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public string exeCount(string query)
        {
            MySqlCommand command = new MySqlCommand(query, connect.getconnection);
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
            MySqlCommand command = new MySqlCommand(query, connect.getconnection);
            command.Parameters.AddWithValue("@search", "%" + searchdata + "%");

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool updateStudent(int id, string nama, string telepon, DateTime tanggalLahir, string jenisKelamin, string alamat, byte[] img)
        {
            MySqlCommand command = new MySqlCommand("UPDATE siswa SET NamaMurid = @nama, Telepon = @telepon, TanggalLahir = @lahir, JenisKelamin = @jenisKelamin, Alamat = @alamat, FotoMurid = @img WHERE Id = @id", connect.getconnection);

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@nama", MySqlDbType.VarChar).Value = nama;
            command.Parameters.Add("@telepon", MySqlDbType.VarChar).Value = telepon;
            command.Parameters.Add("@lahir", MySqlDbType.Date).Value = tanggalLahir;
            command.Parameters.Add("@jenisKelamin", MySqlDbType.VarChar).Value = jenisKelamin;
            command.Parameters.Add("@alamat", MySqlDbType.VarChar).Value = alamat;
            command.Parameters.Add("@img", MySqlDbType.Blob).Value = img;

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
            MySqlCommand command = new MySqlCommand("DELETE FROM siswa WHERE Id = @id", connect.getconnection);

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

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

        public DataTable getList(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
