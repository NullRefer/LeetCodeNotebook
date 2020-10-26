namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #202
    /// </summary>
    public class HappyNumber : IExecute
    {
        public void Execute()
        {
            var res = IsHappy(19);
            PrintResult(res);
        }

        private void PrintResult(bool res)
        {
            System.Console.WriteLine("LeetCode #202: ");
            System.Console.WriteLine(res);
        }

        private bool IsHappy(int n)
        {
            while (true)
            {
                n = Helper(n);
                if (n == 1)
                {
                    return true;
                }
                if (n == 4)
                {
                    return false;
                }
            }
        }

        private int Helper(int n)
        {
            int sum = 0;
            while (n > 0 || n / 10 != 0)
            {
                sum += (n % 10) * (n % 10);
                n /= 10;
            }
            return sum;
        }
    }
}