using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #1365
    /// </summary>
    public class HowManySmallerNumber : IExecute
    {
        public void Execute()
        {
            int[] nums = new[] { 4, 3, 2, 7, 8, 2, 3, 1 };
            var res = SmallerNumbersThanCurrent(nums);
            PrintResult(res);
        }

        void PrintResult(IList<int> res)
        {
            Console.WriteLine("LeetCode #1356:");
            System.Console.WriteLine(string.Join(",", res));
        }

        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int length = nums.Length;
            int[] res = new int[length];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    res[i] += nums[i] > nums[j] ? 1 : 0;
                }
            }
            return res;
        }
    }
}