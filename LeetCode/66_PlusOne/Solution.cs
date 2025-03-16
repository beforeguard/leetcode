namespace LeetCode._66_PlusOne
{
    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            var index = digits.Length - 1;
            var carryOne = false;

            do
            {
                carryOne = AddOneAtIndex(digits, index--);
            } while (carryOne && index >= 0);

            if (carryOne)
            {
                var result = new int[digits.Length + 1];
                result[0] = 1;
                Array.Copy(digits, 0, result, 1, digits.Length);

                return result;
            }
            else
            {
                return digits;
            }
        }

        private bool AddOneAtIndex(int[] digits, int index)
        {
            if (digits[index] == 9)
            {
                digits[index] = 0;
                return true;
            }
            else
            {
                digits[index]++;
                return false;
            }
        }
    }
}