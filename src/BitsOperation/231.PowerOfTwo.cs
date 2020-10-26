using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #231
    /// </summary>
    public class PowerOfTwo : IExecute
    {
        public void Execute()
        {
            var res = IsPowerOfTwo(int.MinValue);
            PrintResult(res);
        }

        void PrintResult(bool res)
        {
            Console.WriteLine("LeetCode #231:");
            System.Console.WriteLine(res);
        }

        public bool IsPowerOfTwo(int n)
        {
            if (n == int.MinValue)
            {
                return false;
            }
            string s = Convert.ToString(n, 2);
            if (s[0] == '1')
            {
                for (int i = 1; i < s.Length; i++)
                {
                    if (s[i] == '1')
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
    }
}