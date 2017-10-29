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
    public partial class GuiTien : Form
    {
        SqlConnection ketnoi = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Vipper\Desktop\NganHang\Database\NganHang.mdf;Integrated Security=True;Connect Timeout=30");
        public static string user2 = "";
        int tien, tongtien = 0, tiengui = 0;
        string mk;
        public GuiTien()
        {
            InitializeComponent();
        }
        int mathe;

        private void btGui_Click(object sender, EventArgs e)
        {
            try
            {
                tiengui = int.Parse(TienGui.Text);
                tongtien = tien + tiengui;
                if (matkhauxacnhan.Text == mk)
                {
                    string update = "UPDATE KhachHang SET Tien='" + tongtien + "'WHERE MaThe='" + mathe + "'";

                    SqlCommand command = new SqlCommand(update, ketnoi);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Gửi Tiền Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TienGui.Enabled = false;
                    matkhauxacnhan.Enabled = false;
                }
                else
                    MessageBox.Show(" Gửi Tiền Không Thành Công ", "Mật Khẩu Sai ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show(" Chưa Nhập Thông Tin ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GuiTien_Load(object sender, EventArgs e)
        {
            ketnoi.Open();
            SqlCommand command = new SqlCommand("select MaThe from KhachHang where TenDangNhap='" + user2 + "'", ketnoi);
            mathe = (int)command.ExecuteScalar();
            SqlCommand command1 = new SqlCommand("select Tien from KhachHang where TenDangNhap='" + user2 + "'", ketnoi);
            tien = (int)command1.ExecuteScalar();
            SqlCommand command2 = new SqlCommand("select MatKhau from KhachHang where TenDangNhap='" + user2 + "'", ketnoi);
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
