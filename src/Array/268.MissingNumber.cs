using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #268
    /// </summary>
    public class MissingNumber : IExecute
    {
        public void Execute()
        {
            var nums = new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
            var res = Missingnumber(nums);
            PrintResult(res);
        }

        void PrintResult(int res)
        {
            Console.WriteLine("LeetCode #268:");
            System.Console.WriteLine(res);
        }

        public int Missingnumber(int[] nums)
        {
            int n = nums.Length;
            return SumN(n) - nums.Sum();
        }

        private int SumN(int n)
        {
            return (1 + n) * n / 2;
        }
    }
}