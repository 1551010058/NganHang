using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace NganHang
{
    public class DungChung
    {
        SqlConnection ketnoi = new SqlConnection(@"Server = .;Database =NganHang1;Integrated Security=True");
        public DungChung() { }
        public bool KiemTra_Rong(string rong)
        {
            if (rong != "")
                return true;
            return false;
        }
        public bool kiemtratontai(string chuoikiemtra)
        {
            bool kt = false;
            string tdn = chuoikiemtra;
            ketnoi.Open();
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
        public bool kiemtrasdttontai(string chuoikiemtra)
        {
           
            string tdn = chuoikiemtra;
            bool kt = false;
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
        public bool kiemtracmndtontai(string chuoikiemtra)
        {
            bool kt = false;
            string tdn = chuoikiemtra;
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
        string chuoidangnhap = "1234567890_qwertyuioasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM@.";///DUNG CHO DANG TÊN ĐĂNG NHAP VÀ PASSWORK
        public bool kiemtrauerpass(string chuoiCanKiemTra)
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
        // Hàm Ktra ký tự đặt biệt 
        string chuoidung = "1234567890_QWERTYUIOPASDFGHJKLZXCVBNM qwertyuiopasdĐđ ÁÀẢẠÃ ĂẴẰẲẮẶ ÂẨẦẤẪẬ ÊỀẾỆỂỄ ÚÙỦỤŨU ÚƯỪỰỬỮ ÍÌỊỈIÌ ÝỲYỶỴỸ ÓÒOỎÕỌ ỘỒÔỐỔỖ ƠỜÓỞỢỠ ÉEÈẺẸẼ  fghjklzxcvbnm áàảạã ăắằẳẵặ âấầẩẫậ êềễểếệ ùúủũụ ưứừửựữ ìíỉịĩ òóỏõọ ôốồỗộổ ờởớỡợơ yýỳỷỹỵ éèẻẹẽ -,.";//Các kí tự đang nhập
        public bool kiemtrakitu(string chuoiCanKiemTra)
        {
            foreach (char kiTu in chuoiCanKiemTra)
            {
                bool dung = false;

                foreach (char kitu2 in chuoidung)
                {
                    if (kiTu == kitu2)
                        dung = true;
                }
                if (dung == false) return false;
            }
            return true;
        }
        public bool SDT(string sdt)
        {
            if ((sdt.Length < 10 || sdt.Length > 11))
                return false;
            return true;
        }
        public bool CMND(string cmnd)
        {
            if((cmnd.Length < 9 || cmnd.Length > 9) && (cmnd.Length < 12 || cmnd.Length > 12))
                return false;
            return true;
        }
        public bool MatKhau(string matkhau)
        {
            if (matkhau.Length < 6 || matkhau.Length >= 20)
                return false;
            return true;
        }
        public bool kiemtratrongchuoi(string chuoi)
        {
            string []a = chuoi.Split();
            for(int i=0;i <chuoi.Length;i++)
            {
                if (a[i] == "")
                    return true;
            }
            return false;
        }

        
    }
}
