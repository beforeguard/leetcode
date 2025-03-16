using LeetCode._27_RemoveElement;

namespace LeetCode.Tests._27_RemoveElement
{
    public class SolutionTests
    {
        private readonly Solution _solution = new();

        [Theory]
        [InlineData(new int[] { 3, 2, 2, 3 }, 3, 2)]
        [InlineData(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5)]
        public void Test(int[] nums, int val, int expected)
        {
            _solution.RemoveElement(nums, val).Should().Be(expected);
        }
    }
}
