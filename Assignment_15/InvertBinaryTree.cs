using DSA.Tree_Data_Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Assignment_15
{
    //https://leetcode.com/problems/invert-binary-tree/
    public class InvertBinaryTree
    {
        public void Run()
        {
            var root = new TreeNode(4);
            root.left = new TreeNode(2);
            root.right = new TreeNode(7);
            root.left.left = new TreeNode(1);
            root.left.right = new TreeNode(3);
            root.right.left = new TreeNode(6);
            root.right.right = new TreeNode(9);

            PostOrder(root);
        }

        public void PostOrder(TreeNode root)
        {
            if (root != null)
            {
                //recursive call for the left subtree
                PostOrder(root.left);

                //## recursive call for the right subtree
                PostOrder(root.right);

                var temp = root.left;
                root.left = root.right;
                root.right = temp;
            }
        }
    }

    //Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
