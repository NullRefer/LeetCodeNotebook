using System;
using System.Collections.Generic;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #144
    /// </summary>
    public class BTPreOrder : IExecute
    {
        public void Execute()
        {
            TreeNode root = new TreeNode(1)
            {
                left = new TreeNode(4)
                {
                    left = new TreeNode(5)
                },
                right = new TreeNode(2)
                {
                    left = new TreeNode(3)
                }
            };
            var res = PreorderTraversal(root);
            PrintResult(res);
        }

        void PrintResult(IList<int> res)
        {
            System.Console.WriteLine("Leetcode #144:");
            System.Console.WriteLine(string.Join(",", res));
        }

        public IList<int> PreorderTraversal(TreeNode root)
        {
            IList<int> res = new List<int>();
            Action<TreeNode> action = root => res.Add(root.val);
            root.PreOrderTravel(action);
            return res;
        }
    }
}