namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #392
    /// Double Pointers
    /// </summary>
    public class IsSubsequence : IExecute
    {
        public void Execute()
        {
            string s = "abc", t = "abskjfc";
            var res = Issubsequence(s, t);
            PrintResult(res);
        }

        void PrintResult(bool res)
        {
            System.Console.WriteLine("Leetcode #392:");
            System.Console.WriteLine(res);
        }

        public bool Issubsequence(string s, string t)
        {
            int p1 = 0, p2 = 0;
            while (p2 < t.Length && p1 < s.Length)
            {
                if (s[p1] == t[p2])
                {
                    p1 += 1;
                    p2 += 1;
                }
                else
                {
                    p2 += 1;
                }
            }
            return p1 == s.Length;
        }
    }
}