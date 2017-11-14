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
        ThongTinTaiKhoan tk=new ThongTinTaiKhoan();
        GuiTien gt=new GuiTien();
        ChuyenTien ct=new ChuyenTien();
        RutTien rt=new RutTien();
        QuanLyKhacHang ql=new QuanLyKhacHang();
        SqlConnection ketnoi = new SqlConnection(@"Server = .;Database =NganHang1;Integrated Security=True");
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
        //Đóng trang chính
        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Bạn Có Muốn Thoát ? ", " Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dn.Show();
                tk.Close();
                gt.Close();
                ct.Close();
                rt.Close();
                ql.Close();
                this.Close();
            }
        }

        private void TTTaiKhoan_Click(object sender, EventArgs e)
        {
            //tk = new ThongTinTaiKhoan();
            //tk.Show();
            this.panel1.Controls.Clear();
            tk = new ThongTinTaiKhoan();
            tk.TopLevel = false;
            this.panel1.Controls.Add(tk);
            tk.Show();
            
        }
        //Gửi Tiền
        private void button2_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            gt = new GuiTien();
            gt.TopLevel = false;
            this.panel1.Controls.Add(gt);
            gt.Show();
        }
        //chuyen Tiền
        private void button3_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            ct = new ChuyenTien();
            ct.TopLevel = false;
            this.panel1.Controls.Add(ct);
            ct.Show();
        }
        //Rút Tiền
        private void button4_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            rt = new RutTien();
            rt.TopLevel = false;
            this.panel1.Controls.Add(rt);
            rt.Show();
        }
        //Quản Lý
        private void QuanLy_Click(object sender, EventArgs e)
        {
            ql = new QuanLyKhacHang();
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

        private void TrangChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Bạn muốn thoát khoải Trang Chính ?", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            //{
            //    dn.Show();
            //    tk.Close();
            //    gt.Close();
            //    ct.Close();
            //    rt.Close();
            //    ql.Close();
            //    this.Close();
            //    e.Cancel = true;

            //}
        }
    }
}
