using System.Collections.Generic;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #112
    /// </summary>
    public class PathSum : IExecute
    {
        public void Execute()
        {
            TreeNode root = new TreeNode(5)
            {
                left = new TreeNode(4)
                {
                    left = new TreeNode(11)
                    {
                        left = new TreeNode(7),
                        right = new TreeNode(2),
                    }
                },
                right = new TreeNode(8)
                {
                    left = new TreeNode(14),
                    right = new TreeNode(4)
                    {
                        right = new TreeNode(1)
                    }
                },
            };
            var res = HasPathSum(root, 22);
            PrintResult(res);
        }

        void PrintResult(bool res)
        {
            System.Console.WriteLine("Leetcode #112:");
            System.Console.WriteLine(res);
        }

        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null){
                return false;
            }

            sum -= root.val;
            if (root.left == null && root.right == null){
                return sum == 0;
            }
            return HasPathSum(root.left, sum) || HasPathSum(root.right, sum);
        }
    }
}