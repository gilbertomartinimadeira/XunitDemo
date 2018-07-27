using System;
using Xunit;
using Xunit.Abstractions;


namespace DemoCode.Tests
{
    public class MemoryCalculatorTests : IDisposable
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private MemoryCalculator _sut;

        public MemoryCalculatorTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
            _testOutputHelper.WriteLine("Creating the system under test");        
            _sut = new MemoryCalculator();
        }

        [Fact]
        public void ShouldAdd()
        {
                                
            _testOutputHelper.WriteLine("Adding 15 to memoryCalculator");
            _sut.Add(15);

            _testOutputHelper.WriteLine("Adding 15 more to memoryCalculator");
            _sut.Add(15);        

            _testOutputHelper.WriteLine("30 was added to memoryCalculator");
            Assert.Equal(30, _sut.CurrentValue);
                
        }

        [Fact]
        public void ShouldSubtract()
        {

            _testOutputHelper.WriteLine("Subtracting 10 from memoryCalculator");
            _sut.Subtract(10);

            _testOutputHelper.WriteLine("Subtracting 6 from memoryCalculator");
            _sut.Subtract(6);

            _testOutputHelper.WriteLine("16 was subtracted from memoryCalculator");
            Assert.Equal(-16, _sut.CurrentValue);

        }

        [Fact]
        public void ShouldDivide()
        {
            _testOutputHelper.WriteLine("CurrentValue Receives 10");
            _sut.Add(10);

            _testOutputHelper.WriteLine("CurrentValue was divided by 2");
            _sut.Divide(2);           

            
            Assert.Equal(5, _sut.CurrentValue);

        }

        public void Dispose()
        {
            _testOutputHelper.WriteLine("Disposing the system under test to clean up resources");
            _sut.Dispose();
                
        }
        
    }
}
