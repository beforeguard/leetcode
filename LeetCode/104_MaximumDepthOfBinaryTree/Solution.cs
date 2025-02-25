namespace LeetCode._104_MaximumDepthOfBinaryTree
{
    public class Solution
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                var leftHeight = MaxDepth(root.left);
                var rightHeight = MaxDepth(root.right);

                return Math.Max(leftHeight, rightHeight) + 1;
            }
        }
    }
}
