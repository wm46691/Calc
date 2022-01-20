using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest {
    [TestClass]
    public class UnitTestUtilities {
        private char[] binSymbols = { '1', '0', '+', '-', '=', '*', '/', '^', '&', '|', '<', '>', '%', '(', ')' };
        private char[] octSymbols = { '1', '0', '2', '3', '4', '5', '6', '7', '+', '-', '=', '*', '/', '^', '&', '|', '<', '>', '%', '(', ')' };
        private char[] decSymbols = { '1', '0', '2', '3', '4', '5', '6', '7', '8', '9', '+', '-', '=', '*', '/', '^', '&', '|', '<', '>', '%', '(', ')' };
        private char[] hexSymbols = { '1', '0', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', '+', '-', '=', '*', '/', '^', '&', '|', '<', '>', '%', '(', ')' };
        [TestMethod]
        public void SwitchToHex() {
            var calc = new Kalkulator.Calc();
            calc.SwitchCalcSystem(Kalkulator.CalcSystem.SystemHex);

            Assert.AreEqual(Kalkulator.CalcSystem.SystemHex, calc.CalcSystem);
            CollectionAssert.AreEqual(calc.possibleSymbols, hexSymbols);
        }

        [TestMethod]
        public void SwitchToDec() {
            var calc = new Kalkulator.Calc();
            calc.SwitchCalcSystem(Kalkulator.CalcSystem.SystemDec);

            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
            CollectionAssert.AreEqual(calc.possibleSymbols, decSymbols);
        }

        [TestMethod]
        public void SwitchToBin() {
            var calc = new Kalkulator.Calc();
            calc.SwitchCalcSystem(Kalkulator.CalcSystem.SystemBin);

            Assert.AreEqual(Kalkulator.CalcSystem.SystemBin, calc.CalcSystem);
            CollectionAssert.AreEqual(calc.possibleSymbols, binSymbols);
        }

        [TestMethod]
        public void SwitchToOct() {
            var calc = new Kalkulator.Calc();
            calc.SwitchCalcSystem(Kalkulator.CalcSystem.SystemOct);

            Assert.AreEqual(Kalkulator.CalcSystem.SystemOct, calc.CalcSystem);
            CollectionAssert.AreEqual(calc.possibleSymbols, octSymbols);
        }
    
        [TestMethod]
        public void SwitchToQword() {
            var calc = new Kalkulator.Calc();
            calc.SwitchCalcTyp(Kalkulator.CalcTyp.TypQword);

            Assert.AreEqual(Kalkulator.CalcTyp.TypQword, calc.CalcTyp);
        }

        [TestMethod]
        public void SwitchToDword() {
            var calc = new Kalkulator.Calc();
            calc.SwitchCalcTyp(Kalkulator.CalcTyp.TypDword);

            Assert.AreEqual(Kalkulator.CalcTyp.TypDword, calc.CalcTyp);
        }

        [TestMethod]
        public void SwitchToWord() {
            var calc = new Kalkulator.Calc();
            calc.SwitchCalcTyp(Kalkulator.CalcTyp.TypWord);

            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
        }

        [TestMethod]
        public void SwitchToByte() {
            var calc = new Kalkulator.Calc();
            calc.SwitchCalcTyp(Kalkulator.CalcTyp.TypByte);

            Assert.AreEqual(Kalkulator.CalcTyp.TypByte, calc.CalcTyp);
        }
    }
}
