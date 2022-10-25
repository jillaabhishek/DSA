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
            instance.InsertAtBeginning(instance, 12);
            instance.InsertAtBeginning(instance, 10);
            instance.InsertAtBeginning(instance, 9);
            instance.InsertAtBeginning(instance, 5);
            instance.InsertAtBeginning(instance, 1);
            instance.InsertAtBeginning(instance, 0);

            //Inserting at End
            instance.InsertAtEnd(instance, 50);

            //Inserting in middle 
            instance.InsertAfterNode(instance.head.next, 11);


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
