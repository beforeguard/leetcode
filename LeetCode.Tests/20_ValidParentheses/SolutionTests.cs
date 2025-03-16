using LeetCode._20_ValidParentheses;

namespace LeetCode.Tests._20_ValidParentheses
{
    public class SolutionTests
    {
        private readonly Solution _solution = new();

        [Theory]
        [InlineData("()", true)]
        [InlineData("()[]{}", true)]
        [InlineData("(]", false)]
        [InlineData("]", false)]
        public void Test(string input, bool expected)
        {
            _solution.IsValid(input).Should().Be(expected);
        }
    }
}
