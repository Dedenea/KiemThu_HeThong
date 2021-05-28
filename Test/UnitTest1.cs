using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibraryHoDuongVu;
namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ClassLibraryHoDuongVu.Class1 o = new Class1();
            String kq = "";
            String ex = o.HowToGrade(-1, 0);
            Assert.AreEqual(kq, ex);
            
        }
        [TestMethod]
        public void TestMethod2()
        {
            ClassLibraryHoDuongVu.Class1 o = new Class1();
            String kq = "Fail";
            String ex = o.HowToGrade(49, 49);
            Assert.AreEqual(kq, ex);

        }
        [TestMethod]
        public void TestMethod3()
        {
            ClassLibraryHoDuongVu.Class1 o = new Class1();
            String kq = "C";
            String ex = o.HowToGrade(59, 59);
            Assert.AreEqual(kq, ex);

        }
        [TestMethod]
        public void TestMethod4()
        {
            ClassLibraryHoDuongVu.Class1 o = new Class1();
            String kq = "B";
            String ex = o.HowToGrade(70, 70);
            Assert.AreEqual(kq, ex);

        }
        [TestMethod]
        public void TestMethod5()
        {
            ClassLibraryHoDuongVu.Class1 o = new Class1();
            String kq = "A";
            String ex = o.HowToGrade(69, 69);
            Assert.AreEqual(kq, ex);

        }
    }
}
