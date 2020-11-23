using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #452
    /// </summary>
    public class MinArrowsToBoostBallons : IExecute
    {
        public void Execute()
        {
            int[][] points = new int[][]
            {
                new int[] { 10, 16 },
                new int[] { 2, 8 },
                new int[] { 1, 6 },
                new int[] { 7, 12 },
            };
            int[][] ps = new int[][]
            {
                new int[] {-2147483646,-2147483645},
                new int[] {2147483646,2147483647}
            };
            var res = FindMinArrowShots(ps);
            PrintResult(res);
        }

        void PrintResult(int res)
        {
            Console.WriteLine("LeetCode #452:");
            Console.WriteLine(res);
        }

        public int FindMinArrowShots(int[][] points)
        {
            if (points == null)
            {
                return 0;
            }
            if (points.Length <= 1)
            {
                return points.Length;
            }
            Array.Sort(points, (v1, v2) =>
            {
                return v1[1] > v2[1] ? 1 : -1;
            });
            int res = 1;
            int rightEdge = points[0][1];
            for (int i = 1; i < points.Length; i++)
            {
                if (rightEdge < points[i][0])
                {
                    res += 1;
                    rightEdge = points[i][1];
                }
            }
            return res;
        }
    }
}