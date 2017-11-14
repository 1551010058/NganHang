using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace NganHang
{
    public partial class GuiTien : Form
    {
        SqlConnection ketnoi = new SqlConnection(@"Server = .;Database =NganHang1;Integrated Security=True");
        public static string user2 = "";
        Int64 tien, tongtien = 0,tiengui=0;
        string mk;
        public GuiTien()
        {
            InitializeComponent();
        }
        int mathe;
        private void GuiTien_Load(object sender, EventArgs e)
        {

            ketnoi.Open();
            SqlCommand command = new SqlCommand("select MaThe from KhachHang where TenDangNhap='" + user2 + "'", ketnoi);
            mathe = (int)command.ExecuteScalar();
            SqlCommand command1 = new SqlCommand("select Tien from KhachHang where TenDangNhap='" + user2 + "'", ketnoi);
            tien = Convert.ToInt64(command1.ExecuteScalar());
            SqlCommand command2 = new SqlCommand("select MatKhau from KhachHang where TenDangNhap='" + user2 + "'", ketnoi);
            mk= (string)command2.ExecuteScalar();
            MaThe.Text = mathe.ToString();
            lbtime.Visible = false;
            txtNgayGui.Visible = false;
        }

        private void btGui_Click(object sender, EventArgs e)
        {


            try
            {
                tiengui = Convert.ToInt64(TienGui.Text);
                if (TGV.TienGui(TienGui.Text) == false)
                {
                    MessageBox.Show("Một lần gửi bạn chỉ được gửi tối đa 2 tỷ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TienGui.Focus();
                }
                else if(Convert.ToInt64(TienGui.Text) < 0)
                {
                    MessageBox.Show("Bạn Nhập Giá Trị Sai", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TienGui.Focus();
                }
                else
                {
                    if (matkhauxacnhan.Text == mk)
                    {
                        tongtien = tien + tiengui;
                        string update = "UPDATE KhachHang SET Tien='" + tongtien + "'WHERE MaThe='" + mathe + "'";
                        SqlCommand command = new SqlCommand(update, ketnoi);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Gửi Tiền Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TienGui.Enabled = false;
                        matkhauxacnhan.Enabled = false;
                        btGui.Enabled = false;
                        PrintRut.Enabled = false;
                        //Insert vào table gửi

                        string insert = "Insert into GuiTien(TienGui,NgayGui,GioGui,MaThe) Values('" + Convert.ToInt32(TienGui.Text) + "',N'" + txtNgayGui.Text + "',N'" + lbtime.Text + "',N'" + mathe + "')";
                        SqlCommand cmd = new SqlCommand(insert, ketnoi);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show(" Gửi Tiền Không Thành Công ", "Mật Khẩu Sai ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        matkhauxacnhan.Focus();
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(" Bạn Nhập Sai ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TienGui.Focus();
            }
            
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Escape)
                this.Close();
            return base.ProcessDialogKey(keyData);
        }
        ClassTien TGV = new ClassTien();
        private void PrintRut_Click(object sender, EventArgs e)
        {
            try
            {
                tiengui = Convert.ToInt64(TienGui.Text);
                if (TGV.TienGui(TienGui.Text)==false)
                {
                    MessageBox.Show("Một lần gửi bạn chỉ được gửi tối đa 2 tỷ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TienGui.Focus();
                }
                else if (Convert.ToInt64(TienGui.Text) < 0)
                {
                    MessageBox.Show("Bạn Nhập Giá Trị Sai", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TienGui.Focus();
                }
                else
                {
                    if (matkhauxacnhan.Text == mk)
                    {
                        tongtien = tien + tiengui;
                        string update = "UPDATE KhachHang SET Tien='" + tongtien + "'WHERE MaThe='" + mathe + "'";
                        SqlCommand command = new SqlCommand(update, ketnoi);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Gửi Tiền Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TienGui.Enabled = false;
                        matkhauxacnhan.Enabled = false;
                        btGui.Enabled = false;
                        PrintRut.Enabled = false;
                        //Insert vào table gửi

                        string insert = "Insert into GuiTien(TienGui,NgayGui,GioGui,MaThe) Values('" + Convert.ToInt32(TienGui.Text) + "',N'" + txtNgayGui.Text + "',N'"+lbtime.Text+"',N'" + mathe + "')";
                        SqlCommand cmd = new SqlCommand(insert, ketnoi);
                        cmd.ExecuteNonQuery();
                        printPreviewDialog.Document = printDocument;
                        ///
                        if (printPreviewDialog.ShowDialog() == DialogResult.OK)
                        {
                            printDocument.Print();
                        }
                    }
                    else
                    {
                        MessageBox.Show(" Gửi Tiền Không Thành Công ", "Mật Khẩu Sai ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        matkhauxacnhan.Focus();
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(" Bạn Nhập Sai ! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TienGui.Focus();
            }
        }
        String thu = "";
        private String Day(string thu)
        {
            switch (thu)
            {
                case "Monday": thu = " Thứ Hai "; break;
                case "Tuesday": thu = " Thứ Ba "; break;
                case "Wednesday": thu = " Thứ Tư "; break;
                case "Thursday": thu = " Thứ Năm "; break;
                case "Friday": thu = " Thứ Sáu "; break;
                case "Saturday": thu = " Thứ Bảy "; break;
                default: thu = " Chủ Nhật "; break;
            }
            return thu;

        }
        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            SqlCommand command = new SqlCommand("select IPGui from GuiTien where GioGui='" + lbtime.Text + "'", ketnoi);
            string ipgui = (string)command.ExecuteScalar().ToString();
            Bitmap bmp = Properties.Resources.Capture;
            Image newImage = bmp;
            e.Graphics.DrawImage(newImage, 25, 25, newImage.Width, newImage.Height);
            e.Graphics.DrawString(" Mã Thẻ : ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 150, 150);
            e.Graphics.DrawString(MaThe.Text, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 600, 150);
            e.Graphics.DrawString(" Số Giao Dich : ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 150, 190);
            e.Graphics.DrawString(ipgui, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 600, 190);
            e.Graphics.DrawString(" Số Tiền Gui : ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 150, 230);
            e.Graphics.DrawString(TienGui.Text+" VNĐ ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 600, 230);
            e.Graphics.DrawString(" Số Dư : ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 150, 270);
            e.Graphics.DrawString(tongtien.ToString() + " VNĐ ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 600, 270);
            e.Graphics.DrawString(" Ngày Giờ Gửi : ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 150, 310);
            e.Graphics.DrawString(Day(DateTime.Now.DayOfWeek.ToString()) + " Ngày " + txtNgayGui.Text + " " + lbtime.Text, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 330, 310);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbtime.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
        }

       
    }
}
