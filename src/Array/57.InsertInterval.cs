using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #57
    /// </summary>
    public class InsertInterval : IExecute
    {
        public void Execute()
        {
            var intervals = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 3, 5 },
                new int[] { 6, 9 },
                new int[] { 12, 15 },
            };
            var newInterval = new int[] { 4, 8 };
            var res = Insert(intervals, newInterval);
            PrintResult(res);
        }

        void PrintResult(int[][] res)
        {
            Console.WriteLine("LeetCode #57:");
            foreach (var re in res)
            {
                System.Console.WriteLine(string.Join(",", re));
            }
        }

        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            List<int[]> overlapped = new List<int[]>();
            List<int[]> notOverlapped = new List<int[]>();
            for (int i = 0; i < intervals.Length; i++)
            {
                bool isNotOverlap = newInterval[0] > intervals[i][1] || newInterval[1] < intervals[i][0];
                if (!isNotOverlap)
                {
                    overlapped.Add(intervals[i]);
                }
                else
                {
                    notOverlapped.Add(intervals[i]);
                }
            }
            // merge
            foreach (var interval in overlapped)
            {
                newInterval[0] = Math.Min(newInterval[0], interval[0]);
                newInterval[1] = Math.Max(newInterval[1], interval[1]);
            }
            int notOverlapCount = notOverlapped.Count;
            for (int i = 0; i < notOverlapCount; i++)
            {
                if (newInterval[0] < notOverlapped[i][0])
                {
                    notOverlapped.Insert(i, newInterval);
                    break;
                }
            }
            if (notOverlapped.Count == notOverlapCount)
            {
                notOverlapped.Add(newInterval);
            }
            return notOverlapped.ToArray();
        }
    }
}