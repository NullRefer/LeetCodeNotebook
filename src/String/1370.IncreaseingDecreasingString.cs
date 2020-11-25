using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #1370
    /// string
    /// </summary>
    public class IncreasingDecreasingString : IExecute
    {
        public void Execute()
        {
            string s = "leetcode";
            var res = SortString(s);
            PrintResult(res);
        }

        void PrintResult(string res)
        {
            Console.WriteLine("LeetCode #1370:");
            System.Console.WriteLine(res);
        }

        public string SortString(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return "";
            }
            int[] nums = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                nums[s[i] - 'a'] += 1;
            }
            StringBuilder sb = new StringBuilder();
            while (sb.Length < s.Length)
            {
                for (int i = 0; i < 26; i++)
                {
                    if (nums[i] > 0)
                    {
                        sb.Append((char)('a' + i));
                        nums[i] -= 1;
                    }
                }
                for (int i = 25; i >= 0; i--)
                {
                    if (nums[i] > 0)
                    {
                        sb.Append((char)('a' + i));
                        nums[i] -= 1;
                    }
                }
            }
            return sb.ToString();
        }
    }
}