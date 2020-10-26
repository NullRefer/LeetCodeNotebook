using System.Collections.Generic;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #1024
    /// Dynamic Programming
    /// </summary>
    public class VideoStitching : IExecute
    {
        public void Execute()
        {
            var clips = new int[][]
            {
                new int[] {0, 2},
                new int[] {4, 6},
                new int[] {8, 10},
                new int[] {1, 9},
                new int[] {1, 5},
                new int[] {5, 9},
            };
            int T = 10;
            var res = Videostitching(clips, T);
            PrintResult(res);
        }

        void PrintResult(int res)
        {
            System.Console.WriteLine("Leetcode #1024:");
            System.Console.WriteLine(res);
        }

        public int Videostitching(int[][] clips, int T)
        {
            var max = 0;
            var last = -1;
            var counter = 0;

            for (; max < T; counter++)
            {
                var choose = clips.Where(x => x[0] > last && x[0] <= max).ToList();
                if (choose.Any())
                {
                    last = max;
                    max = choose.Max(x => x[1]);
                    if (max > last) continue;
                }
                return -1;
            }
            return counter;
        }
    }
}