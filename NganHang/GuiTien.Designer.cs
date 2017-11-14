namespace NganHang
{
    partial class GuiTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuiTien));
            this.label3 = new System.Windows.Forms.Label();
            this.MaThe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TienGui = new System.Windows.Forms.TextBox();
            this.matkhauxacnhan = new System.Windows.Forms.TextBox();
            this.btGui = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.txtNgayGui = new System.Windows.Forms.DateTimePicker();
            this.lbtime = new System.Windows.Forms.Label();
            this.PrintRut = new System.Windows.Forms.Button();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã Thẻ            :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MaThe
            // 
            this.MaThe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MaThe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaThe.Location = new System.Drawing.Point(207, 64);
            this.MaThe.Name = "MaThe";
            this.MaThe.Size = new System.Drawing.Size(287, 31);
            this.MaThe.TabIndex = 14;
            this.MaThe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 35);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tiền Gửi           :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 35);
            this.label4.TabIndex = 17;
            this.label4.Text = "Mật Khẩu XN :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TienGui
            // 
            this.TienGui.Location = new System.Drawing.Point(207, 119);
            this.TienGui.Name = "TienGui";
            this.TienGui.Size = new System.Drawing.Size(287, 29);
            this.TienGui.TabIndex = 18;
            // 
            // matkhauxacnhan
            // 
            this.matkhauxacnhan.Location = new System.Drawing.Point(207, 173);
            this.matkhauxacnhan.Name = "matkhauxacnhan";
            this.matkhauxacnhan.PasswordChar = '*';
            this.matkhauxacnhan.Size = new System.Drawing.Size(287, 29);
            this.matkhauxacnhan.TabIndex = 19;
            // 
            // btGui
            // 
            this.btGui.Image = ((System.Drawing.Image)(resources.GetObject("btGui.Image")));
            this.btGui.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGui.Location = new System.Drawing.Point(544, 112);
            this.btGui.Name = "btGui";
            this.btGui.Size = new System.Drawing.Size(104, 42);
            this.btGui.TabIndex = 20;
            this.btGui.Text = "Gửi";
            this.btGui.UseVisualStyleBackColor = true;
            this.btGui.Click += new System.EventHandler(this.btGui_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(660, 59);
            this.label2.TabIndex = 21;
            this.label2.Text = "Gửi Tiền Vô Tài Khoản";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btThoat
            // 
            this.btThoat.Image = ((System.Drawing.Image)(resources.GetObject("btThoat.Image")));
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(544, 160);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(104, 42);
            this.btThoat.TabIndex = 22;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // txtNgayGui
            // 
            this.txtNgayGui.Enabled = false;
            this.txtNgayGui.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgayGui.Location = new System.Drawing.Point(405, 217);
            this.txtNgayGui.Name = "txtNgayGui";
            this.txtNgayGui.Size = new System.Drawing.Size(112, 29);
            this.txtNgayGui.TabIndex = 28;
            // 
            // lbtime
            // 
            this.lbtime.AutoSize = true;
            this.lbtime.Location = new System.Drawing.Point(559, 217);
            this.lbtime.Name = "lbtime";
            this.lbtime.Size = new System.Drawing.Size(59, 22);
            this.lbtime.TabIndex = 31;
            this.lbtime.Text = "label4";
            // 
            // PrintRut
            // 
            this.PrintRut.Image = ((System.Drawing.Image)(resources.GetObject("PrintRut.Image")));
            this.PrintRut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrintRut.Location = new System.Drawing.Point(544, 64);
            this.PrintRut.Name = "PrintRut";
            this.PrintRut.Size = new System.Drawing.Size(104, 42);
            this.PrintRut.TabIndex = 32;
            this.PrintRut.Text = "Biên Lai";
            this.PrintRut.UseVisualStyleBackColor = true;
            this.PrintRut.Click += new System.EventHandler(this.PrintRut_Click);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // GuiTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(660, 280);
            this.Controls.Add(this.PrintRut);
            this.Controls.Add(this.lbtime);
            this.Controls.Add(this.txtNgayGui);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btGui);
            this.Controls.Add(this.matkhauxacnhan);
            this.Controls.Add(this.TienGui);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaThe);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximizeBox = false;
            this.Name = "GuiTien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuiTien";
            this.Load += new System.EventHandler(this.GuiTien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MaThe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TienGui;
        private System.Windows.Forms.TextBox matkhauxacnhan;
        private System.Windows.Forms.Button btGui;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.DateTimePicker txtNgayGui;
        private System.Windows.Forms.Label lbtime;
        private System.Windows.Forms.Button PrintRut;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.Timer timer;
    }
}