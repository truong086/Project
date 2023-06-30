namespace BAITAPLONS
{
    partial class dangnhap
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
            this.taikhoan = new System.Windows.Forms.Label();
            this.taikhoans = new System.Windows.Forms.TextBox();
            this.matkhaus = new System.Windows.Forms.TextBox();
            this.matkhau = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // taikhoan
            // 
            this.taikhoan.AutoSize = true;
            this.taikhoan.Location = new System.Drawing.Point(396, 162);
            this.taikhoan.Name = "taikhoan";
            this.taikhoan.Size = new System.Drawing.Size(61, 16);
            this.taikhoan.TabIndex = 0;
            this.taikhoan.Text = "tài khoản";
            // 
            // taikhoans
            // 
            this.taikhoans.Location = new System.Drawing.Point(465, 156);
            this.taikhoans.Name = "taikhoans";
            this.taikhoans.Size = new System.Drawing.Size(223, 22);
            this.taikhoans.TabIndex = 1;
            // 
            // matkhaus
            // 
            this.matkhaus.Location = new System.Drawing.Point(465, 233);
            this.matkhaus.Name = "matkhaus";
            this.matkhaus.Size = new System.Drawing.Size(223, 22);
            this.matkhaus.TabIndex = 3;
            this.matkhaus.UseSystemPasswordChar = true;
            // 
            // matkhau
            // 
            this.matkhau.AutoSize = true;
            this.matkhau.Location = new System.Drawing.Point(396, 233);
            this.matkhau.Name = "matkhau";
            this.matkhau.Size = new System.Drawing.Size(61, 16);
            this.matkhau.TabIndex = 2;
            this.matkhau.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(404, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đăng nhập hệ thống";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(448, 309);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(107, 43);
            this.login.TabIndex = 5;
            this.login.Text = "Đăng nhập";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(580, 309);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(108, 43);
            this.exit.TabIndex = 6;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BAITAPLONS.Properties.Resources.Picture3;
            this.pictureBox1.Location = new System.Drawing.Point(31, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 447);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.matkhaus);
            this.Controls.Add(this.matkhau);
            this.Controls.Add(this.taikhoans);
            this.Controls.Add(this.taikhoan);
            this.Name = "dangnhap";
            this.Text = "dangnhap";
            this.Load += new System.EventHandler(this.dangnhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label taikhoan;
        private System.Windows.Forms.TextBox taikhoans;
        private System.Windows.Forms.TextBox matkhaus;
        private System.Windows.Forms.Label matkhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}