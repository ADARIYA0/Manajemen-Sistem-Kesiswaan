using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemManajemenSekolah
{
    internal class Siswa
    {
        DBconnect connect = new DBconnect();

        public bool insertSiswa(string nama, string telepon, DateTime tanggalLahir, string jenisKelamin, string alamat, byte[] img)
        {
            SqlCommand command = new SqlCommand("INSERT INTO siswa(NamaSiswa, Telepon, TanggalLahir, JenisKelamin, Alamat, FotoSiswa) VALUES(@nama, @telepon, @lahir, @jenisKelamin, @alamat, @img)", connect.getConnection);

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

        public DataTable ambilList(SqlCommand command)
        {
            command.Connection = connect.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable tabel = new DataTable();
            adapter.Fill(tabel);
            return tabel;
        }

        public string exeCount(string query)
        {
            SqlCommand command = new SqlCommand(query, connect.getConnection);
            connect.openConnect();
            string count = command.ExecuteScalar().ToString();
            connect.closeConnect();
            return count;
        }

        public string totalSiswa()
        {
            return exeCount("SELECT COUNT(*) FROM siswa");
        }

        public string siswaLaki()
        {
            return exeCount("SELECT COUNT(*) FROM siswa WHERE LOWER(JenisKelamin) = 'laki'");
        }

        public string siswaPerempuan()
        {
            return exeCount("SELECT COUNT(*) FROM siswa WHERE LOWER(JenisKelamin) = 'Perempuan'");
        }

        public DataTable cariSiswa(string searchdata)
        {
            string query = ("SELECT * FROM siswa WHERE CONCAT(Id, NamaSiswa, Alamat) LIKE @search");
            SqlCommand command = new SqlCommand(query, connect.getConnection);
            command.Parameters.AddWithValue("@search", "%" + searchdata + "%");

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable tabel = new DataTable();
            adapter.Fill(tabel);
            return tabel;
        }

        public bool updateSiswa(int id, string nama, string telepon, DateTime tanggalLahir, string jenisKelamin, string alamat, byte[] img)
        {
            SqlCommand command = new SqlCommand("UPDATE siswa SET NamaSiswa = @nama, Telepon = @telepon, TanggalLahir = @lahir, JenisKelamin = @jenisKelamin, Alamat = @alamat, FotoSiswa = @img WHERE Id = @id", connect.getConnection);

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

        public bool hapusSiswa(int id)
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
    }
}
