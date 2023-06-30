namespace BAITAPLONS
{
    partial class sinhvien
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.masvtt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madoituong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msvs = new System.Windows.Forms.Label();
            this.masvs = new System.Windows.Forms.TextBox();
            this.madoituongs = new System.Windows.Forms.TextBox();
            this.mdts = new System.Windows.Forms.Label();
            this.malops = new System.Windows.Forms.TextBox();
            this.mlop = new System.Windows.Forms.Label();
            this.hotens = new System.Windows.Forms.TextBox();
            this.hten = new System.Windows.Forms.Label();
            this.ngaysinhs = new System.Windows.Forms.TextBox();
            this.ns = new System.Windows.Forms.Label();
            this.diachis = new System.Windows.Forms.TextBox();
            this.dc = new System.Windows.Forms.Label();
            this.gioitinhs = new System.Windows.Forms.TextBox();
            this.gt = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.find = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.quyen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masvtt,
            this.msv,
            this.madoituong,
            this.malop,
            this.hoten,
            this.ngaysinh,
            this.diachi,
            this.gioitinh});
            this.dataGridView1.Location = new System.Drawing.Point(0, 432);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1329, 282);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // msvs
            // 
            this.msvs.AutoSize = true;
            this.msvs.Location = new System.Drawing.Point(26, 170);
            this.msvs.Name = "msvs";
            this.msvs.Size = new System.Drawing.Size(81, 16);
            this.msvs.TabIndex = 1;
            this.msvs.Text = "Mã sinh viên";
            // 
            // masvs
            // 
            this.masvs.Location = new System.Drawing.Point(113, 170);
            this.masvs.Name = "masvs";
            this.masvs.Size = new System.Drawing.Size(151, 22);
            this.masvs.TabIndex = 2;
            this.masvs.TextChanged += new System.EventHandler(this.masvs_TextChanged);
            // 
            // madoituongs
            // 
            this.madoituongs.Location = new System.Drawing.Point(768, 170);
            this.madoituongs.Name = "madoituongs";
            this.madoituongs.Size = new System.Drawing.Size(151, 22);
            this.madoituongs.TabIndex = 4;
            // 
            // mdts
            // 
            this.mdts.AutoSize = true;
            this.mdts.Location = new System.Drawing.Point(681, 170);
            this.mdts.Name = "mdts";
            this.mdts.Size = new System.Drawing.Size(84, 16);
            this.mdts.TabIndex = 3;
            this.mdts.Text = "Mã đối tượng";
            // 
            // malops
            // 
            this.malops.Location = new System.Drawing.Point(113, 254);
            this.malops.Name = "malops";
            this.malops.Size = new System.Drawing.Size(151, 22);
            this.malops.TabIndex = 6;
            // 
            // mlop
            // 
            this.mlop.AutoSize = true;
            this.mlop.Location = new System.Drawing.Point(35, 254);
            this.mlop.Name = "mlop";
            this.mlop.Size = new System.Drawing.Size(48, 16);
            this.mlop.TabIndex = 5;
            this.mlop.Text = "Ma lớp";
            // 
            // hotens
            // 
            this.hotens.Location = new System.Drawing.Point(768, 251);
            this.hotens.Name = "hotens";
            this.hotens.Size = new System.Drawing.Size(151, 22);
            this.hotens.TabIndex = 8;
            // 
            // hten
            // 
            this.hten.AutoSize = true;
            this.hten.Location = new System.Drawing.Point(713, 254);
            this.hten.Name = "hten";
            this.hten.Size = new System.Drawing.Size(46, 16);
            this.hten.TabIndex = 7;
            this.hten.Text = "Họ tên";
            this.hten.Click += new System.EventHandler(this.hten_Click);
            // 
            // ngaysinhs
            // 
            this.ngaysinhs.Location = new System.Drawing.Point(419, 170);
            this.ngaysinhs.Name = "ngaysinhs";
            this.ngaysinhs.Size = new System.Drawing.Size(151, 22);
            this.ngaysinhs.TabIndex = 10;
            // 
            // ns
            // 
            this.ns.AutoSize = true;
            this.ns.Location = new System.Drawing.Point(332, 170);
            this.ns.Name = "ns";
            this.ns.Size = new System.Drawing.Size(67, 16);
            this.ns.TabIndex = 9;
            this.ns.Text = "Ngày sinh";
            // 
            // diachis
            // 
            this.diachis.Location = new System.Drawing.Point(1120, 170);
            this.diachis.Name = "diachis";
            this.diachis.Size = new System.Drawing.Size(151, 22);
            this.diachis.TabIndex = 12;
            // 
            // dc
            // 
            this.dc.AutoSize = true;
            this.dc.Location = new System.Drawing.Point(1051, 170);
            this.dc.Name = "dc";
            this.dc.Size = new System.Drawing.Size(47, 16);
            this.dc.TabIndex = 11;
            this.dc.Text = "Địa chỉ";
            // 
            // gioitinhs
            // 
            this.gioitinhs.Location = new System.Drawing.Point(419, 254);
            this.gioitinhs.Name = "gioitinhs";
            this.gioitinhs.Size = new System.Drawing.Size(151, 22);
            this.gioitinhs.TabIndex = 14;
            // 
            // gt
            // 
            this.gt.AutoSize = true;
            this.gt.Location = new System.Drawing.Point(332, 254);
            this.gt.Name = "gt";
            this.gt.Size = new System.Drawing.Size(54, 16);
            this.gt.TabIndex = 13;
            this.gt.Text = "Giới tính";
            this.gt.Click += new System.EventHandler(this.gt_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(392, 361);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(139, 46);
            this.add.TabIndex = 15;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(774, 361);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(127, 46);
            this.delete.TabIndex = 16;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(590, 361);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(134, 46);
            this.edit.TabIndex = 17;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(1120, 254);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(151, 22);
            this.find.TabIndex = 19;
            this.find.TextChanged += new System.EventHandler(this.find_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1003, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Nhập để tìm kiêm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(442, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 95);
            this.label1.TabIndex = 20;
            this.label1.Text = "Sinh viên";
            // 
            // quyen
            // 
            this.quyen.Location = new System.Drawing.Point(1213, 71);
            this.quyen.Name = "quyen";
            this.quyen.Size = new System.Drawing.Size(103, 42);
            this.quyen.TabIndex = 60;
            this.quyen.Text = "button1";
            this.quyen.UseVisualStyleBackColor = true;
            // 
            // sinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 716);
            this.Controls.Add(this.quyen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.find);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
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
            this.Controls.Add(this.dataGridView1);
            this.Name = "sinhvien";
            this.Text = "sinhvien";
            this.Load += new System.EventHandler(this.sinhvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label msvs;
        private System.Windows.Forms.TextBox masvs;
        private System.Windows.Forms.TextBox madoituongs;
        private System.Windows.Forms.Label mdts;
        private System.Windows.Forms.TextBox malops;
        private System.Windows.Forms.Label mlop;
        private System.Windows.Forms.TextBox hotens;
        private System.Windows.Forms.Label hten;
        private System.Windows.Forms.TextBox ngaysinhs;
        private System.Windows.Forms.Label ns;
        private System.Windows.Forms.TextBox diachis;
        private System.Windows.Forms.Label dc;
        private System.Windows.Forms.TextBox gioitinhs;
        private System.Windows.Forms.Label gt;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.TextBox find;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button quyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn masvtt;
        private System.Windows.Forms.DataGridViewTextBoxColumn msv;
        private System.Windows.Forms.DataGridViewTextBoxColumn madoituong;
        private System.Windows.Forms.DataGridViewTextBoxColumn malop;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
    }
}