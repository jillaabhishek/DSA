using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Assignment_10
{
    /// <summary>
    /// https://leetcode.com/problems/palindrome-linked-list/
    /// Floyd's Detection Algo / Two Pointer Approach
    /// Explaination: There will two pointer (Tortoise & hare)
    /// Tortoise will take 1 step at a time & Hare will take 2 steps at a time
    /// If Tortoise & Hare meet at it's a loop cycle
    /// </summary>
    public class LinkedListCycle
    {
        Node head;

        public void Run()
        {
            InsertAtEnd(10);
            InsertAtEnd(20);
            InsertAtEnd(30);
            InsertAtEnd(40);
            InsertAtEnd(50);

            //Creating a loop Cycle
            head.next.next.next.next = head;

            Console.WriteLine("Is Loop Cycle Deteched: " + DetechLoopCycle());
        }

        public bool DetechLoopCycle()
        {
            Node t = head;
            Node h = head;

            while (t != null && h != null && h.next != null)
            {                
                t = t.next;
                h = h.next.next;

                if (t == h)
                    return true;
            }

            return false;
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
