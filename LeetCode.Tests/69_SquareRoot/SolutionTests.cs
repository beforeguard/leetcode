using LeetCode._69_SquareRoot;

namespace LeetCode.Tests._69_SquareRoot
{
    public class SolutionTests
    {
        private readonly Solution _solution = new();

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(4, 2)]
        [InlineData(6, 2)]
        [InlineData(8, 2)]
        [InlineData(36, 6)]
        public void Test(int x, int expected)
        {
            _solution.MySqrt(x).Should().Be(expected);
        }
    }
}
