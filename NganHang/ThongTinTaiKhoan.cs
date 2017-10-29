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

        SqlConnection ketnoi = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Vipper\Desktop\NganHang\Database\NganHang.mdf;Integrated Security=True;Connect Timeout=30");
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
            int tien = (int)command5.ExecuteScalar();
            SqlCommand command6 = new SqlCommand("select DiaChi from KhachHang where TenDangNhap='" + user1 + "'", ketnoi);
            string diachi = (string)command6.ExecuteScalar();
            SqlCommand command7 = new SqlCommand("select NgaySinh from KhachHang where TenDangNhap='" + user1 + "'", ketnoi);
            txtNgaySinh.Text = command7.ExecuteScalar().ToString();
            HovaTen.Text = ho.ToString() + " " + ten.ToString();
            MaThe.Text = mathe.ToString();
            CMND.Text = cmnd.ToString();
            SDT.Text = sdt.ToString();
            SoDu.Text = tien.ToString();
            DiaChi.Text = diachi.ToString();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Escape)
                this.Close();
            return base.ProcessDialogKey(keyData);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoiMaPin dmp = new DoiMaPin();
            dmp.ShowDialog();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
