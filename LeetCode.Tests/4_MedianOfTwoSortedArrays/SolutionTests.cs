using LeetCode._4_MedianOfTwoSortedArrays;

namespace LeetCode.Tests._4_MedianOfTwoSortedArrays
{
    public class SolutionTests
    {
        private readonly Solution _solution = new();

        [Theory]
        [InlineData(new int[0], new int[] { 1 }, 1)]
        [InlineData(new int[] { 1, 3 }, new int[] { 2 }, 2)]
        [InlineData(new int[] { 1, 2 }, new int[] { 3, 4 }, 2.5)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 }, 9)]
        public void Test(int[] nums1, int[] nums2, double expected)
        {
            _solution.FindMedianSortedArrays(nums1, nums2).Should().Be(expected);
        }
    }
}
