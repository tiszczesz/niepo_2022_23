using System.Drawing.Printing;
using MVC_cw2.Models;

namespace MVC_cw2.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsPrimalTest()
        {
            PrimalGenerator pg = new PrimalGenerator();
            Assert.IsTrue(pg.IsPrimal(3));
        }

        [TestMethod]
        public void IsPrimalTest2()
        {
            PrimalGenerator pg = new PrimalGenerator();
            Assert.IsFalse(pg.IsPrimal(4));
        }

        [TestMethod]
        public void IsCountPrimals() {
            PrimalGenerator pgGenerator = new PrimalGenerator();
            var primals = pgGenerator.GetPrimals(10);
            Assert.AreEqual(4,primals.Count);
        }
    }
}