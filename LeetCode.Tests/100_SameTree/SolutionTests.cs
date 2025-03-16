using LeetCode._100_SameTree;

namespace LeetCode.Tests._100_SameTree
{
    public class SolutionTests
    {
        private readonly Solution _solution = new();

        public static TheoryData<int?[], int?[], bool> TestData => new TheoryData<int?[], int?[], bool>
        {
            { new int?[] { 1,2,3 }, new int?[] { 1, 2, 3 }, true },
            { new int?[] { 1,2 }, new int?[] { 1, null, 2 }, false },
            { new int?[] { 1,2, 1 }, new int?[] { 1, 1, 2 }, false },
            { new int?[] { 0, -5 }, new int?[] { 0, -8 }, false },
            { new int?[] { 10, 5, 15 }, new int?[] { 10, 5, null, null, 15 }, false },
            { new int?[] { 1, null, 1 }, new int?[] { 1, null, 1 }, true },
            { new int?[] { 1 }, new int?[] { 1, null, 2 }, false },
            { new int?[] { 12, null, -60 }, new int?[] { 12, null, 72 }, false },
            { new int?[] { 1, 1 }, new int?[] { 1, null, 1 }, false },
        };

        [Theory]
        [MemberData(nameof(TestData))]
        public void Test(int?[] p, int?[] q, bool expected)
        {
            var result = _solution.IsSameTree(p.ToBinaryTree(), q.ToBinaryTree());

            result.Should().Be(expected);
        }
    }
}
