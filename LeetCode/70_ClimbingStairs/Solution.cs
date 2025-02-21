namespace LeetCode._70_ClimbingStairs
{
    public class Solution
    {
        private readonly Dictionary<int, int> _memoization = new();

        public int ClimbStairs(int n) => Fib(n);

        private int Fib(int n)
        {
            if (n <= 2)
            {
                return n;
            }
            else if (_memoization.TryGetValue(n, out var storedVal))
            {
                return storedVal;
            }
            else
            {
                var val = Fib(n - 1) + Fib(n - 2);
                _memoization.Add(n, val);
                return val;
            }
        }
    }
}
