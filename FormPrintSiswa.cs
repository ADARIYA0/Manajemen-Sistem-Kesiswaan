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
using DGVPrinterHelper;

namespace SistemManajemenSekolah
{
    public partial class PrintStudentForm : Form
    {
        Siswa siswa = new Siswa();
        DGVPrinter printer = new DGVPrinter();

        public PrintStudentForm()
        {
            InitializeComponent();
        }

        public void tampilkanData(SqlCommand command)
        {
            DataGridView_murid.ReadOnly = true;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            DataGridView_murid.DataSource = siswa.ambilList(command);

            imageColumn = (DataGridViewImageColumn)DataGridView_murid.Columns[6];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imageColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void PrintStudentForm_Load(object sender, EventArgs e)
        {
            tampilkanData(new SqlCommand("SELECT * FROM siswa"));
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            printer.Title = "List Murid Mdemy";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGridView_murid);
        }

        private void radioButton_all_CheckedChanged(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM siswa";
            if (radioButton_laki.Checked)
            {
                selectQuery = "SELECT * FROM siswa";
            }

            tampilkanData(new SqlCommand(selectQuery));
        }

        private void radioButton_laki_CheckedChanged(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM siswa";
            if (radioButton_laki.Checked)
            {
                selectQuery = "SELECT * FROM siswa WHERE JenisKelamin = 'Laki'";
            }
            
            tampilkanData(new SqlCommand(selectQuery));
        }

        private void radioButton_perempuan_CheckedChanged(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM siswa";
            if (radioButton_perempuan.Checked)
            {
                selectQuery = "SELECT * FROM siswa WHERE JenisKelamin = 'Perempuan'";
            }

            tampilkanData(new SqlCommand(selectQuery));
        }
    }
}
