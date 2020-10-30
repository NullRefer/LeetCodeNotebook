using System;
using System.Collections.Generic;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #463
    /// </summary>
    public class IslandPerimeter : IExecute
    {
        public void Execute()
        {
            int[][] grid = new int[][]
            {
                new int[] { 0, 1, 0, 0 },
                new int[] { 1, 1, 1, 0 },
                new int[] { 0, 1, 0, 0 },
                new int[] { 1, 1, 0, 0 },
            };
            int[][] grid1 = new int[][]
            {
                new int[] {1, 1},
            };
            var res = Islandperimeter(grid1);
            PrintResult(res);
        }

        void PrintResult(int res)
        {
            Console.WriteLine("LeetCode #463:");
            System.Console.WriteLine(res);
        }

        public int Islandperimeter(int[][] grid)
        {
            int res = 0;
            int n = grid.Length;
            int m = grid[0].Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        res += 4;
                        if (i >= 1 && grid[i - 1][j] == 1)
                        {
                            res -= 1;
                        }
                        if (j >= 1 && grid[i][j - 1] == 1)
                        {
                            res -= 1;
                        }
                        if (i + 1 < n && grid[i + 1][j] == 1)
                        {
                            res -= 1;
                        }
                        if (j + 1 < m && grid[i][j + 1] == 1)
                        {
                            res -= 1;
                        }
                    }
                }
            }
            return res;
        }
    }
}