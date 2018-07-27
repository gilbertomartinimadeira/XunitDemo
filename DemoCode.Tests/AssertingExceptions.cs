using System;
using Xunit;

namespace DemoCode.Tests
{
    public class AssertingExceptions
    {
        
        [Fact]
        [Trait("Category", "Error Checking")]
        public void ShouldErrorWhenDivideByZero()
        {
            var sut = new Calculator();

            Assert.Throws<DivideByZeroException>(() => { sut.Divide(10, 0); });
        }

        [Fact]
        [Trait("Category", "Error Checking")]
        public void ShouldErrorWhenNumberTooBig()
        {
            var sut = new Calculator();
        
            var thrownException = Assert.Throws<ArgumentOutOfRangeException>(() => sut.Divide(201, 2));

            Assert.Equal("value", thrownException.ParamName);
        }
    }
}
