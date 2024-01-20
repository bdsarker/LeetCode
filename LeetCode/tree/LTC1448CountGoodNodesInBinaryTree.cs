using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.tree
{
    internal class LTC1448CountGoodNodesInBinaryTree
    {
        public int GoodNodes(TreeNode root)
        {
            return GoodNodes(root, int.MinValue);
        }

        private int GoodNodes(TreeNode root, int max)
        {
            if (root == null)
            {
                return 0;
            }

            int count = 0;
 
            if (root.val >= max)
            {
                count++;
                max = root.val;
            }

            count += GoodNodes(root.left, max);
            count += GoodNodes(root.right, max);

            return count;
        }
    }
}
