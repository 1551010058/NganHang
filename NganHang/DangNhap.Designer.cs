namespace NganHang
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTendangnhap = new System.Windows.Forms.TextBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.btdangky = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btdangnhap = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đăng Nhập Hệ Thống";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Đăng Nhập:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật Khẩu         :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTendangnhap
            // 
            this.txtTendangnhap.Location = new System.Drawing.Point(226, 132);
            this.txtTendangnhap.Name = "txtTendangnhap";
            this.txtTendangnhap.Size = new System.Drawing.Size(254, 32);
            this.txtTendangnhap.TabIndex = 4;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(226, 176);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.PasswordChar = '*';
            this.txtmatkhau.Size = new System.Drawing.Size(254, 32);
            this.txtmatkhau.TabIndex = 5;
            // 
            // btdangky
            // 
            this.btdangky.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btdangky.Image = ((System.Drawing.Image)(resources.GetObject("btdangky.Image")));
            this.btdangky.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btdangky.Location = new System.Drawing.Point(213, 238);
            this.btdangky.Name = "btdangky";
            this.btdangky.Size = new System.Drawing.Size(119, 38);
            this.btdangky.TabIndex = 7;
            this.btdangky.Text = "Đăng Ký";
            this.btdangky.UseVisualStyleBackColor = true;
            this.btdangky.Click += new System.EventHandler(this.btdangky_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::NganHang.Properties.Resources.chesapeake_bay_bridge_wikimedia_commons2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(568, 358);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btdangnhap
            // 
            this.btdangnhap.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btdangnhap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdangnhap.Image = ((System.Drawing.Image)(resources.GetObject("btdangnhap.Image")));
            this.btdangnhap.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btdangnhap.Location = new System.Drawing.Point(54, 238);
            this.btdangnhap.Name = "btdangnhap";
            this.btdangnhap.Size = new System.Drawing.Size(125, 38);
            this.btdangnhap.TabIndex = 9;
            this.btdangnhap.Text = "Đăng nhập";
            this.btdangnhap.UseVisualStyleBackColor = true;
            this.btdangnhap.Click += new System.EventHandler(this.btdangnhap_Click);
            // 
            // btthoat
            // 
            this.btthoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btthoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btthoat.Image = ((System.Drawing.Image)(resources.GetObject("btthoat.Image")));
            this.btthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btthoat.Location = new System.Drawing.Point(361, 238);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(119, 38);
            this.btthoat.TabIndex = 10;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 358);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btdangnhap);
            this.Controls.Add(this.btdangky);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.txtTendangnhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                Đăng Nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTendangnhap;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.Button btdangky;
        private System.Windows.Forms.Button btdangnhap;
        private System.Windows.Forms.Button btthoat;

    }
}

