using FluentAssertions;
using Xunit;

namespace DemoFizzBuzz
{
    public class FizzBuzzShould
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void Return_Given_Number_Stringifyed(int number)
        {
            number.FizzBuzz().Should().Be(number.ToString());
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        public void Return_Fizz_Given_Multiple_Of_3(int number)
        {
            number.FizzBuzz().Should().Be("Fizz");
        }

        [Theory]
        [InlineData(5)]
        public void Return_Buzz_Given_Multiple_Of_5(int number)
        {
            number.FizzBuzz().Should().Be("Buzz");
        }
    }

    // Prod

    public static class NumberExtensions
    {
        public static string FizzBuzz(this int number)
        {
            if (number.IsMultipleOf(3)) return "Fizz";
            if (number.IsMultipleOf(5)) return "Buzz";
            return $"{number}";
        }

        private static bool IsMultipleOf(this int number, int factor) => number % factor == 0;
    }
}
