using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #1030
    /// </summary>
    public class MatrixCellsInDistanceOrder : IExecute
    {
        public void Execute()
        {
            var res = AllCellsDistOrder(2, 3, 1, 2);
            PrintOut(res);
        }

        void PrintOut(int[][] res)
        {
            System.Console.WriteLine("LeetCode #1030: ");
            foreach (var person in res)
            {
                System.Console.Write(string.Join(",", person) + ",");
            }
        }

        public int[][] AllCellsDistOrder(int R, int C, int r0, int c0)
        {
            var orderPointsList = new SortedList<int, List<int[]>>();
            for (var r = 0; r < R; r++)
            {
                for (var c = 0; c < C; c++)
                {
                    var key = Math.Abs(r - r0) + Math.Abs(c - c0);
                    if (!orderPointsList.ContainsKey(key))
                        orderPointsList[key] = new List<int[]>();

                    orderPointsList[key].Add(new int[] { r, c });
                }
            }

            var forReturn = new List<int[]>(R * C);
            foreach (var pointItem in orderPointsList)
                forReturn.AddRange(pointItem.Value);

            return forReturn.ToArray();
        }
    }
}