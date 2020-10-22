using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #67
    /// string
    /// </summary>
    public class AddBinary : IExecute
    {
        public void Execute()
        {
            string a = "11";
            string b = "1";
            var res = Addbinary(a, b);
            PrintResult(res);
        }

        void PrintResult(string res)
        {
            Console.WriteLine("LeetCode #67:");
            System.Console.WriteLine(res);
        }

        public string Addbinary(string a, string b)
        {
            int[] aArr = new int[a.Length];
            int[] bArr = new int[b.Length];
            List<int> res = new List<int>();
            for (int i = 0; i < a.Length; i++)
            {
                aArr[a.Length - i - 1] = a[i] - '0';
            }
            for (int i = 0; i < b.Length; i++)
            {
                bArr[b.Length - i - 1] = b[i] - '0';
            }
            int p0 = 0, carry = 0;
            while (p0 < aArr.Length && p0 < bArr.Length)
            {
                if (aArr[p0] == 1 && bArr[p0] == 1)
                {
                    if (carry == 1)
                    {
                        res.Add(1);
                    }
                    else
                    {
                        res.Add(0);
                    }
                    carry = 1;
                }
                else if (aArr[p0] == 1 || bArr[p0] == 1)
                {
                    if (carry == 1)
                    {
                        res.Add(0);
                    }
                    else
                    {
                        res.Add(1);
                        carry = 0;
                    }
                }
                else
                {
                    res.Add(carry);
                    carry = 0;
                }
                p0 += 1;
            }
            if (p0 < bArr.Length){
                aArr = bArr;
            }
            while (p0 < aArr.Length)
            {
                if (aArr[p0] == 1)
                {
                    if (carry == 1)
                    {
                        res.Add(0);
                    }
                    else
                    {
                        res.Add(1);
                    }
                }
                else
                {
                    res.Add(carry);
                    carry = 0;
                }
                p0 += 1;
            }
            if (carry == 1)
            {
                res.Add(1);
            }
            res.Reverse();
            return string.Join("", res);
        }
    }
}