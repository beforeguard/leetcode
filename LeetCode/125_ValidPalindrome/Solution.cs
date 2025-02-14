using System.Text;

namespace LeetCode._125_ValidPalindrome
{
    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            var stringBuilder = new StringBuilder();

            foreach (var c in s)
            {
                if (char.IsDigit(c) || char.IsLetter(c))
                {
                    stringBuilder.Append(char.ToLower(c));
                }
            }

            return stringBuilder
                .ToString()
                .Equals(new string(stringBuilder.ToString().Reverse().ToArray()));
        }
    }
}
