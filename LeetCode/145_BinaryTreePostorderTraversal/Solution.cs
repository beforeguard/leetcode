namespace LeetCode._145_BinaryTreePostorderTraversal
{
    public class Solution
    {
        public IList<int> PostorderTraversal(TreeNode root)
        {
            var result = new List<int>();
            PostorderTraversal(root, result);
            return result;
        }

        private void PostorderTraversal(TreeNode node, List<int> nums)
        {
            if (node == null)
            {
                return;
            }

            PostorderTraversal(node.left, nums);
            PostorderTraversal(node.right, nums);
            nums.Add(node.val);

        }
    }
}
