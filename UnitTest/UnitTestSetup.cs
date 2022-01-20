using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest {
    [TestClass]
    public class UnitTestSetup {
        [TestMethod]
        public void TestKalkValueInit() {
            var calc = new Kalkulator.Calc();

            Assert.AreEqual("0", calc.calcValue);
        }

        [TestMethod]
        public void TestKalkSystemInit() {
            var calc = new Kalkulator.Calc();

            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
        }
    }
}
