namespace PhanMemQLNS
{
    partial class DANHMUC
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
            this.bt_nhanvien = new System.Windows.Forms.Button();
            this.bt_hopdong = new System.Windows.Forms.Button();
            this.bt_chitiethd = new System.Windows.Forms.Button();
            this.bt_phongban = new System.Windows.Forms.Button();
            this.bt_chucvu = new System.Windows.Forms.Button();
            this.bt_bangcong = new System.Windows.Forms.Button();
            this.bt_bangluong = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_dmk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_nhanvien
            // 
            this.bt_nhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_nhanvien.Location = new System.Drawing.Point(134, 200);
            this.bt_nhanvien.Name = "bt_nhanvien";
            this.bt_nhanvien.Size = new System.Drawing.Size(167, 50);
            this.bt_nhanvien.TabIndex = 0;
            this.bt_nhanvien.Text = "NHÂN VIÊN";
            this.bt_nhanvien.UseVisualStyleBackColor = true;
            this.bt_nhanvien.Click += new System.EventHandler(this.bt_nhanvien_Click);
            // 
            // bt_hopdong
            // 
            this.bt_hopdong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_hopdong.Location = new System.Drawing.Point(7, 79);
            this.bt_hopdong.Name = "bt_hopdong";
            this.bt_hopdong.Size = new System.Drawing.Size(167, 50);
            this.bt_hopdong.TabIndex = 1;
            this.bt_hopdong.Text = "HỢP ĐỒNG";
            this.bt_hopdong.UseVisualStyleBackColor = true;
            this.bt_hopdong.Click += new System.EventHandler(this.bt_hopdong_Click);
            // 
            // bt_chitiethd
            // 
            this.bt_chitiethd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_chitiethd.Location = new System.Drawing.Point(273, 19);
            this.bt_chitiethd.Name = "bt_chitiethd";
            this.bt_chitiethd.Size = new System.Drawing.Size(167, 50);
            this.bt_chitiethd.TabIndex = 2;
            this.bt_chitiethd.Text = "CHI TIẾT HỢP ĐỒNG";
            this.bt_chitiethd.UseVisualStyleBackColor = true;
            this.bt_chitiethd.Click += new System.EventHandler(this.bt_chitiethd_Click);
            // 
            // bt_phongban
            // 
            this.bt_phongban.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_phongban.Location = new System.Drawing.Point(273, 79);
            this.bt_phongban.Name = "bt_phongban";
            this.bt_phongban.Size = new System.Drawing.Size(167, 50);
            this.bt_phongban.TabIndex = 3;
            this.bt_phongban.Text = "PHÒNG BAN";
            this.bt_phongban.UseVisualStyleBackColor = true;
            this.bt_phongban.Click += new System.EventHandler(this.bt_phongban_Click);
            // 
            // bt_chucvu
            // 
            this.bt_chucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_chucvu.Location = new System.Drawing.Point(6, 135);
            this.bt_chucvu.Name = "bt_chucvu";
            this.bt_chucvu.Size = new System.Drawing.Size(167, 50);
            this.bt_chucvu.TabIndex = 4;
            this.bt_chucvu.Text = "CHỨC VỤ";
            this.bt_chucvu.UseVisualStyleBackColor = true;
            this.bt_chucvu.Click += new System.EventHandler(this.bt_chucvu_Click);
            // 
            // bt_bangcong
            // 
            this.bt_bangcong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_bangcong.Location = new System.Drawing.Point(273, 135);
            this.bt_bangcong.Name = "bt_bangcong";
            this.bt_bangcong.Size = new System.Drawing.Size(167, 50);
            this.bt_bangcong.TabIndex = 5;
            this.bt_bangcong.Text = "BẢNG CÔNG";
            this.bt_bangcong.UseVisualStyleBackColor = true;
            this.bt_bangcong.Click += new System.EventHandler(this.bt_bangcong_Click);
            // 
            // bt_bangluong
            // 
            this.bt_bangluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_bangluong.Location = new System.Drawing.Point(6, 19);
            this.bt_bangluong.Name = "bt_bangluong";
            this.bt_bangluong.Size = new System.Drawing.Size(167, 50);
            this.bt_bangluong.TabIndex = 6;
            this.bt_bangluong.Text = "BẢNG LƯƠNG";
            this.bt_bangluong.UseVisualStyleBackColor = true;
            this.bt_bangluong.Click += new System.EventHandler(this.bt_bangluong_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_bangluong);
            this.groupBox1.Controls.Add(this.bt_bangcong);
            this.groupBox1.Controls.Add(this.bt_chucvu);
            this.groupBox1.Controls.Add(this.bt_phongban);
            this.groupBox1.Controls.Add(this.bt_chitiethd);
            this.groupBox1.Controls.Add(this.bt_hopdong);
            this.groupBox1.Controls.Add(this.bt_nhanvien);
            this.groupBox1.Location = new System.Drawing.Point(29, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 256);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý danh mục";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(279, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_dmk
            // 
            this.bt_dmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dmk.Location = new System.Drawing.Point(107, 277);
            this.bt_dmk.Name = "bt_dmk";
            this.bt_dmk.Size = new System.Drawing.Size(113, 32);
            this.bt_dmk.TabIndex = 8;
            this.bt_dmk.Text = "Đổi mật khẩu";
            this.bt_dmk.UseVisualStyleBackColor = true;
            this.bt_dmk.Click += new System.EventHandler(this.bt_dmk_Click);
            // 
            // DANHMUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 357);
            this.Controls.Add(this.bt_dmk);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "DANHMUC";
            this.Text = "DANH MỤC";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button bt_nhanvien;
        public System.Windows.Forms.Button bt_hopdong;
        public System.Windows.Forms.Button bt_chitiethd;
        public System.Windows.Forms.Button bt_phongban;
        public System.Windows.Forms.Button bt_chucvu;
        public System.Windows.Forms.Button bt_bangcong;
        public System.Windows.Forms.Button bt_bangluong;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button bt_dmk;
    }
}