namespace NganHang
{
    partial class RutTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RutTien));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MaThe = new System.Windows.Forms.Label();
            this.SoDu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TienRut = new System.Windows.Forms.TextBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btRut = new System.Windows.Forms.Button();
            this.matkhauxacnhan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nganHangDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbtime = new System.Windows.Forms.Label();
            this.Times = new System.Windows.Forms.Timer(this.components);
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.PrintRut = new System.Windows.Forms.Button();
            this.txtNgayRut = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nganHangDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.label1.TabIndex = 6;
            this.label1.Text = "Rút Tiền";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 35);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã Thẻ            :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MaThe
            // 
            this.MaThe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MaThe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaThe.Location = new System.Drawing.Point(177, 73);
            this.MaThe.Name = "MaThe";
            this.MaThe.Size = new System.Drawing.Size(306, 31);
            this.MaThe.TabIndex = 16;
            this.MaThe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SoDu
            // 
            this.SoDu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SoDu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SoDu.Location = new System.Drawing.Point(177, 115);
            this.SoDu.Name = "SoDu";
            this.SoDu.Size = new System.Drawing.Size(306, 31);
            this.SoDu.TabIndex = 18;
            this.SoDu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 35);
            this.label2.TabIndex = 17;
            this.label2.Text = "Số Dư               :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 35);
            this.label5.TabIndex = 19;
            this.label5.Text = "Số Tiền Rút     :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TienRut
            // 
            this.TienRut.Location = new System.Drawing.Point(177, 163);
            this.TienRut.Name = "TienRut";
            this.TienRut.Size = new System.Drawing.Size(306, 29);
            this.TienRut.TabIndex = 20;
            // 
            // btThoat
            // 
            this.btThoat.Image = ((System.Drawing.Image)(resources.GetObject("btThoat.Image")));
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(520, 198);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(117, 42);
            this.btThoat.TabIndex = 24;
            this.btThoat.Text = "Thoát";
            this.btThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btRut
            // 
            this.btRut.Image = ((System.Drawing.Image)(resources.GetObject("btRut.Image")));
            this.btRut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRut.Location = new System.Drawing.Point(520, 137);
            this.btRut.Name = "btRut";
            this.btRut.Size = new System.Drawing.Size(117, 42);
            this.btRut.TabIndex = 23;
            this.btRut.Text = "Rút";
            this.btRut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btRut.UseVisualStyleBackColor = true;
            this.btRut.Click += new System.EventHandler(this.btRut_Click);
            // 
            // matkhauxacnhan
            // 
            this.matkhauxacnhan.Location = new System.Drawing.Point(177, 211);
            this.matkhauxacnhan.Name = "matkhauxacnhan";
            this.matkhauxacnhan.PasswordChar = '*';
            this.matkhauxacnhan.Size = new System.Drawing.Size(306, 29);
            this.matkhauxacnhan.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 35);
            this.label6.TabIndex = 26;
            this.label6.Text = "Mật Khẩu XN:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbtime
            // 
            this.lbtime.AutoSize = true;
            this.lbtime.Location = new System.Drawing.Point(12, 271);
            this.lbtime.Name = "lbtime";
            this.lbtime.Size = new System.Drawing.Size(59, 22);
            this.lbtime.TabIndex = 30;
            this.lbtime.Text = "label4";
            // 
            // Times
            // 
            this.Times.Enabled = true;
            this.Times.Interval = 1000;
            this.Times.Tick += new System.EventHandler(this.Times_Tick);
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
            // PrintRut
            // 
            this.PrintRut.Image = ((System.Drawing.Image)(resources.GetObject("PrintRut.Image")));
            this.PrintRut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrintRut.Location = new System.Drawing.Point(520, 69);
            this.PrintRut.Name = "PrintRut";
            this.PrintRut.Size = new System.Drawing.Size(117, 42);
            this.PrintRut.TabIndex = 31;
            this.PrintRut.Text = "Biên Lai";
            this.PrintRut.UseVisualStyleBackColor = true;
            this.PrintRut.Click += new System.EventHandler(this.PrintRut_Click);
            // 
            // txtNgayRut
            // 
            this.txtNgayRut.Location = new System.Drawing.Point(485, 287);
            this.txtNgayRut.Name = "txtNgayRut";
            this.txtNgayRut.Size = new System.Drawing.Size(108, 22);
            this.txtNgayRut.TabIndex = 0;
            this.txtNgayRut.Text = "txtNgayRut";
            // 
            // RutTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(660, 412);
            this.Controls.Add(this.txtNgayRut);
            this.Controls.Add(this.PrintRut);
            this.Controls.Add(this.lbtime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.matkhauxacnhan);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btRut);
            this.Controls.Add(this.TienRut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SoDu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaThe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "RutTien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RutTien";
            this.Load += new System.EventHandler(this.RutTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nganHangDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MaThe;
        private System.Windows.Forms.Label SoDu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TienRut;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btRut;
        private System.Windows.Forms.TextBox matkhauxacnhan;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.BindingSource nganHangDataSetBindingSource;
        private System.Windows.Forms.Label lbtime;
        private System.Windows.Forms.Timer Times;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.Button PrintRut;
        private System.Windows.Forms.Label txtNgayRut;
    }
}