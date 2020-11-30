using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #767
    /// </summary>
    public class ReorgnizeString : IExecute
    {
        public void Execute()
        {
            string s = "aab";
            var res = Reorgnizestring(s);
            PrintOut(res);
        }

        void PrintOut(string res)
        {
            System.Console.WriteLine("LeetCode #767: ");
            System.Console.Write(res);
        }

        public string Reorgnizestring(string S)
        {
        if (S.Length < 2)
        {
            return S;
        }
        int[] alpha = new int[26];
        int max = int.MinValue;
        for (int i = 0; i < S.Length; i++)
        {
            alpha[S[i] - 'a'] += 1;
            if (max < alpha[S[i] - 'a'])
            {
                max = alpha[S[i] - 'a'];
            }
        }
        if (max > (S.Length + 1) / 2)
        {
            return "";
        }
        else
        {
            char[] newString = new char[S.Length];
            int evenId = 0, oddId = 1;
            for (int i = 0; i < alpha.Length; i++)
            {
                char c = (char)('a' + i);
                while (alpha[i] > 0 && oddId < S.Length && alpha[i] <= S.Length / 2)
                {
                    newString[oddId] = c;
                    oddId += 2;
                    alpha[i] -= 1;
                }
                while (alpha[i] > 0 && evenId < S.Length)
                {
                    newString[evenId] = c;
                    evenId += 2;
                    alpha[i] -= 1;
                }
            }
            return new string(newString);
        }
        }
    }
}