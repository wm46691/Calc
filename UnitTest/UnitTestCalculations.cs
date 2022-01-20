using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest {
    [TestClass]
    public class UnitTestCalculations {
        [TestMethod]
        public void TestAdd() {
            var calc = new Kalkulator.Calc();

            Assert.AreEqual(calc.Sum(4, 5), 9);
            //Assert.AreEqual(calc.Sum(long.MaxValue + 1), Int64.MinValue);
        }
        [TestMethod]
        public void TestMinus() {
            var calc = new Kalkulator.Calc();

            Assert.AreEqual(calc.Subtraction(13, 7), 6);
            Assert.AreEqual(calc.Subtraction(6, 12), -6);
            Assert.AreEqual(calc.Subtraction(5, -5), 10);
        }
        [TestMethod]
        public void TestMultiply() {
            var calc = new Kalkulator.Calc();

            Assert.AreEqual(calc.Multiply(4, 5), 20);
        }
        [TestMethod]
        public void TestDivision() {
            var calc = new Kalkulator.Calc();

            Assert.AreEqual(calc.Divide(7, 2), 3);
        }
        [TestMethod]
        public void TestModulo() {
            var calc = new Kalkulator.Calc();

            Assert.AreEqual(calc.Modulo(8, 3), 2);
            Assert.AreEqual(calc.Modulo(0, 8), 0);
        }
        [TestMethod]
        public void TestCombinations() {
            var calc = new Kalkulator.Calc();

            Assert.AreEqual(calc.Multiply(2, calc.Divide(7, 3)), 4);
        }
        [TestMethod]
        public void TestAnd() {
            var calc = new Kalkulator.Calc();

            Assert.AreEqual(calc.And(22,5), 4);
        }
        [TestMethod]
        public void TestOr() {
            var calc = new Kalkulator.Calc();

            Assert.AreEqual(calc.Or(7, 11), 15);
        }
        [TestMethod]
        public void TestNot() {
            var calc = new Kalkulator.Calc();

            Assert.AreEqual(calc.Not(55), -56);
            Assert.AreEqual(calc.Not(-56), 55);
        }
        [TestMethod]
        public void TestXor() {
            var calc = new Kalkulator.Calc();
            Assert.AreEqual(calc.Xor(5, 3), 6);
        }
    }
}
