using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #945
    /// </summary>
    public class MinIncrement : IExecute
    {
        public void Execute()
        {
            int[] nums = new[] {  2, 2, 7 };
            var res = MinIncrementForUnique(nums);
            PrintResult(res);
        }

        void PrintResult(int res)
        {
            Console.WriteLine("LeetCode #945:");
            System.Console.WriteLine(res);
        }

        public int MinIncrementForUnique(int[] A)
        {
            Array.Sort(A);
            int incre = 0;
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] == A[i - 1])
                {
                    A[i] += 1;
                    incre += 1;
                }
                if (A[i] < A[i - 1])
                {
                    incre += A[i - 1] - A[i] + 1;
                    A[i] = A[i - 1] + 1;
                }
            }
            return incre;
        }
    }
}