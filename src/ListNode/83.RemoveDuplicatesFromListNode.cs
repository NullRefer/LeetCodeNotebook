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
            ListNode pre = new ListNode(-16548);
            ListNode cur = pre;
            while (head != null)
            {
                if (cur.val != head.val)
                {
                    cur.next = new ListNode(head.val);
                    cur = cur.next;
                }
                head = head.next;
            }
            return pre.next;
        }
    }
}