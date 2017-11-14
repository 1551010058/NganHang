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
    public partial class DoiMaPin : Form
    {
        SqlConnection ketnoi = new SqlConnection(@"Server = .;Database =NganHang1;Integrated Security=True");
        public static string user5 = "";
        public DoiMaPin()
        {
            InitializeComponent();
        }


        string mk;
        private void DoiMaPin_Load(object sender, EventArgs e)
        {
       
        }
        DungChung DC = new DungChung();
        private void doi()
        {
            String[] arrmk = txtPinmoi.Text.Split(' ');
            if (DC.KiemTra_Rong(txtNhaplaipn.Text) == false && DC.KiemTra_Rong(txtPin.Text)==false && DC.KiemTra_Rong(txtPinmoi.Text)==false)
            {
                label5.Text = " Bạn đã nhập sai mật khẩu củ ";
                label6.Text = " Bạn không thể để mật khẩu trống ";
                label7.Text = " Mật khẩu không khớp";
            }
            else if (DC.KiemTra_Rong(txtNhaplaipn.Text) ==false && DC.KiemTra_Rong(txtPin.Text) == false)
            {
                label6.Text = "";
                label7.Text = " Mật khẩu không khớp";
                label5.Text = " Bạn đã nhập sai mật khẩu củ ";
            }
            else if(DC.KiemTra_Rong(txtPin.Text)==false && DC.KiemTra_Rong(txtPinmoi.Text)==false)
            {
                label7.Text = "";
                label5.Text = " Bạn đã nhập sai mật khẩu củ ";
                label6.Text = " Bạn không thể để mật khẩu trống ";
            }  
            else if(DC.KiemTra_Rong(txtNhaplaipn.Text) == false && DC.KiemTra_Rong(txtPinmoi.Text)==false)
            {
                label5.Text = "";
                label6.Text = " Bạn không thể để mật khẩu trống ";
                label7.Text = " Mật khẩu không khớp";
            }           
            else if(DC.KiemTra_Rong(txtPin.Text)==false)
            {
                label6.Text = "";
                label7.Text = "";
                label5.Text = " Bạn đã nhập sai mật khẩu củ ";
            }
            else if (DC.KiemTra_Rong(txtPinmoi.Text) == false)
            {
                label5.Text = "";
                label7.Text = "";
                label6.Text = " Bạn không thể để mật khẩu trống ";
            }
            else if (DC.KiemTra_Rong(txtNhaplaipn.Text) == false)
            {
                label6.Text = "";
                label5.Text = "";
                label7.Text = " Mật khẩu không khớp";
            }
            else if (txtPin.Text != mk)
            {
                label5.Text = " Bạn đã nhập sai mật khẩu củ ";
            }
            else if (DC.MatKhau(txtPinmoi.Text)==false)
            {
                label6.Text = " Mật khẩu từ 6 ký tự trở lên";
            }
            else if (arrmk.Count() > 1)
            {
                label6.Text = " Mật Khẩu không hợp lệ";
            }
            else if (txtPinmoi.Text != txtNhaplaipn.Text)
            {
                label7.Text = " Mật khẩu không khớp";
            }
            else
            {
                label5.Text = "";
                label6.Text = "";
                label7.Text = "";
                string update = "Update KhachHang Set MatKhau=@MatKhau where TenDangNhap=@TenDangNhap";
                SqlCommand command1 = new SqlCommand(update, ketnoi);
                command1.Parameters.AddWithValue("MatKhau", txtPinmoi.Text);
                command1.Parameters.AddWithValue("TenDangNhap", user5);
                command1.ExecuteNonQuery();
                MessageBox.Show(" Bạn Thay doi mật khau thành công ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                btLuu.Enabled = false;
            }
                                 



        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            SqlCommand command = new SqlCommand("select MatKhau from KhachHang where TenDangNhap='" + user5 + "'", ketnoi);
            mk = (string)command.ExecuteScalar();
            
            doi();
            ketnoi.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
