using LeetCode._9_PalindromeNumber;

namespace LeetCode.Tests._9_PalindromeNumber
{
    public class SolutionTests
    {
        private readonly Solution _solution = new();

        [Theory]
        [InlineData(121, true)]
        [InlineData(-121, false)]
        [InlineData(10, false)]
        [InlineData(123, false)]
        public void Test(int number, bool expected)
        {
            _solution.IsPalindrome(number).Should().Be(expected);
        }
    }
}
