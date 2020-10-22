using System.Collections.Generic;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #1757
    /// BFS
    /// </summary>
    public class ListOfDepthlcci : IExecute
    {
        public void Execute()
        {
            TreeNode tree = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(4)
                    {
                        left = new TreeNode(8)
                    },
                    right = new TreeNode(5)
                },
                right = new TreeNode(3)
                {
                    right = new TreeNode(8)
                },
            };
            var res = ListOfDepth(tree);
            PrintResult(res);
        }

        void PrintResult(ListNode[] nodes)
        {
            System.Console.WriteLine("Leetcode #109:");
            foreach (var head in nodes)
            {
                head.PrintOut();
                System.Console.WriteLine();
            }
        }

        public ListNode[] ListOfDepth(TreeNode tree)
        {
            if (tree == null)
            {
                return null;
            }
            Queue<TreeNode> sta = new Queue<TreeNode>();
            List<ListNode> res = new List<ListNode>();
            sta.Enqueue(tree);
            int curLevel = 1;
            while (sta.Count > 0)
            {
                ListNode pre = new ListNode(-1);
                ListNode cur = pre;
                for (int i = 0; i < curLevel; i++)
                {
                    tree = sta.Dequeue();
                    cur.next = new ListNode(tree.val);
                    cur = cur.next;
                    if (tree.left != null)
                    {
                        sta.Enqueue(tree.left);
                    }
                    if (tree.right != null)
                    {
                        sta.Enqueue(tree.right);
                    }
                }
                curLevel = sta.Count;
                res.Add(pre.next);
            }
            return res.ToArray();
        }
    }
}