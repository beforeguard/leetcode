namespace LeetCode.PalindromeNumber
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }
            if (x >= 0 && x < 10)
            {
                return true;
            }
            if (x % 10 == 0)
            {
                return false;
            }

            var reversed = 0;
            var unreversed = x;

            while (x != 0)
            {
                var digit = x % 10;
                reversed = (reversed * 10) + digit;
                x /= 10;
            }

            return reversed == unreversed;
        }
    }
}
