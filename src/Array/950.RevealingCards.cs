using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #950
    /// </summary>
    public class RevealingCards : IExecute
    {
        public void Execute()
        {
            int[] deck = new[] { 17, 13, 11, 2, 3, 5, 7 };
            var res = DeckRevealedIncreasing(deck);
            PrintResult(res);
        }

        void PrintResult(int[] res)
        {
            Console.WriteLine("LeetCode #38:");
            System.Console.WriteLine(string.Join(",", res));
        }

        public int[] DeckRevealedIncreasing(int[] deck)
        {
            Array.Sort(deck);
            List<int> res = new List<int>();
            for (int i = deck.Length - 1; i >= 0; i--)
            {
                if (res.Count > 0)
                {
                    res.Insert(0, res[res.Count - 1]);
                    res.RemoveAt(res.Count - 1);
                }
                res.Insert(0, deck[i]);
            }
            return res.ToArray();
        }
    }
}