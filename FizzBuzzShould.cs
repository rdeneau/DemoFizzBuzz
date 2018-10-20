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
            FizzBuzz.Of(number).Should().Be(number.ToString());
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        public void Return_Fizz_Given_Multiple_Of_3(int number)
        {
            FizzBuzz.Of(number).Should().Be("Fizz");
        }

        [Theory]
        [InlineData(5)]
        public void Return_Buzz_Given_Multiple_Of_5(int number)
        {
            FizzBuzz.Of(number).Should().Be("Buzz");
        }
    }

    // Prod

    public static class FizzBuzz
    {
        public static string Of(int number)
        {
            if (number % 3 == 0) return "Fizz";
            if (number % 5 == 0) return "Buzz";
            return $"{number}";
        }
    }
}
