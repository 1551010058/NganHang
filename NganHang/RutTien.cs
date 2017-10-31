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
    public partial class RutTien : Form
    {
        SqlConnection ketnoi = new SqlConnection(@"Data Source=DESKTOP-FPNJFC5;Initial Catalog=NganHang;Integrated Security=True");
        public static string user4 = "";
        public RutTien()
        {
            InitializeComponent();
        }
        int mathe, tien, tienrut, tongtien = 0;
        string mk;
        private void RutTien_Load(object sender, EventArgs e)
        {
            ketnoi.Open();
            SqlCommand command = new SqlCommand("select MaThe from KhachHang where TenDangNhap='" + user4 + "'", ketnoi);
            mathe = (int)command.ExecuteScalar();
            SqlCommand command5 = new SqlCommand("select Tien from KhachHang where TenDangNhap='" + user4 + "'", ketnoi);
            tien = (int)command5.ExecuteScalar();
            SqlCommand command2 = new SqlCommand("select MatKhau from KhachHang where TenDangNhap='" + user4 + "'", ketnoi);
            mk = (string)command2.ExecuteScalar();
            MaThe.Text = mathe.ToString();
            SoDu.Text = tien.ToString();
        }

        private void btRut_Click(object sender, EventArgs e)
        {
            try
            {
                tienrut = int.Parse(TienRut.Text);
                tongtien = tien - tienrut;
                if (tienrut > tien)
                {
                    MessageBox.Show(" Tiền Của Bạn Không Đủ ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    if (tienrut < 0)
                    MessageBox.Show(" Nhập Sai ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (tienrut > 10000000)
                {
                    MessageBox.Show(" Một lần bạn chỉ Rút tối đa được 10 triệu ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    if (matkhauxacnhan.Text == mk)
                {
                    string update = "UPDATE KhachHang SET Tien='" + tongtien + "'WHERE MaThe='" + mathe + "'";
                    SqlCommand command = new SqlCommand(update, ketnoi);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Rút Tiền Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SqlCommand command5 = new SqlCommand("select Tien from KhachHang where TenDangNhap='" + user4 + "'", ketnoi);
                    tien = (int)command5.ExecuteScalar();
                    SoDu.Text = tien.ToString();
                }
                else
                    MessageBox.Show(" Rút Tiền Không Thành Công ", "Mật Khẩu Sai ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show(" Bạn Nhập Sai ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TienRut.Focus();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Escape)
                this.Close();
            return base.ProcessDialogKey(keyData);
        }
    }
}
