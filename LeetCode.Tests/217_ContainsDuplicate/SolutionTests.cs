using LeetCode._217_ContainsDuplicate;

namespace LeetCode.Tests._217_ContainsDuplicate
{
    public class SolutionTests
    {
        private readonly Solution _solution = new();

        [Theory]
        [InlineData(new[] { 1, 2, 3, 1 }, true)]
        [InlineData(new[] { 1, 2, 3, 4 }, false)]
        [InlineData(new[] { 1, 2, 3, 1, 2, 3 }, true)]
        public void Test(int[] nums, bool expected)
        {
            _solution.ContainsDuplicate(nums).Should().Be(expected);
        }
    }
}
