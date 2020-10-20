using System.Collections.Generic;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #91
    /// Dynamic Programming
    /// </summary>
    public class DecodeWays : IExecute
    {
        public void Execute()
        {
            var res = NumDecodings("226");
            PrintResult(res);
        }

        void PrintResult(int count)
        {
            System.Console.WriteLine("Leetcode #91:");
            System.Console.WriteLine(count);
        }

        public int NumDecodings(string s)
        {
            int length = s.Length;
            int[] dp = new int[length];
            if (s[0] == '0')
            {
                return 0;
            }
            dp[0] = 1;
            for (int i = 1; i < length; i++)
            {
                int val = int.Parse(s[(i - 1)..(i + 1)]);
                bool canFormAlpha = (val >= 10) && (val <= 26);
                if (s[i] == '0')
                {
                    if (canFormAlpha)
                    {
                        dp[i] = i >= 2 ? dp[i - 2] : 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    if (canFormAlpha)
                    {
                        dp[i] = dp[i - 1] + (i >= 2 ? dp[i - 2] : 1);
                    }
                    else
                    {
                        dp[i] = dp[i - 1];
                    }
                }
            }
            return dp[length - 1];
        }
    }
}