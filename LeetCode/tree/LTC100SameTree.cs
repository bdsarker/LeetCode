using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.tree
{
    internal class LTC100SameTree
    {
        public static void Main(string[] args)
        {
            TreeNode p = new TreeNode(1);
            p.left = new TreeNode(2);
            p.right = new TreeNode(3);
            TreeNode q = new TreeNode(1);
            q.left = new TreeNode(2);
            q.right = new TreeNode(4);
            Console.WriteLine(new LTC100SameTree().IsSameTree(p, q));
        }

        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null) return true;
         
            else if (p == null || q == null) return false;
            
            else if (p.val != q.val) return false;
            
            else return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
    }
}
