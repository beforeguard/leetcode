namespace LeetCode.Tests
{
    internal static class ListNodeExtensions
    {
        internal static int[] ToArray(this ListNode listNode)
        {
            if (listNode == null)
            {
                return [];
            }

            var list = new List<int>();

            while (listNode != null)
            {
                list.Add(listNode.val);
                listNode = listNode.next;
            }

            return list.ToArray();
        }
    }
}
