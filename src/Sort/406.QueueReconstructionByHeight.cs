using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #406
    /// </summary>
    public class QueueReconstructionByHeight : IExecute
    {
        public void Execute()
        {
            int[][] people = new int[][]
            {
                new int[] { 7, 0 },
                new int[] { 4, 4 },
                new int[] { 7, 1 },
                new int[] { 5, 0 },
                new int[] { 6, 1 },
                new int[] { 5, 2 },
            };
            var res = ReconstructQueue(people);
            PrintOut(res);
        }

        void PrintOut(int[][] res)
        {
            System.Console.WriteLine("LeetCode #406: ");
            foreach (var person in res)
            {
                System.Console.Write(string.Join(",", person) + ",");
            }
        }

        public int[][] ReconstructQueue(int[][] people)
        {
        var comparer = Comparer<int[]>.Create((int[] p1, int[] p2) =>
        {
            if (p1[0] != p2[0])
            {
                return p2[0].CompareTo(p1[0]);
            }
            else
            {
                return p1[1].CompareTo(p2[1]);
            }
        });
        Array.Sort(people, comparer);
        List<int[]> res = new List<int[]>();
        foreach (var person in people)
        {
            res.Insert(person[1], person);
        }
        return res.ToArray();
        }
    }
}