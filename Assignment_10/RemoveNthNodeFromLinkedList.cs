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

            int nthNode = 1;

            //Bruete Force Approach
            //ilterate for nthNode number of times. 
            //Remove the element and update previous node pointer
            //RemoveNthNode(nthNode);


            //Approach 2
            Console.WriteLine("Approach 2");
            RemoveNthNodeApproach2(nthNode);

            PrintLinkedList();

            Console.WriteLine("\nApproach 3");
            RemoveNthNodeApproach3(nthNode);

            PrintLinkedList();
        }


        public Node RemoveNthNodeApproach2(int nthNode)
        {
            Node dummyNode = new Node(0);
            dummyNode.next = head;

            Node first = dummyNode;
            Node second = dummyNode;


            for (int i = 0; i <= nthNode; i++)
            {
                first = first.next;
            }

            while (first != null)
            {
                first = first.next;
                second = second.next;
            }

            second.next = second.next.next;

            return dummyNode.next;
        }

        public Node RemoveNthNodeApproach3(int nthNode)
        {
            int length = 0;
            Node temp = head;

            while (temp != null)
            {
                length++;
                temp = temp.next;
            }

            length = (length - nthNode) - 1;

            //Node dummyNode = new Node(0);
            //dummyNode.next = head;

            //temp = dummyNode;
            temp = head;

            while (length > 0)
            {
                temp = temp.next;
                length--;
            }

            temp.next = temp.next.next;

            return head;
        }


        //Brute Force approach
        public Node RemoveNthNode(int nthNode)
        {
            //Revering the current linked list
            ReverseLinkedList();

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

            //Again reverse the linked list and return
            ReverseLinkedList();

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
