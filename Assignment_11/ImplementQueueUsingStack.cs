using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Assignment_11
{
    /// <summary>
    /// https://leetcode.com/problems/implement-queue-using-stacks/
    /// </summary>
    public class ImplementQueueUsingStack
    {
        Stack<int> stack1 = new Stack<int>();
        Stack<int> stack2 = new Stack<int>();
        int peek;
        public void Run()
        {
            ImplementQueueUsingStack obj = new ImplementQueueUsingStack();
            obj.Push(1);
            obj.Push(2);
            obj.Push(3);
            obj.Push(4);


            int param_2 = obj.Pop();
            Console.WriteLine("Pop: " + param_2);

            obj.Push(5);

            int param_2_ = obj.Pop();
            Console.WriteLine("Pop: " + param_2_);

            int param_3 = obj.Peek();
            Console.WriteLine("Peek: " + param_3);

            bool param_4 = obj.Empty();
            Console.WriteLine("Is Empty: " + param_4);
        }


        //Time Complexity : O(1)
        public void Push(int x)
        {
            if (Empty()) peek = x;

            stack1.Push(x);
        }

        //Time Complexity : O(n)
        public int Pop()
        {
            if (Empty()) return int.MinValue;

            int size = stack1.Count;

            while (size > 1)
            {
                peek = stack1.Pop();
                stack2.Push(peek);

                size--;
            }

            var res = stack1.Pop();

            size = stack2.Count;

            while (size > 0)
            {
                stack1.Push(stack2.Pop());
                size--;
            }

            return res;
        }

        //Time Complexity : O(1)
        public int Peek()
        {
            if (!Empty())
                return peek;

            return int.MinValue;
        }

        //Time Complexity : O(1)
        public bool Empty()
        {
            return stack1.Count == 0;
        }

    }
}
