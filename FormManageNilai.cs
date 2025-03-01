using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemManajemenSekolah
{
    public partial class FormManageNilai : Form
    {
        Kelas kelas = new Kelas();
        Nilai nilai = new Nilai();

        public FormManageNilai()
        {
            InitializeComponent();
        }
        public void tampilkanNilai()
        {
            DataGridView_nilai.DataSource = nilai.ambilList(new SqlCommand("SELECT nilai.IdSiswa, siswa.NamaSiswa, nilai.NamaKelas, nilai.Nilai, nilai.Deskripsi FROM siswa INNER JOIN nilai ON nilai.IdSiswa = siswa.Id"));
        }

        private void FormManageNilai_Load(object sender, EventArgs e)
        {
            comboBox_kelas.DataSource = kelas.ambilDaftarKelas(new SqlCommand("SELECT * FROM kelas"));
            comboBox_kelas.DisplayMember = "NamaKelas";
            comboBox_kelas.ValueMember = "NamaKelas";
            tampilkanNilai();

            DataGridView_nilai.ReadOnly = true;
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (textBox_idSiswa.Text == "" || textBox_nilai.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Data Kosong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                int idSiswa = Convert.ToInt32(textBox_idSiswa.Text);
                string namaKelas = comboBox_kelas.Text;
                int nilaiSiswa = Convert.ToInt32(textBox_nilai.Text);
                string desk = textBox_deskripsi.Text;

                if (nilai.updateNilai(idSiswa, namaKelas, nilaiSiswa, desk))
                {
                    tampilkanNilai();
                    button_bersihkan.PerformClick();
                    MessageBox.Show("Nilai telah diperbarui.", "Pembaruan Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {

                    MessageBox.Show("Tidak Ada Update Nilai", "Nilai tidak dapat diperbarui", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_hapus_Click(object sender, EventArgs e)
        {
            if (textBox_idSiswa.Text == "")
            {
                MessageBox.Show("Data tidak dipilih", "Tidak Ada Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                int idSiswa = Convert.ToInt32(textBox_idSiswa.Text);
                if (MessageBox.Show("Apakah Anda yakin ingin menghapus data peserta didik ini?", "Menghapus Data Peserta Didik", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (nilai.hapusNilai(idSiswa))
                    {
                        tampilkanNilai();
                        MessageBox.Show("Data Peserta Didik Berhasil Dihapus", "Menghapus Data Peserta Didik", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button_bersihkan.PerformClick();
                    }
                }
            }
        }

        private void button_bersihkan_Click(object sender, EventArgs e)
        {
            textBox_idSiswa.Clear();
            textBox_nilai.Clear();
            textBox_deskripsi.Clear();
            textBox_cari.Clear();
        }

        private void DataGridView_nilaiSiswa_Click(object sender, EventArgs e)
        {
            textBox_idSiswa.Text = DataGridView_nilai.CurrentRow.Cells[0].Value.ToString();
            comboBox_kelas.Text = DataGridView_nilai.CurrentRow.Cells[2].Value.ToString();
            textBox_nilai.Text = DataGridView_nilai.CurrentRow.Cells[3].Value.ToString();
            textBox_deskripsi.Text = DataGridView_nilai.CurrentRow.Cells[4].Value.ToString();
        }

        private void textBox_cari_TextChanged(object sender, EventArgs e)
        {
            DataGridView_nilai.DataSource = nilai.ambilList(new SqlCommand("SELECT nilai.IdSiswa, siswa.NamaSiswa, nilai.NamaKelas, nilai.Nilai, nilai.Deskripsi FROM siswa INNER JOIN nilai ON nilai.IdSiswa = siswa.Id WHERE CONCAT(siswa.NamaSiswa, nilai.NamaKelas)LIKE '%" + textBox_cari.Text + "%'"));
        }
    }
}
