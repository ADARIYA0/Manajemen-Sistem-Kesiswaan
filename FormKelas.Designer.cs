namespace SistemManajemenSekolah
{
    partial class FormKelas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKelas));
            this.label_course = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_tambah = new System.Windows.Forms.Button();
            this.button_bersihkan = new System.Windows.Forms.Button();
            this.label_Cjam = new System.Windows.Forms.Label();
            this.textBox_jam = new System.Windows.Forms.TextBox();
            this.label_namaKelas = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_deskripsi = new System.Windows.Forms.TextBox();
            this.label_Cdeskripsi = new System.Windows.Forms.Label();
            this.textBox_namaKelas = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataGridView_kelas = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_kelas)).BeginInit();
            this.SuspendLayout();
            // 
            // label_course
            // 
            this.label_course.AutoSize = true;
            this.label_course.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_course.Location = new System.Drawing.Point(387, 14);
            this.label_course.Name = "label_course";
            this.label_course.Size = new System.Drawing.Size(156, 25);
            this.label_course.TabIndex = 0;
            this.label_course.Text = "Tambah Kelas";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Location = new System.Drawing.Point(13, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(909, 10);
            this.panel3.TabIndex = 33;
            // 
            // button_tambah
            // 
            this.button_tambah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_tambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button_tambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_tambah.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tambah.ForeColor = System.Drawing.Color.White;
            this.button_tambah.Location = new System.Drawing.Point(804, 212);
            this.button_tambah.Name = "button_tambah";
            this.button_tambah.Size = new System.Drawing.Size(118, 39);
            this.button_tambah.TabIndex = 4;
            this.button_tambah.Text = "Tambah";
            this.button_tambah.UseVisualStyleBackColor = false;
            this.button_tambah.Click += new System.EventHandler(this.button_tambah_Click);
            // 
            // button_bersihkan
            // 
            this.button_bersihkan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_bersihkan.BackColor = System.Drawing.Color.Orange;
            this.button_bersihkan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_bersihkan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_bersihkan.ForeColor = System.Drawing.Color.White;
            this.button_bersihkan.Location = new System.Drawing.Point(680, 212);
            this.button_bersihkan.Name = "button_bersihkan";
            this.button_bersihkan.Size = new System.Drawing.Size(118, 39);
            this.button_bersihkan.TabIndex = 3;
            this.button_bersihkan.Text = "Bersihkan";
            this.button_bersihkan.UseVisualStyleBackColor = false;
            this.button_bersihkan.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // label_Cjam
            // 
            this.label_Cjam.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Cjam.AutoSize = true;
            this.label_Cjam.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Cjam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_Cjam.Location = new System.Drawing.Point(17, 84);
            this.label_Cjam.Name = "label_Cjam";
            this.label_Cjam.Size = new System.Drawing.Size(52, 19);
            this.label_Cjam.TabIndex = 29;
            this.label_Cjam.Text = "Jam :";
            // 
            // textBox_jam
            // 
            this.textBox_jam.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_jam.Location = new System.Drawing.Point(21, 106);
            this.textBox_jam.Name = "textBox_jam";
            this.textBox_jam.Size = new System.Drawing.Size(135, 27);
            this.textBox_jam.TabIndex = 1;
            // 
            // label_namaKelas
            // 
            this.label_namaKelas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_namaKelas.AutoSize = true;
            this.label_namaKelas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_namaKelas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_namaKelas.Location = new System.Drawing.Point(17, 19);
            this.label_namaKelas.Name = "label_namaKelas";
            this.label_namaKelas.Size = new System.Drawing.Size(112, 19);
            this.label_namaKelas.TabIndex = 1;
            this.label_namaKelas.Text = "Nama Kelas :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.textBox_deskripsi);
            this.panel2.Controls.Add(this.label_Cdeskripsi);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button_tambah);
            this.panel2.Controls.Add(this.button_bersihkan);
            this.panel2.Controls.Add(this.label_Cjam);
            this.panel2.Controls.Add(this.textBox_jam);
            this.panel2.Controls.Add(this.label_namaKelas);
            this.panel2.Controls.Add(this.textBox_namaKelas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 352);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 259);
            this.panel2.TabIndex = 16;
            // 
            // textBox_deskripsi
            // 
            this.textBox_deskripsi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_deskripsi.Location = new System.Drawing.Point(21, 174);
            this.textBox_deskripsi.Multiline = true;
            this.textBox_deskripsi.Name = "textBox_deskripsi";
            this.textBox_deskripsi.Size = new System.Drawing.Size(486, 71);
            this.textBox_deskripsi.TabIndex = 2;
            // 
            // label_Cdeskripsi
            // 
            this.label_Cdeskripsi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Cdeskripsi.AutoSize = true;
            this.label_Cdeskripsi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Cdeskripsi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_Cdeskripsi.Location = new System.Drawing.Point(17, 150);
            this.label_Cdeskripsi.Name = "label_Cdeskripsi";
            this.label_Cdeskripsi.Size = new System.Drawing.Size(83, 19);
            this.label_Cdeskripsi.TabIndex = 34;
            this.label_Cdeskripsi.Text = "Deskripsi :";
            // 
            // textBox_namaKelas
            // 
            this.textBox_namaKelas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_namaKelas.Location = new System.Drawing.Point(21, 41);
            this.textBox_namaKelas.Name = "textBox_namaKelas";
            this.textBox_namaKelas.Size = new System.Drawing.Size(486, 27);
            this.textBox_namaKelas.TabIndex = 0;
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
            this.panel1.TabIndex = 17;
            // 
            // DataGridView_kelas
            // 
            this.DataGridView_kelas.AllowUserToAddRows = false;
            this.DataGridView_kelas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView_kelas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_kelas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_kelas.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_kelas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_kelas.ColumnHeadersHeight = 24;
            this.DataGridView_kelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_kelas.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_kelas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_kelas.Location = new System.Drawing.Point(13, 57);
            this.DataGridView_kelas.Name = "DataGridView_kelas";
            this.DataGridView_kelas.RowHeadersVisible = false;
            this.DataGridView_kelas.RowHeadersWidth = 51;
            this.DataGridView_kelas.RowTemplate.Height = 80;
            this.DataGridView_kelas.Size = new System.Drawing.Size(909, 289);
            this.DataGridView_kelas.TabIndex = 15;
            this.DataGridView_kelas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_kelas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_kelas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_kelas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_kelas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_kelas.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.DataGridView_kelas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_kelas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_kelas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_kelas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_kelas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_kelas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_kelas.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridView_kelas.ThemeStyle.ReadOnly = false;
            this.DataGridView_kelas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_kelas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_kelas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_kelas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_kelas.ThemeStyle.RowsStyle.Height = 80;
            this.DataGridView_kelas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_kelas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // FormKelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DataGridView_kelas);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormKelas";
            this.Text = "Tambah Kelas Baru";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_kelas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_course;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_tambah;
        private System.Windows.Forms.Button button_bersihkan;
        private System.Windows.Forms.Label label_Cjam;
        private System.Windows.Forms.TextBox textBox_jam;
        private System.Windows.Forms.Label label_namaKelas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_namaKelas;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_kelas;
        private System.Windows.Forms.Label label_Cdeskripsi;
        private System.Windows.Forms.TextBox textBox_deskripsi;
    }
}