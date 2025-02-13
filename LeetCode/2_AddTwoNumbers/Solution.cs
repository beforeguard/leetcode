namespace LeetCode._2_AddTwoNumbers
{
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode head = null;
            ListNode prev = null;

            var current1 = l1;
            var current2 = l2;
            var carry = 0;

            while (current1 != null || current2 != null || carry > 0)
            {
                var val1 = current1 != null ? current1.val : 0;
                var val2 = current2 != null ? current2.val : 0;

                var val = (val1 + val2 + carry) % 10;
                carry = (val1 + val2 + carry > 9) ? 1 : 0;

                var node = new ListNode { val = val };
                if (prev != null)
                {
                    prev.next = node;
                }
                if (head == null)
                {
                    head = node;
                }

                prev = node;
                current1 = current1?.next;
                current2 = current2?.next;
            }

            return head;
        }
    }
}
