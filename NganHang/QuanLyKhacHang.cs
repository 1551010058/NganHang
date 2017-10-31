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
        SqlConnection ketnoi = new SqlConnection(@"Data Source=DESKTOP-FPNJFC5;Initial Catalog=NganHang;Integrated Security=True");
        public QuanLyKhacHang()
        {
            InitializeComponent();
        }
        private void QuanLyKhacHang_Load(object sender, EventArgs e)
        {
            ketnoi.Open();
            hienthi();
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

            String[] arrDangKy = txtuser.Text.Split(' ');
            String[] arrSDT = txtSDT.Text.Split(' ');
            String[] arrcmnd = txtCMND.Text.Split(' ');
            if (kiemtrakitu(txtHo.Text) == false) { MessageBox.Show("có kí tự đặc biệt"); return; }
            else
                if (arrDangKy.Count() > 1 || arrSDT.Count() > 1 || arrcmnd.Count() > 1)
            {
                MessageBox.Show(" Khong được có khoảng trống ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                    if (kiemtrataikhoantontai() == true && kiemtrasdttontai() == true && kiemtraCMNDtontai() == true)
            {
                Loi4.Text = " * ";
                Loi7.Text = " * ";
                Loi5.Text = " * ";
            }
            else if (kiemtrataikhoantontai() == true && kiemtrasdttontai() == true)
            {
                Loi5.Text = null;
                Loi4.Text = " * ";
                Loi7.Text = " * ";
            }
            else if (kiemtrataikhoantontai() == true && kiemtraCMNDtontai() == true)
            {
                Loi4.Text = null;
                Loi7.Text = " * ";
                Loi5.Text = " * ";
            }
            else if (kiemtraCMNDtontai() == true && kiemtraCMNDtontai() == true)
            {
                Loi7.Text = null;
                Loi4.Text = " * ";
                Loi5.Text = " * ";
            }
            else if (kiemtrataikhoantontai() == true)
            {
                Loi4.Text = null;
                Loi5.Text = null;
                Loi7.Text = " * ";
            }
            else if (kiemtrasdttontai() == true)
            {
                Loi7.Text = null;
                Loi5.Text = null;
                Loi4.Text = " * ";
            }
            else if (kiemtraCMNDtontai() == true)
            {
                Loi4.Text = null;
                Loi5.Text = " * ";
                Loi7.Text = null;
            }
            else if (kiemtrakitu(txtuser.Text) == false)
            {
                MessageBox.Show(" Có Ký tự đặt biệt ở Tên Đăng Nhập ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtuser.Focus();
            }
            else if (kiemtrakitu(txtpasswork.Text) == false)
            {
                MessageBox.Show(" Có Ký tự đặt biệt ở Mật Khẩu ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtpasswork.Focus();
            }
            else if (kiemtrakitu(txtHo.Text) == false)
            {
                MessageBox.Show(" Có Ký tự đặt biệt ở Họ ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHo.Focus();
            }
            else if (kiemtrakitu(txtTen.Text) == false)
            {
                MessageBox.Show(" Có Ký tự đặt biệt ở Ten ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTen.Focus();
            }
            else if (kiemtrakitu(txtDiaChi.Text) == false)
            {
                MessageBox.Show(" Có Ký tự đặt biệt ở Địa Chỉ ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
            }
            else if (txtuser.Text == "" || txtpasswork.Text == "" || txtHo.Text == "" || txtTen.Text == "" || cboGioiTinh.Text == "" ||
                txtSDT.Text == "" || txtDiaChi.Text == "" || cboQuyen.Text == "" || txtagainpasswork.Text == "" || txtCMND.Text == "")
            {
                MessageBox.Show(" Bạn Chưa Nhập Dử Liệu ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtpasswork.Text != txtagainpasswork.Text)
            {
                MessageBox.Show("  Nhập lai mật khẩu không đúng ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if ((txtSDT.Text.Length < 10 || txtSDT.Text.Length > 11))
            {
                MessageBox.Show(" Số Điện Thoại phải nằm trong khoảng 10 đên 11 số ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if ((txtCMND.Text.Length < 9 || txtCMND.Text.Length > 9) && (txtCMND.Text.Length < 12 || txtCMND.Text.Length > 12))
            {
                MessageBox.Show(" CMND phải 9 số và 12 số ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtpasswork.Text.Length < 6 || txtpasswork.Text.Length >= 20)
            {
                MessageBox.Show(" Mật khẩu từ 6 ký tự trở lên ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ketnoi.Open();
                string nhap = "Insert Into KhachHang(MaQuyen,TenDangNhap,MatKhau,Ho,Ten,NgaySinh,GioiTinh,SDT,CMND,DiaChi,Tien)" + "Values ('" + cboQuyen.Text + "',N'" + txtuser.Text + "',N'" + txtpasswork.Text + "',N'" + txtHo.Text + "',N'" + txtTen.Text + "',N'" + txtNgaySinh.Text + "',N'" + cboGioiTinh.Text + "',N'" + txtSDT.Text + "',N'" + txtCMND.Text + "',N'" + txtDiaChi.Text + "',N'" + txtmoney.Text + "')";
                SqlCommand command = new SqlCommand(nhap, ketnoi);
                command.ExecuteNonQuery();
                MessageBox.Show(" Bạn Thêm Thành Công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Loi4.Text = null;
                Loi7.Text = null;
                Loi5.Text = null;
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
            String[] arrDangKy = txtuser.Text.Split(' ');
            String[] arrSDT = txtSDT.Text.Split(' ');
            if (arrDangKy.Count() > 1 || arrSDT.Count() > 1)
            {
                MessageBox.Show(" Khong được có khoảng trống ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                if (txtuser.Text == "" || txtpasswork.Text == "" || txtHo.Text == "" || txtTen.Text == "" || cboGioiTinh.Text == "" ||
                   txtSDT.Text == "" || txtDiaChi.Text == "" || cboQuyen.Text == "" || txtagainpasswork.Text == "" || txtCMND.Text == "")
            {
                MessageBox.Show(" Bạn Chưa Nhập Dử Liệu ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtpasswork.Text != txtagainpasswork.Text)
            {
                MessageBox.Show("  Nhập lai mật khẩu không đúng ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (kiemtrakitu(txtuser.Text) == false)
            {
                MessageBox.Show(" Có Ký tự đặt biệt ở Tên Đăng Nhập ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtuser.Focus();
            }
            else if (kiemtrakitu(txtpasswork.Text) == false)
            {
                MessageBox.Show(" Có Ký tự đặt biệt ở Mật Khẩu ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtpasswork.Focus();
            }
            else if (kiemtrakitu(txtHo.Text) == false)
            {
                MessageBox.Show(" Có Ký tự đặt biệt ở Họ ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHo.Focus();
            }
            else if (kiemtrakitu(txtTen.Text) == false)
            {
                MessageBox.Show(" Có Ký tự đặt biệt ở Ten ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTen.Focus();
            }
            else if (kiemtrakitu(txtDiaChi.Text) == false)
            {
                MessageBox.Show(" Có Ký tự đặt biệt ở Địa Chỉ ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
            }
            else if ((txtSDT.Text.Length < 10 || txtSDT.Text.Length > 11))
            {
                MessageBox.Show(" Số Điện Thoại phải nằm trong khoảng 10 đên 11 số ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if ((txtCMND.Text.Length < 9 || txtCMND.Text.Length > 9) && (txtCMND.Text.Length < 12 || txtCMND.Text.Length > 12))
            {
                MessageBox.Show(" CMND phải 9 số và 12 số ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
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
                command.Parameters.AddWithValue("Tien", txtmoney.Text);
                command.Parameters.AddWithValue("NgaySinh", txtNgaySinh.Text);
                command.ExecuteNonQuery();
                MessageBox.Show(" Bạn Sửa Thành Công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                hienthi();
                ketnoi.Close();
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                MessageBox.Show(" Bạn Chưa tên user muốn xóa ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtuser.Focus();
            }
            else
            {
                ketnoi.Open();
                SqlCommand cmdtk = new SqlCommand("select TenDangNhap from KhachHang where MaThe='" + txtSearchmathe.Text + "'", ketnoi);
                SqlDataReader data = cmdtk.ExecuteReader();
                if (data.Read() != true)
                {
                    MessageBox.Show("Không tìm thấy tên đăng nhập ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    data.Close();
                    data.Dispose();
                    ketnoi.Close();
                }
                else
                {
                    data.Close();
                    data.Dispose();
                    ketnoi.Close();

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
            if (txtSearchmathe.Text == "")
            {
                MessageBox.Show("Bạn Chưa nhập MaThẻ vào ô tìm kiếm ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    }
                    else
                    {
                        ketnoi.Open();
                        SqlCommand command = new SqlCommand("select MaQuyen from KhachHang where MaThe='" + txtSearchmathe.Text + "'", ketnoi);
                        string maquyen = (string)command.ExecuteScalar();
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
                        int tien = (int)command9.ExecuteScalar();
                        SqlCommand command10 = new SqlCommand("select NgaySinh from KhachHang where MaThe='" + txtSearchmathe.Text + "'", ketnoi);
                        txtNgaySinh.Text = command10.ExecuteScalar().ToString();

                        //gán giá tri ra các textbox
                        cboQuyen.Text = maquyen.ToString();
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

        string chuoidung = "1234567890_QWERTYUIOPASDFGHJKLZXCVBNM qwertyuiopasdĐđ ÁÀẢẠÃ ĂẴẰẲẮẶ ÂẨẦẤẪẬ ÊỀẾỆỂỄ ÚÙỦỤŨU ÚƯỪỰỬỮ ÍÌỊỈIÌ ÝỲYỶỴỸ ÓÒOỎÕỌ ỘỒÔỐỔỖ ƠỜÓỞỢỠ ÉEÈẺẸẼ  fghjklzxcvbnm áàảạã ăắằẳẵặ âấầẩẫậ êềễểếệ ùúủũụ ưứừửựữ ìíỉịĩ òóỏõọ ôốồỗộổ ờởớỡợơ yýỳỷỹỵ éèẻẹẽ -,.";//Các kí tự đang nhập

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
    }
}
