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
            if (n <= 1)
            {
                return 0;
            }
            var res = GeneratePrime(n);
            return res.Count();
        }

        private IEnumerable<int> GeneratePrime(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    System.Console.WriteLine(i);
                    yield return i;
                }
            }
        }

        private bool IsPrime(int n)
        {
            if (n == 1)
            {
                return false;
            }
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}