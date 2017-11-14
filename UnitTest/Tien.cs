using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NganHang;
namespace UnitTest
{
    [TestClass]
    public class Tien
    {
        [TestMethod]
        public void TienGui()
        {
            ClassTien TGV = new ClassTien();
            Assert.AreEqual(TGV.TienGui("2000000000"), true);
            Assert.AreEqual(TGV.TienGui("2000000000000"), false);
        }
        [TestMethod]
        public void TienRut1()
        {
            ClassTien TGV = new ClassTien();
            Assert.AreEqual(TGV.Tienrut1(10000), true);
            Assert.AreEqual(TGV.Tienrut1(-100000), false);
        }
        [TestMethod]
        public void TienRut2()
        {
            ClassTien TGV = new ClassTien();
            Assert.AreEqual(TGV.Tienrut2(1000), true);
            Assert.AreEqual(TGV.Tienrut2(1000000000), false);
        }
    }
}
