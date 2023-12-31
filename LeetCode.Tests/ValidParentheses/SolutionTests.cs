using LeetCode.ValidParentheses;

namespace LeetCode.Tests.ValidParentheses
{
    public class SolutionTests
    {
        private readonly Solution _solution = new();

        [Theory]
        [InlineData("()", true)]
        [InlineData("()[]{}", true)]
        [InlineData("(]", false)]
        [InlineData("]", false)]
        public void Tests(string input, bool expected)
        {
            _solution.IsValid(input).Should().Be(expected);
        }
    }
}
