using System.Collections;

namespace LeetCode._191_NumberOfOneBits
{
    public class Solution
    {
        public int HammingWeight(int n)
        {
            var bitArray = new BitArray(new int[] { n });

            var result = 0;
            for (var i = 0; i < bitArray.Length; i++)
            {
                result += bitArray[i] ? 1 : 0;
            }
            return result;
        }
    }
}
