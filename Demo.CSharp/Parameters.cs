using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.CSharp
{
    [TestClass]
    public class Parameters
    {
        private void ByVal(int x) => x++;
        private void ByRef(ref int x) => x++;

        [TestMethod]
        public void ByValue_XnotChanged()
        {
            int x = 1;
            ByVal(x);
            Assert.AreEqual(1, x);
        }

        [TestMethod]
        public void ByValue_Xchanged()
        {
            int x = 1;
            ByRef(ref x);
            Assert.AreEqual(2, x);
        }
    }
}
