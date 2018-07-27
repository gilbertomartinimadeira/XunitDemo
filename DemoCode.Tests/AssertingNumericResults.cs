using Xunit;

namespace DemoCode.Tests
{
    public class AssertingNumericResults
    {
        [Fact]
        public void ShouldAddInts()
        {
            var sut = new Calculator();

            var result = sut.AddInts(4, 5);

            Assert.Equal(9, result);

        }

        [Fact]
        public void ShouldAddDoubles()
        {
            var sut = new Calculator();

            var result = sut.AddDoubles(2.2, 1.1);

            Assert.Equal(3.3, result,1);

        }

        [Fact]
        public void ShouldAddBytes()
        {
            var sut = new Calculator();

            var result = sut.AddBytes(1, 4);

            Assert.Equal(5, result);
        }
    }
}
