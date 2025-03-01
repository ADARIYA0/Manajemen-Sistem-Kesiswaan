using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemManajemenSekolah
{
    public partial class FormManageSiswa : Form
    {
        Siswa siswa = new Siswa();
        public FormManageSiswa()
        {
            InitializeComponent();
        }

        bool verify()
        {
            if (textBox_id.Text == "")
            {
                MessageBox.Show("ID tidak boleh kosong", "ID Kosong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBox_nama.Text == "")
            {
                MessageBox.Show("Nama tidak boleh kosong", "Nama Kosong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBox_telepon.Text == "")
            {
                MessageBox.Show("Nomor telepon tidak boleh kosong", "Nomor Telepon Kosong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!radioButton_laki.Checked && !radioButton_perempuan.Checked)
            {
                MessageBox.Show("Jenis Kelamin harus dipilih", "Jenis Kelamin Kosong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBox_alamat.Text == "")
            {
                MessageBox.Show("Alamat tidak boleh kosong", "Alamat Kosong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (pictureBox_murid.Image == null)
            {
                MessageBox.Show("Foto Profil tidak boleh kosong", "Foto Profil Kosong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public void tampilkanTabel()
        {
            DataGridView_siswa.ReadOnly = true;
            DataGridView_siswa.DataSource = siswa.ambilList(new SqlCommand("SELECT * FROM siswa"));
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_siswa.Columns[6];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void setFormEnabled(bool status)
        {
            textBox_nama.Enabled = status;
            textBox_telepon.Enabled = status;
            dateTimePicker_lahir.Enabled = status;
            radioButton_laki.Enabled = status;
            radioButton_perempuan.Enabled = status;
            textBox_alamat.Enabled = status;
            textBox_id.Enabled = status;
            button_upload.Enabled = status;
            button_bersihkan.Enabled = status;
            button_hapus.Enabled = status;
            button_update.Enabled = status;
        }

        private void ManageStudentForm_Load(object sender, EventArgs e)
        {
            tampilkanTabel();
            setFormEnabled(false);
        }

        private void DataGridView_murid_Click(object sender, EventArgs e)
        {
            setFormEnabled(true);

            textBox_id.Text = DataGridView_siswa.CurrentRow.Cells[0].Value.ToString();
            textBox_nama.Text = DataGridView_siswa.CurrentRow.Cells[1].Value.ToString();
            textBox_telepon.Text = DataGridView_siswa.CurrentRow.Cells[2].Value.ToString();

            dateTimePicker_lahir.Value = (DateTime)DataGridView_siswa.CurrentRow.Cells[3].Value;
            if (DataGridView_siswa.CurrentRow.Cells[4].Value.ToString()  == "Laki")
            {
                radioButton_laki.Checked = true;
            } else
            {
                radioButton_perempuan.Checked = true;
            }

            textBox_alamat.Text = DataGridView_siswa.CurrentRow.Cells[5].Value.ToString();
            byte[] img = (byte[])DataGridView_siswa.CurrentRow.Cells[6].Value;
            MemoryStream ms = new MemoryStream(img);
            pictureBox_murid.Image = Image.FromStream(ms);
        }

        private void button_bersihkan_Click(object sender, EventArgs e)
        {
            textBox_id.Clear();
            textBox_nama.Clear();
            textBox_telepon.Clear();
            dateTimePicker_lahir.Value = DateTime.Now;
            radioButton_laki.Checked = false;
            radioButton_perempuan.Checked = false;
            textBox_alamat.Clear();
            pictureBox_murid.Image = null;

            setFormEnabled(false);
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Pilih Foto(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            opf.Title = "Cari Image";

            if (opf.ShowDialog() == DialogResult.OK)
                pictureBox_murid.Image = Image.FromFile(opf.FileName);
        }

        private void textBox_cari_TextChanged(object sender, EventArgs e)
        {
            DataGridView_siswa.DataSource = siswa.cariSiswa(textBox_cari.Text);

            if (DataGridView_siswa.Columns.Count > 6)
            {
                DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)DataGridView_siswa.Columns[6];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_id.Text))
            {
                MessageBox.Show("Silakan pilih data murid dari tabel sebelum mengubah data.", "Data Tidak Dipilih", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = Convert.ToInt32(textBox_id.Text);
            string nama = textBox_nama.Text;
            string telepon = textBox_telepon.Text;
            DateTime tanggalLahir = dateTimePicker_lahir.Value;
            string jenisKelamin = radioButton_laki.Checked ? "Laki" : "Perempuan";
            string alamat = textBox_alamat.Text;

            int born_year = dateTimePicker_lahir.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year - born_year) < 10 || (this_year - born_year) > 100)
            {
                MessageBox.Show("Usia murid harus diantara 10 dan 100 tahun", "Tanggal Lahir Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (verify())
            {
                try
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox_murid.Image.Save(ms, pictureBox_murid.Image.RawFormat);
                    byte[] img = ms.ToArray();
                    if (siswa.updateSiswa(id, nama, telepon, tanggalLahir, jenisKelamin, alamat, img))
                    {
                        tampilkanTabel();
                        MessageBox.Show("Data Peserta Didik Telah Diubah", "Perubahan Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button_bersihkan.PerformClick();
                    }
                } catch (Exception ex)

                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_hapus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_id.Text))
            {
                MessageBox.Show("Silakan pilih murid dari tabel sebelum menghapus data.", "Data Tidak Dipilih", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = Convert.ToInt32(textBox_id.Text);
            if (MessageBox.Show("Apakah Anda yakin ingin menghapus data peserta didik ini?", "Menghapus Data Peserta Didik", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (siswa.hapusSiswa(id))
                {
                    tampilkanTabel();
                    MessageBox.Show("Data Peserta Didik Berhasil Dihapus", "Menghapus Data Peserta Didik", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button_bersihkan.PerformClick();
                }
            }
        }
    }
}
