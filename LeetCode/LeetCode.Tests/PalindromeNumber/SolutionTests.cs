using LeetCode.PalindromeNumber;

namespace LeetCode.Tests.PalindromeNumber
{
    public class SolutionTests
    {
        private readonly Solution _solution = new();

        [Theory]
        [InlineData(121, true)]
        [InlineData(-121, false)]
        [InlineData(10, false)]
        public void Test(int number, bool expected)
        {
            _solution.IsPalindrome(number).Should().Be(expected);
        }
    }
}
