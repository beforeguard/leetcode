using LeetCode._66_PlusOne;

namespace LeetCode.Tests._66_PlusOne
{
    public class SolutionTests
    {
        private readonly Solution _solution = new();

        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 4 })]
        [InlineData(new int[] { 4, 3, 2, 1 }, new int[] { 4, 3, 2, 2 })]
        [InlineData(new int[] { 9 }, new int[] { 1, 0 })]
        public void Test(int[] digits, int[] expected)
        {
            _solution.PlusOne(digits).Should().BeEquivalentTo(expected);
        }
    }
}
