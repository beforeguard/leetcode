namespace LeetCode.LengthOfLastWord
{
    public class Solution
    {
        public int LengthOfLastWord(string s)
        {
            var lastIndex = s.Length - 1;
            while (lastIndex >= 0 && s[lastIndex] == ' ')
            {
                lastIndex--;
            }

            var firstIndex = lastIndex;
            while (firstIndex >= 0 && s[firstIndex] != ' ')
            {
                firstIndex--;
            }

            return lastIndex - firstIndex;
        }
    }
}