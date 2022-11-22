using DSA.Tree_Data_Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Assignment_14
{
    public class RecoverBinarySearchTree
    {
        TreeNode first = null;
        TreeNode second = null;
        TreeNode prev = null;

        public void Run()
        {
            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);

            recoverTree(root);
        }

        private void recoverTree(TreeNode root)
        {
            if (root == null)
                return;

            InOrder(root);
            int temp = first.val;
            first.val = second.val;
            second.val = temp;
        }

        private void InOrder(TreeNode root)
        {
            if (root == null)
                return;

            //recursive call for the left subtree
            InOrder(root.left);
            
            if (prev != null && root.val < prev.val)
            {
                if (first == null) first = prev;

                second = root;
            }

            prev = root;

            //## recursive call for the right subtree
            InOrder(root.right);

        }
    }   
}
