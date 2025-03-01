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
    public partial class FormKelas : Form
    {
        Kelas kelas = new Kelas();

        public FormKelas()
        {
            InitializeComponent();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_namaKelas.Clear();
            textBox_jam.Clear();
            textBox_deskripsi.Clear();
        }

        private void button_tambah_Click(object sender, EventArgs e)
        {
            if (textBox_namaKelas.Text == "" || textBox_jam.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Data Kosong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                string namaKelas = textBox_namaKelas.Text;
                int jam = Convert.ToInt32(textBox_jam.Text);
                string desk = textBox_deskripsi.Text;

                if (kelas.cekKelas(namaKelas))
                {
                    MessageBox.Show("Nama kursus sudah ada, silakan gunakan nama lain!", "Kursus Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (kelas.insertKelas(namaKelas, jam, desk))
                {
                    showData();
                    button_bersihkan.PerformClick();
                    MessageBox.Show("Kursus baru ditambahkan", "Kursus Baru", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Kursus belum dimasukkan", "Kursus Baru", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void showData()
        {
            DataGridView_kelas.ReadOnly = true;
            DataGridView_kelas.DataSource = kelas.ambilDaftarKelas(new SqlCommand("SELECT * FROM kelas"));
        }
    }
}
