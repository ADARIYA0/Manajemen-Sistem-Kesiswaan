using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemManajemenSekolah
{
    class Nilai
    {
        DBconnect connect = new DBconnect();

        public bool insertNilai(int idSiswa, string namaKelas, int nilai, string desk)
        {
            SqlCommand command = new SqlCommand("INSERT INTO nilai(IdSiswa, NamaKelas, Nilai, Deskripsi) VALUES (@id, @nk, @nilai, @desk)", connect.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = idSiswa;
            command.Parameters.Add("@nk", SqlDbType.VarChar).Value = namaKelas;
            command.Parameters.Add("@nilai", SqlDbType.Int).Value = nilai;
            command.Parameters.Add("@desk", SqlDbType.Text).Value = desk;

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

        public bool cekNilai(int idSiswa, string namaKelas)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM nilai WHERE IdSiswa = @id AND NamaKelas = @nk", connect.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = idSiswa;
            command.Parameters.Add("@nk", SqlDbType.VarChar).Value = namaKelas;

            DataTable tabel = ambilList(command);
            return tabel.Rows.Count > 0;
        }

        public bool updateNilai(int idSiswa, string namaKelas, int nilai, string desk)
        {
            SqlCommand command = new SqlCommand("UPDATE nilai SET Nilai = @nilai, Deskripsi = @desk, NamaKelas = @nk WHERE IdSiswa = @id", connect.getConnection);

            command.Parameters.Add("@nk", SqlDbType.VarChar).Value = namaKelas;
            command.Parameters.Add("@id", SqlDbType.Int).Value = idSiswa;
            command.Parameters.Add("@nilai", SqlDbType.Int).Value = nilai;
            command.Parameters.Add("@desk", SqlDbType.Text).Value = desk;

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

        public bool hapusNilai(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM nilai WHERE IdSiswa = @id", connect.getConnection);
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
