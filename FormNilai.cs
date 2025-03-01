using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemManajemenSekolah
{
    public partial class FormNilai : Form
    {
        Siswa siswa = new Siswa();
        Kelas kelas = new Kelas();
        Nilai nilai = new Nilai();

        public FormNilai()
        {
            InitializeComponent();
        }

        private void tampilkanNilai()
        {
            DataGridView_nilaiSiswa.DataSource = nilai.ambilList(new SqlCommand("SELECT nilai.IdSiswa, siswa.NamaSiswa, nilai.NamaKelas, nilai.Nilai, nilai.Deskripsi FROM siswa INNER JOIN nilai ON nilai.IdSiswa=siswa.Id"));
        }

        private void ScoreForm_Load(object sender, EventArgs e)
        {
            comboBox_kelas.DataSource = kelas.ambilDaftarKelas(new SqlCommand("SELECT * FROM kelas"));
            comboBox_kelas.DisplayMember = "NamaKelas";
            comboBox_kelas.ValueMember = "NamaKelas";

            DataGridView_nilaiSiswa.ReadOnly = true;
            DataGridView_nilaiSiswa.DataSource = siswa.ambilList(new SqlCommand("SELECT Id, NamaSiswa FROM siswa"));
        }

        private void button_tambah_Click(object sender, EventArgs e)
        {
            if (textBox_idSiswa.Text == "" || textBox_nilai.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Data Kosong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                try
                {
                    int idSiswa = Convert.ToInt32(textBox_idSiswa.Text);
                    string namaKelas = comboBox_kelas.Text;
                    int nilaiSiswa = Convert.ToInt32(textBox_nilai.Text);
                    string desk = textBox_deskripsi.Text;

                    if (!nilai.cekNilai(idSiswa, namaKelas))
                    {
                        if (nilai.insertNilai(idSiswa, namaKelas, nilaiSiswa, desk))
                        {
                            tampilkanNilai();
                            button_bersihkan.PerformClick();
                            MessageBox.Show("Nilai baru ditambahkan", "Nilai Baru", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        } else
                        {
                            MessageBox.Show("Nilai belum dimasukkan", "Nilai Tidak Dimasukkan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } else
                    {
                        MessageBox.Show("Nilai untuk kelas ini sudah ada", "Nilai Sudah Ada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } catch (FormatException)
                {
                    MessageBox.Show("Nilai harus berupa angka!", "Kesalahan Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_nilai.Clear();
                    textBox_nilai.Focus();
                }
            }
        }

        private void button_bersihkan_Click(object sender, EventArgs e)
        {
            textBox_idSiswa.Clear();
            textBox_nilai.Clear();
            comboBox_kelas.SelectedIndex = 0;
            textBox_deskripsi.Clear();
        }

        private void DataGridView_nilaiSiswa_Click(object sender, EventArgs e)
        {
            textBox_idSiswa.Text = DataGridView_nilaiSiswa.CurrentRow.Cells[0].Value.ToString();
        }

        private void button_tSiswa_Click(object sender, EventArgs e)
        {
            DataGridView_nilaiSiswa.DataSource = siswa.ambilList(new SqlCommand("SELECT Id, NamaSiswa FROM siswa"));
        }

        private void button_tNilai_Click(object sender, EventArgs e)
        {
            tampilkanNilai();
        }
    }
}
