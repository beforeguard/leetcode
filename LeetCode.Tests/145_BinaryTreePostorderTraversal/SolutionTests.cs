using LeetCode._145_BinaryTreePostorderTraversal;

namespace LeetCode.Tests._145_BinaryTreePostorderTraversal
{
    public class SolutionTests
    {
        private readonly Solution _solution = new();

        public static TheoryData<int?[], int[]> TestData => new TheoryData<int?[], int[]>
        {
            { new int?[] { 1, null ,2 , 3 }, new int[] { 3, 2, 1 } },
            { new int?[] { 1, 2, 3, 4, 5, null, 8, null, null, 6, 7, 9 }, new int[] { 4, 6, 7, 5, 2, 9, 8, 3, 1 } },
            { new int?[] {}, new int[] {} },
            { new int?[] { 1 }, new int[] { 1 } },
        };

        [Theory]
        [MemberData(nameof(TestData))]
        public void Fact(int?[] nums, int[] expected)
        {
            _solution.PostorderTraversal(nums.ToBinaryTree()).Should().BeEquivalentTo(expected);
        }
    }
}
