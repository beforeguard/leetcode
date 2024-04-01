using LeetCode.MergeTwoSortedLists;

namespace LeetCode.Tests.MergeTwoSortedLists
{
    public class SolutionTests
    {
        private readonly Solution _solution = new();

        [Theory]
        [InlineData(new int[] { 1, 2, 4 }, new int[] { 1, 3, 4 }, new int[] { 1, 1, 2, 3, 4, 4 })]
        [InlineData(new int[0], new int[0], new int[0])]
        [InlineData(new int[0], new int[] { 0 }, new int[] { 0 })]
        public void Test(int[] numbers1, int[] numbers2, int[] expected)
        {
            var mergedList = _solution.MergeTwoLists(
                ArrayToLinkedList(numbers1),
                ArrayToLinkedList(numbers2));

            LinkedListToArray(mergedList).Should().BeEquivalentTo(expected);
        }

        internal ListNode ArrayToLinkedList(int[] numbers)
        {
            ListNode listNode = null;

            for (var i = numbers.Length - 1; i >= 0; i--)
            {
                listNode = new ListNode(numbers[i], listNode);
            }

            return listNode;
        }

        internal int[] LinkedListToArray(ListNode listNode)
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
