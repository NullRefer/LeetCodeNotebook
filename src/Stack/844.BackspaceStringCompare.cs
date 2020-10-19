using System.Collections.Generic;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #844
    /// </summary>
    public class BackspaceStringCompare : IExecute
    {
        public void Execute()
        {
            // string S = "ab#c", T = "ac";
            string S = "ab##", T = "c#d#";
            var res = BackspaceCompare(S, T);
            PrintResult(res);
        }

        void PrintResult(bool res)
        {
            System.Console.WriteLine("Leetcode #844:");
            System.Console.WriteLine(res);
        }

        public bool BackspaceCompare(string S, string T)
        {
            Stack<char> staS = new Stack<char>();
            Stack<char> staT = new Stack<char>();
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == '#')
                {
                    if (staS.Count > 0)
                    {
                        staS.Pop();
                    }
                }
                else
                {
                    staS.Push(S[i]);
                }
            }
            for (int i = 0; i < T.Length; i++)
            {
                if (T[i] == '#')
                {
                    if (staT.Count > 0)
                    {
                        staT.Pop();
                    }
                }
                else
                {
                    staT.Push(T[i]);
                }
            }
            if (staS.Count == staT.Count)
            {
                while (staS.Count > 0)
                {
                    if (staS.Pop() != staT.Pop())
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}