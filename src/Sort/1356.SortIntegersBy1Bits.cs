using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #1356
    /// </summary>
    public class SortIntegersBy1Bits : IExecute
    {
        public void Execute()
        {
            int[] arr = new int[] {2,3,5,7,11,13,17,19};
            var res = SortByBits(arr);
            PrintOut(res);
        }

        void PrintOut(int[] res)
        {
            System.Console.WriteLine("LeetCode #1356: ");
            System.Console.WriteLine(string.Join(",", res));
        }

        public int[] SortByBits(int[] arr)
        {
            return arr.OrderBy(v => GetWeight(v)).ThenBy(v => v).ToArray();
        }

        private int GetWeight(int value)
        {
            return Convert.ToString(value, 2).Count(c => c == '1');
        }
    }
}