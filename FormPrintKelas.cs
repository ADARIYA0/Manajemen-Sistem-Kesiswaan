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
    public partial class FormPrintKelas: Form
    {
        Kelas kelas = new Kelas();
        DGVPrinter printer = new DGVPrinter();

        public FormPrintKelas()
        {
            InitializeComponent();
        }

        private void PrintCourseForm_Load(object sender, EventArgs e)
        {
            DataGridView_kelas.ReadOnly = true;
            DataGridView_kelas.DataSource = kelas.ambilDaftarKelas(new SqlCommand("SELECT * FROM kelas"));
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            printer.Title = "List Kelas Mdemy";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGridView_kelas);
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
