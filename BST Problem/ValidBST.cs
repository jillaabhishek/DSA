using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.BST_Problem
{
    public class ValidBST
    {
        public void Run()
        {
            var root = new TreeNode(1);
            root.left = new TreeNode(1);
            //root.right = new TreeNode(3);
            //root.left.left = new TreeNode(1);
            //root.left.right = new TreeNode(3);
            //root.right.left = new TreeNode(6);
            //root.right.right = new TreeNode(9);

            IsValidBST(root);

            //Console.WriteLine(IsValidBST_Approach2(root, new TreeNode()));
        }


        //Approach 2 failed when tree node have duplicate values
        public bool IsValidBST_Approach2(TreeNode root, TreeNode prev)
        {
            if (root == null) return true;

            bool left = IsValidBST_Approach2(root.left, prev);

            if (prev != null && root.val <= prev.val)
                return false;

            prev = root;

            bool right = IsValidBST_Approach2(root.right, prev);

            if (left && right)
                return true;


            return false;
        }

        public bool IsValidBST(TreeNode root)
        {
            if (root == null)
                return true;

            List<int> res = new List<int>();

            InOrderTravesal(root, res);

            for (int i = 0; i < res.Count - 1; i++)
            {
                if (res[i] >= res[i + 1])
                    return false;

            }

            return true;
        }

        public void InOrderTravesal(TreeNode root, List<int> res)
        {
            if (root.left != null)
                InOrderTravesal(root.left, res);

            res.Add(root.val);

            if (root.right != null)
                InOrderTravesal(root.right, res);

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
