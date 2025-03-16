namespace LeetCode._20_ValidParentheses
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            const string openingParentheses = "{[(";
            const string closingParentheses = "}])";

            var stack = new Stack<char>();

            foreach (char c in s)
            {
                if (openingParentheses.Contains(c))
                {
                    stack.Push(c);
                }
                else if (closingParentheses.Contains(c))
                {
                    if (stack.TryPop(out var top))
                    {
                        if ((top != '{' && c == '}') ||
                            (top != '[' && c == ']') ||
                            (top != '(' && c == ')'))
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return stack.Count <= 0;
        }
    }
}
