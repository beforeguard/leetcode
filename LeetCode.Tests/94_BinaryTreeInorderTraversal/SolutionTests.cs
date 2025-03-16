using LeetCode._94_BinaryTreeInorderTraversal;

namespace LeetCode.Tests._94_BinaryTreeInorderTraversal
{
    public class SolutionTests
    {
        private readonly Solution _solution = new();

        public static TheoryData<int?[], int[]> TestData => new TheoryData<int?[], int[]>
        {
            { new int?[] { 1, null, 2, 3 }, new int[] { 1, 3, 2 } },
            { new int?[0], new int[0] },
            { new int?[] { 1 }, new int[] { 1 } }
        };

        [Theory]
        [MemberData(nameof(TestData))]
        public void Test(int?[] testData, int[] expected)
        {
            var result = _solution.InorderTraversal(testData.ToBinaryTree());

            result.Should().BeEquivalentTo(expected);
        }
    }
}
