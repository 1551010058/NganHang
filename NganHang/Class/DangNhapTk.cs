using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace NganHang
{
    public class DangNhapTk
    {
        SqlConnection ketnoi = new SqlConnection(@"Server = .;Database =NganHang1;Integrated Security=True");
        public static string user = "", user1 = " ", user2 = " ", user3 = " ", user4 = " ", user5 = " ";
        public static SqlCommand cmd;
        public static SqlDataReader dta;
        private string id;
        public DangNhapTk()
        {

        }
        public DangNhapTk(string id)
        {
            this.id = id;
        }
 
        public string getID()
        {
            return id;
        }

        public bool getDoDaiID()
        {
            if (id.Length > 20)
                return false;
            else
                return true;
        }
        public bool kiemtraUser(string user)
        {
            if (user == null || user == "")
                return false;
            return true;
        }
        public bool User(string user,string pass)
        {
            bool kt;
            ketnoi.Open();
            string sql = "select *from KhachHang where TenDangNhap= @TK  and MatKhau=@MK";
            cmd = new SqlCommand(sql,ketnoi);
            if(kiemtraUser(user)==true)
            {
                cmd.Parameters.Add(new SqlParameter("TK", user));
                cmd.Parameters.Add(new SqlParameter("MK", pass));
                return kt = true;
            }
            return kt = true;
            
        }
    }
}
