using System.Collections.Generic;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #523
    /// Dynamic Programming
    /// </summary>
    public class ContinuousSubarraySum : IExecute
    {
        public void Execute()
        {
            var arr = new int[] { 23, 2, 6, 4, 7 };
            var k = 8;
            var res = CheckSubarraySum(arr, k);
            PrintResult(res);
        }

        void PrintResult(bool res)
        {
            System.Console.WriteLine("Leetcode #523:");
            System.Console.WriteLine(res);
        }

        public bool CheckSubarraySum(int[] nums, int k)
        {
            if (nums.Sum() < k)
            {
                return false;
            }
            int curSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                curSum += nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    curSum += nums[j];
                    if (curSum % k != 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}