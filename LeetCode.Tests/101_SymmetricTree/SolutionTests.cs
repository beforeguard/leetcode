using LeetCode._101_SymmetricTree;

namespace LeetCode.Tests._101_SymmetricTree
{
    public class SolutionTests
    {
        private readonly Solution _solution = new();

        public static TheoryData<int?[], bool> TestData => new TheoryData<int?[], bool>
        {
            { new int?[] { 1,2,2,3,4,4,3 }, true },
        };

        [Theory]
        [MemberData(nameof(TestData))]
        public void Test(int?[] testData, bool expected)
        {
            var result = _solution.IsSymmetric(testData.ToBinaryTree());

            result.Should().Be(expected);
        }
    }
}
