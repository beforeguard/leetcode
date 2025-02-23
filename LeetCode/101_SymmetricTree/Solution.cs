namespace LeetCode._101_SymmetricTree
{
    public class Solution
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null || root.left == null && root.right == null)
            {
                return true;
            }
            else
            {
                return AreNodesEqual(root.left, root.right);
            }
        }

        private bool AreNodesEqual(TreeNode leftNode, TreeNode rightNode)
        {
            return (leftNode == null && rightNode == null) ||
                (leftNode?.val == rightNode?.val) &&
                AreNodesEqual(leftNode.left, rightNode.right) &&
                AreNodesEqual(leftNode.right, rightNode.left);
        }
    }
}
