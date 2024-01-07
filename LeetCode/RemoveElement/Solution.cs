namespace LeetCode.RemoveElement
{
    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            var replaceIndex = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    SwapValuesAtIndices(nums, i, replaceIndex);
                    replaceIndex++;
                }
            }

            return replaceIndex;
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
