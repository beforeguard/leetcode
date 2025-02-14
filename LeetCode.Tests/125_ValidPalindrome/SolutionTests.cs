using LeetCode._125_ValidPalindrome;

namespace LeetCode.Tests._125_ValidPalindrome
{
    public class SolutionTests
    {
        private readonly Solution _solution = new();

        [Theory]
        [InlineData("A man, a plan, a canal: Panama", true)]
        [InlineData("race a car", false)]
        [InlineData(" ", true)]
        public void Test(string s, bool expected)
        {
            _solution.IsPalindrome(s).Should().Be(expected);
        }
    }
}
