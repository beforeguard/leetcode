using LeetCode.SquareRoot;

namespace LeetCode.Tests.SquareRoot
{
    public class SolutionTests
    {
        private readonly Solution _solution = new();

        [Theory]
        [InlineData(4, 2)]
        [InlineData(8, 2)]
        public void Test(int x, int expected)
        {
            _solution.MySqrt(x).Should().Be(expected);
        }
    }
}
