using System.Collections.Generic;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #129
    /// </summary>
    public class SumRootToLeaf : IExecute
    {
        public void Execute()
        {
            TreeNode t1 = new TreeNode(4)
            {
                left = new TreeNode(9)
                {
                    left = new TreeNode(5),
                    right = new TreeNode(1)
                },
                right = new TreeNode(0),
            };
            var res = SumNumbers(t1);
            PrintResult(res);
        }

        void PrintResult(int res)
        {
            System.Console.WriteLine("Leetcode #129:");
            System.Console.WriteLine(res);
        }

        private int sum;
        public int SumNumbers(TreeNode root)
        {
            sum = 0;
            SumChildTree(root, 0);
            return sum;
        }

        private void SumChildTree(TreeNode root, int val)
        {
            if (root == null)
            {
                return;
            }

            int k = val * 10 + root.val;
            if (root.left == null && root.right == null)
            {
                sum += k;
            }
            SumChildTree(root.left, k);
            SumChildTree(root.right, k);
        }
    }
}