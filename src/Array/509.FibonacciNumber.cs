using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #509
    /// </summary>
    public class FibonacciNumber : IExecute
    {
        public void Execute()
        {
            var res = Fib(5);
            PrintResult(res);
        }

        void PrintResult(int res)
        {
            Console.WriteLine("LeetCode #509:");
            System.Console.WriteLine(res);
        }

        public int Fib(int N)
        {
            if (N <= 1)
            {
                return N;
            }
            int[] fibs = new int[N + 1];
            fibs[0] = 0;
            fibs[1] = 1;
            for (int i = 2; i <= N; i++)
            {
                fibs[i] = fibs[i - 1] + fibs[i - 2];
            }
            return fibs[N];
        }
    }
}