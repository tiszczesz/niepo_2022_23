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
    }
}