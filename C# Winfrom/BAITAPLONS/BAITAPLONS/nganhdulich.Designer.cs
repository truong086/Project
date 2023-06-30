namespace BAITAPLONS
{
    partial class nganhdulich
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
            this.nganhdulichs = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.nganhdulichs)).BeginInit();
            this.SuspendLayout();
            // 
            // nganhdulichs
            // 
            this.nganhdulichs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nganhdulichs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manganhtt,
            this.manganh,
            this.makhoa,
            this.tennganh});
            this.nganhdulichs.Location = new System.Drawing.Point(1, 430);
            this.nganhdulichs.Name = "nganhdulichs";
            this.nganhdulichs.RowHeadersWidth = 51;
            this.nganhdulichs.RowTemplate.Height = 24;
            this.nganhdulichs.Size = new System.Drawing.Size(1334, 325);
            this.nganhdulichs.TabIndex = 34;
            this.nganhdulichs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.nganhdulichs_CellClick);
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
            this.delete.Location = new System.Drawing.Point(673, 352);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(94, 44);
            this.delete.TabIndex = 33;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(492, 352);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(94, 44);
            this.edit.TabIndex = 32;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // timkiems
            // 
            this.timkiems.Location = new System.Drawing.Point(492, 278);
            this.timkiems.Name = "timkiems";
            this.timkiems.Size = new System.Drawing.Size(302, 22);
            this.timkiems.TabIndex = 31;
            this.timkiems.TextChanged += new System.EventHandler(this.timkiems_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Tìm kiếm";
            // 
            // tennganhs
            // 
            this.tennganhs.Location = new System.Drawing.Point(922, 179);
            this.tennganhs.Name = "tennganhs";
            this.tennganhs.Size = new System.Drawing.Size(302, 22);
            this.tennganhs.TabIndex = 29;
            // 
            // makhoas
            // 
            this.makhoas.Location = new System.Drawing.Point(535, 179);
            this.makhoas.Name = "makhoas";
            this.makhoas.Size = new System.Drawing.Size(278, 22);
            this.makhoas.TabIndex = 28;
            // 
            // manganhs
            // 
            this.manganhs.Location = new System.Drawing.Point(138, 179);
            this.manganhs.Name = "manganhs";
            this.manganhs.Size = new System.Drawing.Size(265, 22);
            this.manganhs.TabIndex = 27;
            // 
            // tnganh
            // 
            this.tnganh.AutoSize = true;
            this.tnganh.Location = new System.Drawing.Point(845, 185);
            this.tnganh.Name = "tnganh";
            this.tnganh.Size = new System.Drawing.Size(71, 16);
            this.tnganh.TabIndex = 26;
            this.tnganh.Text = "Tên ngành";
            // 
            // mkhoa
            // 
            this.mkhoa.AutoSize = true;
            this.mkhoa.Location = new System.Drawing.Point(470, 185);
            this.mkhoa.Name = "mkhoa";
            this.mkhoa.Size = new System.Drawing.Size(59, 16);
            this.mkhoa.TabIndex = 25;
            this.mkhoa.Text = "Mã khoa";
            // 
            // mnganh
            // 
            this.mnganh.AutoSize = true;
            this.mnganh.Location = new System.Drawing.Point(63, 185);
            this.mnganh.Name = "mnganh";
            this.mnganh.Size = new System.Drawing.Size(66, 16);
            this.mnganh.TabIndex = 24;
            this.mnganh.Text = "Mã ngành";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 95);
            this.label1.TabIndex = 35;
            this.label1.Text = "Ngành du lịch";
            // 
            // quyen
            // 
            this.quyen.Location = new System.Drawing.Point(1208, 79);
            this.quyen.Name = "quyen";
            this.quyen.Size = new System.Drawing.Size(103, 42);
            this.quyen.TabIndex = 59;
            this.quyen.Text = "button1";
            this.quyen.UseVisualStyleBackColor = true;
            // 
            // nganhdulich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 753);
            this.Controls.Add(this.quyen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nganhdulichs);
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
            this.Name = "nganhdulich";
            this.Text = "nganhdulich";
            this.Load += new System.EventHandler(this.nganhdulich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nganhdulichs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView nganhdulichs;
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