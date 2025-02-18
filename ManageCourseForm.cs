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
using Student_Management_System;

namespace StudentManagementSystem
{
    public partial class ManageCourseForm: Form
    {
        CourseClass kursus = new CourseClass();
        DBconnect connect = new DBconnect();
        public ManageCourseForm()
        {
            InitializeComponent();
        }

        private void setFormEnabled(bool status)
        {
            textBox_namaKursus.Enabled = status;
            textBox_jam.Enabled = status;
            textBox_idKursus.Enabled = status;
            textBox_deskripsi.Enabled = status;
            button_hapus.Enabled = status;
            button_bersihkan.Enabled = status;
            button_update.Enabled = status;
        }

        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            showData();
            setFormEnabled(false);
        }

        private void showData()
        {
            DataGridView_kursus.ReadOnly = true;
            DataGridView_kursus.DataSource = kursus.getCourseList(new SqlCommand("SELECT * FROM kursus"));
        }

        private void button_bersihkan_Click(object sender, EventArgs e)
        {
            setFormEnabled(false);

            textBox_namaKursus.Clear();
            textBox_jam.Clear();
            textBox_idKursus.Clear();
            textBox_deskripsi.Clear();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (textBox_namaKursus.Text == "" || textBox_jam.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Data Kosong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                int idKursus = Convert.ToInt32(textBox_idKursus.Text);
                string namaKursus = textBox_namaKursus.Text;
                int jam = Convert.ToInt32(textBox_jam.Text);
                string desk = textBox_deskripsi.Text;

                if (kursus.updateKursus(idKursus, namaKursus, jam, desk))
                {
                    showData();
                    button_bersihkan.PerformClick();
                    MessageBox.Show("Data kursus telah berhasil diubah", "Kursus Diubah", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Kursus belum diubah", "Kursus Diubah", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_hapus_Click(object sender, EventArgs e)
        {
            if (textBox_idKursus.Text.Equals(""))
            {
                MessageBox.Show("ID Kursus Dibutuhkan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                try
                {
                    int idKursus = Convert.ToInt32(textBox_idKursus.Text);
                    if (MessageBox.Show("Apakah Anda yakin ingin menghapus kursus ini?", "Menghapus Kursus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (kursus.hapusKursus(idKursus))
                        {
                            showData();
                            button_bersihkan.PerformClick();
                            MessageBox.Show("Kursus telah berhasil dihapus", "Kursus Dihapus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "");
                }
            }
        }

        private void DataGridView_course_Click(object sender, EventArgs e)
        {
            setFormEnabled(true);

            textBox_idKursus.Text = DataGridView_kursus.CurrentRow.Cells[0].Value.ToString();
            textBox_namaKursus.Text = DataGridView_kursus.CurrentRow.Cells[1].Value.ToString();
            textBox_jam.Text = DataGridView_kursus.CurrentRow.Cells[2].Value.ToString();
            textBox_deskripsi.Text = DataGridView_kursus.CurrentRow.Cells[3].Value.ToString();
        }

        private void textBox_cari_TextChanged(object sender, EventArgs e)
        {
            DataGridView_kursus.DataSource = kursus.cariKursus(textBox_cari.Text);

            if (DataGridView_kursus.Columns.Count > 6)
            {
                DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)DataGridView_kursus.Columns[3];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
        }
    }
}
