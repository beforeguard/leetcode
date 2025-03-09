using LeetCode._136_SingleNumber;

namespace LeetCode.Tests._136_SingleNumber
{
    public class SolutionTests
    {
        private readonly Solution _solution = new();

        [Theory]
        [InlineData(new int[] { 2, 2, 1 }, 1)]
        [InlineData(new int[] { 4, 1, 2, 1, 2 }, 4)]
        [InlineData(new int[] { 1 }, 1)]
        public void Test(int[] nums, int expected)
        {
            _solution.SingleNumber(nums).Should().Be(expected);
        }
    }
}
