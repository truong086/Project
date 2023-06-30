namespace BAITAPLONS
{
    partial class guiemail
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
            this.files = new System.Windows.Forms.TextBox();
            this.to = new System.Windows.Forms.TextBox();
            this.tieude = new System.Windows.Forms.TextBox();
            this.tentaikhoan = new System.Windows.Forms.TextBox();
            this.matkhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.file = new System.Windows.Forms.Button();
            this.danhsachemail = new System.Windows.Forms.Button();
            this.gui = new System.Windows.Forms.Button();
            this.listbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // files
            // 
            this.files.Location = new System.Drawing.Point(225, 167);
            this.files.Name = "files";
            this.files.ReadOnly = true;
            this.files.Size = new System.Drawing.Size(286, 22);
            this.files.TabIndex = 0;
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(134, 266);
            this.to.Name = "to";
            this.to.ReadOnly = true;
            this.to.Size = new System.Drawing.Size(410, 22);
            this.to.TabIndex = 1;
            // 
            // tieude
            // 
            this.tieude.Location = new System.Drawing.Point(134, 324);
            this.tieude.Name = "tieude";
            this.tieude.Size = new System.Drawing.Size(410, 22);
            this.tieude.TabIndex = 2;
            // 
            // tentaikhoan
            // 
            this.tentaikhoan.Location = new System.Drawing.Point(134, 384);
            this.tentaikhoan.Name = "tentaikhoan";
            this.tentaikhoan.Size = new System.Drawing.Size(410, 22);
            this.tentaikhoan.TabIndex = 3;
            // 
            // matkhau
            // 
            this.matkhau.Location = new System.Drawing.Point(134, 438);
            this.matkhau.Name = "matkhau";
            this.matkhau.Size = new System.Drawing.Size(410, 22);
            this.matkhau.TabIndex = 4;
            this.matkhau.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tiêu đề";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên tài khoản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mật khẩu";
            // 
            // file
            // 
            this.file.Location = new System.Drawing.Point(542, 162);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(89, 32);
            this.file.TabIndex = 9;
            this.file.Text = "File";
            this.file.UseVisualStyleBackColor = true;
            this.file.Click += new System.EventHandler(this.file_Click);
            // 
            // danhsachemail
            // 
            this.danhsachemail.Location = new System.Drawing.Point(561, 256);
            this.danhsachemail.Name = "danhsachemail";
            this.danhsachemail.Size = new System.Drawing.Size(132, 32);
            this.danhsachemail.TabIndex = 11;
            this.danhsachemail.Text = "Danh sách email ";
            this.danhsachemail.UseVisualStyleBackColor = true;
            this.danhsachemail.Click += new System.EventHandler(this.danhsachemail_Click);
            // 
            // gui
            // 
            this.gui.Location = new System.Drawing.Point(134, 484);
            this.gui.Name = "gui";
            this.gui.Size = new System.Drawing.Size(89, 32);
            this.gui.TabIndex = 12;
            this.gui.Text = "Gửi";
            this.gui.UseVisualStyleBackColor = true;
            this.gui.Click += new System.EventHandler(this.gui_Click);
            // 
            // listbox
            // 
            this.listbox.Location = new System.Drawing.Point(115, 540);
            this.listbox.Multiline = true;
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(531, 171);
            this.listbox.TabIndex = 13;
            this.listbox.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 540);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nội dung";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(190, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(407, 95);
            this.label6.TabIndex = 15;
            this.label6.Text = "Gửi email";
            // 
            // guiemail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 724);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.gui);
            this.Controls.Add(this.danhsachemail);
            this.Controls.Add(this.file);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.matkhau);
            this.Controls.Add(this.tentaikhoan);
            this.Controls.Add(this.tieude);
            this.Controls.Add(this.to);
            this.Controls.Add(this.files);
            this.Name = "guiemail";
            this.Text = "guiemail";
            this.Load += new System.EventHandler(this.guiemail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox files;
        private System.Windows.Forms.TextBox to;
        private System.Windows.Forms.TextBox tieude;
        private System.Windows.Forms.TextBox tentaikhoan;
        private System.Windows.Forms.TextBox matkhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button file;
        private System.Windows.Forms.Button danhsachemail;
        private System.Windows.Forms.Button gui;
        private System.Windows.Forms.TextBox listbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}