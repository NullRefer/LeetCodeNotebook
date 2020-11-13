using System.Collections.Generic;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #328
    /// </summary>
    public class OddEvenLinkedList : IExecute
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
                        }
                    }
                }
            };
            var res = OddEvenList(head);
            PrintResult(res);
        }

        void PrintResult(ListNode res)
        {
            System.Console.WriteLine("Leetcode #328:");
            res.PrintOut();
        }

        public ListNode OddEvenList(ListNode head)
        {
        if (head == null || head.next == null)
        {
            return head;
        }
        ListNode preOdd = head, preEven = head.next;
        ListNode odd = head, even = head.next;
        while (even != null && even.next != null)
        {
            odd.next = even.next;
            odd = odd.next;
            if (odd == null)
            {
                even.next = null;
                even = null; 
            }
            else
            {
                even.next = odd.next;
                even = even.next;
            }
        }
        odd.next = preEven;
        return preOdd;
        }
    }
}