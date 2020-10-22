namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #925
    /// Double Pointers
    /// </summary>
    public class LongPressedName : IExecute
    {
        public void Execute()
        {
            string name = "leelee";
            string typed = "lleeelee";
            var res = IsLongPressedName(name, typed);
            PrintResult(res);
        }

        void PrintResult(bool res)
        {
            System.Console.WriteLine("Leetcode #925:");
            System.Console.WriteLine(res);
        }

        public bool IsLongPressedName(string name, string typed)
        {
            if (typed.Length < name.Length)
            {
                return false;
            }
            int p1 = 0, p2 = 0;
            while (p2 < typed.Length)
            {
                if (p1 < name.Length && name[p1] == typed[p2])
                {
                    p1 += 1;
                    p2 += 1;
                }
                else if (p2 > 0 && typed[p2 - 1] == typed[p2])
                {
                    p2 += 1;
                }
                else
                {
                    return false;
                }
            }
            return p1 == name.Length;
        }
    }
}