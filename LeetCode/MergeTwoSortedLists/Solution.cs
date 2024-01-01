namespace LeetCode.MergeTwoSortedLists
{
    public class Solution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode head = null;
            ListNode next = null;
            ListNode prev = null;

            while (list1 != null || list2 != null)
            {
                int val;
                if (list1 == null)
                {
                    val = list2.val;
                    list2 = list2.next;
                }
                else if (list2 == null)
                {
                    val = list1.val;
                    list1 = list1.next;
                }
                else
                {
                    if (list1.val < list2.val)
                    {
                        val = list1.val;
                        list1 = list1.next;
                    }
                    else
                    {
                        val = list2.val;
                        list2 = list2.next;
                    }
                }

                next = new ListNode(val, null);
                
                if (prev != null)
                {
                    prev.next = next;
                }

                if (head == null)
                {
                    head = next;
                }

                prev = next;
            }

            return head;
        }
    }
}
