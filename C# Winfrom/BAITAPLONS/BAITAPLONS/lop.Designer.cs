namespace BAITAPLONS
{
    partial class lop
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
            this.mlop = new System.Windows.Forms.Label();
            this.mnganh = new System.Windows.Forms.Label();
            this.tlop = new System.Windows.Forms.Label();
            this.gvlop = new System.Windows.Forms.Label();
            this.khoah = new System.Windows.Forms.Label();
            this.malops = new System.Windows.Forms.TextBox();
            this.manganhs = new System.Windows.Forms.TextBox();
            this.tenlops = new System.Windows.Forms.TextBox();
            this.gvcnlops = new System.Windows.Forms.TextBox();
            this.khoahocs = new System.Windows.Forms.TextBox();
            this.timkiems = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.lopss = new System.Windows.Forms.DataGridView();
            this.maloptt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenlop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GVCNlop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoahoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quyen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lopss)).BeginInit();
            this.SuspendLayout();
            // 
            // mlop
            // 
            this.mlop.AutoSize = true;
            this.mlop.Location = new System.Drawing.Point(140, 179);
            this.mlop.Name = "mlop";
            this.mlop.Size = new System.Drawing.Size(48, 16);
            this.mlop.TabIndex = 0;
            this.mlop.Text = "Mã lớp";
            // 
            // mnganh
            // 
            this.mnganh.AutoSize = true;
            this.mnganh.Location = new System.Drawing.Point(952, 179);
            this.mnganh.Name = "mnganh";
            this.mnganh.Size = new System.Drawing.Size(66, 16);
            this.mnganh.TabIndex = 1;
            this.mnganh.Text = "Mã ngành";
            // 
            // tlop
            // 
            this.tlop.AutoSize = true;
            this.tlop.Location = new System.Drawing.Point(250, 272);
            this.tlop.Name = "tlop";
            this.tlop.Size = new System.Drawing.Size(53, 16);
            this.tlop.TabIndex = 2;
            this.tlop.Text = "Tên lớp";
            // 
            // gvlop
            // 
            this.gvlop.AutoSize = true;
            this.gvlop.Location = new System.Drawing.Point(493, 179);
            this.gvlop.Name = "gvlop";
            this.gvlop.Size = new System.Drawing.Size(127, 16);
            this.gvlop.TabIndex = 3;
            this.gvlop.Text = "Giáo viên chủ nhiệm";
            // 
            // khoah
            // 
            this.khoah.AutoSize = true;
            this.khoah.Location = new System.Drawing.Point(714, 278);
            this.khoah.Name = "khoah";
            this.khoah.Size = new System.Drawing.Size(63, 16);
            this.khoah.TabIndex = 4;
            this.khoah.Text = "Khóa học";
            // 
            // malops
            // 
            this.malops.Location = new System.Drawing.Point(199, 176);
            this.malops.Name = "malops";
            this.malops.Size = new System.Drawing.Size(230, 22);
            this.malops.TabIndex = 5;
            // 
            // manganhs
            // 
            this.manganhs.Location = new System.Drawing.Point(1033, 173);
            this.manganhs.Name = "manganhs";
            this.manganhs.Size = new System.Drawing.Size(230, 22);
            this.manganhs.TabIndex = 6;
            // 
            // tenlops
            // 
            this.tenlops.Location = new System.Drawing.Point(309, 272);
            this.tenlops.Name = "tenlops";
            this.tenlops.Size = new System.Drawing.Size(230, 22);
            this.tenlops.TabIndex = 7;
            // 
            // gvcnlops
            // 
            this.gvcnlops.Location = new System.Drawing.Point(636, 173);
            this.gvcnlops.Name = "gvcnlops";
            this.gvcnlops.Size = new System.Drawing.Size(230, 22);
            this.gvcnlops.TabIndex = 8;
            // 
            // khoahocs
            // 
            this.khoahocs.Location = new System.Drawing.Point(791, 272);
            this.khoahocs.Name = "khoahocs";
            this.khoahocs.Size = new System.Drawing.Size(230, 22);
            this.khoahocs.TabIndex = 9;
            // 
            // timkiems
            // 
            this.timkiems.Location = new System.Drawing.Point(552, 347);
            this.timkiems.Name = "timkiems";
            this.timkiems.Size = new System.Drawing.Size(230, 22);
            this.timkiems.TabIndex = 11;
            this.timkiems.TextChanged += new System.EventHandler(this.timkiems_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(475, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tìm kiếm";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(430, 426);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(87, 44);
            this.add.TabIndex = 12;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(602, 426);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(87, 44);
            this.edit.TabIndex = 13;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.button2_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(779, 426);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(87, 44);
            this.delete.TabIndex = 14;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button3_Click);
            // 
            // lopss
            // 
            this.lopss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lopss.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maloptt,
            this.malop,
            this.manganh,
            this.tenlop,
            this.GVCNlop,
            this.khoahoc});
            this.lopss.Location = new System.Drawing.Point(-1, 504);
            this.lopss.Name = "lopss";
            this.lopss.RowHeadersWidth = 51;
            this.lopss.RowTemplate.Height = 24;
            this.lopss.Size = new System.Drawing.Size(1341, 257);
            this.lopss.TabIndex = 15;
            this.lopss.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lopss_CellClick);
            // 
            // maloptt
            // 
            this.maloptt.DataPropertyName = "maloptt";
            this.maloptt.HeaderText = "Mã Lớp tự tăng";
            this.maloptt.MinimumWidth = 6;
            this.maloptt.Name = "maloptt";
            this.maloptt.Visible = false;
            this.maloptt.Width = 125;
            // 
            // malop
            // 
            this.malop.DataPropertyName = "malop";
            this.malop.HeaderText = "Mã lớp";
            this.malop.MinimumWidth = 6;
            this.malop.Name = "malop";
            this.malop.Width = 125;
            // 
            // manganh
            // 
            this.manganh.DataPropertyName = "manganh";
            this.manganh.HeaderText = "Mã ngành";
            this.manganh.MinimumWidth = 6;
            this.manganh.Name = "manganh";
            this.manganh.Width = 125;
            // 
            // tenlop
            // 
            this.tenlop.DataPropertyName = "tenlop";
            this.tenlop.HeaderText = "Tên lớp";
            this.tenlop.MinimumWidth = 6;
            this.tenlop.Name = "tenlop";
            this.tenlop.Width = 125;
            // 
            // GVCNlop
            // 
            this.GVCNlop.DataPropertyName = "GVCNlop";
            this.GVCNlop.HeaderText = "Giáo viên chủ nhệm lớp";
            this.GVCNlop.MinimumWidth = 6;
            this.GVCNlop.Name = "GVCNlop";
            this.GVCNlop.Width = 125;
            // 
            // khoahoc
            // 
            this.khoahoc.DataPropertyName = "khoahoc";
            this.khoahoc.HeaderText = "Khóa học";
            this.khoahoc.MinimumWidth = 6;
            this.khoahoc.Name = "khoahoc";
            this.khoahoc.Width = 125;
            // 
            // quyen
            // 
            this.quyen.Location = new System.Drawing.Point(1223, 74);
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
            this.label1.Location = new System.Drawing.Point(586, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 95);
            this.label1.TabIndex = 60;
            this.label1.Text = "Lớp";
            // 
            // lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 761);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quyen);
            this.Controls.Add(this.lopss);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.timkiems);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.khoahocs);
            this.Controls.Add(this.gvcnlops);
            this.Controls.Add(this.tenlops);
            this.Controls.Add(this.manganhs);
            this.Controls.Add(this.malops);
            this.Controls.Add(this.khoah);
            this.Controls.Add(this.gvlop);
            this.Controls.Add(this.tlop);
            this.Controls.Add(this.mnganh);
            this.Controls.Add(this.mlop);
            this.Name = "lop";
            this.Text = "lop";
            this.Load += new System.EventHandler(this.lop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lopss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mlop;
        private System.Windows.Forms.Label mnganh;
        private System.Windows.Forms.Label tlop;
        private System.Windows.Forms.Label gvlop;
        private System.Windows.Forms.Label khoah;
        private System.Windows.Forms.TextBox malops;
        private System.Windows.Forms.TextBox manganhs;
        private System.Windows.Forms.TextBox tenlops;
        private System.Windows.Forms.TextBox gvcnlops;
        private System.Windows.Forms.TextBox khoahocs;
        private System.Windows.Forms.TextBox timkiems;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridView lopss;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloptt;
        private System.Windows.Forms.DataGridViewTextBoxColumn malop;
        private System.Windows.Forms.DataGridViewTextBoxColumn manganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenlop;
        private System.Windows.Forms.DataGridViewTextBoxColumn GVCNlop;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoahoc;
        private System.Windows.Forms.Button quyen;
        private System.Windows.Forms.Label label1;
    }
}