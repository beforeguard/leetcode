namespace LeetCode._26_RemoveDuplicatesFromSortedArray
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            var hashSet = new HashSet<int>();
            var replaceIndex = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (!hashSet.Contains(nums[i]))
                {
                    hashSet.Add(nums[i]);
                    SwapValuesAtIndices(nums, i, replaceIndex);
                    replaceIndex++;
                }
            }

            return hashSet.Count;
        }

        private void SwapValuesAtIndices(int[] nums, int index1, int index2)
        {
            if (nums[index1] == nums[index2])
            {
                return;
            }

            nums[index1] ^= nums[index2];
            nums[index2] ^= nums[index1];
            nums[index1] ^= nums[index2];
        }
    }
}
