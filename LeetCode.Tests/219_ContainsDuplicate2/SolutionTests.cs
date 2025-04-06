using LeetCode._219_ContainsDuplicate2;

namespace LeetCode.Tests._219_ContainsDuplicate2
{
    public class SolutionTests
    {
        private readonly Solution _solution = new Solution();

        [Theory]
        [InlineData(new[] { 1, 2, 3, 1 }, 3, true)]
        [InlineData(new[] { 1, 0, 1, 1 }, 1, true)]
        [InlineData(new[] { 1, 2, 3, 1, 2, 3 }, 2, false)]
        public void Test(int[] nums, int k, bool expected)
        {
            _solution.ContainsNearbyDuplicate(nums, k).Should().Be(expected);
        }
    }
}
