using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedList_Datatype
{

    public class SingleLinkedList
    {
        internal Node head;

        public void Run()
        {
            SingleLinkedList instance = new SingleLinkedList();

            //Inserting at End
            instance.InsertAtBeginning(instance, 10);
            instance.InsertAtEnd(instance, 20);
            instance.InsertAtEnd(instance, 30);
            instance.InsertAtEnd(instance, 40);
            instance.InsertAtEnd(instance, 50);
            //instance.InsertAtEnd(instance, 0);

            ////Inserting at End
            //instance.InsertAtEnd(instance, 50);

            ////Inserting in middle 
            //instance.InsertAfterNode(instance.head.next, 11);


            //DeleteNode(instance, 3);

            //Console.WriteLine("Number of Count: " + CountNode(instance));

            Console.WriteLine("Search Data is present: " + SearchNode(instance, 11));

            PrintLinkedList(instance);
        }


        public void InsertAtBeginning(SingleLinkedList instance, int element)
        {
            Node new_node = new Node(element);
            new_node.next = instance.head;
            instance.head = new_node;
        }

        public void InsertAtEnd(SingleLinkedList instance, int element)
        {
            Node new_Node = new Node(element);
            Node temp = instance.head;

            while (temp.next != null)
            {
                temp = temp.next;
            }

            temp.next = new_Node;
        }

        public void InsertAfterNode(Node prevNode, int element)
        {
            Node new_Node = new Node(element);
            new_Node.next = prevNode.next;

            prevNode.next = new_Node;
        }

        public void DeleteNode(SingleLinkedList instance, int position)
        {
            Node temp = instance.head;

            if (temp.next is null)
                return;

            for (int i = 0; i < position - 1; i++)
            {
                temp = temp.next;

                if (temp.next is null)
                    return;
            }

            Node tempNextPtr = temp.next.next;
            temp.next = null;
            temp.next = tempNextPtr;
        }

        public int CountNode(SingleLinkedList instance)
        {
            int count = 0;
            Node temp = instance.head;

            while (temp is not null)
            {
                temp = temp.next;
                count++;
            }

            return count;
        }

        public bool SearchNode(SingleLinkedList instance, int expectedData)
        {
            Node temp = instance.head;
            bool isDataPresent = false;

            while (temp is not null)
            {
                if (temp.data == expectedData)
                    return true;
                else
                    temp = temp.next;
            }

            return isDataPresent;
        }

        public void PrintLinkedList(SingleLinkedList instance)
        {
            Node temp = instance.head;

            while (temp != null)
            {
                Console.WriteLine("Element: " + temp.data);
                temp = temp.next;
            }

        }
    }

    public class Node
    {
        internal int data;
        internal Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
}
