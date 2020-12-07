using System;
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

        public static void PreOrderTravel(this TreeNode root, Action<TreeNode> action = null)
        {
            if (root == null)
            {
                return;
            }
            if (action == null)
            {
                action = root => System.Console.WriteLine(root.val);
            }
            var stack = new Stack<TreeNode>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                root = stack.Pop();
                action(root);
                if (root.right != null)
                {
                    stack.Push(root.right);
                }
                if (root.left != null)
                {
                    stack.Push(root.left);
                }
            }
        }

        public static void InOrderTravel(this TreeNode root, Action<TreeNode> action = null)
        {
            if (root == null)
            {
                return;
            }
            if (action == null)
            {
                action = root => System.Console.WriteLine(root.val);
            }
            var stack = new Stack<TreeNode>();
            while (stack.Count > 0 || root != null)
            {
                if (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }
                else
                {
                    root = stack.Pop();
                    action(root);
                    root = root.right;
                }
            }
        }

        public static void PostOrderTravel(this TreeNode root, Action<TreeNode> action = null)
        {
            if (root == null)
            {
                return;
            }
            if (action == null)
            {
                action = root => System.Console.WriteLine(root.val);
            }
            var stack = new Stack<TreeNode>();
            List<TreeNode> nodes = new List<TreeNode>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                root = stack.Pop();
                nodes.Add(root);
                if (root.left != null)
                {
                    stack.Push(root.left);
                }
                if (root.right != null)
                {
                    stack.Push(root.right);
                }
            }
            for (int i = nodes.Count - 1; i >= 0; i--)
            {
                action(nodes[i]);
            }
        }
    }
}