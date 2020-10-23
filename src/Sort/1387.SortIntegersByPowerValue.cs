using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #1387
    /// </summary>
    public class SortIntegersByPowerValue : IExecute
    {
        public void Execute()
        {
            int lo = 12, hi = 15, k = 2;
            var res = GetKth(lo, hi, k);
            PrintOut(res);
        }

        void PrintOut(int res)
        {
            System.Console.WriteLine("LeetCode #1387: ");
            System.Console.WriteLine(res);
        }

        public int GetKth(int lo, int hi, int k)
        {
            List<int> arr = new List<int>();
            for (int i = lo; i <= hi; i++)
            {
                arr.Add(i);
            }
            return arr.OrderBy(v => GetWeight(v)).ToList()[k - 1];
        }

        private int GetWeight(int value)
        {
            if (value == 1)
            {
                return 1;
            }
            int count = 0;
            while (value != 1)
            {
                if (value % 2 != 0)
                {
                    value = 3 * value + 1;
                }
                else
                {
                    value /= 2;
                }
                count += 1;
            }
            return count;
        }
    }
}