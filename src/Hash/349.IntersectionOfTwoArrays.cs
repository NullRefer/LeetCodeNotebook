using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #349
    /// </summary>
    public class IntersectionOfTwoArrays : IExecute
    {
        public void Execute()
        {
            int[] nums1 = new int[] { 1, 2, 3, 3, 4 };
            int[] nums2 = new int[] { 2, 2, 3 };
            var res = Intersection(nums1, nums2);
            PrintResult(res);
        }

        void PrintResult(IEnumerable<int> res)
        {
            Console.WriteLine("LeetCode #349:");
            System.Console.WriteLine(string.Join(",", res));
        }

        public int[] Intersection(int[] nums1, int[] nums2)
        {
            // return nums1.Intersect(nums2).ToArray();
            // Intersect by MS
            IList<int> res = new List<int>();
            ISet<int> set = new HashSet<int>();
            set.UnionWith(nums2);
            foreach (var num in nums1)
            {
                if (set.Remove(num))
                {
                    // yield return num;
                    res.Add(num);
                }
            }
            return res.ToArray();
        }
    }
}