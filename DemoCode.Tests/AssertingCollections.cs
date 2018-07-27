using Xunit;


namespace DemoCode.Tests
{
    public class AssertingCollections
    {
        [Fact]
        public void ShouldHaveNoEmptyDefaultWeapons()
        {
            var sut = new PlayerCharacter();

            Assert.All(sut.Weapons, weapon => Assert.False(string.IsNullOrEmpty(weapon)));
        }

        [Fact]
        public void ShouldHaveGun()
        {
            var sut = new PlayerCharacter();

            Assert.Contains("Gun", sut.Weapons);
        }

        [Fact]
        public void ShouldNotHaveStaffs()
        {
            var sut = new PlayerCharacter();

            Assert.DoesNotContain("Staff", sut.Weapons);

        }

        [Fact]
        public void ShouldHaveAtLeastOneKindOfSword()
        {
            var sut = new PlayerCharacter();

            Assert.Contains(sut.Weapons, weapon => weapon.Contains("Sword"));






        }

        [Fact]
        public void ShouldHaveAllExpectedWeapons()
        {

            var sut = new PlayerCharacter();

            var expected = new[]
            {
                "Gun",
                "Sword",
                "Wip"
            };

            Assert.Equal(expected, sut.Weapons);

        }
    }
}
