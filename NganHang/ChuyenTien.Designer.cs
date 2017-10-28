namespace NganHang
{
    partial class ChuyenTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChuyenTien));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MaThe = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MaTheGui = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SoTienChuyen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.matkhauxacnhan = new System.Windows.Forms.TextBox();
            this.btChuyenTien = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã Thẻ:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 62);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chuyển Tiền";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MaThe
            // 
            this.MaThe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MaThe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaThe.Location = new System.Drawing.Point(187, 76);
            this.MaThe.Name = "MaThe";
            this.MaThe.Size = new System.Drawing.Size(303, 31);
            this.MaThe.TabIndex = 15;
            this.MaThe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 35);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mã Thẻ Gửi:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MaTheGui
            // 
            this.MaTheGui.Location = new System.Drawing.Point(187, 110);
            this.MaTheGui.Name = "MaTheGui";
            this.MaTheGui.Size = new System.Drawing.Size(303, 29);
            this.MaTheGui.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 35);
            this.label4.TabIndex = 18;
            this.label4.Text = "Số Tiền Chuyển:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SoTienChuyen
            // 
            this.SoTienChuyen.Location = new System.Drawing.Point(187, 142);
            this.SoTienChuyen.Name = "SoTienChuyen";
            this.SoTienChuyen.Size = new System.Drawing.Size(303, 29);
            this.SoTienChuyen.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 35);
            this.label5.TabIndex = 20;
            this.label5.Text = "Mật Khẩu XN:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // matkhauxacnhan
            // 
            this.matkhauxacnhan.Location = new System.Drawing.Point(187, 174);
            this.matkhauxacnhan.Name = "matkhauxacnhan";
            this.matkhauxacnhan.PasswordChar = '*';
            this.matkhauxacnhan.Size = new System.Drawing.Size(303, 29);
            this.matkhauxacnhan.TabIndex = 21;
            // 
            // btChuyenTien
            // 
            this.btChuyenTien.Image = ((System.Drawing.Image)(resources.GetObject("btChuyenTien.Image")));
            this.btChuyenTien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btChuyenTien.Location = new System.Drawing.Point(134, 209);
            this.btChuyenTien.Name = "btChuyenTien";
            this.btChuyenTien.Size = new System.Drawing.Size(136, 42);
            this.btChuyenTien.TabIndex = 22;
            this.btChuyenTien.Text = "Chuyển Tiền";
            this.btChuyenTien.UseVisualStyleBackColor = true;
           
            // 
            // btThoat
            // 
            this.btThoat.Image = ((System.Drawing.Image)(resources.GetObject("btThoat.Image")));
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(286, 209);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(136, 42);
            this.btThoat.TabIndex = 23;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
           
            // 
            // ChuyenTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(526, 288);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btChuyenTien);
            this.Controls.Add(this.matkhauxacnhan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SoTienChuyen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MaTheGui);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaThe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "ChuyenTien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChuyenTien";
            this.Load += new System.EventHandler(this.ChuyenTien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MaThe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MaTheGui;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SoTienChuyen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox matkhauxacnhan;
        private System.Windows.Forms.Button btChuyenTien;
        private System.Windows.Forms.Button btThoat;
    }
}