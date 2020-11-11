using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #514
    /// Dynamic Programming
    /// </summary>
    public class FreedomTrail : IExecute
    {
        public void Execute()
        {
            string ring = "godding";
            string key = "gd";
            var res = FindRotateSteps(ring, key);
            PrintResult(res);
        }

        void PrintResult(int res)
        {
            System.Console.WriteLine("Leetcode #514:");
            System.Console.WriteLine(res);
        }

        public int FindRotateSteps(string ring, string key)
        {
        int n = ring.Length, m = key.Length;
        List<int>[] pos = new List<int>[26];
        for (int i = 0; i < 26; i++)
        {
            pos[i] = new List<int>();
        }
        for (int i = 0; i < n; i++)
        {
            pos[ring[i] - 'a'].Add(i);
        }
        int[][] dp = new int[m][];
        for (int i = 0; i < m; i++)
        {
            dp[i] = new int[n];
            Array.Fill(dp[i], int.MaxValue);
        }
        foreach (var i in pos[key[0] - 'a'])
        {
            dp[0][i] = Math.Min(i, n - i) + 1;
        }
        for (int i = 1; i < m; i++)
        {
            foreach (int j in pos[key[i] - 'a'])
            {
                foreach (var k in pos[key[i - 1] - 'a'])
                {
                    dp[i][j] = Math.Min(dp[i][j], dp[i - 1][k] + Math.Min(Math.Abs(j - k), n - Math.Abs(j - k)) + 1);
                }
            }
        }
        return dp[^1].Min();
        }
    }
}