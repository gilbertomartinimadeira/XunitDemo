using System;
using Xunit;
using Xunit.Abstractions;

namespace DemoCode.Tests
{
    public class AssertingRanges
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public AssertingRanges(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void ShouldIncreaseHealthAfterSleeping()
        {
            _testOutputHelper.WriteLine("Creating PlayerCharacter");
            var sut = new PlayerCharacter() { Health = 100 };

            _testOutputHelper.WriteLine("PlayerCharacter Going to Sleep");
            sut.Sleep();

            
            _testOutputHelper.WriteLine("PlayerCharacter Awoken");
            Assert.InRange(sut.Health, 101, 200);
            

        }

    }
}
