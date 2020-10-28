using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #769
    /// </summary>
    public class MaxChunksMakeSorted : IExecute
    {
        public void Execute()
        {
            int[] nums = new[] { 1, 0, 2, 3, 4 };
            var res = MaxChunksToSorted(nums);
            PrintResult(res);
        }

        void PrintResult(int res)
        {
            Console.WriteLine("LeetCode #769:");
            System.Console.WriteLine(res);
        }

        public int MaxChunksToSorted(int[] arr)
        {
            int max = int.MinValue, res = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                max = Math.Max(max, arr[i]);
                if (max == i)
                {
                    res += 1;
                }
            }
            return res;
        }
    }
}