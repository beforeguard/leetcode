using LeetCode._144_BinaryTreePreorderTraversal;

namespace LeetCode.Tests._144_BinaryTreePreorderTraversal
{
    public class SolutionTests
    {
        private readonly Solution _solution = new();

        public static TheoryData<int?[], int[]> TestData => new TheoryData<int?[], int[]>
        {
            { new int?[] { 1, null, 2, 3 }, new int[] { 1, 2, 3 } },
            { new int?[] { 1,2,3,4,5,null,8,null,null,6,7,9 }, new int[] { 1, 2, 4, 5, 6, 7, 3, 8, 9 } },
            { new int?[] {}, new int[] {} },
            { new int?[] { 1 }, new int[] { 1 } },
        };

        [Theory]
        [MemberData(nameof(TestData))]
        public void Fact(int?[] nums, int[] expected)
        {
            _solution.PreorderTraversal(nums.ToBinaryTree()).Should().BeEquivalentTo(expected);
        }
    }
}
