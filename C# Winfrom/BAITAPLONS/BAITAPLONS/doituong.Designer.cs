namespace BAITAPLONS
{
    partial class doituong
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
            this.dt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tendt = new System.Windows.Forms.Label();
            this.madoituongs = new System.Windows.Forms.TextBox();
            this.tendoituongs = new System.Windows.Forms.TextBox();
            this.timkiems = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.doituongss = new System.Windows.Forms.DataGridView();
            this.madoituongtt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madoituong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendoituong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.quyen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.doituongss)).BeginInit();
            this.SuspendLayout();
            // 
            // dt
            // 
            this.dt.AutoSize = true;
            this.dt.Location = new System.Drawing.Point(127, 178);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(84, 16);
            this.dt.TabIndex = 0;
            this.dt.Text = "Mã đối tượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tìm kiếm";
            // 
            // tendt
            // 
            this.tendt.AutoSize = true;
            this.tendt.Location = new System.Drawing.Point(558, 178);
            this.tendt.Name = "tendt";
            this.tendt.Size = new System.Drawing.Size(89, 16);
            this.tendt.TabIndex = 1;
            this.tendt.Text = "Tên đối tượng";
            // 
            // madoituongs
            // 
            this.madoituongs.Location = new System.Drawing.Point(217, 172);
            this.madoituongs.Name = "madoituongs";
            this.madoituongs.Size = new System.Drawing.Size(297, 22);
            this.madoituongs.TabIndex = 3;
            // 
            // tendoituongs
            // 
            this.tendoituongs.Location = new System.Drawing.Point(653, 172);
            this.tendoituongs.Name = "tendoituongs";
            this.tendoituongs.Size = new System.Drawing.Size(326, 22);
            this.tendoituongs.TabIndex = 4;
            // 
            // timkiems
            // 
            this.timkiems.Location = new System.Drawing.Point(386, 269);
            this.timkiems.Name = "timkiems";
            this.timkiems.Size = new System.Drawing.Size(323, 22);
            this.timkiems.TabIndex = 5;
            this.timkiems.TextChanged += new System.EventHandler(this.timkiems_TextChanged);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(282, 347);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(105, 47);
            this.add.TabIndex = 6;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(492, 347);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(105, 47);
            this.edit.TabIndex = 7;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.button2_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(693, 347);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(105, 47);
            this.delete.TabIndex = 8;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button3_Click);
            // 
            // doituongss
            // 
            this.doituongss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doituongss.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madoituongtt,
            this.madoituong,
            this.tendoituong});
            this.doituongss.Location = new System.Drawing.Point(-2, 428);
            this.doituongss.Name = "doituongss";
            this.doituongss.RowHeadersWidth = 51;
            this.doituongss.RowTemplate.Height = 24;
            this.doituongss.Size = new System.Drawing.Size(1154, 192);
            this.doituongss.TabIndex = 9;
            this.doituongss.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.doituongss_CellClick);
            // 
            // madoituongtt
            // 
            this.madoituongtt.DataPropertyName = "madoituongtt";
            this.madoituongtt.HeaderText = "Mã Đối tượng tự tăng";
            this.madoituongtt.MinimumWidth = 6;
            this.madoituongtt.Name = "madoituongtt";
            this.madoituongtt.Visible = false;
            this.madoituongtt.Width = 125;
            // 
            // madoituong
            // 
            this.madoituong.DataPropertyName = "madoituong";
            this.madoituong.HeaderText = "Mã đối tượng";
            this.madoituong.MinimumWidth = 6;
            this.madoituong.Name = "madoituong";
            this.madoituong.Width = 125;
            // 
            // tendoituong
            // 
            this.tendoituong.DataPropertyName = "tendoituong";
            this.tendoituong.HeaderText = "Tên đối tượng";
            this.tendoituong.MinimumWidth = 6;
            this.tendoituong.Name = "tendoituong";
            this.tendoituong.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 95);
            this.label1.TabIndex = 10;
            this.label1.Text = "Đối tượng";
            // 
            // quyen
            // 
            this.quyen.Location = new System.Drawing.Point(1042, 53);
            this.quyen.Name = "quyen";
            this.quyen.Size = new System.Drawing.Size(103, 42);
            this.quyen.TabIndex = 59;
            this.quyen.Text = "button1";
            this.quyen.UseVisualStyleBackColor = true;
            // 
            // doituong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 620);
            this.Controls.Add(this.quyen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doituongss);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.timkiems);
            this.Controls.Add(this.tendoituongs);
            this.Controls.Add(this.madoituongs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tendt);
            this.Controls.Add(this.dt);
            this.Name = "doituong";
            this.Text = "doituong";
            this.Load += new System.EventHandler(this.doituong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.doituongss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tendt;
        private System.Windows.Forms.TextBox madoituongs;
        private System.Windows.Forms.TextBox tendoituongs;
        private System.Windows.Forms.TextBox timkiems;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridView doituongss;
        private System.Windows.Forms.DataGridViewTextBoxColumn madoituongtt;
        private System.Windows.Forms.DataGridViewTextBoxColumn madoituong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendoituong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button quyen;
    }
}