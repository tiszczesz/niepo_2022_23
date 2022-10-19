namespace Console1.Test
{
    [TestClass]
    public class CalculateNumbersTest
    {
        [TestMethod]
        public void AddTest()
        {
            int a = 12;
            int b = 13;
            CalculateNumbers cn = new CalculateNumbers();
            cn.FirstNumber = a;
            cn.SecondNumber = b;
            Assert.AreEqual(25, cn.Add());
        }
        [TestMethod]
        public void SubtractTest()
        {
            var cn = new CalculateNumbers();
            cn.FirstNumber = 3;
            cn.SecondNumber = 4;
            Assert.AreEqual(-1, cn.Subtract());
        }
        [TestMethod]
        public void SubtractTestOther()
        {
            var cn = new CalculateNumbers();
            cn.FirstNumber = 7;
            cn.SecondNumber = 5;
            Assert.AreEqual(2, cn.Subtract());
        }
        [TestMethod]
        public void DivideTest()
        {
            var cn = new CalculateNumbers();
            cn.FirstNumber = 25;
            cn.SecondNumber = 10;
            Assert.AreEqual(2.5, cn.Divie());
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException),"Dzielimy przez zero")]
        public void DivideTestByZero()
        {
            var cn = new CalculateNumbers();
            cn.FirstNumber = 25;
            cn.SecondNumber = 0;
            Assert.AreEqual(2.5, cn.Divie());
        }
    }
}