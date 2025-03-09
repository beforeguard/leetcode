using LeetCode._141_LinkedListCycle;

namespace LeetCode.Tests._141_LinkedListCycle
{
    public class SolutionTests
    {
        private readonly Solution _solution = new();

        [Theory]
        [InlineData(new int[] { 3, 2, 0, -4 }, 1, true)]
        [InlineData(new int[] { 1, 2 }, 0, true)]
        [InlineData(new int[] { 1 }, -1, false)]
        public void Test(int[] nums, int cycleIndex, bool expected)
        {
            _solution.HasCycle(nums.ToLinkedList(cycleIndex)).Should().Be(expected);
        }
    }
}
