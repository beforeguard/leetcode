using System.Runtime.CompilerServices;

namespace LeetCode.Tests
{
    internal static class ArrayExtensions
    {
        internal static ListNode ToLinkedList(this int[] numbers, int cycleIndex = -1)
        {
            ListNode head = null;
            ListNode tail = null;

            for (var i = numbers.Length - 1; i >= 0; i--)
            {
                head = new ListNode(numbers[i], head);

                if (tail == null)
                {
                    tail = head;
                }

                if (i == cycleIndex)
                {
                    tail.next = head;
                }
            }

            return head;
        }

        internal static (ListNode headA, ListNode headB) ToIntersectingLinkedList(this int[] numbersA, int[] numbersB, int intersectVal, int skipA, int skipB)
        {
            ListNode tail = null;
            for (var i = numbersA.Length - 1; i > skipA; i--)
            {
                tail = new ListNode(numbersA[i], tail);
            }

            var intersectNode = new ListNode(intersectVal, tail);

            ListNode tailA = null;
            for (var i = skipA - 1; i >= 0; i--)
            {
                tailA = new ListNode(numbersA[i], tailA == null ? intersectNode : tailA);
            }

            ListNode tailB = null;
            for (var i = skipB - 1; i >= 0; i--)
            {
                tailB = new ListNode(numbersB[i], tailB == null ? intersectNode : tailB);
            }

            return new(tailA, tailB);
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
