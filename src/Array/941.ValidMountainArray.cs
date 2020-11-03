using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #941
    /// </summary>
    public class ValidMountainArray : IExecute
    {
        public void Execute()
        {
            int[] nums = new[] { 0, 2, 3, 4, 5, 4, 3, 2 };
            var res = ValidMountainarray(nums);
            PrintResult(res);
        }

        void PrintResult(bool res)
        {
            Console.WriteLine("LeetCode #941:");
            System.Console.WriteLine(res);
        }

        public bool ValidMountainarray(int[] arr)
        {
            int left = 0, right = arr.Length - 1;
            while (left < arr.Length - 1 && right > 0)
            {
                if (arr[left] >= arr[left + 1] && arr[right] >= arr[right - 1])
                {
                    break;
                }
                if (arr[left] < arr[left + 1])
                {
                    left += 1;
                }
                if (arr[right] < arr[right - 1])
                {
                    right -= 1;
                }
            }
            return left != 0 && right != arr.Length - 1 && right == left;
        }
    }
}