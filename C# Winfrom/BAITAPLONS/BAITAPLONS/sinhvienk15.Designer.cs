namespace BAITAPLONS
{
    partial class sinhvienk15
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
            this.find = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.svk15 = new System.Windows.Forms.DataGridView();
            this.masvtt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madoituong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinhs = new System.Windows.Forms.TextBox();
            this.gt = new System.Windows.Forms.Label();
            this.diachis = new System.Windows.Forms.TextBox();
            this.dc = new System.Windows.Forms.Label();
            this.ngaysinhs = new System.Windows.Forms.TextBox();
            this.ns = new System.Windows.Forms.Label();
            this.hotens = new System.Windows.Forms.TextBox();
            this.hten = new System.Windows.Forms.Label();
            this.malops = new System.Windows.Forms.TextBox();
            this.mlop = new System.Windows.Forms.Label();
            this.madoituongs = new System.Windows.Forms.TextBox();
            this.mdts = new System.Windows.Forms.Label();
            this.masvs = new System.Windows.Forms.TextBox();
            this.msvs = new System.Windows.Forms.Label();
            this.quyen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.svk15)).BeginInit();
            this.SuspendLayout();
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(888, 335);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(151, 22);
            this.find.TabIndex = 44;
            this.find.TextChanged += new System.EventHandler(this.find_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(771, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 16);
            this.label8.TabIndex = 43;
            this.label8.Text = "Nhập để tìm kiêm";
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(353, 328);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(104, 36);
            this.edit.TabIndex = 42;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(537, 328);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(103, 36);
            this.delete.TabIndex = 41;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // svk15
            // 
            this.svk15.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.svk15.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masvtt,
            this.msv,
            this.madoituong,
            this.malop,
            this.hoten,
            this.ngaysinh,
            this.diachi,
            this.gioitinh});
            this.svk15.Location = new System.Drawing.Point(0, 395);
            this.svk15.Name = "svk15";
            this.svk15.RowHeadersWidth = 51;
            this.svk15.RowTemplate.Height = 24;
            this.svk15.Size = new System.Drawing.Size(1341, 360);
            this.svk15.TabIndex = 40;
            this.svk15.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.svk15_CellClick);
            // 
            // masvtt
            // 
            this.masvtt.DataPropertyName = "masvtt";
            this.masvtt.HeaderText = "masvtt";
            this.masvtt.MinimumWidth = 6;
            this.masvtt.Name = "masvtt";
            this.masvtt.Visible = false;
            this.masvtt.Width = 125;
            // 
            // msv
            // 
            this.msv.DataPropertyName = "msv";
            this.msv.HeaderText = "Mã sinh viên";
            this.msv.MinimumWidth = 6;
            this.msv.Name = "msv";
            this.msv.Width = 125;
            // 
            // madoituong
            // 
            this.madoituong.DataPropertyName = "madoituong";
            this.madoituong.HeaderText = "Mã đối tượng";
            this.madoituong.MinimumWidth = 6;
            this.madoituong.Name = "madoituong";
            this.madoituong.Width = 125;
            // 
            // malop
            // 
            this.malop.DataPropertyName = "malop";
            this.malop.HeaderText = "Mã lớp";
            this.malop.MinimumWidth = 6;
            this.malop.Name = "malop";
            this.malop.Width = 125;
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "hoten";
            this.hoten.HeaderText = "Họ tên";
            this.hoten.MinimumWidth = 6;
            this.hoten.Name = "hoten";
            this.hoten.Width = 125;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.MinimumWidth = 6;
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Width = 125;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.Width = 125;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.MinimumWidth = 6;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Width = 125;
            // 
            // gioitinhs
            // 
            this.gioitinhs.Location = new System.Drawing.Point(481, 239);
            this.gioitinhs.Name = "gioitinhs";
            this.gioitinhs.Size = new System.Drawing.Size(151, 22);
            this.gioitinhs.TabIndex = 58;
            // 
            // gt
            // 
            this.gt.AutoSize = true;
            this.gt.Location = new System.Drawing.Point(394, 239);
            this.gt.Name = "gt";
            this.gt.Size = new System.Drawing.Size(54, 16);
            this.gt.TabIndex = 57;
            this.gt.Text = "Giới tính";
            // 
            // diachis
            // 
            this.diachis.Location = new System.Drawing.Point(1089, 166);
            this.diachis.Name = "diachis";
            this.diachis.Size = new System.Drawing.Size(151, 22);
            this.diachis.TabIndex = 56;
            // 
            // dc
            // 
            this.dc.AutoSize = true;
            this.dc.Location = new System.Drawing.Point(1002, 166);
            this.dc.Name = "dc";
            this.dc.Size = new System.Drawing.Size(47, 16);
            this.dc.TabIndex = 55;
            this.dc.Text = "Địa chỉ";
            // 
            // ngaysinhs
            // 
            this.ngaysinhs.Location = new System.Drawing.Point(484, 166);
            this.ngaysinhs.Name = "ngaysinhs";
            this.ngaysinhs.Size = new System.Drawing.Size(151, 22);
            this.ngaysinhs.TabIndex = 54;
            // 
            // ns
            // 
            this.ns.AutoSize = true;
            this.ns.Location = new System.Drawing.Point(397, 166);
            this.ns.Name = "ns";
            this.ns.Size = new System.Drawing.Size(67, 16);
            this.ns.TabIndex = 53;
            this.ns.Text = "Ngày sinh";
            // 
            // hotens
            // 
            this.hotens.Location = new System.Drawing.Point(780, 239);
            this.hotens.Name = "hotens";
            this.hotens.Size = new System.Drawing.Size(151, 22);
            this.hotens.TabIndex = 52;
            // 
            // hten
            // 
            this.hten.AutoSize = true;
            this.hten.Location = new System.Drawing.Point(693, 239);
            this.hten.Name = "hten";
            this.hten.Size = new System.Drawing.Size(46, 16);
            this.hten.TabIndex = 51;
            this.hten.Text = "Họ tên";
            // 
            // malops
            // 
            this.malops.Location = new System.Drawing.Point(175, 239);
            this.malops.Name = "malops";
            this.malops.Size = new System.Drawing.Size(151, 22);
            this.malops.TabIndex = 50;
            // 
            // mlop
            // 
            this.mlop.AutoSize = true;
            this.mlop.Location = new System.Drawing.Point(88, 239);
            this.mlop.Name = "mlop";
            this.mlop.Size = new System.Drawing.Size(48, 16);
            this.mlop.TabIndex = 49;
            this.mlop.Text = "Ma lớp";
            // 
            // madoituongs
            // 
            this.madoituongs.Location = new System.Drawing.Point(783, 166);
            this.madoituongs.Name = "madoituongs";
            this.madoituongs.Size = new System.Drawing.Size(151, 22);
            this.madoituongs.TabIndex = 48;
            // 
            // mdts
            // 
            this.mdts.AutoSize = true;
            this.mdts.Location = new System.Drawing.Point(696, 166);
            this.mdts.Name = "mdts";
            this.mdts.Size = new System.Drawing.Size(84, 16);
            this.mdts.TabIndex = 47;
            this.mdts.Text = "Mã đối tượng";
            // 
            // masvs
            // 
            this.masvs.Location = new System.Drawing.Point(178, 166);
            this.masvs.Name = "masvs";
            this.masvs.Size = new System.Drawing.Size(151, 22);
            this.masvs.TabIndex = 46;
            // 
            // msvs
            // 
            this.msvs.AutoSize = true;
            this.msvs.Location = new System.Drawing.Point(91, 166);
            this.msvs.Name = "msvs";
            this.msvs.Size = new System.Drawing.Size(81, 16);
            this.msvs.TabIndex = 45;
            this.msvs.Text = "Mã sinh viên";
            // 
            // quyen
            // 
            this.quyen.Location = new System.Drawing.Point(1228, 58);
            this.quyen.Name = "quyen";
            this.quyen.Size = new System.Drawing.Size(103, 42);
            this.quyen.TabIndex = 59;
            this.quyen.Text = "button1";
            this.quyen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(726, 95);
            this.label1.TabIndex = 60;
            this.label1.Text = "Sinh viên khóa 15";
            // 
            // sinhvienk15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 751);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quyen);
            this.Controls.Add(this.gioitinhs);
            this.Controls.Add(this.gt);
            this.Controls.Add(this.diachis);
            this.Controls.Add(this.dc);
            this.Controls.Add(this.ngaysinhs);
            this.Controls.Add(this.ns);
            this.Controls.Add(this.hotens);
            this.Controls.Add(this.hten);
            this.Controls.Add(this.malops);
            this.Controls.Add(this.mlop);
            this.Controls.Add(this.madoituongs);
            this.Controls.Add(this.mdts);
            this.Controls.Add(this.masvs);
            this.Controls.Add(this.msvs);
            this.Controls.Add(this.find);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.svk15);
            this.Name = "sinhvienk15";
            this.Text = "sinhvienk15";
            this.Load += new System.EventHandler(this.sinhvienk15_Load);
            ((System.ComponentModel.ISupportInitialize)(this.svk15)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox find;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridView svk15;
        private System.Windows.Forms.DataGridViewTextBoxColumn masvtt;
        private System.Windows.Forms.DataGridViewTextBoxColumn msv;
        private System.Windows.Forms.DataGridViewTextBoxColumn madoituong;
        private System.Windows.Forms.DataGridViewTextBoxColumn malop;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.TextBox gioitinhs;
        private System.Windows.Forms.Label gt;
        private System.Windows.Forms.TextBox diachis;
        private System.Windows.Forms.Label dc;
        private System.Windows.Forms.TextBox ngaysinhs;
        private System.Windows.Forms.Label ns;
        private System.Windows.Forms.TextBox hotens;
        private System.Windows.Forms.Label hten;
        private System.Windows.Forms.TextBox malops;
        private System.Windows.Forms.Label mlop;
        private System.Windows.Forms.TextBox madoituongs;
        private System.Windows.Forms.Label mdts;
        private System.Windows.Forms.TextBox masvs;
        private System.Windows.Forms.Label msvs;
        private System.Windows.Forms.Button quyen;
        private System.Windows.Forms.Label label1;
    }
}