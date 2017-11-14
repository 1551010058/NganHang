using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace NganHang
{
    public partial class QuanLyKhacHang : Form
    {
        SqlConnection ketnoi = new SqlConnection(@"Server = .;Database =NganHang1;Integrated Security=True");
         ErrorProvider Error = new ErrorProvider();
        public QuanLyKhacHang()
        {
            InitializeComponent();
        }
        private void QuanLyKhacHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nganHang1DataSet.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.nganHang1DataSet.KhachHang);
            // TODO: This line of code loads data into the 'nganHangDataSet.KhachHang' table. You can move, or remove it, as needed.
           // this.khachHangTableAdapter.Fill(this.nganHangDataSet.KhachHang);
            ketnoi.Open();
            hienthi();
            txtSearchmathe.Focus();
        }
        private void QuanLyKhacHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ketnoi.Close();
        }
        public void hienthi()
        {

            string sqlselect = "SELECT *FROM KhachHang";
            SqlCommand command = new SqlCommand(sqlselect, ketnoi);

            SqlDataReader rd = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            dataDanhSach.DataSource = dt;
            ketnoi.Close();



        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            Error.Clear();
            String[] arrDangKy = txtuser.Text.Split(' ');
            String[] arrSDT = txtSDT.Text.Split(' ');
            String[] arrcmnd = txtCMND.Text.Split(' ');
            String[] arrmatkhau = txtpasswork.Text.Split(' ');
            if (txtuser.Text == "" || txtpasswork.Text == "" || txtHo.Text == "" || txtTen.Text == "" || cboGioiTinh.Text == "" ||
                    txtSDT.Text == "" || txtDiaChi.Text == "" || cboQuyen.Text == "" || txtagainpasswork.Text == "" || txtCMND.Text == "")
                {
                    MessageBox.Show(" Bạn Chưa Nhập Dử Liệu ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (txtCMND.Text == "")
                    {
                        Error.SetError(txtCMND, "a");
                        txtCMND.Focus();
                    }
                    if (txtDiaChi.Text == "")
                    {
                        Error.SetError(txtDiaChi, "a");
                        txtDiaChi.Focus();
                    }
                    if (cboGioiTinh.Text == "")
                    {
                        Error.SetError(cboGioiTinh, "a");
                        cboGioiTinh.Focus();
                    }
                    if (txtHo.Text == "")
                    {
                        Error.SetError(txtHo, "a");
                        txtHo.Focus();
                    }
                    if (txtpasswork.Text == "")
                    {
                        Error.SetError(txtpasswork, "a");
                        txtpasswork.Focus();
                    }
                    if (txtNgaySinh.Text == "")
                    {
                        Error.SetError(txtNgaySinh, "a");
                        txtNgaySinh.Focus();
                    }
                    if (txtSDT.Text == "")
                    {
                        Error.SetError(txtSDT, "a");
                        txtSDT.Focus();
                    }
                    if (txtTen.Text == "")
                    {
                        Error.SetError(txtTen, "a");
                        txtTen.Focus();
                    }
                    if (txtuser.Text == "")
                    {
                        Error.SetError(txtuser, "a");
                        txtuser.Focus();
                    }
                    if (txtmoney.Text == "")
                    {
                        Error.SetError(txtmoney, "a");
                        txtmoney.Focus();
                    }
                    if(cboQuyen.Text=="")
                    {
                        Error.SetError(cboQuyen, "a");
                        cboQuyen.Focus();
                    }
                    if(txtagainpasswork.Text=="")
                    {
                        Error.SetError(txtagainpasswork, "a");
                        txtagainpasswork.Focus();
                    }

                }
           
            else
                if (arrDangKy.Count() > 1)
                {
                    MessageBox.Show(" không được có khoảng trống ở Tên đăng nhập ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Error.SetError(txtHo, " a ");
                    txtuser.Focus();
                    
                }
                else if(arrSDT.Count()>1)
                {
                    MessageBox.Show(" không được có khoảng trống ở SDT ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Error.SetError(txtSDT, " a ");
                    txtSDT.Focus();
                }
                else if(arrcmnd.Count()>1)
                {
                    MessageBox.Show(" không được có khoảng trống ở CMND ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Error.SetError(txtCMND, " a ");
                    txtCMND.Focus();
                }
                else if(arrmatkhau.Count()>1)
                {
                    MessageBox.Show(" không được có khoảng trống ở passswork ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Error.SetError(txtpasswork, " a ");
                    txtpasswork.Focus();
                }
                else
                    if (kiemtrataikhoantontai() == true && kiemtrasdttontai() == true && kiemtraCMNDtontai() == true)
                    {
                        if (kiemtrataikhoantontai() == true)
                        {
                            Error.SetError(txtuser, " a ");
                            txtuser.Focus();
                        }
                        if (kiemtrasdttontai() == true)
                        {
                            Error.SetError(txtSDT, "a");
                            txtSDT.Focus();
                        }
                        if (kiemtraCMNDtontai() == true)
                        {
                            Error.SetError(txtCMND, "a");
                            txtCMND.Focus();
                        }
                    }
                    else if (kiemtrauerpass(txtuser.Text) == false)
                    {
                        MessageBox.Show(" Có Ký tự đặt biệt ở Tên Đăng Nhập ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Error.SetError(txtuser, " a ");
                        txtuser.Focus();
                    }
                    else if (kiemtrauerpass(txtpasswork.Text) == false)
                    {
                        MessageBox.Show(" Có Ký tự đặt biệt ở Mật Khẩu ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Error.SetError(txtpasswork, " a ");
                        txtpasswork.Focus();
                    }
                    else if (kiemtrakitu(txtHo.Text) == false)
                    {
                        MessageBox.Show(" Có Ký tự đặt biệt ở Họ ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Error.SetError(txtHo, " a ");
                        txtHo.Focus();
                    }
                    else if (kiemtrakitu(txtTen.Text) == false)
                    {
                        MessageBox.Show(" Có Ký tự đặt biệt ở Ten ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Error.SetError(txtTen, " a ");
                        txtTen.Focus();
                    }
                    else if (kiemtrakitu(txtDiaChi.Text) == false)
                    {
                        MessageBox.Show(" Có Ký tự đặt biệt ở Địa Chỉ ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Error.SetError(txtDiaChi, " a ");
                        txtDiaChi.Focus();
                    }

                    else if (txtpasswork.Text != txtagainpasswork.Text)
                    {
                        MessageBox.Show("  Nhập lai mật khẩu không đúng ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Error.SetError(txtagainpasswork, " a ");
                        txtagainpasswork.Focus();
                    }
                    else if ((txtSDT.Text.Length < 10 || txtSDT.Text.Length > 11))
                    {
                        MessageBox.Show(" Số Điện Thoại phải nằm trong khoảng 10 đên 11 số ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Error.SetError(txtSDT, " a ");
                        txtSDT.Focus();
                    }
                    else if ((txtCMND.Text.Length < 9 || txtCMND.Text.Length > 9) && (txtCMND.Text.Length < 12 || txtCMND.Text.Length > 12))
                    {
                        MessageBox.Show(" CMND phải 9 số và 12 số ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Error.SetError(txtCMND, " a ");
                        txtCMND.Focus();
                    }
                    else if (txtpasswork.Text.Length < 6 || txtpasswork.Text.Length >= 20)
                    {
                        MessageBox.Show(" Mật khẩu từ 6 ký tự trở lên ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Error.SetError(txtpasswork, " a ");
                        txtpasswork.Focus();
                    }
                    else
                    {
                        ketnoi.Open();
                        string nhap = "Insert Into KhachHang(MaQuyen,TenDangNhap,MatKhau,Ho,Ten,NgaySinh,GioiTinh,SDT,CMND,DiaChi,Tien) Values ('" + cboQuyen.Text + "',N'" + txtuser.Text + "',N'" + txtpasswork.Text + "',N'" + txtHo.Text + "',N'" + txtTen.Text + "',N'" + txtNgaySinh.Text + "',N'" + cboGioiTinh.Text + "',N'" + txtSDT.Text + "',N'" + txtCMND.Text + "',N'" + txtDiaChi.Text + "',N'" +Convert.ToInt64(txtmoney.Text) + "')";
                        SqlCommand command = new SqlCommand(nhap, ketnoi);
                        command.ExecuteNonQuery();
                        MessageBox.Show(" Bạn Thêm Thành Công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        hienthi();
                        ketnoi.Close();
                    }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            Error.Clear();
            String[] arrDangKy = txtuser.Text.Split(' ');
            String[] arrSDT = txtSDT.Text.Split(' ');
            String[] arrcmnd = txtCMND.Text.Split(' ');
            String[] arrmatkhau = txtpasswork.Text.Split(' ');
            if (txtuser.Text == "" || txtpasswork.Text == "" || txtHo.Text == "" || txtTen.Text == "" || cboGioiTinh.Text == "" ||
                    txtSDT.Text == "" || txtDiaChi.Text == "" || cboQuyen.Text == "" || txtagainpasswork.Text == "" || txtCMND.Text == "")
            {
                MessageBox.Show(" Bạn Chưa Nhập Dử Liệu ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (txtCMND.Text == "")
                {
                    Error.SetError(txtCMND, "a");
                    txtCMND.Focus();
                }
                if (txtDiaChi.Text == "")
                {
                    Error.SetError(txtDiaChi, "a");
                    txtDiaChi.Focus();
                }
                if (cboGioiTinh.Text == "")
                {
                    Error.SetError(cboGioiTinh, "a");
                    cboGioiTinh.Focus();
                }
                if (txtHo.Text == "")
                {
                    Error.SetError(txtHo, "a");
                    txtHo.Focus();
                }
                if (txtpasswork.Text == "")
                {
                    Error.SetError(txtpasswork, "a");
                    txtpasswork.Focus();
                }
                if (txtNgaySinh.Text == "")
                {
                    Error.SetError(txtNgaySinh, "a");
                    txtNgaySinh.Focus();
                }
                if (txtSDT.Text == "")
                {
                    Error.SetError(txtSDT, "a");
                    txtSDT.Focus();
                }
                if (txtTen.Text == "")
                {
                    Error.SetError(txtTen, "a");
                    txtTen.Focus();
                }
                if (txtuser.Text == "")
                {
                    Error.SetError(txtuser, "a");
                    txtuser.Focus();
                }
                if (txtmoney.Text == "")
                {
                    Error.SetError(txtmoney, "a");
                    txtmoney.Focus();
                }
                if (cboQuyen.Text == "")
                {
                    Error.SetError(cboQuyen, "a");
                    cboQuyen.Focus();
                }
                if (txtagainpasswork.Text == "")
                {
                    Error.SetError(txtagainpasswork, "a");
                    txtagainpasswork.Focus();
                }

            }
            else if (arrDangKy.Count() > 1)
            {
                MessageBox.Show(" không được có khoảng trống ở Tên đăng nhập ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Error.SetError(txtuser, " không được có khoảng trống ở Tên đăng nhập ");
                txtuser.Focus();
            }
            else if (arrSDT.Count() > 1)
            {
                MessageBox.Show(" không được có khoảng trống ở SDT ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Error.SetError(txtSDT, "SDT");
                txtSDT.Focus();
            }
            else if (arrcmnd.Count() > 1)
            {
                MessageBox.Show(" không được có khoảng trống ở CMND ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Error.SetError(txtCMND, "CMND");
                txtCMND.Focus();
            }
            else if (arrmatkhau.Count() > 1)
            {
                MessageBox.Show(" không được có khoảng trống ở passswork ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Error.SetError(txtpasswork, "PassWork");
                txtpasswork.Focus();
            }
            else
               if (txtpasswork.Text != txtagainpasswork.Text)
                {
                    MessageBox.Show("  Nhập lai mật khẩu không đúng ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Error.SetError(txtagainpasswork, "agian");
                    txtagainpasswork.Focus();
                }
               else if (kiemtrauerpass(txtuser.Text) == false)
                {
                    MessageBox.Show(" Có Ký tự đặt biệt ở Tên Đăng Nhập ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Error.SetError(txtuser, "User");
                    txtuser.Focus();
                }
               else if (kiemtrauerpass(txtpasswork.Text) == false)
                {
                    MessageBox.Show(" Có Ký tự đặt biệt ở Mật Khẩu ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Error.SetError(txtpasswork, "PassWork");
                    txtpasswork.Focus();
                }
                else if (kiemtrakitu(txtHo.Text) == false)
                {
                    MessageBox.Show(" Có Ký tự đặt biệt ở Họ ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Error.SetError(txtHo, "Ho");
                    txtHo.Focus();
                }
                else if (kiemtrakitu(txtTen.Text) == false)
                {
                    MessageBox.Show(" Có Ký tự đặt biệt ở Ten ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Error.SetError(txtTen, "Ten");
                    txtTen.Focus();
                }
                else if (kiemtrakitu(txtDiaChi.Text) == false)
                {
                    MessageBox.Show(" Có Ký tự đặt biệt ở Địa Chỉ ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Error.SetError(txtDiaChi, "DiaChi");
                    txtDiaChi.Focus();
                }
                else if ((txtSDT.Text.Length < 10 || txtSDT.Text.Length > 11))
                {
                    MessageBox.Show(" Số Điện Thoại phải nằm trong khoảng 10 đên 11 số ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Error.SetError(txtSDT, "SDT");
                    txtSDT.Focus();
                }
                else if ((txtCMND.Text.Length < 9 || txtCMND.Text.Length > 9) && (txtCMND.Text.Length < 12 || txtCMND.Text.Length > 12))
                {
                    MessageBox.Show(" CMND phải 9 số và 12 số ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Error.SetError(txtCMND, "CMND");
                    txtCMND.Focus();
                }
                else if (txtpasswork.Text.Length < 6 || txtpasswork.Text.Length >= 20)
                {
                    MessageBox.Show(" Mật khẩu từ 6 ký tự trở lên ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Error.SetError(txtpasswork, " a ");
                    txtpasswork.Focus();
                }
                else
                {
                    ketnoi.Open();
                    SqlCommand cmdtk = new SqlCommand("select MaThe from KhachHang where MaThe='" + txtSearchmathe.Text + "'", ketnoi);
                    SqlDataReader data = cmdtk.ExecuteReader();
                    if (data.Read() != true)
                    {
                        MessageBox.Show("Không tìm thấy mả thẻ ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Error.SetError(txtSearchmathe, "Search");
                        txtSearchmathe.Focus();
                        data.Close();
                        data.Dispose();
                        ketnoi.Close();
                    }
                    else
                    {
                        data.Close();
                        data.Dispose();
                        ketnoi.Close();
                        ketnoi.Open();

                        string update = "Update KhachHang Set TenDangNhap=@TenDangNhap,MaQuyen=@MaQuyen,MatKhau=@MatKhau,Ho=@Ho,Ten=@Ten,NgaySinh=@NgaySinh,GioiTinh=@GioiTinh,SDT=@SDT,CMND=@CMND,DiaChi=@DiaChi,Tien=@Tien where MaThe=@MaThe";
                        SqlCommand command = new SqlCommand(update, ketnoi);
                        command.Parameters.AddWithValue("MaThe", txtSearchmathe.Text);
                        command.Parameters.AddWithValue("TenDangNhap", txtuser.Text);
                        command.Parameters.AddWithValue("MaQuyen", cboQuyen.Text);
                        command.Parameters.AddWithValue("MatKhau", txtpasswork.Text);
                        command.Parameters.AddWithValue("Ho", txtHo.Text);
                        command.Parameters.AddWithValue("Ten", txtTen.Text);
                        command.Parameters.AddWithValue("GioiTinh", cboGioiTinh.Text);
                        command.Parameters.AddWithValue("SDT", txtSDT.Text);
                        command.Parameters.AddWithValue("CMND", txtCMND.Text);
                        command.Parameters.AddWithValue("DiaChi", txtDiaChi.Text);
                        command.Parameters.AddWithValue("Tien", Convert.ToInt64(txtmoney.Text));
                        command.Parameters.AddWithValue("NgaySinh", txtNgaySinh.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show(" Bạn Sửa Thành Công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Loi4.Text = null;
                        Loi7.Text = null;
                        Loi5.Text = null;
                        hienthi();
                        ketnoi.Close();
                    }
                }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            Error.Clear();
            if (txtuser.Text == "")
            {
                MessageBox.Show(" Bạn Chưa tên user muốn xóa ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Error.SetError(txtuser, "a");
                txtuser.Focus();
            }
            else
            {
                ketnoi.Open();
                SqlCommand cmdtk = new SqlCommand("select TenDangNhap from KhachHang where TenDangNhap='" + txtuser.Text+ "'", ketnoi);
                SqlDataReader data = cmdtk.ExecuteReader();
                if (data.Read() != true)
                {
                    MessageBox.Show("Không tìm thấy tên đăng nhập ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Error.SetError(txtuser, "a");
                    txtuser.Focus();
                    data.Close();
                    data.Dispose();
                    ketnoi.Close();
                }
                else
                {
                    data.Close();
                    data.Dispose();
                    
                   
                    string xoa = "Delete from KhachHang where TenDangNhap=@TenDangNhap";
                    SqlCommand command = new SqlCommand(xoa, ketnoi);
                    command.Parameters.AddWithValue("MaQuyen", cboQuyen.Text);
                    command.Parameters.AddWithValue("TenDangNhap", txtuser.Text);
                    command.Parameters.AddWithValue("MatKhau", txtpasswork.Text);
                    command.Parameters.AddWithValue("Ho", txtHo.Text);
                    command.Parameters.AddWithValue("Ten", txtTen.Text);
                    command.Parameters.AddWithValue("GioiTinh", cboGioiTinh.Text);
                    command.Parameters.AddWithValue("SDT", txtSDT.Text);
                    command.Parameters.AddWithValue("CMND", txtCMND.Text);
                    command.Parameters.AddWithValue("DiaChi", txtDiaChi.Text);
                    command.Parameters.AddWithValue("Tien", txtmoney.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show(" Xóa Thành Công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    hienthi();
                    ketnoi.Close();
                }
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
                Error.Clear();
            if (txtSearchmathe.Text == "")
            {
                MessageBox.Show("Bạn Chưa nhập MaThẻ vào ô tìm kiếm ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Error.SetError(txtSearchmathe, "Bạn Chưa nhập MaThẻ vào ô tìm kiếm ");
                txtSearchmathe.Focus();
            }
            else
            {
                ketnoi.Open();
                SqlCommand cmdtk = new SqlCommand("select MaThe from KhachHang where MaThe='" + txtSearchmathe.Text + "'", ketnoi);
                SqlDataReader data = cmdtk.ExecuteReader();
                if (data.Read() != true)
                {
                    MessageBox.Show("Không tìm thấy mả thẻ ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Error.SetError(txtSearchmathe, "Bạn Chưa nhập MaThẻ vào ô tìm kiếm ");
                    txtSearchmathe.Focus();
                    data.Close();
                    data.Dispose();
                    ketnoi.Close();
                }
                else
                {
                    data.Close();
                    data.Dispose();
                    ketnoi.Close();
                    if (txtSearchmathe.Text == "")
                    {
                        MessageBox.Show(" Bạn Chưa Nhập Ô Tìm Kiếm ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Error.SetError(txtSearchmathe, "Bạn Chưa nhập MaThẻ vào ô tìm kiếm ");
                        txtSearchmathe.Focus();
                    }
                    else
                    {
                        ketnoi.Open();
                        SqlCommand command = new SqlCommand("select MaQuyen from KhachHang where MaThe='" + txtSearchmathe.Text + "'", ketnoi);
                        cboQuyen.Text = (string)command.ExecuteScalar().ToString();
                        SqlCommand command1 = new SqlCommand("select TenDangNhap from KhachHang where MaThe='" + txtSearchmathe.Text + "'", ketnoi);
                        string tendangnhap = (string)command1.ExecuteScalar();
                        SqlCommand command2 = new SqlCommand("select MatKhau from KhachHang where MaThe='" + txtSearchmathe.Text + "'", ketnoi);
                        string mk = (string)command2.ExecuteScalar();
                        SqlCommand command3 = new SqlCommand("select Ho from KhachHang where MaThe='" + txtSearchmathe.Text + "'", ketnoi);
                        string ho = (string)command3.ExecuteScalar();
                        SqlCommand command4 = new SqlCommand("select Ten from KhachHang where MaThe='" + txtSearchmathe.Text + "'", ketnoi);
                        string ten = (string)command4.ExecuteScalar();
                        SqlCommand command5 = new SqlCommand("select GioiTinh from KhachHang where MaThe='" + txtSearchmathe.Text + "'", ketnoi);
                        string gioitinh = (string)command5.ExecuteScalar();
                        SqlCommand command6 = new SqlCommand("select SDT from KhachHang where MaThe='" + txtSearchmathe.Text + "'", ketnoi);
                        string sdt = (string)command6.ExecuteScalar();
                        SqlCommand command7 = new SqlCommand("select CMND from KhachHang where MaThe='" + txtSearchmathe.Text + "'", ketnoi);
                        string cmnd = (string)command7.ExecuteScalar();
                        SqlCommand command8 = new SqlCommand("select DiaChi from KhachHang where MaThe='" + txtSearchmathe.Text + "'", ketnoi);
                        string diachi = (string)command8.ExecuteScalar();
                        SqlCommand command9 = new SqlCommand("select Tien from KhachHang where MaThe='" + txtSearchmathe.Text + "'", ketnoi);
                        Int64 tien = Convert.ToInt64(command9.ExecuteScalar());
                        SqlCommand command10 = new SqlCommand("select NgaySinh from KhachHang where MaThe='" + txtSearchmathe.Text + "'", ketnoi);
                        txtNgaySinh.Text = command10.ExecuteScalar().ToString();

                        //gán giá tri ra các textbox
                       // cboQuyen.Text = maquyen.ToString();
                        txtuser.Text = tendangnhap.ToString();
                        txtpasswork.Text = mk.ToString();
                        txtHo.Text = ho.ToString();
                        txtTen.Text = ten.ToString();
                        cboGioiTinh.Text = gioitinh.ToString();
                        txtSDT.Text = sdt.ToString();
                        txtCMND.Text = cmnd.ToString();
                        txtDiaChi.Text = diachi.ToString();
                        txtmoney.Text = tien.ToString();
                        txtagainpasswork.Text = mk.ToString();
                        // cap nhap a
                        string tk = "select *from KhachHang where MaThe=@MaThe";
                        SqlCommand command0 = new SqlCommand(tk, ketnoi);
                        command0.Parameters.AddWithValue("MaThe", txtSearchmathe.Text);
                        command0.Parameters.AddWithValue("MaQuyen", cboQuyen.Text);
                        command0.Parameters.AddWithValue("TenDangNhap", txtuser.Text);
                        command0.Parameters.AddWithValue("MatKhau", txtpasswork.Text);
                        command0.Parameters.AddWithValue("Ho", txtHo.Text);
                        command0.Parameters.AddWithValue("Ten", txtTen.Text);
                        command0.Parameters.AddWithValue("GioiTinh", cboGioiTinh.Text);
                        command0.Parameters.AddWithValue("SDT", txtSDT.Text);
                        command0.Parameters.AddWithValue("CMND", txtCMND.Text);
                        command0.Parameters.AddWithValue("DiaChi", txtDiaChi.Text);
                        command0.Parameters.AddWithValue("Tien", txtmoney.Text);
                        command0.ExecuteNonQuery();

                        SqlDataReader dr = command0.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        dataDanhSach.DataSource = dt;
                        ketnoi.Close();
                    }
                }
            }
        }
        private bool kiemtrataikhoantontai()
        {
            bool kt = false;
            string tdn = txtuser.Text;
            SqlDataAdapter da_kt = new SqlDataAdapter("Select * from KhachHang where TenDangNhap='" + tdn + "'", ketnoi);
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

        private void Clear_Click(object sender, EventArgs e)
        {
            Error.Clear();
            if (txtuser.Text == "" && txtpasswork.Text == "" && txtHo.Text == "" && txtTen.Text == "" && cboGioiTinh.Text == "" &&
                txtSDT.Text == "" && txtDiaChi.Text == "" && cboQuyen.Text == "" && txtagainpasswork.Text == "" && txtCMND.Text == "")
            {
                MessageBox.Show(" Du Lieu ban dang trống ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ketnoi.Open();
                txtCMND.Text = null;
                txtagainpasswork.Text = null;
                txtDiaChi.Text = null;
                txtHo.Text = null;
                txtmoney.Text = "100000";
                txtNgaySinh.Text = null;
                txtpasswork.Text = null;
                txtSDT.Text = null;
                txtSearchmathe.Text = null;
                txtTen.Text = null;
                txtuser.Text = null;
                cboGioiTinh.Text = null;
                cboQuyen.Text = null;

                hienthi();
                ketnoi.Close();

            }
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {

            if (keyData == Keys.Escape)
                this.Close();
            return base.ProcessDialogKey(keyData);
        }

        private void txtSearchmathe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtmoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        // ktra ký tự dat biệt
        string chuoidung = "1234567890 qwertyuiopasdfghjklzxcvbnm QWERTYUIOPASDFGHJKLZXCVBNM - _ ÁÀẢẠÃ ĂẴẰẲẮẶ ÂẨẦẤẪẬ ÊỀẾỆỂỄ ÚÙỦỤŨU ỨƯỪỰỬỮ ÍÌỊỈĨ ÝỲỶỴỸ ÓÒỎÕỌ ỘỒÔỐỔỖ ƠỜỚỞỢỠ ÉÈẺẸẼ áàảạã ăắằẳẵặ âấầẩẫậ êềễểếệ ùúủũụ ưứừửựữ ìíỉịĩ òóỏõọ ôốồỗộổ ờởớỡợơ yýỳỷỹỵ éèẻẹẽ ,. Đđ ";//Các kí tự đang nhập
        private bool kiemtrakitu(string chuoiCanKiemTra)
        {
            foreach (char kiTu in chuoiCanKiemTra)
            {
                bool dung = false;

                foreach (char kitu2 in chuoidung)
                {
                    if (kiTu == kitu2) dung = true;
                }
                if (dung == false) return false;
            }
            return true;
        }
        string chuoidangnhap = "1234567890_qwertypuioasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM@.";///DUNG CHO DANG TÊN ĐĂNG NHAP VÀ PASSWORK
        private bool kiemtrauerpass(string chuoiCanKiemTra)
        {
            foreach (char kiTu in chuoiCanKiemTra)
            {
                bool dung = false;

                foreach (char kitu2 in chuoidangnhap)
                {
                    if (kiTu == kitu2) dung = true;
                }
                if (dung == false) return false;
            }
            return true;
        }
        //double click vô dataGridView se hiện hết thông tin
        private void dataDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSearchmathe.Text = dataDanhSach.CurrentRow.Cells[0].Value.ToString();
            cboQuyen.Text = dataDanhSach.CurrentRow.Cells[11].Value.ToString();
            txtuser.Text = dataDanhSach.CurrentRow.Cells[8].Value.ToString();
            txtpasswork.Text = dataDanhSach.CurrentRow.Cells[9].Value.ToString();
            txtHo.Text = dataDanhSach.CurrentRow.Cells[1].Value.ToString();
            txtTen.Text = dataDanhSach.CurrentRow.Cells[2].Value.ToString();
            txtNgaySinh.Text = dataDanhSach.CurrentRow.Cells[4].Value.ToString();
            cboGioiTinh.Text = dataDanhSach.CurrentRow.Cells[3].Value.ToString();
            txtSDT.Text = dataDanhSach.CurrentRow.Cells[5].Value.ToString();
            txtCMND.Text = dataDanhSach.CurrentRow.Cells[6].Value.ToString();
            txtmoney.Text = dataDanhSach.CurrentRow.Cells[10].Value.ToString();
            txtDiaChi.Text = dataDanhSach.CurrentRow.Cells[7].Value.ToString();
            txtagainpasswork.Text = dataDanhSach.CurrentRow.Cells[9].Value.ToString();
        }

        private void btprint_Click(object sender, EventArgs e)
        {
            Print.Export2Excel(dataDanhSach);
        }        
    }

}
