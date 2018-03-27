using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool prawda = true;

            Assert.IsTrue(prawda);
        }

        [TestMethod]
        public void TestMethod2()
        {
            bool prawda = false;

            Assert.IsTrue(prawda);
        }
    }


}
