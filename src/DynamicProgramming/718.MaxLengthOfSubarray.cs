using System;
using System.Collections.Generic;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #718
    /// Dynamic Programming
    /// </summary>
    public class MaxLengthOfSubarray : IExecute
    {
        public void Execute()
        {
            var A = new int[] { 1, 2, 3, 2, 1 };
            var B = new int[] { 3, 2, 1, 4, 7 };
            var res = FindLength(A, B);
            PrintResult(res);
        }

        void PrintResult(int res)
        {
            System.Console.WriteLine("Leetcode #718:");
            System.Console.WriteLine(res);
        }

        public int FindLength(int[] A, int[] B)
        {
            int an = A.Length;
            int bn = B.Length;
            int[,] dp = new int[an + 1, bn + 1];
            int ans = 0;
            for (int i = an - 1; i >= 0; i--)
            {
                for (int j = bn - 1; j >= 0; j--)
                {
                    dp[i, j] = A[i] == B[j] ? dp[i + 1, j + 1] + 1: 0;
                    ans = Math.Max(dp[i, j], ans);
                }
            }
            return ans;
        }
    }
}