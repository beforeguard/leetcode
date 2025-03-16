namespace LeetCode._14_LongestCommonPrefix
{
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
            {
                return string.Empty;
            }

            if (strs.Length == 1)
            {
                return strs[0];
            }

            var highestIndex = -1;

            for (var i = 0; i < strs[0].Length; i++)
            {
                if (strs.Skip(1).Any(s => i >= s.Length) ||
                    strs.Skip(1).Any(s => s[i] != strs[0][i]))
                {
                    break;
                }

                highestIndex = i;
            }

            return strs[0].Substring(0, highestIndex + 1);
        }
    }
}
