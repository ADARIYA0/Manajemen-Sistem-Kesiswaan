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
    public partial class FormRegister : Form
    {
        Siswa siswa = new Siswa();

        public FormRegister()
        {
            InitializeComponent();
        }

        bool verify()
        {
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
            DataGridView_murid.ReadOnly = true;
            DataGridView_murid.DataSource = siswa.ambilList(new SqlCommand("SELECT * FROM siswa"));
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_murid.Columns[6];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            tampilkanTabel();
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            opf.Title = "Browse Image";

            if (opf.ShowDialog() == DialogResult.OK)
                pictureBox_murid.Image = Image.FromFile(opf.FileName);
        }

        private void button_tambah_Click(object sender, EventArgs e)
        {
            if (!verify())
            {
                return;
            }

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
                    if (siswa.insertSiswa(nama, telepon, tanggalLahir, jenisKelamin, alamat, img))
                    {
                        tampilkanTabel();
                        MessageBox.Show("Data Peserta Didik Baru Ditambahkan", "Penambahan Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } catch (Exception ex)

                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_nama.Clear();
            textBox_telepon.Clear();
            dateTimePicker_lahir.Value = DateTime.Now;
            radioButton_laki.Checked = false;
            radioButton_perempuan.Checked = false;
            textBox_alamat.Clear();
            pictureBox_murid.Image = null;
        }
    }
}
