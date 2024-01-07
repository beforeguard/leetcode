using LeetCode.RemoveDuplicatesFromSortedArray;

namespace LeetCode.Tests.RemoveDuplicatesFromSortedArray
{
    public class SolutionTests
    {
        private readonly Solution _solution = new();

        [Theory]
        [InlineData(new int[] { 1, 1, 2 }, 2)]
        [InlineData(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5)]
        public void Test(int[] nums, int expected)
        {
            _solution.RemoveDuplicates(nums).Should().Be(expected);
        }
    }
}
