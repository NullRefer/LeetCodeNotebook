using System;
using System.Collections.Generic;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #454
    /// </summary>
    public class FourSum2 : IExecute
    {
        public void Execute()
        {
            int[] A = new int[] { 1, 2 };
            int[] B = new int[] { -2, -1 };
            int[] C = new int[] { -1, 2 };
            int[] D = new int[] { 0, 2 };
            var res = FourSumCount(A, B, C, D);
            PrintResult(res);
        }

        void PrintResult(int res)
        {
            Console.WriteLine("LeetCode #454:");
            System.Console.WriteLine(res);
        }

        public int FourSumCount(int[] A, int[] B, int[] C, int[] D)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var a in A)
            {
                foreach (var b in B)
                {
                    if (dict.ContainsKey(a + b))
                    {
                        dict[a + b] += 1;
                        continue;
                    }
                    dict.Add(a + b, 1);
                }
            }

            int res = 0;
            foreach (var c in C)
            {
                foreach (var d in D)
                {
                    int sum = -(c + d);
                    if (dict.ContainsKey(sum))
                    {
                        res += dict[sum];
                    }
                }
            }
            return res;
        }
    }
}