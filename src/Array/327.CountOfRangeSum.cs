using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Diagnostics;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #327
    /// </summary>
    public class CountOfRangeSum : IExecute
    {
        public void Execute()
        {
            int[] nums = new[] { -6, 20, };
            int lower = -24;
            int upper = 30;
            var sp = new Stopwatch();
            sp.Start();
            var res = CountRangeSum(nums, lower, upper);
            PrintResult(res);
            sp.Stop();
            System.Console.WriteLine(sp.ElapsedMilliseconds);
        }

        void PrintResult(int res)
        {
            Console.WriteLine("LeetCode #327:");
            System.Console.WriteLine(res);
        }

        public int CountRangeSum(int[] nums, int lower, int upper)
        {
            // 
            long s = 0;
            long[] sum = new long[nums.Length + 1];
            for (int i = 0; i < nums.Length; ++i)
            {
                s += nums[i];
                sum[i + 1] = s;
            }
            return CountRangeSumRecursive(sum, lower, upper, 0, sum.Length - 1);
        }

        public int CountRangeSumRecursive(long[] sum, int lower, int upper, int left, int right)
        {
            if (left == right)
            {
                return 0;
            }
            else
            {
                int mid = (left + right) / 2;
                int n1 = CountRangeSumRecursive(sum, lower, upper, left, mid);
                int n2 = CountRangeSumRecursive(sum, lower, upper, mid + 1, right);
                int ret = n1 + n2;

                // 首先统计下标对的数量
                int i = left;
                int l = mid + 1;
                int r = mid + 1;
                while (i <= mid)
                {
                    while (l <= right && sum[l] - sum[i] < lower)
                    {
                        l++;
                    }
                    while (r <= right && sum[r] - sum[i] <= upper)
                    {
                        r++;
                    }
                    ret += r - l;
                    i++;
                }

                // 随后合并两个排序数组
                int[] sorted = new int[right - left + 1];
                int p1 = left, p2 = mid + 1;
                int p = 0;
                while (p1 <= mid || p2 <= right)
                {
                    if (p1 > mid)
                    {
                        sorted[p++] = (int)sum[p2++];
                    }
                    else if (p2 > right)
                    {
                        sorted[p++] = (int)sum[p1++];
                    }
                    else
                    {
                        if (sum[p1] < sum[p2])
                        {
                            sorted[p++] = (int)sum[p1++];
                        }
                        else
                        {
                            sorted[p++] = (int)sum[p2++];
                        }
                    }
                }
                for (int j = 0; j < sorted.Length; j++)
                {
                    sum[left + j] = sorted[j];
                }
                return ret;
            }
        }
    }
}