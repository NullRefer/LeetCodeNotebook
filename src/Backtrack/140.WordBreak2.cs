using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #140
    /// Backtracking
    /// </summary>
    public class WordBreak2 : IExecute
    {
        public void Execute()
        {
            string s = "catsanddog";
            IList<string> wordDict = new List<string>()
            {
                "cat", "cats", "and", "sand", "dog"
            };
            var res = WordBreak(s, wordDict);
            PrintResult(res);
        }

        void PrintResult(IList<string> res)
        {
            Console.WriteLine("LeetCode #140:");
            System.Console.WriteLine(string.Join("\n", res));
        }

        Stack<string> sta = new Stack<string>();
        List<string> res = new List<string>();
        public IList<string> WordBreak(string s, IList<string> wordDict)
        {
            int length = s.Length;
            bool[] dp = new bool[length + 1];
            HashSet<string> wordSet = new HashSet<string>(wordDict);
            dp[0] = true;

            for (int i = 1; i <= length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (dp[j] && wordSet.Contains(s[j..i]))
                    {
                        dp[i] = true;
                        break;
                    }
                }
            }

            if (dp[length])
            {
                Backtracking(s, wordSet, dp, length);
            }
            return res;
        }

        private void Backtracking(string s, HashSet<string> wordDict, bool[] dp, int length)
        {
            if (length == 0)
            {
                res.Add(string.Join(" ", sta));
                return;
            }

            for (int i = length - 1; i >= 0; i--)
            {
                string suffix = s[i..length];
                if (wordDict.Contains(suffix) && dp[i])
                {
                    sta.Push(suffix);
                    Backtracking(s, wordDict, dp, i);
                    sta.Pop();
                }
            }
        }
    }
}