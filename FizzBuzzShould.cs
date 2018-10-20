using FluentAssertions;
using Xunit;

namespace DemoFizzBuzz
{
    public class FizzBuzzShould
    {
        [Fact]
        public void Return_1_Given_1()
        {
            new FizzBuzz().Of(1).Should().Be("1");
        }
    }

    // Prod

    public class FizzBuzz
    {
        public string Of(int number)
        {
            return "";
        }
    }
}
