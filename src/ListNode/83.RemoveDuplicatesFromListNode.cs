using System.Collections.Generic;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #83
    /// </summary>
    public class RemoveDuplicatesFromListNode : IExecute
    {
        public void Execute()
        {
            ListNode head = new ListNode(1)
            {
                next = new ListNode(1)
                {
                    next = new ListNode(2)
                    {
                        next = new ListNode(3)
                        {
                            next = new ListNode(3)
                            {
                                next = new ListNode(3)
                            }
                        }
                    }
                }
            };
            var res = DeleteDuplicates(head);
            PrintResult(res);
        }

        void PrintResult(ListNode res)
        {
            System.Console.WriteLine("Leetcode #83:");
            res.PrintOut();
        }

        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            ListNode cur = head, pre = head;
            while (cur != null && cur.next != null)
            {
                cur = cur.next;
                while (cur != null && cur.val == pre.val)
                {
                    cur = cur.next;
                }
                pre.next = cur;
                pre = cur;
            }
            return head;
        }
    }
}