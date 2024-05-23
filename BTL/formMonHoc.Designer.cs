namespace BTL
{
    partial class formMonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMonHoc));
            this.label5 = new System.Windows.Forms.Label();
            this.tbMaMon = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.cbbMaKhoa = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbSoTC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbTenMon = new System.Windows.Forms.TextBox();
            this.tbTimKiemTheoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbTimTheoKhoa = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTatCa = new System.Windows.Forms.Button();
            this.dgvSV = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.btnRefresh.SuspendLayout();
            this.btnXoa.SuspendLayout();
            this.btnSua.SuspendLayout();
            this.btnThem.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã:";
            // 
            // tbMaMon
            // 
            this.tbMaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaMon.Location = new System.Drawing.Point(88, 19);
            this.tbMaMon.Name = "tbMaMon";
            this.tbMaMon.Size = new System.Drawing.Size(185, 23);
            this.tbMaMon.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.cbbMaKhoa);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.tbSoTC);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.tbTenMon);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tbMaMon);
            this.panel2.Location = new System.Drawing.Point(796, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 420);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRefresh.Controls.Add(this.label20);
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.ForeColor = System.Drawing.Color.MistyRose;
            this.btnRefresh.Location = new System.Drawing.Point(22, 265);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(86, 37);
            this.btnRefresh.TabIndex = 31;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label20.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(8, 4);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 26);
            this.label20.TabIndex = 23;
            this.label20.Text = "Reset";
            this.label20.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoa.Controls.Add(this.label19);
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.ForeColor = System.Drawing.Color.MistyRose;
            this.btnXoa.Location = new System.Drawing.Point(185, 342);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 37);
            this.btnXoa.TabIndex = 29;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(3, 3);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 26);
            this.label19.TabIndex = 23;
            this.label19.Text = "Delete";
            this.label19.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Orange;
            this.btnSua.Controls.Add(this.label18);
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.ForeColor = System.Drawing.Color.MistyRose;
            this.btnSua.Location = new System.Drawing.Point(22, 342);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(86, 37);
            this.btnSua.TabIndex = 28;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(11, 4);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 26);
            this.label18.TabIndex = 23;
            this.label18.Text = "Edit";
            this.label18.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThem.Controls.Add(this.label15);
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.ForeColor = System.Drawing.Color.MistyRose;
            this.btnThem.Location = new System.Drawing.Point(185, 265);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 37);
            this.btnThem.TabIndex = 27;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(9, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 26);
            this.label15.TabIndex = 23;
            this.label15.Text = "Thêm";
            this.label15.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbbMaKhoa
            // 
            this.cbbMaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaKhoa.FormattingEnabled = true;
            this.cbbMaKhoa.Location = new System.Drawing.Point(88, 140);
            this.cbbMaKhoa.Name = "cbbMaKhoa";
            this.cbbMaKhoa.Size = new System.Drawing.Size(185, 24);
            this.cbbMaKhoa.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(14, 147);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 17);
            this.label16.TabIndex = 22;
            this.label16.Text = "Khoa:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(189, 265);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 17);
            this.label12.TabIndex = 14;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Số tín chỉ:";
            // 
            // tbSoTC
            // 
            this.tbSoTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoTC.Location = new System.Drawing.Point(88, 106);
            this.tbSoTC.Name = "tbSoTC";
            this.tbSoTC.Size = new System.Drawing.Size(185, 23);
            this.tbSoTC.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tên môn:";
            // 
            // tbTenMon
            // 
            this.tbTenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenMon.Location = new System.Drawing.Point(88, 61);
            this.tbTenMon.Name = "tbTenMon";
            this.tbTenMon.Size = new System.Drawing.Size(185, 23);
            this.tbTenMon.TabIndex = 9;
            // 
            // tbTimKiemTheoTen
            // 
            this.tbTimKiemTheoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimKiemTheoTen.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbTimKiemTheoTen.Location = new System.Drawing.Point(27, 26);
            this.tbTimKiemTheoTen.Name = "tbTimKiemTheoTen";
            this.tbTimKiemTheoTen.Size = new System.Drawing.Size(205, 23);
            this.tbTimKiemTheoTen.TabIndex = 0;
            this.tbTimKiemTheoTen.Enter += new System.EventHandler(this.tbTimKiemTheoTen_Enter);
            this.tbTimKiemTheoTen.Leave += new System.EventHandler(this.tbTimKiemTheoTen_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(275, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Khoa:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbbTimTheoKhoa
            // 
            this.cbbTimTheoKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTimTheoKhoa.FormattingEnabled = true;
            this.cbbTimTheoKhoa.Location = new System.Drawing.Point(278, 26);
            this.cbbTimTheoKhoa.Name = "cbbTimTheoKhoa";
            this.cbbTimTheoKhoa.Size = new System.Drawing.Size(190, 24);
            this.cbbTimTheoKhoa.TabIndex = 4;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.White;
            this.btnTimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.BackgroundImage")));
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnTimKiem.Location = new System.Drawing.Point(481, 12);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(53, 43);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnTatCa);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.cbbTimTheoKhoa);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbTimKiemTheoTen);
            this.panel1.Location = new System.Drawing.Point(447, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 72);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nhập tên hoặc mã môn:";
            // 
            // btnTatCa
            // 
            this.btnTatCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTatCa.ForeColor = System.Drawing.SystemColors.Info;
            this.btnTatCa.Location = new System.Drawing.Point(545, 15);
            this.btnTatCa.Name = "btnTatCa";
            this.btnTatCa.Size = new System.Drawing.Size(75, 35);
            this.btnTatCa.TabIndex = 6;
            this.btnTatCa.Text = "Tải lại";
            this.btnTatCa.UseVisualStyleBackColor = false;
            this.btnTatCa.Click += new System.EventHandler(this.btnTatCa_Click);
            // 
            // dgvSV
            // 
            this.dgvSV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvSV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSV.Location = new System.Drawing.Point(1, 139);
            this.dgvSV.Name = "dgvSV";
            this.dgvSV.Size = new System.Drawing.Size(796, 420);
            this.dgvSV.TabIndex = 5;
            this.dgvSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSV_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label8.Location = new System.Drawing.Point(69, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(273, 64);
            this.label8.TabIndex = 7;
            this.label8.Text = " Học Phần";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox7.Location = new System.Drawing.Point(364, 63);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(57, 65);
            this.pictureBox7.TabIndex = 8;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(6, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 65);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // formMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1102, 559);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvSV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formMonHoc";
            this.Text = "formSV";
            this.Load += new System.EventHandler(this.formSV_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.btnRefresh.ResumeLayout(false);
            this.btnRefresh.PerformLayout();
            this.btnXoa.ResumeLayout(false);
            this.btnXoa.PerformLayout();
            this.btnSua.ResumeLayout(false);
            this.btnSua.PerformLayout();
            this.btnThem.ResumeLayout(false);
            this.btnThem.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMaMon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbTenMon;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbSoTC;
        private System.Windows.Forms.ComboBox cbbMaKhoa;
        private System.Windows.Forms.Panel btnThem;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel btnXoa;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel btnSua;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbTimKiemTheoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbTimTheoKhoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvSV;
        private System.Windows.Forms.Panel btnRefresh;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnTatCa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}