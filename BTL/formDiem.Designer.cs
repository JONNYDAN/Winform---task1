namespace BTL
{
    partial class formDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDiem));
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMaLop = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbDiemGK = new System.Windows.Forms.TextBox();
            this.tbDiemThi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbMaSV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDiemCC = new System.Windows.Forms.TextBox();
            this.tbTimKiemTheoMa = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTatCa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.btnRefresh.SuspendLayout();
            this.btnXoa.SuspendLayout();
            this.btnSua.SuspendLayout();
            this.btnThem.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Location = new System.Drawing.Point(119, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý Điểm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã Lớp:";
            // 
            // tbMaLop
            // 
            this.tbMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaLop.Location = new System.Drawing.Point(88, 20);
            this.tbMaLop.Name = "tbMaLop";
            this.tbMaLop.Size = new System.Drawing.Size(185, 23);
            this.tbMaLop.TabIndex = 3;
            this.tbMaLop.TextChanged += new System.EventHandler(this.tbMaLop_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.tbDiemGK);
            this.panel2.Controls.Add(this.tbDiemThi);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.tbMaSV);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.tbDiemCC);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tbMaLop);
            this.panel2.Location = new System.Drawing.Point(793, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 420);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tbDiemGK
            // 
            this.tbDiemGK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiemGK.Location = new System.Drawing.Point(145, 143);
            this.tbDiemGK.Name = "tbDiemGK";
            this.tbDiemGK.Size = new System.Drawing.Size(128, 23);
            this.tbDiemGK.TabIndex = 36;
            this.tbDiemGK.Text = "0";
            this.tbDiemGK.TextChanged += new System.EventHandler(this.tbDiemGK_TextChanged);
            // 
            // tbDiemThi
            // 
            this.tbDiemThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiemThi.Location = new System.Drawing.Point(145, 182);
            this.tbDiemThi.Name = "tbDiemThi";
            this.tbDiemThi.Size = new System.Drawing.Size(128, 23);
            this.tbDiemThi.TabIndex = 35;
            this.tbDiemThi.Text = "0";
            this.tbDiemThi.TextChanged += new System.EventHandler(this.tbDiemThi_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 34;
            this.label8.Text = "Điểm Giữa Kỳ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "Điểm Thi:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRefresh.Controls.Add(this.label6);
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.ForeColor = System.Drawing.Color.MistyRose;
            this.btnRefresh.Location = new System.Drawing.Point(31, 295);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(81, 37);
            this.btnRefresh.TabIndex = 31;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            this.btnRefresh.Paint += new System.Windows.Forms.PaintEventHandler(this.btnRefresh_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(9, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 24);
            this.label6.TabIndex = 38;
            this.label6.Text = "Reset";
            this.label6.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXoa.Controls.Add(this.label10);
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.ForeColor = System.Drawing.Color.MistyRose;
            this.btnXoa.Location = new System.Drawing.Point(192, 354);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(81, 37);
            this.btnXoa.TabIndex = 29;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            this.btnXoa.Paint += new System.Windows.Forms.PaintEventHandler(this.btnXoa_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(8, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 24);
            this.label10.TabIndex = 38;
            this.label10.Text = "Delete";
            this.label10.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Orange;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSua.Controls.Add(this.label14);
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.ForeColor = System.Drawing.Color.MistyRose;
            this.btnSua.Location = new System.Drawing.Point(31, 354);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(81, 37);
            this.btnSua.TabIndex = 28;
            this.btnSua.Tag = "";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            this.btnSua.Paint += new System.Windows.Forms.PaintEventHandler(this.btnSua_Paint);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Location = new System.Drawing.Point(17, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 24);
            this.label14.TabIndex = 39;
            this.label14.Text = "Edit";
            this.label14.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThem.Controls.Add(this.label13);
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.ForeColor = System.Drawing.Color.MistyRose;
            this.btnThem.Location = new System.Drawing.Point(192, 295);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(81, 37);
            this.btnThem.TabIndex = 27;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnThem.Paint += new System.Windows.Forms.PaintEventHandler(this.btnThem_Paint);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Location = new System.Drawing.Point(16, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 24);
            this.label13.TabIndex = 39;
            this.label13.Text = "Add";
            this.label13.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(241, 387);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 17);
            this.label12.TabIndex = 14;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Mã SV:";
            // 
            // tbMaSV
            // 
            this.tbMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaSV.Location = new System.Drawing.Point(88, 61);
            this.tbMaSV.Name = "tbMaSV";
            this.tbMaSV.Size = new System.Drawing.Size(185, 23);
            this.tbMaSV.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Điểm Chuyên Cần:";
            // 
            // tbDiemCC
            // 
            this.tbDiemCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiemCC.Location = new System.Drawing.Point(145, 100);
            this.tbDiemCC.Name = "tbDiemCC";
            this.tbDiemCC.Size = new System.Drawing.Size(128, 23);
            this.tbDiemCC.TabIndex = 9;
            this.tbDiemCC.Text = "0";
            this.tbDiemCC.TextChanged += new System.EventHandler(this.tbDiemCC_TextChanged);
            // 
            // tbTimKiemTheoMa
            // 
            this.tbTimKiemTheoMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimKiemTheoMa.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbTimKiemTheoMa.Location = new System.Drawing.Point(28, 20);
            this.tbTimKiemTheoMa.Name = "tbTimKiemTheoMa";
            this.tbTimKiemTheoMa.Size = new System.Drawing.Size(313, 23);
            this.tbTimKiemTheoMa.TabIndex = 0;
            this.tbTimKiemTheoMa.Enter += new System.EventHandler(this.tbTimKiemTheoTen_Enter);
            this.tbTimKiemTheoMa.Leave += new System.EventHandler(this.tbTimKiemTheoTen_Leave);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.MintCream;
            this.btnTimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.BackgroundImage")));
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnTimKiem.Location = new System.Drawing.Point(358, 10);
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
            this.panel1.Controls.Add(this.btnTatCa);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.tbTimKiemTheoMa);
            this.panel1.Location = new System.Drawing.Point(592, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 71);
            this.panel1.TabIndex = 1;
            // 
            // btnTatCa
            // 
            this.btnTatCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTatCa.ForeColor = System.Drawing.SystemColors.Info;
            this.btnTatCa.Location = new System.Drawing.Point(417, 13);
            this.btnTatCa.Name = "btnTatCa";
            this.btnTatCa.Size = new System.Drawing.Size(75, 35);
            this.btnTatCa.TabIndex = 36;
            this.btnTatCa.Text = "Tải lại";
            this.btnTatCa.UseVisualStyleBackColor = false;
            this.btnTatCa.Click += new System.EventHandler(this.btnTatCa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nhập mã Lớp:";
            // 
            // dgvDiem
            // 
            this.dgvDiem.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiem.Location = new System.Drawing.Point(1, 137);
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.Size = new System.Drawing.Size(793, 420);
            this.dgvDiem.TabIndex = 5;
            this.dgvDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSV_CellClick);
            this.dgvDiem.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dgvDiem_SortCompare);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox7.Location = new System.Drawing.Point(37, 49);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(57, 65);
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(472, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 65);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // formDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1102, 559);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.dgvDiem);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formDiem";
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMaLop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbDiemCC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbMaSV;
        private System.Windows.Forms.Panel btnThem;
        private System.Windows.Forms.Panel btnXoa;
        private System.Windows.Forms.Panel btnSua;
        private System.Windows.Forms.TextBox tbTimKiemTheoMa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDiem;
        private System.Windows.Forms.Panel btnRefresh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDiemGK;
        private System.Windows.Forms.TextBox tbDiemThi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTatCa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}