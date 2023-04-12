using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_cw2.Models;

namespace MVC_cw2.Tests
{
    [TestClass]
    public class NWDUnitTest
    {
        [TestMethod]
        public void Test1() {
            NWDCounter nwd = new NWDCounter();
            nwd.A = 20;
            nwd.B = 15;
            int actual = nwd.GetNWD(nwd.A, nwd.B);
            Assert.AreEqual(5, actual);
        }
    }
}
