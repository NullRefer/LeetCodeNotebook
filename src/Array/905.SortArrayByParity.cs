using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #905
    /// </summary>
    public class SortArrayByParity : IExecute
    {
        public void Execute()
        {
            int[] nums = new[] { 0, 2, 1, 3 };
            var res = SortArraybyParity(nums);
            PrintResult(res);
        }

        void PrintResult(int[] res)
        {
            Console.WriteLine("LeetCode #905:");
            System.Console.WriteLine(string.Join(",", res));
        }

        public int[] SortArraybyParity(int[] A)
        {
            int[] res = new int[A.Length];
            int resIndex = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    res[resIndex++] = A[i];
                }
            }
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 1)
                {
                    res[resIndex++] = A[i];
                }
            }
            return res;
        }
    }
}