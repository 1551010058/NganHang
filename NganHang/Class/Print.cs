using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using ms=Microsoft.Office.Interop.Excel;

namespace NganHang
{
    class Print
    {
       
        public static void Export2Excel(DataGridView dgr)
        {
            // khởi tạo Excel
            ms._Application app = new Microsoft.Office.Interop.Excel.Application();
          
            //khởi tao WorkBook
            ms._Workbook wb = app.Workbooks.Add(Type.Missing);
            //Khoi tạo WorkSheet
            ms._Worksheet ws=(ms._Worksheet)app.ActiveSheet;
            app.Visible=true;
           
            //Đỗ Dữ Liệu vào
            ws.Cells[2, 1] = "STT";
            ws.Cells[2, 2] = "Mã Thẻ";
            ws.Cells[2, 3] = "Họ";
            ws.Cells[2, 4] = "Tên";
            ws.Cells[2, 5] = "Giới Tính";
            ws.Cells[2, 6] = "Ngày Sinh";
            ws.Cells[2, 7] = "SĐT";
            ws.Cells[2, 8] = "CMND";
            ws.Cells[2, 9] = "Địa Chỉ";
            ws.Cells[2, 10] = "Tên Đăng Nhập";
            ws.Cells[2, 11] = "Mật Khuẩu";
            ws.Cells[2, 12] = "Tiền";
            ws.Cells[2, 13] = "Mã Quền";
            for (int i = 0; i < dgr.Rows.Count - 1; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                   //// if (dgr.Rows[i].Cells[j] != null)
                   // {
                        ws.Cells[i + 3, 1] = i + 1;
                        ws.Cells[i + 3, j + 2] = dgr.Rows[i].Cells[j].Value;
                   // }
                }
            }
        }

        private SqlConnection Connected()
        {
            throw new NotImplementedException();
        }
    }
}
