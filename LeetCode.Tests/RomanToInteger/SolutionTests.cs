using LeetCode.RomanToInteger;

namespace LeetCode.Tests.RomanToInteger
{
    public class SolutionTests
    {
        private readonly Solution _solution = new();

        [Theory]
        [InlineData("III", 3)]
        [InlineData("LVIII", 58)]
        [InlineData("MCMXCIV", 1994)]
        public void Test(string input, int expected)
        {
            _solution.RomanToInt(input).Should().Be(expected);
        }
    }
}
