namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #876
    /// </summary>
    public class MiddleOfLinkedList : IExecute
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
            var res = MiddleNode(head);
            PrintResult(res);
        }

        void PrintResult(ListNode head)
        {
            System.Console.WriteLine("Leetcode #876:");
            System.Console.WriteLine(head.val);
        }

        public ListNode MiddleNode(ListNode head)
        {
            if (head == null)
            {
                return null;
            }
            if (head.next != null)
            {
                ListNode slow = head;
                ListNode fast = head;
                while (fast != null && fast.next != null)
                {
                    slow = slow.next;
                    fast = fast.next.next;
                }
                return slow;
            }
            return head;
        }
    }
}