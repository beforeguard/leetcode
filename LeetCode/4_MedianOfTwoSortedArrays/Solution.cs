using System.Linq;

namespace LeetCode._4_MedianOfTwoSortedArrays
{
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var nums = nums1.Concat(nums2).Order();
            var numsLength = nums1.Length + nums2.Length;
            var middleIndex = numsLength / 2;

            if (numsLength % 2 == 1 || numsLength == 1)
            {
                return nums.ElementAt(middleIndex);
            }
            else
            {
                return (nums.ElementAt(middleIndex) +
                    nums.ElementAt(middleIndex - 1)) / 2.0;
            }
        }
    }
}
