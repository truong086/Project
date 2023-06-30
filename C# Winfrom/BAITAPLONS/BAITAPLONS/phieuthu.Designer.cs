namespace BAITAPLONS
{
    partial class phieuthu
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
            this.phieuthuss = new System.Windows.Forms.DataGridView();
            this.maphieuthutt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maphieuthu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mamonhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkhoanthu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaythu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mataikhoannganhangSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mataikhoannhantienHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msphieuthu = new System.Windows.Forms.Label();
            this.mhphieuthu = new System.Windows.Forms.Label();
            this.tkphieuthu = new System.Windows.Forms.Label();
            this.nhphieuthu = new System.Windows.Forms.Label();
            this.hkphieuthu = new System.Windows.Forms.Label();
            this.htphieuthu = new System.Windows.Forms.Label();
            this.tknhphieuthu = new System.Windows.Forms.Label();
            this.tkntphieuthu = new System.Windows.Forms.Label();
            this.sphieuthu = new System.Windows.Forms.Label();
            this.nphieuthu = new System.Windows.Forms.Label();
            this.msvs = new System.Windows.Forms.TextBox();
            this.mamonhocs = new System.Windows.Forms.TextBox();
            this.tenphieuthus = new System.Windows.Forms.TextBox();
            this.hockys = new System.Windows.Forms.TextBox();
            this.hinhthucs = new System.Windows.Forms.TextBox();
            this.namhocs = new System.Windows.Forms.TextBox();
            this.sotiens = new System.Windows.Forms.TextBox();
            this.ngaythus = new System.Windows.Forms.TextBox();
            this.mataikhoannhantienHPs = new System.Windows.Forms.TextBox();
            this.mataikhoannganhangSVs = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.timkiems = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.quyen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.phieuthuss)).BeginInit();
            this.SuspendLayout();
            // 
            // phieuthuss
            // 
            this.phieuthuss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phieuthuss.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphieuthutt,
            this.maphieuthu,
            this.msv,
            this.mamonhoc,
            this.tenkhoanthu,
            this.namhoc,
            this.hocky,
            this.ngaythu,
            this.sotien,
            this.hinhthuc,
            this.mataikhoannganhangSV,
            this.mataikhoannhantienHP});
            this.phieuthuss.Location = new System.Drawing.Point(1, 401);
            this.phieuthuss.Name = "phieuthuss";
            this.phieuthuss.RowHeadersWidth = 51;
            this.phieuthuss.RowTemplate.Height = 24;
            this.phieuthuss.Size = new System.Drawing.Size(1434, 326);
            this.phieuthuss.TabIndex = 0;
            this.phieuthuss.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.phieuthuss_CellClick);
            this.phieuthuss.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.phieuthuss_CellContentClick);
            // 
            // maphieuthutt
            // 
            this.maphieuthutt.DataPropertyName = "maphieuthutt";
            this.maphieuthutt.HeaderText = "Mã phiếu thu tự tăng";
            this.maphieuthutt.MinimumWidth = 6;
            this.maphieuthutt.Name = "maphieuthutt";
            this.maphieuthutt.Visible = false;
            this.maphieuthutt.Width = 125;
            // 
            // maphieuthu
            // 
            this.maphieuthu.DataPropertyName = "maphieuthu";
            this.maphieuthu.HeaderText = "Mã phiếu thu";
            this.maphieuthu.MinimumWidth = 6;
            this.maphieuthu.Name = "maphieuthu";
            this.maphieuthu.Width = 125;
            // 
            // msv
            // 
            this.msv.DataPropertyName = "msv";
            this.msv.HeaderText = "Mã sinh viên";
            this.msv.MinimumWidth = 6;
            this.msv.Name = "msv";
            this.msv.Width = 125;
            // 
            // mamonhoc
            // 
            this.mamonhoc.DataPropertyName = "mamonhoc";
            this.mamonhoc.HeaderText = "Mã môn học";
            this.mamonhoc.MinimumWidth = 6;
            this.mamonhoc.Name = "mamonhoc";
            this.mamonhoc.Width = 125;
            // 
            // tenkhoanthu
            // 
            this.tenkhoanthu.DataPropertyName = "tenkhoanthu";
            this.tenkhoanthu.HeaderText = "Tên khoản thu";
            this.tenkhoanthu.MinimumWidth = 6;
            this.tenkhoanthu.Name = "tenkhoanthu";
            this.tenkhoanthu.Width = 125;
            // 
            // namhoc
            // 
            this.namhoc.DataPropertyName = "namhoc";
            this.namhoc.HeaderText = "Năm học";
            this.namhoc.MinimumWidth = 6;
            this.namhoc.Name = "namhoc";
            this.namhoc.Width = 125;
            // 
            // hocky
            // 
            this.hocky.DataPropertyName = "hocky";
            this.hocky.HeaderText = "Học kỳ";
            this.hocky.MinimumWidth = 6;
            this.hocky.Name = "hocky";
            this.hocky.Width = 125;
            // 
            // ngaythu
            // 
            this.ngaythu.DataPropertyName = "ngaythu";
            this.ngaythu.HeaderText = "Ngày thu";
            this.ngaythu.MinimumWidth = 6;
            this.ngaythu.Name = "ngaythu";
            this.ngaythu.Width = 125;
            // 
            // sotien
            // 
            this.sotien.DataPropertyName = "sotien";
            this.sotien.HeaderText = "số tiền";
            this.sotien.MinimumWidth = 6;
            this.sotien.Name = "sotien";
            this.sotien.Width = 125;
            // 
            // hinhthuc
            // 
            this.hinhthuc.DataPropertyName = "hinhthuc";
            this.hinhthuc.HeaderText = "Hình thức";
            this.hinhthuc.MinimumWidth = 6;
            this.hinhthuc.Name = "hinhthuc";
            this.hinhthuc.Width = 125;
            // 
            // mataikhoannganhangSV
            // 
            this.mataikhoannganhangSV.DataPropertyName = "mataikhoannganhangSV";
            this.mataikhoannganhangSV.HeaderText = "Mã tài khoản ngân hàng sinh viên";
            this.mataikhoannganhangSV.MinimumWidth = 6;
            this.mataikhoannganhangSV.Name = "mataikhoannganhangSV";
            this.mataikhoannganhangSV.Width = 125;
            // 
            // mataikhoannhantienHP
            // 
            this.mataikhoannhantienHP.DataPropertyName = "mataikhoannhantienHP";
            this.mataikhoannhantienHP.HeaderText = "mã tài khoản nhận tiền học phí";
            this.mataikhoannhantienHP.MinimumWidth = 6;
            this.mataikhoannhantienHP.Name = "mataikhoannhantienHP";
            this.mataikhoannhantienHP.Width = 125;
            // 
            // msphieuthu
            // 
            this.msphieuthu.AutoSize = true;
            this.msphieuthu.Location = new System.Drawing.Point(69, 109);
            this.msphieuthu.Name = "msphieuthu";
            this.msphieuthu.Size = new System.Drawing.Size(81, 16);
            this.msphieuthu.TabIndex = 2;
            this.msphieuthu.Text = "Mã sinh viên";
            // 
            // mhphieuthu
            // 
            this.mhphieuthu.AutoSize = true;
            this.mhphieuthu.Location = new System.Drawing.Point(69, 167);
            this.mhphieuthu.Name = "mhphieuthu";
            this.mhphieuthu.Size = new System.Drawing.Size(80, 16);
            this.mhphieuthu.TabIndex = 3;
            this.mhphieuthu.Text = "Mã môn học";
            // 
            // tkphieuthu
            // 
            this.tkphieuthu.AutoSize = true;
            this.tkphieuthu.Location = new System.Drawing.Point(69, 233);
            this.tkphieuthu.Name = "tkphieuthu";
            this.tkphieuthu.Size = new System.Drawing.Size(91, 16);
            this.tkphieuthu.TabIndex = 4;
            this.tkphieuthu.Text = "Tên khoản thu";
            // 
            // nhphieuthu
            // 
            this.nhphieuthu.AutoSize = true;
            this.nhphieuthu.Location = new System.Drawing.Point(567, 93);
            this.nhphieuthu.Name = "nhphieuthu";
            this.nhphieuthu.Size = new System.Drawing.Size(61, 16);
            this.nhphieuthu.TabIndex = 5;
            this.nhphieuthu.Text = "Năm học";
            // 
            // hkphieuthu
            // 
            this.hkphieuthu.AutoSize = true;
            this.hkphieuthu.Location = new System.Drawing.Point(574, 146);
            this.hkphieuthu.Name = "hkphieuthu";
            this.hkphieuthu.Size = new System.Drawing.Size(49, 16);
            this.hkphieuthu.TabIndex = 6;
            this.hkphieuthu.Text = "Học kỳ";
            // 
            // htphieuthu
            // 
            this.htphieuthu.AutoSize = true;
            this.htphieuthu.Location = new System.Drawing.Point(990, 93);
            this.htphieuthu.Name = "htphieuthu";
            this.htphieuthu.Size = new System.Drawing.Size(61, 16);
            this.htphieuthu.TabIndex = 7;
            this.htphieuthu.Text = "Hình thức";
            // 
            // tknhphieuthu
            // 
            this.tknhphieuthu.AutoSize = true;
            this.tknhphieuthu.Location = new System.Drawing.Point(990, 164);
            this.tknhphieuthu.Name = "tknhphieuthu";
            this.tknhphieuthu.Size = new System.Drawing.Size(90, 16);
            this.tknhphieuthu.TabIndex = 8;
            this.tknhphieuthu.Text = "Mã TK NH SV";
            // 
            // tkntphieuthu
            // 
            this.tkntphieuthu.AutoSize = true;
            this.tkntphieuthu.Location = new System.Drawing.Point(990, 216);
            this.tkntphieuthu.Name = "tkntphieuthu";
            this.tkntphieuthu.Size = new System.Drawing.Size(90, 16);
            this.tkntphieuthu.TabIndex = 9;
            this.tkntphieuthu.Text = "Mã TK NT HP";
            // 
            // sphieuthu
            // 
            this.sphieuthu.AutoSize = true;
            this.sphieuthu.Location = new System.Drawing.Point(574, 270);
            this.sphieuthu.Name = "sphieuthu";
            this.sphieuthu.Size = new System.Drawing.Size(48, 16);
            this.sphieuthu.TabIndex = 10;
            this.sphieuthu.Text = "Số tiền";
            // 
            // nphieuthu
            // 
            this.nphieuthu.AutoSize = true;
            this.nphieuthu.Location = new System.Drawing.Point(574, 204);
            this.nphieuthu.Name = "nphieuthu";
            this.nphieuthu.Size = new System.Drawing.Size(60, 16);
            this.nphieuthu.TabIndex = 11;
            this.nphieuthu.Text = "Ngày thu";
            // 
            // msvs
            // 
            this.msvs.Location = new System.Drawing.Point(156, 106);
            this.msvs.Name = "msvs";
            this.msvs.Size = new System.Drawing.Size(291, 22);
            this.msvs.TabIndex = 13;
            // 
            // mamonhocs
            // 
            this.mamonhocs.Location = new System.Drawing.Point(157, 167);
            this.mamonhocs.Name = "mamonhocs";
            this.mamonhocs.Size = new System.Drawing.Size(291, 22);
            this.mamonhocs.TabIndex = 14;
            // 
            // tenphieuthus
            // 
            this.tenphieuthus.Location = new System.Drawing.Point(166, 227);
            this.tenphieuthus.Name = "tenphieuthus";
            this.tenphieuthus.Size = new System.Drawing.Size(291, 22);
            this.tenphieuthus.TabIndex = 15;
            // 
            // hockys
            // 
            this.hockys.Location = new System.Drawing.Point(632, 146);
            this.hockys.Name = "hockys";
            this.hockys.Size = new System.Drawing.Size(291, 22);
            this.hockys.TabIndex = 16;
            // 
            // hinhthucs
            // 
            this.hinhthucs.Location = new System.Drawing.Point(1055, 90);
            this.hinhthucs.Name = "hinhthucs";
            this.hinhthucs.Size = new System.Drawing.Size(291, 22);
            this.hinhthucs.TabIndex = 17;
            // 
            // namhocs
            // 
            this.namhocs.Location = new System.Drawing.Point(634, 93);
            this.namhocs.Name = "namhocs";
            this.namhocs.Size = new System.Drawing.Size(291, 22);
            this.namhocs.TabIndex = 18;
            // 
            // sotiens
            // 
            this.sotiens.Location = new System.Drawing.Point(644, 270);
            this.sotiens.Name = "sotiens";
            this.sotiens.Size = new System.Drawing.Size(291, 22);
            this.sotiens.TabIndex = 19;
            // 
            // ngaythus
            // 
            this.ngaythus.Location = new System.Drawing.Point(640, 201);
            this.ngaythus.Name = "ngaythus";
            this.ngaythus.Size = new System.Drawing.Size(291, 22);
            this.ngaythus.TabIndex = 20;
            // 
            // mataikhoannhantienHPs
            // 
            this.mataikhoannhantienHPs.Location = new System.Drawing.Point(1055, 213);
            this.mataikhoannhantienHPs.Name = "mataikhoannhantienHPs";
            this.mataikhoannhantienHPs.Size = new System.Drawing.Size(291, 22);
            this.mataikhoannhantienHPs.TabIndex = 21;
            // 
            // mataikhoannganhangSVs
            // 
            this.mataikhoannganhangSVs.Location = new System.Drawing.Point(1086, 158);
            this.mataikhoannganhangSVs.Name = "mataikhoannganhangSVs";
            this.mataikhoannganhangSVs.Size = new System.Drawing.Size(260, 22);
            this.mataikhoannganhangSVs.TabIndex = 22;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(370, 343);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(125, 41);
            this.add.TabIndex = 23;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(577, 343);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(125, 41);
            this.edit.TabIndex = 24;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.button2_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(798, 343);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(125, 41);
            this.delete.TabIndex = 25;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button3_Click);
            // 
            // timkiems
            // 
            this.timkiems.Location = new System.Drawing.Point(1055, 343);
            this.timkiems.Name = "timkiems";
            this.timkiems.Size = new System.Drawing.Size(291, 22);
            this.timkiems.TabIndex = 27;
            this.timkiems.TextChanged += new System.EventHandler(this.timkiems_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(990, 346);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 16);
            this.label12.TabIndex = 26;
            this.label12.Text = "Tìm kiếm ";
            // 
            // quyen
            // 
            this.quyen.Location = new System.Drawing.Point(1243, 270);
            this.quyen.Name = "quyen";
            this.quyen.Size = new System.Drawing.Size(103, 42);
            this.quyen.TabIndex = 59;
            this.quyen.Text = "button1";
            this.quyen.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(560, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 58);
            this.label1.TabIndex = 60;
            this.label1.Text = "Phiếu thu";
            // 
            // phieuthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 727);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quyen);
            this.Controls.Add(this.timkiems);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.mataikhoannganhangSVs);
            this.Controls.Add(this.mataikhoannhantienHPs);
            this.Controls.Add(this.ngaythus);
            this.Controls.Add(this.sotiens);
            this.Controls.Add(this.namhocs);
            this.Controls.Add(this.hinhthucs);
            this.Controls.Add(this.hockys);
            this.Controls.Add(this.tenphieuthus);
            this.Controls.Add(this.mamonhocs);
            this.Controls.Add(this.msvs);
            this.Controls.Add(this.nphieuthu);
            this.Controls.Add(this.sphieuthu);
            this.Controls.Add(this.tkntphieuthu);
            this.Controls.Add(this.tknhphieuthu);
            this.Controls.Add(this.htphieuthu);
            this.Controls.Add(this.hkphieuthu);
            this.Controls.Add(this.nhphieuthu);
            this.Controls.Add(this.tkphieuthu);
            this.Controls.Add(this.mhphieuthu);
            this.Controls.Add(this.msphieuthu);
            this.Controls.Add(this.phieuthuss);
            this.Name = "phieuthu";
            this.Text = "phieuthu";
            this.Load += new System.EventHandler(this.phieuthu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phieuthuss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView phieuthuss;
        private System.Windows.Forms.Label msphieuthu;
        private System.Windows.Forms.Label mhphieuthu;
        private System.Windows.Forms.Label tkphieuthu;
        private System.Windows.Forms.Label nhphieuthu;
        private System.Windows.Forms.Label hkphieuthu;
        private System.Windows.Forms.Label htphieuthu;
        private System.Windows.Forms.Label tknhphieuthu;
        private System.Windows.Forms.Label tkntphieuthu;
        private System.Windows.Forms.Label sphieuthu;
        private System.Windows.Forms.Label nphieuthu;
        private System.Windows.Forms.TextBox msvs;
        private System.Windows.Forms.TextBox mamonhocs;
        private System.Windows.Forms.TextBox tenphieuthus;
        private System.Windows.Forms.TextBox hockys;
        private System.Windows.Forms.TextBox hinhthucs;
        private System.Windows.Forms.TextBox namhocs;
        private System.Windows.Forms.TextBox sotiens;
        private System.Windows.Forms.TextBox ngaythus;
        private System.Windows.Forms.TextBox mataikhoannhantienHPs;
        private System.Windows.Forms.TextBox mataikhoannganhangSVs;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox timkiems;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphieuthutt;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphieuthu;
        private System.Windows.Forms.DataGridViewTextBoxColumn msv;
        private System.Windows.Forms.DataGridViewTextBoxColumn mamonhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkhoanthu;
        private System.Windows.Forms.DataGridViewTextBoxColumn namhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn hocky;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaythu;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotien;
        private System.Windows.Forms.DataGridViewTextBoxColumn hinhthuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn mataikhoannganhangSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn mataikhoannhantienHP;
        private System.Windows.Forms.Button quyen;
        private System.Windows.Forms.Label label1;
    }
}