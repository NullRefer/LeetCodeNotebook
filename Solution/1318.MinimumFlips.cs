using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #1318
    /// </summary>
    public class MinimumFlips : IExecute
    {
        public void Execute()
        {
            int a = 8, b = 3, c = 5;
            var res = MinFlips(a, b, c);
            PrintResult(res);
        }

        void PrintResult(int res)
        {
            Console.WriteLine("LeetCode #1318:" + $"{res}");
        }

        public int MinFlips(int a, int b, int c)
        {
            string aStr = a.ToString("B8");
            string bStr = b.ToString("B8");
            string cStr = c.ToString("B8");
            int res = 0;
            for (int i = 0; i < cStr.Length; i++)
            {
                if (cStr[i] == '0')
                {
                    if (aStr[i] == '1' && bStr[i] == '1')
                    {
                        res += 2;
                    }
                    else if (aStr[i] == '1' || bStr[i] == '1')
                    {
                        res += 1;
                    }
                }
                else
                {
                    if (aStr[i] == '0' && bStr[i] == '0')
                    {
                        res += 1;
                    }
                }
            }
            return res;
        }
    }
}