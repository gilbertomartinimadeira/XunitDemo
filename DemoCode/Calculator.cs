using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCode
{
    public class Calculator
    {

        public int AddInts(int a, int b) => a + b;       

        public double AddDoubles(double a, double b) => a + b;

        public byte AddBytes(byte a, byte b) => (byte)(a + b);

        public int Divide(int value, int by)
        {
            if (value > 200)
            {
                throw new ArgumentOutOfRangeException("value");
            }
            return value / by;
        }
    }
}
