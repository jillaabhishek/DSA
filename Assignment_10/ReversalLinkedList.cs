using DSA.LinkedList_Datatype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Assignment_10
{
    //https://leetcode.com/problems/reverse-linked-list/
    public class ReversalLinkedList
    {
        internal Node head;

        public Node Run()
        {
            InsertAtEnd(10);
            InsertAtEnd(20);
            InsertAtEnd(30);
            InsertAtEnd(40);
            InsertAtEnd(50);

            Console.WriteLine(" *********** Linked List Before Reversal: *********** ");
            PrintLinkedList();

            ReverseLinkedList();

            Console.WriteLine("");
            Console.WriteLine("************ Linked List After Reversal: ************ ");
            PrintLinkedList();

            return head;

        }

        public void ReverseLinkedList()
        {
            Node current = head;
            Node prev = null;

            while (current is not null)
            {                
                //Getting the next element from linkedlist               
                Node next = current.next;

                //setting current element next to previous element
                current.next = prev;

                //storing current element as previous
                prev = current;

                //storing next element as current
                current = next;
            }

            head = prev;
        }

        public void InsertAtEnd(int element)
        {
            //Creating a new node 
            Node new_Node = new Node(element);

            //In the first case, When head is null
            if (head is null)
            {
                head = new_Node;
                return;
            }

            //Assigning the head to temp for iteration
            Node temp = head;

            // loop will stop once we hit the last element, which will have next pointer as none
            // because it's a singly linkedlist
            while (temp.next is not null)
            {
                temp = temp.next;
            }

            //assigning
            temp.next = new_Node;
        }

        public void PrintLinkedList()
        {
            Node temp = head;

            while (temp != null)
            {
                Console.WriteLine("Element: " + temp.data);
                temp = temp.next;
            }

        }
    }    
}
