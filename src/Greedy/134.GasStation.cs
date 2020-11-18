using System;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #134
    /// </summary>
    public class GasStation : IExecute
    {
        public void Execute()
        {
            var gas = new int[] { 1, 2, 3, 4, 5 };
            var cost = new int[] { 3, 4, 5, 1, 2 };
            var res = CanCompleteCircuit(gas, cost);
            PrintResult(res);
        }

        void PrintResult(int res)
        {
            Console.WriteLine("LeetCode #134:");
            Console.WriteLine(res);
        }

        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
        if (gas.Sum() < cost.Sum())
        {
            return -1;
        }
        int start = 0, rest = 0, run = 0;
        for (int i = 0; i < gas.Length; i++)
        {
            rest += gas[i] - cost[i];
            run += gas[i] - cost[i];
            if (run < 0)
            {
                run = 0;
                start = i + 1;
            }
        }
        return rest < 0 ? -1 : start;
        }
    }
}