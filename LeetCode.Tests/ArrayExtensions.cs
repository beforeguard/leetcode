namespace LeetCode.Tests
{
    internal static class ArrayExtensions
    {
        internal static ListNode ToLinkedList(this int[] numbers)
        {
            ListNode listNode = null;

            for (var i = numbers.Length - 1; i >= 0; i--)
            {
                listNode = new ListNode(numbers[i], listNode);
            }

            return listNode;
        }

        internal static TreeNode ToBinaryTree(this int?[] numbers)
        {
            TreeNode treeNode = null;

            // TODO: Add implementation.

            return treeNode;
        }
    }
}
