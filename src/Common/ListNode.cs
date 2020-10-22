using System;

namespace LeetCodeNotebook
{
    public class ListNode
    {
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public int val;
        public ListNode next;

    }

    public static class ListNodeExtension
    {
        public static void PrintOut(this ListNode head)
        {
            while (head != null)
            {
                Console.Write($"{head.val},");
                head = head.next;
            }
        }
    }
}