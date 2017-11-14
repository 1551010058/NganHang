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
using System.Threading;
namespace NganHang
{
    public partial class DangNhap : Form
    {
        HieuUng hiuung = new HieuUng();
        int count = 0;
        public DangNhap()
        {
            Thread t = new Thread(new ThreadStart(Start));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }
        public void Start()
        {
            Application.Run(new HieuUng());
        }
        public string getdangnhap()
        {
            return txtTendangnhap.Text;
        }
        public static string user = "", user1 = " ", user2 = " ", user3 = " ", user4 = " ",user5=" ";
        
        
        private void Init()
        {   
            SqlConnection ketnoi = new SqlConnection(@"Server = .;Database =NganHang1;Integrated Security=True");
            try
            {
                ketnoi.Open();
                DangNhapTk dntk = new DangNhapTk(); //testcase
                string tk = getdangnhap();
                string mk = txtmatkhau.Text;
               dntk.User(tk, mk); //test case
               // //string sql = "select *from KhachHang where TenDangNhap= @TK  and MatKhau=@MK";
               // //SqlCommand cmd = new SqlCommand();
               // //cmd.CommandText = sql;
               // //cmd.Parameters.AddWithValue("@TK", tk);
               // //cmd.Parameters.AddWithValue("@MK", mk);
               // //cmd.Connection = ketnoi;
               SqlDataReader dta = (DangNhapTk.cmd).ExecuteReader();

               if (dta.Read() == true)
               {
                   MessageBox.Show("Đăng Nhập Thành Công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   TrangChinh frm = new TrangChinh();
                   TrangChinh.user = txtTendangnhap.Text;//luu ten dang nhap
                   ThongTinTaiKhoan.user1 = txtTendangnhap.Text;
                   GuiTien.user2 = txtTendangnhap.Text;
                   ChuyenTien.user3 = txtTendangnhap.Text;
                   RutTien.user4 = txtTendangnhap.Text;
                   DoiMaPin.user5 = txtTendangnhap.Text;
                   frm.Show();

                   this.Hide();
                   DangNhapTk.cmd.Dispose();//test case
                    dta.Close();
                     dta.Dispose();
                   hiuung.Close();

               }
               else
               {
                   count++;
                   if (count >= 5)
                   {
                       MessageBox.Show("Tài khoản bạn đã bị tạm giữ ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       return;
                   }
                   else
                       MessageBox.Show("Đăng Nhập không Thành Công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Lỗi Kết Nối " + ex.Message);
            }
        }
        
        
        private void DangNhap_Load(object sender, EventArgs e)
        {
            //hiuung.Show();
            //System.Threading.Thread.Sleep(3000);
            //hiuung.Close();   
        }

        private void btdangky_Click(object sender, EventArgs e)
        {
            DangKy dk = new DangKy();
            dk.Show();
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                Init();
            }
            if (keyData == Keys.Escape)
                this.Close();
            return base.ProcessDialogKey(keyData);
        }

        private void btdangnhap_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đóng chương trình", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                timer1.Enabled = true;
                timer1_Tick(sender, e);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity - 0.08;
            if (this.Opacity < 0.1) this.Close();
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Bạn muốn đóng chương trình", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            //{
            //    e.Cancel = true;
            //    timer1.Enabled = true;
            //    timer1_Tick(sender, e);
            //}
        }
       
       

       

     

       
        

       
             
      

      
    }
}
