using System.Collections.Generic;

namespace LeetCodeNotebook
{
    public class TreeNode
    {
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public int val;
        public TreeNode left;
        public TreeNode right;

    }

    public static class TreeNodeExtension
    {

        public static void PrintOut(this TreeNode root)
        {
            Queue<TreeNode> sta = new Queue<TreeNode>();
            sta.Enqueue(root);
            while (sta.Count != 0)
            {
                root = sta.Dequeue();
                System.Console.Write($"{root.val},");
                if (root.left != null)
                {
                    sta.Enqueue(root.left);
                }
                if (root.right != null)
                {
                    sta.Enqueue(root.right);
                }
            }
        }
    }
}