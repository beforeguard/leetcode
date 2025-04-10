﻿using LeetCode._3_LengthOfLongestSubstring;

namespace LeetCode.Tests._3_LengthOfLongestSubstring
{
    public class SolutionTests
    {
        private readonly Solution _solution = new();

        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        public void Test(string input, int expected)
        {
            _solution.LengthOfLongestSubstring(input).Should().Be(expected);
        }
    }
}
