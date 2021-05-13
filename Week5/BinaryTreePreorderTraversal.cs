using System;

namespace BinaryTreePreorderTraversal
{
    // 144. (Easy)
    public class Solution
    {
        // Given the root of a binary tree, return the preorder traversal of its nodes' values.

        // Input: root = [1,null,2,3], Output: [1,2,3]
        // Input: root = [1,null,2], Output: [1,2]

        public IList<int> PreorderTraversal(TreeNode root)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            List<int> list = new List<int>();

            stack.Push(root);

            while (stack.Count() > 0)
            {
                TreeNode current = stack.Pop();
                if (current != null)
                {
                    list.Add(current.val);
                    stack.Push(current.right);
                    stack.Push(current.left);
                }
            }

            return list;
        }
    }
}
