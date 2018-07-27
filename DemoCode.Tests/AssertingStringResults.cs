using Xunit;

namespace DemoCode.Tests
{
    public class AssertingStringResults
    {
        [Fact]
        public void ShouldJoinNames()
        {
            var sut = new NameJoiner();

            var result = sut.Join("Gilberto", "Madeira");

            var fullname = "Gilberto Madeira";

            Assert.Equal(fullname, result);
            
        }

        [Fact]
        public void ShouldJoinNamesIgnoringCase()
        {

            var sut = new NameJoiner();

            var result = sut.Join("GILBERTO", "MADEIRA");

            Assert.Equal("gilberto madeira", result, ignoreCase: true);
        }

        [Fact]
        public void ShouldJoinNamesVerifyingContent()
        {
            var sut = new NameJoiner();

            var result = sut.Join("Joselia", "Amancio");

            Assert.Contains("Amancio", result);
        }

        [Fact]
        public void ShouldJoinNames_StartsWith()
        {
            var sut = new NameJoiner();

            var result = sut.Join("Diego", "Dantas");

            Assert.StartsWith("Diego", result);       
        }

        [Fact]
        public void ShouldJoinNames_EndsWith()
        {
            var sut = new NameJoiner();

            var result = sut.Join("Victor", "Ferreira");

            Assert.EndsWith("ira", result);        
        }

        [Fact]
        public void ShouldJoinNames_Regex()
        {
            var sut = new NameJoiner();

            var result = sut.Join("Priscila","Lima");

            Assert.Matches("^P", result);
        }
    }
}
