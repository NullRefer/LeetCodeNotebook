using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #1375
    /// </summary>
    public class BulbSwitcher3 : IExecute
    {
        public void Execute()
        {
            int[] nums = new[] { 4, 3, 2, 7, 8, 2, 3, 1 };
            var res = NumTimesAllBlue(nums);
            PrintResult(res);
        }

        void PrintResult(int res)
        {
            Console.WriteLine("LeetCode #1375:");
            System.Console.WriteLine(res);
        }

        public int NumTimesAllBlue(int[] light)
        {
            int res = 0;
            int maxNo = 0;
            for (int i = 0; i < light.Length; i++)
            {
                maxNo = Math.Max(maxNo, light[i]);
                if (i + 1 == maxNo)
                {
                    res += 1;
                }
            }
            return res;
        }
    }
}