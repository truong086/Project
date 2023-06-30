namespace BAITAPLONS
{
    partial class nganhluat
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
            this.luatss = new System.Windows.Forms.DataGridView();
            this.manganhtt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.timkiems = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tennganhs = new System.Windows.Forms.TextBox();
            this.makhoas = new System.Windows.Forms.TextBox();
            this.manganhs = new System.Windows.Forms.TextBox();
            this.tnganh = new System.Windows.Forms.Label();
            this.mkhoa = new System.Windows.Forms.Label();
            this.mnganh = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.quyen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.luatss)).BeginInit();
            this.SuspendLayout();
            // 
            // luatss
            // 
            this.luatss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.luatss.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manganhtt,
            this.manganh,
            this.makhoa,
            this.tennganh});
            this.luatss.Location = new System.Drawing.Point(0, 444);
            this.luatss.Name = "luatss";
            this.luatss.RowHeadersWidth = 51;
            this.luatss.RowTemplate.Height = 24;
            this.luatss.Size = new System.Drawing.Size(1340, 313);
            this.luatss.TabIndex = 45;
            this.luatss.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.luatss_CellClick);
            // 
            // manganhtt
            // 
            this.manganhtt.DataPropertyName = "manganhtt";
            this.manganhtt.HeaderText = "Mã ngành tự tăng";
            this.manganhtt.MinimumWidth = 6;
            this.manganhtt.Name = "manganhtt";
            this.manganhtt.Visible = false;
            this.manganhtt.Width = 125;
            // 
            // manganh
            // 
            this.manganh.DataPropertyName = "manganh";
            this.manganh.HeaderText = "Mã ngành";
            this.manganh.MinimumWidth = 6;
            this.manganh.Name = "manganh";
            this.manganh.Width = 125;
            // 
            // makhoa
            // 
            this.makhoa.DataPropertyName = "makhoa";
            this.makhoa.HeaderText = "Mã khoa";
            this.makhoa.MinimumWidth = 6;
            this.makhoa.Name = "makhoa";
            this.makhoa.Width = 125;
            // 
            // tennganh
            // 
            this.tennganh.DataPropertyName = "tennganh";
            this.tennganh.HeaderText = "Tên ngành";
            this.tennganh.MinimumWidth = 6;
            this.tennganh.Name = "tennganh";
            this.tennganh.Width = 125;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(671, 357);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(133, 57);
            this.delete.TabIndex = 44;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(443, 357);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(142, 57);
            this.edit.TabIndex = 43;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // timkiems
            // 
            this.timkiems.Location = new System.Drawing.Point(483, 257);
            this.timkiems.Name = "timkiems";
            this.timkiems.Size = new System.Drawing.Size(321, 22);
            this.timkiems.TabIndex = 42;
            this.timkiems.TextChanged += new System.EventHandler(this.timkiems_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "Tìm kiếm";
            // 
            // tennganhs
            // 
            this.tennganhs.Location = new System.Drawing.Point(969, 169);
            this.tennganhs.Name = "tennganhs";
            this.tennganhs.Size = new System.Drawing.Size(294, 22);
            this.tennganhs.TabIndex = 40;
            // 
            // makhoas
            // 
            this.makhoas.Location = new System.Drawing.Point(582, 169);
            this.makhoas.Name = "makhoas";
            this.makhoas.Size = new System.Drawing.Size(259, 22);
            this.makhoas.TabIndex = 39;
            // 
            // manganhs
            // 
            this.manganhs.Location = new System.Drawing.Point(143, 169);
            this.manganhs.Name = "manganhs";
            this.manganhs.Size = new System.Drawing.Size(315, 22);
            this.manganhs.TabIndex = 38;
            // 
            // tnganh
            // 
            this.tnganh.AutoSize = true;
            this.tnganh.Location = new System.Drawing.Point(892, 175);
            this.tnganh.Name = "tnganh";
            this.tnganh.Size = new System.Drawing.Size(71, 16);
            this.tnganh.TabIndex = 37;
            this.tnganh.Text = "Tên ngành";
            // 
            // mkhoa
            // 
            this.mkhoa.AutoSize = true;
            this.mkhoa.Location = new System.Drawing.Point(498, 175);
            this.mkhoa.Name = "mkhoa";
            this.mkhoa.Size = new System.Drawing.Size(59, 16);
            this.mkhoa.TabIndex = 36;
            this.mkhoa.Text = "Mã khoa";
            // 
            // mnganh
            // 
            this.mnganh.AutoSize = true;
            this.mnganh.Location = new System.Drawing.Point(68, 175);
            this.mnganh.Name = "mnganh";
            this.mnganh.Size = new System.Drawing.Size(66, 16);
            this.mnganh.TabIndex = 35;
            this.mnganh.Text = "Mã ngành";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 95);
            this.label1.TabIndex = 46;
            this.label1.Text = "Ngành luật";
            // 
            // quyen
            // 
            this.quyen.Location = new System.Drawing.Point(1214, 75);
            this.quyen.Name = "quyen";
            this.quyen.Size = new System.Drawing.Size(103, 42);
            this.quyen.TabIndex = 59;
            this.quyen.Text = "button1";
            this.quyen.UseVisualStyleBackColor = true;
            // 
            // nganhluat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 755);
            this.Controls.Add(this.quyen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.luatss);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.timkiems);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tennganhs);
            this.Controls.Add(this.makhoas);
            this.Controls.Add(this.manganhs);
            this.Controls.Add(this.tnganh);
            this.Controls.Add(this.mkhoa);
            this.Controls.Add(this.mnganh);
            this.Name = "nganhluat";
            this.Text = "nganhluat";
            this.Load += new System.EventHandler(this.nganhluat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.luatss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView luatss;
        private System.Windows.Forms.DataGridViewTextBoxColumn manganhtt;
        private System.Windows.Forms.DataGridViewTextBoxColumn manganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennganh;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.TextBox timkiems;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tennganhs;
        private System.Windows.Forms.TextBox makhoas;
        private System.Windows.Forms.TextBox manganhs;
        private System.Windows.Forms.Label tnganh;
        private System.Windows.Forms.Label mkhoa;
        private System.Windows.Forms.Label mnganh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button quyen;
    }
}