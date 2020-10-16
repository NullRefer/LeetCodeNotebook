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
            int res = 0;
            for (int i = 0; i < 32; i++)
            {
                var bita = (a >> i) & 1;
                var bitb = (b >> i) & 1;
                var bitc = (c >> i) & 1;
                if (bitc == 0)
                {
                    res += bita + bitb;
                }
                else
                {
                    res += (bita + bitb == 0) ? 1 : 0;
                }
            }
            return res;
        }
    }
}