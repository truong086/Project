namespace BAITAPLONS
{
    partial class FormMai
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
            this.components = new System.ComponentModel.Container();
            this.sinhvien = new System.Windows.Forms.Button();
            this.TKNH = new System.Windows.Forms.Button();
            this.phieuthu = new System.Windows.Forms.Button();
            this.taikhoan = new System.Windows.Forms.Button();
            this.taikhoanNT = new System.Windows.Forms.Button();
            this.lop = new System.Windows.Forms.Button();
            this.khoa = new System.Windows.Forms.Button();
            this.nganh = new System.Windows.Forms.Button();
            this.doituong = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.monhoc = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.svdb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.svk14 = new System.Windows.Forms.Button();
            this.cdhp = new System.Windows.Forms.Button();
            this.svcntt = new System.Windows.Forms.Button();
            this.svk15 = new System.Windows.Forms.Button();
            this.svk16 = new System.Windows.Forms.Button();
            this.nganhcntt = new System.Windows.Forms.Button();
            this.dulichs = new System.Windows.Forms.Button();
            this.luats = new System.Windows.Forms.Button();
            this.qtkds = new System.Windows.Forms.Button();
            this.quyen = new System.Windows.Forms.Button();
            this.ten = new System.Windows.Forms.Button();
            this.khoahocs = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lichsu = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.Button();
            this.gvcns = new System.Windows.Forms.Button();
            this.thacmac = new System.Windows.Forms.Button();
            this.phanhoi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.donghocphi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sinhvien
            // 
            this.sinhvien.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sinhvien.Location = new System.Drawing.Point(28, 389);
            this.sinhvien.Name = "sinhvien";
            this.sinhvien.Size = new System.Drawing.Size(117, 46);
            this.sinhvien.TabIndex = 0;
            this.sinhvien.Text = "Sinh viên";
            this.sinhvien.UseVisualStyleBackColor = false;
            this.sinhvien.Click += new System.EventHandler(this.sinhvien_Click);
            // 
            // TKNH
            // 
            this.TKNH.Location = new System.Drawing.Point(163, 516);
            this.TKNH.Name = "TKNH";
            this.TKNH.Size = new System.Drawing.Size(113, 46);
            this.TKNH.TabIndex = 1;
            this.TKNH.Text = "Tài khoản ngân hàng sinh viên";
            this.TKNH.UseVisualStyleBackColor = true;
            this.TKNH.Click += new System.EventHandler(this.gvcn_Click);
            // 
            // phieuthu
            // 
            this.phieuthu.Location = new System.Drawing.Point(28, 516);
            this.phieuthu.Name = "phieuthu";
            this.phieuthu.Size = new System.Drawing.Size(117, 46);
            this.phieuthu.TabIndex = 2;
            this.phieuthu.Text = "Phiếu thu";
            this.phieuthu.UseVisualStyleBackColor = true;
            this.phieuthu.Click += new System.EventHandler(this.phieuthu_Click);
            // 
            // taikhoan
            // 
            this.taikhoan.Location = new System.Drawing.Point(293, 455);
            this.taikhoan.Name = "taikhoan";
            this.taikhoan.Size = new System.Drawing.Size(107, 46);
            this.taikhoan.TabIndex = 3;
            this.taikhoan.Text = "Tài khoản";
            this.taikhoan.UseVisualStyleBackColor = true;
            this.taikhoan.Click += new System.EventHandler(this.namhoc_Click);
            // 
            // taikhoanNT
            // 
            this.taikhoanNT.Location = new System.Drawing.Point(293, 516);
            this.taikhoanNT.Name = "taikhoanNT";
            this.taikhoanNT.Size = new System.Drawing.Size(110, 46);
            this.taikhoanNT.TabIndex = 4;
            this.taikhoanNT.Text = "Tài khoản nhận tiền học phí";
            this.taikhoanNT.UseVisualStyleBackColor = true;
            this.taikhoanNT.Click += new System.EventHandler(this.mucthu_Click);
            // 
            // lop
            // 
            this.lop.Location = new System.Drawing.Point(163, 389);
            this.lop.Name = "lop";
            this.lop.Size = new System.Drawing.Size(113, 46);
            this.lop.TabIndex = 5;
            this.lop.Text = "Lớp";
            this.lop.UseVisualStyleBackColor = true;
            this.lop.Click += new System.EventHandler(this.lop_Click);
            // 
            // khoa
            // 
            this.khoa.Location = new System.Drawing.Point(163, 455);
            this.khoa.Name = "khoa";
            this.khoa.Size = new System.Drawing.Size(113, 46);
            this.khoa.TabIndex = 6;
            this.khoa.Text = "Khoa";
            this.khoa.UseVisualStyleBackColor = true;
            this.khoa.Click += new System.EventHandler(this.khoa_Click);
            // 
            // nganh
            // 
            this.nganh.Location = new System.Drawing.Point(293, 389);
            this.nganh.Name = "nganh";
            this.nganh.Size = new System.Drawing.Size(107, 46);
            this.nganh.TabIndex = 7;
            this.nganh.Text = "Ngành";
            this.nganh.UseVisualStyleBackColor = true;
            this.nganh.Click += new System.EventHandler(this.nganh_Click);
            // 
            // doituong
            // 
            this.doituong.Location = new System.Drawing.Point(28, 581);
            this.doituong.Name = "doituong";
            this.doituong.Size = new System.Drawing.Size(117, 46);
            this.doituong.TabIndex = 8;
            this.doituong.Text = "Đối tượng";
            this.doituong.UseVisualStyleBackColor = true;
            this.doituong.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1212, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 45);
            this.button2.TabIndex = 9;
            this.button2.Text = "Đăng xuất";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // monhoc
            // 
            this.monhoc.Location = new System.Drawing.Point(28, 455);
            this.monhoc.Name = "monhoc";
            this.monhoc.Size = new System.Drawing.Size(117, 46);
            this.monhoc.TabIndex = 10;
            this.monhoc.Text = "Môn học";
            this.monhoc.UseVisualStyleBackColor = true;
            this.monhoc.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1354, 30);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(212, 28);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(211, 24);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(225, 26);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // svdb
            // 
            this.svdb.Location = new System.Drawing.Point(954, 389);
            this.svdb.Name = "svdb";
            this.svdb.Size = new System.Drawing.Size(117, 46);
            this.svdb.TabIndex = 13;
            this.svdb.Text = "Sinh viên đặc biệt";
            this.svdb.UseVisualStyleBackColor = true;
            this.svdb.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(198, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(931, 58);
            this.label1.TabIndex = 14;
            this.label1.Text = "QUẢN LÝ HỆ THỐNG ĐÓNG HỌC PHÍ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // svk14
            // 
            this.svk14.Location = new System.Drawing.Point(954, 460);
            this.svk14.Name = "svk14";
            this.svk14.Size = new System.Drawing.Size(117, 46);
            this.svk14.TabIndex = 15;
            this.svk14.Text = "Sinh viên khóa 14";
            this.svk14.UseVisualStyleBackColor = true;
            this.svk14.Click += new System.EventHandler(this.button4_Click);
            // 
            // cdhp
            // 
            this.cdhp.Location = new System.Drawing.Point(1223, 389);
            this.cdhp.Name = "cdhp";
            this.cdhp.Size = new System.Drawing.Size(111, 46);
            this.cdhp.TabIndex = 16;
            this.cdhp.Text = "Chưa đóng học phí";
            this.cdhp.UseVisualStyleBackColor = true;
            this.cdhp.Click += new System.EventHandler(this.button5_Click);
            // 
            // svcntt
            // 
            this.svcntt.Location = new System.Drawing.Point(1091, 389);
            this.svcntt.Name = "svcntt";
            this.svcntt.Size = new System.Drawing.Size(117, 46);
            this.svcntt.TabIndex = 17;
            this.svcntt.Text = "Sinh viên CNTT";
            this.svcntt.UseVisualStyleBackColor = true;
            this.svcntt.Click += new System.EventHandler(this.button6_Click);
            // 
            // svk15
            // 
            this.svk15.Location = new System.Drawing.Point(1091, 460);
            this.svk15.Name = "svk15";
            this.svk15.Size = new System.Drawing.Size(117, 46);
            this.svk15.TabIndex = 18;
            this.svk15.Text = "Sinh viên khóa 15";
            this.svk15.UseVisualStyleBackColor = true;
            this.svk15.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // svk16
            // 
            this.svk16.Location = new System.Drawing.Point(1223, 460);
            this.svk16.Name = "svk16";
            this.svk16.Size = new System.Drawing.Size(110, 46);
            this.svk16.TabIndex = 19;
            this.svk16.Text = "Sinh viên khóa 16";
            this.svk16.UseVisualStyleBackColor = true;
            this.svk16.Click += new System.EventHandler(this.svk16_Click);
            // 
            // nganhcntt
            // 
            this.nganhcntt.Location = new System.Drawing.Point(954, 531);
            this.nganhcntt.Name = "nganhcntt";
            this.nganhcntt.Size = new System.Drawing.Size(117, 46);
            this.nganhcntt.TabIndex = 20;
            this.nganhcntt.Text = "Ngành CNTT";
            this.nganhcntt.UseVisualStyleBackColor = true;
            this.nganhcntt.Click += new System.EventHandler(this.button4_Click_2);
            // 
            // dulichs
            // 
            this.dulichs.Location = new System.Drawing.Point(1091, 531);
            this.dulichs.Name = "dulichs";
            this.dulichs.Size = new System.Drawing.Size(117, 46);
            this.dulichs.TabIndex = 21;
            this.dulichs.Text = "Ngành du lịch";
            this.dulichs.UseVisualStyleBackColor = true;
            this.dulichs.Click += new System.EventHandler(this.button7_Click);
            // 
            // luats
            // 
            this.luats.Location = new System.Drawing.Point(1223, 531);
            this.luats.Name = "luats";
            this.luats.Size = new System.Drawing.Size(111, 46);
            this.luats.TabIndex = 22;
            this.luats.Text = "Ngành luật";
            this.luats.UseVisualStyleBackColor = true;
            this.luats.Click += new System.EventHandler(this.button8_Click);
            // 
            // qtkds
            // 
            this.qtkds.Location = new System.Drawing.Point(1091, 603);
            this.qtkds.Name = "qtkds";
            this.qtkds.Size = new System.Drawing.Size(117, 46);
            this.qtkds.TabIndex = 23;
            this.qtkds.Text = "Ngành QTKD";
            this.qtkds.UseVisualStyleBackColor = true;
            this.qtkds.Click += new System.EventHandler(this.button9_Click);
            // 
            // quyen
            // 
            this.quyen.Location = new System.Drawing.Point(541, 418);
            this.quyen.Name = "quyen";
            this.quyen.Size = new System.Drawing.Size(111, 43);
            this.quyen.TabIndex = 24;
            this.quyen.Text = "button1";
            this.quyen.UseVisualStyleBackColor = true;
            // 
            // ten
            // 
            this.ten.Location = new System.Drawing.Point(541, 487);
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(260, 43);
            this.ten.TabIndex = 25;
            this.ten.Text = "button3";
            this.ten.UseVisualStyleBackColor = true;
            // 
            // khoahocs
            // 
            this.khoahocs.Location = new System.Drawing.Point(690, 418);
            this.khoahocs.Name = "khoahocs";
            this.khoahocs.Size = new System.Drawing.Size(111, 43);
            this.khoahocs.TabIndex = 26;
            this.khoahocs.Text = "button1";
            this.khoahocs.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(124, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 37);
            this.label2.TabIndex = 28;
            this.label2.Text = "Bảng chính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(1050, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 37);
            this.label3.TabIndex = 29;
            this.label3.Text = "Bảng chi tiết";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lichsu
            // 
            this.lichsu.Location = new System.Drawing.Point(163, 581);
            this.lichsu.Name = "lichsu";
            this.lichsu.Size = new System.Drawing.Size(113, 46);
            this.lichsu.TabIndex = 30;
            this.lichsu.Text = "Lịch sử";
            this.lichsu.UseVisualStyleBackColor = true;
            this.lichsu.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(293, 581);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(107, 46);
            this.email.TabIndex = 31;
            this.email.Text = "Gửi email";
            this.email.UseVisualStyleBackColor = true;
            this.email.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // gvcns
            // 
            this.gvcns.Location = new System.Drawing.Point(498, 551);
            this.gvcns.Name = "gvcns";
            this.gvcns.Size = new System.Drawing.Size(362, 76);
            this.gvcns.TabIndex = 32;
            this.gvcns.Text = "button3";
            this.gvcns.UseVisualStyleBackColor = true;
            // 
            // thacmac
            // 
            this.thacmac.Location = new System.Drawing.Point(954, 603);
            this.thacmac.Name = "thacmac";
            this.thacmac.Size = new System.Drawing.Size(111, 46);
            this.thacmac.TabIndex = 33;
            this.thacmac.Text = "Thắc mắc";
            this.thacmac.UseVisualStyleBackColor = true;
            this.thacmac.Click += new System.EventHandler(this.button1_Click_4);
            // 
            // phanhoi
            // 
            this.phanhoi.Location = new System.Drawing.Point(1223, 603);
            this.phanhoi.Name = "phanhoi";
            this.phanhoi.Size = new System.Drawing.Size(111, 46);
            this.phanhoi.TabIndex = 34;
            this.phanhoi.Text = "Phản hồi";
            this.phanhoi.UseVisualStyleBackColor = true;
            this.phanhoi.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 45);
            this.button1.TabIndex = 35;
            this.button1.Text = "Đổi mật khẩu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_5);
            // 
            // donghocphi
            // 
            this.donghocphi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donghocphi.Location = new System.Drawing.Point(1212, 110);
            this.donghocphi.Name = "donghocphi";
            this.donghocphi.Size = new System.Drawing.Size(130, 45);
            this.donghocphi.TabIndex = 36;
            this.donghocphi.Text = "Đóng học phí";
            this.donghocphi.UseVisualStyleBackColor = true;
            this.donghocphi.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BAITAPLONS.Properties.Resources.Picture3;
            this.pictureBox1.Location = new System.Drawing.Point(553, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 669);
            this.Controls.Add(this.donghocphi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.phanhoi);
            this.Controls.Add(this.thacmac);
            this.Controls.Add(this.gvcns);
            this.Controls.Add(this.email);
            this.Controls.Add(this.lichsu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.khoahocs);
            this.Controls.Add(this.ten);
            this.Controls.Add(this.quyen);
            this.Controls.Add(this.qtkds);
            this.Controls.Add(this.luats);
            this.Controls.Add(this.dulichs);
            this.Controls.Add(this.nganhcntt);
            this.Controls.Add(this.svk16);
            this.Controls.Add(this.svk15);
            this.Controls.Add(this.svcntt);
            this.Controls.Add(this.cdhp);
            this.Controls.Add(this.svk14);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.svdb);
            this.Controls.Add(this.monhoc);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.doituong);
            this.Controls.Add(this.nganh);
            this.Controls.Add(this.khoa);
            this.Controls.Add(this.lop);
            this.Controls.Add(this.taikhoanNT);
            this.Controls.Add(this.taikhoan);
            this.Controls.Add(this.phieuthu);
            this.Controls.Add(this.TKNH);
            this.Controls.Add(this.sinhvien);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMai";
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.FormMai_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sinhvien;
        private System.Windows.Forms.Button TKNH;
        private System.Windows.Forms.Button phieuthu;
        private System.Windows.Forms.Button taikhoan;
        private System.Windows.Forms.Button taikhoanNT;
        private System.Windows.Forms.Button lop;
        private System.Windows.Forms.Button khoa;
        private System.Windows.Forms.Button nganh;
        private System.Windows.Forms.Button doituong;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button monhoc;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button svdb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button svk14;
        private System.Windows.Forms.Button cdhp;
        private System.Windows.Forms.Button svcntt;
        private System.Windows.Forms.Button svk15;
        private System.Windows.Forms.Button svk16;
        private System.Windows.Forms.Button nganhcntt;
        private System.Windows.Forms.Button dulichs;
        private System.Windows.Forms.Button luats;
        private System.Windows.Forms.Button qtkds;
        private System.Windows.Forms.Button quyen;
        private System.Windows.Forms.Button ten;
        private System.Windows.Forms.Button khoahocs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button lichsu;
        private System.Windows.Forms.Button email;
        private System.Windows.Forms.Button gvcns;
        private System.Windows.Forms.Button thacmac;
        private System.Windows.Forms.Button phanhoi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button donghocphi;
    }
}