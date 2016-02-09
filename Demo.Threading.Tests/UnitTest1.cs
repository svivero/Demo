using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demo.Threading.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calculator target = new Calculator();
            int actual = target.AddAsync(1, 2);
            Assert.AreEqual(3, actual);
        }
    }
}
