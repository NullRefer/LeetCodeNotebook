using System.Collections.Generic;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #204
    /// </summary>
    public class CountPrimes : IExecute
    {
        public void Execute()
        {
            var res = CountPrime(10);
            PrintResult(res);
        }

        private void PrintResult(int res)
        {
            System.Console.WriteLine("LeetCode #204: ");
            System.Console.WriteLine(res);
        }

        public int CountPrime(int n)
        {
            int[] a = new int[n + 1];
            int count = 0;
            for (int i = 2; i < n; i++)
                a[i] = 1;

            for (int i = 2; i < n; i++)
                if (a[i] != 0)
                {
                    count++;
                    for (int j = 2 * i; j < n; j += i)
                        a[j] = 0;
                }

            return count;
        }
    }
}