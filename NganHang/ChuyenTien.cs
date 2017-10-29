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
    public partial class ChuyenTien : Form
    {
        SqlConnection ketnoi = new SqlConnection(@"Data Source=DESKTOP-FPNJFC5;Initial Catalog=NganHang;Integrated Security=True");
        public static string user3 = "";
        int tienbengui, tongtienbennhan = 0, tienchuyen = 0, tongtienbengui = 0;
        int thegui;
        string mk;
        int mathe;

        private void btChuyenTien_Click(object sender, EventArgs e)
        {
            try
            {
                tienchuyen = int.Parse(SoTienChuyen.Text);
                thegui = int.Parse(MaTheGui.Text);
                SqlCommand command0 = new SqlCommand("select MaThe from KhachHang where MaThe='" + thegui + "'", ketnoi);
                SqlDataReader dta = command0.ExecuteReader();
                if (dta.Read() != true)
                {
                    MessageBox.Show("Không tìm thấy mả thẻ ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dta.Close();
                    dta.Dispose();
                }
                else
                {
                    dta.Close();
                    dta.Dispose();
                    //ketnoi.Open();
                    SqlCommand command = new SqlCommand("select Tien from KhachHang where MaThe='" + thegui + "'", ketnoi);
                    int tienbennhan = (int)command.ExecuteScalar();
                    tongtienbennhan = tienbennhan + tienchuyen;// Cong Tien ben nhận
                    tongtienbengui = tienbengui - tienchuyen;//Trừ Tiền bên gửi
                    if (tienchuyen > tienbengui)
                    {
                        MessageBox.Show("Số Dư Của Bạn Không Đủ ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        if (tienchuyen < 0)
                        MessageBox.Show("Bạn Nhập Sai ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                            if (matkhauxacnhan.Text == mk)
                    {
                        string update = "UPDATE KhachHang SET Tien='" + tongtienbengui + "'WHERE MaThe='" + mathe + "'";
                        SqlCommand command1 = new SqlCommand(update, ketnoi);
                        command1.ExecuteNonQuery();
                        string update1 = "UPDATE KhachHang SET Tien='" + tongtienbennhan + "'WHERE MaThe='" + thegui + "'";
                        SqlCommand command2 = new SqlCommand(update1, ketnoi);
                        command2.ExecuteNonQuery();
                        MessageBox.Show("Đã Chuyển Tiền Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                        MessageBox.Show(" Đã Chuyển không Thành Công ", "Mật Khẩu Sai ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(" Nhập Sai ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public ChuyenTien()
        {
            InitializeComponent();
        }
        private void ChuyenTien_Load(object sender, EventArgs e)
        {
            ketnoi.Open();
            SqlCommand command = new SqlCommand("select MaThe from KhachHang where TenDangNhap='" + user3 + "'", ketnoi);
            mathe = (int)command.ExecuteScalar();
            SqlCommand command1 = new SqlCommand("select Tien from KhachHang where TenDangNhap='" + user3 + "'", ketnoi);
            tienbengui = (int)command1.ExecuteScalar();
            SqlCommand command2 = new SqlCommand("select MatKhau from KhachHang where TenDangNhap='" + user3 + "'", ketnoi);
            mk = (string)command2.ExecuteScalar();
            MaThe.Text = mathe.ToString();
        }

       
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Escape)
                this.Close();
            return base.ProcessDialogKey(keyData);
        }
    }
}
