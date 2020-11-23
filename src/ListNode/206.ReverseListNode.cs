using System.Collections.Generic;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #148
    /// </summary>
    public class ReverseListNode : IExecute
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
            var res = ReverseList(head);
            PrintResult(res);
        }

        void PrintResult(ListNode res)
        {
            System.Console.WriteLine("Leetcode #148:");
            res.PrintOut();
        }

        public ListNode ReverseList(ListNode head)
        {
            ListNode pre = null;
            ListNode cur = head;
            while (cur != null)
            {
                ListNode nextTemp = cur.next;
                cur.next = pre;
                pre = cur;
                cur = nextTemp;
            }
            return pre;
        }
    }
}