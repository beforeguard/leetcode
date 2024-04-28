using System.Linq;

namespace LeetCode.Tests
{
    internal static class ArrayExtensions
    {
        internal static ListNode ToLinkedList(this int[] numbers)
        {
            ListNode head = null;

            for (var i = numbers.Length - 1; i >= 0; i--)
            {
                head = new ListNode(numbers[i], head);
            }

            return head;
        }

        internal static TreeNode ToBinaryTree(this int?[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return null;
            }

            var treeNodeQueue = new Queue<TreeNode>();
            var integerQueue = new Queue<int?>();
            for (var i = 1; i < numbers.Length; i++)
            {
                integerQueue.Enqueue(numbers[i]);
            }

            var treeNode = new TreeNode(numbers[0].Value);
            treeNodeQueue.Enqueue(treeNode);

            while (integerQueue.Any())
            {
                var leftValue = !integerQueue.Any() ? null : integerQueue.Dequeue();
                var rightValue = !integerQueue.Any() ? null : integerQueue.Dequeue();
                var current = treeNodeQueue.Dequeue();
                if (leftValue.HasValue)
                {
                    var left = new TreeNode(leftValue.Value);
                    current.left = left;
                    treeNodeQueue.Enqueue(left);
                }
                if (rightValue.HasValue)
                {
                    var right = new TreeNode(rightValue.Value);
                    current.right = right;
                    treeNodeQueue.Enqueue(right);
                }
            }
            return treeNode;
        }
    }
}
