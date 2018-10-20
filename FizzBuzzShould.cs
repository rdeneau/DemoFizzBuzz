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

        [Fact]
        public void Return_2_Given_2()
        {
            FizzBuzz.Of(2).Should().Be("2");
        }
    }

    // Prod

    public static class FizzBuzz
    {
        public static string Of(int number)
        {
            if (number == 2) return $"{number}";
            if (number == 1) return $"{number}";
            return "";
        }
    }
}
