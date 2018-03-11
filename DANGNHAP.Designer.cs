namespace PhanMemQLNS
{
    partial class DANGNHAP
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
            this.txt_loginname = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_dangnhap = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login Name: ";
            // 
            // txt_loginname
            // 
            this.txt_loginname.Location = new System.Drawing.Point(101, 21);
            this.txt_loginname.Name = "txt_loginname";
            this.txt_loginname.Size = new System.Drawing.Size(173, 20);
            this.txt_loginname.TabIndex = 1;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(101, 55);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(173, 20);
            this.txt_pass.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "PassWord";
            // 
            // bt_dangnhap
            // 
            this.bt_dangnhap.Location = new System.Drawing.Point(76, 95);
            this.bt_dangnhap.Name = "bt_dangnhap";
            this.bt_dangnhap.Size = new System.Drawing.Size(75, 23);
            this.bt_dangnhap.TabIndex = 4;
            this.bt_dangnhap.Text = "Đăng nhập";
            this.bt_dangnhap.UseVisualStyleBackColor = true;
            this.bt_dangnhap.Click += new System.EventHandler(this.bt_dangnhap_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(185, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // DANGNHAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 138);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bt_dangnhap);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_loginname);
            this.Controls.Add(this.label1);
            this.Name = "DANGNHAP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_loginname;
        public System.Windows.Forms.TextBox txt_pass;
        public System.Windows.Forms.Button bt_dangnhap;
        public System.Windows.Forms.Button button2;
    }
}