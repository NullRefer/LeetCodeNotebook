using System.Collections.Generic;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #118
    /// </summary>
    public class PascalsTriangle : IExecute
    {
        public void Execute()
        {
            var res = Generate(4);
            PrintResult(res);
        }

        void PrintResult(IList<IList<int>> res)
        {
            System.Console.WriteLine("Leetcode #118:");
            foreach (var re in res)
            {
                System.Console.WriteLine(string.Join(",", re));
            }
        }

        public IList<IList<int>> Generate(int numRows)
        {
            int[][] dp = new int[numRows][];
            for (int i = 0; i < numRows; i++)
            {
                dp[i] = new int[i + 1];
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        dp[i][j] = 1;
                    }
                    else
                    {
                        dp[i][j] = dp[i - 1][j - 1] + dp[i - 1][j];
                    }
                }
            }
            IList<IList<int>> p = new List<IList<int>>();
            for (int i = 1; i <= numRows; i++)
            {
                var list = dp[i - 1].ToList();
                p.Add(list);
            }
            return p;
        }
    }
}