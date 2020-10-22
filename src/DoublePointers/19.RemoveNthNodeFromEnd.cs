namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #19
    /// Double Pointers
    /// </summary>
    public class RemoveNthNode : IExecute
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
            var res = RemoveNthFromEnd(head, 5);
            PrintResult(res);
        }

        void PrintResult(ListNode head)
        {
            System.Console.WriteLine("Leetcode #19:");
            while (head != null)
            {
                System.Console.WriteLine(head.val);
                head = head.next;
            }
        }

        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head == null || n == 0)
            {
                return head;
            }

            ListNode fast = head, slow = head;
            ListNode pre = head;
            while (n > 0)
            {
                fast = fast.next;
                n -= 1;
            }
            if (fast == null)
            {
                return head.next;
            }
            while (fast != null)
            {
                pre = slow;
                slow = slow.next;
                fast = fast.next;
            }
            pre.next = slow.next;
            return head;
        }
    }
}