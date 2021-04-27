
using System;

namespace Calculator
{
    public class CCalculator
    {
        private readonly Offset Offset;

        public CCalculator(Offset _offeset)
        {
            Offset = _offeset;
        }
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public int AddWithOffset(int num1, int num2)
        {
            return num1 + num2 + Offset.Get();
        }
        public int Sub(int num1, int num2)
        {
            return num1 - num2;
        }
        public int Mul(int num1, int num2)
        {
            return num1 * num2;
        }
        public int Div(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
