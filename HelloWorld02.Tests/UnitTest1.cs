using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorld02.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string x = "Hello World";
            Assert.AreEqual("Hello World", x);
        }
    }
}
