using System.Collections.Generic;
using System.Linq;
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
        [InlineData(10)]
        public void Return_Buzz_Given_Multiple_Of_5(int number)
        {
            number.FizzBuzz().Should().Be("Buzz");
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        public void Return_FizzBuzz_Given_Multiple_Of_15(int number)
        {
            number.FizzBuzz().Should().Be("FizzBuzz");
        }
    }

    // Prod

    public static class NumberExtensions
    {
        public static string FizzBuzz(this int number) =>
            Rule.All
                        .First(rule => rule.IsSatisfied(number))
                        .Result(number);

        private abstract class Rule
        {
            public static readonly IReadOnlyList<Rule> All = new Rule[]
            {
                new FizzBuzzRule(),
                new FizzRule(),
                new BuzzRule(),
                new DefaultRule()
            };

            private Rule() { }

            public abstract bool IsSatisfied(int number);
            public abstract string Result(int number);

            private class DefaultRule : Rule
            {
                public override bool IsSatisfied(int number) => true;
                public override string Result(int number) => $"{number}";
            }

            private abstract class FactorRule : Rule
            {
                public override bool IsSatisfied(int number) => number.IsMultipleOf(Factor);
                protected abstract int Factor { get; }
            }

            private class FizzRule : FactorRule
            {
                protected override int Factor => 3;
                public override string Result(int number) => "Fizz";
            }

            private class BuzzRule : FactorRule
            {
                protected override int Factor => 5;
                public override string Result(int number) => "Buzz";
            }

            private class FizzBuzzRule : FactorRule
            {
                protected override int Factor => 15;
                public override string Result(int number) => "FizzBuzz";
            }
        }

        private static bool IsMultipleOf(this int number, int factor) => number % factor == 0;
    }
}
