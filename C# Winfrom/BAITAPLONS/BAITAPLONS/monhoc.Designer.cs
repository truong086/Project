namespace BAITAPLONS
{
    partial class monhoc
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
            this.mmonhoc = new System.Windows.Forms.Label();
            this.mamonhocs = new System.Windows.Forms.TextBox();
            this.tenmonhocs = new System.Windows.Forms.TextBox();
            this.tmonhoc = new System.Windows.Forms.Label();
            this.timkiems = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.monhocss = new System.Windows.Forms.DataGridView();
            this.mamonhoctt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mamonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quyen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.monhocss)).BeginInit();
            this.SuspendLayout();
            // 
            // mmonhoc
            // 
            this.mmonhoc.AutoSize = true;
            this.mmonhoc.Location = new System.Drawing.Point(197, 211);
            this.mmonhoc.Name = "mmonhoc";
            this.mmonhoc.Size = new System.Drawing.Size(80, 16);
            this.mmonhoc.TabIndex = 0;
            this.mmonhoc.Text = "Mã môn học";
            // 
            // mamonhocs
            // 
            this.mamonhocs.Location = new System.Drawing.Point(294, 205);
            this.mamonhocs.Name = "mamonhocs";
            this.mamonhocs.Size = new System.Drawing.Size(199, 22);
            this.mamonhocs.TabIndex = 1;
            // 
            // tenmonhocs
            // 
            this.tenmonhocs.Location = new System.Drawing.Point(835, 208);
            this.tenmonhocs.Name = "tenmonhocs";
            this.tenmonhocs.Size = new System.Drawing.Size(199, 22);
            this.tenmonhocs.TabIndex = 3;
            // 
            // tmonhoc
            // 
            this.tmonhoc.AutoSize = true;
            this.tmonhoc.Location = new System.Drawing.Point(729, 214);
            this.tmonhoc.Name = "tmonhoc";
            this.tmonhoc.Size = new System.Drawing.Size(85, 16);
            this.tmonhoc.TabIndex = 2;
            this.tmonhoc.Text = "Tên môn học";
            // 
            // timkiems
            // 
            this.timkiems.Location = new System.Drawing.Point(504, 293);
            this.timkiems.Name = "timkiems";
            this.timkiems.Size = new System.Drawing.Size(257, 22);
            this.timkiems.TabIndex = 5;
            this.timkiems.TextChanged += new System.EventHandler(this.timkiems_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tìm kiếm";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(331, 377);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(93, 45);
            this.add.TabIndex = 6;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(589, 377);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(93, 45);
            this.edit.TabIndex = 7;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.button2_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(835, 377);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(93, 45);
            this.delete.TabIndex = 8;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button3_Click);
            // 
            // monhocss
            // 
            this.monhocss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monhocss.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mamonhoctt,
            this.mamonhoc,
            this.tenmonhoc});
            this.monhocss.Location = new System.Drawing.Point(1, 473);
            this.monhocss.Name = "monhocss";
            this.monhocss.RowHeadersWidth = 51;
            this.monhocss.RowTemplate.Height = 24;
            this.monhocss.Size = new System.Drawing.Size(1342, 280);
            this.monhocss.TabIndex = 9;
            this.monhocss.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.monhocss_CellClick);
            // 
            // mamonhoctt
            // 
            this.mamonhoctt.DataPropertyName = "mamonhoctt";
            this.mamonhoctt.HeaderText = "Mã môn học tự tăng";
            this.mamonhoctt.MinimumWidth = 6;
            this.mamonhoctt.Name = "mamonhoctt";
            this.mamonhoctt.Visible = false;
            this.mamonhoctt.Width = 125;
            // 
            // mamonhoc
            // 
            this.mamonhoc.DataPropertyName = "mamonhoc";
            this.mamonhoc.HeaderText = "Mã môn học";
            this.mamonhoc.MinimumWidth = 6;
            this.mamonhoc.Name = "mamonhoc";
            this.mamonhoc.Width = 125;
            // 
            // tenmonhoc
            // 
            this.tenmonhoc.DataPropertyName = "tenmonhoc";
            this.tenmonhoc.HeaderText = "Tên môn học";
            this.tenmonhoc.MinimumWidth = 6;
            this.tenmonhoc.Name = "tenmonhoc";
            this.tenmonhoc.Width = 125;
            // 
            // quyen
            // 
            this.quyen.Location = new System.Drawing.Point(1230, 111);
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
            this.label1.Location = new System.Drawing.Point(488, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 95);
            this.label1.TabIndex = 60;
            this.label1.Text = "Môn học";
            // 
            // monhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 751);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quyen);
            this.Controls.Add(this.monhocss);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.timkiems);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tenmonhocs);
            this.Controls.Add(this.tmonhoc);
            this.Controls.Add(this.mamonhocs);
            this.Controls.Add(this.mmonhoc);
            this.Name = "monhoc";
            this.Text = "monhoc";
            this.Load += new System.EventHandler(this.monhoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.monhocss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mmonhoc;
        private System.Windows.Forms.TextBox mamonhocs;
        private System.Windows.Forms.TextBox tenmonhocs;
        private System.Windows.Forms.Label tmonhoc;
        private System.Windows.Forms.TextBox timkiems;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridView monhocss;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamonhoctt;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmonhoc;
        private System.Windows.Forms.Button quyen;
        private System.Windows.Forms.Label label1;
    }
}