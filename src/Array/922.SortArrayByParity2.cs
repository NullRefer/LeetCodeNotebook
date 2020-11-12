using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #922
    /// </summary>
    public class SortArrayByParity2 : IExecute
    {
        public void Execute()
        {
            int[] nums = new[] { 1, 0, 2, 3};
            var res = SortArrayByParity(nums);
            PrintResult(res);
        }

        void PrintResult(int[] res)
        {
            Console.WriteLine("LeetCode #922:");
            System.Console.WriteLine(string.Join(",", res));
        }

        public int[] SortArrayByParity(int[] A)
        {
        int[] res = new int[A.Length];
        int evenIndex = 0;
        int oddIndex = 1;
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] % 2 == 0)
            {
                res[evenIndex] = A[i];
                evenIndex += 2;
            }
            else
            {
                res[oddIndex] = A[i];
                oddIndex += 2;
            }
        }
        return res;
        }
    }
}