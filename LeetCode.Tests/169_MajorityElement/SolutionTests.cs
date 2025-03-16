using LeetCode._169_MajorityElement;

namespace LeetCode.Tests._169_MajorityElement
{
    public class SolutionTests
    {
        private readonly Solution _solution = new();

        [Theory]
        [InlineData(new int[] { 3, 2, 3 }, 3)]
        [InlineData(new int[] { 2, 2, 1, 1, 1, 2, 2 }, 2)]
        public void Test(int[] nums, int expected)
        {
            _solution.MajorityElement(nums).Should().Be(expected);
        }
    }
}
