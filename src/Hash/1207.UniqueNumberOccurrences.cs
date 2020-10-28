using System;
using System.Collections.Generic;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #1207
    /// </summary>
    public class UniqueNumberOccurrences : IExecute
    {
        public void Execute()
        {
            var arr = new int[] { -3, 0, 1, -3, 1, 1, 1, -3, 10, 0 };
            var res = UniqueOccurrences(arr);
            PrintResult(res);
        }

        void PrintResult(bool res)
        {
            Console.WriteLine("LeetCode #1207:");
            System.Console.WriteLine(res);
        }

        public bool UniqueOccurrences(int[] arr)
        {
            int[] counter = new int[2000];
            for (int i = 0; i < arr.Length; i++)
            {
                counter[arr[i] + 1000] += 1;
            }
            int[] ccounter = new int[2000];
            for (int i = 0; i < counter.Length; i++)
            {
                if (counter[i] == 0)
                {
                    continue;
                }
                if (ccounter[counter[i]] == 0)
                {
                    ccounter[counter[i]] += 1;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}