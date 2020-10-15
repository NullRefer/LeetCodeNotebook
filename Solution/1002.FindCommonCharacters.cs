using System;
using System.Collections.Generic;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #1002
    /// </summary>
    public class FindCommonCharacters : IExecute
    {
        public void Execute()
        {
            string[] A = new string[]
            {
                "acabcddd", "bcbdbcbd", "baddbadb", "cbdddcac", "aacbcccd", "ccccddda", "cababaab", "addcaccd"
            };
            string[] A2 = new string[]
            {
                "bella","label","roller"
            };
            var res = CommonChars(A2);
            PrintResult(res);
        }

        void PrintResult(IList<string> res)
        {
            Console.WriteLine("LeetCode #1002:" + string.Join(",", res));
        }

        public IList<string> CommonChars(string[] A)
        {
            IList<string> res = new List<string>();
            int[] minFreq = new int[26];
            for (int i = 0; i < A[0].Length; i++)
            {
                minFreq[A[0][i] - 'a'] += 1;
            }
            for (int i = 1; i < A.Length; i++)
            {
                int[] tmpFreq = new int[26];
                for (int j = 0; j < A[i].Length; j++)
                {
                    tmpFreq[A[i][j] - 'a'] += 1;
                }
                for (int k = 0; k < minFreq.Length; k++)
                {
                    minFreq[k] = Math.Min(minFreq[k], tmpFreq[k]);
                }
            }
            for (int i = 0; i < minFreq.Length; i++)
            {
                for (int j = 0; j < minFreq[i]; j++)
                {
                    res.Add(((char)(i + 'a')).ToString());
                }
            }
            return res;
        }
    }
}