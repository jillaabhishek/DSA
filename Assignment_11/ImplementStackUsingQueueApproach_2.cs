using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Assignment_11
{
    /// <summary>
    /// https://leetcode.com/problems/implement-stack-using-queues/
    /// </summary>
    public class ImplementStackUsingQueueApproach_2
    {
        LinkedList<int> queue1 = new LinkedList<int>();
        int top;
        public void Run()
        {
            ImplementStackUsingQueueApproach_2 obj = new ImplementStackUsingQueueApproach_2();
            //obj.Push(3);
            //obj.Push(3);
            obj.Push(1);
            //obj.Push(2);
            //obj.Push(3);

            int param_3 = obj.Top();
            int param_2 = obj.Pop();
            int param_4 = obj.Top();
            //Console.WriteLine("POP: " + param_2);

            Console.WriteLine("Top: " + param_4);
            //bool param_4 = obj.Empty();
            //Console.WriteLine("is Empty: " + param_4);
        }

        //Time Complexity : O(1)
        void Push(int x)
        {
            queue1.AddFirst(x);
            top = x;
        }

        //Time Complexity : O(1)
        int Pop()
        {
            if (Empty()) return int.MinValue;

            LinkedListNode<int> pop = queue1.First;
            queue1.Remove(pop);

            if (!Empty())
                top = queue1.First.Value;

            return pop.Value;
        }

        //Time Complexity : O(1)
        int Top()
        {
            if (Empty()) return int.MinValue;

            return top;
        }

        //Time Complexity : O(1)
        bool Empty()
        {
            return queue1.Count == 0;
        }
    }
}
