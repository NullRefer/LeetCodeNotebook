using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #442
    /// </summary>
    public class FindAllDuplicates : IExecute
    {
        public void Execute()
        {
            int[] nums = new[] { 4, 3, 2, 7, 8, 2, 3, 1 };
            var res = FindDuplicates(nums);
            PrintResult(res);
        }

        void PrintResult(IList<int> res)
        {
            Console.WriteLine("LeetCode #442:");
            System.Console.WriteLine(string.Join(",", res));
        }

        public IList<int> FindDuplicates(int[] nums)
        {
            IList<int> res = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[Math.Abs(nums[i]) - 1] < 0)
                {
                    res.Add(Math.Abs(nums[i]));
                }
                else
                {
                    nums[Math.Abs(nums[i]) - 1] *= -1;
                }
            }
            return res;
        }
    }
}