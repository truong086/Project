namespace BAITAPLONS
{
    partial class nganh
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
            this.mnganh = new System.Windows.Forms.Label();
            this.mkhoa = new System.Windows.Forms.Label();
            this.tnganh = new System.Windows.Forms.Label();
            this.manganhs = new System.Windows.Forms.TextBox();
            this.makhoas = new System.Windows.Forms.TextBox();
            this.tennganhs = new System.Windows.Forms.TextBox();
            this.timkiems = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.nganhss = new System.Windows.Forms.DataGridView();
            this.manganhtt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quyen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nganhss)).BeginInit();
            this.SuspendLayout();
            // 
            // mnganh
            // 
            this.mnganh.AutoSize = true;
            this.mnganh.Location = new System.Drawing.Point(205, 227);
            this.mnganh.Name = "mnganh";
            this.mnganh.Size = new System.Drawing.Size(66, 16);
            this.mnganh.TabIndex = 0;
            this.mnganh.Text = "Mã ngành";
            // 
            // mkhoa
            // 
            this.mkhoa.AutoSize = true;
            this.mkhoa.Location = new System.Drawing.Point(519, 227);
            this.mkhoa.Name = "mkhoa";
            this.mkhoa.Size = new System.Drawing.Size(59, 16);
            this.mkhoa.TabIndex = 1;
            this.mkhoa.Text = "Mã khoa";
            // 
            // tnganh
            // 
            this.tnganh.AutoSize = true;
            this.tnganh.Location = new System.Drawing.Point(822, 227);
            this.tnganh.Name = "tnganh";
            this.tnganh.Size = new System.Drawing.Size(71, 16);
            this.tnganh.TabIndex = 2;
            this.tnganh.Text = "Tên ngành";
            // 
            // manganhs
            // 
            this.manganhs.Location = new System.Drawing.Point(280, 221);
            this.manganhs.Name = "manganhs";
            this.manganhs.Size = new System.Drawing.Size(203, 22);
            this.manganhs.TabIndex = 3;
            // 
            // makhoas
            // 
            this.makhoas.Location = new System.Drawing.Point(603, 221);
            this.makhoas.Name = "makhoas";
            this.makhoas.Size = new System.Drawing.Size(203, 22);
            this.makhoas.TabIndex = 4;
            // 
            // tennganhs
            // 
            this.tennganhs.Location = new System.Drawing.Point(899, 221);
            this.tennganhs.Name = "tennganhs";
            this.tennganhs.Size = new System.Drawing.Size(203, 22);
            this.tennganhs.TabIndex = 5;
            // 
            // timkiems
            // 
            this.timkiems.Location = new System.Drawing.Point(504, 309);
            this.timkiems.Name = "timkiems";
            this.timkiems.Size = new System.Drawing.Size(302, 22);
            this.timkiems.TabIndex = 7;
            this.timkiems.TextChanged += new System.EventHandler(this.timkiems_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tìm kiếm";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(409, 387);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(94, 44);
            this.add.TabIndex = 8;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(592, 387);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(94, 44);
            this.edit.TabIndex = 9;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.button2_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(773, 387);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(94, 44);
            this.delete.TabIndex = 10;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button3_Click);
            // 
            // nganhss
            // 
            this.nganhss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nganhss.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manganhtt,
            this.manganh,
            this.makhoa,
            this.tennganh});
            this.nganhss.Location = new System.Drawing.Point(2, 454);
            this.nganhss.Name = "nganhss";
            this.nganhss.RowHeadersWidth = 51;
            this.nganhss.RowTemplate.Height = 24;
            this.nganhss.Size = new System.Drawing.Size(1336, 296);
            this.nganhss.TabIndex = 11;
            this.nganhss.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.nganhss_CellClick);
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
            // quyen
            // 
            this.quyen.Location = new System.Drawing.Point(1222, 56);
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
            this.label1.Location = new System.Drawing.Point(553, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 95);
            this.label1.TabIndex = 60;
            this.label1.Text = "Ngành";
            // 
            // nganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 750);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quyen);
            this.Controls.Add(this.nganhss);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.timkiems);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tennganhs);
            this.Controls.Add(this.makhoas);
            this.Controls.Add(this.manganhs);
            this.Controls.Add(this.tnganh);
            this.Controls.Add(this.mkhoa);
            this.Controls.Add(this.mnganh);
            this.Name = "nganh";
            this.Text = "nganh";
            this.Load += new System.EventHandler(this.nganh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nganhss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mnganh;
        private System.Windows.Forms.Label mkhoa;
        private System.Windows.Forms.Label tnganh;
        private System.Windows.Forms.TextBox manganhs;
        private System.Windows.Forms.TextBox makhoas;
        private System.Windows.Forms.TextBox tennganhs;
        private System.Windows.Forms.TextBox timkiems;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridView nganhss;
        private System.Windows.Forms.DataGridViewTextBoxColumn manganhtt;
        private System.Windows.Forms.DataGridViewTextBoxColumn manganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennganh;
        private System.Windows.Forms.Button quyen;
        private System.Windows.Forms.Label label1;
    }
}