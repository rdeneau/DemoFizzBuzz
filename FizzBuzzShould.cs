using FluentAssertions;
using Xunit;

namespace DemoFizzBuzz
{
    public class FizzBuzzShould
    {
        [Fact]
        public void Return_1_Given_1()
        {
            new FizzBuzz();
        }
    }

    // Prod

    public class FizzBuzz {}
}
