namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #977
    /// Double Pointers
    /// </summary>
    public class SquaresOfSortedArray : IExecute
    {
        public void Execute()
        {
            int[] arr = new[] { -7, -3, 0, 2, 3, 11 };
            var res = SortedSquares(arr);
            PrintResult(res);
        }

        void PrintResult(int[] arr)
        {
            System.Console.WriteLine("Leetcode #977:");
            System.Console.WriteLine(string.Join(",", arr));
        }

        public int[] SortedSquares(int[] A)
        {
            int left = 0, right = A.Length - 1;
            int[] res = new int[A.Length];
            int cur = A.Length - 1;
            while (right >= left && cur >= 0)
            {
                int ls = A[left] * A[left];
                int rs = A[right] * A[right];
                if (ls >= rs)
                {
                    res[cur--] = ls;
                    left += 1;
                }
                else
                {
                    res[cur--] = rs;
                    right -= 1;
                }
            }
            return res;
        }
    }
}