using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Assignment_10
{
    //https://leetcode.com/problems/palindrome-linked-list/
    public class PalindromeLinkedList
    {
        Node head;

        public void Run()
        {
            InsertAtEnd(1);
            InsertAtEnd(2);
            InsertAtEnd(2);
            InsertAtEnd(1);

            Console.WriteLine("Is Palindrome: " + IsPalindrome_2());
        }

        //Using Stack data structure

        public bool IsPalindrome_2()
        {
            Stack<int> stack = new Stack<int>();
            
            Node curr = head;
            while (curr != null)
            {
                stack.Push(curr.data);

                curr = curr.next;
            }

            curr = head;

            // In this approach we only loop half the length of stack.
            // Because if half of the stack data matches with the linkedList data. 
            // Then it's palindrome

            for(int i = 0; i <= stack.Count/2; i++)
            {
                if (curr.data == stack.Peek())
                {
                    stack.Pop();
                }
                else
                    return false;

                curr = curr.next;
            }


            // Other Way
            // It will loop all the elment

            //while (curr != null)
            //{
            //    if (curr.data == stack.Peek())
            //    {
            //        stack.Pop();
            //    }

            //    curr = curr.next;
            //}

            return true;
        }


        // Floyd's Detection Algo / Two Pointer Approach
        // Using 2-pointer approach of tortosis and hare
        public bool IsPalindrome()
        {
            Node slow = head;
            Node fast = head;
            Node prev, temp;

            //Iterate for linked list till will reach end
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            //After compleleting the above iteration. 
            //Fast node will be at end of the linked list
            //Slow node will be at middle in of the linked list

            //Now will be reverse the next half of the linked starting from the next node from slow
            prev = slow;
            slow = slow.next;
            prev.next = null;

            while (slow is not null)
            {
                //Getting the next element from linkedlist               
                temp = slow.next;
                //setting slow element next to previous element
                slow.next = prev;
                //storing slow element as previous
                prev = slow;
                //storing next element as slow
                slow = temp;
            }

            //Setting fast node to head and slow to prev node
            fast = head;
            slow = prev;

            // Will iterate linked list and complare fast node data and slow node data
            // at any point both data not equal then will return false.
            // else true;
            while (slow != null)
            {
                if (fast.data != slow.data)
                    return false;

                fast = fast.next;
                slow = slow.next;
            }

            return true;
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
