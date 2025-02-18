using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentManagementSystem
{
    public partial class CourseForm : Form
    {
        CourseClass kursus = new CourseClass();

        public CourseForm()
        {
            InitializeComponent();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_namaKursus.Clear();
            textBox_jam.Clear();
            textBox_deskripsi.Clear();
        }

        private void button_tambah_Click(object sender, EventArgs e)
        {
            if (textBox_namaKursus.Text == "" || textBox_jam.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Data Kosong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                string namaKursus = textBox_namaKursus.Text;
                int jam = Convert.ToInt32(textBox_jam.Text);
                string desk = textBox_deskripsi.Text;

                if (kursus.isCourseExists(namaKursus))
                {
                    MessageBox.Show("Nama kursus sudah ada, silakan gunakan nama lain!", "Kursus Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (kursus.insertCourse(namaKursus, jam, desk))
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
            DataGridView_kursus.ReadOnly = true;
            DataGridView_kursus.DataSource = kursus.getCourseList(new SqlCommand("SELECT * FROM kursus"));
        }
    }
}
