using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #38
    /// Backtracking
    /// </summary>
    public class CombinationSum : IExecute
    {
        public void Execute()
        {
            int[] candidates = new[] { 2, 3, 5 };
            int target = 8;
            var res = Combinationsum(candidates, target);
            PrintResult(res);
        }

        void PrintResult(IList<IList<int>> res)
        {
            Console.WriteLine("LeetCode #38:");
            for (int i = 0; i < res.Count; i++)
            {
                Console.WriteLine(string.Join(',', res[i]));
            }
        }

        public IList<IList<int>> Combinationsum(int[] candidates, int target)
        {
            IList<IList<int>> res = new List<IList<int>>();
            IList<int> path = new List<int>();
            Array.Sort(candidates);
            Backtracking(candidates, 0, candidates.Length, target, path, res);
            return res;
        }

        private void Backtracking(int[] candidates, int start, int length, int target, IList<int> path, IList<IList<int>> res)
        {
            if (target == 0)
            {
                res.Add(new List<int>(path));
                return;
            }

            for (int i = start; i < length; i++)
            {
                if (target - candidates[i] < 0)
                {
                    break;
                }
                path.Add(candidates[i]);

                Backtracking(candidates, i, length, target - candidates[i], path, res);

                path.RemoveAt(path.Count - 1);
            }
        }
    }
}