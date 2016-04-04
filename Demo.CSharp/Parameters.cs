using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demo.CSharp
{
    /*
        Also,
        ref tells the compiler that the object is initialized before entering the function, 
        while out tells the compiler that the object will be initialized inside the function.
    */
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
