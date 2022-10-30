using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Assignment_10
{
    /// <summary>
    /// https://practice.geeksforgeeks.org/problems/given-a-linked-list-of-0s-1s-and-2s-sort-it/1?utm_source=youtube&utm_medium=collab_striver_ytdescription&utm_campaign=given-a-linked-list-of-0s-1s-and-2s-sort-it
    /// Sort 0s, 1s, and 2s in ascending order in Linked List
    /// 4.	Given a linked list of N nodes where nodes can contain values 0s, 1s, and 2s only.
    /// The task is to segregate 0s, 1s, and 2s linked list such that all zeros segregate to the head side, 
    /// 2s at the end of the linked list, and 1s in the mid of 0s and 2s.

    /// </summary>
    public class SortLinkedList
    {
        Node head;
        public void Run()
        {
            InsertAtEnd(1);
            InsertAtEnd(2);
            InsertAtEnd(0);
            InsertAtEnd(1);
            InsertAtEnd(2);
            InsertAtEnd(1);
            InsertAtEnd(0);
            InsertAtEnd(0);
            InsertAtEnd(1);
            InsertAtEnd(2);

            Sort();

            PrintLinkedList();
        }

        public void Sort()
        {
            if (head == null)
                return;

            int count0 = 0, count1 = 0, count2 = 0;

            Node curr = head;

            while (curr != null)
            {
                if (curr.data == 0)
                    count0++;
                else if (curr.data == 2)
                    count2++;
                else
                    count1++;

                curr = curr.next;
            }

            curr = head;

            while (curr != null)
            {
                if (count0 > 0)
                {
                    curr.data = 0;
                    count0--;
                }
                else if (count1 > 0)
                {
                    curr.data = 1;
                    count1--;
                }
                else
                {
                    curr.data = 2;
                    count2--;
                }

                curr = curr.next;
            }
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
