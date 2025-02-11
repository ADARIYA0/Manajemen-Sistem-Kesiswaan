namespace Student_Management_System
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.label_nama = new System.Windows.Forms.Label();
            this.textBox_nama = new System.Windows.Forms.TextBox();
            this.DataGridView_murid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label_tanggalLahir = new System.Windows.Forms.Label();
            this.dateTimePicker_lahir = new System.Windows.Forms.DateTimePicker();
            this.label_jenisKelamin = new System.Windows.Forms.Label();
            this.radioButton_laki = new System.Windows.Forms.RadioButton();
            this.radioButton_perempuan = new System.Windows.Forms.RadioButton();
            this.label_alamat = new System.Windows.Forms.Label();
            this.textBox_alamat = new System.Windows.Forms.TextBox();
            this.pictureBox_murid = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_tambah = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.label_noTelp = new System.Windows.Forms.Label();
            this.textBox_telepon = new System.Windows.Forms.TextBox();
            this.button_upload = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_registrasi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_murid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_murid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_nama
            // 
            this.label_nama.AutoSize = true;
            this.label_nama.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_nama.Location = new System.Drawing.Point(21, 25);
            this.label_nama.Name = "label_nama";
            this.label_nama.Size = new System.Drawing.Size(67, 19);
            this.label_nama.TabIndex = 1;
            this.label_nama.Text = "Nama :";
            // 
            // textBox_nama
            // 
            this.textBox_nama.Location = new System.Drawing.Point(94, 21);
            this.textBox_nama.Name = "textBox_nama";
            this.textBox_nama.Size = new System.Drawing.Size(419, 27);
            this.textBox_nama.TabIndex = 2;
            // 
            // DataGridView_murid
            // 
            this.DataGridView_murid.AllowUserToAddRows = false;
            this.DataGridView_murid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView_murid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_murid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_murid.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_murid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_murid.ColumnHeadersHeight = 24;
            this.DataGridView_murid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_murid.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_murid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_murid.Location = new System.Drawing.Point(13, 57);
            this.DataGridView_murid.Name = "DataGridView_murid";
            this.DataGridView_murid.RowHeadersVisible = false;
            this.DataGridView_murid.RowHeadersWidth = 51;
            this.DataGridView_murid.RowTemplate.Height = 80;
            this.DataGridView_murid.Size = new System.Drawing.Size(909, 291);
            this.DataGridView_murid.TabIndex = 2;
            this.DataGridView_murid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_murid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_murid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_murid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_murid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_murid.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.DataGridView_murid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_murid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_murid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_murid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_murid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_murid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_murid.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridView_murid.ThemeStyle.ReadOnly = false;
            this.DataGridView_murid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_murid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_murid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_murid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_murid.ThemeStyle.RowsStyle.Height = 80;
            this.DataGridView_murid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_murid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label_tanggalLahir
            // 
            this.label_tanggalLahir.AutoSize = true;
            this.label_tanggalLahir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tanggalLahir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_tanggalLahir.Location = new System.Drawing.Point(21, 76);
            this.label_tanggalLahir.Name = "label_tanggalLahir";
            this.label_tanggalLahir.Size = new System.Drawing.Size(123, 19);
            this.label_tanggalLahir.TabIndex = 5;
            this.label_tanggalLahir.Text = "Tanggal Lahir :";
            // 
            // dateTimePicker_lahir
            // 
            this.dateTimePicker_lahir.Location = new System.Drawing.Point(150, 72);
            this.dateTimePicker_lahir.Name = "dateTimePicker_lahir";
            this.dateTimePicker_lahir.Size = new System.Drawing.Size(291, 27);
            this.dateTimePicker_lahir.TabIndex = 6;
            // 
            // label_jenisKelamin
            // 
            this.label_jenisKelamin.AutoSize = true;
            this.label_jenisKelamin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_jenisKelamin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_jenisKelamin.Location = new System.Drawing.Point(462, 76);
            this.label_jenisKelamin.Name = "label_jenisKelamin";
            this.label_jenisKelamin.Size = new System.Drawing.Size(124, 19);
            this.label_jenisKelamin.TabIndex = 7;
            this.label_jenisKelamin.Text = "Jenis Kelamin :";
            // 
            // radioButton_laki
            // 
            this.radioButton_laki.AutoSize = true;
            this.radioButton_laki.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_laki.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.radioButton_laki.Location = new System.Drawing.Point(592, 74);
            this.radioButton_laki.Name = "radioButton_laki";
            this.radioButton_laki.Size = new System.Drawing.Size(58, 23);
            this.radioButton_laki.TabIndex = 8;
            this.radioButton_laki.TabStop = true;
            this.radioButton_laki.Text = "Laki";
            this.radioButton_laki.UseVisualStyleBackColor = true;
            // 
            // radioButton_perempuan
            // 
            this.radioButton_perempuan.AutoSize = true;
            this.radioButton_perempuan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_perempuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.radioButton_perempuan.Location = new System.Drawing.Point(656, 74);
            this.radioButton_perempuan.Name = "radioButton_perempuan";
            this.radioButton_perempuan.Size = new System.Drawing.Size(119, 23);
            this.radioButton_perempuan.TabIndex = 9;
            this.radioButton_perempuan.TabStop = true;
            this.radioButton_perempuan.Text = "Perempuan";
            this.radioButton_perempuan.UseVisualStyleBackColor = true;
            // 
            // label_alamat
            // 
            this.label_alamat.AutoSize = true;
            this.label_alamat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_alamat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_alamat.Location = new System.Drawing.Point(21, 124);
            this.label_alamat.Name = "label_alamat";
            this.label_alamat.Size = new System.Drawing.Size(75, 19);
            this.label_alamat.TabIndex = 10;
            this.label_alamat.Text = "Alamat :";
            // 
            // textBox_alamat
            // 
            this.textBox_alamat.Location = new System.Drawing.Point(102, 124);
            this.textBox_alamat.Multiline = true;
            this.textBox_alamat.Name = "textBox_alamat";
            this.textBox_alamat.Size = new System.Drawing.Size(658, 50);
            this.textBox_alamat.TabIndex = 11;
            // 
            // pictureBox_murid
            // 
            this.pictureBox_murid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_murid.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox_murid.Location = new System.Drawing.Point(807, 22);
            this.pictureBox_murid.Name = "pictureBox_murid";
            this.pictureBox_murid.Size = new System.Drawing.Size(118, 110);
            this.pictureBox_murid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_murid.TabIndex = 12;
            this.pictureBox_murid.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_tambah);
            this.panel1.Controls.Add(this.button_clear);
            this.panel1.Controls.Add(this.label_noTelp);
            this.panel1.Controls.Add(this.textBox_telepon);
            this.panel1.Controls.Add(this.button_upload);
            this.panel1.Controls.Add(this.pictureBox_murid);
            this.panel1.Controls.Add(this.label_nama);
            this.panel1.Controls.Add(this.textBox_alamat);
            this.panel1.Controls.Add(this.textBox_nama);
            this.panel1.Controls.Add(this.label_alamat);
            this.panel1.Controls.Add(this.radioButton_perempuan);
            this.panel1.Controls.Add(this.radioButton_laki);
            this.panel1.Controls.Add(this.label_tanggalLahir);
            this.panel1.Controls.Add(this.label_jenisKelamin);
            this.panel1.Controls.Add(this.dateTimePicker_lahir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 354);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 259);
            this.panel1.TabIndex = 13;
            // 
            // button_tambah
            // 
            this.button_tambah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_tambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button_tambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_tambah.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tambah.ForeColor = System.Drawing.Color.White;
            this.button_tambah.Location = new System.Drawing.Point(808, 212);
            this.button_tambah.Name = "button_tambah";
            this.button_tambah.Size = new System.Drawing.Size(118, 39);
            this.button_tambah.TabIndex = 32;
            this.button_tambah.Text = "Tambah";
            this.button_tambah.UseVisualStyleBackColor = false;
            this.button_tambah.Click += new System.EventHandler(this.button_tambah_Click);
            // 
            // button_clear
            // 
            this.button_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear.BackColor = System.Drawing.Color.Orange;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.ForeColor = System.Drawing.Color.White;
            this.button_clear.Location = new System.Drawing.Point(684, 212);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(118, 39);
            this.button_clear.TabIndex = 31;
            this.button_clear.Text = "Bersihkan";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // label_noTelp
            // 
            this.label_noTelp.AutoSize = true;
            this.label_noTelp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_noTelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_noTelp.Location = new System.Drawing.Point(519, 25);
            this.label_noTelp.Name = "label_noTelp";
            this.label_noTelp.Size = new System.Drawing.Size(79, 19);
            this.label_noTelp.TabIndex = 29;
            this.label_noTelp.Text = "No. Telp :";
            // 
            // textBox_telepon
            // 
            this.textBox_telepon.Location = new System.Drawing.Point(604, 21);
            this.textBox_telepon.Name = "textBox_telepon";
            this.textBox_telepon.Size = new System.Drawing.Size(156, 27);
            this.textBox_telepon.TabIndex = 30;
            // 
            // button_upload
            // 
            this.button_upload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_upload.BackColor = System.Drawing.Color.Green;
            this.button_upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_upload.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_upload.ForeColor = System.Drawing.Color.White;
            this.button_upload.Location = new System.Drawing.Point(807, 138);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(118, 39);
            this.button_upload.TabIndex = 28;
            this.button_upload.Text = "Upload";
            this.button_upload.UseVisualStyleBackColor = false;
            this.button_upload.Click += new System.EventHandler(this.button_upload_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Controls.Add(this.label_registrasi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 51);
            this.panel2.TabIndex = 14;
            // 
            // label_registrasi
            // 
            this.label_registrasi.AutoSize = true;
            this.label_registrasi.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_registrasi.Location = new System.Drawing.Point(417, 13);
            this.label_registrasi.Name = "label_registrasi";
            this.label_registrasi.Size = new System.Drawing.Size(106, 25);
            this.label_registrasi.TabIndex = 0;
            this.label_registrasi.Text = "Registrasi";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 613);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DataGridView_murid);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "RegisterForm";
            this.Text = "Registrasi Murid";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_murid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_murid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_nama;
        private System.Windows.Forms.TextBox textBox_nama;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_murid;
        private System.Windows.Forms.Label label_tanggalLahir;
        private System.Windows.Forms.DateTimePicker dateTimePicker_lahir;
        private System.Windows.Forms.Label label_jenisKelamin;
        private System.Windows.Forms.RadioButton radioButton_laki;
        private System.Windows.Forms.RadioButton radioButton_perempuan;
        private System.Windows.Forms.Label label_alamat;
        private System.Windows.Forms.TextBox textBox_alamat;
        private System.Windows.Forms.PictureBox pictureBox_murid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_upload;
        private System.Windows.Forms.Label label_noTelp;
        private System.Windows.Forms.TextBox textBox_telepon;
        private System.Windows.Forms.Button button_tambah;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_registrasi;
    }
}