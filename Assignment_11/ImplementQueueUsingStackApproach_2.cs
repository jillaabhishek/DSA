using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Assignment_11
{
    /// <summary>
    /// https://leetcode.com/problems/implement-queue-using-stacks/
    /// </summary>
    public class ImplementQueueUsingStackApproach_2
    {
        LinkedList<int> stack = new LinkedList<int>();

        public void Run()
        {
            ImplementQueueUsingStackApproach_2 obj = new ImplementQueueUsingStackApproach_2();
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
            stack.AddFirst(x);
        }

        //Time Complexity : O(1)
        public int Pop()
        {
            var pop = stack.Last;
            if (pop != null)
            {
                stack.Remove(pop);

                return pop.Value;
            }

            return int.MinValue;
        }

        //Time Complexity : O(1)
        public int Peek()
        {
            if (!Empty())
                return stack.Last.Value;

            return int.MinValue;
        }

        //Time Complexity : O(1)
        public bool Empty()
        {
            return stack.Count == 0;
        }
    }
}
