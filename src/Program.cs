using System;
using System.Collections.Generic;

namespace LeetCodeNotebook
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[] { 6, 5, 1, 7, 6, 5, 5, 4, 10, 4 };
            int[] ages = new int[] { 3, 2, 5, 3, 2, 1, 4, 4, 5, 1 };
            var res = BestTeam(scores, ages);
            System.Console.WriteLine(res);
            // new RemoveNthNode().Execute();
        }

        public static int BestTeam(int[] scores, int[] ages)
        {
            int number = scores.Length;
            if (number <= 0)
            {
                return 0;
            }
            int[][] players = new int[number][];
            for (int i = 0; i < number; i++)
            {
                players[i] = new int[] { ages[i], scores[i] };
            }
            Array.Sort(players, (v1, v2) => v2[0] - v1[0]);
            int curMax = players[0][1];
            List<int> curGroups = new List<int>() { 0 };
            for (int i = 1; i < players.Length; i++)
            {
                int confictMax = 0;
                List<int> toRemove = new List<int>();
                foreach (var j in curGroups)
                {
                    if (players[i][0] < players[j][0] && players[i][1] > players[j][1])
                    {
                        confictMax += players[j][1];
                        toRemove.Add(j);
                    }
                }
                if (players[i][1] > confictMax)
                {
                    curMax += players[i][1] - confictMax;
                    curGroups.Add(i);
                    foreach (var j in toRemove)
                    {
                        curGroups.Remove(j);
                    }
                }
            }
            return curMax;
        }
    }
}
