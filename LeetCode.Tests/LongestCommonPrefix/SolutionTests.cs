using LeetCode.LongestCommonPrefix;

namespace LeetCode.Tests.LongestCommonPrefix
{
    public class SolutionTests
    {
        private readonly Solution _solution = new();

        [Theory]
        [InlineData(new string[] { "flower", "flow", "flight" }, "fl")]
        [InlineData(new string[] { "dog", "racecar", "car" }, "")]
        public void Test(string[] strs, string expected)
        {
            _solution.LongestCommonPrefix(strs).Should().Be(expected);
        }
    }
}
