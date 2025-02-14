using LeetCode._1_TwoSum;

namespace LeetCode.Tests.TwoSum
{
    public class SolutionTests
    {
        private readonly Solution _solution = new();

        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2})]
        [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        public void Test(int[] numbers, int target, int[] expected)
        {
            _solution.TwoSum(numbers, target).Should().BeEquivalentTo(expected);
        }
    }
}
