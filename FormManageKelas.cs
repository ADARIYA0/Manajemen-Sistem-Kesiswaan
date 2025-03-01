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
    public partial class FormManageKelas: Form
    {
        Kelas kelas = new Kelas();

        public FormManageKelas()
        {
            InitializeComponent();
        }

        private void setFormEnabled(bool status)
        {
            textBox_namaKelas.Enabled = status;
            textBox_jam.Enabled = status;
            textBox_id.Enabled = status;
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
            DataGridView_kelas.ReadOnly = true;
            DataGridView_kelas.DataSource = kelas.ambilDaftarKelas(new SqlCommand("SELECT * FROM kelas"));
        }

        private void button_bersihkan_Click(object sender, EventArgs e)
        {
            setFormEnabled(false);

            textBox_namaKelas.Clear();
            textBox_jam.Clear();
            textBox_id.Clear();
            textBox_deskripsi.Clear();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (textBox_namaKelas.Text == "" || textBox_jam.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Data Kosong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                int id = Convert.ToInt32(textBox_id.Text);
                string namaKelas = textBox_namaKelas.Text;
                int jam = Convert.ToInt32(textBox_jam.Text);
                string desk = textBox_deskripsi.Text;

                if (kelas.updateKelas(id, namaKelas, jam, desk))
                {
                    showData();
                    button_bersihkan.PerformClick();
                    MessageBox.Show("Data kelas berhasil diubah", "Data Kelas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Data kelas belum diubah", "Data Kelas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_hapus_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text.Equals(""))
            {
                MessageBox.Show("ID Kelas Dibutuhkan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                try
                {
                    int id = Convert.ToInt32(textBox_id.Text);
                    if (MessageBox.Show("Apakah Anda yakin ingin menghapus kelas ini?", "Menghapus Kelas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (kelas.hapusKelas(id))
                        {
                            showData();
                            button_bersihkan.PerformClick();
                            MessageBox.Show("Kelas telah berhasil dihapus", "Kelas Dihapus", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            textBox_id.Text = DataGridView_kelas.CurrentRow.Cells[0].Value.ToString();
            textBox_namaKelas.Text = DataGridView_kelas.CurrentRow.Cells[1].Value.ToString();
            textBox_jam.Text = DataGridView_kelas.CurrentRow.Cells[2].Value.ToString();
            textBox_deskripsi.Text = DataGridView_kelas.CurrentRow.Cells[3].Value.ToString();
        }

        private void textBox_cari_TextChanged(object sender, EventArgs e)
        {
            DataGridView_kelas.DataSource = kelas.cariKelas(textBox_cari.Text);

            if (DataGridView_kelas.Columns.Count > 6)
            {
                DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)DataGridView_kelas.Columns[3];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
        }
    }
}
