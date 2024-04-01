using LeetCode.RemoveDuplicatesFromSortedList;

namespace LeetCode.Tests.RemoveDuplicatesFromSortedList
{
    public class SolutionTests
    {
        private readonly Solution _solution = new();

        [Theory]
        [InlineData(new int[] { 1, 1, 2 }, new int[] { 1, 2 })]
        [InlineData(new int[] { 1, 1, 2, 3, 3 }, new int[] { 1, 2, 3 })]
        public void Test(int[] nums, int[] expected)
        {
            var result = _solution.DeleteDuplicates(nums.ToLinkedList());

            result.ToArray().Should().BeEquivalentTo(expected);
        }
    }
}
