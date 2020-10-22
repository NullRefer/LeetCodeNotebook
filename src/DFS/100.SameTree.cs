using System.Collections.Generic;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #100
    /// </summary>
    public class SameTree : IExecute
    {
        public void Execute()
        {
            TreeNode t1 = new TreeNode(1)
            {
                left = new TreeNode(2),
                right = new TreeNode(3),
            };
            TreeNode t2 = new TreeNode(1)
            {
                left = new TreeNode(2),
                right = new TreeNode(3),
            };
            var res = IsSameTree(t1, t2);
            PrintResult(res);
        }

        void PrintResult(bool res)
        {
            System.Console.WriteLine("Leetcode #100:");
            System.Console.WriteLine(res);
        }

        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            // base case
            if (p == null && q == null)
            {
                return true;
            }
            else if (p == null || q == null)
            {
                return false;
            }
            if (p.val != q.val)
            {
                return false;
            }
            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
    }
}