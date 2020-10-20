using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #216
    /// Backtracking
    /// </summary>
    public class CombinationSum3 : IExecute
    {
        public void Execute()
        {
            var res = Combinationsum3(9, 45);
            PrintResult(res);
        }

        void PrintResult(IList<IList<int>> res)
        {
            Console.WriteLine("LeetCode #216:");
            for (int i = 0; i < res.Count; i++)
            {
                Console.WriteLine(string.Join(',', res[i]));
            }
        }

        public IList<IList<int>> Combinationsum3(int k, int n)
        {
            IList<IList<int>> res = new List<IList<int>>();
            IList<int> path = new List<int>();
            Backtracking(k, n, 1, path, res);
            return res;
        }

        private void Backtracking(int k, int n, int start, IList<int> path, IList<IList<int>> res)
        {
            if (path.Count == k)
            {
                if (path.Sum() == n)
                {
                    res.Add(new List<int>(path));
                }
                return;
            }

            for (int i = start; i <= 9; i++)
            {
                if (path.Sum() > n)
                {
                    return;
                }
                path.Add(i);

                Backtracking(k, n, i + 1, path, res);

                path.RemoveAt(path.Count - 1);
            }
        }
    }
}