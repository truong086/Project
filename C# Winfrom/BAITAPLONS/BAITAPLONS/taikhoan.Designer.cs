namespace BAITAPLONS
{
    partial class taikhoan
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
            this.components = new System.ComponentModel.Container();
            this.use = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.cq = new System.Windows.Forms.Label();
            this.tentaikhoans = new System.Windows.Forms.TextBox();
            this.capquyens = new System.Windows.Forms.TextBox();
            this.matkhaus = new System.Windows.Forms.TextBox();
            this.taikhoanss = new System.Windows.Forms.DataGridView();
            this.mataikhoantt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentaikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capquyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.timkiems = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.qLHocPhiDataSet = new BAITAPLONS.QLHocPhiDataSet();
            this.qLHocPhiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quyen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.taikhoanss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHocPhiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHocPhiDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // use
            // 
            this.use.AutoSize = true;
            this.use.Location = new System.Drawing.Point(157, 132);
            this.use.Name = "use";
            this.use.Size = new System.Drawing.Size(88, 16);
            this.use.TabIndex = 0;
            this.use.Text = "Tên tài khoản";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(724, 132);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(61, 16);
            this.password.TabIndex = 1;
            this.password.Text = "Mật khẩu";
            // 
            // cq
            // 
            this.cq.AutoSize = true;
            this.cq.Location = new System.Drawing.Point(468, 200);
            this.cq.Name = "cq";
            this.cq.Size = new System.Drawing.Size(72, 16);
            this.cq.TabIndex = 2;
            this.cq.Text = "Cấp quyền";
            // 
            // tentaikhoans
            // 
            this.tentaikhoans.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tentaikhoans.Location = new System.Drawing.Point(251, 126);
            this.tentaikhoans.Name = "tentaikhoans";
            this.tentaikhoans.Size = new System.Drawing.Size(334, 22);
            this.tentaikhoans.TabIndex = 3;
            // 
            // capquyens
            // 
            this.capquyens.Location = new System.Drawing.Point(546, 197);
            this.capquyens.Name = "capquyens";
            this.capquyens.Size = new System.Drawing.Size(312, 22);
            this.capquyens.TabIndex = 4;
            // 
            // matkhaus
            // 
            this.matkhaus.Location = new System.Drawing.Point(791, 126);
            this.matkhaus.Name = "matkhaus";
            this.matkhaus.Size = new System.Drawing.Size(330, 22);
            this.matkhaus.TabIndex = 5;
            // 
            // taikhoanss
            // 
            this.taikhoanss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taikhoanss.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mataikhoantt,
            this.tentaikhoan,
            this.matkhau,
            this.capquyen});
            this.taikhoanss.Location = new System.Drawing.Point(-5, 355);
            this.taikhoanss.Name = "taikhoanss";
            this.taikhoanss.RowHeadersWidth = 51;
            this.taikhoanss.RowTemplate.Height = 24;
            this.taikhoanss.Size = new System.Drawing.Size(1349, 322);
            this.taikhoanss.TabIndex = 6;
            this.taikhoanss.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.taikhoanss_CellClick);
            this.taikhoanss.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.taikhoanss_CellContentClick);
            // 
            // mataikhoantt
            // 
            this.mataikhoantt.DataPropertyName = "mataikhoantt";
            this.mataikhoantt.HeaderText = "mataikhoantt";
            this.mataikhoantt.MinimumWidth = 6;
            this.mataikhoantt.Name = "mataikhoantt";
            this.mataikhoantt.Visible = false;
            this.mataikhoantt.Width = 125;
            // 
            // tentaikhoan
            // 
            this.tentaikhoan.DataPropertyName = "tentaikhoan";
            this.tentaikhoan.HeaderText = "Tên tài khoản";
            this.tentaikhoan.MinimumWidth = 6;
            this.tentaikhoan.Name = "tentaikhoan";
            this.tentaikhoan.Width = 125;
            // 
            // matkhau
            // 
            this.matkhau.DataPropertyName = "matkhau";
            this.matkhau.HeaderText = "Mật khẩu";
            this.matkhau.MinimumWidth = 6;
            this.matkhau.Name = "matkhau";
            this.matkhau.Width = 125;
            // 
            // capquyen
            // 
            this.capquyen.DataPropertyName = "capquyen";
            this.capquyen.HeaderText = "Cấp quyền";
            this.capquyen.MinimumWidth = 6;
            this.capquyen.Name = "capquyen";
            this.capquyen.Width = 125;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(407, 304);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(90, 29);
            this.add.TabIndex = 7;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(577, 304);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(90, 29);
            this.edit.TabIndex = 8;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(738, 304);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(90, 29);
            this.delete.TabIndex = 9;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // timkiems
            // 
            this.timkiems.Location = new System.Drawing.Point(515, 252);
            this.timkiems.Name = "timkiems";
            this.timkiems.Size = new System.Drawing.Size(285, 22);
            this.timkiems.TabIndex = 11;
            this.timkiems.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tìm kiếm";
            // 
            // qLHocPhiDataSet
            // 
            this.qLHocPhiDataSet.DataSetName = "QLHocPhiDataSet";
            this.qLHocPhiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLHocPhiDataSetBindingSource
            // 
            this.qLHocPhiDataSetBindingSource.DataSource = this.qLHocPhiDataSet;
            this.qLHocPhiDataSetBindingSource.Position = 0;
            // 
            // quyen
            // 
            this.quyen.Location = new System.Drawing.Point(1241, 80);
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
            this.label1.Location = new System.Drawing.Point(484, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 95);
            this.label1.TabIndex = 60;
            this.label1.Text = "Tài khoản";
            // 
            // taikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 678);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quyen);
            this.Controls.Add(this.timkiems);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.taikhoanss);
            this.Controls.Add(this.matkhaus);
            this.Controls.Add(this.capquyens);
            this.Controls.Add(this.tentaikhoans);
            this.Controls.Add(this.cq);
            this.Controls.Add(this.password);
            this.Controls.Add(this.use);
            this.Name = "taikhoan";
            this.Text = "taikhoan";
            this.Load += new System.EventHandler(this.taikhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taikhoanss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHocPhiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHocPhiDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label use;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label cq;
        private System.Windows.Forms.TextBox tentaikhoans;
        private System.Windows.Forms.TextBox capquyens;
        private System.Windows.Forms.TextBox matkhaus;
        private System.Windows.Forms.DataGridView taikhoanss;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox timkiems;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource qLHocPhiDataSetBindingSource;
        private QLHocPhiDataSet qLHocPhiDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn mataikhoantt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentaikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn matkhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn capquyen;
        private System.Windows.Forms.Button quyen;
        private System.Windows.Forms.Label label1;
    }
}