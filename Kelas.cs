using System;
using System.Data;
using System.Data.SqlClient;

namespace SistemManajemenSekolah
{
    internal class Kelas
    {
        DBconnect connect = new DBconnect();

        public bool insertKelas(string namaKelas, int jam, string desk)
        {
            SqlCommand command = new SqlCommand("INSERT INTO kelas(NamaKelas, Jam, Deskripsi) VALUES (@nk, @jam, @desk)", connect.getConnection);

            command.Parameters.Add("@nk", SqlDbType.VarChar).Value = namaKelas;
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

        public DataTable ambilDaftarKelas(SqlCommand command)
        {
            command.Connection = connect.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable tabel = new DataTable();
            adapter.Fill(tabel);
            return tabel;
        }

        public bool cekKelas(string namaKelas)
        {
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM kelas WHERE NamaKelas = @nk", connect.getConnection);
            command.Parameters.Add("@nk", SqlDbType.VarChar).Value = namaKelas;

            connect.openConnect();
            int count = Convert.ToInt32(command.ExecuteScalar());
            connect.closeConnect();

            return count > 0;
        }


        public bool updateKelas(int id, string namaKelas, int jam, string desk)
        {
            SqlCommand command = new SqlCommand("UPDATE kelas SET NamaKelas = @nk, Jam = @jam, Deskripsi = @desk WHERE Id = @id", connect.getConnection);

            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@nk", SqlDbType.VarChar).Value = namaKelas;
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

        public bool hapusKelas(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM kelas WHERE Id = @id", connect.getConnection);
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

        public DataTable cariKelas(string searchdata)
        {
            string query = ("SELECT * FROM kelas WHERE CONCAT(Id, NamaKelas) LIKE @search");
            SqlCommand command = new SqlCommand(query, connect.getConnection);
            command.Parameters.AddWithValue("@search", "%" + searchdata + "%");

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable tabel = new DataTable();
            adapter.Fill(tabel);
            return tabel;
        }
    }
}
