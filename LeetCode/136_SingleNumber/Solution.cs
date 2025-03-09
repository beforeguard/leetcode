namespace LeetCode._136_SingleNumber
{
    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            var xor = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                xor ^= nums[i];
            }

            return xor;
        }
    }
}
