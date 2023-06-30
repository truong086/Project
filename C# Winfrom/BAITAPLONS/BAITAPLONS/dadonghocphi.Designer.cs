namespace BAITAPLONS
{
    partial class dadonghocphi
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
            this.cdhp = new System.Windows.Forms.DataGridView();
            this.masvtt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madoituong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.quyen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cdhp)).BeginInit();
            this.SuspendLayout();
            // 
            // cdhp
            // 
            this.cdhp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cdhp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masvtt,
            this.msv,
            this.madoituong,
            this.malop,
            this.hoten,
            this.ngaysinh,
            this.diachi,
            this.gioitinh});
            this.cdhp.Location = new System.Drawing.Point(3, 272);
            this.cdhp.Name = "cdhp";
            this.cdhp.RowHeadersWidth = 51;
            this.cdhp.RowTemplate.Height = 24;
            this.cdhp.Size = new System.Drawing.Size(1210, 373);
            this.cdhp.TabIndex = 56;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(763, 95);
            this.label1.TabIndex = 57;
            this.label1.Text = "Chưa đóng học phí";
            // 
            // quyen
            // 
            this.quyen.Location = new System.Drawing.Point(1101, 33);
            this.quyen.Name = "quyen";
            this.quyen.Size = new System.Drawing.Size(103, 42);
            this.quyen.TabIndex = 58;
            this.quyen.Text = "button1";
            this.quyen.UseVisualStyleBackColor = true;
            // 
            // dadonghocphi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 644);
            this.Controls.Add(this.quyen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cdhp);
            this.Name = "dadonghocphi";
            this.Text = "dadonghocphi";
            this.Load += new System.EventHandler(this.dadonghocphi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cdhp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView cdhp;
        private System.Windows.Forms.DataGridViewTextBoxColumn masvtt;
        private System.Windows.Forms.DataGridViewTextBoxColumn msv;
        private System.Windows.Forms.DataGridViewTextBoxColumn madoituong;
        private System.Windows.Forms.DataGridViewTextBoxColumn malop;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button quyen;
    }
}