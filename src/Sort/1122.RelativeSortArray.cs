using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #1122
    /// </summary>
    public class RelativeSortArray : IExecute
    {
        public void Execute()
        {
            int[] arr1 = new int[] { 2, 3, 1, 3, 2, 4, 6, 7, 9, 2, 19 };
            int[] arr2 = new int[] { 2, 1, 4, 3, 9, 6 };
            var res = RelativesortArray(arr1, arr2);
            PrintOut(arr1);
        }

        void PrintOut(int[] res)
        {
            System.Console.WriteLine("LeetCode #1122: ");
            System.Console.Write(string.Join(",", res));
        }

        public int[] RelativesortArray(int[] arr1, int[] arr2)
        {
            var list2 = arr2.ToList();
            var sort1 = arr1.OrderBy(v => list2.IndexOf(v));
            var sort2 = sort1.OrderBy(v => list2.IndexOf(v) == -1 ? v : 0)
                       .ToArray();
            return arr1;
        }
    }
}