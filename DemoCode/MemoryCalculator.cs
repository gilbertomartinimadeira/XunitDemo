using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DemoCode
{
    public class MemoryCalculator : IDisposable
    {
        public int CurrentValue { get; private set; }

        public MemoryCalculator()
        {           
            Thread.Sleep(2000);

        }

        public void Add(int number) => CurrentValue += number;

        public void Subtract(int number) => CurrentValue -= number;

        public void Divide(int number)
        {
            CurrentValue /= number;
        }

        public void Clear()
        {
            CurrentValue = 0;
        }

        public void Dispose()
        {
            CurrentValue = 0;
        }
    }
}
