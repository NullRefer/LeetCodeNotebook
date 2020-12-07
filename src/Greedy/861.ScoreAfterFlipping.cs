using System;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #861
    /// </summary>
    public class ScoreAfterFlipping : IExecute
    {
        public void Execute()
        {
            int[][] A = new int[][]
            {
                new int[] { 0, 0, 1, 1 },
                new int[] { 1, 0, 1, 0 },
                new int[] { 1, 1, 0, 0 }
            };
            var res = MatrixScore(A);
            PrintResult(res);
        }

        void PrintResult(int res)
        {
            Console.WriteLine("LeetCode #861:");
            Console.WriteLine(res);
        }

        public int MatrixScore(int[][] A)
        {
            int m = A.Length, n = A[0].Length;
            int ret = m * (1 << (n - 1));

            for (int j = 1; j < n; j++)
            {
                int nOnes = 0;
                for (int i = 0; i < m; i++)
                {
                    if (A[i][0] == 1)
                    {
                        nOnes += A[i][j];
                    }
                    else
                    {
                        nOnes += (1 - A[i][j]);
                    }
                }
                int k = Math.Max(nOnes, m - nOnes);
                ret += k * (1 << (n - j - 1));
            }
            return ret;
        }
    }
}