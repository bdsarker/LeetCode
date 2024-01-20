using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.tree
{
    internal class LTC872LeafSimilarTree
    {
        // Write a Main method here to test your solution
        public static void Main(string[] args)
        {
            var root1 =                     new TreeNode(3, 
                                new TreeNode(5, 
                            new TreeNode(6), new TreeNode(2, 
                                                new TreeNode(7), new TreeNode(4)
                                                )
                            ), 
                                
                                new TreeNode(1, 
                                    new TreeNode(9), new TreeNode(8)
                                )
                       );
            var root2 = new TreeNode(3, new TreeNode(5, new TreeNode(6), new TreeNode(7)), new TreeNode(1, new TreeNode(4), new TreeNode(2, new TreeNode(9), new TreeNode(8))));
            
            var result = new LTC872LeafSimilarTree().LeafSimilar(root1, root2);
            
            Console.WriteLine(result);
            Console.ReadLine();
        }


        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            var leaf1 = new List<int>();
            var leaf2 = new List<int>();
            
            GetLeaf(root1, leaf1);
            GetLeaf(root2, leaf2);
            
            return leaf1.SequenceEqual(leaf2);
        }

        private void GetLeaf(TreeNode root, List<int> leaf)
        {
            if (root == null)
            {
                return;
            }
            if (root.left == null && root.right == null)
            {
                leaf.Add(root.val);
            }

            GetLeaf(root.left, leaf);
            GetLeaf(root.right, leaf);
        }
    }
}
