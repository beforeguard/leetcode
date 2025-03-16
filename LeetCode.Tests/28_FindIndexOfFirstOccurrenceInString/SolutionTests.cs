using LeetCode._28_FindIndexOfFirstOccurrenceInString;

namespace LeetCode.Tests._28_FindIndexOfFirstOccurrenceInString
{
    public class SolutionTests
    {
        private readonly Solution _solution = new();

        [Theory]
        [InlineData("sadbutsad", "sad", 0)]
        [InlineData("leetcode", "leeto", -1)]
        public void Test(string haystack, string needle, int expected)
        {
            _solution.StrStr(haystack, needle).Should().Be(expected);
        }
    }
}
