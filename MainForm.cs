using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemManajemenSekolah
{
    public partial class MainForm : Form
    {
        Siswa siswa = new Siswa();
        public MainForm()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void jumlahSiswa()
        {
            label_jumlahMrd.Text = "Jumlah Siswa : " + siswa.totalSiswa();
            label_mrdLaki.Text = "Laki : " + siswa.siswaLaki();
            label_mrdPerempuan.Text = "Perempuan : " + siswa.siswaPerempuan();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            jumlahSiswa();
        }

        private void customizeDesign()
        {
            panel_stdSubmenu.Visible = false;
            panel_courseSubmenu.Visible = false;
            panel_scoreSubmenu.Visible = false;
        }

        private void hideSubmenu(Panel activeSubmenu)
        {
            if (activeSubmenu.Visible == true)
            {
                activeSubmenu.Visible = false;
            }
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void button_std_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_stdSubmenu);
        }
        #region StdSubmenu
        private void button_registration_Click(object sender, EventArgs e)
        {
            openChildForm(new FormRegister());
            //...
            //..Your code
            //...
            hideSubmenu(panel_stdSubmenu);
        }

        private void button_manageStd_Click(object sender, EventArgs e)
        {
            openChildForm(new FormManageSiswa());
            //...
            //..Your code
            //...
            hideSubmenu(panel_stdSubmenu);
        }

        private void button_stdPrint_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintStudentForm());
            //...
            //..Your code
            //...
            hideSubmenu(panel_stdSubmenu);
        }

        #endregion StdSubmenu
        private void button_course_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_courseSubmenu);
        }
        #region CourseSubmenu
        private void button_newCourse_Click(object sender, EventArgs e)
        {
            openChildForm(new FormKelas());
            //...
            //..Your code
            //...
            hideSubmenu(panel_courseSubmenu);
        }

        private void button_manageCourse_Click(object sender, EventArgs e)
        {
            openChildForm(new FormManageKelas());
            //...
            //..Your code
            //...
            hideSubmenu(panel_courseSubmenu);
        }

        private void button_coursePrint_Click(object sender, EventArgs e)
        {
            openChildForm(new FormPrintKelas());
            //...
            //..Your code
            //...
            hideSubmenu(panel_courseSubmenu);
        }
        #endregion CourseSubmenu

        private void button_score_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_scoreSubmenu);
        }
        #region ScoreSubmenu
        private void button_newScore_Click(object sender, EventArgs e)
        {
            openChildForm(new FormNilai());
            //...
            //..Your code
            //...
            hideSubmenu(panel_scoreSubmenu);
        }

        private void button_manageScore_Click(object sender, EventArgs e)
        {
            openChildForm(new FormManageNilai());
            //...
            //..Your code
            //...
            hideSubmenu(panel_scoreSubmenu);
        }

        private void button_scorePrint_Click(object sender, EventArgs e)
        {
            openChildForm(new FormPrintNilai());
            //...
            //..Your code
            //...
            hideSubmenu(panel_scoreSubmenu);
        }


        #endregion ScoreSubmenu

        //to show register form in mainform
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                if (activeForm.GetType() == childForm.GetType())
                {
                    return;
                }
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            panel_main.Controls.Add(panel_cover);
            jumlahSiswa();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            this.Hide();
            login.Show();
        }
    }
}