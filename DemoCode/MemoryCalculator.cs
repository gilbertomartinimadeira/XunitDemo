using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCode
{
    public class MemoryCalculator : IDisposable
    {
        public int CurrentValue { get; private set; }

        public void Add(int number) => CurrentValue += number;

        public void Subtract(int number) => CurrentValue -= number;

        public void Divide(int number)
        {
            CurrentValue /= number;
        }

        public void Dispose()
        {
            CurrentValue = 0;
        }
    }
}
