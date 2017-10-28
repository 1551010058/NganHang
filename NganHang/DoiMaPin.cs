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
        SqlConnection ketnoi = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Vipper\Desktop\NganHang\Database\NganHang.mdf;Integrated Security=True;Connect Timeout=30");
        public static string user5 = "";
        public DoiMaPin()
        {
            InitializeComponent();
        }


      
        private void DoiMaPin_Load(object sender, EventArgs e)
        {
       
        }
       

        
    }
}
