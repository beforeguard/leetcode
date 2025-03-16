using LeetCode._21_MergeTwoSortedLists;

namespace LeetCode.Tests._21_MergeTwoSortedLists
{
    public class SolutionTests
    {
        private readonly Solution _solution = new();

        [Theory]
        [InlineData(new int[] { 1, 2, 4 }, new int[] { 1, 3, 4 }, new int[] { 1, 1, 2, 3, 4, 4 })]
        [InlineData(new int[0], new int[0], new int[0])]
        [InlineData(new int[0], new int[] { 0 }, new int[] { 0 })]
        public void Test(int[] numbers1, int[] numbers2, int[] expected)
        {
            var mergedList = _solution.MergeTwoLists(
                numbers1.ToLinkedList(),
                numbers2.ToLinkedList());

            mergedList.ToArray().Should().BeEquivalentTo(expected);
        }
    }
}
