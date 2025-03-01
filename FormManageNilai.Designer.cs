namespace SistemManajemenSekolah
{
    partial class FormManageNilai
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
            this.label_cariKursus = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_kelas = new System.Windows.Forms.ComboBox();
            this.textBox_deskripsi = new System.Windows.Forms.TextBox();
            this.label_Cdeskripsi = new System.Windows.Forms.Label();
            this.label_Cjam = new System.Windows.Forms.Label();
            this.textBox_nilai = new System.Windows.Forms.TextBox();
            this.label_idSiswa = new System.Windows.Forms.Label();
            this.textBox_idSiswa = new System.Windows.Forms.TextBox();
            this.button_hapus = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_update = new System.Windows.Forms.Button();
            this.button_bersihkan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_kelas = new System.Windows.Forms.Label();
            this.textBox_cari = new System.Windows.Forms.TextBox();
            this.DataGridView_nilai = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_nilai)).BeginInit();
            this.SuspendLayout();
            // 
            // label_cariKursus
            // 
            this.label_cariKursus.AutoSize = true;
            this.label_cariKursus.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label_cariKursus.Location = new System.Drawing.Point(628, 61);
            this.label_cariKursus.Name = "label_cariKursus";
            this.label_cariKursus.Size = new System.Drawing.Size(132, 21);
            this.label_cariKursus.TabIndex = 43;
            this.label_cariKursus.Text = "Cari Nilai Siswa :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.comboBox_kelas);
            this.panel2.Controls.Add(this.textBox_deskripsi);
            this.panel2.Controls.Add(this.label_Cdeskripsi);
            this.panel2.Controls.Add(this.label_Cjam);
            this.panel2.Controls.Add(this.textBox_nilai);
            this.panel2.Controls.Add(this.label_idSiswa);
            this.panel2.Controls.Add(this.textBox_idSiswa);
            this.panel2.Controls.Add(this.button_hapus);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button_update);
            this.panel2.Controls.Add(this.button_bersihkan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 376);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 235);
            this.panel2.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(39, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 45;
            this.label1.Text = "Deskripsi :";
            // 
            // comboBox_kelas
            // 
            this.comboBox_kelas.FormattingEnabled = true;
            this.comboBox_kelas.Location = new System.Drawing.Point(128, 63);
            this.comboBox_kelas.Name = "comboBox_kelas";
            this.comboBox_kelas.Size = new System.Drawing.Size(417, 29);
            this.comboBox_kelas.TabIndex = 44;
            // 
            // textBox_deskripsi
            // 
            this.textBox_deskripsi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_deskripsi.Location = new System.Drawing.Point(128, 141);
            this.textBox_deskripsi.Multiline = true;
            this.textBox_deskripsi.Name = "textBox_deskripsi";
            this.textBox_deskripsi.Size = new System.Drawing.Size(417, 71);
            this.textBox_deskripsi.TabIndex = 41;
            // 
            // label_Cdeskripsi
            // 
            this.label_Cdeskripsi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Cdeskripsi.AutoSize = true;
            this.label_Cdeskripsi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Cdeskripsi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_Cdeskripsi.Location = new System.Drawing.Point(23, 106);
            this.label_Cdeskripsi.Name = "label_Cdeskripsi";
            this.label_Cdeskripsi.Size = new System.Drawing.Size(99, 19);
            this.label_Cdeskripsi.TabIndex = 43;
            this.label_Cdeskripsi.Text = "Skor / Nilai :";
            // 
            // label_Cjam
            // 
            this.label_Cjam.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Cjam.AutoSize = true;
            this.label_Cjam.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Cjam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_Cjam.Location = new System.Drawing.Point(29, 67);
            this.label_Cjam.Name = "label_Cjam";
            this.label_Cjam.Size = new System.Drawing.Size(93, 19);
            this.label_Cjam.TabIndex = 42;
            this.label_Cjam.Text = "Pilih Kelas :";
            // 
            // textBox_nilai
            // 
            this.textBox_nilai.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_nilai.Location = new System.Drawing.Point(128, 102);
            this.textBox_nilai.Name = "textBox_nilai";
            this.textBox_nilai.Size = new System.Drawing.Size(135, 27);
            this.textBox_nilai.TabIndex = 39;
            // 
            // label_idSiswa
            // 
            this.label_idSiswa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_idSiswa.AutoSize = true;
            this.label_idSiswa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_idSiswa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_idSiswa.Location = new System.Drawing.Point(44, 28);
            this.label_idSiswa.Name = "label_idSiswa";
            this.label_idSiswa.Size = new System.Drawing.Size(78, 19);
            this.label_idSiswa.TabIndex = 40;
            this.label_idSiswa.Text = "ID Siswa :";
            // 
            // textBox_idSiswa
            // 
            this.textBox_idSiswa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_idSiswa.Location = new System.Drawing.Point(128, 24);
            this.textBox_idSiswa.Name = "textBox_idSiswa";
            this.textBox_idSiswa.Size = new System.Drawing.Size(135, 27);
            this.textBox_idSiswa.TabIndex = 38;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.label_kelas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 51);
            this.panel1.TabIndex = 41;
            // 
            // label_kelas
            // 
            this.label_kelas.AutoSize = true;
            this.label_kelas.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_kelas.Location = new System.Drawing.Point(370, 13);
            this.label_kelas.Name = "label_kelas";
            this.label_kelas.Size = new System.Drawing.Size(150, 25);
            this.label_kelas.TabIndex = 0;
            this.label_kelas.Text = "Manage Nilai";
            // 
            // textBox_cari
            // 
            this.textBox_cari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_cari.Location = new System.Drawing.Point(766, 58);
            this.textBox_cari.Name = "textBox_cari";
            this.textBox_cari.Size = new System.Drawing.Size(156, 27);
            this.textBox_cari.TabIndex = 42;
            this.textBox_cari.TextChanged += new System.EventHandler(this.textBox_cari_TextChanged);
            // 
            // DataGridView_nilai
            // 
            this.DataGridView_nilai.AllowUserToAddRows = false;
            this.DataGridView_nilai.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView_nilai.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_nilai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_nilai.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_nilai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_nilai.ColumnHeadersHeight = 24;
            this.DataGridView_nilai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_nilai.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_nilai.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_nilai.Location = new System.Drawing.Point(13, 93);
            this.DataGridView_nilai.Name = "DataGridView_nilai";
            this.DataGridView_nilai.RowHeadersVisible = false;
            this.DataGridView_nilai.RowHeadersWidth = 51;
            this.DataGridView_nilai.RowTemplate.Height = 80;
            this.DataGridView_nilai.Size = new System.Drawing.Size(909, 279);
            this.DataGridView_nilai.TabIndex = 39;
            this.DataGridView_nilai.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_nilai.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_nilai.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_nilai.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_nilai.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_nilai.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.DataGridView_nilai.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_nilai.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_nilai.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_nilai.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_nilai.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_nilai.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_nilai.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridView_nilai.ThemeStyle.ReadOnly = false;
            this.DataGridView_nilai.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_nilai.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_nilai.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_nilai.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_nilai.ThemeStyle.RowsStyle.Height = 80;
            this.DataGridView_nilai.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_nilai.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_nilai.Click += new System.EventHandler(this.DataGridView_nilaiSiswa_Click);
            // 
            // FormManageNilai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.label_cariKursus);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_cari);
            this.Controls.Add(this.DataGridView_nilai);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormManageNilai";
            this.Text = "Manage Nilai Siswa";
            this.Load += new System.EventHandler(this.FormManageNilai_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_nilai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_cariKursus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_kelas;
        private System.Windows.Forms.TextBox textBox_deskripsi;
        private System.Windows.Forms.Label label_Cdeskripsi;
        private System.Windows.Forms.Label label_Cjam;
        private System.Windows.Forms.TextBox textBox_nilai;
        private System.Windows.Forms.Label label_idSiswa;
        private System.Windows.Forms.TextBox textBox_idSiswa;
        private System.Windows.Forms.Button button_hapus;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_bersihkan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_kelas;
        private System.Windows.Forms.TextBox textBox_cari;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_nilai;
    }
}