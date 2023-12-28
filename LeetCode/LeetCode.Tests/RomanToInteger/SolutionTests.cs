using LeetCode.RomanToInteger;

namespace LeetCode.Tests.RomanToInteger
{
    /*
     * Example 1:

Input: s = "III"
Output: 3
Explanation: III = 3.
Example 2:

Input: s = "LVIII"
Output: 58
Explanation: L = 50, V= 5, III = 3.
Example 3:

Input: s = "MCMXCIV"
Output: 1994
Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
     */

    public class SolutionTests
    {
        private readonly Solution _solution = new();

        [Theory]
        [InlineData("III", 3)]
        [InlineData("LVIII", 58)]
        [InlineData("MCMXCIV", 1994)]
        public void Test(string input, int expected)
        {
            _solution.RomanToInt(input).Should().Be(expected);
        }
    }
}
