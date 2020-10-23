namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #234
    /// Double Pointers
    /// </summary>
    public class PalindromeLinkedList : IExecute
    {
        public void Execute()
        {
            ListNode head = new ListNode(1)
            {
                next = new ListNode(2)
                {
                    next = new ListNode(3)
                    {
                        next = new ListNode(2)
                        {
                            next = new ListNode(1)
                        }
                    }
                }
            };
            var res = IsPalindrome(head);
            PrintResult(res);
        }

        void PrintResult(bool res)
        {
            System.Console.WriteLine("Leetcode #234:");
            System.Console.WriteLine(res);
        }

        public bool IsPalindrome(ListNode head)
        {
            if (head == null)
            {
                return false;
            }
            if (head.next == null)
            {
                return true;
            }
            ListNode fast = head;
            ListNode slow = head;
            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }
            ListNode next = null;
            if (fast == null)
            {
                next = slow;
            }
            else
            {
                next = slow.next;
            }
            next = Reverse(next);
            while (head != null && next != null)
            {
                if (head.val != next.val)
                {
                    return false;
                }
                head = head.next;
                next = next.next;
            }
            return true;
        }

        private ListNode Reverse(ListNode head)
        {
            if (head == null)
            {
                return null;
            }

            ListNode pre = null;
            ListNode cur = head;
            while (cur != null)
            {
                var tmp = cur.next;
                cur.next = pre;
                pre = cur;
                cur = tmp;
            }
            return pre;
        }
    }
}