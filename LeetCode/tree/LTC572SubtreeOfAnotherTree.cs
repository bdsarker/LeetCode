using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.tree
{
    internal class LTC572SubtreeOfAnotherTree
    {
        public static void Main(string[] args)
        {
            TreeNode s = new TreeNode(3);
            s.left = new TreeNode(4);
            s.right = new TreeNode(5);
            s.left.left = new TreeNode(1);
            s.left.right = new TreeNode(2);
            TreeNode t = new TreeNode(4);
            t.left = new TreeNode(1);
            t.right = new TreeNode(2);
            Console.WriteLine(new LTC572SubtreeOfAnotherTree().IsSubtree(s, t));
        }

        public bool IsSubtree(TreeNode s, TreeNode t)
        {
            if (s == null && t == null) return true;
            else if (s == null || t == null) return false;
            else if (IsSameTree(s, t)) return true;
            else return IsSubtree(s.left, t) || IsSubtree(s.right, t);
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
