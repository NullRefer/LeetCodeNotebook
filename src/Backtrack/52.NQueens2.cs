using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #51
    /// Backtracking
    /// </summary>
    public class NQueens2 : IExecute
    {
        public void Execute()
        {
            var res = TotalNQueens(4);
            PrintResult(res);
        }

        void PrintResult(int res)
        {
            Console.WriteLine("LeetCode #51:");
            System.Console.WriteLine(res);
        }

        private HashSet<int> Cols;
        private HashSet<int> Subs;
        private HashSet<int> Diags;
        public int TotalNQueens(int n)
        {
            IList<IList<string>> res = new List<IList<string>>();
            IList<int> path = new List<int>();
            Cols = new HashSet<int>();
            Subs = new HashSet<int>();
            Diags = new HashSet<int>();
            Backtracking(n, 0, path, res);
            return res.Count;
        }

        private void Backtracking(int n, int row, IList<int> path, IList<IList<string>> res)
        {
            if (row == n)
            {
                res.Add(ConvertToBoard(path));
                return;
            }

            for (int i = 0; i < n; i++)
            {
                if (!Cols.Contains(i) && !Subs.Contains(row + i) && !Diags.Contains(row - i))
                {
                    path.Add(i);
                    Cols.Add(i);
                    Subs.Add(row + i);
                    Diags.Add(row - i);

                    Backtracking(n, row + 1, path, res);

                    path.RemoveAt(path.Count - 1);
                    Cols.Remove(i);
                    Subs.Remove(row + i);
                    Diags.Remove(row - i);
                }
            }
        }

        private IList<string> ConvertToBoard(IList<int> path)
        {
            var res = new List<string>();
            for (int i = 0; i < path.Count; i++)
            {
                string line = "";
                for (int j = 0; j < path.Count; j++)
                {
                    if (path[i] == j)
                    {
                        line += "Q";
                    }
                    else
                    {
                        line += ".";
                    }
                }
                res.Add(line);
            }
            return res;
        }
    }
}