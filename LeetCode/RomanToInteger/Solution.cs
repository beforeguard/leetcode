namespace LeetCode.RomanToInteger
{
    public class Solution
    {
        private readonly string _subtractionChars = "IXC";
        private readonly Dictionary<string, int> _map = new Dictionary<string, int>()
        {
            { "I", 1 },
            { "IV", 4 },
            { "V", 5 },
            { "IX", 9 },
            { "X", 10 },
            { "XL", 40 },
            { "L", 50 },
            { "XC", 90 },
            { "C", 100 },
            { "CD", 400 },
            { "D", 500 },
            { "CM", 900 },
            { "M", 1000},
        };

        public int RomanToInt(string s)
        {
            var result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                var c = s[i].ToString();

                if (_subtractionChars.Contains(c))
                {
                    if (i + 1 <= s.Length - 1 && _map.ContainsKey($"{c}{s[i + 1]}"))
                    {
                        c += s[i + 1];
                        i++;
                    }
                }

                result += _map[c];
            }

            return result;
        }
    }
}
