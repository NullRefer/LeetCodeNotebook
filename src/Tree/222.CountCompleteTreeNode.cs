using System.Collections.Generic;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #222
    /// </summary>
    public class CountCompleteTreeNode : IExecute
    {
        public void Execute()
        {
            TreeNode root = new TreeNode()
            {
                val = 1,
                left = new TreeNode()
                {
                    val = 2,
                    left = new TreeNode()
                    {
                        val = 4,
                    },
                    right = new TreeNode()
                    {
                        val = 5
                    }
                },
                right = new TreeNode()
                {
                    val = 3,
                    left = new TreeNode(6)
                }
            };
            var res = CountNodes(root);
            PrintResult(res);
        }

        void PrintResult(int res)
        {
            System.Console.WriteLine("Leetcode #222:");
            System.Console.WriteLine(res);
        }

        public int CountNodes(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            Queue<TreeNode> que = new Queue<TreeNode>();
            int res = 0;
            que.Enqueue(root);
            while (que.Count != 0)
            {
                root = que.Dequeue();
                res += 1;
                if (root.left != null)
                {
                    que.Enqueue(root.left);
                }
                if (root.right != null)
                {
                    que.Enqueue(root.right);
                }
            }
            return res;
        }
    }
}