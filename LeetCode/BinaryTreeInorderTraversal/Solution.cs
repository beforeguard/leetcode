namespace LeetCode.BinaryTreeInorderTraversal
{
    public class Solution
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            var result = new List<int>();
            InorderTraversal(result, root);
            return result;
        }

        private void InorderTraversal(IList<int> nums, TreeNode current)
        {
            if (current == null)
            {
                return;
            }

            InorderTraversal(nums, current.left);
            nums.Add(current.val);
            InorderTraversal(nums, current.right);
        }
    }
}
