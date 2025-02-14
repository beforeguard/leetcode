namespace LeetCode.MergeSortedArray
{
    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var i = m + n - 1;
            m--;
            n--;

            while (i >= 0)
            {
                if (m >= 0 && n < 0)
                {
                    nums1[i] = nums1[m--];
                }
                else if (m < 0 && n >= 0)
                {
                    nums1[i] = nums2[n--];
                }
                else if (nums1[m] > nums2[n])
                {
                    nums1[i] = nums1[m--];
                }
                else
                {
                    nums1[i] = nums2[n--];
                }

                i--;
            }
        }
    }
}
