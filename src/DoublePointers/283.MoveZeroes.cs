namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #283
    /// Double Pointers
    /// </summary>
    public class MoveZeroes : IExecute
    {
        public void Execute()
        {
            int[] nums = new[] { 0, 1, 0, 3, 12 };
            Movezeroes(nums);
            PrintResult(nums);
        }

        void PrintResult(int[] res)
        {
            System.Console.WriteLine("Leetcode #283:");
            System.Console.WriteLine(string.Join(",", res));
        }

        public void Movezeroes(int[] nums)
        {
            int fast = 0, slow = 0;
            while (fast < nums.Length)
            {
                if (nums[fast] != 0)
                {
                    nums[slow] = nums[fast];
                    slow += 1;
                }
                fast++;
            }
            while (slow < nums.Length)
            {
                nums[slow++] = 0;
            }
        }
    }
}