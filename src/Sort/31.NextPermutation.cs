using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #31
    /// </summary>
    public class NextPermutation : IExecute
    {
        public void Execute()
        {
            int[] nums = new int[] { 2, 2, 0, 4, 3, 1 };
            Nextpermutation(nums);
            PrintOut(nums);
        }

        void PrintOut(int[] res)
        {
            System.Console.WriteLine("LeetCode #31: ");
            System.Console.Write(string.Join(",", res));
        }

        public void Nextpermutation(int[] nums)
        {
            int firstTarget = -1;
            for (int i = nums.Length - 1; i > 0; i--)
            {
                if (nums[i - 1] < nums[i])
                {
                    firstTarget = i - 1;
                    break;
                }
            }
            if (firstTarget >= 0)
            {
                for (int i = nums.Length - 1; i > firstTarget; i--)
                {
                    if (nums[firstTarget] < nums[i])
                    {
                        Swap(nums, firstTarget, i);
                        Reverse(nums, firstTarget + 1, nums.Length - 1);
                        return;
                    }
                }
            }
            else
            {
                Array.Sort(nums);
            }
        }

        private void Swap(int[] nums, int i, int j)
        {
            int tmp = nums[i];
            nums[i] = nums[j];
            nums[j] = tmp;
        }

        private void Reverse(int[] nums, int start, int end)
        {
            while (end > start)
            {
                Swap(nums, start++, end--);
            }
        }
    }
}