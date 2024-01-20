using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.tree
{
    internal class LTC226InvertBinaryTree
    {

        public static void Main(string[] args)
        {
            var root = new TreeNode(4);
            root.left = new TreeNode(2);
            root.right = new TreeNode(7);
            root.left.left = new TreeNode(1);
            root.left.right = new TreeNode(3);
            root.right.left = new TreeNode(6);
            root.right.right = new TreeNode(9);

            var result = new LTC226InvertBinaryTree().InvertTree(root);
            //Console.WriteLine(result);
            // print the binary tree in order
            Console.WriteLine("In order traversal of binary tree is ");
            printInOrder(result);

        }
        
        // A utility function to do inorder traversal of BST
        static void printInOrder(TreeNode root)
        {
            if (root != null)
            {
                printInOrder(root.left);
                Console.WriteLine(root.val);
                printInOrder(root.right);
            }
        }

        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return null;

            var temp = root.left;
            root.left = root.right;
            root.right = temp;

            InvertTree(root.left);
            InvertTree(root.right);

            return root;
        }
    }
}
