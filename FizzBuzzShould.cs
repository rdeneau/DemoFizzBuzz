using FluentAssertions;
using Xunit;

namespace DemoFizzBuzz
{
    public class FizzBuzzShould
    {
        [Fact]
        public void Return_1_Given_1()
        {
            FizzBuzz.Of(1).Should().Be("1");
        }
    }

    // Prod

    public static class FizzBuzz
    {
        public static string Of(int number)
        {
            return "1";
        }
    }
}
