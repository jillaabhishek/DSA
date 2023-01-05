using DSA.Assignment_10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Tree_Data_Structure
{
    public class TreeTraversalAlgorithm
    {
        public int data;
        public TreeTraversalAlgorithm left = null;
        public TreeTraversalAlgorithm right = null;

        public TreeTraversalAlgorithm()
        {

        }

        public TreeTraversalAlgorithm(int data)
        {
            this.data = data;
        }

        public void Run()
        {
            var root = new TreeTraversalAlgorithm(1);
            root.left = new TreeTraversalAlgorithm(2);
            root.right = new TreeTraversalAlgorithm(3);
            root.left.left = new TreeTraversalAlgorithm(4);
            root.left.right = new TreeTraversalAlgorithm(5);

            Console.WriteLine("PreOrder");
            string preOrderResult = string.Empty;
            PreOrder(root, ref preOrderResult);
            Console.WriteLine(preOrderResult);

            Console.WriteLine("\n InOrder");
            string inOrderResult = string.Empty;
            InOrder(root, ref inOrderResult);
            Console.WriteLine(inOrderResult);

            Console.WriteLine("\n PostOrder");
            string postOrderResult = string.Empty;
            PostOrder(root, ref postOrderResult);
            Console.WriteLine(postOrderResult);
        }

        public void PreOrder(TreeTraversalAlgorithm root, ref string result)
        {
            if (root != null)
            {
                //Print
                //Console.WriteLine($"{root.data} ");
                result += root.data + " ";

                //recursive call for the left subtree
                PreOrder(root.left, ref result);

                //## recursive call for the right subtree
                PreOrder(root.right, ref result);
            }
        }

        public void InOrder(TreeTraversalAlgorithm root, ref string result)
        {
            if (root != null)
            {
                //recursive call for the left subtree
                InOrder(root.left, ref result);

                //Print
                //Console.WriteLine($"{root.data} ");
                result += root.data + " ";

                //## recursive call for the right subtree
                InOrder(root.right, ref result);
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
