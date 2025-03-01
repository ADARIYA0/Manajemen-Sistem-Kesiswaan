namespace SistemManajemenSekolah
{
    partial class FormNilai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNilai));
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_tambah = new System.Windows.Forms.Button();
            this.button_bersihkan = new System.Windows.Forms.Button();
            this.label_Cjam = new System.Windows.Forms.Label();
            this.textBox_nilai = new System.Windows.Forms.TextBox();
            this.label_idSiswa = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_kelas = new System.Windows.Forms.ComboBox();
            this.textBox_deskripsi = new System.Windows.Forms.TextBox();
            this.label_Cdeskripsi = new System.Windows.Forms.Label();
            this.textBox_idSiswa = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_tNilai = new System.Windows.Forms.Button();
            this.button_tSiswa = new System.Windows.Forms.Button();
            this.DataGridView_nilaiSiswa = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_nilaiSiswa)).BeginInit();
            this.SuspendLayout();
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
            this.button_bersihkan.Click += new System.EventHandler(this.button_bersihkan_Click);
            // 
            // label_Cjam
            // 
            this.label_Cjam.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Cjam.AutoSize = true;
            this.label_Cjam.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Cjam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_Cjam.Location = new System.Drawing.Point(31, 75);
            this.label_Cjam.Name = "label_Cjam";
            this.label_Cjam.Size = new System.Drawing.Size(93, 19);
            this.label_Cjam.TabIndex = 29;
            this.label_Cjam.Text = "Pilih Kelas :";
            // 
            // textBox_nilai
            // 
            this.textBox_nilai.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_nilai.Location = new System.Drawing.Point(130, 110);
            this.textBox_nilai.Name = "textBox_nilai";
            this.textBox_nilai.Size = new System.Drawing.Size(135, 27);
            this.textBox_nilai.TabIndex = 1;
            // 
            // label_idSiswa
            // 
            this.label_idSiswa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_idSiswa.AutoSize = true;
            this.label_idSiswa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_idSiswa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_idSiswa.Location = new System.Drawing.Point(46, 36);
            this.label_idSiswa.Name = "label_idSiswa";
            this.label_idSiswa.Size = new System.Drawing.Size(78, 19);
            this.label_idSiswa.TabIndex = 1;
            this.label_idSiswa.Text = "ID Siswa :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBox_kelas);
            this.panel2.Controls.Add(this.textBox_deskripsi);
            this.panel2.Controls.Add(this.label_Cdeskripsi);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button_tambah);
            this.panel2.Controls.Add(this.button_bersihkan);
            this.panel2.Controls.Add(this.label_Cjam);
            this.panel2.Controls.Add(this.textBox_nilai);
            this.panel2.Controls.Add(this.label_idSiswa);
            this.panel2.Controls.Add(this.textBox_idSiswa);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 352);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 259);
            this.panel2.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(41, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 36;
            this.label1.Text = "Deskripsi :";
            // 
            // comboBox_kelas
            // 
            this.comboBox_kelas.FormattingEnabled = true;
            this.comboBox_kelas.Location = new System.Drawing.Point(130, 71);
            this.comboBox_kelas.Name = "comboBox_kelas";
            this.comboBox_kelas.Size = new System.Drawing.Size(486, 29);
            this.comboBox_kelas.TabIndex = 35;
            // 
            // textBox_deskripsi
            // 
            this.textBox_deskripsi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_deskripsi.Location = new System.Drawing.Point(130, 149);
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
            this.label_Cdeskripsi.Location = new System.Drawing.Point(25, 114);
            this.label_Cdeskripsi.Name = "label_Cdeskripsi";
            this.label_Cdeskripsi.Size = new System.Drawing.Size(99, 19);
            this.label_Cdeskripsi.TabIndex = 34;
            this.label_Cdeskripsi.Text = "Skor / Nilai :";
            // 
            // textBox_idSiswa
            // 
            this.textBox_idSiswa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_idSiswa.Location = new System.Drawing.Point(130, 32);
            this.textBox_idSiswa.Name = "textBox_idSiswa";
            this.textBox_idSiswa.Size = new System.Drawing.Size(135, 27);
            this.textBox_idSiswa.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.button_tNilai);
            this.panel1.Controls.Add(this.button_tSiswa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 51);
            this.panel1.TabIndex = 20;
            // 
            // button_tNilai
            // 
            this.button_tNilai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_tNilai.BackColor = System.Drawing.Color.White;
            this.button_tNilai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_tNilai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button_tNilai.Location = new System.Drawing.Point(781, 12);
            this.button_tNilai.Name = "button_tNilai";
            this.button_tNilai.Size = new System.Drawing.Size(141, 34);
            this.button_tNilai.TabIndex = 4;
            this.button_tNilai.Text = "Tampilkan Nilai";
            this.button_tNilai.UseVisualStyleBackColor = false;
            this.button_tNilai.Click += new System.EventHandler(this.button_tNilai_Click);
            // 
            // button_tSiswa
            // 
            this.button_tSiswa.BackColor = System.Drawing.Color.White;
            this.button_tSiswa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_tSiswa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button_tSiswa.Location = new System.Drawing.Point(17, 12);
            this.button_tSiswa.Name = "button_tSiswa";
            this.button_tSiswa.Size = new System.Drawing.Size(148, 34);
            this.button_tSiswa.TabIndex = 3;
            this.button_tSiswa.Text = "Tampilkan Siswa";
            this.button_tSiswa.UseVisualStyleBackColor = false;
            this.button_tSiswa.Click += new System.EventHandler(this.button_tSiswa_Click);
            // 
            // DataGridView_nilaiSiswa
            // 
            this.DataGridView_nilaiSiswa.AllowUserToAddRows = false;
            this.DataGridView_nilaiSiswa.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView_nilaiSiswa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_nilaiSiswa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_nilaiSiswa.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_nilaiSiswa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_nilaiSiswa.ColumnHeadersHeight = 24;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_nilaiSiswa.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_nilaiSiswa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_nilaiSiswa.Location = new System.Drawing.Point(13, 52);
            this.DataGridView_nilaiSiswa.Name = "DataGridView_nilaiSiswa";
            this.DataGridView_nilaiSiswa.RowHeadersVisible = false;
            this.DataGridView_nilaiSiswa.RowTemplate.Height = 80;
            this.DataGridView_nilaiSiswa.Size = new System.Drawing.Size(909, 299);
            this.DataGridView_nilaiSiswa.TabIndex = 37;
            this.DataGridView_nilaiSiswa.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_nilaiSiswa.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_nilaiSiswa.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_nilaiSiswa.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_nilaiSiswa.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_nilaiSiswa.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.DataGridView_nilaiSiswa.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_nilaiSiswa.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_nilaiSiswa.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_nilaiSiswa.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_nilaiSiswa.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_nilaiSiswa.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridView_nilaiSiswa.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridView_nilaiSiswa.ThemeStyle.ReadOnly = false;
            this.DataGridView_nilaiSiswa.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_nilaiSiswa.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_nilaiSiswa.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_nilaiSiswa.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_nilaiSiswa.ThemeStyle.RowsStyle.Height = 80;
            this.DataGridView_nilaiSiswa.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_nilaiSiswa.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_nilaiSiswa.Click += new System.EventHandler(this.DataGridView_nilaiSiswa_Click);
            // 
            // FormNilai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.DataGridView_nilaiSiswa);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormNilai";
            this.Text = "Tambah Skor / Nilai Murid";
            this.Load += new System.EventHandler(this.ScoreForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_nilaiSiswa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_tambah;
        private System.Windows.Forms.Button button_bersihkan;
        private System.Windows.Forms.Label label_Cjam;
        private System.Windows.Forms.TextBox textBox_nilai;
        private System.Windows.Forms.Label label_idSiswa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_deskripsi;
        private System.Windows.Forms.Label label_Cdeskripsi;
        private System.Windows.Forms.TextBox textBox_idSiswa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_kelas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_tSiswa;
        private System.Windows.Forms.Button button_tNilai;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_nilaiSiswa;
    }
}