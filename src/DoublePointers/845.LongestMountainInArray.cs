using System;
using System.Collections.Generic;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #845
    /// Double Pointers
    /// </summary>
    public class LongestMountainInArray : IExecute
    {
        public void Execute()
        {
            var array = new int[] { 2, 1, 4, 7, 3, 2, 5 };
            var res = LongestMountain(array);
            PrintResult(res);
        }

        void PrintResult(int res)
        {
            System.Console.WriteLine("Leetcode #845:");
            System.Console.WriteLine(res);
        }

        public int LongestMountain(int[] A)
        {
            int n = A.Length;
            if (n == 0)
            {
                return 0;
            }
            int[] left = new int[n];
            for (int i = 1; i < n; i++)
            {
                left[i] = A[i - 1] < A[i] ? left[i - 1] + 1 : 0;
            }
            int[] right = new int[n];
            for (int i = n - 2; i >= 0; i--)
            {
                right[i] = A[i + 1] < A[i] ? right[i + 1] + 1 : 0;
            }

            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                if (left[i] > 0 && right[i] > 0)
                {
                    ans = Math.Max(ans, left[i] + right[i] + 1);
                }
            }
            return ans;
        }
    }
}