using LeetCode.SearchInsertPosition;

namespace LeetCode.Tests.SearchInsertPosition
{
    public class SolutionTests
    {
        private readonly Solution _solution = new();

        [Theory]
        [InlineData(new int[] { 1, 3, 5, 6 }, 5, 2)]
        [InlineData(new int[] { 1, 3, 5, 6 }, 2, 1)]
        [InlineData(new int[] { 1, 3, 5, 6 }, 7, 4)]
        public void Test(int[] nums, int target, int expected)
        {
            _solution.SearchInsert(nums, target).Should().Be(expected);
        }
    }
}
