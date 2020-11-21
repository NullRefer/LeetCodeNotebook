using System.Collections.Generic;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #148
    /// </summary>
    public class SortList : IExecute
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
            var res = Sortlist(head);
            PrintResult(res);
        }

        void PrintResult(ListNode res)
        {
            System.Console.WriteLine("Leetcode #148:");
            res.PrintOut();
        }

        public ListNode Sortlist(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            ListNode slow = head, fast = head.next;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            ListNode rightPart = slow.next;
            slow.next = null;
            var left = Sortlist(head);
            var right = Sortlist(rightPart);
            return Merge(left, right);
        }

        public ListNode Merge(ListNode h1, ListNode h2)
        {
            ListNode pre = new ListNode(-1);
            ListNode cur = pre;
            while (h1 != null && h2 != null)
            {
                if (h1.val <= h2.val)
                {
                    cur.next = h1;
                    h1 = h1.next;
                }
                else
                {
                    cur.next = h2;
                    h2 = h2.next;
                }
                cur = cur.next;
            }
            if (h1 == null)
            {
                cur.next = h2;
            }
            else if (h2 == null)
            {
                cur.next = h1;
            }
            return pre.next;
        }
    }
}