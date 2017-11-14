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
    public partial class ThongTinTaiKhoan : Form
    {
        SqlConnection ketnoi = new SqlConnection(@"Server = .;Database =NganHang1;Integrated Security=True");
        public static string user1 = "";
       
        public ThongTinTaiKhoan()
        {
            InitializeComponent();
        }

        private void ThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            ketnoi.Open();
            SqlCommand command = new SqlCommand("select Ho from KhachHang where TenDangNhap='" + user1 + "'", ketnoi);
            string ho = (string)command.ExecuteScalar();
            SqlCommand command1 = new SqlCommand("select Ten from KhachHang where TenDangNhap='" + user1 + "'", ketnoi);
            string ten = (string)command1.ExecuteScalar();
            SqlCommand command2 = new SqlCommand("select MaThe from KhachHang where TenDangNhap='" + user1 + "'", ketnoi);
            int mathe = (int)command2.ExecuteScalar();
            SqlCommand command3 = new SqlCommand("select CMND from KhachHang where TenDangNhap='" + user1 + "'", ketnoi);
            string cmnd = (string)command3.ExecuteScalar();
            SqlCommand command4 = new SqlCommand("select SDT from KhachHang where TenDangNhap='" + user1 + "'", ketnoi);
            string sdt = (string)command4.ExecuteScalar();
            SqlCommand command5 = new SqlCommand("select Tien from KhachHang where TenDangNhap='" + user1 + "'", ketnoi);
            Int64 tien = Convert.ToInt64(command5.ExecuteScalar());
            SqlCommand command6 = new SqlCommand("select DiaChi from KhachHang where TenDangNhap='" + user1 + "'", ketnoi);
            string diachi = (string)command6.ExecuteScalar();
            SqlCommand command7 = new SqlCommand("select NgaySinh from KhachHang where TenDangNhap='" + user1 + "'", ketnoi);
            txtNgaySinh.Text = command7.ExecuteScalar().ToString(); 
           HovaTen.Text =ho.ToString()+ " "+ten.ToString();
           MaThe.Text = mathe.ToString();
           CMND.Text = cmnd.ToString();
           SDT.Text = sdt.ToString();
           SoDu.Text = tien.ToString("### ### ### ### VND").Trim();
           DiaChi.Text = diachi.ToString();
           


        }

       
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Escape)
                this.Close();
            return base.ProcessDialogKey(keyData);
        }
        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoiMaPin pin = new DoiMaPin();
            pin.Show();
        }
    }
}
