using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.tree
{
    internal class LTC1372LongestZigZagPathInBinaryTree
    {
        public int LongestZigZag(TreeNode root)
        {
            if (root == null) return 0;
            return Math.Max(LongestZigZagFrom(root, true,0), LongestZigZagFrom(root, false,0));
        }

        private int LongestZigZagFrom(TreeNode node, bool isLeft, int count)
        {
            if (node == null)
                return count;

            if (isLeft)
                return Math.Max(LongestZigZagFrom(node.left, true, 0), LongestZigZagFrom(node.right, false, count + 1));
            
            return Math.Max(LongestZigZagFrom(node.left, true, count + 1), LongestZigZagFrom(node.right, false, 0));
        }
    }
}
