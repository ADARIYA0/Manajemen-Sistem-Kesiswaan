namespace SistemManajemenSekolah
{
    partial class FormManageSiswa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageSiswa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_registrasi = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_update = new System.Windows.Forms.Button();
            this.button_bersihkan = new System.Windows.Forms.Button();
            this.label_noTelp = new System.Windows.Forms.Label();
            this.textBox_telepon = new System.Windows.Forms.TextBox();
            this.button_upload = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button_hapus = new System.Windows.Forms.Button();
            this.pictureBox_murid = new System.Windows.Forms.PictureBox();
            this.label_nama = new System.Windows.Forms.Label();
            this.textBox_alamat = new System.Windows.Forms.TextBox();
            this.textBox_nama = new System.Windows.Forms.TextBox();
            this.label_alamat = new System.Windows.Forms.Label();
            this.radioButton_perempuan = new System.Windows.Forms.RadioButton();
            this.radioButton_laki = new System.Windows.Forms.RadioButton();
            this.label_tanggalLahir = new System.Windows.Forms.Label();
            this.label_jenisKelamin = new System.Windows.Forms.Label();
            this.dateTimePicker_lahir = new System.Windows.Forms.DateTimePicker();
            this.DataGridView_siswa = new Guna.UI2.WinForms.Guna2DataGridView();
            this.textBox_cari = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_murid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_siswa)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.label_registrasi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 51);
            this.panel1.TabIndex = 17;
            // 
            // label_registrasi
            // 
            this.label_registrasi.AutoSize = true;
            this.label_registrasi.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_registrasi.Location = new System.Drawing.Point(370, 13);
            this.label_registrasi.Name = "label_registrasi";
            this.label_registrasi.Size = new System.Drawing.Size(161, 25);
            this.label_registrasi.TabIndex = 0;
            this.label_registrasi.Text = "Manage Siswa";
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
            this.button_update.TabIndex = 8;
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
            this.button_bersihkan.TabIndex = 7;
            this.button_bersihkan.Text = "Bersihkan";
            this.button_bersihkan.UseVisualStyleBackColor = false;
            this.button_bersihkan.Click += new System.EventHandler(this.button_bersihkan_Click);
            // 
            // label_noTelp
            // 
            this.label_noTelp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_noTelp.AutoSize = true;
            this.label_noTelp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_noTelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_noTelp.Location = new System.Drawing.Point(519, 21);
            this.label_noTelp.Name = "label_noTelp";
            this.label_noTelp.Size = new System.Drawing.Size(79, 19);
            this.label_noTelp.TabIndex = 29;
            this.label_noTelp.Text = "No. Telp :";
            // 
            // textBox_telepon
            // 
            this.textBox_telepon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_telepon.Location = new System.Drawing.Point(604, 17);
            this.textBox_telepon.Name = "textBox_telepon";
            this.textBox_telepon.Size = new System.Drawing.Size(156, 27);
            this.textBox_telepon.TabIndex = 1;
            // 
            // button_upload
            // 
            this.button_upload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_upload.BackColor = System.Drawing.Color.Green;
            this.button_upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_upload.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_upload.ForeColor = System.Drawing.Color.White;
            this.button_upload.Location = new System.Drawing.Point(804, 133);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(118, 39);
            this.button_upload.TabIndex = 6;
            this.button_upload.Text = "Upload";
            this.button_upload.UseVisualStyleBackColor = false;
            this.button_upload.Click += new System.EventHandler(this.button_upload_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox_id);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.button_hapus);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button_update);
            this.panel2.Controls.Add(this.button_bersihkan);
            this.panel2.Controls.Add(this.label_noTelp);
            this.panel2.Controls.Add(this.textBox_telepon);
            this.panel2.Controls.Add(this.button_upload);
            this.panel2.Controls.Add(this.pictureBox_murid);
            this.panel2.Controls.Add(this.label_nama);
            this.panel2.Controls.Add(this.textBox_alamat);
            this.panel2.Controls.Add(this.textBox_nama);
            this.panel2.Controls.Add(this.label_alamat);
            this.panel2.Controls.Add(this.radioButton_perempuan);
            this.panel2.Controls.Add(this.radioButton_laki);
            this.panel2.Controls.Add(this.label_tanggalLahir);
            this.panel2.Controls.Add(this.label_jenisKelamin);
            this.panel2.Controls.Add(this.dateTimePicker_lahir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 376);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 235);
            this.panel2.TabIndex = 16;
            // 
            // textBox_id
            // 
            this.textBox_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_id.Location = new System.Drawing.Point(652, 101);
            this.textBox_id.Multiline = true;
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(85, 50);
            this.textBox_id.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label8.Location = new System.Drawing.Point(588, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 19);
            this.label8.TabIndex = 35;
            this.label8.Text = "ID No :";
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
            this.button_hapus.TabIndex = 34;
            this.button_hapus.Text = "Hapus";
            this.button_hapus.UseVisualStyleBackColor = false;
            this.button_hapus.Click += new System.EventHandler(this.button_hapus_Click);
            // 
            // pictureBox_murid
            // 
            this.pictureBox_murid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_murid.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox_murid.Location = new System.Drawing.Point(804, 17);
            this.pictureBox_murid.Name = "pictureBox_murid";
            this.pictureBox_murid.Size = new System.Drawing.Size(118, 110);
            this.pictureBox_murid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_murid.TabIndex = 12;
            this.pictureBox_murid.TabStop = false;
            // 
            // label_nama
            // 
            this.label_nama.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_nama.AutoSize = true;
            this.label_nama.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_nama.Location = new System.Drawing.Point(21, 21);
            this.label_nama.Name = "label_nama";
            this.label_nama.Size = new System.Drawing.Size(67, 19);
            this.label_nama.TabIndex = 1;
            this.label_nama.Text = "Nama :";
            // 
            // textBox_alamat
            // 
            this.textBox_alamat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_alamat.Location = new System.Drawing.Point(102, 101);
            this.textBox_alamat.Multiline = true;
            this.textBox_alamat.Name = "textBox_alamat";
            this.textBox_alamat.Size = new System.Drawing.Size(458, 50);
            this.textBox_alamat.TabIndex = 5;
            // 
            // textBox_nama
            // 
            this.textBox_nama.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_nama.Location = new System.Drawing.Point(94, 17);
            this.textBox_nama.Name = "textBox_nama";
            this.textBox_nama.Size = new System.Drawing.Size(419, 27);
            this.textBox_nama.TabIndex = 0;
            // 
            // label_alamat
            // 
            this.label_alamat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_alamat.AutoSize = true;
            this.label_alamat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_alamat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_alamat.Location = new System.Drawing.Point(21, 101);
            this.label_alamat.Name = "label_alamat";
            this.label_alamat.Size = new System.Drawing.Size(75, 19);
            this.label_alamat.TabIndex = 10;
            this.label_alamat.Text = "Alamat :";
            // 
            // radioButton_perempuan
            // 
            this.radioButton_perempuan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_perempuan.AutoSize = true;
            this.radioButton_perempuan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_perempuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.radioButton_perempuan.Location = new System.Drawing.Point(656, 62);
            this.radioButton_perempuan.Name = "radioButton_perempuan";
            this.radioButton_perempuan.Size = new System.Drawing.Size(119, 23);
            this.radioButton_perempuan.TabIndex = 4;
            this.radioButton_perempuan.Text = "Perempuan";
            this.radioButton_perempuan.UseVisualStyleBackColor = true;
            // 
            // radioButton_laki
            // 
            this.radioButton_laki.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton_laki.AutoSize = true;
            this.radioButton_laki.Checked = true;
            this.radioButton_laki.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_laki.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.radioButton_laki.Location = new System.Drawing.Point(592, 62);
            this.radioButton_laki.Name = "radioButton_laki";
            this.radioButton_laki.Size = new System.Drawing.Size(58, 23);
            this.radioButton_laki.TabIndex = 3;
            this.radioButton_laki.TabStop = true;
            this.radioButton_laki.Text = "Laki";
            this.radioButton_laki.UseVisualStyleBackColor = true;
            // 
            // label_tanggalLahir
            // 
            this.label_tanggalLahir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_tanggalLahir.AutoSize = true;
            this.label_tanggalLahir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tanggalLahir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_tanggalLahir.Location = new System.Drawing.Point(21, 64);
            this.label_tanggalLahir.Name = "label_tanggalLahir";
            this.label_tanggalLahir.Size = new System.Drawing.Size(123, 19);
            this.label_tanggalLahir.TabIndex = 5;
            this.label_tanggalLahir.Text = "Tanggal Lahir :";
            // 
            // label_jenisKelamin
            // 
            this.label_jenisKelamin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_jenisKelamin.AutoSize = true;
            this.label_jenisKelamin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_jenisKelamin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label_jenisKelamin.Location = new System.Drawing.Point(462, 64);
            this.label_jenisKelamin.Name = "label_jenisKelamin";
            this.label_jenisKelamin.Size = new System.Drawing.Size(124, 19);
            this.label_jenisKelamin.TabIndex = 7;
            this.label_jenisKelamin.Text = "Jenis Kelamin :";
            // 
            // dateTimePicker_lahir
            // 
            this.dateTimePicker_lahir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_lahir.Location = new System.Drawing.Point(150, 60);
            this.dateTimePicker_lahir.Name = "dateTimePicker_lahir";
            this.dateTimePicker_lahir.Size = new System.Drawing.Size(291, 27);
            this.dateTimePicker_lahir.TabIndex = 2;
            // 
            // DataGridView_siswa
            // 
            this.DataGridView_siswa.AllowUserToAddRows = false;
            this.DataGridView_siswa.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView_siswa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_siswa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView_siswa.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_siswa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_siswa.ColumnHeadersHeight = 24;
            this.DataGridView_siswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_siswa.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_siswa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_siswa.Location = new System.Drawing.Point(13, 93);
            this.DataGridView_siswa.Name = "DataGridView_siswa";
            this.DataGridView_siswa.RowHeadersVisible = false;
            this.DataGridView_siswa.RowHeadersWidth = 51;
            this.DataGridView_siswa.RowTemplate.Height = 80;
            this.DataGridView_siswa.Size = new System.Drawing.Size(909, 279);
            this.DataGridView_siswa.TabIndex = 15;
            this.DataGridView_siswa.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_siswa.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_siswa.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_siswa.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_siswa.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_siswa.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.DataGridView_siswa.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_siswa.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_siswa.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_siswa.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_siswa.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_siswa.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_siswa.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridView_siswa.ThemeStyle.ReadOnly = false;
            this.DataGridView_siswa.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_siswa.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_siswa.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView_siswa.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_siswa.ThemeStyle.RowsStyle.Height = 80;
            this.DataGridView_siswa.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_siswa.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_siswa.Click += new System.EventHandler(this.DataGridView_murid_Click);
            // 
            // textBox_cari
            // 
            this.textBox_cari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_cari.Location = new System.Drawing.Point(766, 58);
            this.textBox_cari.Name = "textBox_cari";
            this.textBox_cari.Size = new System.Drawing.Size(156, 27);
            this.textBox_cari.TabIndex = 35;
            this.textBox_cari.TextChanged += new System.EventHandler(this.textBox_cari_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(609, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 21);
            this.label1.TabIndex = 36;
            this.label1.Text = "Cari Nama Murid :";
            // 
            // FormManageSiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_cari);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DataGridView_siswa);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormManageSiswa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Siswa";
            this.Load += new System.EventHandler(this.ManageStudentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_murid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_siswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_murid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_registrasi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_bersihkan;
        private System.Windows.Forms.Label label_noTelp;
        private System.Windows.Forms.TextBox textBox_telepon;
        private System.Windows.Forms.Button button_upload;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_nama;
        private System.Windows.Forms.TextBox textBox_alamat;
        private System.Windows.Forms.TextBox textBox_nama;
        private System.Windows.Forms.Label label_alamat;
        private System.Windows.Forms.RadioButton radioButton_perempuan;
        private System.Windows.Forms.RadioButton radioButton_laki;
        private System.Windows.Forms.Label label_tanggalLahir;
        private System.Windows.Forms.Label label_jenisKelamin;
        private System.Windows.Forms.DateTimePicker dateTimePicker_lahir;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_siswa;
        private System.Windows.Forms.Button button_hapus;
        private System.Windows.Forms.TextBox textBox_cari;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label1;
    }
}