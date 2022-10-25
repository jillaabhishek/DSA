using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Testing
{
    public class LearnPriorityQueue
    {
        public void Run()
        {
            PriorityQueue<string, int> priorityQueue = new PriorityQueue<string, int>(new IntMaxCompare());

            priorityQueue.Enqueue("John Lennon", 1940);
            priorityQueue.Enqueue("George Harrison", 1943);
            priorityQueue.Enqueue("Paul McCartney", 1942);
            priorityQueue.Enqueue("Ringo Starr1", 1940);
            priorityQueue.Enqueue("Ringo Starr2", 1940);
            priorityQueue.Enqueue("Ringo Starr3", 1940);

            while (priorityQueue.TryDequeue(out string item, out int priority))
                Console.WriteLine($"{item} born in {priority}");
        }
    }

    public class IntMaxCompare : IComparer<int>
    {
        public int Compare(int x, int y) => y.CompareTo(x);
    }
}
