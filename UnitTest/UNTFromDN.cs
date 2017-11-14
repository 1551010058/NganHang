using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NganHang;

namespace UnitTest
{
    [TestClass]
    public class UNTFromDN
    {
        [TestMethod]
        public void TestID_DangNhap()
        {
            DangNhapTk tk1 = new DangNhapTk("linhmai");
            DangNhapTk tk2 = new DangNhapTk(null);
            DangNhapTk tk3 = new DangNhapTk("");
            Assert.AreEqual("linhmai", tk1.getID());
            Assert.AreEqual(null, tk2.getID());
            Assert.AreEqual("",tk3.getID());   
        }
        [TestMethod]
        public void TestDoDaiID()
        {
            DangNhapTk tk4 = new DangNhapTk("qw1111111111111111111111111111111111111111111");
            Assert.AreEqual(false, tk4.getDoDaiID());

            DangNhapTk tk5 = new DangNhapTk("qwerty");
            Assert.AreEqual(true, tk5.getDoDaiID());
        }
        [TestMethod]
        public void Kiem_tra_Dang_Nhap()
        {
            
            //Đúng giá trị
            DangNhapTk tk5 = new DangNhapTk();
            Assert.AreEqual(tk5.User("linhmai","123456"),true);
            //Sai Gia trị
            DangNhapTk tk6 = new DangNhapTk();
            Assert.AreEqual(tk6.User("linhmai", "123123"),false);
        }
    }
}
