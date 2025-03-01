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
using DGVPrinterHelper;

namespace SistemManajemenSekolah
{
    public partial class FormPrintNilai: Form
    {
        Nilai nilai = new Nilai();
        DGVPrinter printer = new DGVPrinter();

        public FormPrintNilai()
        {
            InitializeComponent();
        }

        private void textBox_cari_TextChanged(object sender, EventArgs e)
        {
            DataGridView_nilai.DataSource = nilai.ambilList(new SqlCommand("SELECT nilai.IdSiswa, siswa.NamaSiswa, nilai.NamaKelas, nilai.Nilai, nilai.Deskripsi FROM siswa INNER JOIN nilai ON nilai.IdSiswa = siswa.Id WHERE CONCAT(siswa.NamaSiswa, nilai.NamaKelas)LIKE '%" + textBox_cari.Text + "%'"));
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            printer.Title = "List Nilai Siswa Mdemy";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGridView_nilai);
        }

        private void showData()
        {
            DataGridView_nilai.ReadOnly = true;
            DataGridView_nilai.DataSource = nilai.ambilList(new SqlCommand("SELECT nilai.IdSiswa, siswa.NamaSiswa, nilai.NamaKelas, nilai.Nilai, nilai.Deskripsi FROM siswa INNER JOIN nilai ON nilai.IdSiswa=siswa.Id"));
        }

        private void FormPrintNilai_Load(object sender, EventArgs e)
        {
            showData();
        }
    }
}
