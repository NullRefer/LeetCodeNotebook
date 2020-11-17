using System.Collections.Generic;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #402
    /// </summary>
    public class RemoveKDigits : IExecute
    {
        public void Execute()
        {
            string num = "5337";
            int k = 2;
            var res = RemovekDigits(num, k);
            PrintResult(res);
        }

        void PrintResult(string res)
        {
            System.Console.WriteLine("Leetcode #402:");
            System.Console.WriteLine(res);
        }

        public string RemovekDigits(string num, int k)
        {
            if (k >= num.Length)
            {
                return "0";
            }
            var numArr = num.ToList();
            int popTime = 0, index = 0;
            while (popTime < k && index < numArr.Count - 1)
            {
                if (numArr[index] > numArr[index + 1])
                {
                    numArr.RemoveAt(index);
                    popTime += 1;
                    index -= index > 0 ? 1 : 0;
                    continue;
                }
                else
                {
                    index += 1;
                }
            }
            while (popTime < k)
            {
                numArr.RemoveAt(numArr.Count - 1);
                popTime += 1;
            }
            while (numArr[0] == '0' && numArr.Count > 1)
            {
                numArr.RemoveAt(0);
            }
            return new string(numArr.ToArray());
        }
    }
}