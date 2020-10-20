using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #77
    /// Backtracking
    /// </summary>
    public class Combinations : IExecute
    {
        public void Execute()
        {
            var res = Combine(4, 2);
            PrintResult(res);
        }

        void PrintResult(IList<IList<int>> res)
        {
            Console.WriteLine("LeetCode #77:");
            for (int i = 0; i < res.Count; i++)
            {
                Console.WriteLine(string.Join(',', res[i]));
            }
        }

        public IList<IList<int>> Combine(int n, int k)
        {
            IList<IList<int>> res = new List<IList<int>>();
            IList<int> path = new List<int>();
            Backtracking(n, k, 1, path, res);
            return res;
        }

        private void Backtracking(int n, int k, int start, IList<int> path, IList<IList<int>> res)
        {
            if (path.Count == k)
            {
                res.Add(new List<int>(path));
                return;
            }

            for (int i = start; i <= n; i++)
            {
                path.Add(i);

                Backtracking(n, k, i + 1, path, res);

                path.RemoveAt(path.Count - 1);
            }
        }
    }
}