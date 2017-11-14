using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NganHang
{
    public class ClassTien
    {
        public ClassTien() { }
        public bool TienGui(string tien)
        {
            if (Convert.ToInt64(tien) > 2000000000)
                return false;
            return true;
        }
        public bool Tienrut1(Int64 tien)
        {
            if (tien < 0)
                return false;
            return true;
        }
        public bool Tienrut2(Int64 tien)
        {
            if (tien > 100000000)
                return false;
            return true;
        }
    }
}
