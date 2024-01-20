using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.tree
{
    internal class LTC543DiameterOfBinaryTree
    {
        int max = 0;

        public static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);
            root.left.right.right = new TreeNode(6);

            Console.WriteLine(new LTC543DiameterOfBinaryTree().DiameterOfBinaryTree(root));
        }
        public int DiameterOfBinaryTree(TreeNode root)
        {
            this.Helper(root);
            return max;
        }

        public int Helper(TreeNode root)
        {
            if (root == null) return 0;
            
            int left = this.Helper(root.left);
            int right = this.Helper(root.right);

            max = Math.Max(max, left + right);
            return Math.Max(left, right) + 1;
        }

    }
}
