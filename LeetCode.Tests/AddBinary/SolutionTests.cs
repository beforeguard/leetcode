using LeetCode.AddBinary;

namespace LeetCode.Tests.AddBinary
{
    public class SolutionTests
    {
        private Solution _solution = new();

        [Theory]
        [InlineData("1111", "1111", "11110")]
        [InlineData("11", "1", "100")]
        [InlineData("1010", "1011", "10101")]
        public void Tests(string a, string b, string expected)
        {
            _solution.AddBinary(a, b).Should().Be(expected);
        }
    }
}