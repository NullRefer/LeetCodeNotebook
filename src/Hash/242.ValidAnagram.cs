using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #242
    /// </summary>
    public class ValidAnagram : IExecute
    {
        public void Execute()
        {
            string s = "rat", t = "car";
            var res = IsAnagram(s, t);
            PrintResult(res);
        }

        void PrintResult(bool res)
        {
            Console.WriteLine("LeetCode #242:");
            System.Console.WriteLine(res);
        }

        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            int[] alphabet = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                alphabet[s[i] - 'a'] += 1;
            }
            for (int i = 0; i < t.Length; i++)
            {
                alphabet[t[i] - 'a'] -= 1;
            }
            return alphabet.All(a => a == 0);
        }
    }
}