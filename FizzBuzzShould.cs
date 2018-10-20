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
        public void Return_Fizz_Given_Multiple_Of_3(int number)
        {
            FizzBuzz.Of(number).Should().Be("Fizz");
        }
    }

    // Prod

    public static class FizzBuzz
    {
        public static string Of(int number)
        {
            return $"{number}";
        }
    }
}
