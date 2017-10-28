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
    public partial class TrangChinh : Form
    {
        DangNhap dn = new DangNhap();
        SqlConnection ketnoi = new SqlConnection(@"Data Source=DESKTOP-FPNJFC5;Initial Catalog=NganHang;Integrated Security=True");
        public TrangChinh()
        {
            InitializeComponent();
        }
        public static string user = "";
        private void TrangChinh_Load(object sender, EventArgs e)
        {
            ketnoi.Open();
            SqlCommand command = new SqlCommand("select Ten from KhachHang where TenDangNhap='" + user + "'", ketnoi);
            string hoten = (string)command.ExecuteScalar();
            SqlCommand command2 = new SqlCommand("select Ho from KhachHang where TenDangNhap='" + user + "'", ketnoi);
            string ho = (string)command2.ExecuteScalar();
            SqlCommand command1 = new SqlCommand("select MaQuyen from KhachHang where TenDangNhap='" + user + "'", ketnoi);
            string ma = (string)command1.ExecuteScalar();
            hien.Text = " Xin Chào " +ho.ToString()+" "+ hoten.ToString();
            if(ma=="Admin")
            {
                QuanLy.Enabled = true;
            }
            else
            {
                QuanLy.Enabled = false;
                QuanLy.Visible = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dn.Show();
            //user = null;
            this.Close();
        }

        private void TTTaiKhoan_Click(object sender, EventArgs e)
        {
            ThongTinTaiKhoan tk = new ThongTinTaiKhoan();
            tk.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GuiTien gt = new GuiTien();
            gt.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChuyenTien ct = new ChuyenTien();
            ct.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RutTien rt = new RutTien();
            rt.Show();
        }

        private void QuanLy_Click(object sender, EventArgs e)
        {
            QuanLyKhacHang ql = new QuanLyKhacHang();
            ql.Show();

        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                dn.Show();
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
