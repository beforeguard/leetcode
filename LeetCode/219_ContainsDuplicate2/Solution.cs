namespace LeetCode._219_ContainsDuplicate2
{
    public class Solution
    {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var dict = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                if (dict.TryGetValue(nums[i], out var lastIndex))
                {
                    if (Math.Abs(i - lastIndex) <= k)
                    {
                        return true;
                    }
                    else
                    {
                        dict[nums[i]] = i;
                    }
                }
                else
                {
                    dict.Add(nums[i], i);
                }
            }

            return false;
        }
    }
}
