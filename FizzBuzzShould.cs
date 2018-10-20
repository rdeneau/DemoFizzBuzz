using FluentAssertions;
using Xunit;

namespace DemoFizzBuzz
{
    public class FizzBuzzShould
    {
        [Fact]
        public void SmokeTest()
        {
            true.Should().Be(false);
        }
    }
}
