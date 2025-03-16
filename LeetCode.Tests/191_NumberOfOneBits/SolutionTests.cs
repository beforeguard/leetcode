using LeetCode._191_NumberOfOneBits;

namespace LeetCode.Tests._191_NumberOfOneBits
{
    public class SolutionTests
    {
        private Solution _solution = new();

        [Theory]
        [InlineData(11, 3)]
        [InlineData(128, 1)]
        [InlineData(2147483645, 30)]
        public void Test(int num, int expected)
        {
            _solution.HammingWeight(num).Should().Be(expected);
        }
    }
}
