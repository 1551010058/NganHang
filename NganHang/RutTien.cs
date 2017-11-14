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
using System.Drawing.Printing;
using System.Threading.Tasks;

namespace NganHang
{
    public partial class RutTien : Form
    {
        ClassTien TGV = new ClassTien();
        SqlConnection ketnoi = new SqlConnection(@"Server = .;Database =NganHang1;Integrated Security=True");
        public static string user4 = "";
        public RutTien()
        {
            InitializeComponent();
        }
        int mathe;
        Int64 tien,tienrut,tongtien=0;
        string mk;
        private void RutTien_Load(object sender, EventArgs e)
        {
          //  lbtime.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
            txtNgayRut.Text = DateTime.Now.Month.ToString()+"/"+DateTime.Now.Day.ToString()+"/"+DateTime.Now.Year.ToString();
            ketnoi.Open();
            SqlCommand command = new SqlCommand("select MaThe from KhachHang where TenDangNhap='" + user4 + "'", ketnoi);
            mathe = (int)command.ExecuteScalar();
            SqlCommand command5 = new SqlCommand("select Tien from KhachHang where TenDangNhap='" + user4 + "'", ketnoi);
            tien = Convert.ToInt64(command5.ExecuteScalar());
            SqlCommand command2 = new SqlCommand("select MatKhau from KhachHang where TenDangNhap='" + user4 + "'", ketnoi);
            mk = (string)command2.ExecuteScalar();
            MaThe.Text = mathe.ToString();
            SoDu.Text = tien.ToString("### ### ### ### VND").Trim();
            txtNgayRut.Visible = false;
            lbtime.Visible = false;
        }

        private void btRut_Click(object sender, EventArgs e)
        {
            try
            {
                tienrut = Int64.Parse(TienRut.Text);
                tongtien = tien - tienrut;
                if(tienrut>tien)
                {
                    MessageBox.Show(" Tiền Của Bạn Không Đủ ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    if (TGV.Tienrut1(tienrut) == false)
                        MessageBox.Show(" Nhập Sai ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if (TGV.Tienrut2(tienrut) == false)
                    {
                        MessageBox.Show(" Một lần bạn chỉ Rút tối đa được 100 triệu ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        if (matkhauxacnhan.Text == mk)
                        {
                            string update = "UPDATE KhachHang SET Tien='" + tongtien + "'WHERE MaThe='" + mathe + "'";
                            SqlCommand command = new SqlCommand(update, ketnoi);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Rút Tiền Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SqlCommand command5 = new SqlCommand("select Tien from KhachHang where TenDangNhap='" + user4 + "'", ketnoi);
                            tien = Convert.ToInt64(command5.ExecuteScalar());
                            SoDu.Text = tien.ToString("### ### ### ### VND").Trim();
                            //Insert vào bản RutTien
                            string insert = "Insert into RutTien(TienRut,NgayRut,GioRut,MaThe) Values('" + Convert.ToInt32(TienRut.Text) + "',N'" + txtNgayRut.Text + "',N'" +lbtime.Text+"',N'"+ mathe + "')";
                            SqlCommand cmd = new SqlCommand(insert, ketnoi);
                            cmd.ExecuteNonQuery();
                            //
                            btRut.Enabled = false;
                            PrintRut.Enabled = false;
                            matkhauxacnhan.Enabled = false;
                            TienRut.Enabled = false;
                        }
                        else
                            MessageBox.Show(" Rút Tiền Không Thành Công ", "Mật Khẩu Sai ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(FormatException)
            {
                MessageBox.Show(" Bạn Nhập Sai ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TienRut.Focus();
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

        private void PrintRut_Click(object sender, EventArgs e)
        {
            try
            {
                tienrut = Int64.Parse(TienRut.Text);
                tongtien = tien - tienrut;
                if (tienrut > tien)
                {
                    MessageBox.Show(" Tiền Của Bạn Không Đủ ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    if (TGV.Tienrut1(tienrut)==false)
                        MessageBox.Show(" Nhập Sai ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if (TGV.Tienrut2(tienrut) == false)
                    {
                        MessageBox.Show(" Một lần bạn chỉ Rút tối đa được 100 triệu ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        if (matkhauxacnhan.Text == mk)
                        {
                            string update = "UPDATE KhachHang SET Tien='" + tongtien + "'WHERE MaThe='" + mathe + "'";
                            SqlCommand command = new SqlCommand(update, ketnoi);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Rút Tiền Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SqlCommand command5 = new SqlCommand("select Tien from KhachHang where TenDangNhap='" + user4 + "'", ketnoi);
                            tien = Convert.ToInt64(command5.ExecuteScalar());
                            SoDu.Text = tien.ToString("### ### ### ### VND").Trim();
                            btRut.Enabled = false;
                            PrintRut.Enabled = false;
                            matkhauxacnhan.Enabled = false;
                            TienRut.Enabled = false;
                            //Insert vào bản RutTien
                            string insert = "Insert into RutTien(TienRut,NgayRut,GioRut,MaThe) Values('" + Convert.ToInt32(TienRut.Text) + "',N'" + txtNgayRut.Text + "',N'" + lbtime.Text + "',N'" + mathe + "')";
                            SqlCommand cmd = new SqlCommand(insert, ketnoi);
                            cmd.ExecuteNonQuery();
                            ///
                            printPreviewDialog.Document = printDocument;
                            if (printPreviewDialog.ShowDialog() == DialogResult.OK)
                            {
                                printDocument.Print();
                            }
                        }
                        else
                            MessageBox.Show(" Rút Tiền Không Thành Công ", "Mật Khẩu Sai ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show(" Bạn Nhập Sai ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TienRut.Focus();
            }
        }
        String thu = "";
        private String Day(string thu)
        {
            switch(thu)
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
        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            SqlCommand command = new SqlCommand("select IPRut from RutTien where GioRut='" + lbtime.Text + "'", ketnoi);
            string iprut = (string)command.ExecuteScalar().ToString();
            Bitmap bmp = Properties.Resources.Capture;
            Image newImage = bmp;
            e.Graphics.DrawImage(newImage, 25, 25, newImage.Width, newImage.Height);
            e.Graphics.DrawString(" Mã Thẻ : " ,new Font("Arial",14,FontStyle.Bold),Brushes.Black,150,150);
            e.Graphics.DrawString(MaThe.Text, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 600, 150);
            e.Graphics.DrawString(" Số Giao Dich : ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 150, 190);
            e.Graphics.DrawString(iprut, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 600, 190);
            e.Graphics.DrawString(" Số Tiền Rút : ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 150, 230);
            e.Graphics.DrawString(TienRut.Text+" VNĐ ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 600, 230);
            e.Graphics.DrawString(" Số Dư : ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 150, 270);
            e.Graphics.DrawString(tien.ToString() + " VNĐ ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 600, 270);
            e.Graphics.DrawString(" Ngày Gio Rút : ", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 150, 310);
            e.Graphics.DrawString(Day(DateTime.Now.DayOfWeek.ToString())+" Ngày " + txtNgayRut.Text + " " + lbtime.Text, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 330, 310);
        }

        private void Times_Tick(object sender, EventArgs e)
        {
            lbtime.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString();
        }

      

        

        
    }
}
