using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTestBin
    {
        [TestMethod]
        public void TestKalkOne()
        {
            var calc = new Kalkulator.Calc();

            calc.CalcValue = "1ww";

            Assert.AreEqual("1", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkZero()
        {
            var calc = new Kalkulator.Calc();

            calc.CalcValue = "0ww";

            Assert.AreEqual("0", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkPlus()
        {
            var calc = new Kalkulator.Calc();

            calc.CalcValue = "+ww";

            Assert.AreEqual("+", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkMinus()
        {
            var calc = new Kalkulator.Calc();

            calc.CalcValue = "-ww";

            Assert.AreEqual("-", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkEqual()
        {
            var calc = new Kalkulator.Calc();

            calc.CalcValue = "=ww";

            Assert.AreEqual("=", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkMulti()
        {
            var calc = new Kalkulator.Calc();

            calc.CalcValue = "*ww";

            Assert.AreEqual("*", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkDiv()
        {
            var calc = new Kalkulator.Calc();

            calc.CalcValue = "/wws";

            Assert.AreEqual("/", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkXor()
        {
            var calc = new Kalkulator.Calc();

            calc.CalcValue = "^wws";

            Assert.AreEqual("^", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkAnd()
        {
            var calc = new Kalkulator.Calc();

            calc.CalcValue = "&wws";

            Assert.AreEqual("&", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkOr()
        {
            var calc = new Kalkulator.Calc();

            calc.CalcValue = "|wws";

            Assert.AreEqual("|", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkLsh()
        {
            var calc = new Kalkulator.Calc();

            calc.CalcValue = "<wws";

            Assert.AreEqual("<", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkRsh()
        {
            var calc = new Kalkulator.Calc();

            calc.CalcValue = ">wws";

            Assert.AreEqual(">", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkMod()
        {
            var calc = new Kalkulator.Calc();

            calc.CalcValue = "%wws";

            Assert.AreEqual("%", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkNawiasLewy()
        {
            var calc = new Kalkulator.Calc();

            calc.CalcValue = "(wws";

            Assert.AreEqual("(", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkNawiasPrawy()
        {
            var calc = new Kalkulator.Calc();

            calc.CalcValue = ")wws";

            Assert.AreEqual(")", calc.CalcValue);
        }
    }
}
