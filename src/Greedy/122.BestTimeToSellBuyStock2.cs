using System;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #122
    /// </summary>
    public class BestTimeToSellBuyStock2 : IExecute
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
            int res = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                if (prices[i] < prices[i + 1])
                {
                    res += prices[i + 1] - prices[i];
                }
            }
            return res;
        }
    }
}