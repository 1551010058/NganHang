using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NganHang;
namespace UnitTest
{
    [TestClass]
    public class Chung
    {
        [TestMethod]
        public void KiemTraRong()
        {
            DungChung DC = new DungChung();
            DungChung DC1 = new DungChung();
            Assert.AreEqual(DC.KiemTra_Rong(""), false);//sai
            Assert.AreEqual(DC1.KiemTra_Rong("abc"), true);//đúng
        }
         [TestMethod]
        public void KiemTraTonTai()
        {
            DungChung DC2 = new DungChung();
            DungChung DC3 = new DungChung();
            Assert.AreEqual(DC2.kiemtratontai("linhmai"), true);//báo da có
            Assert.AreEqual(DC3.kiemtratontai("maiduylinh"), false);//báo chưa có
            ///SDT
        }
         [TestMethod]
         public void KiemTraSDTTonTai()
         {
             ///VD
             DungChung DC4 = new DungChung();
             DungChung DC5 = new DungChung();
             Assert.AreEqual(DC4.kiemtrasdttontai("01635541996"),true);//báo da có
            Assert.AreEqual(DC5.kiemtrasdttontai("1234567890"), false);//báo chưa có
         }
         [TestMethod]
         public void KiemTraCMNDTonTai()
         {
             //VD
             DungChung DC6 = new DungChung();
             DungChung DC7 = new DungChung();
             Assert.AreEqual(DC6.kiemtracmndtontai("272609131"), true);//báo da có
             Assert.AreEqual(DC7.kiemtracmndtontai("222331133"), false);//báo chưa có
         }
         [TestMethod]
        // kiem tra ký tu dat biệt ở user pass
        public void KiemTraKyUserrPass()
         {
             DungChung DC8 = new DungChung();
             Assert.AreEqual(DC8.kiemtrauerpass("mai#linh"), false);//Có ký tu dat biệt ở ô user or pass
             DungChung DC9 = new DungChung();
             Assert.AreEqual(DC9.kiemtrauerpass("linhmai"), true);// Ko Có ký tu dat biệt ở ô user or pass
         }
         [TestMethod]
         public void KiemTraChuoiKyTu()
         {
             //VD
             DungChung DC10 = new DungChung();
             Assert.AreEqual(DC10.kiemtrakitu("mai#linh"), false);//Có ký tu dat biệt ở các ô còn lai
             DungChung DC11 = new DungChung();
             Assert.AreEqual(DC11.kiemtrakitu("Nguyễn Văn A"), true);// Đúng ở họ Tên ...
         }
         [TestMethod]
        public void SDT()
         {
             //VD
             DungChung DC12 = new DungChung();
             DungChung DC13 = new DungChung();
             Assert.AreEqual(DC12.SDT("01635541996"), true);// có 11 SDT
             Assert.AreEqual(DC13.SDT("016355419967"), false);//Có 12 SDT
         }
        [TestMethod]
         public void CMND()
         {
             //VD
             DungChung DC1 = new DungChung();
             DungChung DC2 = new DungChung();
             Assert.AreEqual(DC1.CMND("271609131"), true);// có 9 CMND
             Assert.AreEqual(DC2.CMND("2726091312"), false);//Có 10 số CMND
         }
         [TestMethod]
        public void MatKhau()
        {
            //VD
            DungChung DC1 = new DungChung();
            DungChung DC2 = new DungChung();
            Assert.AreEqual(DC1.MatKhau("123456"), true);// đúng
            Assert.AreEqual(DC2.MatKhau("27260913122131231231233123"), false);//Sai nhiu hơn con số từ 6 đén 20
        }
        [TestMethod]
        public void ktchuoicotrong()
         {
            // VD trên ô đang nhập luc đang ký
             DungChung DC1 = new DungChung();
             DungChung DC2 = new DungChung();
             Assert.AreEqual(DC1.kiemtratrongchuoi("mai linh"), true);// sai
             Assert.AreEqual(DC2.kiemtratrongchuoi("mailinh"), false);//Đúng
         }

    }
}
