using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Student_Management_System;

namespace StudentManagementSystem
{
    public partial class ManageStudentForm : Form
    {
        StudentClass siswa = new StudentClass();
        public ManageStudentForm()
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

        private void ManageStudentForm_Load(object sender, EventArgs e)
        {
            showTable();
        }

        public void showTable()
        {
            DataGridView_murid.ReadOnly = true;
            DataGridView_murid.DataSource = siswa.getStudentlist();
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_murid.Columns[6];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void DataGridView_murid_Click(object sender, EventArgs e)
        {
            textBox_id.Text = DataGridView_murid.CurrentRow.Cells[0].Value.ToString();
            textBox_nama.Text = DataGridView_murid.CurrentRow.Cells[1].Value.ToString();
            textBox_telepon.Text = DataGridView_murid.CurrentRow.Cells[2].Value.ToString();

            dateTimePicker_lahir.Value = (DateTime)DataGridView_murid.CurrentRow.Cells[3].Value;
            if (DataGridView_murid.CurrentRow.Cells[4].Value.ToString()  == "Laki")
            {
                radioButton_laki.Checked = true;
            } else
            {
                radioButton_perempuan.Checked = true;
            }

            textBox_alamat.Text = DataGridView_murid.CurrentRow.Cells[5].Value.ToString();
            byte[] img = (byte[])DataGridView_murid.CurrentRow.Cells[6].Value;
            MemoryStream ms = new MemoryStream(img);
            pictureBox_murid.Image = Image.FromStream(ms);
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_id.Clear();
            textBox_nama.Clear();
            textBox_telepon.Clear();
            dateTimePicker_lahir.Value = DateTime.Now;
            radioButton_laki.Checked = false;
            radioButton_perempuan.Checked = false;
            textBox_alamat.Clear();
            pictureBox_murid.Image = null;
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Photo(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            opf.Title = "Browse Image";

            if (opf.ShowDialog() == DialogResult.OK)
                pictureBox_murid.Image = Image.FromFile(opf.FileName);
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataGridView_murid.DataSource = siswa.cariMurid(textBox_search.Text);
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_murid.Columns[6];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void button_update_Click(object sender, EventArgs e)
        {
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
                    if (siswa.updateStudent(id, nama, telepon, tanggalLahir, jenisKelamin, alamat, img))
                    {
                        showTable();
                        MessageBox.Show("Data Peserta Didik Telah Diubah", "Perubahan Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button_clear.PerformClick();
                    }
                } catch (Exception ex)

                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox_id.Text);
            //Show a confirmation message before delete the student
            if (MessageBox.Show("Apakah Anda yakin ingin menghapus data peserta didik ini?", "Menghapus Data Peserta Didik", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (siswa.deleteStudent(id))
                {
                    showTable();
                    MessageBox.Show("Data Peserta Didik Berhasil Dihapus", "Menghapus Data Peserta Didik", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button_clear.PerformClick();
                }
            }
        }
    }
}
