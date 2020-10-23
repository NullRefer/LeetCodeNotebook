using System.Collections.Generic;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #876
    /// </summary>
    public class AddTwoNumbers2 : IExecute
    {
        public void Execute()
        {
            ListNode l1 = new ListNode(7)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(4)
                    {
                        next = new ListNode(3)
                    }
                }
            };
            ListNode l2 = new ListNode(5)
            {
                next = new ListNode(6)
                {
                    next = new ListNode(4)
                }
            };
            var res = AddTwoNumbers(l1, l2);
            PrintResult(res);
        }

        void PrintResult(ListNode res)
        {
            System.Console.WriteLine("Leetcode #445:");
            res.PrintOut();
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            Stack<int> sta1 = new Stack<int>();
            Stack<int> sta2 = new Stack<int>();
            while (l1 != null)
            {
                sta1.Push(l1.val);
                l1 = l1.next;
            }
            while (l2 != null)
            {
                sta2.Push(l2.val);
                l2 = l2.next;
            }
            Stack<int> resSta = new Stack<int>();
            int sum = 0, carry = 0;
            while (sta1.Count > 0 && sta2.Count > 0)
            {
                sum = sta1.Pop() + sta2.Pop() + carry;
                carry = sum / 10;
                resSta.Push(sum % 10);
            }
            while (sta1.Count > 0)
            {
                sum = sta1.Pop() + carry;
                carry = sum / 10;
                resSta.Push(sum % 10);
            }
            while (sta2.Count > 0)
            {
                sum = sta2.Pop() + carry;
                carry = sum / 10;
                resSta.Push(sum % 10);
            }
            if (carry == 1)
            {
                resSta.Push(1);
            }
            ListNode pre = new ListNode(-1);
            ListNode cur = pre;
            while (resSta.Count > 0)
            {
                cur.next = new ListNode(resSta.Pop());
                cur = cur.next;
            }
            return pre.next;
        }
    }
}