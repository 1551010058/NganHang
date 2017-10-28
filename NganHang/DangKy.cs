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
    public partial class DangKy : Form
    {
        SqlConnection ketnoi = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Vipper\Desktop\NganHang\Database\NganHang.mdf;Integrated Security=True;Connect Timeout=30");
        public DangKy()
        {
            InitializeComponent();
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void DangKy_Load(object sender, EventArgs e)
        {
        }
        private void btDangKy_Click(object sender, EventArgs e)
        {
            dangky();
        }
        private void dangky()
        {
            String[] arrDangKy = txtTenDangNhap.Text.Split(' ');
            String[] arrSDT = txtSDT.Text.Split(' ');
            String[] arrmk=txtMatKhau.Text.Split(' ');
            String[] arrcmnd = txtCMND.Text.Split(' ');
            if (arrDangKy.Count() > 1 || arrSDT.Count() > 1|| arrmk.Count()>1||arrcmnd.Count()>1)
            {
                MessageBox.Show(" Khong được có khoảng trống ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
                //hàm tren kt ten dang nhap ko dc có khoảng trắng
                if (kiemtrataikhoantontai() == true && kiemtrasdttontai() == true && kiemtraCMNDtontai() == true)
                {
                    Loi1.Text = " * ";
                    Loi7.Text = " * ";
                    Loi8.Text = " * ";
                }
                else if (kiemtrataikhoantontai() == true && kiemtrasdttontai() == true)
                {
                    Loi8.Text = null;
                    Loi1.Text = " * ";
                    Loi7.Text = " * ";
                }
                else if (kiemtrataikhoantontai() == true && kiemtraCMNDtontai() == true)
                {
                    Loi7.Text = null;
                    Loi1.Text = " * ";
                    Loi8.Text = " * ";
                }
                else if (kiemtraCMNDtontai() == true && kiemtraCMNDtontai() == true)
                {
                    Loi1.Text = null;
                    Loi7.Text = " * ";
                    Loi8.Text = " * ";
                }
                else if (kiemtrataikhoantontai() == true)
                {
                    Loi7.Text = null;
                    Loi8.Text = null;
                    Loi1.Text = " * ";
                }
                else if (kiemtrasdttontai() == true)
                {
                    Loi1.Text = null;
                    Loi8.Text = null;
                    Loi7.Text = " * ";
                }
                else if (kiemtraCMNDtontai() == true)
                {
                    Loi1.Text = null;
                    Loi8.Text = " * ";
                    Loi7.Text = null;
                }
                else if (txtTenDangNhap.Text == "" || txtMatKhau.Text == "" || txtHo.Text == "" || txtTen.Text == "" || txtNgaySinh.Text == "" ||
                txtSDT.Text == "" || txtDiaChi.Text == "" || txtCMND.Text == "")
                {
                    MessageBox.Show(" Bạn Chưa Nhập Dử Liệu ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if ((txtSDT.Text.Length < 10 || txtSDT.Text.Length > 11))
                {
                    MessageBox.Show(" Số Điện Thoại phải nằm trong khoảng 10 đên 11 số ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if ((txtCMND.Text.Length < 9 || txtCMND.Text.Length > 9) && (txtCMND.Text.Length < 12 || txtCMND.Text.Length > 12))
                {
                    MessageBox.Show(" CMND phải 9 số và 12 số ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(txtMatKhau.Text.Length <6 || txtMatKhau.Text.Length >=20)
                {
                    MessageBox.Show(" Mật khẩu từ 6 ký tự trở lên ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else

                {

                    ketnoi.Open();
                    string nhap = "Insert Into KhachHang(MaQuyen,TenDangNhap,MatKhau,Ho,Ten,NgaySinh,GioiTinh,SDT,CMND,DiaChi,Tien)" + "Values ('" + "User" + "',N'" + txtTenDangNhap.Text + "',N'" + txtMatKhau.Text + "',N'" + txtHo.Text + "',N'" + txtTen.Text + "',N'" +txtNgaySinh.Text+"',N'"+ txtGioiTinh.Text + "',N'" + txtSDT.Text + "',N'" + txtCMND.Text + "',N'" + txtDiaChi.Text + "',N'" + 100000 + "')";
                    SqlCommand command = new SqlCommand(nhap, ketnoi);
                    command.ExecuteNonQuery();
                    MessageBox.Show(" Bạn Đăng Ký Thành Công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            //else if(kiemtrataikhoantontai() == false || kiemtrasdttontai() == false || kiemtraCMNDtontai() == false)
            //    {
            //        Loi1.Text = null;
            //        Loi8.Text = null;
            //        Loi7.Text = null;
            //    }
        }
        private bool kiemtrataikhoantontai()
        {
            bool kt = false;
            string tdn = txtTenDangNhap.Text;
            ketnoi.Open();
            SqlDataAdapter da_kt = new SqlDataAdapter("Select * from KhachHang where TenDangNhap='" + tdn + "'", ketnoi);
            DataTable dt_kiemtra = new DataTable();
            da_kt.Fill(dt_kiemtra);
            if(dt_kiemtra.Rows.Count>0)
            {
                kt = true;

            }
            da_kt.Dispose();
            ketnoi.Close();
            return kt;
        }
        private bool kiemtrasdttontai()
        {
            string tdn;
            try
            {
                tdn = String.Format(txtSDT.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Nhập Sai ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            bool kt = false;
            tdn = String.Format(txtSDT.Text);
           
            ketnoi.Open();
            SqlDataAdapter da_kt = new SqlDataAdapter("Select * from KhachHang where SDT='" + tdn + "'", ketnoi);
            DataTable dt_kiemtra = new DataTable();
            da_kt.Fill(dt_kiemtra);
            if (dt_kiemtra.Rows.Count > 0)
            {
               kt = true;

            }
            da_kt.Dispose();
            ketnoi.Close();
           
            return kt;
        }
        private bool kiemtraCMNDtontai()
        {
            string tdn;
            try
            {
                tdn = String.Format(txtCMND.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Nhập Sai ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            bool kt = false;
            tdn = String.Format(txtCMND.Text);
            ketnoi.Open();
            SqlDataAdapter da_kt = new SqlDataAdapter("Select * from KhachHang where CMND='" + tdn + "'", ketnoi);
            DataTable dt_kiemtra = new DataTable();
            da_kt.Fill(dt_kiemtra);
            if (dt_kiemtra.Rows.Count > 0)
            {
                kt = true;
            }
            da_kt.Dispose();
            ketnoi.Close();
            
            return kt;
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Escape)
                this.Close();
            return base.ProcessDialogKey(keyData);
        }

       
    }
}
