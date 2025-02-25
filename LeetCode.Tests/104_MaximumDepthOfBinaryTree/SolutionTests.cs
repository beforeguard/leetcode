using LeetCode._104_MaximumDepthOfBinaryTree;

namespace LeetCode.Tests._104_MaximumDepthOfBinaryTree
{
    public class SolutionTests
    {
        private readonly Solution _solution = new();

        public static TheoryData<int?[], int> TestData => new TheoryData<int?[], int>
        {
            { new int?[] { 3, 9, 20, null, null, 15, 7 }, 3 },
            { new int?[] { 1, null, 2 }, 2 },
        };

        [Theory]
        [MemberData(nameof(TestData))]
        public void Test(int?[] testData, int expected)
        {
            var result = _solution.MaxDepth(testData.ToBinaryTree());

            result.Should().Be(expected);
        }
    }
}
