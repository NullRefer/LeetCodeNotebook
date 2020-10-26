using System;
using System.Collections.Generic;
using System.Reflection;

namespace LeetCodeNotebook
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 1)
            {
                var assembly = Assembly.GetExecutingAssembly();
                var solution = assembly.GetType($"LeetCodeNotebook.{args[0]}");
                var methodInfo = solution.GetMethod("Execute");
                var instance = assembly.CreateInstance($"LeetCodeNotebook.{args[0]}");
                methodInfo.Invoke(instance, null);
            }
            else new PowerOfTwo().Execute();
        }
    }
}
