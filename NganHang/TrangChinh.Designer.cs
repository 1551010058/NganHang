namespace NganHang
{
    partial class TrangChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChinh));
            this.TTTaiKhoan = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.hien = new System.Windows.Forms.Label();
            this.QuanLy = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TTTaiKhoan
            // 
            this.TTTaiKhoan.ForeColor = System.Drawing.Color.Navy;
            this.TTTaiKhoan.Image = ((System.Drawing.Image)(resources.GetObject("TTTaiKhoan.Image")));
            this.TTTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TTTaiKhoan.Location = new System.Drawing.Point(14, 33);
            this.TTTaiKhoan.Name = "TTTaiKhoan";
            this.TTTaiKhoan.Size = new System.Drawing.Size(167, 51);
            this.TTTaiKhoan.TabIndex = 2;
            this.TTTaiKhoan.Text = "TT Tài Khoản";
            this.TTTaiKhoan.UseVisualStyleBackColor = true;
            this.TTTaiKhoan.Click += new System.EventHandler(this.TTTaiKhoan_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Navy;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(13, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 51);
            this.button2.TabIndex = 3;
            this.button2.Text = "Gửi Tiền";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Navy;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(12, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 51);
            this.button3.TabIndex = 4;
            this.button3.Text = "Chuyển Tiền";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Navy;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(14, 253);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(167, 51);
            this.button4.TabIndex = 5;
            this.button4.Text = "Rút Tiền";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.Color.Navy;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.Location = new System.Drawing.Point(14, 394);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(165, 51);
            this.button5.TabIndex = 6;
            this.button5.Text = "Thoát";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // hien
            // 
            this.hien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.hien.Dock = System.Windows.Forms.DockStyle.Top;
            this.hien.ForeColor = System.Drawing.Color.Red;
            this.hien.Location = new System.Drawing.Point(0, 0);
            this.hien.Name = "hien";
            this.hien.Size = new System.Drawing.Size(849, 30);
            this.hien.TabIndex = 7;
            this.hien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuanLy
            // 
            this.QuanLy.ForeColor = System.Drawing.Color.Navy;
            this.QuanLy.Image = ((System.Drawing.Image)(resources.GetObject("QuanLy.Image")));
            this.QuanLy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.QuanLy.Location = new System.Drawing.Point(14, 321);
            this.QuanLy.Name = "QuanLy";
            this.QuanLy.Size = new System.Drawing.Size(167, 51);
            this.QuanLy.TabIndex = 9;
            this.QuanLy.Text = "Quản Lý";
            this.QuanLy.UseVisualStyleBackColor = true;
            this.QuanLy.Click += new System.EventHandler(this.QuanLy_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::NganHang.Properties.Resources.hinh_nen_powerpoint_kinh_te_tai_chinh_3;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(660, 412);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(186, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 412);
            this.panel1.TabIndex = 11;
            // 
            // TrangChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(849, 457);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.QuanLy);
            this.Controls.Add(this.hien);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TTTaiKhoan);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.MaximizeBox = false;
            this.Name = "TrangChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang Chính ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrangChinh_FormClosing);
            this.Load += new System.EventHandler(this.TrangChinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        
        private System.Windows.Forms.Button TTTaiKhoan;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label hien;
        private System.Windows.Forms.Button QuanLy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}