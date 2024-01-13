using LeetCode.LengthOfLastWord;

namespace LeetCode.Tests.LengthOfLastWord
{
    public class SolutionTests
    {
        private readonly Solution _solution = new Solution();

        [Theory]
        [InlineData(" ", 0)]
        [InlineData("a", 1)]
        [InlineData("a ", 1)]
        [InlineData(" a", 1)]
        [InlineData("day", 3)]
        [InlineData("Hello World", 5)]
        [InlineData("   fly me   to   the moon  ", 4)]
        [InlineData("luffy is still joyboy", 6)]
        public void Test(string s, int expected)
        {
            _solution.LengthOfLastWord(s).Should().Be(expected);
        }
    }
}
