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

namespace StudentManagementSystem
{
    public partial class PrintCourseForm: Form
    {
        CourseClass kursus = new CourseClass();
        DGVPrinter printer = new DGVPrinter();

        public PrintCourseForm()
        {
            InitializeComponent();
        }

        private void PrintCourseForm_Load(object sender, EventArgs e)
        {
            DataGridView_kursus.DataSource = kursus.getCourseList(new SqlCommand("SELECT * FROM kursus"));
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            printer.Title = "List Kursus Mdemy";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGridView_kursus);
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
