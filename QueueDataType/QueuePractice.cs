using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueDataType.Queue
{
    internal class QueuePractice
    {
        public void Run()
        {
            Queue<string> q = new Queue<string>();

            ProduceBinaryNumber(10);


            //Deque s = new Deque();
        }

        public void ProduceBinaryNumber(int n)
        {
            Queue<string> binaryNumbers = new Queue<string>();

            binaryNumbers.Enqueue("1");

            for (int i = 0; i < n; i++)
            {
                var front = binaryNumbers.Peek();
                binaryNumbers.Enqueue(front + "0");
                binaryNumbers.Enqueue(front + "1");


                //binaryNumbers.Dequeue();
            }

        }
    }
}
