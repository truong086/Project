namespace BAITAPLONS
{
    partial class khoa
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
            this.mkhoa = new System.Windows.Forms.Label();
            this.tenkh = new System.Windows.Forms.Label();
            this.giaovcnk = new System.Windows.Forms.Label();
            this.makhoas = new System.Windows.Forms.TextBox();
            this.gvchkhoa = new System.Windows.Forms.TextBox();
            this.tenkhoas = new System.Windows.Forms.TextBox();
            this.timkiems = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.khoass = new System.Windows.Forms.DataGridView();
            this.makhoatt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GVCNkhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.quyen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.khoass)).BeginInit();
            this.SuspendLayout();
            // 
            // mkhoa
            // 
            this.mkhoa.AutoSize = true;
            this.mkhoa.Location = new System.Drawing.Point(40, 234);
            this.mkhoa.Name = "mkhoa";
            this.mkhoa.Size = new System.Drawing.Size(59, 16);
            this.mkhoa.TabIndex = 0;
            this.mkhoa.Text = "Mã khoa";
            // 
            // tenkh
            // 
            this.tenkh.AutoSize = true;
            this.tenkh.Location = new System.Drawing.Point(371, 234);
            this.tenkh.Name = "tenkh";
            this.tenkh.Size = new System.Drawing.Size(64, 16);
            this.tenkh.TabIndex = 1;
            this.tenkh.Text = "Tên khoa";
            // 
            // giaovcnk
            // 
            this.giaovcnk.AutoSize = true;
            this.giaovcnk.Location = new System.Drawing.Point(699, 234);
            this.giaovcnk.Name = "giaovcnk";
            this.giaovcnk.Size = new System.Drawing.Size(127, 16);
            this.giaovcnk.TabIndex = 2;
            this.giaovcnk.Text = "Giáo viên chủ nhiệm";
            // 
            // makhoas
            // 
            this.makhoas.Location = new System.Drawing.Point(107, 228);
            this.makhoas.Name = "makhoas";
            this.makhoas.Size = new System.Drawing.Size(196, 22);
            this.makhoas.TabIndex = 3;
            // 
            // gvchkhoa
            // 
            this.gvchkhoa.Location = new System.Drawing.Point(846, 228);
            this.gvchkhoa.Name = "gvchkhoa";
            this.gvchkhoa.Size = new System.Drawing.Size(236, 22);
            this.gvchkhoa.TabIndex = 4;
            // 
            // tenkhoas
            // 
            this.tenkhoas.Location = new System.Drawing.Point(442, 228);
            this.tenkhoas.Name = "tenkhoas";
            this.tenkhoas.Size = new System.Drawing.Size(209, 22);
            this.tenkhoas.TabIndex = 5;
            // 
            // timkiems
            // 
            this.timkiems.Location = new System.Drawing.Point(480, 343);
            this.timkiems.Name = "timkiems";
            this.timkiems.Size = new System.Drawing.Size(256, 22);
            this.timkiems.TabIndex = 7;
            this.timkiems.TextChanged += new System.EventHandler(this.timkiems_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tìm kiếm";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(406, 429);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 8;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(563, 429);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 9;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.button2_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(718, 429);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 10;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button3_Click);
            // 
            // khoass
            // 
            this.khoass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.khoass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makhoatt,
            this.makhoa,
            this.tenkhoa,
            this.GVCNkhoa});
            this.khoass.Location = new System.Drawing.Point(-2, 480);
            this.khoass.Name = "khoass";
            this.khoass.RowHeadersWidth = 51;
            this.khoass.RowTemplate.Height = 24;
            this.khoass.Size = new System.Drawing.Size(1224, 171);
            this.khoass.TabIndex = 11;
            this.khoass.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.khoass_CellClick);
            // 
            // makhoatt
            // 
            this.makhoatt.DataPropertyName = "makhoatt";
            this.makhoatt.HeaderText = "mã khoa tự tăng";
            this.makhoatt.MinimumWidth = 6;
            this.makhoatt.Name = "makhoatt";
            this.makhoatt.Visible = false;
            this.makhoatt.Width = 125;
            // 
            // makhoa
            // 
            this.makhoa.DataPropertyName = "makhoa";
            this.makhoa.HeaderText = "Mã khoa";
            this.makhoa.MinimumWidth = 6;
            this.makhoa.Name = "makhoa";
            this.makhoa.Width = 125;
            // 
            // tenkhoa
            // 
            this.tenkhoa.DataPropertyName = "tenkhoa";
            this.tenkhoa.HeaderText = "Tên khoa";
            this.tenkhoa.MinimumWidth = 6;
            this.tenkhoa.Name = "tenkhoa";
            this.tenkhoa.Width = 125;
            // 
            // GVCNkhoa
            // 
            this.GVCNkhoa.DataPropertyName = "GVCNkhoa";
            this.GVCNkhoa.HeaderText = "Giáo viên chủ nhiệm khoa";
            this.GVCNkhoa.MinimumWidth = 6;
            this.GVCNkhoa.Name = "GVCNkhoa";
            this.GVCNkhoa.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(461, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 95);
            this.label1.TabIndex = 12;
            this.label1.Text = "Khoa";
            // 
            // quyen
            // 
            this.quyen.Location = new System.Drawing.Point(1107, 65);
            this.quyen.Name = "quyen";
            this.quyen.Size = new System.Drawing.Size(103, 42);
            this.quyen.TabIndex = 59;
            this.quyen.Text = "button1";
            this.quyen.UseVisualStyleBackColor = true;
            // 
            // khoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 650);
            this.Controls.Add(this.quyen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.khoass);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.timkiems);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tenkhoas);
            this.Controls.Add(this.gvchkhoa);
            this.Controls.Add(this.makhoas);
            this.Controls.Add(this.giaovcnk);
            this.Controls.Add(this.tenkh);
            this.Controls.Add(this.mkhoa);
            this.Name = "khoa";
            this.Text = "khoa";
            this.Load += new System.EventHandler(this.khoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.khoass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mkhoa;
        private System.Windows.Forms.Label tenkh;
        private System.Windows.Forms.Label giaovcnk;
        private System.Windows.Forms.TextBox makhoas;
        private System.Windows.Forms.TextBox gvchkhoa;
        private System.Windows.Forms.TextBox tenkhoas;
        private System.Windows.Forms.TextBox timkiems;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridView khoass;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhoatt;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn GVCNkhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button quyen;
    }
}