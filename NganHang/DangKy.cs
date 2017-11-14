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
        ErrorProvider Error = new ErrorProvider();
        SqlConnection ketnoi = new SqlConnection(@"Server = .;Database =NganHang1;Integrated Security=True");
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
        DungChung DC = new DungChung();

        private void dangky()
        {
            
            Error.Clear();
            String[] arrDangKy = txtTenDangNhap.Text.Split(' ');
            String[] arrSDT = txtSDT.Text.Split(' ');
            String[] arrmk=txtMatKhau.Text.Split(' ');
            String[] arrcmnd = txtCMND.Text.Split(' ');
           
            if (DC.kiemtratrongchuoi(txtTenDangNhap.Text)==true)
            {
                MessageBox.Show(" Không được có khoảng trống ở Tên Đăng Nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Error.SetError(txtTenDangNhap, "a");
                txtTenDangNhap.Focus();
            }
            else if(arrSDT.Count()>1)
            {
                MessageBox.Show(" Không được có khoảng trống ở SĐT", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Error.SetError(txtSDT, " a ");
                txtSDT.Focus();
            }
            else if(arrmk.Count()>1)
            {
                MessageBox.Show(" Không được có khoảng trống ở mật khẩu ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Error.SetError(txtMatKhau, " a ");
                txtMatKhau.Focus();
            }
            else if(arrcmnd.Count()>1)
            {
                MessageBox.Show(" Không được có khoảng trống ở CMND ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Error.SetError(txtCMND, " a ");
                txtCMND.Focus();
            }
            else 
                //hàm tren kt ten dang nhap ko dc có khoảng trắng
                if (DC.KiemTra_Rong(txtTenDangNhap.Text) == false || DC.KiemTra_Rong(txtMatKhau.Text) ==false || DC.KiemTra_Rong(txtHo.Text) == false || DC.KiemTra_Rong(txtTen.Text) == false || DC.KiemTra_Rong(txtNgaySinh.Text) == false ||
                DC.KiemTra_Rong(txtSDT.Text) == false || DC.KiemTra_Rong(txtDiaChi.Text) == false || DC.KiemTra_Rong(txtCMND.Text) == false || DC.KiemTra_Rong(txtGioiTinh.Text) == false)
                {
                    MessageBox.Show(" Bạn Chưa Nhập Dử Liệu ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (DC.KiemTra_Rong(txtCMND.Text) ==false)
                    {
                        Error.SetError(txtCMND, "a");
                        txtCMND.Focus();
                    }
                    if (DC.KiemTra_Rong(txtDiaChi.Text) == false)
                    {
                        Error.SetError(txtDiaChi, "a");
                        txtDiaChi.Focus();
                    }
                    if (DC.KiemTra_Rong(txtGioiTinh.Text) == false)
                    {
                        Error.SetError(txtGioiTinh, "a");
                        txtGioiTinh.Focus();
                    }
                    if (DC.KiemTra_Rong(txtHo.Text) == false)
                    {
                        Error.SetError(txtHo, "a");
                        txtHo.Focus();
                    }
                    if (DC.KiemTra_Rong(txtMatKhau.Text) == false)
                    {
                        Error.SetError(txtMatKhau, "a");
                        txtMatKhau.Focus();
                    }
                    if (DC.KiemTra_Rong(txtNgaySinh.Text) == false)
                    {
                        Error.SetError(txtNgaySinh, "a");
                        txtNgaySinh.Focus();
                    }
                    if (DC.KiemTra_Rong(txtSDT.Text) == false)
                    {
                        Error.SetError(txtSDT, "a");
                        txtSDT.Focus();
                    }
                    if (DC.KiemTra_Rong(txtTen.Text) == false)
                    {
                        Error.SetError(txtTen, "a");
                        txtTen.Focus();
                    }
                    if (DC.KiemTra_Rong(txtTenDangNhap.Text) == false)
                    {
                        Error.SetError(txtTenDangNhap, "a");
                        txtTenDangNhap.Focus();
                    }
                    if (DC.KiemTra_Rong(txtTien.Text) == false)
                    {
                        Error.SetError(txtTien, "a");
                        txtTien.Focus();
                    }

                }
                else if (DC.kiemtratontai(txtTenDangNhap.Text) == true || DC.kiemtrasdttontai(txtSDT.Text) == true || DC.kiemtracmndtontai(txtCMND.Text) == true)
                {

                    if (DC.kiemtratontai(txtTenDangNhap.Text) == true)
                    {
                        Error.SetError(txtTenDangNhap, " a ");
                        txtTenDangNhap.Focus();
                    }
                    if (DC.kiemtrasdttontai(txtSDT.Text) == true)
                    {
                        Error.SetError(txtSDT, "a");
                        txtSDT.Focus();
                    }
                    if (DC.kiemtracmndtontai(txtCMND.Text) == true)
                    {
                        Error.SetError(txtCMND, "a");
                        txtCMND.Focus();
                    }
            }
            else if (DC.kiemtrauerpass(txtTenDangNhap.Text) == false)
            {
                MessageBox.Show(" Có Ký tự đặt biệt ở Tên Đăng Nhập ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Error.SetError(txtTenDangNhap, " a ");
                txtTenDangNhap.Focus();
            }
            else if (DC.kiemtrauerpass(txtMatKhau.Text) == false)
            {
                MessageBox.Show(" Có Ký tự đặt biệt ở Mật Khẩu ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Error.SetError(txtMatKhau, " a ");
                txtMatKhau.Focus();
            }
            else if (DC.kiemtrakitu(txtHo.Text) == false)
            {
                MessageBox.Show(" Có Ký tự đặt biệt ở Họ ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Error.SetError(txtHo, " a ");
                txtHo.Focus();
            }
            else if (DC.kiemtrakitu(txtTen.Text) == false)
            {
                MessageBox.Show(" Có Ký tự đặt biệt ở Ten ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Error.SetError(txtTen, " a ");
                txtTen.Focus();
            }
            else if (DC.kiemtrakitu(txtDiaChi.Text) == false)
            {
                MessageBox.Show(" Có Ký tự đặt biệt ở Địa Chỉ ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Error.SetError(txtDiaChi, " a ");
                txtDiaChi.Focus();
            }
            else if (DC.SDT(txtSDT.Text)==false)
            {
                MessageBox.Show(" Số Điện Thoại phải nằm trong khoảng 10 đên 11 số ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Error.SetError(txtSDT, " a ");
                txtSDT.Focus();
            }
            else if (DC.CMND(txtCMND.Text)==false)
            {
                MessageBox.Show(" CMND phải 9 số và 12 số ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Error.SetError(txtCMND, " a ");
                txtCMND.Focus();
            }
            else if(DC.MatKhau(txtMatKhau.Text)==false)
            {
                MessageBox.Show(" Mật khẩu từ 6 ký tự trở lên ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Error.SetError(txtMatKhau, " a ");
                txtMatKhau.Focus();
            }
            else

                {

                    ketnoi.Open();
                    string nhap = "Insert Into KhachHang(MaQuyen,TenDangNhap,MatKhau,Ho,Ten,NgaySinh,GioiTinh,SDT,CMND,DiaChi,Tien)" + "Values ('" + "User" + "',N'" + txtTenDangNhap.Text + "',N'" + txtMatKhau.Text + "',N'" + txtHo.Text + "',N'" + txtTen.Text + "',N'" +txtNgaySinh.Text+"',N'"+ txtGioiTinh.Text + "',N'" + txtSDT.Text + "',N'" + txtCMND.Text + "',N'" + txtDiaChi.Text + "',N'" + 100000 + "')";
                    SqlCommand command = new SqlCommand(nhap, ketnoi);
                    command.ExecuteNonQuery();
                    MessageBox.Show(" Bạn Đăng Ký Thành Công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Loi1.Text = null;
                    Loi8.Text = null;
                    Loi7.Text = null;
                    this.Close();
                }
            //else if(kiemtrataikhoantontai() == false || kiemtrasdttontai() == false || kiemtraCMNDtontai() == false)
            //    {
            //        Loi1.Text = null;
            //        Loi8.Text = null;
            //        Loi7.Text = null;
            //    }
        }
       
        //private bool kiemtraCMNDtontai()
        //{
        //    string tdn;
        //    try
        //    {
        //        tdn = String.Format(txtCMND.Text);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(" Nhập Sai ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    bool kt = false;
        //    tdn = String.Format(txtCMND.Text);
        //    ketnoi.Open();
        //    SqlDataAdapter da_kt = new SqlDataAdapter("Select * from KhachHang where CMND='" + tdn + "'", ketnoi);
        //    DataTable dt_kiemtra = new DataTable();
        //    da_kt.Fill(dt_kiemtra);
        //    if (dt_kiemtra.Rows.Count > 0)
        //    {
        //        kt = true;
        //    }
        //    da_kt.Dispose();
        //    ketnoi.Close();
            
        //    return kt;
        //}

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Escape)
                this.Close();
            return base.ProcessDialogKey(keyData);
        }
        //áàảạã ăắằẳẵặ âấầẩẫậ êềễểếệ ùúủũụ ưứừửựữ ìíỉịĩ òóỏõọ ôốồỗộổ ờởớỡợơ yýỳỷỹỵ éèẻẹẽ
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {

        }
       
    }
}
