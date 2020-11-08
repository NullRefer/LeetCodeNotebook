using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #319
    /// </summary>
    public class BulbSwitcher : IExecute
    {
        public void Execute()
        {
            var res = BulbSwitch(5);
            PrintResult(res);
        }

        void PrintResult(int res)
        {
            Console.WriteLine("LeetCode #319:");
            System.Console.WriteLine(res);
        }

        public int BulbSwitch(int n)
        {
            return (int)Math.Floor(Math.Sqrt(n));
        }
    }
}