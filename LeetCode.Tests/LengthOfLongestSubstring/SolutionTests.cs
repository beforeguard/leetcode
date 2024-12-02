using LeetCode.LengthOfLongestSubstring;

namespace LeetCode.Tests.LengthOfLongestSubstring
{
    public class SolutionTests
    {
        private readonly Solution _solution = new();

        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        public void Test(string input, int expected)
        {
            _solution.LengthOfLongestSubstring(input).Should().Be(expected);
        }
    }
}
