using RegexDemoApp.Domain;

namespace RegexDemoApp.Tests
{
    public class AppDataUnitTests
    {
        [Fact]
        public void Title_ShouldBeExpectedValue1()
        {
            Assert.Equal("Regex with unit tests", AppData.TITLE);
        }

        [Fact]
        public void Version_ShouldBeExpectedValue1()
        {
            Assert.Equal("1.0", AppData.VERSION);
        }
    }
}