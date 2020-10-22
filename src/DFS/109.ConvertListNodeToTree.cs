using System.Collections.Generic;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #109
    /// </summary>
    public class ConvertListNodeToTree : IExecute
    {
        public void Execute()
        {
            ListNode head = new ListNode(-10)
            {
                next = new ListNode(-3)
                {
                    next = new ListNode(0)
                    {
                        next = new ListNode(5)
                        {
                            next = new ListNode(9)
                        }
                    }
                }
            };
            var res = SortedListToBST(head);
            PrintResult(res);
        }

        void PrintResult(TreeNode root)
        {
            System.Console.WriteLine("Leetcode #109:");
            root.PrintOut();
        }

        public TreeNode SortedListToBST(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            List<ListNode> nodes = new List<ListNode>();
            while (head != null)
            {
                nodes.Add(head);
                head = head.next;
            }
            if (nodes.Count >= 3)
            {
                ListNode mid = nodes[nodes.Count / 2];
                TreeNode root = new TreeNode(mid.val);
                nodes[nodes.Count / 2 - 1].next = null;
                root.left = SortedListToBST(nodes[0]);
                mid.next = null;
                root.right = SortedListToBST(nodes[nodes.Count / 2 + 1]);
                return root;
            }
            else if (nodes.Count == 2)
            {
                return new TreeNode(nodes[1].val)
                {
                    left = new TreeNode(nodes[0].val)
                };
            }
            else
            {
                return new TreeNode(nodes[0].val);
            }
        }
    }
}