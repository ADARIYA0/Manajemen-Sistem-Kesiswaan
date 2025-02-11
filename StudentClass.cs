using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Student_Management_System
{
    internal class StudentClass
    {
        DBconnect connect = new DBconnect();

        public bool insertStudent(string nama, string telepon, DateTime tanggalLahir, string jenisKelamin, string alamat, byte[] img)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `siswa`(`StdNama`, `Telepon`, `TanggalLahir`, `JenisKelamin`, `Alamat`, `StdProfil`) VALUES(@nama, @telepon, @lahir, @jenisKelamin, @alamat, @img)", connect.getconnection);

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

        public DataTable getStudentlist(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
