using System;
using System.Collections.Generic;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #19
    /// Double Pointers
    /// </summary>
    public class PartitionLabels : IExecute
    {
        public void Execute()
        {
            var res = PartitionLabel("ababcbacadefegdehijhklij");
            PrintResult(res);
        }

        void PrintResult(IList<int> res)
        {
            System.Console.WriteLine("Leetcode #763:");
            System.Console.WriteLine(string.Join(",", res));
        }

        public IList<int> PartitionLabel(string S)
        {
            IList<int> res = new List<int>();
            Dictionary<char, int> table = new Dictionary<char, int>();
            for (int i = 0; i < S.Length; i++)
            {
                if (table.ContainsKey(S[i]))
                {
                    table[S[i]] = i;
                }
                else
                {
                    table.Add(S[i], i);
                }
            }
            int start = 0, end = 0;
            for (int i = 0; i < S.Length; i++)
            {
                end = Math.Max(end, table[S[i]]);
                if (end == i)
                {
                    res.Add(end - start + 1);
                    start = i + 1;
                }
            }
            return res;
        }
    }
}