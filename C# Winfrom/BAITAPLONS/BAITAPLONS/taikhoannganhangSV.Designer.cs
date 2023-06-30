namespace BAITAPLONS
{
    partial class taikhoannganhangSV
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
            this.mtk = new System.Windows.Forms.Label();
            this.tnh = new System.Windows.Forms.Label();
            this.stk = new System.Windows.Forms.Label();
            this.cn = new System.Windows.Forms.Label();
            this.nt = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.manganhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennganhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chinhanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotaikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentaikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaytao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msvs = new System.Windows.Forms.TextBox();
            this.ngaytaos = new System.Windows.Forms.TextBox();
            this.chinhanhs = new System.Windows.Forms.TextBox();
            this.sotaikhoans = new System.Windows.Forms.TextBox();
            this.tennganhangs = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.tentaikhoans = new System.Windows.Forms.TextBox();
            this.ttk = new System.Windows.Forms.Label();
            this.value = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.quyen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // mtk
            // 
            this.mtk.AutoSize = true;
            this.mtk.Location = new System.Drawing.Point(69, 166);
            this.mtk.Name = "mtk";
            this.mtk.Size = new System.Drawing.Size(81, 16);
            this.mtk.TabIndex = 0;
            this.mtk.Text = "Mã sinh viên";
            // 
            // tnh
            // 
            this.tnh.AutoSize = true;
            this.tnh.Location = new System.Drawing.Point(668, 163);
            this.tnh.Name = "tnh";
            this.tnh.Size = new System.Drawing.Size(97, 16);
            this.tnh.TabIndex = 1;
            this.tnh.Text = "Tên ngân hàng";
            // 
            // stk
            // 
            this.stk.AutoSize = true;
            this.stk.Location = new System.Drawing.Point(372, 166);
            this.stk.Name = "stk";
            this.stk.Size = new System.Drawing.Size(81, 16);
            this.stk.TabIndex = 2;
            this.stk.Text = "Số tài khoản";
            // 
            // cn
            // 
            this.cn.AutoSize = true;
            this.cn.Location = new System.Drawing.Point(68, 228);
            this.cn.Name = "cn";
            this.cn.Size = new System.Drawing.Size(68, 16);
            this.cn.TabIndex = 3;
            this.cn.Text = "Chi Nhánh";
            // 
            // nt
            // 
            this.nt.AutoSize = true;
            this.nt.Location = new System.Drawing.Point(372, 234);
            this.nt.Name = "nt";
            this.nt.Size = new System.Drawing.Size(68, 16);
            this.nt.TabIndex = 4;
            this.nt.Text = "Ngày Tạo";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manganhang,
            this.msv,
            this.tennganhang,
            this.chinhanh,
            this.sotaikhoan,
            this.tentaikhoan,
            this.ngaytao});
            this.dataGridView2.Location = new System.Drawing.Point(-3, 340);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1345, 314);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // manganhang
            // 
            this.manganhang.DataPropertyName = "manganhang";
            this.manganhang.HeaderText = "Mã ngân hàng";
            this.manganhang.MinimumWidth = 6;
            this.manganhang.Name = "manganhang";
            this.manganhang.Visible = false;
            this.manganhang.Width = 125;
            // 
            // msv
            // 
            this.msv.DataPropertyName = "msv";
            this.msv.HeaderText = "msv";
            this.msv.MinimumWidth = 6;
            this.msv.Name = "msv";
            this.msv.Width = 125;
            // 
            // tennganhang
            // 
            this.tennganhang.DataPropertyName = "tennganhang";
            this.tennganhang.HeaderText = "Tên ngân hàng";
            this.tennganhang.MinimumWidth = 6;
            this.tennganhang.Name = "tennganhang";
            this.tennganhang.Width = 125;
            // 
            // chinhanh
            // 
            this.chinhanh.DataPropertyName = "chinhanh";
            this.chinhanh.HeaderText = "Chi Nhánh";
            this.chinhanh.MinimumWidth = 6;
            this.chinhanh.Name = "chinhanh";
            this.chinhanh.Width = 125;
            // 
            // sotaikhoan
            // 
            this.sotaikhoan.DataPropertyName = "sotaikhoan";
            this.sotaikhoan.HeaderText = "Số tài khoản";
            this.sotaikhoan.MinimumWidth = 6;
            this.sotaikhoan.Name = "sotaikhoan";
            this.sotaikhoan.Width = 125;
            // 
            // tentaikhoan
            // 
            this.tentaikhoan.DataPropertyName = "tentaikhoan";
            this.tentaikhoan.HeaderText = "Tên tài khoản";
            this.tentaikhoan.MinimumWidth = 6;
            this.tentaikhoan.Name = "tentaikhoan";
            this.tentaikhoan.Width = 125;
            // 
            // ngaytao
            // 
            this.ngaytao.DataPropertyName = "ngaytao";
            this.ngaytao.HeaderText = "Ngày tạo";
            this.ngaytao.MinimumWidth = 6;
            this.ngaytao.Name = "ngaytao";
            this.ngaytao.Width = 125;
            // 
            // msvs
            // 
            this.msvs.Location = new System.Drawing.Point(156, 160);
            this.msvs.Name = "msvs";
            this.msvs.Size = new System.Drawing.Size(173, 22);
            this.msvs.TabIndex = 6;
            // 
            // ngaytaos
            // 
            this.ngaytaos.Location = new System.Drawing.Point(459, 228);
            this.ngaytaos.Name = "ngaytaos";
            this.ngaytaos.Size = new System.Drawing.Size(173, 22);
            this.ngaytaos.TabIndex = 7;
            // 
            // chinhanhs
            // 
            this.chinhanhs.Location = new System.Drawing.Point(142, 222);
            this.chinhanhs.Name = "chinhanhs";
            this.chinhanhs.Size = new System.Drawing.Size(173, 22);
            this.chinhanhs.TabIndex = 8;
            // 
            // sotaikhoans
            // 
            this.sotaikhoans.Location = new System.Drawing.Point(459, 160);
            this.sotaikhoans.Name = "sotaikhoans";
            this.sotaikhoans.Size = new System.Drawing.Size(173, 22);
            this.sotaikhoans.TabIndex = 9;
            // 
            // tennganhangs
            // 
            this.tennganhangs.Location = new System.Drawing.Point(771, 157);
            this.tennganhangs.Name = "tennganhangs";
            this.tennganhangs.Size = new System.Drawing.Size(173, 22);
            this.tennganhangs.TabIndex = 10;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(321, 286);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 11;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(472, 286);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 23);
            this.edit.TabIndex = 12;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.button2_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(630, 286);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 13;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button3_Click);
            // 
            // tentaikhoans
            // 
            this.tentaikhoans.Location = new System.Drawing.Point(1099, 157);
            this.tentaikhoans.Name = "tentaikhoans";
            this.tentaikhoans.Size = new System.Drawing.Size(173, 22);
            this.tentaikhoans.TabIndex = 15;
            // 
            // ttk
            // 
            this.ttk.AutoSize = true;
            this.ttk.Location = new System.Drawing.Point(1005, 163);
            this.ttk.Name = "ttk";
            this.ttk.Size = new System.Drawing.Size(88, 16);
            this.ttk.TabIndex = 14;
            this.ttk.Text = "Tên tài khoản";
            // 
            // value
            // 
            this.value.Location = new System.Drawing.Point(924, 286);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(173, 22);
            this.value.TabIndex = 17;
            this.value.TextChanged += new System.EventHandler(this.value_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(837, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1215, 95);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tài khoản ngân hàng sinh viên";
            // 
            // quyen
            // 
            this.quyen.Location = new System.Drawing.Point(1221, 202);
            this.quyen.Name = "quyen";
            this.quyen.Size = new System.Drawing.Size(103, 42);
            this.quyen.TabIndex = 59;
            this.quyen.Text = "button1";
            this.quyen.UseVisualStyleBackColor = true;
            // 
            // taikhoannganhangSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 646);
            this.Controls.Add(this.quyen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.value);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tentaikhoans);
            this.Controls.Add(this.ttk);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.tennganhangs);
            this.Controls.Add(this.sotaikhoans);
            this.Controls.Add(this.chinhanhs);
            this.Controls.Add(this.ngaytaos);
            this.Controls.Add(this.msvs);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.nt);
            this.Controls.Add(this.cn);
            this.Controls.Add(this.stk);
            this.Controls.Add(this.tnh);
            this.Controls.Add(this.mtk);
            this.Name = "taikhoannganhangSV";
            this.Text = "taikhoannganhangSV";
            this.Load += new System.EventHandler(this.taikhoannganhangSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mtk;
        private System.Windows.Forms.Label tnh;
        private System.Windows.Forms.Label stk;
        private System.Windows.Forms.Label cn;
        private System.Windows.Forms.Label nt;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox msvs;
        private System.Windows.Forms.TextBox ngaytaos;
        private System.Windows.Forms.TextBox chinhanhs;
        private System.Windows.Forms.TextBox sotaikhoans;
        private System.Windows.Forms.TextBox tennganhangs;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox tentaikhoans;
        private System.Windows.Forms.Label ttk;
        private System.Windows.Forms.DataGridViewTextBoxColumn manganhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn msv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennganhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn chinhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotaikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentaikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaytao;
        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button quyen;
    }
}