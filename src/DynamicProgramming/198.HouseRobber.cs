using System;
using System.Collections.Generic;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #198
    /// Dynamic Programming
    /// </summary>
    public class HouseRobber : IExecute
    {
        public void Execute()
        {
            int[] nums = new int[] { 2, 7, 9, 3, 1 };
            var res = Rob(nums);
            PrintResult(res);
        }

        void PrintResult(int res)
        {
            System.Console.WriteLine("Leetcode #198:");
            System.Console.WriteLine(res);
        }

        public int Rob(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            int pre = nums[0], cur = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (i == 1)
                {
                    cur = Math.Max(nums[i], nums[i - 1]);
                }
                else
                {
                    pre = cur;
                    cur = Math.Max(pre + nums[i], cur);
                }
            }
            return cur;
        }
    }
}