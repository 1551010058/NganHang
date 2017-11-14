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
    public partial class ChuyenTien : Form
    {
        SqlConnection ketnoi = new SqlConnection(@"Server = .;Database =NganHang1;Integrated Security=True");
        public static string user3 = "";
        Int64 tienbengui, tongtienbennhan = 0, tienchuyen = 0,tongtienbengui=0;
        int thegui;
        string mk;
        public ChuyenTien()
        {
            InitializeComponent();
        }
        int mathe;
        private void ChuyenTien_Load(object sender, EventArgs e)
        {
            
            ketnoi.Open();
            SqlCommand command = new SqlCommand("select MaThe from KhachHang where TenDangNhap='" + user3 + "'", ketnoi);
            mathe = (int)command.ExecuteScalar();
            SqlCommand command1 = new SqlCommand("select Tien from KhachHang where TenDangNhap='" + user3 + "'", ketnoi);
            tienbengui = Convert.ToInt64(command1.ExecuteScalar());
            SqlCommand command2 = new SqlCommand("select MatKhau from KhachHang where TenDangNhap='" + user3 + "'", ketnoi);
            mk = (string)command2.ExecuteScalar();
            MaThe.Text = mathe.ToString();
            lbtime.Visible = false;
            txtNgayChuyen.Visible = false;
        }

        private void btChuyenTien_Click(object sender, EventArgs e)
        {
            chuyentien();
        }
        private void chuyentien()
        {
            try
            {
                tienchuyen = int.Parse(SoTienChuyen.Text);
                thegui = int.Parse(MaTheGui.Text);
                SqlCommand command0 = new SqlCommand("select MaThe from KhachHang where MaThe='" + thegui + "'", ketnoi);
                SqlDataReader dta = command0.ExecuteReader();
                if (dta.Read()!=true)
                {
                    MessageBox.Show("Không tìm thấy mả thẻ ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dta.Close();
                    dta.Dispose();
                }
                else
                {
                    dta.Close();
                    dta.Dispose();
                    //ketnoi.Open();
                    SqlCommand command = new SqlCommand("select Tien from KhachHang where MaThe='" + thegui + "'", ketnoi);
                    Int64 tienbennhan = Convert.ToInt64(command.ExecuteScalar());
                    tongtienbennhan = tienbennhan + tienchuyen;// Cong Tien ben nhận
                    tongtienbengui = tienbengui - tienchuyen;//Trừ Tiền bên gửi
                    if (tienchuyen > tienbengui)
                    {
                        MessageBox.Show("Số Dư Của Bạn Không Đủ ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        if (tienchuyen < 0)
                            MessageBox.Show("Bạn Nhập Sai ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            if (matkhauxacnhan.Text == mk)
                            {
                                string update = "UPDATE KhachHang SET Tien='" + tongtienbengui + "'WHERE MaThe='" + mathe + "'";
                                SqlCommand command1 = new SqlCommand(update, ketnoi);
                                command1.ExecuteNonQuery();
                                string update1 = "UPDATE KhachHang SET Tien='" + tongtienbennhan + "'WHERE MaThe='" + thegui + "'";
                                SqlCommand command2 = new SqlCommand(update1, ketnoi);
                                command2.ExecuteNonQuery();
                                MessageBox.Show("Đã Chuyển Tiền Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //Insert vào bảng Chuyển Tiền 
                                string insert = "Insert into ChuyenTien(TienChuyen,NgayChuyen,GioChuyen,MaThe,MaTheNhan) Values('" + Convert.ToInt32(SoTienChuyen.Text) + "',N'" + txtNgayChuyen.Text + "',N'" + lbtime.Text + "',N'" + mathe + "',N'" + thegui + "')";
                                SqlCommand cmd = new SqlCommand(insert, ketnoi);
                                cmd.ExecuteNonQuery();
                                PrintChuyen.Enabled = false;
                                btChuyenTien.Enabled = false;
                            }
                            else
                                MessageBox.Show(" Đã Chuyển không Thành Công ", "Mật Khẩu Sai ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(" Nhập Sai ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Escape)
                this.Close();
            return base.ProcessDialogKey(keyData);
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbtime.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
          
        }

        private void PrintChuyen_Click(object sender, EventArgs e)
        {
            try
            {
                tienchuyen = int.Parse(SoTienChuyen.Text);
                thegui = int.Parse(MaTheGui.Text);
                SqlCommand command0 = new SqlCommand("select MaThe from KhachHang where MaThe='" + thegui + "'", ketnoi);
                SqlDataReader dta = command0.ExecuteReader();
                if (dta.Read() != true)
                {
                    MessageBox.Show("Không tìm thấy mả thẻ ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dta.Close();
                    dta.Dispose();
                }
                else
                {
                    dta.Close();
                    dta.Dispose();
                    //ketnoi.Open();
                    SqlCommand command = new SqlCommand("select Tien from KhachHang where MaThe='" + thegui + "'", ketnoi);
                    Int64 tienbennhan = Convert.ToInt64(command.ExecuteScalar());
                    tongtienbennhan = tienbennhan + tienchuyen;// Cong Tien ben nhận
                    tongtienbengui = tienbengui - tienchuyen;//Trừ Tiền bên gửi
                    if (tienchuyen > tienbengui)
                    {
                        MessageBox.Show("Số Dư Của Bạn Không Đủ ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        if (tienchuyen < 0)
                            MessageBox.Show("Bạn Nhập Sai ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            if (matkhauxacnhan.Text == mk)
                            {
                                string update = "UPDATE KhachHang SET Tien='" + tongtienbengui + "'WHERE MaThe='" + mathe + "'";
                                SqlCommand command1 = new SqlCommand(update, ketnoi);
                                command1.ExecuteNonQuery();
                                string update1 = "UPDATE KhachHang SET Tien='" + tongtienbennhan + "'WHERE MaThe='" + thegui + "'";
                                SqlCommand command2 = new SqlCommand(update1, ketnoi);
                                command2.ExecuteNonQuery();
                                MessageBox.Show("Đã Chuyển Tiền Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //Insert vào bảng Chuyển Tiền 
                                string insert = "Insert into ChuyenTien(TienChuyen,NgayChuyen,GioChuyen,MaThe,MaTheNhan) Values('" + Convert.ToInt32(SoTienChuyen.Text) + "',N'" + txtNgayChuyen.Text + "',N'"+lbtime.Text+ "',N'" + mathe + "',N'" + thegui + "')";
                                SqlCommand cmd = new SqlCommand(insert, ketnoi);
                                cmd.ExecuteNonQuery();
                                PrintChuyen.Enabled = false;
                                btChuyenTien.Enabled = false;
                                printPreviewDialog.Document = printDocument;
                                if (printPreviewDialog.ShowDialog() == DialogResult.OK)
                               {
                                printDocument.Print();
                                }
                            }
                            else
                                MessageBox.Show(" Đã Chuyển không Thành Công ", "Mật Khẩu Sai ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(" Nhập Sai ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            SqlCommand command = new SqlCommand("select IPChuyen from ChuyenTien where GioChuyen='" + lbtime.Text + "'", ketnoi);
            string ipchuyen = (string)command.ExecuteScalar().ToString();
            Bitmap bmp = Properties.Resources.Capture;
            Image newImage = bmp;
            e.Graphics.DrawImage(newImage, 25, 25, newImage.Width, newImage.Height);
            e.Graphics.DrawString(" Số Giao Dich : ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 150, 150);
            e.Graphics.DrawString(ipchuyen, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 600, 150);
            e.Graphics.DrawString(" Mã Thẻ Gửi : ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 150, 190);
            e.Graphics.DrawString(MaThe.Text, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 600, 190);
            e.Graphics.DrawString(" Mã Thẻ Nhận : ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 150, 230);
            e.Graphics.DrawString(MaTheGui.Text, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 600, 230);
            e.Graphics.DrawString(" Số Tiền Chuyển : ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 150, 270);
            e.Graphics.DrawString(SoTienChuyen.Text + " VNĐ ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 600, 270);
            e.Graphics.DrawString(" Số Dư : ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 150, 310);
            e.Graphics.DrawString(tongtienbengui.ToString()+" VNĐ ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 600, 310);
            e.Graphics.DrawString(" Ngày Giờ Chuyển : ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 150, 350);
            e.Graphics.DrawString(Day(DateTime.Now.DayOfWeek.ToString()) + " Ngày " + txtNgayChuyen.Text + " " + lbtime.Text, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 330, 350);
        }
    }
}
