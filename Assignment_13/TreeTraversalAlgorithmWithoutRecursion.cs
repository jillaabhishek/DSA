using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Assignment_13
{
    /// <summary>
    /// 1.	Implement inOrder, preOrder, and postOrder traversal algorithms already discussed 
    /// in live sessions without using recursion(as you already know implementation using recursion 
    /// is already done in live sessions, so am looking at the code without recursion only, 
    /// if you did the implementation using recursion, your solution will be marked as incorrect)
    /// </summary>
    public class TreeTraversalAlgorithmWithoutRecursion
    {
        int data;
        TreeTraversalAlgorithmWithoutRecursion left = null;
        TreeTraversalAlgorithmWithoutRecursion right = null;

        public TreeTraversalAlgorithmWithoutRecursion()
        {

        }

        public TreeTraversalAlgorithmWithoutRecursion(int data)
        {
            this.data = data;
        }

        public void Run()
        {
            var root = new TreeTraversalAlgorithmWithoutRecursion(1);
            root.left = new TreeTraversalAlgorithmWithoutRecursion(2);
            root.right = new TreeTraversalAlgorithmWithoutRecursion(3);
            root.left.left = new TreeTraversalAlgorithmWithoutRecursion(4);
            root.left.right = new TreeTraversalAlgorithmWithoutRecursion(5);

            root.left.left.left = new TreeTraversalAlgorithmWithoutRecursion(6);
            root.left.left.right = new TreeTraversalAlgorithmWithoutRecursion(7);

            root.left.right.left = new TreeTraversalAlgorithmWithoutRecursion(8);
            root.left.right.right = new TreeTraversalAlgorithmWithoutRecursion(9);

            //Console.WriteLine("PreOrder");
            //string preOrderResult = string.Empty;
            //PreOrder(root, ref preOrderResult);
            //Console.WriteLine(preOrderResult);

            //Console.WriteLine("\n InOrder");
            //string inOrderResult = string.Empty;
            //InOrder(root, ref inOrderResult);
            //Console.WriteLine(inOrderResult);

            Console.WriteLine("\n PostOrder");
            string postOrderResult = string.Empty;
            PostOrder(root, ref postOrderResult);
            Console.WriteLine(postOrderResult);
        }

        public void PreOrder(TreeTraversalAlgorithmWithoutRecursion root, ref string result)
        {
            if (root != null)
            {
                var treeStack = new Stack<TreeTraversalAlgorithmWithoutRecursion>();

                treeStack.Push(root);

                while (treeStack.Count > 0)
                {
                    var top = treeStack.Peek();
                    result += top.data + " ";
                    treeStack.Pop();

                    if (top.right != null)
                        treeStack.Push(top.right);
                    if (top.left != null)
                        treeStack.Push(top.left);
                }
            }
        }

        public void InOrder(TreeTraversalAlgorithmWithoutRecursion root, ref string result)
        {
            if (root != null)
            {
                var treeStack = new Stack<TreeTraversalAlgorithmWithoutRecursion>();
                var currentNode = root;

                while (currentNode != null || treeStack.Count > 0)
                {
                    if (currentNode != null)
                    {
                        treeStack.Push(currentNode);
                        currentNode = currentNode.left;
                    }
                    else
                    {
                        var poppedItem = treeStack.Peek();
                        result += treeStack.Pop().data + " ";

                        currentNode = poppedItem.right;
                    }
                }
            }
        }

        public void PostOrder(TreeTraversalAlgorithmWithoutRecursion root, ref string result)
        {
            if (root != null)
            {
                var treeStack = new Stack<TreeTraversalAlgorithmWithoutRecursion>();
                var treeStack2 = new Stack<TreeTraversalAlgorithmWithoutRecursion>();
                var currentNode = root;

                treeStack.Push(currentNode);

                while (treeStack.Count > 0)
                {
                    currentNode = treeStack.Pop();

                    treeStack2.Push(currentNode);

                    if (currentNode.left != null)
                        treeStack.Push(currentNode.left);

                    if (currentNode.right != null)
                        treeStack.Push(currentNode.right);
                }

                while (treeStack2.Count > 0)
                {
                    var res = treeStack2.Pop();

                    result += res.data + " ";
                }
            }
        }
    }
}
