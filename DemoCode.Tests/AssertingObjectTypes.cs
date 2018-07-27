using Xunit;

namespace DemoCode.Tests
{
    public class AssertingObjectTypes
    {
        [Fact]
        public void ShouldCreateNormalEnemy_SimpleExample()
        {

            var sut = new EnemyFactory();

            object enemy = sut.CreateEnemy(false);

            NormalEnemy normalEnemy = Assert.IsType<NormalEnemy>(enemy);

            Assert.Equal(10, normalEnemy.Power);

        }
    }
}
