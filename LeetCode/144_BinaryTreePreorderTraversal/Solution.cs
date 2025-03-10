namespace LeetCode._144_BinaryTreePreorderTraversal
{
    public class Solution
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            var result = new List<int>();
            PreorderTraversal(root, result);
            return result;
        }

        private void PreorderTraversal(TreeNode node, List<int> nums)
        {
            if (node == null)
            {
                return;
            }

            nums.Add(node.val);
            PreorderTraversal(node.left, nums);
            PreorderTraversal(node.right, nums);
        }
    }
}
