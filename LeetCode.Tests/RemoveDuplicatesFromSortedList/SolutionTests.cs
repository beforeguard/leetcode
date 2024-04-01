using LeetCode.RemoveDuplicatesFromSortedList;

namespace LeetCode.Tests.RemoveDuplicatesFromSortedList
{
    public class SolutionTests
    {
        private readonly Solution _solution = new();

        [Theory]
        [InlineData(new int[] { 1, 1, 2 }, new int[] { 1, 2 })]
        [InlineData(new int[] { 1, 1, 2, 3, 3 }, new int[] { 1, 2, 3 })]
        public void Test(int[] nums, int[] expected)
        {
            var result = _solution.DeleteDuplicates(ArrayToLinkedList(nums));

            LinkedListToArray(result).Should().BeEquivalentTo(expected);
        }

        private ListNode ArrayToLinkedList(int[] numbers)
        {
            ListNode listNode = null;

            for (var i = numbers.Length - 1; i >= 0; i--)
            {
                listNode = new ListNode(numbers[i], listNode);
            }

            return listNode;
        }

        private int[] LinkedListToArray(ListNode listNode)
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
