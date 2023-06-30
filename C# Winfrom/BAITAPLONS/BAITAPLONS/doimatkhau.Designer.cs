namespace BAITAPLONS
{
    partial class doimatkhau
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tentaikhoans = new System.Windows.Forms.TextBox();
            this.matkhaus = new System.Windows.Forms.TextBox();
            this.matkhaumoi = new System.Windows.Forms.TextBox();
            this.thaydois = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // tentaikhoans
            // 
            this.tentaikhoans.Location = new System.Drawing.Point(304, 172);
            this.tentaikhoans.Name = "tentaikhoans";
            this.tentaikhoans.Size = new System.Drawing.Size(319, 22);
            this.tentaikhoans.TabIndex = 6;
            // 
            // matkhaus
            // 
            this.matkhaus.Location = new System.Drawing.Point(304, 237);
            this.matkhaus.Name = "matkhaus";
            this.matkhaus.Size = new System.Drawing.Size(319, 22);
            this.matkhaus.TabIndex = 7;
            this.matkhaus.UseSystemPasswordChar = true;
            // 
            // matkhaumoi
            // 
            this.matkhaumoi.Location = new System.Drawing.Point(304, 291);
            this.matkhaumoi.Name = "matkhaumoi";
            this.matkhaumoi.Size = new System.Drawing.Size(319, 22);
            this.matkhaumoi.TabIndex = 8;
            this.matkhaumoi.UseSystemPasswordChar = true;
            // 
            // thaydois
            // 
            this.thaydois.Location = new System.Drawing.Point(357, 366);
            this.thaydois.Name = "thaydois";
            this.thaydois.Size = new System.Drawing.Size(129, 52);
            this.thaydois.TabIndex = 9;
            this.thaydois.Text = "Thay đổi";
            this.thaydois.UseVisualStyleBackColor = true;
            this.thaydois.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật khẩu mới";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(171, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(547, 95);
            this.label5.TabIndex = 10;
            this.label5.Text = "Đổi mật khẩu";
            // 
            // doimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 463);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.thaydois);
            this.Controls.Add(this.matkhaumoi);
            this.Controls.Add(this.matkhaus);
            this.Controls.Add(this.tentaikhoans);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "doimatkhau";
            this.Text = "doimatkhau";
            this.Load += new System.EventHandler(this.doimatkhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tentaikhoans;
        private System.Windows.Forms.TextBox matkhaus;
        private System.Windows.Forms.TextBox matkhaumoi;
        private System.Windows.Forms.Button thaydois;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}