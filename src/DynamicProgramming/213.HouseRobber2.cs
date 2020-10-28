using System;
using System.Collections.Generic;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #213
    /// Dynamic Programming
    /// </summary>
    public class HouseRobber2 : IExecute
    {
        public void Execute()
        {
            int[] nums = new int[] { 1, 7, 9, 2 };
            var res = Rob(nums);
            PrintResult(res);
        }

        void PrintResult(int res)
        {
            System.Console.WriteLine("Leetcode #213:");
            System.Console.WriteLine(res);
        }

        public int Rob(int[] nums)
        {
            int length = nums.Length;
            if (length == 1)
            {
                return nums[0];
            }
            else if (length == 2)
            {
                return Math.Max(nums[0], nums[1]);
            }
            else if (length == 3)
            {
                return Math.Max(nums[0], nums[1] > nums[2] ? nums[1] : nums[2]);
            }
            int[] dp1 = new int[length];
            dp1[0] = nums[0];
            dp1[1] = Math.Max(nums[0], nums[1]);
            for (int i = 2; i < length - 1; i++)
            {
                dp1[i] = Math.Max(dp1[i - 1], dp1[i - 2] + nums[i]);
            }
            int[] dp2 = new int[length];
            dp2[1] = nums[1];
            dp2[2] = Math.Max(nums[1], nums[2]);
            for (int i = 3; i < length; i++)
            {
                dp2[i] = Math.Max(dp2[i - 1], dp2[i - 2] + nums[i]);
            }
            return Math.Max(dp1[length - 2], dp2[length - 1]);
        }
    }
}