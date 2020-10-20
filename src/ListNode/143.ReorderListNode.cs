using System.Collections.Generic;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #143
    /// </summary>
    public class ReorderListNode : IExecute
    {
        public void Execute()
        {
            ListNode head = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(5)
                            {
                                next = new ListNode(6)
                            }
                        }
                    }
                }
            };
            ReorderList(head);
            PrintResult(head);
        }

        void PrintResult(ListNode head)
        {
            System.Console.WriteLine("Leetcode #143:");
            while (head != null)
            {
                System.Console.WriteLine(head.val);
                head = head.next;
            }
        }

        public void ReorderList(ListNode head)
        {
            if (head == null)
            {
                return;
            }
            List<ListNode> nodes = new List<ListNode>();
            while (head != null)
            {
                nodes.Add(head);
                head = head.next;
            }
            int left = 0, right = nodes.Count - 1;
            while (left < right){
                var tmp = nodes[left].next;
                nodes[left].next = nodes[right];
                nodes[right].next = tmp;
                left += 1;
                right -= 1;
            }
            nodes[left].next = null;
            head = nodes[0];
        }
    }
}