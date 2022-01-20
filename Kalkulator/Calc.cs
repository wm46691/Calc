using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    public class Calc {
        public string calcValue;
        public string CalcValue {
            get { return calcValue; }
            set { calcValue = GigaSet(value); }
        }
        public CalcSystem CalcSystem { get; set; }
        public CalcTyp CalcTyp { get; set; }

        private char[] binSymbols = { '1', '0', '+', '-', '=', '*', '/', '^', '&', '|', '<', '>', '%', '(', ')' };
        private char[] octSymbols = { '1', '0', '2', '3', '4', '5', '6', '7', '+', '-', '=', '*', '/', '^', '&', '|', '<', '>', '%', '(', ')' };
        private char[] decSymbols = { '1', '0', '2', '3', '4', '5', '6', '7', '8', '9', '+', '-', '=', '*', '/', '^', '&', '|', '<', '>', '%', '(', ')' };
        private char[] hexSymbols = { '1', '0', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', '+', '-', '=', '*', '/', '^', '&', '|', '<', '>', '%', '(', ')' };

        public char[] possibleSymbols = { };
        public Calc()
        {
            calcValue = "0";
            SwitchCalcSystem(CalcSystem.SystemDec);
            
        }

        public string GigaSet(string value)
        {
            string valueOne = "";
            //char[] possibleValue = { '1', '0', '+', '-', '=', '*', '/', '^', '&', '|', '<', '>', '%', '(', ')' };
            for(int i=0; i<value.Length;i++)
            {
                if (possibleSymbols.Contains(value[i]))
                {
                    valueOne += value[i];
                }
            }
            return valueOne;
        }
            
        public void SwitchCalcTyp(CalcTyp ct) {
            CalcTyp = ct;
        }

        public void SwitchCalcSystem(CalcSystem cs) {
            CalcSystem = cs;
            switch (CalcSystem) {
                case CalcSystem.SystemHex:
                    possibleSymbols = hexSymbols;
                    break;
                case CalcSystem.SystemDec:
                    possibleSymbols = decSymbols;
                    break;
                case CalcSystem.SystemOct:
                    possibleSymbols = octSymbols;
                    break;
                case CalcSystem.SystemBin:
                    possibleSymbols = binSymbols;
                    break;
            }
        }

        public long Sum(long a, long b) {
            return a + b;
        }
        public long Subtraction(long a, long b) {
            return a - b;
        }
        public long Multiply(long a, long b) {
            return a * b;
        }
        public long Divide (long a, long b) {
            return a / b;
        }
        public long Modulo (long a, long b) {
            return a % b;
        }
        public long And (long a, long b) {
            return a & b;
        }
        public long Or(long a, long b) {
            return a | b;
        }
        public long Not(long a) {
            return ~a;
        }
        public long Xor(long a, long b) {
            return a ^ b;
        }
        public long RightShift(long a, int b) {
            return a >> b;
        }
        public long LeftShift(long a, int b) {
            return a >> b;
        }
    }

}
