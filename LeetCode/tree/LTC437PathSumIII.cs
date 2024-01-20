using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.tree
{
    internal class LTC437PathSumIII
    {
        public int PathSum(TreeNode root, int sum)
        {
            if (root == null) return 0;
            return PathSumFrom(root, sum) + PathSum(root.left, sum) + PathSum(root.right, sum);
        }

        private int PathSumFrom(TreeNode root, int sum)
        {
            if (root == null) return 0;
            return (root.val == sum ? 1 : 0) + PathSumFrom(root.left, sum - root.val) + PathSumFrom(root.right, sum - root.val);
        }
    }
}
