namespace LeetCode._69_SquareRoot
{
    public class Solution
    {
        public int MySqrt(int x)
        {
            return MySqrt(x, 0, x / 2);
        }

        private int MySqrt(int x, int low, int high)
        {
            if (high >= low)
            {
                var mid = low + (high - 2) / 2;
                var midSqred = mid * mid;

                if (midSqred == x)
                {
                    return mid;
                }
                else if (midSqred > x)
                {
                    return MySqrt(x, low, mid - 1);
                }
                else
                {
                    return MySqrt(x, mid + 1, high);
                }
            }
            else
            {
                return low;
            }
        }
    }
}
