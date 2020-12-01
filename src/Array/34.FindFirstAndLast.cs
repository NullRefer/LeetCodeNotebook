using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #34
    /// </summary>
    public class FindFirstAndLast : IExecute
    {
        public void Execute()
        {
            var nums = new int[] { 1, 2, 3, 4, 6, 8, 8, 9, 10 };
            var res = SearchRange(nums, 8);
            PrintResult(res);
        }

        void PrintResult(int[] res)
        {
            Console.WriteLine("LeetCode #34:");
            System.Console.WriteLine(string.Join(",", res));
        }

        public int[] SearchRange(int[] nums, int target)
        {
            int[] res = new int[] { -1, -1 };
            int left = 0;
            int right = nums.Length;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (mid > nums.Length - 1)
                {
                    return res;
                }
                if (nums[mid] == target)
                {
                    for (int i = mid; i < nums.Length; i++)
                    {
                        if (nums[i] == target)
                        {
                            res[1] = i;
                        }
                    }
                    for (int i = mid; i >= 0; i--)
                    {
                        if (nums[i] == target)
                        {
                            res[0] = i;
                        }
                    }
                    return res;
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else if (nums[mid] > target)
                {
                    right = mid - 1;
                }
            }

            return res;
        }
    }
}