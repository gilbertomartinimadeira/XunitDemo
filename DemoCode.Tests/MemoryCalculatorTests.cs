using System;
using Xunit;
using Xunit.Abstractions;


namespace DemoCode.Tests
{
    public class MemoryCalculatorTests : IClassFixture<MemoryCalculatorFixture>
    {
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly MemoryCalculatorFixture _fixture;

        public MemoryCalculatorTests(ITestOutputHelper testOutputHelper, MemoryCalculatorFixture fixture)
        {
            _testOutputHelper = testOutputHelper;
            _fixture = fixture;
            _fixture.Sut.Clear();
        }

        [Theory]
        [InlineData(5,5,10)]
        [InlineData(2, 2, 4)]
        public void ShouldAdd(int a, int b, int expectedResult)
        {
                                
            _testOutputHelper.WriteLine($"Adding {a} to memoryCalculator");
            _fixture.Sut.Add(a);

            _testOutputHelper.WriteLine($"Adding {b} more to memoryCalculator");
            _fixture.Sut.Add(b);        

            _testOutputHelper.WriteLine($"{a+b} was added to memoryCalculator");
            Assert.Equal(expectedResult, _fixture.Sut.CurrentValue);
                
        }

        [Fact]
        public void ShouldSubtract()
        {

            _testOutputHelper.WriteLine("Subtracting 10 from memoryCalculator");
            _fixture.Sut.Subtract(10);

            _testOutputHelper.WriteLine("Subtracting 6 from memoryCalculator");
            _fixture.Sut.Subtract(6);

            _testOutputHelper.WriteLine("16 was subtracted from memoryCalculator");
            Assert.Equal(-16, _fixture.Sut.CurrentValue);

        }

        [Fact]
        public void ShouldDivide()
        {
            _testOutputHelper.WriteLine("CurrentValue Receives 10");
            _fixture.Sut.Add(10);

            _testOutputHelper.WriteLine("CurrentValue was divided by 2");
            _fixture.Sut.Divide(2);           

            
            Assert.Equal(5, _fixture.Sut.CurrentValue);

        }     
        
    }
}
