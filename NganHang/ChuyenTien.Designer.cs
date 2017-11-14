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
            this.components = new System.ComponentModel.Container();
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
            this.txtNgayChuyen = new System.Windows.Forms.DateTimePicker();
            this.lbtime = new System.Windows.Forms.Label();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.PrintChuyen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã Thẻ               :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(660, 59);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chuyển Tiền";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MaThe
            // 
            this.MaThe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MaThe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaThe.Location = new System.Drawing.Point(179, 76);
            this.MaThe.Name = "MaThe";
            this.MaThe.Size = new System.Drawing.Size(303, 31);
            this.MaThe.TabIndex = 15;
            this.MaThe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 35);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mã Thẻ Gửi       :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MaTheGui
            // 
            this.MaTheGui.Location = new System.Drawing.Point(179, 125);
            this.MaTheGui.Name = "MaTheGui";
            this.MaTheGui.Size = new System.Drawing.Size(303, 29);
            this.MaTheGui.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 35);
            this.label4.TabIndex = 18;
            this.label4.Text = "Số Tiền Chuyển:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SoTienChuyen
            // 
            this.SoTienChuyen.Location = new System.Drawing.Point(179, 171);
            this.SoTienChuyen.Name = "SoTienChuyen";
            this.SoTienChuyen.Size = new System.Drawing.Size(303, 29);
            this.SoTienChuyen.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 35);
            this.label5.TabIndex = 20;
            this.label5.Text = "Mật Khẩu XN   :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // matkhauxacnhan
            // 
            this.matkhauxacnhan.Location = new System.Drawing.Point(179, 217);
            this.matkhauxacnhan.Name = "matkhauxacnhan";
            this.matkhauxacnhan.PasswordChar = '*';
            this.matkhauxacnhan.Size = new System.Drawing.Size(303, 29);
            this.matkhauxacnhan.TabIndex = 21;
            // 
            // btChuyenTien
            // 
            this.btChuyenTien.Image = ((System.Drawing.Image)(resources.GetObject("btChuyenTien.Image")));
            this.btChuyenTien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btChuyenTien.Location = new System.Drawing.Point(488, 139);
            this.btChuyenTien.Name = "btChuyenTien";
            this.btChuyenTien.Size = new System.Drawing.Size(144, 42);
            this.btChuyenTien.TabIndex = 22;
            this.btChuyenTien.Text = "Chuyển Tiền";
            this.btChuyenTien.UseVisualStyleBackColor = true;
            this.btChuyenTien.Click += new System.EventHandler(this.btChuyenTien_Click);
            // 
            // btThoat
            // 
            this.btThoat.Image = ((System.Drawing.Image)(resources.GetObject("btThoat.Image")));
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(488, 206);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(144, 42);
            this.btThoat.TabIndex = 23;
            this.btThoat.Text = "Thoát";
            this.btThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // txtNgayChuyen
            // 
            this.txtNgayChuyen.Enabled = false;
            this.txtNgayChuyen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgayChuyen.Location = new System.Drawing.Point(7, 354);
            this.txtNgayChuyen.Name = "txtNgayChuyen";
            this.txtNgayChuyen.Size = new System.Drawing.Size(112, 29);
            this.txtNgayChuyen.TabIndex = 29;
            // 
            // lbtime
            // 
            this.lbtime.AutoSize = true;
            this.lbtime.Location = new System.Drawing.Point(3, 329);
            this.lbtime.Name = "lbtime";
            this.lbtime.Size = new System.Drawing.Size(59, 22);
            this.lbtime.TabIndex = 31;
            this.lbtime.Text = "label4";
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog1";
            this.printPreviewDialog.Visible = false;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // PrintChuyen
            // 
            this.PrintChuyen.Image = ((System.Drawing.Image)(resources.GetObject("PrintChuyen.Image")));
            this.PrintChuyen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrintChuyen.Location = new System.Drawing.Point(488, 76);
            this.PrintChuyen.Name = "PrintChuyen";
            this.PrintChuyen.Size = new System.Drawing.Size(144, 42);
            this.PrintChuyen.TabIndex = 33;
            this.PrintChuyen.Text = "Biên Lai";
            this.PrintChuyen.UseVisualStyleBackColor = true;
            this.PrintChuyen.Click += new System.EventHandler(this.PrintChuyen_Click);
            // 
            // ChuyenTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(660, 412);
            this.Controls.Add(this.PrintChuyen);
            this.Controls.Add(this.lbtime);
            this.Controls.Add(this.txtNgayChuyen);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.DateTimePicker txtNgayChuyen;
        private System.Windows.Forms.Label lbtime;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button PrintChuyen;
    }
}