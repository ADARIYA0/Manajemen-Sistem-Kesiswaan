using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Management_System;
using MySql.Data.MySqlClient;
using DGVPrinterHelper;

namespace StudentManagementSystem
{
    public partial class PrintStudentForm : Form
    {
        StudentClass siswa = new StudentClass();
        DGVPrinter printer = new DGVPrinter();
        public PrintStudentForm()
        {
            InitializeComponent();
        }

        private void PrintStudentForm_Load(object sender, EventArgs e)
        {
            showData(new MySqlCommand("SELECT * FROM siswa"));
        }

        public void showData(MySqlCommand command)
        {
            DataGridView_murid.ReadOnly = true;
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            DataGridView_murid.DataSource = siswa.getList(command);

            imageColumn = (DataGridViewImageColumn)DataGridView_murid.Columns[6];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imageColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string selectQuery;
            if (radioButton_all.Checked)
            {
                selectQuery = "SELECT * FROM siswa";
            } else if (radioButton_laki.Checked)
            {
                selectQuery = "SELECT * FROM siswa WHERE JenisKelamin = 'Laki'";
            } else
            {
                selectQuery = "SELECT * FROM siswa WHERE JenisKelamin = 'Perempuan'";
            }
            showData(new MySqlCommand(selectQuery));
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            printer.Title = "Mdemy Students List";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "foxlearn";
            printer.FooterSpacing = 15;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(DataGridView_murid);
        }
    }
}
