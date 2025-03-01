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
    public partial class FormLogin: Form
    {
        Siswa siswa = new Siswa();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Transparent;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (textBox_username.Text == "" || textBox_password.Text == "")
            {
                MessageBox.Show("Masukkan username dan passwordnya!", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                string username = textBox_username.Text;
                string password = textBox_password.Text;
                DataTable tabel = siswa.ambilList(new SqlCommand("SELECT * FROM userLogin WHERE username = '" + username + "' AND password = '" + password + "'"));
                if (tabel.Rows.Count > 0)
                {
                    MainForm main = new MainForm();
                    this.Hide();
                    main.Show();
                } else
                {
                    MessageBox.Show("Username atau Password tidak ada", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
