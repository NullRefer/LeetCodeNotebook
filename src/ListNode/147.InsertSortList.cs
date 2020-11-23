using System.Collections.Generic;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #147
    /// </summary>
    public class InsertSortList : IExecute
    {
        public void Execute()
        {
            ListNode head = new ListNode(5)
            {
                next = new ListNode(4)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(2)
                        {
                            next = new ListNode(1)
                            {
                                next = new ListNode(6)
                            }
                        }
                    }
                }
            };
            var res = InsertionSortList(head);
            PrintResult(res);
        }

        void PrintResult(ListNode head)
        {
            System.Console.WriteLine("Leetcode #147:");
            head.PrintOut();
        }

        public ListNode InsertionSortList(ListNode head)
        {
            ListNode dummy = new ListNode(0), pre;
            dummy.next = head;

            while (head != null && head.next != null)
            {
                if (head.val <= head.next.val)
                {
                    head = head.next;
                    continue;
                }
                pre = dummy;

                while (pre.next.val < head.next.val) pre = pre.next;

                ListNode curr = head.next;
                head.next = curr.next;
                curr.next = pre.next;
                pre.next = curr;
            }
            return dummy.next;
        }
    }
}