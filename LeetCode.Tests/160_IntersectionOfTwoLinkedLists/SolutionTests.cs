using LeetCode._160_IntersectionOfTwoLinkedLists;

namespace LeetCode.Tests._160_IntersectionOfTwoLinkedLists
{
    public class SolutionTests
    {
        private readonly Solution _solution = new();

        [Theory]
        [InlineData(new int[] { 4, 1, 8, 4, 5 }, new int[] { 5, 6, 1, 8, 4, 5 }, 8, 2, 3)]
        [InlineData(new int[] { 1, 9, 1, 2, 4 }, new int[] { 3, 2, 4 }, 2, 3, 1)]
        [InlineData(new int[] { 2, 6, 4 }, new int[] { 1, 5 }, 0, 3, 2)]
        public void Test(int[] listA, int[] listB, int intersectVal, int skipA, int skipB)
        {
            var (headA, headB) = listA.ToIntersectingLinkedList(listB, intersectVal, skipA, skipB);

            var intersectNode = _solution.GetIntersectionNode(headA, headB);

            if (intersectVal == 0)
            {
                intersectNode.Should().NotBeNull();
            }
            else
            {
                intersectNode.val.Should().Be(intersectVal);
            }
        }
    }
}
