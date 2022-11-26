using DSA.Tree_Data_Structure;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Assignment_13
{
    /// <summary>
    /// 2.	Implement the function in which given the Binary Tree Inorder and Preorder traversal, 
    /// the result will give the postorder traversal of the tree.
    /// Inorder: DIABCEGHF
    /// Preorder: CDBIAEFGH

    /// </summary>
    public class PostOrderTraversal
    {
        public void Run()
        {
            var preOrder = "CDBIAEFGH";
            var inOrder = "DIABCEGHF";


        }

        public void BuildTree(int[] preorder, int[] inorder)
        {
            int[] binaryTree = new int[preorder.Length];

            for(int i=0; i<preorder.Length; i++)
            {
                binaryTree[i] = preorder[i];

                
            }


            for (int j = 0; j < inorder.Length; j++)
            {

            }
        }

        public void PostOrder(TreeTraversalAlgorithm root, ref string result)
        {
            if (root != null)
            {
                //recursive call for the left subtree
                PostOrder(root.left, ref result);

                //## recursive call for the right subtree
                PostOrder(root.right, ref result);

                //Print
                //Console.WriteLine($"{root.data} ");
                result += root.data + " ";
            }
        }
    }
}
