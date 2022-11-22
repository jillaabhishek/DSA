using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Assignment_14
{
    public class LCAOfBinarySearchTree
    {
        TreeNode currentLCA = null;
        int min_Val = 0;
        int max_Val = 0;
        public void Run()
        {
            //var root = new TreeNode(3);
            //root.left = new TreeNode(1);
            //root.right = new TreeNode(4);
            ////root.left.left = new TreeNode(2);
            //root.left.right = new TreeNode(2);
            ////root.left.left.left = new TreeNode(1);

            var root = new TreeNode(6);
            root.left = new TreeNode(2);
            root.right = new TreeNode(8);
            root.left.left = new TreeNode(0);
            root.left.right = new TreeNode(4);
            root.left.right.left = new TreeNode(3);
            root.left.right.right = new TreeNode(5);

            root.right.left = new TreeNode(7);
            root.right.right = new TreeNode(9);

            var result = LowestCommonAncestor(root, root.left.right.left, root.left.right.right);
        }

        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            currentLCA = root;

            if (p.val > currentLCA.val && q.val > currentLCA.val)
                return LowestCommonAncestor(currentLCA.right, p, q);
            else if (p.val < currentLCA.val && q.val < currentLCA.val)
                return LowestCommonAncestor(currentLCA.left, p, q);
            else
                return currentLCA;
        }

        public TreeNode LowestCommonAncestorApproach_2(TreeNode root, TreeNode p, TreeNode q)
        {
            if (p.val < q.val)
            {
                min_Val = p.val;
                max_Val = q.val;
            }
            else
            {
                min_Val = q.val;
                max_Val = p.val;
            }

            return Approach_2(root);
        }

        private TreeNode Approach_2(TreeNode root)
        {
            if (min_Val <= root.val && root.val <= max_Val)
                return root;
            else if (max_Val < root.val)
                return Approach_2(root.left);
            else
                return Approach_2(root.right);

            //Non-recursion

            //while (true)
            //{
            //    if (min_Val <= root.val && root.val <= max_Val)
            //        return root;
            //    else if (max_Val < root.val)
            //        root = Approach_2(root.left);
            //    else
            //        root = Approach_2(root.right);
            //}
        }
    }
}
