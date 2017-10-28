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
       
        public QuanLyKhacHang()
        {
            InitializeComponent();
        }
        private void QuanLyKhacHang_Load(object sender, EventArgs e)
        {

        }
 
        protected override bool ProcessDialogKey(Keys keyData)
        {
            
            if (keyData == Keys.Escape)
                this.Close();
            return base.ProcessDialogKey(keyData);
        }

        

    }
}
