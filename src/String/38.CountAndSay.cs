using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #38
    /// string
    /// </summary>
    public class CountandSay : IExecute
    {
        public void Execute()
        {
            var res = CountAndSay(5);
            PrintResult(res);
        }

        void PrintResult(string res)
        {
            Console.WriteLine("LeetCode #38:" + res);
        }

        public string CountAndSay(int n)
        {
            if (n == 1)
            {
                return "1";
            }
            StringBuilder sb = new StringBuilder();
            string pre = "1";
            for (int i = 1; i < n; i++)
            {
                int count = 1;
                int number = pre[0] - '0';
                for (int j = 1; j < pre.Length; j++)
                {
                    if (number != pre[j] - '0')
                    {
                        sb.Append($"{count}{number}");
                        number = pre[j] - '0';
                        count = 1;
                    }
                    else
                    {
                        count += 1;
                    }
                }
                sb.Append($"{count}{number}");
                pre = sb.ToString();
                sb.Clear();
            }
            return pre;
        }
    }
}