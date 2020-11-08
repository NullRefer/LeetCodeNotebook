using System;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #122
    /// </summary>
    public class BestTimeToSellBuyStock : IExecute
    {
        public void Execute()
        {
            var stocks = new int[] { 1, 2, 3, 4, 6 };
            var res = MaxProfit(stocks);
            PrintResult(res);
        }

        void PrintResult(int res)
        {
            Console.WriteLine("LeetCode #122:");
            Console.WriteLine(res);
        }

        public int MaxProfit(int[] prices)
        {
            int[] dp = new int[prices.Length];
            dp[0] = 0;
            dp[1] = prices[1] > prices[0] ? prices[1] - prices[0] : 0;
            int minPrice = Math.Min(prices[0], prices[1]);
            for (int i = 2; i < prices.Length; i++)
            {
                dp[i] = Math.Max(dp[i - 1], prices[i] - minPrice);
                minPrice = Math.Min(minPrice, prices[i]);
            }
            return dp[prices.Length - 1];
        }
    }
}