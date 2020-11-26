using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #164
    /// </summary>
    public class MaximumGap : IExecute
    {
        public void Execute()
        {
            int[] nums = new int[] { 3, 6, 9, 1 };
            var res = Maximumgap(nums);
            PrintOut(res);
        }

        void PrintOut(int res)
        {
            System.Console.WriteLine("LeetCode #164: ");
            System.Console.Write(res);
        }

        public int Maximumgap(int[] nums)
        {
            Array.Sort(nums);
            int maxGap = int.MinValue;
            for (int i = 1; i < nums.Length; i++)
            {
                maxGap = Math.Max(maxGap, nums[i] - nums[i - 1]);
            }
            return maxGap;
        }
    }
}