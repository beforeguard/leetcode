namespace LeetCode._160_IntersectionOfTwoLinkedLists
{
    public class Solution
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            var visitedA = new HashSet<ListNode>();

            var curr = headA;
            while (curr != null)
            {
                visitedA.Add(curr);
                curr = curr.next;
            }

            curr = headB;
            while (curr != null)
            {
                if (visitedA.Contains(curr))
                {
                    return curr;
                }
                curr = curr.next;
            }

            return null;
        }
    }
}
