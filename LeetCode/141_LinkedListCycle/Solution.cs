namespace LeetCode._141_LinkedListCycle
{
    public class Solution
    {
        public bool HasCycle(ListNode head)
        {
            var fast = head;
            var slow = head;

            while (slow != null && fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
