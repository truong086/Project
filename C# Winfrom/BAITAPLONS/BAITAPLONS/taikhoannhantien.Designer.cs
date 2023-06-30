namespace BAITAPLONS
{
    partial class taikhoannhantien
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
            this.taikhoannhantiens = new System.Windows.Forms.DataGridView();
            this.mataikhoannhantien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennganhhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenchinhanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotaikhoanNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentaikhoanNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaytao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tnh = new System.Windows.Forms.Label();
            this.cn = new System.Windows.Forms.Label();
            this.stk = new System.Windows.Forms.Label();
            this.ttk = new System.Windows.Forms.Label();
            this.nt = new System.Windows.Forms.Label();
            this.tennganhangs = new System.Windows.Forms.TextBox();
            this.ngaytaos = new System.Windows.Forms.TextBox();
            this.sotaikhoans = new System.Windows.Forms.TextBox();
            this.tentaikhoans = new System.Windows.Forms.TextBox();
            this.tenchinhanhs = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.timkiems = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.quyen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.taikhoannhantiens)).BeginInit();
            this.SuspendLayout();
            // 
            // taikhoannhantiens
            // 
            this.taikhoannhantiens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taikhoannhantiens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mataikhoannhantien,
            this.tennganhhang,
            this.tenchinhanh,
            this.sotaikhoanNT,
            this.tentaikhoanNT,
            this.ngaytao});
            this.taikhoannhantiens.Location = new System.Drawing.Point(0, 458);
            this.taikhoannhantiens.Name = "taikhoannhantiens";
            this.taikhoannhantiens.RowHeadersWidth = 51;
            this.taikhoannhantiens.RowTemplate.Height = 24;
            this.taikhoannhantiens.Size = new System.Drawing.Size(1350, 280);
            this.taikhoannhantiens.TabIndex = 0;
            this.taikhoannhantiens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.taikhoannhantiens_CellClick);
            // 
            // mataikhoannhantien
            // 
            this.mataikhoannhantien.DataPropertyName = "mataikhoannhantien";
            this.mataikhoannhantien.HeaderText = "Mã tài khoản nhận tiền";
            this.mataikhoannhantien.MinimumWidth = 6;
            this.mataikhoannhantien.Name = "mataikhoannhantien";
            this.mataikhoannhantien.Width = 125;
            // 
            // tennganhhang
            // 
            this.tennganhhang.DataPropertyName = "tennganhhang";
            this.tennganhhang.HeaderText = "Tên ngân hàng";
            this.tennganhhang.MinimumWidth = 6;
            this.tennganhhang.Name = "tennganhhang";
            this.tennganhhang.Width = 125;
            // 
            // tenchinhanh
            // 
            this.tenchinhanh.DataPropertyName = "tenchinhanh";
            this.tenchinhanh.HeaderText = "Tên chi nhánh";
            this.tenchinhanh.MinimumWidth = 6;
            this.tenchinhanh.Name = "tenchinhanh";
            this.tenchinhanh.Width = 125;
            // 
            // sotaikhoanNT
            // 
            this.sotaikhoanNT.DataPropertyName = "sotaikhoanNT";
            this.sotaikhoanNT.HeaderText = "Số tài khoản";
            this.sotaikhoanNT.MinimumWidth = 6;
            this.sotaikhoanNT.Name = "sotaikhoanNT";
            this.sotaikhoanNT.Width = 125;
            // 
            // tentaikhoanNT
            // 
            this.tentaikhoanNT.DataPropertyName = "tentaikhoanNT";
            this.tentaikhoanNT.HeaderText = "Tên tài khoản";
            this.tentaikhoanNT.MinimumWidth = 6;
            this.tentaikhoanNT.Name = "tentaikhoanNT";
            this.tentaikhoanNT.Width = 125;
            // 
            // ngaytao
            // 
            this.ngaytao.DataPropertyName = "ngaytao";
            this.ngaytao.HeaderText = "Ngày tạo";
            this.ngaytao.MinimumWidth = 6;
            this.ngaytao.Name = "ngaytao";
            this.ngaytao.Width = 125;
            // 
            // tnh
            // 
            this.tnh.AutoSize = true;
            this.tnh.Location = new System.Drawing.Point(32, 184);
            this.tnh.Name = "tnh";
            this.tnh.Size = new System.Drawing.Size(97, 16);
            this.tnh.TabIndex = 2;
            this.tnh.Text = "Tên ngân hàng";
            // 
            // cn
            // 
            this.cn.AutoSize = true;
            this.cn.Location = new System.Drawing.Point(709, 184);
            this.cn.Name = "cn";
            this.cn.Size = new System.Drawing.Size(84, 16);
            this.cn.TabIndex = 3;
            this.cn.Text = "tên chi nhánh";
            // 
            // stk
            // 
            this.stk.AutoSize = true;
            this.stk.Location = new System.Drawing.Point(493, 287);
            this.stk.Name = "stk";
            this.stk.Size = new System.Drawing.Size(81, 16);
            this.stk.TabIndex = 4;
            this.stk.Text = "Số tài khoản";
            // 
            // ttk
            // 
            this.ttk.AutoSize = true;
            this.ttk.Location = new System.Drawing.Point(371, 184);
            this.ttk.Name = "ttk";
            this.ttk.Size = new System.Drawing.Size(88, 16);
            this.ttk.TabIndex = 5;
            this.ttk.Text = "Tên tài khoản";
            // 
            // nt
            // 
            this.nt.AutoSize = true;
            this.nt.Location = new System.Drawing.Point(1035, 187);
            this.nt.Name = "nt";
            this.nt.Size = new System.Drawing.Size(62, 16);
            this.nt.TabIndex = 6;
            this.nt.Text = "Ngày tạo";
            // 
            // tennganhangs
            // 
            this.tennganhangs.Location = new System.Drawing.Point(135, 178);
            this.tennganhangs.Name = "tennganhangs";
            this.tennganhangs.Size = new System.Drawing.Size(215, 22);
            this.tennganhangs.TabIndex = 8;
            // 
            // ngaytaos
            // 
            this.ngaytaos.Location = new System.Drawing.Point(1103, 184);
            this.ngaytaos.Name = "ngaytaos";
            this.ngaytaos.Size = new System.Drawing.Size(215, 22);
            this.ngaytaos.TabIndex = 9;
            // 
            // sotaikhoans
            // 
            this.sotaikhoans.Location = new System.Drawing.Point(589, 281);
            this.sotaikhoans.Name = "sotaikhoans";
            this.sotaikhoans.Size = new System.Drawing.Size(215, 22);
            this.sotaikhoans.TabIndex = 10;
            // 
            // tentaikhoans
            // 
            this.tentaikhoans.Location = new System.Drawing.Point(465, 181);
            this.tentaikhoans.Name = "tentaikhoans";
            this.tentaikhoans.Size = new System.Drawing.Size(215, 22);
            this.tentaikhoans.TabIndex = 11;
            // 
            // tenchinhanhs
            // 
            this.tenchinhanhs.Location = new System.Drawing.Point(799, 181);
            this.tenchinhanhs.Name = "tenchinhanhs";
            this.tenchinhanhs.Size = new System.Drawing.Size(215, 22);
            this.tenchinhanhs.TabIndex = 12;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(242, 372);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(138, 50);
            this.add.TabIndex = 13;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(460, 372);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(138, 50);
            this.edit.TabIndex = 14;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(681, 372);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(138, 50);
            this.delete.TabIndex = 15;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // timkiems
            // 
            this.timkiems.Location = new System.Drawing.Point(1017, 386);
            this.timkiems.Name = "timkiems";
            this.timkiems.Size = new System.Drawing.Size(215, 22);
            this.timkiems.TabIndex = 17;
            this.timkiems.TextChanged += new System.EventHandler(this.timkiems_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(943, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tìm kiếm";
            // 
            // quyen
            // 
            this.quyen.Location = new System.Drawing.Point(1247, 274);
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
            this.label1.Location = new System.Drawing.Point(132, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1100, 95);
            this.label1.TabIndex = 60;
            this.label1.Text = "Tài khoản nhận tiền học phí";
            // 
            // taikhoannhantien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quyen);
            this.Controls.Add(this.timkiems);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.tenchinhanhs);
            this.Controls.Add(this.tentaikhoans);
            this.Controls.Add(this.sotaikhoans);
            this.Controls.Add(this.ngaytaos);
            this.Controls.Add(this.tennganhangs);
            this.Controls.Add(this.nt);
            this.Controls.Add(this.ttk);
            this.Controls.Add(this.stk);
            this.Controls.Add(this.cn);
            this.Controls.Add(this.tnh);
            this.Controls.Add(this.taikhoannhantiens);
            this.Name = "taikhoannhantien";
            this.Text = "taikhoannhantien";
            this.Load += new System.EventHandler(this.taikhoannhantien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taikhoannhantiens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView taikhoannhantiens;
        private System.Windows.Forms.Label tnh;
        private System.Windows.Forms.Label cn;
        private System.Windows.Forms.Label stk;
        private System.Windows.Forms.Label ttk;
        private System.Windows.Forms.Label nt;
        private System.Windows.Forms.TextBox tennganhangs;
        private System.Windows.Forms.TextBox ngaytaos;
        private System.Windows.Forms.TextBox sotaikhoans;
        private System.Windows.Forms.TextBox tentaikhoans;
        private System.Windows.Forms.TextBox tenchinhanhs;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox timkiems;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn mataikhoannhantien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennganhhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenchinhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotaikhoanNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentaikhoanNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaytao;
        private System.Windows.Forms.Button quyen;
        private System.Windows.Forms.Label label1;
    }
}