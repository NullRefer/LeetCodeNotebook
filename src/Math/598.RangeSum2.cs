using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #204
    /// </summary>
    public class RangeSum2 : IExecute
    {
        public void Execute()
        {
            var ops = new int[][]
            {
                new int[] {2, 2},
                new int[] {3, 3},
            };
            var res = MaxCount(4, 4, ops);
            PrintResult(res);
        }

        private void PrintResult(int res)
        {
            System.Console.WriteLine("LeetCode #204: ");
            System.Console.WriteLine(res);
        }

        public int MaxCount(int m, int n, int[][] ops)
        {
            if (ops.Length == 0)
            {
                return m * n;
            }
            int minX = int.MaxValue;
            int minY = int.MaxValue;
            foreach (int[] op in ops)
            {
                minX = Math.Min(op[0], minX);
                minY = Math.Min(op[1], minY);
            }
            return minX * minY;
        }
    }
}