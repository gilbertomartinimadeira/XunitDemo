using System;
using System.Threading;
using Xunit;

namespace DemoCode.Tests
{
    [Trait("Category", "Error Checking")]
    public class AssertingExceptions
    {
        
        [Fact]
        public void ShouldErrorWhenDivideByZero()
        {
            var sut = new Calculator();

            Assert.Throws<DivideByZeroException>(() => { sut.Divide(10, 0); });
        }

        [Fact]
        [Trait("Category", "Slow Running")]
        public void ShouldErrorWhenNumberTooBig()
        {
            var sut = new Calculator();

            Thread.Sleep(3000);
            var thrownException = Assert.Throws<ArgumentOutOfRangeException>(() => sut.Divide(201, 2));

            Assert.Equal("value", thrownException.ParamName);
        }
    }
}
