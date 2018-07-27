using Xunit;

namespace DemoCode.Tests
{
    public class AssertingNullsBooleans
    {
        [Fact]
        public void ShouldHaveDefaultRandomGeneratedName()
        {
            var sut = new PlayerCharacter();

            Assert.False(string.IsNullOrEmpty(sut.Name));
           
        }
        [Fact]
        public void ShouldNotHaveNickname()
        {        
            var sut = new PlayerCharacter();

            Assert.Null(sut.Nickname);

        }

        [Fact]
        public void ShouldBeNewbie()
        {
            var sut = new PlayerCharacter();

            Assert.True(sut.IsNoob);

        }
    }
}
