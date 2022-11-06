using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Assignment_11
{
    /// <summary>
    /// https://leetcode.com/problems/implement-stack-using-queues/
    /// </summary>
    public class ImplementStackUsingQueue
    {
        Queue<int> queue1;
        Queue<int> queue2;
        int top;
        public void Run()
        {
            ImplementStackUsingQueue obj = new ImplementStackUsingQueue();
            //obj.Push(3);
            //obj.Push(3);
            obj.Push(1);
            obj.Push(2);
            obj.Push(3);

            int param_3 = obj.Top();
            int param_2 = obj.Pop();
            int param_4 = obj.Top();
            //Console.WriteLine("POP: " + param_2);

            Console.WriteLine("Top: " + param_4);
            //bool param_4 = obj.Empty();
            //Console.WriteLine("is Empty: " + param_4);
        }

        public ImplementStackUsingQueue()
        {
            queue1 = new Queue<int>();
            queue2 = new Queue<int>();
        }

        //Time Complexity : O(1)
        public void Push(int x)
        {
            queue1.Enqueue(x);
            top = x;
        }

        //Time Complexity : O(n)
        public int Pop()
        {
            if (Empty())
                return -1;

            int size = queue1.Count;

            while (size > 1)
            {
                top = queue1.Dequeue();
                queue2.Enqueue(top);
                size--;
            }

            var result = queue1.Dequeue();
            var temp = queue1;

            queue1 = queue2;
            queue2 = temp;


            return result;
        }

        //Time Complexity : O(1)
        public int Top()
        {
            return top;
        }

        //Time Complexity : O(1)
        public bool Empty()
        {
            return queue1.Count == 0;
        }
    }
}
