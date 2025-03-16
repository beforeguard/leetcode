namespace LeetCode._83_RemoveDuplicatesFromSortedList
{
    public class Solution
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null)
            {
                return head;
            }

            var current  = head;
            do
            {
                current = DeleteDuplicatesForNode(current);
            } while (current != null);

            return head;
        }

        private ListNode DeleteDuplicatesForNode(ListNode node)
        {
            var current = node;

            while (current != null && current.val == node.val)
            {
                current = current.next;
            }

            node.next = current;

            return current;
        }
    }
}
