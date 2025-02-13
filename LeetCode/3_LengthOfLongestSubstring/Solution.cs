namespace LeetCode._3_LengthOfLongestSubstring
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            var hashSet = new HashSet<char>();

            var result = 0;

            for (var i = 0; i < s.Length; i++)
            {
                hashSet.Clear();
                var substringLength = 0;
                var j = i;
                while (j < s.Length && !hashSet.Contains(s[j]))
                {
                    hashSet.Add(s[j++]);
                    substringLength++;
                }

                if (substringLength > result)
                {
                    result = substringLength;
                }
            }

            return result;
        }
    }
}
