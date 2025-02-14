﻿namespace LeetCode._35_SearchInsertPosition
{
    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            return BinarySearch(nums, target, low: 0, high: nums.Length - 1);
        }

        private int BinarySearch(int[] nums, int target, int low, int high)
        {
            if (high >= low)
            {
                var mid = low + (high - low) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] > target)
                {
                    return BinarySearch(nums, target, low, mid - 1);
                }
                else
                {
                    return BinarySearch(nums, target, mid + 1, high);
                }
            }
            else
            {
                return low;
            }
        }
    }
}
