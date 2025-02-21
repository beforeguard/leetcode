using LeetCode._70_ClimbingStairs;

namespace LeetCode.Tests._70_ClimbingStairs
{
    public class SolutionTests
    {
        private readonly Solution _solution = new();

        [Theory]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        [InlineData(45, 1836311903)]
        public void Test(int n, int expected)
        {
            _solution.ClimbStairs(n).Should().Be(expected);
        }
    }
}
