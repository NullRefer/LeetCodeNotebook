using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #973
    /// </summary>
    public class KClosestPointsToOrigin : IExecute
    {
        public void Execute()
        {
            int[][] points = new int[][]
            {
                new int[] { 3, 3 },
                new int[] { 5, -1 },
                new int[] { -2, 4 },
            };
            var res = KClosest(points, 2);
            PrintOut(res);
        }

        void PrintOut(int[][] res)
        {
            System.Console.WriteLine("LeetCode #973: ");
            foreach (var point in res)
            {
                System.Console.Write($"({point[0]}, {point[1]}) ");
            }
        }

        public int[][] KClosest(int[][] points, int K)
        {
            return points.OrderBy(v => GetWeight(v))
                         .Take(K)
                         .ToArray();
        }

        private int GetWeight(int[] value)
        {
            return value[0] * value[0] + value[1] * value[1];
        }
    }
}