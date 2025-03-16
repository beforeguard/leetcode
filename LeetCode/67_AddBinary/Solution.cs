using System.Text;

namespace LeetCode._67_AddBinary
{
    public class Solution
    {
        public string AddBinary(string a, string b)
        {
            var longer = a.Length > b.Length ? a : b;
            var shorter = a.Length > b.Length ? b : a;
            var offset = longer.Length - shorter.Length;

            var result = new StringBuilder(longer);
            char? carry = null;
            for (var i = shorter.Length - 1; i >= 0; i--)
            {
                if (shorter[i] == '1' && longer[i + offset] == '1')
                {
                    result[i + offset] = carry.HasValue ? '1' : '0';
                    carry = '1';
                }
                else if (carry.HasValue && (shorter[i] == '1' || longer[i + offset] == '1'))
                {
                    result[i + offset] = '0';
                    carry = '1';
                }
                else if (carry.HasValue)
                {
                    result[i + offset] = '1';
                    carry = null;
                }
                else
                {
                    result[i + offset] = shorter[i] == '1' || longer[i + offset] == '1' ? '1' : '0';
                    carry = null;
                }
            }

            var index = offset - 1;
            while (carry.HasValue)
            {
                if (index < 0)
                {
                    result.Insert(0, carry.Value);
                    carry = null;
                }
                else
                {
                    if (carry.Value == '1' && result[index] == '1')
                    {
                        result[index] = '0';
                        carry = '1';
                    }
                    else
                    {
                        result[index] = carry.Value == '1' || result[index] == '1' ? '1' : '0';
                        carry = null;
                    }
                }

                index--;
            }

            return result.ToString();
        }
    }
}
