using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Assignment_10
{
    //https://leetcode.com/problems/remove-nth-node-from-end-of-list/submissions/
    //Given the head of a linked list, remove the nth node from the end of the list and return its head.
    public class RemoveNthNodeFromLinkedList
    {
        Node head;
        public void Run()
        {
            InsertAtEnd(1);
            InsertAtEnd(2);
            InsertAtEnd(3);
            InsertAtEnd(4);
            InsertAtEnd(5);

            //Revering the current linked list
            ReverseLinkedList();

            int nthNode = 2;

            //ilterate for nthNode number of times. 
            //Remove the element and update previous node pointer
            RemoveNthNode(nthNode);

            //Again reverse the linked list and return
            ReverseLinkedList();

            
            PrintLinkedList();
        }

        public Node RemoveNthNode(int nthNode)
        {
            //
            Node curr = head;
            Node prev = null;

            for (int i = 1; i <= nthNode; i++)
            {
                if (curr != null)
                {
                    if (i == nthNode)
                    {
                        if (prev == null)
                        {
                            head = curr.next;
                        }
                        else
                        {
                            prev.next = curr.next;
                        }                        

                        return head;
                    }

                    prev = curr;
                    curr = curr.next;
                }                
            }

            return head;
        }

        public Node ReverseLinkedList()
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

            return head;
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
