using DSA.LinkedList_Datatype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Assignment_10
{
    //2. Convert a singly linked list into a circular linked list
    public class ConvertSinglyToCircularLinkedList
    {
        Node head;
        public void Run()
        {
            InsertAtEnd(10);
            InsertAtEnd(20);
            InsertAtEnd(30);
            InsertAtEnd(40);
            InsertAtEnd(50);

            ConvertSinglyToCircular();

            LinkedListCycle linkedListCycle = new LinkedListCycle();

            Console.WriteLine($"Loop Cycle Deteched: {linkedListCycle.DetechLoopCycle(head)}");
        }

        public void ConvertSinglyToCircular()
        {
            Node curr = head;
            while (curr.next != null)
            {
                curr = curr.next;
            }

            curr.next = head.next;
        }

        public void InsertAtEnd(int newElement)
        {
            Node newNode = new Node(newElement);

            if (head is null)
            {
                head = newNode;
                return;
            }

            Node temp = head;

            while (temp.next != null)
            {
                temp = temp.next;
            }

            temp.next = newNode;
        }
    }
}
