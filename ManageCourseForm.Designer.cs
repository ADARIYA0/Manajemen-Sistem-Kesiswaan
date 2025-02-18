namespace StudentManagementSystem
{
    partial class ManageCourseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCourseForm));
            this.label_course = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_update = new System.Windows.Forms.Button();
            this.button_bersihkan = new System.Windows.Forms.Button();
            this.label_jam = new System.Windows.Forms.Label();
            this.textBox_jam = new System.Windows.Forms.TextBox();
            this.label_namaKursus = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_hapus = new System.Windows.Forms.Button();
            this.label_idKursus = new System.Windows.Forms.Label();
            this.textBox_idKursus = new System.Windows.Forms.TextBox();
            this.textBox_deskripsi = new System.Windows.Forms.TextBox();
            this.label_deskripsi = new System.Windows.Forms.Label();
            this.textBox_namaKursus = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataGridView_kursus = new Guna.UI2.WinForms.Guna2DataGridView();
            this.textBox_cari = new System.Windows.Forms.TextBox();
            this.label_cariKursus = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_kursus)).BeginInit();
            this.SuspendLayout();
            // 
            // label_course
            // 
            this.label_course.AutoSize = true;
            this.label_course.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_course.Location = new System.Drawing.Point(370, 13);
            this.label_course.Name = "label_course";
            this.label_course.Size = new System.Drawing.Size(169, 25);
            this.label_course.TabIndex = 0;
            this.label_course.Text = "Manage Kursus";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Location = new System.Drawing.Point(13, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(909, 10);
            this.panel3.TabIndex = 33;
            // 
            // button_update
            // 
            this.button_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_update.BackColor = System.Drawing.Color.Orange;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.Color.White;
            this.button_update.Location = new System.Drawing.Point(804, 188);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(118, 39);
            this.button_update.TabIndex = 4;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_bersihkan
            // 
            this.button_bersihkan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_bersihkan.BackColor = System.Drawing.Color.OrangeRed;
            this.button_bersihkan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_bersihkan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_bersihkan.ForeColor = System.Drawing.Color.White;
            this.button_bersihkan.Location = new System.Drawing.Point(680, 188);
            this.button_bersihkan.Name = "button_bersihkan";
            this.button_bersihkan.Size = new System.Drawing.Size(118, 39);
            this.button_bersihkan.TabIndex = 3;
            this.button_bersihkan.Text = "Bersihkan";
            this.button_bersihkan.UseVisualStyleBackColor = false;
            this.button_bersihkan.Click += new System.EventHandler(this.button_bersihkan_Click);
            // 
            // label_jam
            // 
            this.label_jam.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_jam.AutoSize = true;
            this.label_jam.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_jam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_jam.Location = new System.Drawing.Point(17, 72);
            this.label_jam.Name = "label_jam";
            this.label_jam.Size = new System.Drawing.Size(48, 19);
            this.label_jam.TabIndex = 29;
            this.label_jam.Text = "Jam:";
            // 
            // textBox_jam
            // 
            this.textBox_jam.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_jam.Location = new System.Drawing.Point(21, 94);
            this.textBox_jam.Name = "textBox_jam";
            this.textBox_jam.Size = new System.Drawing.Size(156, 27);
            this.textBox_jam.TabIndex = 1;
            // 
            // label_namaKursus
            // 
            this.label_namaKursus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_namaKursus.AutoSize = true;
            this.label_namaKursus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_namaKursus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_namaKursus.Location = new System.Drawing.Point(17, 18);
            this.label_namaKursus.Name = "label_namaKursus";
            this.label_namaKursus.Size = new System.Drawing.Size(114, 19);
            this.label_namaKursus.TabIndex = 1;
            this.label_namaKursus.Text = "Nama Kursus:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_hapus);
            this.panel2.Controls.Add(this.label_idKursus);
            this.panel2.Controls.Add(this.textBox_idKursus);
            this.panel2.Controls.Add(this.textBox_deskripsi);
            this.panel2.Controls.Add(this.label_deskripsi);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button_update);
            this.panel2.Controls.Add(this.button_bersihkan);
            this.panel2.Controls.Add(this.label_jam);
            this.panel2.Controls.Add(this.textBox_jam);
            this.panel2.Controls.Add(this.label_namaKursus);
            this.panel2.Controls.Add(this.textBox_namaKursus);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 376);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 235);
            this.panel2.TabIndex = 19;
            // 
            // button_hapus
            // 
            this.button_hapus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_hapus.BackColor = System.Drawing.Color.Red;
            this.button_hapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_hapus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_hapus.ForeColor = System.Drawing.Color.White;
            this.button_hapus.Location = new System.Drawing.Point(556, 188);
            this.button_hapus.Name = "button_hapus";
            this.button_hapus.Size = new System.Drawing.Size(118, 39);
            this.button_hapus.TabIndex = 37;
            this.button_hapus.Text = "Hapus";
            this.button_hapus.UseVisualStyleBackColor = false;
            this.button_hapus.Click += new System.EventHandler(this.button_hapus_Click);
            // 
            // label_idKursus
            // 
            this.label_idKursus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_idKursus.AutoSize = true;
            this.label_idKursus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_idKursus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_idKursus.Location = new System.Drawing.Point(363, 73);
            this.label_idKursus.Name = "label_idKursus";
            this.label_idKursus.Size = new System.Drawing.Size(79, 19);
            this.label_idKursus.TabIndex = 36;
            this.label_idKursus.Text = "ID Kursus:";
            // 
            // textBox_idKursus
            // 
            this.textBox_idKursus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_idKursus.Location = new System.Drawing.Point(363, 94);
            this.textBox_idKursus.Name = "textBox_idKursus";
            this.textBox_idKursus.Size = new System.Drawing.Size(156, 27);
            this.textBox_idKursus.TabIndex = 35;
            // 
            // textBox_deskripsi
            // 
            this.textBox_deskripsi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_deskripsi.Location = new System.Drawing.Point(21, 150);
            this.textBox_deskripsi.Multiline = true;
            this.textBox_deskripsi.Name = "textBox_deskripsi";
            this.textBox_deskripsi.Size = new System.Drawing.Size(498, 65);
            this.textBox_deskripsi.TabIndex = 2;
            // 
            // label_deskripsi
            // 
            this.label_deskripsi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_deskripsi.AutoSize = true;
            this.label_deskripsi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_deskripsi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_deskripsi.Location = new System.Drawing.Point(17, 126);
            this.label_deskripsi.Name = "label_deskripsi";
            this.label_deskripsi.Size = new System.Drawing.Size(79, 19);
            this.label_deskripsi.TabIndex = 34;
            this.label_deskripsi.Text = "Deskripsi:";
            // 
            // textBox_namaKursus
            // 
            this.textBox_namaKursus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_namaKursus.Location = new System.Drawing.Point(21, 40);
            this.textBox_namaKursus.Name = "textBox_namaKursus";
            this.textBox_namaKursus.Size = new System.Drawing.Size(498, 27);
            this.textBox_namaKursus.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.label_course);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 51);
            this.panel1.TabIndex = 20;
            // 
            // DataGridView_kursus
            // 
            this.DataGridView_kursus.AllowUserToAddRows = false;
            this.DataGridView_kursus.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView_kursus.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_kursus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_kursus.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_kursus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_kursus.ColumnHeadersHeight = 24;
            this.DataGridView_kursus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_kursus.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_kursus.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_kursus.Location = new System.Drawing.Point(13, 93);
            this.DataGridView_kursus.Name = "DataGridView_kursus";
            this.DataGridView_kursus.RowHeadersVisible = false;
            this.DataGridView_kursus.RowHeadersWidth = 51;
            this.DataGridView_kursus.RowTemplate.Height = 80;
            this.DataGridView_kursus.Size = new System.Drawing.Size(909, 279);
            this.DataGridView_kursus.TabIndex = 18;
            this.DataGridView_kursus.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_kursus.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_kursus.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_kursus.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_kursus.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_kursus.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.DataGridView_kursus.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_kursus.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_kursus.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_kursus.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_kursus.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_kursus.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_kursus.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridView_kursus.ThemeStyle.ReadOnly = false;
            this.DataGridView_kursus.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_kursus.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_kursus.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_kursus.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_kursus.ThemeStyle.RowsStyle.Height = 80;
            this.DataGridView_kursus.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_kursus.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_kursus.Click += new System.EventHandler(this.DataGridView_course_Click);
            // 
            // textBox_cari
            // 
            this.textBox_cari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_cari.Location = new System.Drawing.Point(766, 58);
            this.textBox_cari.Name = "textBox_cari";
            this.textBox_cari.Size = new System.Drawing.Size(156, 27);
            this.textBox_cari.TabIndex = 36;
            this.textBox_cari.TextChanged += new System.EventHandler(this.textBox_cari_TextChanged);
            // 
            // label_cariKursus
            // 
            this.label_cariKursus.AutoSize = true;
            this.label_cariKursus.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_cariKursus.Location = new System.Drawing.Point(607, 61);
            this.label_cariKursus.Name = "label_cariKursus";
            this.label_cariKursus.Size = new System.Drawing.Size(153, 21);
            this.label_cariKursus.TabIndex = 38;
            this.label_cariKursus.Text = "Cari Nama Kursus :";
            // 
            // ManageCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.label_cariKursus);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_cari);
            this.Controls.Add(this.DataGridView_kursus);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ManageCourseForm";
            this.Text = "Manage Kursus";
            this.Load += new System.EventHandler(this.ManageCourseForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_kursus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_course;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_bersihkan;
        private System.Windows.Forms.Label label_jam;
        private System.Windows.Forms.TextBox textBox_jam;
        private System.Windows.Forms.Label label_namaKursus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_deskripsi;
        private System.Windows.Forms.Label label_deskripsi;
        private System.Windows.Forms.TextBox textBox_namaKursus;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_kursus;
        private System.Windows.Forms.Label label_idKursus;
        private System.Windows.Forms.TextBox textBox_idKursus;
        private System.Windows.Forms.TextBox textBox_cari;
        private System.Windows.Forms.Button button_hapus;
        private System.Windows.Forms.Label label_cariKursus;
    }
}