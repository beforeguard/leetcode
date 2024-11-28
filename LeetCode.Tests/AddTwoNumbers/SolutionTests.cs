using LeetCode.AddTwoNumbers;

namespace LeetCode.Tests.AddTwoNumbers
{
    public class SolutionTests
    {
        private Solution _solution = new();

        [Theory]
        [InlineData(new[] { 0 }, new[] { 0 }, new[] { 0 })]
        [InlineData(new int[] { 2, 4, 3 }, new int[] { 5, 6, 4 }, new int[] { 7, 0, 8 })]
        [InlineData(new int[] { 2, 4, 9 }, new int[] { 5, 6, 4, 9 }, new int[] { 7, 0, 4, 0, 1 })]
        [InlineData(new int[] { 9, 9, 9, 9, 9, 9, 9 }, new int[] { 9, 9, 9, 9 }, new int[] { 8, 9, 9, 9, 0, 0, 0, 1 })]
        public void Test(int[] l1, int[] l2, int[] expected)
        {
            _solution
                .AddTwoNumbers(l1.ToLinkedList(), l2.ToLinkedList())
                .ToArray()
                .Should()
                .BeEquivalentTo(expected);
        }
    }
}
