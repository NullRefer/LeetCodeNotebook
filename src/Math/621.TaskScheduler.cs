using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #621
    /// </summary>
    public class TaskScheduler : IExecute
    {
        public void Execute()
        {
            var tasks = new char[] { 'A', 'A', 'A', 'B', 'B', 'B', 'C' };
            var res = LeastInterval(tasks, 2);
            PrintResult(res);
        }

        void PrintResult(int res)
        {
            Console.WriteLine("LeetCode #621:");
            System.Console.WriteLine(res);
        }

        public int LeastInterval(char[] tasks, int n)
        {
            if (n == 0)
            {
                return tasks.Length;
            }
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (var task in tasks)
            {
                if (!dict.ContainsKey(task))
                {
                    dict.Add(task, 0);
                }
                dict[task] += 1;
            }
            int maxTask = dict.Values.Max();
            int maxCount = dict.Count(kv => kv.Value == maxTask);
            return Math.Max(tasks.Length, (maxTask - 1) * (n + 1) + maxCount);
        }
    }
}